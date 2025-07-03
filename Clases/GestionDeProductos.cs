using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.ComponentModel;
using Dapper;

namespace Gestor_de_inventario.Clases
{
    public class Producto
    {
        [DisplayName("Código")]
        public string G2_Code { get; set; }
        [DisplayName("Nombre")]
        public string G2_Name { get; set; }
        [DisplayName("Categoría")]
        public string G2_Category { get; set; }
        [DisplayName("Precio")]
        public decimal G2_Price { get; set; }
        [DisplayName("Stock")]
        public int G2_Stock { get; set; }
    }
    
    internal class GestionDeProductos
    {
        public static class BaseDeDatos
        {
            public static string Ruta => "Producto.db";
            public static string Conexion => $"Data Source={Ruta};Version=3;";
        }

        private static string Conexion => BaseDeDatos.Conexion;


        public static void CrearTablaSiNoExiste() //Si no hay ningun producto en la tabla
        {
            using (var con = new SQLiteConnection(Conexion))
            {   
                con.Execute(@"CREATE TABLE IF NOT EXISTS Productos (
                            G2_Code TEXT PRIMARY KEY,
                            G2_Name TEXT NOT NULL,
                            G2_Category TEXT NOT NULL,
                            G2_Price REAL NOT NULL,
                            G2_Stock INTEGER NOT NULL 
                        )");
            }
        }

        public static List<Producto> MostrarProductos() //Metodo para mostrar los productos en la tabla
        {
            using (var con = new SQLiteConnection(Conexion))
            {
                int CBD = con.ExecuteScalar<int>("SELECT COUNT(*) FROM Productos");
                if (CBD > 0) return con.Query<Producto>("SELECT * FROM Productos").ToList();
                else return new List<Producto>();
            }
        }
        public static string Codigo() //Metodo para crear automaticamente el codigo del siguiente producto.
        {
            using (var con = new SQLiteConnection(Conexion))
            {
                var ultimo = con.QueryFirstOrDefault<string>(
                               @"SELECT G2_Code FROM Productos 
                               ORDER BY CAST(G2_Code AS INTEGER) DESC 
                               LIMIT 1"
                );
                if (string.IsNullOrEmpty(ultimo))
                    return "001";

                int numero = int.Parse(ultimo);
                numero++;

                return numero.ToString("D3");
            }
        }


        public static bool AgregarProducto(Producto nuevo)
        {
            using (var con = new SQLiteConnection(Conexion))
            {
                //Verificamos is el producto existe
                var existe = con.QueryFirstOrDefault<Producto>(
                    "SELECT * FROM Productos WHERE LOWER(G2_Name) = LOWER(@Nombre)", new { Nombre = nuevo.G2_Name });

                if (existe != null)
                    return false;
                //En caso de no existir lo registramos. 
                con.Execute("INSERT INTO Productos (G2_Code, G2_Name, G2_Category, G2_Price, G2_Stock) VALUES (@G2_Code, @G2_Name, @G2_Category, @G2_Price, @G2_Stock)", nuevo);
                return true;
            }
        }

        public static List<Producto> Buscar(string texto)
        {
            //Nos conectamos a la base de dato y segun lo que se escriba se van mostrando productos relacionados 
            using (var con = new SQLiteConnection(Conexion))
            {
                string consulta = @"SELECT * FROM Productos 
                                WHERE G2_Code LIKE @txt OR
                                      LOWER(G2_Name) LIKE @txt OR 
                                      LOWER(G2_Category) LIKE @txt OR 
                                      G2_Price LIKE @txt OR
                                      G2_Stock LIKE @txt";
                return con.Query<Producto>(consulta, new { txt = "%" + texto.ToLower() + "%" }).ToList();
            }
        }

        public static bool EliminarProducto(string nombre)
        {
            //Nos conectamos a la base de datos y borramos el producto seleccionado
            using (var con = new SQLiteConnection(Conexion))
            {
                int filasAfectadas = con.Execute("DELETE FROM Productos WHERE LOWER(G2_Name) = LOWER(@Nombre)", new { Nombre = nombre });
                return filasAfectadas > 0;
            }
        }

        //Actualizamos el stock de los articulos que se compraron
        public static void ActualizarStock(string codigo, int cantidadVendida)
        {
            using (var con = new SQLiteConnection(Conexion))
            {
                // Actualizamos el stock restando la cantidad vendida
                con.Execute(@"UPDATE Productos 
                      SET G2_Stock = G2_Stock - @Cantidad 
                      WHERE G2_Code = @Codigo",
                            new { Cantidad = cantidadVendida, Codigo = codigo });
            }
        }

        //Actualizar datos por Admin
        public static void ActualizarProducto(Producto actualizado)
        {
            using (var con = new SQLiteConnection(Conexion))
            {
                con.Execute(@"UPDATE Productos 
                      SET G2_Name = @G2_Name, 
                          G2_Category = @G2_Category, 
                          G2_Price = @G2_Price, 
                          G2_Stock = @G2_Stock 
                      WHERE G2_Code = @G2_Code", actualizado);
            }
        }

    }
}

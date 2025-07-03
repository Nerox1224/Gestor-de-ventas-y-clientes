using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data;
using MySql;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.SQLite;
using Dapper;

namespace Gestor_de_inventario.Clases
{
    internal class Cliente
    {
        [DisplayName("Nombre")]
        public string G2_Nombre { get; set; }
        [DisplayName("Apellido")]
        public string G2_Apellido { get; set; }
        [DisplayName("DNI")]
        public int G2_DNI { get; set; }
        [DisplayName("Celular")]
        public int G2_Celular { get; set; }
    }
    internal class GestionDeClientes
    {
        public static class BaseDeDatos
        {
            public static string Ruta => "Cliente.db";
            public static string Conexion => $"Data Source={Ruta};Version=3;";
        }
        private static string Conexion => BaseDeDatos.Conexion;
        public static List<Cliente> MostrarClientes() //Metodo para mostrar los Clientes en la tabla
        {
            using (var con = new SQLiteConnection(Conexion))
            {
                int CBD = con.ExecuteScalar<int>("SELECT COUNT(*) FROM Clients");
                if (CBD > 0) return con.Query<Cliente>("SELECT * FROM Clients").ToList();
                else return new List<Cliente>();
            }
        }
        public static void CrearTablaSiNoExiste() //Si no hay ningun producto en la tabla
        {
            using (var con = new SQLiteConnection(Conexion))//Nos conectamoas con la basededatos
            {
                con.Execute(@"CREATE TABLE IF NOT EXISTS Clients (
                            G2_Nombre TEXT PRIMARY KEY,
                            G2_Apellido TEXT NOT NULL,
                            G2_DNI TEXT NOT NULL,
                            G2_Celular INTEGER NOT NULL 
                        )");
            }
        }

        //Regristo de usuario
        public static bool RegristrarUsuario(Cliente nuevo)
        {
            using (var con = new SQLiteConnection(Conexion))
            {
                var Registrado = con.QueryFirstOrDefault<Cliente>//Verificamos si ecxiste
                    ("SELECT * FROM Clients WHERE G2_DNI = @DNI", new { DNI = nuevo.G2_DNI });
                if (Registrado != null)
                    return false;
                //En caso que no lo creamos y añadimos
                con.Execute("INSERT INTO Clients (G2_Nombre, G2_Apellido, G2_DNI, G2_Celular) VALUES (@G2_Nombre, @G2_Apellido, @G2_DNI, @G2_Celular)", nuevo);
                return true;
            }
        }
        //Verificar Usuario
        public static bool VerificarPorDni(string nombre, string DNI)
        {
            using (var con = new SQLiteConnection(Conexion))
            {   //En caso que haya un dni y nombre ya existentes, existe sera = 1 y por lo tanto se rechaza el registro
                int existe = con.ExecuteScalar<int>(
                    "SELECT COUNT(*) FROM Clients WHERE LOWER(G2_Nombre) = LOWER(@nombre) AND G2_DNI = @DNI",
                    new { nombre, DNI }
                );
                return existe > 0;
            }
        }
        public static List<Cliente> Buscar(string texto)
        {
            //Nos conectamos a la base de dato y segun lo que se escriba se van mostrando productos relacionados 
            using (var con = new SQLiteConnection(Conexion))
            {
                string consulta = @"SELECT * FROM Clients 
                        WHERE LOWER(G2_Nombre) LIKE @txt OR 
                              LOWER(G2_Apellido) LIKE @txt OR 
                              G2_DNI LIKE @txt OR
                              G2_Celular LIKE @txt";
                return con.Query<Cliente>(consulta, new { txt = "%" + texto.ToLower() + "%" }).ToList();
            }
        }

        public static bool EliminarCliente(string nombre)
        {
            //Nos conectamos a la base de datos y borramos el producto seleccionado
            using (var con = new SQLiteConnection(Conexion))
            {
                int filasAfectadas = con.Execute("DELETE FROM Clients WHERE LOWER(G2_Nombre) = LOWER(@Nombre)", new { Nombre = nombre });
                return filasAfectadas > 0;
            }
        }
    }
}

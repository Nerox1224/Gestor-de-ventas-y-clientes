using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_inventario.Clases
{
    internal class CalcularStock
    {
        public class StockPorCategoria
        {
            public string Categoria { get; set; }
            public int StockTotal { get; set; }
        }
        /*public static List<StockPorCategoria> Categoria()
        {
            var productos = GestionDeProductos.MostrarProductos();//Creamos una lista para las categorias
            List<StockPorCategoria> resultado = new List<StockPorCategoria>();
            TotalStock(productos, 0, resultado);//Llamamos al metodo TotalStock
            return resultado;
        }

        private static void TotalStock(List<Producto> productos, int index, List<StockPorCategoria> acumulado)
        {
            if (index >= productos.Count)
                return;

            Producto actual = productos[index];
            StockPorCategoria existente = acumulado.Find(c => c.Categoria.Equals(actual.G2_Category, StringComparison.OrdinalIgnoreCase));

            if (existente != null)//De existir una categoria se le añade su stock según la categoría
            {
                existente.StockTotal += actual.G2_Stock;
            }
            else
            {
                acumulado.Add(new StockPorCategoria//Si el categoria aun no esta se añade y se cuenta la cantidad
                {
                    Categoria = actual.G2_Category,
                    StockTotal = actual.G2_Stock
                });
            }

            TotalStock(productos, index + 1, acumulado);//Terminamos de recorrer la fila y pasamos a la siguiente para repetir el proceso
        }*/
    }
}
using Gestor_de_inventario.Clases;
using MultiHerramientas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_inventario.Formularios
{
    public partial class ViewStock : Form
    {
        public ViewStock(List<Producto> productos)
        {
            InitializeComponent();
            FormHelper.MovePanel(Panel, this);
            VerStockProductos(productos);
        }
        private void MostrarStock()
        {
            /*var StockComplet = CalcularStock.Categoria(); //Obtenemos las categorias
            StringBuilder sb = new StringBuilder();//Creamos un nueo constructor de texto

            foreach (var item in StockComplet)
            {
                //Se leen las categorias y se añaden al constructor de texto
                sb.AppendLine($"{item.Categoria}: {item.StockTotal} unidades");
            }

            VerStock.Text = sb.ToString();//El resultado lo mandamos al textbox'VerStock' para ser visto
            */
        }
        private void VerStockProductos(List<Producto> productos)
        {
            VerStock.Items.Clear();
            foreach(var item in productos)
            {
                string linea = $"{item.G2_Code.PadRight(5)} | {item.G2_Name.PadRight(5)} | Stock: {item.G2_Stock}";
                VerStock.Items.Add(linea);
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

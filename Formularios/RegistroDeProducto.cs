using Gestor_de_inventario.Clases;
using MultiHerramientas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gestor_de_inventario
{
    public partial class RegistroDeProducto : Form
    {
        public RegistroDeProducto()
        {
            InitializeComponent();
            this.Load += RegistroDeProducto_Load;
            FormHelper.MovePanel(panel, this);
        }
        public static event EventHandler ProductoAgregado;
        private void RegProducto_Click(object sender, EventArgs e)
        {
            // Validamos campos vacíos
            if (string.IsNullOrWhiteSpace(Nombre.Text) ||
                string.IsNullOrWhiteSpace(Categoria.Text) ||
                string.IsNullOrWhiteSpace(Precio.Text) ||
                string.IsNullOrWhiteSpace(Stock.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificamos si el formato de cada variable es correcto
            if (!decimal.TryParse(Precio.Text, out decimal precio))
            {
                MessageBox.Show("Precio inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(Stock.Text, out int stock))
            {
                MessageBox.Show("Stock inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Registramos cada variable del nuevo producto
            Producto nuevo = new Producto
            {
                G2_Code = GestionDeProductos.Codigo(),
                G2_Name = Nombre.Text.Trim(),
                G2_Category = Categoria.Text.Trim(),
                G2_Price = precio,
                G2_Stock = stock
            };

            // Intentamos Agregar
            if (GestionDeProductos.AgregarProducto(nuevo))
            {
                MessageBox.Show("Producto registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProductoAgregado?.Invoke(this, EventArgs.Empty);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Ya existe un producto con ese nombre.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarCampos() //Limpiamos los Label
        {
            Nombre.Text = "";
            Categoria.Text = "";
            Precio.Text = "";
            Stock.Text = "";
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();//Cerramos el form
        }
        private List<string> Categorias()
        {
            return GestionDeProductos.MostrarProductos().Select(p => p.G2_Category).Distinct(StringComparer.OrdinalIgnoreCase).ToList();
        }
        private void RegistroDeProducto_Load(object sender, EventArgs e)
        {
            var categorias = Categorias();
            //Creamos una lista de autocompletado y lo configuramos
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            auto.AddRange(categorias.ToArray());

            Categoria.AutoCompleteCustomSource = auto;
            Categoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Categoria.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
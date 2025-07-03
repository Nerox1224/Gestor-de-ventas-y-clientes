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
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
            this.KeyPreview = true;
            FormHelper.MovePanel(Panel, this);//Agregamos al metodo para mover el panel y asi mover el form
            MostrarProductos(GestionDeProductos.MostrarProductos());
            MostrarClientes(GestionDeClientes.MostrarClientes());
            RegistroDeProducto.ProductoAgregado += (s, ev) => ActualizarDataGrid();
            NuevoUsuario.NewUsuario += (s, ev) => ActualizarDataClientes();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void ChangeState_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //tablas de la tienda:
        private void MostrarProductos(List<Producto> productos) //Metodo para actualizar la Tabla
        {
            DataProductos.DataSource = null;
            DataProductos.DataSource = productos;
        }
        private void MostrarClientes(List<Cliente> clientes)
        {
            DataClientes.DataSource = null;
            DataClientes.DataSource = clientes;
        }
        //Metodos para las tablas
        public void ActualizarDataGrid() //Actualizamos el DataGridView al momento de buscar un producto
        {
            string texto = txtBuscar.Text.Trim();
            if (string.IsNullOrEmpty(texto))
                MostrarProductos(GestionDeProductos.MostrarProductos());
            else
                MostrarProductos(GestionDeProductos.Buscar(texto));
        }
        public void ActualizarDataClientes() //Actualizamos la tabla de clientes
        {
            string texto = txtBuscar.Text.Trim();
            if (string.IsNullOrEmpty(texto))
                MostrarClientes(GestionDeClientes.MostrarClientes());
            else
                MostrarClientes(GestionDeClientes.Buscar(texto));
        }
        //Botones para quitar y añadir productos
        private void DelProdructo_Click(object sender, EventArgs e)
        {
            if (DataProductos.CurrentRow != null)
            {  //Se guarda el nombre de la celda seleccionada
                string nombre = DataProductos.CurrentRow.Cells["G2_Name"].Value.ToString();

                //Mostramos un mensaje de confirmación para borrar el producto
                var confirmar = MessageBox.Show($"¿Eliminar el producto \"{nombre}\"?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)//En caso de responder sí
                {
                    if (GestionDeProductos.EliminarProducto(nombre))
                    { //Llamamos al metodo para eliminar un producto
                        MessageBox.Show("Producto eliminado.");//Mostramos un mensaje de confiermación
                        ActualizarDataGrid();//Actualizamos la Tabla
                    }
                    else
                    {  //En caso de error mostramos un mensaje de fallo
                        MessageBox.Show("No se pudo eliminar el producto.");
                    }
                }
            }
        }

        private void AddProducto_Click(object sender, EventArgs e)
        {
            FormHelper.ShowOrActivateForm<RegistroDeProducto>();
        }
        //Botones para quitar y añadir clientes
        private void AddCliente_Click(object sender, EventArgs e)
        {
            FormHelper.ShowOrActivateForm<NuevoUsuario>();
        }

        private void DelCliente_Click(object sender, EventArgs e)
        {
            if (DataClientes.CurrentRow != null)
            {  //Se guarda el nombre de la celda seleccionada
                string nombre = DataClientes.CurrentRow.Cells["G2_Nombre"].Value.ToString();

                //Mostramos un mensaje de confirmación para borrar al cliente
                var confirmar = MessageBox.Show($"¿Eliminar Cliente: \"{nombre}\"?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)//En caso de responder sí
                {
                    if (GestionDeClientes.EliminarCliente(nombre))
                    { //Llamamos al metodo para eliminar un cliente
                        MessageBox.Show("Cliente eliminado.");//Mostramos un mensaje de confiermación
                        ActualizarDataClientes();//Actualizamos la Tabla
                    }
                    else
                    {  //En caso de error mostramos un mensaje de fallo
                        MessageBox.Show("No se pudo eliminar al cliente.");
                    }
                }
            }
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion IS = new IniciarSesion();
            IS.Show();
            this.Close();
        }
        //Barras de busqueda
        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            string G2_texto = txtBuscar.Text;
            var G2_resultados = GestionDeProductos.Buscar(G2_texto);//Guardamos y mandamos el texto escrito
            MostrarProductos(G2_resultados);//Llamamos al metodo MostrarProducto para ver los productos relacionados con el tecto
        }

        private void BuscarCliente_TextChanged(object sender, EventArgs e)
        {
            string G2_texto = BuscarCliente.Text;
            var G2_resultados = GestionDeClientes.Buscar(G2_texto);//Guardamos y mandamos el texto escrito
            MostrarClientes(G2_resultados);//Llamamos al metodo MostrarClientes para ver los productos relacionados
        }

        private void SaveChange_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in DataProductos.Rows)
                {
                    // Ignorar filas nuevas vacías
                    if (row.IsNewRow) continue;

                    var producto = new Producto
                    {
                        G2_Code = row.Cells["G2_Code"].Value?.ToString(),
                        G2_Name = row.Cells["G2_Name"].Value?.ToString(),
                        G2_Category = row.Cells["G2_Category"].Value?.ToString(),
                        G2_Price = Convert.ToDecimal(row.Cells["G2_Price"].Value),
                        G2_Stock = Convert.ToInt32(row.Cells["G2_Stock"].Value)
                    };

                    // Validación básica
                    if (!string.IsNullOrEmpty(producto.G2_Code))
                        GestionDeProductos.ActualizarProducto(producto);
                }

                MessageBox.Show("Cambios guardados correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

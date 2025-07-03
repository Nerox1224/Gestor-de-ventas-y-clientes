using Gestor_de_inventario.Clases;
using Gestor_de_inventario.Formularios;
using MultiHerramientas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Gestor_de_inventario
{
    public partial class Tienda : Form
    {
        public Tienda()
        {
            try
            {
                GestionDeProductos.CrearTablaSiNoExiste();
                InitializeComponent();
                this.KeyPreview = true;
                FormHelper.MovePanel(Panel, this);//Agregamos al metodo para mover el panel y asi mover el form
                MostrarProductos(GestionDeProductos.MostrarProductos());
                RegistroDeProducto.ProductoAgregado += (s, ev) => ActualizarDataGrid();
                txtBuscar.TextChanged += txtBuscar_TextChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //usuario actual.
        string UsuariActual = IniciarSesion.user_nombre; //Capturamos el usuario que ha ingresado
        string DniActual = IniciarSesion.user_dni;
        //Botones base
        private void Cerrar_Click(object sender, EventArgs e) //Botón para cerrar la aplicación
        {
            Application.ExitThread();
        }

        private void ChangeState_Click(object sender, EventArgs e) //Cambio de estado de la ventana
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void minimized_Click(object sender, EventArgs e) //Cambio de estado de ventana 
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //tabla de la tienda:
        private void MostrarProductos(List<Producto> productos) //Metodo para actualizar la Tabla
        {
            DataProductos.DataSource = null;
            DataProductos.DataSource = productos;
        }
        //Metodos para laas tablas
        public void ActualizarDataGrid() //Actualizamos el DataGridView al momento de buscar un producto
        {
            string texto = txtBuscar.Text.Trim();
            if (string.IsNullOrEmpty(texto))
                MostrarProductos(GestionDeProductos.MostrarProductos());
            else
                MostrarProductos(GestionDeProductos.Buscar(texto));
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string G2_texto = txtBuscar.Text;
            var G2_resultados = GestionDeProductos.Buscar(G2_texto);//Guardamos y mandamos el texto escrito
            MostrarProductos(G2_resultados);//Llamamos al metodo MostrarProducto para ver los productos relacionados con el tecto
        }

        //Mostrar el stock total.
        private void StockTotal_Click(object sender, EventArgs e)
        {
            var productos = GestionDeProductos.MostrarProductos();
            FormHelper.ShowOrActivateFormConParametros(() => new ViewStock(productos));
        }


        //Añadir al carro de compras
        //Verificando
        private void Verif()
        {
            var fila = DataProductos.CurrentRow;//Obtenemos la celda y los datos de su fila
            string codigo = fila.Cells["G2_Code"].Value?.ToString();
            string nombre = fila.Cells["G2_Name"].Value?.ToString();
            string precioText = fila.Cells["G2_Price"].Value?.ToString();
            string stock = fila.Cells["G2_Stock"].Value?.ToString();

            decimal precio = 0;
            decimal.TryParse(precioText, out precio);
            int stockDisponible = 0;
            int.TryParse(stock, out stockDisponible);

            using (AddCantidad AddCar = new AddCantidad())//Abrimos la ventana para ingresar la cantidad
            {
                if (AddCar.ShowDialog() == DialogResult.OK)
                {
                    int cantidad = AddCar.G2_cantidad;
                    decimal total = cantidad * precio;
                    // Verificamos si ya está el producto 
                    int index = ventCodigo.Items.IndexOf(codigo);
                    if (cantidad <= stockDisponible)//Verificamos si la cantidad pedida es menor o igual al pedipo por el usuario
                    {
                        if (index >= 0)
                        {
                            // Ya existe, actualizamos la cantidad y el total
                            int cantidadActual = int.Parse(ventCantidad.Items[index].ToString());
                            int nuevaCantidad = cantidadActual + cantidad;
                            decimal nuevoTotal = nuevaCantidad * precio;

                            if (nuevaCantidad > stockDisponible)//Verificamos si la suma de cantidades pedida por el usuario es menor o igual al stock
                            {
                                MessageBox.Show($"No hay suficiente stock para esta cantidad: {nuevaCantidad}", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            ventCantidad.Items[index] = nuevaCantidad.ToString();
                            ventTotal.Items[index] = nuevoTotal.ToString("C");
                            ViewMontoFinal();
                        }
                        else//En caso que el producto aun no sea añadido al carro, lo añadimos como nuevo producto
                        {
                            ventCodigo.Items.Add(codigo);
                            ventNombre.Items.Add(nombre);
                            ventPrecio.Items.Add(precio.ToString("C"));
                            ventCantidad.Items.Add(cantidad.ToString());
                            ventTotal.Items.Add(total.ToString("C"));
                            ViewMontoFinal();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"No hay suficiente stock para esta cantidad: {cantidad}", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }
        //Agregamos los productos ya sea por el boton o la tecla enter
        private void Add_Click(object sender, EventArgs e)
        {
            Verif();
        }
        private void DataProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                Verif();
            }
        }
        //Total a pagar 
        private void ViewMontoFinal()
        {
            decimal totalAPagar = 0;

            foreach (var item in ventTotal.Items)
            {
                string temp = item.ToString();

                // Quitar cualquier símbolo que no sea número, coma o punto, por seguridad
                temp = new string(temp.Where(c => char.IsDigit(c) || c == '.' || c == ',').ToArray());

                if (decimal.TryParse(temp, out decimal valor))
                {
                    totalAPagar += valor;
                }
            }
            PrecioPorPagar.Text = $"Total a pagar: {totalAPagar:N2}";
        }
        //Comprar
        private void Comprar_Click(object sender, EventArgs e)
        {
            GenerarBoleta(DniActual, UsuariActual);
            StockFinal();
            ClearLists();
        }
        //Metodo para modificar el stock de la tabla una vez se realize la venta
        private void StockFinal()
        {
            for (int i = 0; i < ventCodigo.Items.Count; i++)
            {
                string code = ventCodigo.Items[i].ToString();
                int cantidadVendida = int.Parse(ventCantidad.Items[i].ToString());

                // Actualizar tabla
                foreach (DataGridViewRow fila in DataProductos.Rows)
                {
                    if (fila.Cells["G2_Code"].Value?.ToString() == code)
                    {
                        int stockActual = Convert.ToInt32(fila.Cells["G2_Stock"].Value);
                        fila.Cells["G2_Stock"].Value = stockActual - cantidadVendida;
                        break;
                    }
                }

                // Actualizar base de datos
                GestionDeProductos.ActualizarStock(code, cantidadVendida);
            }
        }
        //Cancelar Compra
        private void CancelarCompra_Click(object sender, EventArgs e)
        {
            ClearLists();
            ViewMontoFinal();
        }
        private void ClearLists()//Limpiarmos las listas
        {
            ventCodigo.Items.Clear();
            ventNombre.Items.Clear();
            ventCantidad.Items.Clear();
            ventPrecio.Items.Clear();
            ventTotal.Items.Clear();
        }

        //Generar boletas de venta
        private void GenerarBoleta(string dniCliente, string nameCliente)
        {
            string nombreArchivo = $"Boleta_{dniCliente}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

            // 1. Ruta dentro del proyecto
            string rutaInterna = Path.Combine(Application.StartupPath, "Boletas");
            Directory.CreateDirectory(rutaInterna); // Crea si no existe
            string archivoInterno = Path.Combine(rutaInterna, nombreArchivo);

            // 2. Ruta en el escritorio del usuario
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaEscritorio = Path.Combine(escritorio, "Boletas");
            Directory.CreateDirectory(rutaEscritorio); // Crea si no existe
            string archivoEscritorio = Path.Combine(rutaEscritorio, nombreArchivo);

            // Contenido de la boleta
            string[] contenido = GenerarContenidoBoleta(dniCliente, nameCliente);

            // Guardar archivo en ambas ubicaciones
            File.WriteAllLines(archivoInterno, contenido);
            File.WriteAllLines(archivoEscritorio, contenido);

            MessageBox.Show("Boleta guardada en:\n- Escritorio", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private string[] GenerarContenidoBoleta(string dniCliente, string nameCliente)
        {//Asignamos los productos comprados al cliente generando una boltea
            List<string> lineas = new List<string>();
            lineas.Add("====== BOLETA DE COMPRA ======");
            lineas.Add($"DNI Cliente:     {dniCliente}");
            lineas.Add($"Nombre Cliente:  {nameCliente}");
            lineas.Add($"Fecha:           {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            lineas.Add("");
            lineas.Add("Código    |Nombre                             |Precio        |Cantidad      |Total");

            for (int i = 0; i < ventCodigo.Items.Count; i++)//Recorremos cada item ca cada lista para presentarlos en orden
            {
                string codigo = ventCodigo.Items[i].ToString().PadRight(10);
                string nombre = ventNombre.Items[i].ToString().PadRight(35);
                string precio = ventPrecio.Items[i].ToString().PadRight(14);
                string cantidad = ventCantidad.Items[i].ToString().PadRight(14);
                string total = ventTotal.Items[i].ToString().PadRight(15);

                string Line = $"{codigo}|{nombre}|{precio}|{cantidad}|{total}";//Lina de presentación
                lineas.Add(Line);
            }

            lineas.Add("");
            lineas.Add($"{PrecioPorPagar.Text}");
            lineas.Add("==============================");

            return lineas.ToArray();
        }

        private void Tienda_Load(object sender, EventArgs e)
        {

        }
        private void CerrarSesion_Click(object sender, EventArgs e)
        {//Volvemos a la ventana de inicio para asi poder entrar con otro usuario
            IniciarSesion IS = new IniciarSesion();
            IS.Show();
            this.Close();
        }
    }
}

using Gestor_de_inventario.Clases;
using MultiHerramientas;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Gestor_de_inventario.Formularios
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
            FormHelper.MovePanel(Panel, this);
            this.KeyDown += Registrarse_KeyDown;
        }
        public static event EventHandler NewUsuario;

        //Boton de registrar usuario
        private void Registrarse_Click(object sender, EventArgs e)
        {
            // Validamos campos vacíos
            if (string.IsNullOrWhiteSpace(Nombre.Text) ||
                string.IsNullOrWhiteSpace(Apellido.Text) ||
                string.IsNullOrWhiteSpace(DNI.Text) ||
                string.IsNullOrWhiteSpace(Celular.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificamos si el formato de cada variable es correcto
            if (!int.TryParse(Celular.Text, out int celular))
            {
                MessageBox.Show("Celular inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(DNI.Text, out int dni))
            {
                MessageBox.Show("DNI inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidCelular(Celular.Text) || !ValidDNI(DNI.Text))
            {
                if (times == 0) Application.ExitThread();
                return;
            }

            //Registramos cada variable del nuevo producto
            Cliente nuevo = new Cliente()
            {
                G2_Nombre = Nombre.Text.Trim(),
                G2_Apellido = Apellido.Text.Trim(),
                G2_DNI = dni,
                G2_Celular = celular
            };

            // Intentamos Agregar
            if (GestionDeClientes.RegristrarUsuario(nuevo))
            {
                MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewUsuario?.Invoke(this, EventArgs.Empty);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Ya existe un producto con ese nombre.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Registrarse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Registrarse.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


        //Validaciones recursivas
        int times = 3;//número de intentos
        private bool ValidCelular(string celular)
        {
            if (celular.Length == 9 && celular.StartsWith("9"))//verificamos si la cantidad es 9
                return true;
            else
    
            {
                MessageBox.Show($"Celular inválido. \nIntentos restantes:{times}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                times--;//Restamos 1 a las oportunidades de entrar
                 return false;
            }
            if(times <= 0) //Observamos si el admin se quedo sin intentos para añadir un usuario nuevo
            {
                MessageBox.Show("Se quedo sin intentos.\nSe cerrara la aplicación por seguridad", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return false;
            }
            return ValidCelular(celular);//En caso de no registrara correctamente un usuario, vamos al siguiente intento
        }
        private bool ValidDNI(string dni)
        {
            if (dni.Length == 8)//verificamos si la cantidad de digitos del dni es la deseada.
                return true;
            else
            {
                MessageBox.Show($"DNI inválido. \nIntentos restantes:{times}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                times--;//Restamos 1 a las oportunidades de entrar
                return false;
            }
            if (times <= 0)//Observamos si el admin se quedo sin intentos para añadir un usuario nuevo
            {
                MessageBox.Show("Se quedo sin intentos.\nSe cerrara la aplicación por seguridad", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return false;
            }
            return ValidDNI(dni);//En caso de no registrara correctamente un usuario, vamos al siguiente intento
        }

        //buttons
        private void LimpiarCampos() //Limpiamos los Label
        {
            Nombre.Text = "";
            Apellido.Text = "";
            DNI.Text = "";
            Celular.Text = "";
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

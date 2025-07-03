using Gestor_de_inventario.Clases;
using MultiHerramientas;
using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_inventario.Formularios
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            GestionDeClientes.CrearTablaSiNoExiste();
            InitializeComponent();
            FormHelper.MovePanel(Panel, this);
        }

        //Administrador
        string Admin_user = "Nero";
        string Admin_DNI = "20602412";
        //usuarios
        public static string user_nombre;
        public static string user_dni;

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void NuevoRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHelper.ShowOrActivateForm<NuevoUsuario>();
        }

        private void EntrarCliente_Click(object sender, EventArgs e)
        {
             user_nombre = UserName.Text.Trim();
             user_dni = UserDNI.Text.Trim();
            //Verificamos si los campos estan vacios
            if (string.IsNullOrWhiteSpace(user_nombre) || string.IsNullOrWhiteSpace(user_dni))
            {
                MessageBox.Show("Por favor, ingresa nombre y DNI.");
                return;
            }
            if (user_nombre == Admin_user && user_dni == Admin_DNI) //El admin puede entrar tanto a la tienda como al registro
            {
                FormHelper.ShowOrActivateForm<Tienda>();
                
                this.Hide();
            }
            else
            {
                if (GestionDeClientes.VerificarPorDni(user_nombre, user_dni)) //llamamos a la verificación
                {
                    MessageBox.Show("Sesión iniciada.", $"Bienvenido {UserName}", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormHelper.ShowOrActivateForm<Tienda>();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void EntrarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Simulamos un click para registrar al cliente
            {
                EntrarCliente.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Administrador_Click(object sender, EventArgs e)
        {
            user_nombre = UserName.Text.Trim(); //Tomamos el nombre del usuario que intenta entrar
            user_dni = UserDNI.Text.Trim(); //Tomamos el DNI del usuario que intenta entrara
            if (string.IsNullOrWhiteSpace(user_nombre) || string.IsNullOrWhiteSpace(user_dni))
            {//Verificamos si estan vacios
                MessageBox.Show("Por favor, ingresa nombre y DNI.");
                return;
            }
            //Si el usuario no uso el nombre y dni del admin no puede entrar
            if (user_nombre != Admin_user && user_dni != Admin_DNI) MessageBox.Show("Usted no es un administrador", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
            {
                FormHelper.ShowOrActivateForm<Administracion>();
                this.Hide();
            }
        }
    }
}

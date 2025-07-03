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
    public partial class AddCantidad : Form
    {
        public AddCantidad()
        {
            InitializeComponent();
            FormHelper.MovePanel(Panel, this);
        }
        public int G2_cantidad { get; private set; } = 1;

        private void Añadir_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TextCantidad.Text, out int cantidad) && cantidad > 0) //verificamos si la cantidad es un número y mayor a 0
            {
                G2_cantidad = int.Parse(TextCantidad.Text);//Guardamos la cantidad
                DialogResult = DialogResult.OK;//Mandamos el resultado de DialogResult
                TextCantidad.Text = "";//limpiamos el texbox
                this.Close();//Cerramos
            }
            else MessageBox.Show("Ingrese un número valido");
        }
        private void Añadir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Simulamos un click para el boton
            {
                Añadir.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
        }

    }
}

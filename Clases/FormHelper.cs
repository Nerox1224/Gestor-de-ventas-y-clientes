using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiHerramientas
{
    internal class FormHelper
    {
        public static void ShowOrActivateForm<T>() where T : Form, new()
        {
            // Buscar si el formulario ya está abierto
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f is T);

            if (form != null)
            {
                // Restaurar si está minimizado
                if (form.WindowState == FormWindowState.Minimized)
                {
                    form.WindowState = FormWindowState.Normal;
                }

                // Traer al frente y activar
                form.BringToFront();
                form.Activate();
            }
            else
            {
                // Si no está abierto, crear y mostrar el formulario
                form = new T();
                form.Show();
            }
        }
        public static void ShowOrActivateFormConParametros(Func<Form> OpenForm)
        {
            // Obtener el tipo del formulario que se desea crear
            Type tipoFormulario = OpenForm().GetType();

            // Buscar si ya está abierto
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f.GetType() == tipoFormulario);

            if (form != null)
            {
                if (form.WindowState == FormWindowState.Minimized)
                    form.WindowState = FormWindowState.Normal;

                form.BringToFront();
                form.Activate();
            }
            else
            {
                // Crear el formulario con los parámetros proporcionados
                form = OpenForm();
                form.Show();
            }
        }


        //Panel

        private static int posX = 0;
        private static int posY = 0;
        public static void MovePanel(Control panel, Form formulario)
        {
            panel.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    posX = e.X;
                    posY = e.Y;
                }
            };

            panel.MouseMove += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    formulario.Left += e.X - posX;
                    formulario.Top += e.Y - posY;
                }
            };
        }
    }
}

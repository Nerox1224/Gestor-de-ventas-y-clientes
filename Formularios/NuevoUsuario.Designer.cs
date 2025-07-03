namespace Gestor_de_inventario.Formularios
{
    partial class NuevoUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoUsuario));
            this.Panel = new System.Windows.Forms.Panel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Cerrar = new Guna.UI2.WinForms.Guna2Button();
            this.DNI = new Guna.UI2.WinForms.Guna2TextBox();
            this.Celular = new Guna.UI2.WinForms.Guna2TextBox();
            this.Apellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.Nombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Registrarse = new Guna.UI2.WinForms.Guna2Button();
            this.Cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.NombreApp = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.Panel.Controls.Add(this.NombreApp);
            this.Panel.Controls.Add(this.guna2PictureBox3);
            this.Panel.Controls.Add(this.Cerrar);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(292, 37);
            this.Panel.TabIndex = 2;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Enabled = false;
            this.guna2PictureBox3.Image = global::Gestor_de_inventario.Properties.Resources.Logo;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(-331, 1);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(40, 36);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 17;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.Animated = true;
            this.Cerrar.BorderRadius = 3;
            this.Cerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Cerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Cerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Cerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Cerrar.FillColor = System.Drawing.Color.White;
            this.Cerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Cerrar.ForeColor = System.Drawing.Color.Black;
            this.Cerrar.Location = new System.Drawing.Point(257, 4);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(30, 29);
            this.Cerrar.TabIndex = 14;
            this.Cerrar.TabStop = false;
            this.Cerrar.Text = "X";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // DNI
            // 
            this.DNI.BackColor = System.Drawing.Color.Transparent;
            this.DNI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DNI.DefaultText = "";
            this.DNI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DNI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DNI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DNI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DNI.FillColor = System.Drawing.Color.LightSteelBlue;
            this.DNI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DNI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DNI.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DNI.Location = new System.Drawing.Point(74, 173);
            this.DNI.MaxLength = 8;
            this.DNI.Name = "DNI";
            this.DNI.PlaceholderText = "";
            this.DNI.SelectedText = "";
            this.DNI.Size = new System.Drawing.Size(200, 36);
            this.DNI.TabIndex = 2;
            // 
            // Celular
            // 
            this.Celular.BackColor = System.Drawing.Color.Transparent;
            this.Celular.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Celular.DefaultText = "";
            this.Celular.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Celular.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Celular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Celular.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Celular.FillColor = System.Drawing.Color.LightSteelBlue;
            this.Celular.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Celular.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Celular.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Celular.Location = new System.Drawing.Point(74, 232);
            this.Celular.MaxLength = 9;
            this.Celular.Name = "Celular";
            this.Celular.PlaceholderText = "";
            this.Celular.SelectedText = "";
            this.Celular.Size = new System.Drawing.Size(200, 36);
            this.Celular.TabIndex = 3;
            // 
            // Apellido
            // 
            this.Apellido.BackColor = System.Drawing.Color.Transparent;
            this.Apellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Apellido.DefaultText = "";
            this.Apellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Apellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Apellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Apellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Apellido.FillColor = System.Drawing.Color.LightSteelBlue;
            this.Apellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Apellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Apellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Apellido.Location = new System.Drawing.Point(74, 117);
            this.Apellido.Name = "Apellido";
            this.Apellido.PlaceholderText = "";
            this.Apellido.SelectedText = "";
            this.Apellido.Size = new System.Drawing.Size(200, 36);
            this.Apellido.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nombre.DefaultText = "";
            this.Nombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Nombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Nombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Nombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Nombre.FillColor = System.Drawing.Color.LightSteelBlue;
            this.Nombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Nombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Nombre.Location = new System.Drawing.Point(74, 64);
            this.Nombre.Name = "Nombre";
            this.Nombre.PlaceholderText = "";
            this.Nombre.SelectedText = "";
            this.Nombre.Size = new System.Drawing.Size(200, 36);
            this.Nombre.TabIndex = 0;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(14, 71);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(48, 20);
            this.guna2HtmlLabel2.TabIndex = 7;
            this.guna2HtmlLabel2.TabStop = false;
            this.guna2HtmlLabel2.Text = "Nombres:";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(14, 124);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(48, 20);
            this.guna2HtmlLabel3.TabIndex = 8;
            this.guna2HtmlLabel3.TabStop = false;
            this.guna2HtmlLabel3.Text = "Apellidos:";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(14, 239);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(48, 20);
            this.guna2HtmlLabel4.TabIndex = 9;
            this.guna2HtmlLabel4.TabStop = false;
            this.guna2HtmlLabel4.Text = "Celular:";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(14, 180);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(48, 20);
            this.guna2HtmlLabel5.TabIndex = 10;
            this.guna2HtmlLabel5.TabStop = false;
            this.guna2HtmlLabel5.Text = "DNI:";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Registrarse
            // 
            this.Registrarse.Animated = true;
            this.Registrarse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Registrarse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Registrarse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Registrarse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Registrarse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.Registrarse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Registrarse.ForeColor = System.Drawing.Color.Black;
            this.Registrarse.Location = new System.Drawing.Point(42, 321);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(204, 36);
            this.Registrarse.TabIndex = 4;
            this.Registrarse.Text = "Registrarse";
            this.Registrarse.Click += new System.EventHandler(this.Registrarse_Click);
            this.Registrarse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Registrarse_KeyDown);
            // 
            // Cancelar
            // 
            this.Cancelar.Animated = true;
            this.Cancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Cancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Cancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Cancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Cancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.Cancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Cancelar.ForeColor = System.Drawing.Color.Black;
            this.Cancelar.Location = new System.Drawing.Point(42, 377);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(204, 36);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "Cancelar Regristro";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // NombreApp
            // 
            this.NombreApp.BackColor = System.Drawing.Color.Transparent;
            this.NombreApp.Enabled = false;
            this.NombreApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NombreApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.NombreApp.Location = new System.Drawing.Point(46, 8);
            this.NombreApp.Name = "NombreApp";
            this.NombreApp.Size = new System.Drawing.Size(175, 22);
            this.NombreApp.TabIndex = 15;
            this.NombreApp.TabStop = false;
            this.NombreApp.Text = "Registrate para comprar";
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 439);
            this.ControlBox = false;
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Registrarse);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Celular);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoUsuario";
            this.Text = "NuevoUsuario";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2Button Cerrar;
        private Guna.UI2.WinForms.Guna2TextBox DNI;
        private Guna.UI2.WinForms.Guna2TextBox Celular;
        private Guna.UI2.WinForms.Guna2TextBox Apellido;
        private Guna.UI2.WinForms.Guna2TextBox Nombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button Registrarse;
        private Guna.UI2.WinForms.Guna2Button Cancelar;
        private Guna.UI2.WinForms.Guna2HtmlLabel NombreApp;
    }
}
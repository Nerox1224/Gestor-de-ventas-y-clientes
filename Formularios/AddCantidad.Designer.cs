namespace Gestor_de_inventario.Formularios
{
    partial class AddCantidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCantidad));
            this.TextCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.Cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.Añadir = new Guna.UI2.WinForms.Guna2Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.NombreApp = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TextCantidad
            // 
            this.TextCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextCantidad.DefaultText = "";
            this.TextCantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextCantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextCantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextCantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextCantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextCantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextCantidad.Location = new System.Drawing.Point(9, 33);
            this.TextCantidad.Name = "TextCantidad";
            this.TextCantidad.PlaceholderText = "";
            this.TextCantidad.SelectedText = "";
            this.TextCantidad.Size = new System.Drawing.Size(301, 28);
            this.TextCantidad.TabIndex = 0;
            // 
            // Cancelar
            // 
            this.Cancelar.Animated = true;
            this.Cancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Cancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Cancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Cancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Cancelar.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Cancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cancelar.Location = new System.Drawing.Point(177, 70);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(119, 28);
            this.Cancelar.TabIndex = 2;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Añadir
            // 
            this.Añadir.Animated = true;
            this.Añadir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Añadir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Añadir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Añadir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Añadir.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Añadir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Añadir.ForeColor = System.Drawing.Color.White;
            this.Añadir.Location = new System.Drawing.Point(19, 70);
            this.Añadir.Name = "Añadir";
            this.Añadir.Size = new System.Drawing.Size(119, 28);
            this.Añadir.TabIndex = 1;
            this.Añadir.Text = "Añadir";
            this.Añadir.Click += new System.EventHandler(this.Añadir_Click);
            this.Añadir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Añadir_KeyDown);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Controls.Add(this.guna2PictureBox3);
            this.Panel.Controls.Add(this.NombreApp);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(322, 29);
            this.Panel.TabIndex = 4;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Enabled = false;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(-304, -4);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(40, 36);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 17;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // NombreApp
            // 
            this.NombreApp.BackColor = System.Drawing.Color.Transparent;
            this.NombreApp.Enabled = false;
            this.NombreApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NombreApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.NombreApp.Location = new System.Drawing.Point(89, 4);
            this.NombreApp.Name = "NombreApp";
            this.NombreApp.Size = new System.Drawing.Size(142, 22);
            this.NombreApp.TabIndex = 14;
            this.NombreApp.TabStop = false;
            this.NombreApp.Text = "Cantidad a comprar";
            // 
            // AddCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 115);
            this.ControlBox = false;
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Añadir);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.TextCantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCantidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddCantidad";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox TextCantidad;
        private Guna.UI2.WinForms.Guna2Button Cancelar;
        private Guna.UI2.WinForms.Guna2Button Añadir;
        private System.Windows.Forms.Panel Panel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel NombreApp;
    }
}
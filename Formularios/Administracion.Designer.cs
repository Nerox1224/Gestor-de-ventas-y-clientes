namespace Gestor_de_inventario.Formularios
{
    partial class Administracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administracion));
            this.Panel = new System.Windows.Forms.Panel();
            this.CerrarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.NombreApp = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ChangeState = new Guna.UI2.WinForms.Guna2Button();
            this.minimized = new Guna.UI2.WinForms.Guna2Button();
            this.Cerrar = new Guna.UI2.WinForms.Guna2Button();
            this.DelProdructo = new Guna.UI2.WinForms.Guna2Button();
            this.DataProductos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddProducto = new Guna.UI2.WinForms.Guna2Button();
            this.DataClientes = new System.Windows.Forms.DataGridView();
            this.BuscarCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.DelCliente = new Guna.UI2.WinForms.Guna2Button();
            this.AddCliente = new Guna.UI2.WinForms.Guna2Button();
            this.SaveChange = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Controls.Add(this.CerrarSesion);
            this.Panel.Controls.Add(this.guna2PictureBox3);
            this.Panel.Controls.Add(this.NombreApp);
            this.Panel.Controls.Add(this.ChangeState);
            this.Panel.Controls.Add(this.minimized);
            this.Panel.Controls.Add(this.Cerrar);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(910, 37);
            this.Panel.TabIndex = 1;
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CerrarSesion.Animated = true;
            this.CerrarSesion.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.CerrarSesion.CustomBorderColor = System.Drawing.Color.Black;
            this.CerrarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CerrarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CerrarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CerrarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CerrarSesion.FillColor = System.Drawing.Color.LightGray;
            this.CerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.CerrarSesion.IndicateFocus = true;
            this.CerrarSesion.Location = new System.Drawing.Point(49, 5);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(123, 26);
            this.CerrarSesion.TabIndex = 59;
            this.CerrarSesion.Text = "Cerrar sesión";
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Enabled = false;
            this.guna2PictureBox3.Image = global::Gestor_de_inventario.Properties.Resources.Logo;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(3, 0);
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
            this.NombreApp.Location = new System.Drawing.Point(180, 7);
            this.NombreApp.Name = "NombreApp";
            this.NombreApp.Size = new System.Drawing.Size(107, 22);
            this.NombreApp.TabIndex = 14;
            this.NombreApp.TabStop = false;
            this.NombreApp.Text = "Administración";
            // 
            // ChangeState
            // 
            this.ChangeState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeState.Animated = true;
            this.ChangeState.BorderRadius = 3;
            this.ChangeState.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ChangeState.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ChangeState.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ChangeState.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ChangeState.FillColor = System.Drawing.Color.White;
            this.ChangeState.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ChangeState.ForeColor = System.Drawing.Color.Black;
            this.ChangeState.Location = new System.Drawing.Point(834, 3);
            this.ChangeState.Name = "ChangeState";
            this.ChangeState.Size = new System.Drawing.Size(30, 29);
            this.ChangeState.TabIndex = 16;
            this.ChangeState.TabStop = false;
            this.ChangeState.Text = "2";
            this.ChangeState.Click += new System.EventHandler(this.ChangeState_Click);
            // 
            // minimized
            // 
            this.minimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimized.Animated = true;
            this.minimized.BorderRadius = 3;
            this.minimized.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minimized.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minimized.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minimized.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minimized.FillColor = System.Drawing.Color.White;
            this.minimized.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimized.ForeColor = System.Drawing.Color.Black;
            this.minimized.Location = new System.Drawing.Point(798, 3);
            this.minimized.Name = "minimized";
            this.minimized.Size = new System.Drawing.Size(30, 29);
            this.minimized.TabIndex = 15;
            this.minimized.TabStop = false;
            this.minimized.Text = "_";
            this.minimized.Click += new System.EventHandler(this.minimized_Click);
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
            this.Cerrar.Location = new System.Drawing.Point(870, 3);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(30, 29);
            this.Cerrar.TabIndex = 14;
            this.Cerrar.TabStop = false;
            this.Cerrar.Text = "X";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // DelProdructo
            // 
            this.DelProdructo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelProdructo.Animated = true;
            this.DelProdructo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.DelProdructo.CustomBorderColor = System.Drawing.Color.Black;
            this.DelProdructo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DelProdructo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DelProdructo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DelProdructo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DelProdructo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.DelProdructo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DelProdructo.ForeColor = System.Drawing.Color.Black;
            this.DelProdructo.IndicateFocus = true;
            this.DelProdructo.Location = new System.Drawing.Point(233, 421);
            this.DelProdructo.Name = "DelProdructo";
            this.DelProdructo.Size = new System.Drawing.Size(176, 36);
            this.DelProdructo.TabIndex = 17;
            this.DelProdructo.Text = "Eliminar producto";
            this.DelProdructo.Click += new System.EventHandler(this.DelProdructo_Click);
            // 
            // DataProductos
            // 
            this.DataProductos.AllowUserToAddRows = false;
            this.DataProductos.AllowUserToDeleteRows = false;
            this.DataProductos.AllowUserToResizeColumns = false;
            this.DataProductos.AllowUserToResizeRows = false;
            this.DataProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataProductos.Location = new System.Drawing.Point(12, 111);
            this.DataProductos.MultiSelect = false;
            this.DataProductos.Name = "DataProductos";
            this.DataProductos.RowHeadersVisible = false;
            this.DataProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataProductos.Size = new System.Drawing.Size(426, 294);
            this.DataProductos.TabIndex = 29;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Animated = true;
            this.txtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Location = new System.Drawing.Point(12, 60);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(402, 26);
            this.txtBuscar.TabIndex = 32;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            // 
            // AddProducto
            // 
            this.AddProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddProducto.Animated = true;
            this.AddProducto.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.AddProducto.CustomBorderColor = System.Drawing.Color.Black;
            this.AddProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddProducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.AddProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddProducto.ForeColor = System.Drawing.Color.Black;
            this.AddProducto.IndicateFocus = true;
            this.AddProducto.Location = new System.Drawing.Point(34, 421);
            this.AddProducto.Name = "AddProducto";
            this.AddProducto.Size = new System.Drawing.Size(176, 36);
            this.AddProducto.TabIndex = 33;
            this.AddProducto.Text = "Agregar producto";
            this.AddProducto.Click += new System.EventHandler(this.AddProducto_Click);
            // 
            // DataClientes
            // 
            this.DataClientes.AllowUserToAddRows = false;
            this.DataClientes.AllowUserToDeleteRows = false;
            this.DataClientes.AllowUserToResizeColumns = false;
            this.DataClientes.AllowUserToResizeRows = false;
            this.DataClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataClientes.Location = new System.Drawing.Point(472, 111);
            this.DataClientes.MultiSelect = false;
            this.DataClientes.Name = "DataClientes";
            this.DataClientes.ReadOnly = true;
            this.DataClientes.RowHeadersVisible = false;
            this.DataClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataClientes.Size = new System.Drawing.Size(426, 294);
            this.DataClientes.TabIndex = 34;
            // 
            // BuscarCliente
            // 
            this.BuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarCliente.Animated = true;
            this.BuscarCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BuscarCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BuscarCliente.DefaultText = "";
            this.BuscarCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BuscarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BuscarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BuscarCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BuscarCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BuscarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.BuscarCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BuscarCliente.Location = new System.Drawing.Point(472, 60);
            this.BuscarCliente.Name = "BuscarCliente";
            this.BuscarCliente.PlaceholderText = "";
            this.BuscarCliente.SelectedText = "";
            this.BuscarCliente.Size = new System.Drawing.Size(401, 26);
            this.BuscarCliente.TabIndex = 35;
            this.BuscarCliente.TextChanged += new System.EventHandler(this.BuscarCliente_TextChanged);
            // 
            // DelCliente
            // 
            this.DelCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelCliente.Animated = true;
            this.DelCliente.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.DelCliente.CustomBorderColor = System.Drawing.Color.Black;
            this.DelCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DelCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DelCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DelCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DelCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.DelCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DelCliente.ForeColor = System.Drawing.Color.Black;
            this.DelCliente.IndicateFocus = true;
            this.DelCliente.Location = new System.Drawing.Point(606, 476);
            this.DelCliente.Name = "DelCliente";
            this.DelCliente.Size = new System.Drawing.Size(176, 36);
            this.DelCliente.TabIndex = 36;
            this.DelCliente.Text = "Eliminar Cliente";
            this.DelCliente.Click += new System.EventHandler(this.DelCliente_Click);
            // 
            // AddCliente
            // 
            this.AddCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddCliente.Animated = true;
            this.AddCliente.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.AddCliente.CustomBorderColor = System.Drawing.Color.Black;
            this.AddCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.AddCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddCliente.ForeColor = System.Drawing.Color.Black;
            this.AddCliente.IndicateFocus = true;
            this.AddCliente.Location = new System.Drawing.Point(606, 421);
            this.AddCliente.Name = "AddCliente";
            this.AddCliente.Size = new System.Drawing.Size(176, 36);
            this.AddCliente.TabIndex = 37;
            this.AddCliente.Text = "Añadir Cliente";
            this.AddCliente.Click += new System.EventHandler(this.AddCliente_Click);
            // 
            // SaveChange
            // 
            this.SaveChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveChange.Animated = true;
            this.SaveChange.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.SaveChange.CustomBorderColor = System.Drawing.Color.Black;
            this.SaveChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveChange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.SaveChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveChange.ForeColor = System.Drawing.Color.Black;
            this.SaveChange.IndicateFocus = true;
            this.SaveChange.Location = new System.Drawing.Point(136, 476);
            this.SaveChange.Name = "SaveChange";
            this.SaveChange.Size = new System.Drawing.Size(176, 36);
            this.SaveChange.TabIndex = 38;
            this.SaveChange.Text = "Guardar cambios";
            this.SaveChange.Click += new System.EventHandler(this.SaveChange_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Enabled = false;
            this.guna2PictureBox1.Image = global::Gestor_de_inventario.Properties.Resources.Busqueda;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(410, 60);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(28, 26);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 39;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Enabled = false;
            this.guna2PictureBox2.Image = global::Gestor_de_inventario.Properties.Resources.Busqueda;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(870, 60);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(28, 26);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 40;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 536);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.SaveChange);
            this.Controls.Add(this.AddCliente);
            this.Controls.Add(this.DelCliente);
            this.Controls.Add(this.BuscarCliente);
            this.Controls.Add(this.DataClientes);
            this.Controls.Add(this.AddProducto);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.DataProductos);
            this.Controls.Add(this.DelProdructo);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel NombreApp;
        private Guna.UI2.WinForms.Guna2Button ChangeState;
        private Guna.UI2.WinForms.Guna2Button minimized;
        private Guna.UI2.WinForms.Guna2Button Cerrar;
        private Guna.UI2.WinForms.Guna2Button DelProdructo;
        private System.Windows.Forms.DataGridView DataProductos;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private Guna.UI2.WinForms.Guna2Button AddProducto;
        private Guna.UI2.WinForms.Guna2Button CerrarSesion;
        private System.Windows.Forms.DataGridView DataClientes;
        private Guna.UI2.WinForms.Guna2TextBox BuscarCliente;
        private Guna.UI2.WinForms.Guna2Button DelCliente;
        private Guna.UI2.WinForms.Guna2Button AddCliente;
        private Guna.UI2.WinForms.Guna2Button SaveChange;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}
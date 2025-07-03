namespace Gestor_de_inventario
{
    partial class Tienda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tienda));
            this.Panel = new System.Windows.Forms.Panel();
            this.CerrarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.NombreApp = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ChangeState = new Guna.UI2.WinForms.Guna2Button();
            this.minimized = new Guna.UI2.WinForms.Guna2Button();
            this.Cerrar = new Guna.UI2.WinForms.Guna2Button();
            this.StockTotal = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataProductos = new System.Windows.Forms.DataGridView();
            this.PrecioPorPagar = new System.Windows.Forms.Label();
            this.Add = new Guna.UI2.WinForms.Guna2Button();
            this.Text1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Text5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Text4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Text3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Text2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Comprar = new Guna.UI2.WinForms.Guna2Button();
            this.ventCodigo = new System.Windows.Forms.ListBox();
            this.ventNombre = new System.Windows.Forms.ListBox();
            this.ventPrecio = new System.Windows.Forms.ListBox();
            this.ventCantidad = new System.Windows.Forms.ListBox();
            this.ventTotal = new System.Windows.Forms.ListBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CancelarCompra = new Guna.UI2.WinForms.Guna2Button();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Controls.Add(this.CerrarSesion);
            this.Panel.Controls.Add(this.guna2PictureBox3);
            this.Panel.Controls.Add(this.NombreApp);
            this.Panel.Controls.Add(this.ChangeState);
            this.Panel.Controls.Add(this.minimized);
            this.Panel.Controls.Add(this.Cerrar);
            this.Panel.Location = new System.Drawing.Point(1, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(935, 37);
            this.Panel.TabIndex = 0;
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
            this.CerrarSesion.Location = new System.Drawing.Point(48, 4);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(123, 26);
            this.CerrarSesion.TabIndex = 58;
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
            this.guna2PictureBox3.Location = new System.Drawing.Point(2, 0);
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
            this.NombreApp.Location = new System.Drawing.Point(187, 7);
            this.NombreApp.Name = "NombreApp";
            this.NombreApp.Size = new System.Drawing.Size(51, 22);
            this.NombreApp.TabIndex = 14;
            this.NombreApp.TabStop = false;
            this.NombreApp.Text = "Tienda";
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
            this.ChangeState.Location = new System.Drawing.Point(859, 3);
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
            this.minimized.Location = new System.Drawing.Point(823, 3);
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
            this.Cerrar.Location = new System.Drawing.Point(895, 3);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(30, 29);
            this.Cerrar.TabIndex = 14;
            this.Cerrar.TabStop = false;
            this.Cerrar.Text = "X";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // StockTotal
            // 
            this.StockTotal.Animated = true;
            this.StockTotal.BorderColor = System.Drawing.Color.Transparent;
            this.StockTotal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StockTotal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StockTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StockTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StockTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.StockTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StockTotal.ForeColor = System.Drawing.Color.Black;
            this.StockTotal.IndicateFocus = true;
            this.StockTotal.Location = new System.Drawing.Point(31, 437);
            this.StockTotal.Name = "StockTotal";
            this.StockTotal.Size = new System.Drawing.Size(176, 36);
            this.StockTotal.TabIndex = 27;
            this.StockTotal.Text = "Stock total";
            this.StockTotal.Click += new System.EventHandler(this.StockTotal_Click);
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
            this.txtBuscar.Location = new System.Drawing.Point(12, 47);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(463, 26);
            this.txtBuscar.TabIndex = 15;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // DataProductos
            // 
            this.DataProductos.AllowUserToAddRows = false;
            this.DataProductos.AllowUserToDeleteRows = false;
            this.DataProductos.AllowUserToResizeColumns = false;
            this.DataProductos.AllowUserToResizeRows = false;
            this.DataProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataProductos.Location = new System.Drawing.Point(11, 89);
            this.DataProductos.MultiSelect = false;
            this.DataProductos.Name = "DataProductos";
            this.DataProductos.ReadOnly = true;
            this.DataProductos.RowHeadersVisible = false;
            this.DataProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataProductos.Size = new System.Drawing.Size(511, 342);
            this.DataProductos.TabIndex = 28;
            this.DataProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataProductos_KeyDown);
            // 
            // PrecioPorPagar
            // 
            this.PrecioPorPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrecioPorPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PrecioPorPagar.Location = new System.Drawing.Point(761, 472);
            this.PrecioPorPagar.Name = "PrecioPorPagar";
            this.PrecioPorPagar.Size = new System.Drawing.Size(177, 25);
            this.PrecioPorPagar.TabIndex = 29;
            this.PrecioPorPagar.Text = "Total a pagar: S/00.00";
            this.PrecioPorPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add.Animated = true;
            this.Add.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Add.CustomBorderColor = System.Drawing.Color.Black;
            this.Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Add.ForeColor = System.Drawing.Color.Black;
            this.Add.IndicateFocus = true;
            this.Add.Location = new System.Drawing.Point(299, 437);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(176, 36);
            this.Add.TabIndex = 31;
            this.Add.Text = "Añadir al carro";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Text1
            // 
            this.Text1.BackColor = System.Drawing.Color.SteelBlue;
            this.Text1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text1.DefaultText = "Código";
            this.Text1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Text1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Text1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text1.Enabled = false;
            this.Text1.FillColor = System.Drawing.Color.SteelBlue;
            this.Text1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text1.ForeColor = System.Drawing.Color.Black;
            this.Text1.HideSelection = false;
            this.Text1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text1.Location = new System.Drawing.Point(529, 53);
            this.Text1.Name = "Text1";
            this.Text1.PlaceholderText = "";
            this.Text1.ReadOnly = true;
            this.Text1.SelectedText = "";
            this.Text1.Size = new System.Drawing.Size(74, 30);
            this.Text1.TabIndex = 36;
            this.Text1.TabStop = false;
            // 
            // Text5
            // 
            this.Text5.BackColor = System.Drawing.Color.SteelBlue;
            this.Text5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text5.DefaultText = "Total";
            this.Text5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Text5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Text5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text5.Enabled = false;
            this.Text5.FillColor = System.Drawing.Color.SteelBlue;
            this.Text5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text5.ForeColor = System.Drawing.Color.Black;
            this.Text5.HideSelection = false;
            this.Text5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text5.Location = new System.Drawing.Point(853, 53);
            this.Text5.Name = "Text5";
            this.Text5.PlaceholderText = "";
            this.Text5.ReadOnly = true;
            this.Text5.SelectedText = "";
            this.Text5.Size = new System.Drawing.Size(74, 30);
            this.Text5.TabIndex = 37;
            this.Text5.TabStop = false;
            // 
            // Text4
            // 
            this.Text4.BackColor = System.Drawing.Color.SteelBlue;
            this.Text4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text4.DefaultText = "Cantidad";
            this.Text4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Text4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Text4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text4.Enabled = false;
            this.Text4.FillColor = System.Drawing.Color.SteelBlue;
            this.Text4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text4.ForeColor = System.Drawing.Color.Black;
            this.Text4.HideSelection = false;
            this.Text4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text4.Location = new System.Drawing.Point(772, 53);
            this.Text4.Name = "Text4";
            this.Text4.PlaceholderText = "";
            this.Text4.ReadOnly = true;
            this.Text4.SelectedText = "";
            this.Text4.Size = new System.Drawing.Size(74, 30);
            this.Text4.TabIndex = 38;
            this.Text4.TabStop = false;
            // 
            // Text3
            // 
            this.Text3.BackColor = System.Drawing.Color.SteelBlue;
            this.Text3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text3.DefaultText = "Precio";
            this.Text3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Text3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Text3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text3.Enabled = false;
            this.Text3.FillColor = System.Drawing.Color.SteelBlue;
            this.Text3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text3.ForeColor = System.Drawing.Color.Black;
            this.Text3.HideSelection = false;
            this.Text3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text3.Location = new System.Drawing.Point(691, 53);
            this.Text3.Name = "Text3";
            this.Text3.PlaceholderText = "";
            this.Text3.ReadOnly = true;
            this.Text3.SelectedText = "";
            this.Text3.Size = new System.Drawing.Size(74, 30);
            this.Text3.TabIndex = 39;
            this.Text3.TabStop = false;
            // 
            // Text2
            // 
            this.Text2.BackColor = System.Drawing.Color.SteelBlue;
            this.Text2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text2.DefaultText = "Nombre";
            this.Text2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Text2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Text2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text2.Enabled = false;
            this.Text2.FillColor = System.Drawing.Color.SteelBlue;
            this.Text2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text2.ForeColor = System.Drawing.Color.Black;
            this.Text2.HideSelection = false;
            this.Text2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text2.Location = new System.Drawing.Point(610, 53);
            this.Text2.Name = "Text2";
            this.Text2.PlaceholderText = "";
            this.Text2.ReadOnly = true;
            this.Text2.SelectedText = "";
            this.Text2.Size = new System.Drawing.Size(74, 30);
            this.Text2.TabIndex = 40;
            this.Text2.TabStop = false;
            // 
            // Comprar
            // 
            this.Comprar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Comprar.Animated = true;
            this.Comprar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Comprar.CustomBorderColor = System.Drawing.Color.Black;
            this.Comprar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Comprar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Comprar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Comprar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Comprar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.Comprar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Comprar.ForeColor = System.Drawing.Color.Black;
            this.Comprar.IndicateFocus = true;
            this.Comprar.Location = new System.Drawing.Point(734, 437);
            this.Comprar.Name = "Comprar";
            this.Comprar.Size = new System.Drawing.Size(176, 36);
            this.Comprar.TabIndex = 51;
            this.Comprar.Text = "Comprar";
            this.Comprar.Click += new System.EventHandler(this.Comprar_Click);
            // 
            // ventCodigo
            // 
            this.ventCodigo.FormattingEnabled = true;
            this.ventCodigo.Location = new System.Drawing.Point(529, 89);
            this.ventCodigo.Name = "ventCodigo";
            this.ventCodigo.Size = new System.Drawing.Size(74, 342);
            this.ventCodigo.TabIndex = 52;
            // 
            // ventNombre
            // 
            this.ventNombre.FormattingEnabled = true;
            this.ventNombre.Location = new System.Drawing.Point(610, 89);
            this.ventNombre.Name = "ventNombre";
            this.ventNombre.Size = new System.Drawing.Size(74, 342);
            this.ventNombre.TabIndex = 53;
            // 
            // ventPrecio
            // 
            this.ventPrecio.FormattingEnabled = true;
            this.ventPrecio.Location = new System.Drawing.Point(691, 89);
            this.ventPrecio.Name = "ventPrecio";
            this.ventPrecio.Size = new System.Drawing.Size(74, 342);
            this.ventPrecio.TabIndex = 54;
            // 
            // ventCantidad
            // 
            this.ventCantidad.FormattingEnabled = true;
            this.ventCantidad.Location = new System.Drawing.Point(772, 89);
            this.ventCantidad.Name = "ventCantidad";
            this.ventCantidad.Size = new System.Drawing.Size(74, 342);
            this.ventCantidad.TabIndex = 55;
            // 
            // ventTotal
            // 
            this.ventTotal.FormattingEnabled = true;
            this.ventTotal.Location = new System.Drawing.Point(853, 89);
            this.ventTotal.Name = "ventTotal";
            this.ventTotal.Size = new System.Drawing.Size(74, 342);
            this.ventTotal.TabIndex = 56;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Enabled = false;
            this.guna2PictureBox1.Image = global::Gestor_de_inventario.Properties.Resources.Busqueda;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(476, 47);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(28, 26);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 18;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // CancelarCompra
            // 
            this.CancelarCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelarCompra.Animated = true;
            this.CancelarCompra.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.CancelarCompra.CustomBorderColor = System.Drawing.Color.Black;
            this.CancelarCompra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelarCompra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelarCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelarCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelarCompra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.CancelarCompra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CancelarCompra.ForeColor = System.Drawing.Color.Black;
            this.CancelarCompra.IndicateFocus = true;
            this.CancelarCompra.Location = new System.Drawing.Point(537, 437);
            this.CancelarCompra.Name = "CancelarCompra";
            this.CancelarCompra.Size = new System.Drawing.Size(176, 36);
            this.CancelarCompra.TabIndex = 57;
            this.CancelarCompra.Text = "Cancelar compra";
            this.CancelarCompra.Click += new System.EventHandler(this.CancelarCompra_Click);
            // 
            // Tienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 498);
            this.ControlBox = false;
            this.Controls.Add(this.CancelarCompra);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.ventTotal);
            this.Controls.Add(this.ventCantidad);
            this.Controls.Add(this.ventPrecio);
            this.Controls.Add(this.ventNombre);
            this.Controls.Add(this.ventCodigo);
            this.Controls.Add(this.Comprar);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.Text5);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.PrecioPorPagar);
            this.Controls.Add(this.DataProductos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.StockTotal);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de inventario";
            this.Load += new System.EventHandler(this.Tienda_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel NombreApp;
        private Guna.UI2.WinForms.Guna2Button ChangeState;
        private Guna.UI2.WinForms.Guna2Button minimized;
        private Guna.UI2.WinForms.Guna2Button Cerrar;
        private Guna.UI2.WinForms.Guna2Button StockTotal;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private System.Windows.Forms.DataGridView DataProductos;
        private System.Windows.Forms.Label PrecioPorPagar;
        private Guna.UI2.WinForms.Guna2Button Add;
        private Guna.UI2.WinForms.Guna2TextBox Text1;
        private Guna.UI2.WinForms.Guna2TextBox Text5;
        private Guna.UI2.WinForms.Guna2TextBox Text4;
        private Guna.UI2.WinForms.Guna2TextBox Text3;
        private Guna.UI2.WinForms.Guna2TextBox Text2;
        private Guna.UI2.WinForms.Guna2Button Comprar;
        private System.Windows.Forms.ListBox ventCodigo;
        private System.Windows.Forms.ListBox ventNombre;
        private System.Windows.Forms.ListBox ventPrecio;
        private System.Windows.Forms.ListBox ventCantidad;
        private System.Windows.Forms.ListBox ventTotal;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button CancelarCompra;
        private Guna.UI2.WinForms.Guna2Button CerrarSesion;
    }
}


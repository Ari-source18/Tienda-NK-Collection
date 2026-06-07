namespace Sistema_NK
{
    partial class forminventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forminventario));
            panel1 = new Panel();
            btninventario = new Button();
            btnnivelacioninventario = new Button();
            btndevolucionventas = new Button();
            btncredito = new Button();
            btndevolucioncompra = new Button();
            btncaja = new Button();
            btnusuarios = new Button();
            btncompras = new Button();
            btnproductos = new Button();
            btnproveedores = new Button();
            btnventas = new Button();
            label11 = new Label();
            label15 = new Label();
            btnclientes = new Button();
            label16 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            groupBoxnuevoproducto = new GroupBox();
            btnImprimirreporte = new Button();
            dataGridView2 = new DataGridView();
            groupBox1 = new GroupBox();
            checkBoxSolostockbajo = new CheckBox();
            CBestado1 = new ComboBox();
            CBcategoria3 = new ComboBox();
            btnBuscarproducto7 = new Button();
            label2 = new Label();
            label13 = new Label();
            txtBuscarproducto = new TextBox();
            label17 = new Label();
            btnLimpiar4 = new Button();
            button6 = new Button();
            button5 = new Button();
            Código = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Categoría = new DataGridViewTextBoxColumn();
            Stock_actual = new DataGridViewTextBoxColumn();
            Stock_minimo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Precio_venta = new DataGridViewTextBoxColumn();
            editar = new DataGridViewTextBoxColumn();
            btnActualizar1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxnuevoproducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Controls.Add(btninventario);
            panel1.Controls.Add(btnnivelacioninventario);
            panel1.Controls.Add(btndevolucionventas);
            panel1.Controls.Add(btncredito);
            panel1.Controls.Add(btndevolucioncompra);
            panel1.Controls.Add(btncaja);
            panel1.Controls.Add(btnusuarios);
            panel1.Controls.Add(btncompras);
            panel1.Controls.Add(btnproductos);
            panel1.Controls.Add(btnproveedores);
            panel1.Controls.Add(btnventas);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(btnclientes);
            panel1.Controls.Add(label16);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 690);
            panel1.TabIndex = 4;
            // 
            // btninventario
            // 
            btninventario.BackColor = Color.DarkSalmon;
            btninventario.FlatAppearance.BorderSize = 0;
            btninventario.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btninventario.FlatAppearance.MouseOverBackColor = Color.Tan;
            btninventario.FlatStyle = FlatStyle.Flat;
            btninventario.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btninventario.ForeColor = Color.White;
            btninventario.ImageAlign = ContentAlignment.MiddleLeft;
            btninventario.Location = new Point(46, 650);
            btninventario.Margin = new Padding(2);
            btninventario.Name = "btninventario";
            btninventario.Size = new Size(134, 30);
            btninventario.TabIndex = 56;
            btninventario.Text = "Inventario";
            btninventario.UseVisualStyleBackColor = false;
            btninventario.Click += btninventario_Click;
            // 
            // btnnivelacioninventario
            // 
            btnnivelacioninventario.BackColor = Color.Transparent;
            btnnivelacioninventario.FlatAppearance.BorderSize = 0;
            btnnivelacioninventario.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnnivelacioninventario.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnnivelacioninventario.FlatStyle = FlatStyle.Flat;
            btnnivelacioninventario.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnivelacioninventario.ForeColor = Color.White;
            btnnivelacioninventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnnivelacioninventario.Location = new Point(2, 607);
            btnnivelacioninventario.Margin = new Padding(2);
            btnnivelacioninventario.Name = "btnnivelacioninventario";
            btnnivelacioninventario.Size = new Size(232, 30);
            btnnivelacioninventario.TabIndex = 55;
            btnnivelacioninventario.Text = "Nivelación de inventario";
            btnnivelacioninventario.UseVisualStyleBackColor = false;
            btnnivelacioninventario.Click += btnnivelacioninventario_Click;
            // 
            // btndevolucionventas
            // 
            btndevolucionventas.BackColor = Color.Transparent;
            btndevolucionventas.FlatAppearance.BorderSize = 0;
            btndevolucionventas.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btndevolucionventas.FlatAppearance.MouseOverBackColor = Color.Tan;
            btndevolucionventas.FlatStyle = FlatStyle.Flat;
            btndevolucionventas.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndevolucionventas.ForeColor = Color.White;
            btndevolucionventas.ImageAlign = ContentAlignment.MiddleLeft;
            btndevolucionventas.Location = new Point(25, 458);
            btndevolucionventas.Margin = new Padding(2);
            btndevolucionventas.Name = "btndevolucionventas";
            btndevolucionventas.Size = new Size(206, 30);
            btndevolucionventas.TabIndex = 54;
            btndevolucionventas.Text = "Devolución Ventas";
            btndevolucionventas.UseVisualStyleBackColor = false;
            btndevolucionventas.Click += btndevolucionventas_Click;
            // 
            // btncredito
            // 
            btncredito.BackColor = Color.Transparent;
            btncredito.FlatAppearance.BorderSize = 0;
            btncredito.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btncredito.FlatAppearance.MouseOverBackColor = Color.Tan;
            btncredito.FlatStyle = FlatStyle.Flat;
            btncredito.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncredito.ForeColor = Color.White;
            btncredito.ImageAlign = ContentAlignment.MiddleLeft;
            btncredito.Location = new Point(46, 406);
            btncredito.Margin = new Padding(2);
            btncredito.Name = "btncredito";
            btncredito.Size = new Size(134, 30);
            btncredito.TabIndex = 53;
            btncredito.Text = "Crédito";
            btncredito.UseVisualStyleBackColor = false;
            btncredito.Click += btncredito_Click;
            // 
            // btndevolucioncompra
            // 
            btndevolucioncompra.BackColor = Color.Transparent;
            btndevolucioncompra.FlatAppearance.BorderSize = 0;
            btndevolucioncompra.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btndevolucioncompra.FlatAppearance.MouseOverBackColor = Color.Tan;
            btndevolucioncompra.FlatStyle = FlatStyle.Flat;
            btndevolucioncompra.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndevolucioncompra.ForeColor = Color.White;
            btndevolucioncompra.ImageAlign = ContentAlignment.MiddleLeft;
            btndevolucioncompra.Location = new Point(16, 508);
            btndevolucioncompra.Margin = new Padding(2);
            btndevolucioncompra.Name = "btndevolucioncompra";
            btndevolucioncompra.Size = new Size(214, 30);
            btndevolucioncompra.TabIndex = 52;
            btndevolucioncompra.Text = "Devolución Compra";
            btndevolucioncompra.UseVisualStyleBackColor = false;
            btndevolucioncompra.Click += btndevolucioncompra_Click;
            // 
            // btncaja
            // 
            btncaja.BackColor = Color.Transparent;
            btncaja.FlatAppearance.BorderSize = 0;
            btncaja.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btncaja.FlatAppearance.MouseOverBackColor = Color.Tan;
            btncaja.FlatStyle = FlatStyle.Flat;
            btncaja.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncaja.ForeColor = Color.White;
            btncaja.ImageAlign = ContentAlignment.MiddleLeft;
            btncaja.Location = new Point(46, 558);
            btncaja.Margin = new Padding(2);
            btncaja.Name = "btncaja";
            btncaja.Size = new Size(134, 30);
            btncaja.TabIndex = 51;
            btncaja.Text = "Caja";
            btncaja.UseVisualStyleBackColor = false;
            btncaja.Click += btncaja_Click;
            // 
            // btnusuarios
            // 
            btnusuarios.BackColor = Color.Transparent;
            btnusuarios.FlatAppearance.BorderSize = 0;
            btnusuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnusuarios.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnusuarios.FlatStyle = FlatStyle.Flat;
            btnusuarios.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnusuarios.ForeColor = Color.White;
            btnusuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnusuarios.Location = new Point(46, 97);
            btnusuarios.Margin = new Padding(2);
            btnusuarios.Name = "btnusuarios";
            btnusuarios.Size = new Size(134, 30);
            btnusuarios.TabIndex = 50;
            btnusuarios.Text = "Usuarios";
            btnusuarios.UseVisualStyleBackColor = false;
            btnusuarios.Click += btnusuarios_Click;
            // 
            // btncompras
            // 
            btncompras.BackColor = Color.Transparent;
            btncompras.FlatAppearance.BorderSize = 0;
            btncompras.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btncompras.FlatAppearance.MouseOverBackColor = Color.Tan;
            btncompras.FlatStyle = FlatStyle.Flat;
            btncompras.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncompras.ForeColor = Color.White;
            btncompras.ImageAlign = ContentAlignment.MiddleLeft;
            btncompras.Location = new Point(46, 206);
            btncompras.Margin = new Padding(2);
            btncompras.Name = "btncompras";
            btncompras.Size = new Size(134, 30);
            btncompras.TabIndex = 49;
            btncompras.Text = "Compras";
            btncompras.UseVisualStyleBackColor = false;
            btncompras.Click += btncompras_Click;
            // 
            // btnproductos
            // 
            btnproductos.BackColor = Color.Transparent;
            btnproductos.FlatAppearance.BorderSize = 0;
            btnproductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnproductos.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnproductos.FlatStyle = FlatStyle.Flat;
            btnproductos.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnproductos.ForeColor = Color.White;
            btnproductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnproductos.Location = new Point(46, 305);
            btnproductos.Margin = new Padding(2);
            btnproductos.Name = "btnproductos";
            btnproductos.Size = new Size(134, 30);
            btnproductos.TabIndex = 48;
            btnproductos.Text = "Productos";
            btnproductos.UseVisualStyleBackColor = false;
            btnproductos.Click += btnproductos_Click;
            // 
            // btnproveedores
            // 
            btnproveedores.BackColor = Color.Transparent;
            btnproveedores.FlatAppearance.BorderSize = 0;
            btnproveedores.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnproveedores.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnproveedores.FlatStyle = FlatStyle.Flat;
            btnproveedores.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnproveedores.ForeColor = Color.White;
            btnproveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnproveedores.Location = new Point(46, 359);
            btnproveedores.Margin = new Padding(2);
            btnproveedores.Name = "btnproveedores";
            btnproveedores.Size = new Size(134, 30);
            btnproveedores.TabIndex = 47;
            btnproveedores.Text = "Proveedores";
            btnproveedores.UseVisualStyleBackColor = false;
            btnproveedores.Click += btnproveedores_Click;
            // 
            // btnventas
            // 
            btnventas.BackColor = Color.Transparent;
            btnventas.FlatAppearance.BorderSize = 0;
            btnventas.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnventas.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnventas.FlatStyle = FlatStyle.Flat;
            btnventas.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnventas.ForeColor = Color.White;
            btnventas.ImageAlign = ContentAlignment.MiddleLeft;
            btnventas.Location = new Point(46, 257);
            btnventas.Margin = new Padding(2);
            btnventas.Name = "btnventas";
            btnventas.Size = new Size(134, 30);
            btnventas.TabIndex = 46;
            btnventas.Text = "Ventas";
            btnventas.UseVisualStyleBackColor = false;
            btnventas.Click += btnventas_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(10, 25);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(69, 48);
            label11.TabIndex = 43;
            label11.Text = "NK";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(73, 38);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(152, 24);
            label15.TabIndex = 44;
            label15.Text = "COLLECTION";
            // 
            // btnclientes
            // 
            btnclientes.BackColor = Color.Transparent;
            btnclientes.FlatAppearance.BorderSize = 0;
            btnclientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnclientes.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnclientes.FlatStyle = FlatStyle.Flat;
            btnclientes.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclientes.ForeColor = Color.White;
            btnclientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnclientes.Location = new Point(46, 152);
            btnclientes.Margin = new Padding(2);
            btnclientes.Name = "btnclientes";
            btnclientes.Size = new Size(134, 30);
            btnclientes.TabIndex = 34;
            btnclientes.Text = "Clientes";
            btnclientes.UseVisualStyleBackColor = false;
            btnclientes.Click += btnclientes_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(2, 61);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(241, 24);
            label16.TabIndex = 45;
            label16.Text = "_____________________";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagen_circular_recortada;
            pictureBox1.Location = new Point(998, 10);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 132;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(252, 38);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(254, 27);
            label5.TabIndex = 131;
            label5.Text = "Gestión de Inventario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(241, 58);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(824, 27);
            label6.TabIndex = 130;
            label6.Text = "__________________________________________________________";
            // 
            // groupBoxnuevoproducto
            // 
            groupBoxnuevoproducto.BackColor = Color.SeaShell;
            groupBoxnuevoproducto.Controls.Add(btnImprimirreporte);
            groupBoxnuevoproducto.Controls.Add(dataGridView2);
            groupBoxnuevoproducto.Location = new Point(252, 277);
            groupBoxnuevoproducto.Margin = new Padding(2);
            groupBoxnuevoproducto.Name = "groupBoxnuevoproducto";
            groupBoxnuevoproducto.Padding = new Padding(2);
            groupBoxnuevoproducto.Size = new Size(1016, 236);
            groupBoxnuevoproducto.TabIndex = 146;
            groupBoxnuevoproducto.TabStop = false;
            groupBoxnuevoproducto.Text = "Lista de productos en inventario";
            // 
            // btnImprimirreporte
            // 
            btnImprimirreporte.BackColor = Color.FromArgb(64, 0, 0);
            btnImprimirreporte.BackgroundImageLayout = ImageLayout.None;
            btnImprimirreporte.Font = new Font("PMingLiU-ExtB", 10F);
            btnImprimirreporte.ForeColor = Color.White;
            btnImprimirreporte.Location = new Point(10, 193);
            btnImprimirreporte.Margin = new Padding(2);
            btnImprimirreporte.Name = "btnImprimirreporte";
            btnImprimirreporte.Size = new Size(121, 34);
            btnImprimirreporte.TabIndex = 42;
            btnImprimirreporte.Text = "Imprimir reporte";
            btnImprimirreporte.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.SeaShell;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Código, Producto, Categoría, Stock_actual, Stock_minimo, Estado, Precio_venta, editar });
            dataGridView2.Location = new Point(10, 35);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(983, 126);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(btnActualizar1);
            groupBox1.Controls.Add(checkBoxSolostockbajo);
            groupBox1.Controls.Add(CBestado1);
            groupBox1.Controls.Add(CBcategoria3);
            groupBox1.Controls.Add(btnBuscarproducto7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtBuscarproducto);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(btnLimpiar4);
            groupBox1.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(252, 97);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(818, 160);
            groupBox1.TabIndex = 145;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros de búsqueda ";
            // 
            // checkBoxSolostockbajo
            // 
            checkBoxSolostockbajo.AutoSize = true;
            checkBoxSolostockbajo.Location = new Point(8, 107);
            checkBoxSolostockbajo.Name = "checkBoxSolostockbajo";
            checkBoxSolostockbajo.Size = new Size(170, 28);
            checkBoxSolostockbajo.TabIndex = 43;
            checkBoxSolostockbajo.Text = "Solo stock bajo";
            checkBoxSolostockbajo.UseVisualStyleBackColor = true;
            // 
            // CBestado1
            // 
            CBestado1.Font = new Font("PMingLiU-ExtB", 9F);
            CBestado1.FormattingEnabled = true;
            CBestado1.Location = new Point(524, 57);
            CBestado1.Margin = new Padding(2);
            CBestado1.Name = "CBestado1";
            CBestado1.Size = new Size(246, 23);
            CBestado1.TabIndex = 121;
            // 
            // CBcategoria3
            // 
            CBcategoria3.Font = new Font("PMingLiU-ExtB", 9F);
            CBcategoria3.FormattingEnabled = true;
            CBcategoria3.Location = new Point(292, 56);
            CBcategoria3.Margin = new Padding(2);
            CBcategoria3.Name = "CBcategoria3";
            CBcategoria3.Size = new Size(197, 23);
            CBcategoria3.TabIndex = 120;
            // 
            // btnBuscarproducto7
            // 
            btnBuscarproducto7.BackColor = Color.Transparent;
            btnBuscarproducto7.BackgroundImage = (Image)resources.GetObject("btnBuscarproducto7.BackgroundImage");
            btnBuscarproducto7.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBuscarproducto7.ForeColor = SystemColors.ControlLightLight;
            btnBuscarproducto7.Location = new Point(219, 54);
            btnBuscarproducto7.Margin = new Padding(2);
            btnBuscarproducto7.Name = "btnBuscarproducto7";
            btnBuscarproducto7.Size = new Size(30, 27);
            btnBuscarproducto7.TabIndex = 119;
            btnBuscarproducto7.Text = "Cerrar Sesión ";
            btnBuscarproducto7.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 10F);
            label2.Location = new Point(522, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 60;
            label2.Text = "Estado:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("PMingLiU-ExtB", 10F);
            label13.Location = new Point(290, 32);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(74, 17);
            label13.TabIndex = 47;
            label13.Text = "Categoría:";
            // 
            // txtBuscarproducto
            // 
            txtBuscarproducto.Font = new Font("PMingLiU-ExtB", 9F);
            txtBuscarproducto.Location = new Point(10, 56);
            txtBuscarproducto.Margin = new Padding(2);
            txtBuscarproducto.Name = "txtBuscarproducto";
            txtBuscarproducto.Size = new Size(205, 25);
            txtBuscarproducto.TabIndex = 46;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("PMingLiU-ExtB", 10F);
            label17.Location = new Point(6, 31);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(116, 17);
            label17.TabIndex = 37;
            label17.Text = "Buscar producto:";
            // 
            // btnLimpiar4
            // 
            btnLimpiar4.BackColor = Color.FromArgb(64, 0, 0);
            btnLimpiar4.BackgroundImageLayout = ImageLayout.None;
            btnLimpiar4.Font = new Font("PMingLiU-ExtB", 10F);
            btnLimpiar4.ForeColor = Color.White;
            btnLimpiar4.Location = new Point(230, 103);
            btnLimpiar4.Margin = new Padding(2);
            btnLimpiar4.Name = "btnLimpiar4";
            btnLimpiar4.Size = new Size(121, 34);
            btnLimpiar4.TabIndex = 41;
            btnLimpiar4.Text = "Limpiar";
            btnLimpiar4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(64, 0, 0);
            button6.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(252, 650);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(130, 30);
            button6.TabIndex = 144;
            button6.Text = "Menú principal";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 0, 0);
            button5.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(955, 650);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(99, 27);
            button5.TabIndex = 143;
            button5.Text = "Cerrar Sesión ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.MinimumWidth = 8;
            Código.Name = "Código";
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 125;
            // 
            // Categoría
            // 
            Categoría.HeaderText = "Categoría";
            Categoría.MinimumWidth = 6;
            Categoría.Name = "Categoría";
            Categoría.Width = 120;
            // 
            // Stock_actual
            // 
            Stock_actual.HeaderText = "Stock Actual";
            Stock_actual.MinimumWidth = 6;
            Stock_actual.Name = "Stock_actual";
            Stock_actual.Width = 125;
            // 
            // Stock_minimo
            // 
            Stock_minimo.HeaderText = "Stock Minimo";
            Stock_minimo.MinimumWidth = 6;
            Stock_minimo.Name = "Stock_minimo";
            Stock_minimo.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 120;
            // 
            // Precio_venta
            // 
            Precio_venta.HeaderText = "Precio Venta";
            Precio_venta.MinimumWidth = 6;
            Precio_venta.Name = "Precio_venta";
            Precio_venta.Width = 125;
            // 
            // editar
            // 
            editar.HeaderText = "Editar";
            editar.MinimumWidth = 6;
            editar.Name = "editar";
            editar.Width = 125;
            // 
            // btnActualizar1
            // 
            btnActualizar1.BackColor = Color.FromArgb(64, 0, 0);
            btnActualizar1.BackgroundImageLayout = ImageLayout.None;
            btnActualizar1.Font = new Font("PMingLiU-ExtB", 10F);
            btnActualizar1.ForeColor = Color.White;
            btnActualizar1.Location = new Point(368, 101);
            btnActualizar1.Margin = new Padding(2);
            btnActualizar1.Name = "btnActualizar1";
            btnActualizar1.Size = new Size(121, 34);
            btnActualizar1.TabIndex = 122;
            btnActualizar1.Text = "Actualizar";
            btnActualizar1.UseVisualStyleBackColor = false;
            // 
            // forminventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 690);
            Controls.Add(groupBoxnuevoproducto);
            Controls.Add(groupBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            Name = "forminventario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxnuevoproducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btninventario;
        private Button btnnivelacioninventario;
        private Button btndevolucionventas;
        private Button btncredito;
        private Button btndevolucioncompra;
        private Button btncaja;
        private Button btnusuarios;
        private Button btncompras;
        private Button btnproductos;
        private Button btnproveedores;
        private Button btnventas;
        private Label label11;
        private Label label15;
        private Button btnclientes;
        private Label label16;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private GroupBox groupBoxnuevoproducto;
        private Button btnImprimirreporte;
        private DataGridView dataGridView2;
        private GroupBox groupBox1;
        private CheckBox checkBoxSolostockbajo;
        private ComboBox CBestado1;
        private ComboBox CBcategoria3;
        private Button btnBuscarproducto7;
        private Label label2;
        private Label label13;
        private TextBox txtBuscarproducto;
        private Label label17;
        private Button btnLimpiar4;
        private Button button6;
        private Button button5;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Categoría;
        private DataGridViewTextBoxColumn Stock_actual;
        private DataGridViewTextBoxColumn Stock_minimo;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Precio_venta;
        private DataGridViewTextBoxColumn editar;
        private Button btnActualizar1;
    }
}
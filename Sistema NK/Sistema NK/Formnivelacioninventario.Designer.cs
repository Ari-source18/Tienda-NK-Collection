namespace Sistema_NK
{
    partial class Formnivelacioninventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formnivelacioninventario));
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
            button6 = new Button();
            button5 = new Button();
            groupBoxnuevoproducto = new GroupBox();
            dataGridView1 = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Código = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Tipo_ajuste = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Motivo = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Observaciones = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btnGenerarreporte = new Button();
            CBcantidaddeajuste = new ComboBox();
            label20 = new Label();
            txtObservaciones = new TextBox();
            label17 = new Label();
            CBtipoajuste = new ComboBox();
            label18 = new Label();
            btnCancelar = new Button();
            btnNivelarinventario = new Button();
            CBmotiboajuste = new ComboBox();
            label21 = new Label();
            groupBox1 = new GroupBox();
            btnBuscarcodigo = new Button();
            txtCategoria = new TextBox();
            label12 = new Label();
            txtStockfisico = new TextBox();
            label8 = new Label();
            txtStockensistema = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtCodigo1 = new TextBox();
            txtDiferencia = new TextBox();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxnuevoproducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
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
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // btninventario
            // 
            btninventario.BackColor = Color.Transparent;
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
            btnnivelacioninventario.BackColor = Color.DarkSalmon;
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
            pictureBox1.Location = new Point(999, 10);
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
            label5.Location = new Point(254, 38);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(288, 27);
            label5.TabIndex = 131;
            label5.Text = "Nivelación de inventario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(242, 58);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(824, 27);
            label6.TabIndex = 130;
            label6.Text = "__________________________________________________________";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(64, 0, 0);
            button6.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(262, 650);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(130, 30);
            button6.TabIndex = 140;
            button6.Text = "Menú principal";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 0, 0);
            button5.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(966, 650);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(99, 27);
            button5.TabIndex = 139;
            button5.Text = "Cerrar Sesión ";
            button5.UseVisualStyleBackColor = false;
            // 
            // groupBoxnuevoproducto
            // 
            groupBoxnuevoproducto.BackColor = Color.SeaShell;
            groupBoxnuevoproducto.Controls.Add(dataGridView1);
            groupBoxnuevoproducto.Location = new Point(254, 450);
            groupBoxnuevoproducto.Margin = new Padding(2);
            groupBoxnuevoproducto.Name = "groupBoxnuevoproducto";
            groupBoxnuevoproducto.Padding = new Padding(2);
            groupBoxnuevoproducto.Size = new Size(821, 195);
            groupBoxnuevoproducto.TabIndex = 143;
            groupBoxnuevoproducto.TabStop = false;
            groupBoxnuevoproducto.Text = "Historial de Nivelaciones";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SeaShell;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, Código, Producto, Tipo_ajuste, Cantidad, Motivo, Usuario, Observaciones });
            dataGridView1.Location = new Point(10, 35);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(794, 126);
            dataGridView1.TabIndex = 0;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 8;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.MinimumWidth = 8;
            Código.Name = "Código";
            Código.Width = 125;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 125;
            // 
            // Tipo_ajuste
            // 
            Tipo_ajuste.HeaderText = "Tipo de ajuste";
            Tipo_ajuste.MinimumWidth = 6;
            Tipo_ajuste.Name = "Tipo_ajuste";
            Tipo_ajuste.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // Motivo
            // 
            Motivo.HeaderText = "Motivo";
            Motivo.MinimumWidth = 6;
            Motivo.Name = "Motivo";
            Motivo.Width = 125;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            Usuario.Width = 125;
            // 
            // Observaciones
            // 
            Observaciones.HeaderText = "Observaciones";
            Observaciones.MinimumWidth = 6;
            Observaciones.Name = "Observaciones";
            Observaciones.Width = 200;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SeaShell;
            groupBox2.Controls.Add(btnGenerarreporte);
            groupBox2.Controls.Add(CBcantidaddeajuste);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(txtObservaciones);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(CBtipoajuste);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(btnNivelarinventario);
            groupBox2.Controls.Add(CBmotiboajuste);
            groupBox2.Controls.Add(label21);
            groupBox2.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox2.Location = new Point(257, 240);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(818, 206);
            groupBox2.TabIndex = 142;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ajustes de Nivelación ";
            // 
            // btnGenerarreporte
            // 
            btnGenerarreporte.BackColor = Color.FromArgb(64, 0, 0);
            btnGenerarreporte.BackgroundImageLayout = ImageLayout.None;
            btnGenerarreporte.Font = new Font("PMingLiU-ExtB", 10F);
            btnGenerarreporte.ForeColor = Color.White;
            btnGenerarreporte.Location = new Point(566, 162);
            btnGenerarreporte.Margin = new Padding(2);
            btnGenerarreporte.Name = "btnGenerarreporte";
            btnGenerarreporte.Size = new Size(159, 34);
            btnGenerarreporte.TabIndex = 124;
            btnGenerarreporte.Text = "Generar reporte";
            btnGenerarreporte.UseVisualStyleBackColor = false;
            // 
            // CBcantidaddeajuste
            // 
            CBcantidaddeajuste.Font = new Font("PMingLiU-ExtB", 9F);
            CBcantidaddeajuste.FormattingEnabled = true;
            CBcantidaddeajuste.Location = new Point(293, 56);
            CBcantidaddeajuste.Margin = new Padding(2);
            CBcantidaddeajuste.Name = "CBcantidaddeajuste";
            CBcantidaddeajuste.Size = new Size(229, 23);
            CBcantidaddeajuste.TabIndex = 123;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(64, 0, 0);
            label20.Location = new Point(9, 142);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(105, 17);
            label20.TabIndex = 122;
            label20.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Font = new Font("PMingLiU-ExtB", 9F);
            txtObservaciones.Location = new Point(9, 170);
            txtObservaciones.Margin = new Padding(2);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(513, 25);
            txtObservaciones.TabIndex = 57;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("PMingLiU-ExtB", 10F);
            label17.Location = new Point(7, 84);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(121, 17);
            label17.TabIndex = 56;
            label17.Text = "Motivo del ajuste:";
            // 
            // CBtipoajuste
            // 
            CBtipoajuste.Font = new Font("PMingLiU-ExtB", 9F);
            CBtipoajuste.FormattingEnabled = true;
            CBtipoajuste.Location = new Point(10, 56);
            CBtipoajuste.Margin = new Padding(2);
            CBtipoajuste.Name = "CBtipoajuste";
            CBtipoajuste.Size = new Size(246, 23);
            CBtipoajuste.TabIndex = 112;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("PMingLiU-ExtB", 10F);
            label18.Location = new Point(291, 33);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(133, 17);
            label18.TabIndex = 47;
            label18.Text = "Cantidad de ajustar:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(64, 0, 0);
            btnCancelar.BackgroundImageLayout = ImageLayout.None;
            btnCancelar.Font = new Font("PMingLiU-ExtB", 10F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(566, 106);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 34);
            btnCancelar.TabIndex = 45;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnNivelarinventario
            // 
            btnNivelarinventario.BackColor = Color.FromArgb(64, 0, 0);
            btnNivelarinventario.BackgroundImageLayout = ImageLayout.None;
            btnNivelarinventario.Font = new Font("PMingLiU-ExtB", 10F);
            btnNivelarinventario.ForeColor = Color.White;
            btnNivelarinventario.Location = new Point(566, 45);
            btnNivelarinventario.Margin = new Padding(2);
            btnNivelarinventario.Name = "btnNivelarinventario";
            btnNivelarinventario.Size = new Size(159, 34);
            btnNivelarinventario.TabIndex = 41;
            btnNivelarinventario.Text = "Nivelar Inventario";
            btnNivelarinventario.UseVisualStyleBackColor = false;
            // 
            // CBmotiboajuste
            // 
            CBmotiboajuste.Font = new Font("PMingLiU-ExtB", 9F);
            CBmotiboajuste.FormattingEnabled = true;
            CBmotiboajuste.Location = new Point(9, 117);
            CBmotiboajuste.Margin = new Padding(2);
            CBmotiboajuste.Name = "CBmotiboajuste";
            CBmotiboajuste.Size = new Size(513, 23);
            CBmotiboajuste.TabIndex = 110;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("PMingLiU-ExtB", 10F);
            label21.Location = new Point(7, 32);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(101, 17);
            label21.TabIndex = 37;
            label21.Text = "Tipo de ajuste:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(btnBuscarcodigo);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtStockfisico);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtStockensistema);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCodigo1);
            groupBox1.Controls.Add(txtDiferencia);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(257, 97);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(818, 140);
            groupBox1.TabIndex = 141;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Producto";
            // 
            // btnBuscarcodigo
            // 
            btnBuscarcodigo.BackColor = Color.Transparent;
            btnBuscarcodigo.BackgroundImage = (Image)resources.GetObject("btnBuscarcodigo.BackgroundImage");
            btnBuscarcodigo.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBuscarcodigo.ForeColor = SystemColors.ControlLightLight;
            btnBuscarcodigo.Location = new Point(217, 54);
            btnBuscarcodigo.Margin = new Padding(2);
            btnBuscarcodigo.Name = "btnBuscarcodigo";
            btnBuscarcodigo.Size = new Size(24, 27);
            btnBuscarcodigo.TabIndex = 119;
            btnBuscarcodigo.Text = "Cerrar Sesión ";
            btnBuscarcodigo.UseVisualStyleBackColor = false;
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("PMingLiU-ExtB", 10F);
            txtCategoria.Location = new Point(526, 54);
            txtCategoria.Margin = new Padding(2);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(258, 27);
            txtCategoria.TabIndex = 61;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("PMingLiU-ExtB", 10F);
            label12.Location = new Point(524, 34);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(74, 17);
            label12.TabIndex = 60;
            label12.Text = "Categoría:";
            // 
            // txtStockfisico
            // 
            txtStockfisico.Font = new Font("PMingLiU-ExtB", 10F);
            txtStockfisico.Location = new Point(294, 104);
            txtStockfisico.Margin = new Padding(2);
            txtStockfisico.Name = "txtStockfisico";
            txtStockfisico.Size = new Size(162, 27);
            txtStockfisico.TabIndex = 59;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("PMingLiU-ExtB", 10F);
            label8.Location = new Point(289, 87);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(87, 17);
            label8.TabIndex = 58;
            label8.Text = "Stock físico:";
            // 
            // txtStockensistema
            // 
            txtStockensistema.Font = new Font("PMingLiU-ExtB", 9F);
            txtStockensistema.Location = new Point(10, 106);
            txtStockensistema.Margin = new Padding(2);
            txtStockensistema.Name = "txtStockensistema";
            txtStockensistema.Size = new Size(239, 25);
            txtStockensistema.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("PMingLiU-ExtB", 10F);
            label4.Location = new Point(8, 86);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 17);
            label4.TabIndex = 56;
            label4.Text = "Stock en sistema:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("PMingLiU-ExtB", 10F);
            txtNombre.Location = new Point(294, 54);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(162, 27);
            txtNombre.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 10F);
            label2.Location = new Point(292, 34);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 47;
            label2.Text = "Nombre:";
            // 
            // txtCodigo1
            // 
            txtCodigo1.Font = new Font("PMingLiU-ExtB", 9F);
            txtCodigo1.Location = new Point(10, 56);
            txtCodigo1.Margin = new Padding(2);
            txtCodigo1.Name = "txtCodigo1";
            txtCodigo1.Size = new Size(205, 25);
            txtCodigo1.TabIndex = 46;
            // 
            // txtDiferencia
            // 
            txtDiferencia.Font = new Font("PMingLiU-ExtB", 9F);
            txtDiferencia.Location = new Point(526, 104);
            txtDiferencia.Margin = new Padding(2);
            txtDiferencia.Name = "txtDiferencia";
            txtDiferencia.Size = new Size(146, 25);
            txtDiferencia.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("PMingLiU-ExtB", 10F);
            label9.Location = new Point(524, 88);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(78, 17);
            label9.TabIndex = 38;
            label9.Text = "Diferencia:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("PMingLiU-ExtB", 10F);
            label10.Location = new Point(8, 33);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(59, 17);
            label10.TabIndex = 37;
            label10.Text = "Código:";
            // 
            // Formnivelacioninventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 690);
            Controls.Add(groupBoxnuevoproducto);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            Name = "Formnivelacioninventario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxnuevoproducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Button button6;
        private Button button5;
        private GroupBox groupBoxnuevoproducto;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Tipo_ajuste;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Motivo;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Observaciones;
        private GroupBox groupBox2;
        private Button btnGenerarreporte;
        private ComboBox CBcantidaddeajuste;
        private Label label20;
        private TextBox txtObservaciones;
        private Label label17;
        private ComboBox CBtipoajuste;
        private Label label18;
        private Button btnCancelar;
        private Button btnNivelarinventario;
        private ComboBox CBmotiboajuste;
        private Label label21;
        private GroupBox groupBox1;
        private Button btnBuscarcodigo;
        private TextBox txtCategoria;
        private Label label12;
        private TextBox txtStockfisico;
        private Label label8;
        private TextBox txtStockensistema;
        private Label label4;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtCodigo1;
        private TextBox txtDiferencia;
        private Label label9;
        private Label label10;
    }
}
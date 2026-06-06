namespace Sistema_NK
{
    partial class Formventas
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formventas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            btninventario = new Button();
            btnnivelacioninventario = new Button();
            btndevolucionventas = new Button();
            btncredito = new Button();
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
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_agregar_cliente = new Button();
            imageList1 = new ImageList(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label13 = new Label();
            label14 = new Label();
            label17 = new Label();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            comboBox2 = new ComboBox();
            textBox8 = new TextBox();
            button1 = new Button();
            dtgw_ventas = new DataGridView();
            Clm_producto = new DataGridViewTextBoxColumn();
            Clm_Cantidad = new DataGridViewTextBoxColumn();
            Clm_Precio = new DataGridViewTextBoxColumn();
            Clm_IVA = new DataGridViewTextBoxColumn();
            Clm_Descuento = new DataGridViewTextBoxColumn();
            Clm_Subtotal = new DataGridViewTextBoxColumn();
            Clm_Editar = new DataGridViewTextBoxColumn();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            label12 = new Label();
            rdb_Tarjeta = new RadioButton();
            rdb_Credito = new RadioButton();
            rdb_Efectivo = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgw_ventas).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagen_circular_recortada;
            pictureBox1.Location = new Point(1496, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 98;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(300, 9);
            label5.Name = "label5";
            label5.Size = new Size(251, 32);
            label5.TabIndex = 96;
            label5.Text = "Gestión de Ventas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(292, 21);
            label6.Name = "label6";
            label6.Size = new Size(1198, 32);
            label6.TabIndex = 95;
            label6.Text = "__________________________________________________________________________";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Controls.Add(btninventario);
            panel1.Controls.Add(btnnivelacioninventario);
            panel1.Controls.Add(btndevolucionventas);
            panel1.Controls.Add(btncredito);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 877);
            panel1.TabIndex = 107;
            // 
            // btninventario
            // 
            btninventario.BackColor = Color.Transparent;
            btninventario.FlatAppearance.BorderSize = 0;
            btninventario.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btninventario.FlatAppearance.MouseOverBackColor = Color.Tan;
            btninventario.FlatStyle = FlatStyle.Flat;
            btninventario.Font = new Font("PMingLiU-ExtB", 12F);
            btninventario.ForeColor = Color.White;
            btninventario.ImageAlign = ContentAlignment.MiddleLeft;
            btninventario.Location = new Point(58, 811);
            btninventario.Name = "btninventario";
            btninventario.Size = new Size(167, 38);
            btninventario.TabIndex = 56;
            btninventario.Text = "Inventario";
            btninventario.UseVisualStyleBackColor = false;
            btninventario.Click += btninventario_Click_1;
            // 
            // btnnivelacioninventario
            // 
            btnnivelacioninventario.BackColor = Color.Transparent;
            btnnivelacioninventario.FlatAppearance.BorderSize = 0;
            btnnivelacioninventario.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnnivelacioninventario.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnnivelacioninventario.FlatStyle = FlatStyle.Flat;
            btnnivelacioninventario.Font = new Font("PMingLiU-ExtB", 12F);
            btnnivelacioninventario.ForeColor = Color.White;
            btnnivelacioninventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnnivelacioninventario.Location = new Point(20, 756);
            btnnivelacioninventario.Name = "btnnivelacioninventario";
            btnnivelacioninventario.Size = new Size(244, 38);
            btnnivelacioninventario.TabIndex = 55;
            btnnivelacioninventario.Text = "Nivelación de inventario";
            btnnivelacioninventario.UseVisualStyleBackColor = false;
            btnnivelacioninventario.Click += btnnivelacioninventario_Click_1;
            // 
            // btndevolucionventas
            // 
            btndevolucionventas.BackColor = Color.Transparent;
            btndevolucionventas.FlatAppearance.BorderSize = 0;
            btndevolucionventas.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btndevolucionventas.FlatAppearance.MouseOverBackColor = Color.Tan;
            btndevolucionventas.FlatStyle = FlatStyle.Flat;
            btndevolucionventas.Font = new Font("PMingLiU-ExtB", 12F);
            btndevolucionventas.ForeColor = Color.White;
            btndevolucionventas.ImageAlign = ContentAlignment.MiddleLeft;
            btndevolucionventas.Location = new Point(34, 629);
            btndevolucionventas.Name = "btndevolucionventas";
            btndevolucionventas.Size = new Size(218, 38);
            btndevolucionventas.TabIndex = 54;
            btndevolucionventas.Text = "Devolución Ventas";
            btndevolucionventas.UseVisualStyleBackColor = false;
            btndevolucionventas.Click += btndevolucionventas_Click_1;
            // 
            // btncredito
            // 
            btncredito.BackColor = Color.Transparent;
            btncredito.FlatAppearance.BorderSize = 0;
            btncredito.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btncredito.FlatAppearance.MouseOverBackColor = Color.Tan;
            btncredito.FlatStyle = FlatStyle.Flat;
            btncredito.Font = new Font("PMingLiU-ExtB", 12F);
            btncredito.ForeColor = Color.White;
            btncredito.ImageAlign = ContentAlignment.MiddleLeft;
            btncredito.Location = new Point(58, 560);
            btncredito.Name = "btncredito";
            btncredito.Size = new Size(167, 38);
            btncredito.TabIndex = 53;
            btncredito.Text = "Crédito";
            btncredito.UseVisualStyleBackColor = false;
            btncredito.Click += btncredito_Click_1;
            // 
            // btncaja
            // 
            btncaja.BackColor = Color.Transparent;
            btncaja.FlatAppearance.BorderSize = 0;
            btncaja.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btncaja.FlatAppearance.MouseOverBackColor = Color.Tan;
            btncaja.FlatStyle = FlatStyle.Flat;
            btncaja.Font = new Font("PMingLiU-ExtB", 12F);
            btncaja.ForeColor = Color.White;
            btncaja.ImageAlign = ContentAlignment.MiddleLeft;
            btncaja.Location = new Point(58, 429);
            btncaja.Name = "btncaja";
            btncaja.Size = new Size(167, 38);
            btncaja.TabIndex = 51;
            btncaja.Text = "Caja";
            btncaja.UseVisualStyleBackColor = false;
            btncaja.Click += btncaja_Click_1;
            // 
            // btnusuarios
            // 
            btnusuarios.BackColor = Color.Transparent;
            btnusuarios.FlatAppearance.BorderSize = 0;
            btnusuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnusuarios.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnusuarios.FlatStyle = FlatStyle.Flat;
            btnusuarios.Font = new Font("PMingLiU-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnusuarios.ForeColor = Color.White;
            btnusuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnusuarios.Location = new Point(58, 121);
            btnusuarios.Name = "btnusuarios";
            btnusuarios.Size = new Size(167, 38);
            btnusuarios.TabIndex = 50;
            btnusuarios.Text = "Usuarios";
            btnusuarios.UseVisualStyleBackColor = false;
            btnusuarios.Click += btnusuarios_Click_1;
            // 
            // btncompras
            // 
            btncompras.BackColor = Color.Transparent;
            btncompras.FlatAppearance.BorderSize = 0;
            btncompras.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btncompras.FlatAppearance.MouseOverBackColor = Color.Tan;
            btncompras.FlatStyle = FlatStyle.Flat;
            btncompras.Font = new Font("PMingLiU-ExtB", 12F);
            btncompras.ForeColor = Color.White;
            btncompras.ImageAlign = ContentAlignment.MiddleLeft;
            btncompras.Location = new Point(58, 363);
            btncompras.Name = "btncompras";
            btncompras.Size = new Size(167, 38);
            btncompras.TabIndex = 49;
            btncompras.Text = "Compras";
            btncompras.UseVisualStyleBackColor = false;
            btncompras.Click += btncompras_Click_1;
            // 
            // btnproductos
            // 
            btnproductos.BackColor = Color.Transparent;
            btnproductos.FlatAppearance.BorderSize = 0;
            btnproductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnproductos.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnproductos.FlatStyle = FlatStyle.Flat;
            btnproductos.Font = new Font("PMingLiU-ExtB", 12F);
            btnproductos.ForeColor = Color.White;
            btnproductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnproductos.Location = new Point(58, 304);
            btnproductos.Name = "btnproductos";
            btnproductos.Size = new Size(167, 38);
            btnproductos.TabIndex = 48;
            btnproductos.Text = "Productos";
            btnproductos.UseVisualStyleBackColor = false;
            btnproductos.Click += btnproductos_Click_1;
            // 
            // btnproveedores
            // 
            btnproveedores.BackColor = Color.Transparent;
            btnproveedores.FlatAppearance.BorderSize = 0;
            btnproveedores.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnproveedores.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnproveedores.FlatStyle = FlatStyle.Flat;
            btnproveedores.Font = new Font("PMingLiU-ExtB", 12F);
            btnproveedores.ForeColor = Color.White;
            btnproveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnproveedores.Location = new Point(58, 241);
            btnproveedores.Name = "btnproveedores";
            btnproveedores.Size = new Size(167, 38);
            btnproveedores.TabIndex = 47;
            btnproveedores.Text = "Proveedores";
            btnproveedores.UseVisualStyleBackColor = false;
            btnproveedores.Click += btnproveedores_Click_1;
            // 
            // btnventas
            // 
            btnventas.BackColor = Color.DarkSalmon;
            btnventas.FlatAppearance.BorderSize = 0;
            btnventas.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnventas.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnventas.FlatStyle = FlatStyle.Flat;
            btnventas.Font = new Font("PMingLiU-ExtB", 12F);
            btnventas.ForeColor = Color.White;
            btnventas.ImageAlign = ContentAlignment.MiddleLeft;
            btnventas.Location = new Point(58, 495);
            btnventas.Name = "btnventas";
            btnventas.Size = new Size(167, 38);
            btnventas.TabIndex = 46;
            btnventas.Text = "Ventas";
            btnventas.UseVisualStyleBackColor = false;
            btnventas.Click += btnventas_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(7, 31);
            label11.Name = "label11";
            label11.Size = new Size(84, 57);
            label11.TabIndex = 43;
            label11.Text = "NK";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(86, 48);
            label15.Name = "label15";
            label15.Size = new Size(178, 28);
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
            btnclientes.Font = new Font("PMingLiU-ExtB", 12F);
            btnclientes.ForeColor = Color.White;
            btnclientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnclientes.Location = new Point(58, 177);
            btnclientes.Name = "btnclientes";
            btnclientes.Size = new Size(167, 38);
            btnclientes.TabIndex = 34;
            btnclientes.Text = "Clientes";
            btnclientes.UseVisualStyleBackColor = false;
            btnclientes.Click += btnclientes_Click_1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(18, 76);
            label16.Name = "label16";
            label16.Size = new Size(246, 28);
            label16.TabIndex = 45;
            label16.Text = "__________________";
            // 
            // button5
            // 
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 145;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(300, 66);
            label1.Name = "label1";
            label1.Size = new Size(179, 22);
            label1.TabIndex = 108;
            label1.Text = "Datos del Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(300, 103);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 109;
            label2.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(746, 103);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 110;
            label3.Text = "Cédula:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(479, 103);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 111;
            label4.Text = "Nombre del cliente:";
            // 
            // btn_agregar_cliente
            // 
            btn_agregar_cliente.BackColor = Color.Maroon;
            btn_agregar_cliente.Font = new Font("PMingLiU-ExtB", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar_cliente.ForeColor = SystemColors.ControlLightLight;
            btn_agregar_cliente.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agregar_cliente.ImageIndex = 0;
            btn_agregar_cliente.ImageList = imageList1;
            btn_agregar_cliente.Location = new Point(1311, 103);
            btn_agregar_cliente.Name = "btn_agregar_cliente";
            btn_agregar_cliente.Size = new Size(97, 36);
            btn_agregar_cliente.TabIndex = 112;
            btn_agregar_cliente.Text = "Cliente";
            btn_agregar_cliente.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-más-24.png");
            imageList1.Images.SetKeyName(1, "icons8-agregar-48.png");
            // 
            // textBox1
            // 
            textBox1.Location = new Point(300, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 31);
            textBox1.TabIndex = 113;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(479, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 31);
            textBox2.TabIndex = 114;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(746, 126);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 31);
            textBox3.TabIndex = 115;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("PMingLiU-ExtB", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(300, 177);
            label7.Name = "label7";
            label7.Size = new Size(91, 22);
            label7.TabIndex = 116;
            label7.Text = "Agregar:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(985, 103);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 117;
            label8.Text = "Dirección:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(985, 126);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(320, 31);
            textBox4.TabIndex = 118;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(64, 0, 0);
            label9.Location = new Point(300, 218);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 119;
            label9.Text = "Producto:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(64, 0, 0);
            label10.Location = new Point(554, 218);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 120;
            label10.Text = "Código:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(64, 0, 0);
            label13.Location = new Point(746, 218);
            label13.Name = "label13";
            label13.Size = new Size(80, 20);
            label13.TabIndex = 122;
            label13.Text = "Cantidad:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(64, 0, 0);
            label14.Location = new Point(1284, 218);
            label14.Name = "label14";
            label14.Size = new Size(60, 20);
            label14.TabIndex = 123;
            label14.Text = "Precio:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(64, 0, 0);
            label17.Location = new Point(1105, 218);
            label17.Name = "label17";
            label17.Size = new Size(86, 20);
            label17.TabIndex = 124;
            label17.Text = "Categoría:";
            // 
            // comboBox1
            // 
            comboBox1.Location = new Point(300, 248);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 33);
            comboBox1.TabIndex = 143;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(554, 248);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(165, 31);
            textBox5.TabIndex = 126;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(746, 248);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(165, 31);
            textBox6.TabIndex = 127;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(936, 246);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(135, 31);
            textBox7.TabIndex = 128;
            // 
            // comboBox2
            // 
            comboBox2.Location = new Point(1105, 246);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(161, 33);
            comboBox2.TabIndex = 142;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(1284, 244);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(124, 31);
            textBox8.TabIndex = 130;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 1;
            button1.ImageList = imageList1;
            button1.Location = new Point(1295, 291);
            button1.Name = "button1";
            button1.Size = new Size(113, 41);
            button1.TabIndex = 131;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            // 
            // dtgw_ventas
            // 
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dtgw_ventas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgw_ventas.BackgroundColor = SystemColors.InactiveBorder;
            dtgw_ventas.BorderStyle = BorderStyle.None;
            dtgw_ventas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgw_ventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgw_ventas.Columns.AddRange(new DataGridViewColumn[] { Clm_producto, Clm_Cantidad, Clm_Precio, Clm_IVA, Clm_Descuento, Clm_Subtotal, Clm_Editar });
            dtgw_ventas.Location = new Point(292, 338);
            dtgw_ventas.Name = "dtgw_ventas";
            dtgw_ventas.RowHeadersWidth = 62;
            dtgw_ventas.Size = new Size(1116, 315);
            dtgw_ventas.TabIndex = 132;
            // 
            // Clm_producto
            // 
            Clm_producto.HeaderText = "Producto";
            Clm_producto.MinimumWidth = 8;
            Clm_producto.Name = "Clm_producto";
            Clm_producto.Width = 150;
            // 
            // Clm_Cantidad
            // 
            Clm_Cantidad.HeaderText = "Cantidad";
            Clm_Cantidad.MinimumWidth = 8;
            Clm_Cantidad.Name = "Clm_Cantidad";
            Clm_Cantidad.Width = 150;
            // 
            // Clm_Precio
            // 
            Clm_Precio.HeaderText = "Precio ";
            Clm_Precio.MinimumWidth = 8;
            Clm_Precio.Name = "Clm_Precio";
            Clm_Precio.Width = 150;
            // 
            // Clm_IVA
            // 
            Clm_IVA.HeaderText = "IVA";
            Clm_IVA.MinimumWidth = 8;
            Clm_IVA.Name = "Clm_IVA";
            Clm_IVA.Width = 150;
            // 
            // Clm_Descuento
            // 
            Clm_Descuento.HeaderText = "Descuento";
            Clm_Descuento.MinimumWidth = 8;
            Clm_Descuento.Name = "Clm_Descuento";
            Clm_Descuento.Width = 150;
            // 
            // Clm_Subtotal
            // 
            Clm_Subtotal.HeaderText = "Subtotal";
            Clm_Subtotal.MinimumWidth = 8;
            Clm_Subtotal.Name = "Clm_Subtotal";
            Clm_Subtotal.Width = 150;
            // 
            // Clm_Editar
            // 
            Clm_Editar.HeaderText = "Editar";
            Clm_Editar.MinimumWidth = 8;
            Clm_Editar.Name = "Clm_Editar";
            Clm_Editar.Width = 150;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(64, 0, 0);
            label18.Location = new Point(1426, 363);
            label18.Name = "label18";
            label18.Size = new Size(69, 20);
            label18.TabIndex = 133;
            label18.Text = "Subtotal";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.FromArgb(64, 0, 0);
            label19.Location = new Point(1427, 542);
            label19.Name = "label19";
            label19.Size = new Size(68, 20);
            label19.TabIndex = 134;
            label19.Text = "Cambio";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(64, 0, 0);
            label20.Location = new Point(1426, 485);
            label20.Name = "label20";
            label20.Size = new Size(47, 20);
            label20.TabIndex = 135;
            label20.Text = "Total";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.FromArgb(64, 0, 0);
            label21.Location = new Point(1426, 420);
            label21.Name = "label21";
            label21.Size = new Size(86, 20);
            label21.TabIndex = 136;
            label21.Text = "Descuento";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(1426, 567);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(135, 31);
            textBox9.TabIndex = 137;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(1427, 508);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 31);
            textBox10.TabIndex = 141;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(1426, 443);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(135, 31);
            textBox11.TabIndex = 139;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(1426, 386);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(135, 31);
            textBox12.TabIndex = 140;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(64, 0, 0);
            label12.Location = new Point(936, 218);
            label12.Name = "label12";
            label12.Size = new Size(91, 20);
            label12.TabIndex = 146;
            label12.Text = "Descuento:";
            // 
            // rdb_Tarjeta
            // 
            rdb_Tarjeta.AutoSize = true;
            rdb_Tarjeta.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdb_Tarjeta.ForeColor = Color.FromArgb(64, 0, 0);
            rdb_Tarjeta.Location = new Point(300, 679);
            rdb_Tarjeta.Name = "rdb_Tarjeta";
            rdb_Tarjeta.Size = new Size(90, 22);
            rdb_Tarjeta.TabIndex = 147;
            rdb_Tarjeta.TabStop = true;
            rdb_Tarjeta.Text = "Tarjeta";
            rdb_Tarjeta.UseVisualStyleBackColor = true;
            // 
            // rdb_Credito
            // 
            rdb_Credito.AutoSize = true;
            rdb_Credito.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdb_Credito.ForeColor = Color.FromArgb(64, 0, 0);
            rdb_Credito.Location = new Point(427, 679);
            rdb_Credito.Name = "rdb_Credito";
            rdb_Credito.Size = new Size(91, 22);
            rdb_Credito.TabIndex = 148;
            rdb_Credito.TabStop = true;
            rdb_Credito.Text = "Crédito";
            rdb_Credito.UseVisualStyleBackColor = true;
            // 
            // rdb_Efectivo
            // 
            rdb_Efectivo.AutoSize = true;
            rdb_Efectivo.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdb_Efectivo.ForeColor = Color.FromArgb(64, 0, 0);
            rdb_Efectivo.Location = new Point(544, 679);
            rdb_Efectivo.Name = "rdb_Efectivo";
            rdb_Efectivo.Size = new Size(99, 22);
            rdb_Efectivo.TabIndex = 149;
            rdb_Efectivo.TabStop = true;
            rdb_Efectivo.Text = "Efectivo";
            rdb_Efectivo.UseVisualStyleBackColor = true;
            // 
            // Formventas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1576, 877);
            Controls.Add(rdb_Efectivo);
            Controls.Add(rdb_Credito);
            Controls.Add(rdb_Tarjeta);
            Controls.Add(label12);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(dtgw_ventas);
            Controls.Add(button1);
            Controls.Add(textBox8);
            Controls.Add(comboBox2);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(comboBox1);
            Controls.Add(label17);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn_agregar_cliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Formventas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgw_ventas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Button btninventario;
        private Button btnnivelacioninventario;
        private Button btndevolucionventas;
        private Button btncredito;
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
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_agregar_cliente;
        private ImageList imageList1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label7;
        private Label label8;
        private TextBox textBox4;
        private Label label9;
        private Label label10;
        private Label label13;
        private Label label14;
        private Label label17;
        private ComboBox comboBox1;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private ComboBox comboBox2;
        private TextBox textBox8;
        private Button button1;
        private DataGridView dtgw_ventas;
        private DataGridViewTextBoxColumn Clm_producto;
        private DataGridViewTextBoxColumn Clm_Cantidad;
        private DataGridViewTextBoxColumn Clm_Precio;
        private DataGridViewTextBoxColumn Clm_IVA;
        private DataGridViewTextBoxColumn Clm_Descuento;
        private DataGridViewTextBoxColumn Clm_Subtotal;
        private DataGridViewTextBoxColumn Clm_Editar;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private Label label12;
        private RadioButton rdb_Tarjeta;
        private RadioButton rdb_Credito;
        private RadioButton rdb_Efectivo;
    }
}
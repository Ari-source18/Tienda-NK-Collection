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
            textBox13 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            button2 = new Button();
            lbl_efectivo_cordobas = new Label();
            lbl_efectivo_dolares = new Label();
            txt_efectivo_cordobas = new TextBox();
            txt_efectivo_dolares = new TextBox();
            lbl_numero_referencia = new Label();
            lbl_cantidad = new Label();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            date_credito = new DateTimePicker();
            lbl_interes = new Label();
            txt_interes = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgw_ventas).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagen_circular_recortada;
            pictureBox1.Location = new Point(1253, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 98;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(45, 41);
            label5.Name = "label5";
            label5.Size = new Size(251, 32);
            label5.TabIndex = 96;
            label5.Text = "Gestión de Ventas";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(37, 53);
            label6.Name = "label6";
            label6.Size = new Size(1198, 32);
            label6.TabIndex = 95;
            label6.Text = "__________________________________________________________________________";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(45, 98);
            label1.Name = "label1";
            label1.Size = new Size(179, 22);
            label1.TabIndex = 108;
            label1.Text = "Datos del Cliente:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(45, 135);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 109;
            label2.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(491, 135);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 110;
            label3.Text = "Cédula:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(224, 135);
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
            btn_agregar_cliente.Location = new Point(1056, 155);
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
            imageList1.Images.SetKeyName(2, "icons8-cancelar-30.png");
            imageList1.Images.SetKeyName(3, "icons8-documento-67.png");
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Location = new Point(45, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 31);
            textBox1.TabIndex = 113;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.Location = new Point(224, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 31);
            textBox2.TabIndex = 114;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox3.Location = new Point(491, 158);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 31);
            textBox3.TabIndex = 115;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("PMingLiU-ExtB", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(45, 209);
            label7.Name = "label7";
            label7.Size = new Size(192, 22);
            label7.TabIndex = 116;
            label7.Text = "Datos del producto:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(730, 135);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 117;
            label8.Text = "Dirección:";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox4.Location = new Point(730, 158);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(320, 31);
            textBox4.TabIndex = 118;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(64, 0, 0);
            label9.Location = new Point(45, 250);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 119;
            label9.Text = "Producto:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(64, 0, 0);
            label10.Location = new Point(299, 250);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 120;
            label10.Text = "Código:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(64, 0, 0);
            label13.Location = new Point(850, 250);
            label13.Name = "label13";
            label13.Size = new Size(80, 20);
            label13.TabIndex = 122;
            label13.Text = "Cantidad:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(64, 0, 0);
            label14.Location = new Point(1029, 250);
            label14.Name = "label14";
            label14.Size = new Size(60, 20);
            label14.TabIndex = 123;
            label14.Text = "Precio:";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(64, 0, 0);
            label17.Location = new Point(491, 250);
            label17.Name = "label17";
            label17.Size = new Size(86, 20);
            label17.TabIndex = 124;
            label17.Text = "Categoría:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox1.Location = new Point(45, 280);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 33);
            comboBox1.TabIndex = 143;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox5.Location = new Point(299, 280);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(165, 31);
            textBox5.TabIndex = 126;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox6.Location = new Point(850, 276);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(165, 31);
            textBox6.TabIndex = 127;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox7.Location = new Point(681, 278);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(135, 31);
            textBox7.TabIndex = 128;
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox8.Location = new Point(1029, 276);
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
            button1.Location = new Point(45, 323);
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
            dtgw_ventas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgw_ventas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgw_ventas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            dtgw_ventas.BackgroundColor = SystemColors.InactiveBorder;
            dtgw_ventas.BorderStyle = BorderStyle.None;
            dtgw_ventas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgw_ventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgw_ventas.Columns.AddRange(new DataGridViewColumn[] { Clm_producto, Clm_Cantidad, Clm_Precio, Clm_IVA, Clm_Descuento, Clm_Subtotal, Clm_Editar });
            dtgw_ventas.Cursor = Cursors.Hand;
            dtgw_ventas.Location = new Point(45, 370);
            dtgw_ventas.Name = "dtgw_ventas";
            dtgw_ventas.RowHeadersWidth = 62;
            dtgw_ventas.Size = new Size(1108, 315);
            dtgw_ventas.TabIndex = 132;
            // 
            // Clm_producto
            // 
            Clm_producto.HeaderText = "Producto";
            Clm_producto.MinimumWidth = 8;
            Clm_producto.Name = "Clm_producto";
            // 
            // Clm_Cantidad
            // 
            Clm_Cantidad.HeaderText = "Cantidad";
            Clm_Cantidad.MinimumWidth = 8;
            Clm_Cantidad.Name = "Clm_Cantidad";
            // 
            // Clm_Precio
            // 
            Clm_Precio.HeaderText = "Precio ";
            Clm_Precio.MinimumWidth = 8;
            Clm_Precio.Name = "Clm_Precio";
            // 
            // Clm_IVA
            // 
            Clm_IVA.HeaderText = "IVA";
            Clm_IVA.MinimumWidth = 8;
            Clm_IVA.Name = "Clm_IVA";
            // 
            // Clm_Descuento
            // 
            Clm_Descuento.HeaderText = "Descuento";
            Clm_Descuento.MinimumWidth = 8;
            Clm_Descuento.Name = "Clm_Descuento";
            // 
            // Clm_Subtotal
            // 
            Clm_Subtotal.HeaderText = "Subtotal";
            Clm_Subtotal.MinimumWidth = 8;
            Clm_Subtotal.Name = "Clm_Subtotal";
            // 
            // Clm_Editar
            // 
            Clm_Editar.HeaderText = "Editar";
            Clm_Editar.MinimumWidth = 8;
            Clm_Editar.Name = "Clm_Editar";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(64, 0, 0);
            label18.Location = new Point(1171, 395);
            label18.Name = "label18";
            label18.Size = new Size(69, 20);
            label18.TabIndex = 133;
            label18.Text = "Subtotal";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.FromArgb(64, 0, 0);
            label19.Location = new Point(1172, 574);
            label19.Name = "label19";
            label19.Size = new Size(68, 20);
            label19.TabIndex = 134;
            label19.Text = "Cambio";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(64, 0, 0);
            label20.Location = new Point(1171, 517);
            label20.Name = "label20";
            label20.Size = new Size(47, 20);
            label20.TabIndex = 135;
            label20.Text = "Total";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label21.AutoSize = true;
            label21.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.FromArgb(64, 0, 0);
            label21.Location = new Point(1171, 452);
            label21.Name = "label21";
            label21.Size = new Size(86, 20);
            label21.TabIndex = 136;
            label21.Text = "Descuento";
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox9.Location = new Point(1171, 599);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(135, 31);
            textBox9.TabIndex = 137;
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox10.Location = new Point(1172, 540);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(134, 31);
            textBox10.TabIndex = 141;
            // 
            // textBox11
            // 
            textBox11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox11.Location = new Point(1171, 475);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(135, 31);
            textBox11.TabIndex = 139;
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox12.Location = new Point(1171, 418);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(135, 31);
            textBox12.TabIndex = 140;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(64, 0, 0);
            label12.Location = new Point(681, 250);
            label12.Name = "label12";
            label12.Size = new Size(91, 20);
            label12.TabIndex = 146;
            label12.Text = "Descuento:";
            // 
            // rdb_Tarjeta
            // 
            rdb_Tarjeta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rdb_Tarjeta.AutoSize = true;
            rdb_Tarjeta.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdb_Tarjeta.ForeColor = Color.FromArgb(64, 0, 0);
            rdb_Tarjeta.Location = new Point(45, 711);
            rdb_Tarjeta.Name = "rdb_Tarjeta";
            rdb_Tarjeta.Size = new Size(90, 22);
            rdb_Tarjeta.TabIndex = 147;
            rdb_Tarjeta.TabStop = true;
            rdb_Tarjeta.Text = "Tarjeta";
            rdb_Tarjeta.UseVisualStyleBackColor = true;
            // 
            // rdb_Credito
            // 
            rdb_Credito.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rdb_Credito.AutoSize = true;
            rdb_Credito.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdb_Credito.ForeColor = Color.FromArgb(64, 0, 0);
            rdb_Credito.Location = new Point(172, 711);
            rdb_Credito.Name = "rdb_Credito";
            rdb_Credito.Size = new Size(91, 22);
            rdb_Credito.TabIndex = 148;
            rdb_Credito.TabStop = true;
            rdb_Credito.Text = "Crédito";
            rdb_Credito.UseVisualStyleBackColor = true;
            // 
            // rdb_Efectivo
            // 
            rdb_Efectivo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rdb_Efectivo.AutoSize = true;
            rdb_Efectivo.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdb_Efectivo.ForeColor = Color.FromArgb(64, 0, 0);
            rdb_Efectivo.Location = new Point(289, 711);
            rdb_Efectivo.Name = "rdb_Efectivo";
            rdb_Efectivo.Size = new Size(99, 22);
            rdb_Efectivo.TabIndex = 149;
            rdb_Efectivo.TabStop = true;
            rdb_Efectivo.Text = "Efectivo";
            rdb_Efectivo.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            textBox13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox13.Location = new Point(491, 280);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(165, 31);
            textBox13.TabIndex = 150;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 26);
            panel1.TabIndex = 151;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 0);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1345, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(26, 798);
            panel2.TabIndex = 152;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 0, 0);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(26, 798);
            panel3.TabIndex = 153;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 0, 0);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(26, 798);
            panel4.Name = "panel4";
            panel4.Size = new Size(1319, 26);
            panel4.TabIndex = 154;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageIndex = 2;
            button2.ImageList = imageList1;
            button2.Location = new Point(172, 323);
            button2.Name = "button2";
            button2.Size = new Size(113, 41);
            button2.TabIndex = 155;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // lbl_efectivo_cordobas
            // 
            lbl_efectivo_cordobas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_efectivo_cordobas.AutoSize = true;
            lbl_efectivo_cordobas.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_efectivo_cordobas.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_efectivo_cordobas.Location = new Point(730, 764);
            lbl_efectivo_cordobas.Name = "lbl_efectivo_cordobas";
            lbl_efectivo_cordobas.Size = new Size(102, 20);
            lbl_efectivo_cordobas.TabIndex = 156;
            lbl_efectivo_cordobas.Text = "Efectivo C$:";
            // 
            // lbl_efectivo_dolares
            // 
            lbl_efectivo_dolares.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_efectivo_dolares.AutoSize = true;
            lbl_efectivo_dolares.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_efectivo_dolares.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_efectivo_dolares.Location = new Point(949, 764);
            lbl_efectivo_dolares.Name = "lbl_efectivo_dolares";
            lbl_efectivo_dolares.Size = new Size(89, 20);
            lbl_efectivo_dolares.TabIndex = 157;
            lbl_efectivo_dolares.Text = "Efectivo $:";
            // 
            // txt_efectivo_cordobas
            // 
            txt_efectivo_cordobas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txt_efectivo_cordobas.Location = new Point(834, 753);
            txt_efectivo_cordobas.Name = "txt_efectivo_cordobas";
            txt_efectivo_cordobas.Size = new Size(109, 31);
            txt_efectivo_cordobas.TabIndex = 159;
            // 
            // txt_efectivo_dolares
            // 
            txt_efectivo_dolares.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txt_efectivo_dolares.Location = new Point(1044, 753);
            txt_efectivo_dolares.Name = "txt_efectivo_dolares";
            txt_efectivo_dolares.Size = new Size(109, 31);
            txt_efectivo_dolares.TabIndex = 160;
            // 
            // lbl_numero_referencia
            // 
            lbl_numero_referencia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_numero_referencia.AutoSize = true;
            lbl_numero_referencia.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_numero_referencia.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_numero_referencia.Location = new Point(88, 764);
            lbl_numero_referencia.Name = "lbl_numero_referencia";
            lbl_numero_referencia.Size = new Size(175, 20);
            lbl_numero_referencia.TabIndex = 161;
            lbl_numero_referencia.Text = "Número de referencia:";
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_cantidad.AutoSize = true;
            lbl_cantidad.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_cantidad.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_cantidad.Location = new Point(479, 764);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(80, 20);
            lbl_cantidad.TabIndex = 162;
            lbl_cantidad.Text = "Cantidad:";
            // 
            // textBox14
            // 
            textBox14.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox14.Location = new Point(565, 757);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(109, 31);
            textBox14.TabIndex = 163;
            // 
            // textBox15
            // 
            textBox15.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox15.Location = new Point(269, 757);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(204, 31);
            textBox15.TabIndex = 164;
            // 
            // date_credito
            // 
            date_credito.Location = new Point(479, 720);
            date_credito.Name = "date_credito";
            date_credito.Size = new Size(300, 31);
            date_credito.TabIndex = 166;
            // 
            // lbl_interes
            // 
            lbl_interes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_interes.AutoSize = true;
            lbl_interes.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_interes.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_interes.Location = new Point(802, 720);
            lbl_interes.Name = "lbl_interes";
            lbl_interes.Size = new Size(64, 20);
            lbl_interes.TabIndex = 167;
            lbl_interes.Text = "Interés:";
            // 
            // txt_interes
            // 
            txt_interes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txt_interes.Location = new Point(872, 716);
            txt_interes.Name = "txt_interes";
            txt_interes.Size = new Size(109, 31);
            txt_interes.TabIndex = 168;
            // 
            // button4
            // 
            button4.BackColor = Color.Maroon;
            button4.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.ImageIndex = 3;
            button4.ImageList = imageList1;
            button4.Location = new Point(1193, 743);
            button4.Name = "button4";
            button4.Size = new Size(129, 41);
            button4.TabIndex = 170;
            button4.Text = "Registrar";
            button4.UseVisualStyleBackColor = false;
            // 
            // Formventas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 824);
            Controls.Add(button4);
            Controls.Add(txt_interes);
            Controls.Add(lbl_interes);
            Controls.Add(date_credito);
            Controls.Add(textBox15);
            Controls.Add(textBox14);
            Controls.Add(lbl_cantidad);
            Controls.Add(lbl_numero_referencia);
            Controls.Add(txt_efectivo_dolares);
            Controls.Add(txt_efectivo_cordobas);
            Controls.Add(lbl_efectivo_dolares);
            Controls.Add(lbl_efectivo_cordobas);
            Controls.Add(button2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox13);
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
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formventas";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgw_ventas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
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
        private TextBox textBox13;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button2;
        private Label lbl_efectivo_cordobas;
        private Label lbl_efectivo_dolares;
        private TextBox txt_efectivo_cordobas;
        private TextBox txt_efectivo_dolares;
        private Label lbl_numero_referencia;
        private Label lbl_cantidad;
        private TextBox textBox14;
        private TextBox textBox15;
        private DateTimePicker date_credito;
        private Label lbl_interes;
        private TextBox txt_interes;
        private Button button4;
    }
}
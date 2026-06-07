namespace Sistema_NK
{
    partial class Formcontroldeegresos
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
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
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
            groupBox1 = new GroupBox();
            label12 = new Label();
            label2 = new Label();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            CBconcepto = new ComboBox();
            btnBuscar = new Button();
            btnImprimir = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Concepto = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Responsable = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            button6 = new Button();
            button5 = new Button();
            txtTotalegresado = new TextBox();
            txtTotaldeegresos = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagen_circular_recortada;
            pictureBox1.Location = new Point(1007, 10);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 136;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(262, 38);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(319, 27);
            label5.TabIndex = 135;
            label5.Text = "Control de Egresos de Caja";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(250, 58);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(824, 27);
            label6.TabIndex = 134;
            label6.Text = "__________________________________________________________";
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
            panel1.TabIndex = 133;
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
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(btnImprimir);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(CBconcepto);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(263, 97);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(818, 111);
            groupBox1.TabIndex = 142;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("PMingLiU-ExtB", 10F);
            label12.Location = new Point(340, 32);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(73, 17);
            label12.TabIndex = 60;
            label12.Text = "Concepto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 10F);
            label2.Location = new Point(176, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 47;
            label2.Text = "Fecha fin:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("PMingLiU-ExtB", 10F);
            label10.Location = new Point(7, 32);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(89, 17);
            label10.TabIndex = 37;
            label10.Text = "Fecha inicio:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.Black;
            dateTimePicker1.CalendarMonthBackground = Color.White;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 8.25F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(7, 58);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(135, 23);
            dateTimePicker1.TabIndex = 143;
            dateTimePicker1.Value = new DateTime(2026, 6, 7, 12, 32, 51, 0);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarForeColor = Color.Black;
            dateTimePicker2.CalendarMonthBackground = Color.White;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 8.25F);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(176, 55);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(135, 23);
            dateTimePicker2.TabIndex = 144;
            dateTimePicker2.Value = new DateTime(2026, 6, 7, 12, 32, 51, 0);
            // 
            // CBconcepto
            // 
            CBconcepto.Font = new Font("PMingLiU-ExtB", 9F);
            CBconcepto.FormattingEnabled = true;
            CBconcepto.Location = new Point(340, 55);
            CBconcepto.Margin = new Padding(2);
            CBconcepto.Name = "CBconcepto";
            CBconcepto.Size = new Size(246, 23);
            CBconcepto.TabIndex = 145;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(64, 0, 0);
            btnBuscar.BackgroundImageLayout = ImageLayout.None;
            btnBuscar.Font = new Font("PMingLiU-ExtB", 10F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(601, 44);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(88, 34);
            btnBuscar.TabIndex = 146;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(64, 0, 0);
            btnImprimir.BackgroundImageLayout = ImageLayout.None;
            btnImprimir.Font = new Font("PMingLiU-ExtB", 10F);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(718, 44);
            btnImprimir.Margin = new Padding(2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(93, 34);
            btnImprimir.TabIndex = 147;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SeaShell;
            groupBox2.Controls.Add(txtTotaldeegresos);
            groupBox2.Controls.Add(txtTotalegresado);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox2.Location = new Point(250, 406);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(818, 89);
            groupBox2.TabIndex = 143;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("PMingLiU-ExtB", 10F);
            label3.Location = new Point(543, 44);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 17);
            label3.TabIndex = 47;
            label3.Text = "Total egresado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("PMingLiU-ExtB", 10F);
            label4.Location = new Point(20, 44);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(123, 17);
            label4.TabIndex = 37;
            label4.Text = "Total de egresoso:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SeaShell;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, Concepto, Descripcion, Responsable, Monto });
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(250, 233);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(827, 134);
            dataGridView1.TabIndex = 144;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // Concepto
            // 
            Concepto.HeaderText = "Concepto";
            Concepto.MinimumWidth = 6;
            Concepto.Name = "Concepto";
            Concepto.Width = 195;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripción";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 195;
            // 
            // Responsable
            // 
            Responsable.HeaderText = "Responsable";
            Responsable.MinimumWidth = 6;
            Responsable.Name = "Responsable";
            Responsable.Width = 125;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto (C$)";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            Monto.Width = 125;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(64, 0, 0);
            button6.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(250, 609);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(130, 30);
            button6.TabIndex = 146;
            button6.Text = "Menú principal";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 0, 0);
            button5.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(954, 609);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(99, 27);
            button5.TabIndex = 145;
            button5.Text = "Cerrar Sesión ";
            button5.UseVisualStyleBackColor = false;
            // 
            // txtTotalegresado
            // 
            txtTotalegresado.Font = new Font("PMingLiU-ExtB", 9F);
            txtTotalegresado.Location = new Point(658, 36);
            txtTotalegresado.Margin = new Padding(2);
            txtTotalegresado.Name = "txtTotalegresado";
            txtTotalegresado.Size = new Size(145, 25);
            txtTotalegresado.TabIndex = 48;
            // 
            // txtTotaldeegresos
            // 
            txtTotaldeegresos.Font = new Font("PMingLiU-ExtB", 9F);
            txtTotaldeegresos.Location = new Point(147, 36);
            txtTotaldeegresos.Margin = new Padding(2);
            txtTotaldeegresos.Name = "txtTotaldeegresos";
            txtTotaldeegresos.Size = new Size(76, 25);
            txtTotaldeegresos.TabIndex = 49;
            // 
            // Formcontroldeegresos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 690);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Formcontroldeegresos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private GroupBox groupBox1;
        private Label label12;
        private Label label2;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox CBconcepto;
        private Button btnImprimir;
        private Button btnBuscar;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Concepto;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Responsable;
        private DataGridViewTextBoxColumn Monto;
        private Button button6;
        private Button button5;
        private TextBox txtTotaldeegresos;
        private TextBox txtTotalegresado;
    }
}
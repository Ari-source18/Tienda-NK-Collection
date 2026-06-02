namespace Sistema_NK
{
    partial class Formcaja
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
            btnclientes = new Button();
            label11 = new Label();
            label15 = new Label();
            label16 = new Label();
            button6 = new Button();
            button5 = new Button();
            groupBoxnuevoproducto = new GroupBox();
            dataGridView1 = new DataGridView();
            Conepto = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            txtSaldoinicial = new TextBox();
            txtSaldofinal = new TextBox();
            txtTotalingresos = new TextBox();
            txtTotalegresos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnCerrarcaja = new Button();
            btnGuardarmovimiento = new Button();
            groupBox2 = new GroupBox();
            CBtipo = new ComboBox();
            txtReferencia = new TextBox();
            txtMonto = new TextBox();
            txtConcepto = new TextBox();
            lblreferencia = new Label();
            lblmonto = new Label();
            lblconcepto = new Label();
            lbltipo = new Label();
            groupBoxdatos = new GroupBox();
            CBusuario = new ComboBox();
            label7 = new Label();
            txtFecha = new TextBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            groupBoxnuevoproducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            groupBoxdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Controls.Add(btnclientes);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label16);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 870);
            panel1.TabIndex = 5;
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
            btninventario.Location = new Point(61, 816);
            btninventario.Name = "btninventario";
            btninventario.Size = new Size(167, 38);
            btninventario.TabIndex = 76;
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
            btnnivelacioninventario.Location = new Point(6, 756);
            btnnivelacioninventario.Name = "btnnivelacioninventario";
            btnnivelacioninventario.Size = new Size(290, 38);
            btnnivelacioninventario.TabIndex = 75;
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
            btndevolucionventas.Location = new Point(28, 568);
            btndevolucionventas.Name = "btndevolucionventas";
            btndevolucionventas.Size = new Size(257, 38);
            btndevolucionventas.TabIndex = 74;
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
            btncredito.Location = new Point(55, 503);
            btncredito.Name = "btncredito";
            btncredito.Size = new Size(167, 38);
            btncredito.TabIndex = 73;
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
            btndevolucioncompra.Location = new Point(12, 631);
            btndevolucioncompra.Name = "btndevolucioncompra";
            btndevolucioncompra.Size = new Size(268, 38);
            btndevolucioncompra.TabIndex = 72;
            btndevolucioncompra.Text = "Devolución Compra";
            btndevolucioncompra.UseVisualStyleBackColor = false;
            btndevolucioncompra.Click += btndevolucioncompra_Click;
            // 
            // btncaja
            // 
            btncaja.BackColor = Color.DarkSalmon;
            btncaja.FlatAppearance.BorderSize = 0;
            btncaja.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btncaja.FlatAppearance.MouseOverBackColor = Color.Tan;
            btncaja.FlatStyle = FlatStyle.Flat;
            btncaja.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncaja.ForeColor = Color.White;
            btncaja.ImageAlign = ContentAlignment.MiddleLeft;
            btncaja.Location = new Point(55, 692);
            btncaja.Name = "btncaja";
            btncaja.Size = new Size(167, 38);
            btncaja.TabIndex = 71;
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
            btnusuarios.Location = new Point(55, 116);
            btnusuarios.Name = "btnusuarios";
            btnusuarios.Size = new Size(167, 38);
            btnusuarios.TabIndex = 70;
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
            btncompras.Location = new Point(55, 253);
            btncompras.Name = "btncompras";
            btncompras.Size = new Size(167, 38);
            btncompras.TabIndex = 69;
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
            btnproductos.Location = new Point(55, 376);
            btnproductos.Name = "btnproductos";
            btnproductos.Size = new Size(167, 38);
            btnproductos.TabIndex = 68;
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
            btnproveedores.Location = new Point(55, 444);
            btnproveedores.Name = "btnproveedores";
            btnproveedores.Size = new Size(167, 38);
            btnproveedores.TabIndex = 67;
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
            btnventas.Location = new Point(55, 316);
            btnventas.Name = "btnventas";
            btnventas.Size = new Size(167, 38);
            btnventas.TabIndex = 66;
            btnventas.Text = "Ventas";
            btnventas.UseVisualStyleBackColor = false;
            btnventas.Click += btnventas_Click;
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
            btnclientes.Location = new Point(55, 185);
            btnclientes.Name = "btnclientes";
            btnclientes.Size = new Size(167, 38);
            btnclientes.TabIndex = 65;
            btnclientes.Text = "Clientes";
            btnclientes.UseVisualStyleBackColor = false;
            btnclientes.Click += btnclientes_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(12, 31);
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
            label15.Location = new Point(91, 48);
            label15.Name = "label15";
            label15.Size = new Size(178, 28);
            label15.TabIndex = 44;
            label15.Text = "COLLECTION";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(3, 76);
            label16.Name = "label16";
            label16.Size = new Size(285, 28);
            label16.TabIndex = 45;
            label16.Text = "_____________________";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(64, 0, 0);
            button6.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(318, 819);
            button6.Name = "button6";
            button6.Size = new Size(163, 38);
            button6.TabIndex = 141;
            button6.Text = "Menú principal";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 0, 0);
            button5.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(1232, 821);
            button5.Name = "button5";
            button5.Size = new Size(124, 34);
            button5.TabIndex = 140;
            button5.Text = "Cerrar Sesión ";
            button5.UseVisualStyleBackColor = false;
            // 
            // groupBoxnuevoproducto
            // 
            groupBoxnuevoproducto.BackColor = Color.SeaShell;
            groupBoxnuevoproducto.Controls.Add(dataGridView1);
            groupBoxnuevoproducto.Location = new Point(897, 448);
            groupBoxnuevoproducto.Name = "groupBoxnuevoproducto";
            groupBoxnuevoproducto.Size = new Size(447, 161);
            groupBoxnuevoproducto.TabIndex = 136;
            groupBoxnuevoproducto.TabStop = false;
            groupBoxnuevoproducto.Text = "Tipos de caja";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SeaShell;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Conepto, Monto });
            dataGridView1.Location = new Point(16, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(416, 109);
            dataGridView1.TabIndex = 0;
            // 
            // Conepto
            // 
            Conepto.HeaderText = "Concepto";
            Conepto.MinimumWidth = 8;
            Conepto.Name = "Conepto";
            Conepto.Width = 200;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 8;
            Monto.Name = "Monto";
            Monto.Width = 150;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(303, 227);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 386);
            groupBox1.TabIndex = 139;
            groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSaldoinicial);
            groupBox3.Controls.Add(txtSaldofinal);
            groupBox3.Controls.Add(txtTotalingresos);
            groupBox3.Controls.Add(txtTotalegresos);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(14, 154);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(428, 206);
            groupBox3.TabIndex = 108;
            groupBox3.TabStop = false;
            // 
            // txtSaldoinicial
            // 
            txtSaldoinicial.Location = new Point(165, 21);
            txtSaldoinicial.Name = "txtSaldoinicial";
            txtSaldoinicial.Size = new Size(150, 31);
            txtSaldoinicial.TabIndex = 10;
            // 
            // txtSaldofinal
            // 
            txtSaldofinal.Location = new Point(165, 155);
            txtSaldofinal.Name = "txtSaldofinal";
            txtSaldofinal.Size = new Size(150, 31);
            txtSaldofinal.TabIndex = 9;
            // 
            // txtTotalingresos
            // 
            txtTotalingresos.Location = new Point(165, 63);
            txtTotalingresos.Name = "txtTotalingresos";
            txtTotalingresos.Size = new Size(150, 31);
            txtTotalingresos.TabIndex = 8;
            // 
            // txtTotalegresos
            // 
            txtTotalegresos.Location = new Point(165, 110);
            txtTotalegresos.Name = "txtTotalegresos";
            txtTotalegresos.Size = new Size(150, 31);
            txtTotalegresos.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 69);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 6;
            label1.Text = "Total ingreso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 116);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 5;
            label2.Text = "Total egresos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 161);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 4;
            label4.Text = "Saldo final:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 27);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 3;
            label3.Text = "Saldo inicial:";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.SeaShell;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView2.Location = new Point(6, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(564, 123);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tipo";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Concepto";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Monto";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // btnCerrarcaja
            // 
            btnCerrarcaja.BackColor = Color.Maroon;
            btnCerrarcaja.ForeColor = SystemColors.ControlLightLight;
            btnCerrarcaja.Location = new Point(1157, 615);
            btnCerrarcaja.Name = "btnCerrarcaja";
            btnCerrarcaja.Size = new Size(165, 34);
            btnCerrarcaja.TabIndex = 138;
            btnCerrarcaja.Text = "Cerrar caja";
            btnCerrarcaja.UseVisualStyleBackColor = false;
            // 
            // btnGuardarmovimiento
            // 
            btnGuardarmovimiento.BackColor = Color.Maroon;
            btnGuardarmovimiento.ForeColor = SystemColors.ControlLightLight;
            btnGuardarmovimiento.Location = new Point(920, 615);
            btnGuardarmovimiento.Name = "btnGuardarmovimiento";
            btnGuardarmovimiento.Size = new Size(215, 34);
            btnGuardarmovimiento.TabIndex = 137;
            btnGuardarmovimiento.Text = "Guardar movimiento";
            btnGuardarmovimiento.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SeaShell;
            groupBox2.Controls.Add(CBtipo);
            groupBox2.Controls.Add(txtReferencia);
            groupBox2.Controls.Add(txtMonto);
            groupBox2.Controls.Add(txtConcepto);
            groupBox2.Controls.Add(lblreferencia);
            groupBox2.Controls.Add(lblmonto);
            groupBox2.Controls.Add(lblconcepto);
            groupBox2.Controls.Add(lbltipo);
            groupBox2.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox2.Location = new Point(977, 240);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 196);
            groupBox2.TabIndex = 135;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registrar movimiento ";
            // 
            // CBtipo
            // 
            CBtipo.FormattingEnabled = true;
            CBtipo.Location = new Point(73, 26);
            CBtipo.Name = "CBtipo";
            CBtipo.Size = new Size(197, 33);
            CBtipo.TabIndex = 86;
            // 
            // txtReferencia
            // 
            txtReferencia.Location = new Point(111, 155);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(159, 31);
            txtReferencia.TabIndex = 6;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(88, 111);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(182, 31);
            txtMonto.TabIndex = 5;
            // 
            // txtConcepto
            // 
            txtConcepto.Location = new Point(111, 65);
            txtConcepto.Name = "txtConcepto";
            txtConcepto.Size = new Size(159, 31);
            txtConcepto.TabIndex = 4;
            // 
            // lblreferencia
            // 
            lblreferencia.AutoSize = true;
            lblreferencia.Location = new Point(12, 161);
            lblreferencia.Name = "lblreferencia";
            lblreferencia.Size = new Size(96, 25);
            lblreferencia.TabIndex = 3;
            lblreferencia.Text = "Referencia:";
            // 
            // lblmonto
            // 
            lblmonto.AutoSize = true;
            lblmonto.Location = new Point(12, 117);
            lblmonto.Name = "lblmonto";
            lblmonto.Size = new Size(70, 25);
            lblmonto.TabIndex = 2;
            lblmonto.Text = "Monto:";
            // 
            // lblconcepto
            // 
            lblconcepto.AutoSize = true;
            lblconcepto.Location = new Point(12, 71);
            lblconcepto.Name = "lblconcepto";
            lblconcepto.Size = new Size(93, 25);
            lblconcepto.TabIndex = 1;
            lblconcepto.Text = "Concepto:";
            // 
            // lbltipo
            // 
            lbltipo.AutoSize = true;
            lbltipo.Location = new Point(12, 37);
            lbltipo.Name = "lbltipo";
            lbltipo.Size = new Size(51, 25);
            lbltipo.TabIndex = 0;
            lbltipo.Text = "Tipo:";
            // 
            // groupBoxdatos
            // 
            groupBoxdatos.BackColor = Color.SeaShell;
            groupBoxdatos.Controls.Add(CBusuario);
            groupBoxdatos.Controls.Add(label7);
            groupBoxdatos.Controls.Add(txtFecha);
            groupBoxdatos.Controls.Add(label8);
            groupBoxdatos.ForeColor = Color.FromArgb(64, 0, 0);
            groupBoxdatos.Location = new Point(303, 147);
            groupBoxdatos.Name = "groupBoxdatos";
            groupBoxdatos.Size = new Size(1041, 74);
            groupBoxdatos.TabIndex = 134;
            groupBoxdatos.TabStop = false;
            // 
            // CBusuario
            // 
            CBusuario.FormattingEnabled = true;
            CBusuario.Location = new Point(371, 27);
            CBusuario.Name = "CBusuario";
            CBusuario.Size = new Size(648, 33);
            CBusuario.TabIndex = 85;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(280, 27);
            label7.Name = "label7";
            label7.Size = new Size(76, 25);
            label7.TabIndex = 2;
            label7.Text = "Usuario:";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(84, 27);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(150, 31);
            txtFecha.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 30);
            label8.Name = "label8";
            label8.Size = new Size(61, 25);
            label8.TabIndex = 0;
            label8.Text = "Fecha:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagen_circular_recortada;
            pictureBox1.Location = new Point(1249, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 133;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(317, 48);
            label5.Name = "label5";
            label5.Size = new Size(220, 32);
            label5.TabIndex = 132;
            label5.Text = "Gestión de Caja";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(303, 72);
            label6.Name = "label6";
            label6.Size = new Size(942, 32);
            label6.TabIndex = 131;
            label6.Text = "__________________________________________________________";
            // 
            // Formcaja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 870);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(groupBoxnuevoproducto);
            Controls.Add(groupBox1);
            Controls.Add(btnCerrarcaja);
            Controls.Add(btnGuardarmovimiento);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxdatos);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Formcaja";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxnuevoproducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBoxdatos.ResumeLayout(false);
            groupBoxdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnbuscarcliente;
        private TextBox txtfecha;
        private Panel panel1;
        private Label label11;
        private Label label15;
        private Label label16;
        private Button button6;
        private Button button5;
        private GroupBox groupBoxnuevoproducto;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Conepto;
        private DataGridViewTextBoxColumn Monto;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private TextBox txtSaldoinicial;
        private TextBox txtSaldofinal;
        private TextBox txtTotalingresos;
        private TextBox txtTotalegresos;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btnCerrarcaja;
        private Button btnGuardarmovimiento;
        private GroupBox groupBox2;
        private ComboBox CBtipo;
        private TextBox txtReferencia;
        private TextBox txtMonto;
        private TextBox txtConcepto;
        private Label lblreferencia;
        private Label lblmonto;
        private Label lblconcepto;
        private Label lbltipo;
        private GroupBox groupBoxdatos;
        private ComboBox CBusuario;
        private Label label7;
        private TextBox txtFecha;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Button btndevolucionventas;
        private Button btncredito;
        private Button btndevolucioncompra;
        private Button btncaja;
        private Button btnusuarios;
        private Button btncompras;
        private Button btnproductos;
        private Button btnproveedores;
        private Button btnventas;
        private Button btnclientes;
        private Button btninventario;
        private Button btnnivelacioninventario;
    }
}
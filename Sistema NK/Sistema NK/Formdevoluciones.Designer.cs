namespace Sistema_NK
{
    partial class Formdevoluciones
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
            groupBoxdatagrid = new GroupBox();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            dataGridViewdevo = new DataGridView();
            columnaproducto = new DataGridViewTextBoxColumn();
            cantvendida = new DataGridViewTextBoxColumn();
            cantdevolver = new DataGridViewTextBoxColumn();
            motivo = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            groupBoxnuevoproducto = new GroupBox();
            dataGridViewnuevoproducto = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            groupBoxtipodevolucion = new GroupBox();
            btnnotadecredito = new RadioButton();
            btncambio = new RadioButton();
            btnreembolso = new RadioButton();
            btnimprimir = new Button();
            btnvalidar = new Button();
            groupBoxdatos = new GroupBox();
            btnbuscarventa = new Button();
            label3 = new Label();
            txtcliente = new TextBox();
            label2 = new Label();
            txtfactura = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            groupBoxdatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewdevo).BeginInit();
            groupBoxnuevoproducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewnuevoproducto).BeginInit();
            groupBoxtipodevolucion.SuspendLayout();
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
            panel1.Size = new Size(296, 852);
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
            btninventario.Location = new Point(58, 801);
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
            btnnivelacioninventario.Location = new Point(3, 741);
            btnnivelacioninventario.Name = "btnnivelacioninventario";
            btnnivelacioninventario.Size = new Size(290, 38);
            btnnivelacioninventario.TabIndex = 75;
            btnnivelacioninventario.Text = "Nivelación de inventario";
            btnnivelacioninventario.UseVisualStyleBackColor = false;
            btnnivelacioninventario.Click += btnnivelacioninventario_Click;
            // 
            // btndevolucionventas
            // 
            btndevolucionventas.BackColor = Color.DarkSalmon;
            btndevolucionventas.FlatAppearance.BorderSize = 0;
            btndevolucionventas.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btndevolucionventas.FlatAppearance.MouseOverBackColor = Color.Tan;
            btndevolucionventas.FlatStyle = FlatStyle.Flat;
            btndevolucionventas.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndevolucionventas.ForeColor = Color.White;
            btndevolucionventas.ImageAlign = ContentAlignment.MiddleLeft;
            btndevolucionventas.Location = new Point(26, 564);
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
            btncredito.Location = new Point(53, 499);
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
            btndevolucioncompra.Location = new Point(15, 626);
            btndevolucioncompra.Name = "btndevolucioncompra";
            btndevolucioncompra.Size = new Size(268, 38);
            btndevolucioncompra.TabIndex = 72;
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
            btncaja.Location = new Point(53, 688);
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
            btnusuarios.Location = new Point(53, 112);
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
            btncompras.Location = new Point(53, 249);
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
            btnproductos.Location = new Point(53, 372);
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
            btnproveedores.Location = new Point(53, 440);
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
            btnventas.Location = new Point(53, 312);
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
            btnclientes.Location = new Point(53, 181);
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
            button6.Location = new Point(311, 799);
            button6.Name = "button6";
            button6.Size = new Size(163, 38);
            button6.TabIndex = 139;
            button6.Text = "Menú principal";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 0, 0);
            button5.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(1225, 801);
            button5.Name = "button5";
            button5.Size = new Size(124, 34);
            button5.TabIndex = 138;
            button5.Text = "Cerrar Sesión ";
            button5.UseVisualStyleBackColor = false;
            // 
            // groupBoxdatagrid
            // 
            groupBoxdatagrid.BackColor = Color.SeaShell;
            groupBoxdatagrid.Controls.Add(textBox3);
            groupBoxdatagrid.Controls.Add(label7);
            groupBoxdatagrid.Controls.Add(textBox2);
            groupBoxdatagrid.Controls.Add(label4);
            groupBoxdatagrid.Controls.Add(dataGridViewdevo);
            groupBoxdatagrid.Location = new Point(307, 192);
            groupBoxdatagrid.Name = "groupBoxdatagrid";
            groupBoxdatagrid.Size = new Size(1038, 165);
            groupBoxdatagrid.TabIndex = 137;
            groupBoxdatagrid.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(9, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 31);
            textBox3.TabIndex = 95;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 81);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 94;
            label7.Text = "Total:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 31);
            textBox2.TabIndex = 93;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 19);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 92;
            label4.Text = "Motivo:";
            // 
            // dataGridViewdevo
            // 
            dataGridViewdevo.BackgroundColor = Color.SeaShell;
            dataGridViewdevo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewdevo.Columns.AddRange(new DataGridViewColumn[] { columnaproducto, cantvendida, cantdevolver, motivo, estado });
            dataGridViewdevo.Location = new Point(208, 30);
            dataGridViewdevo.Name = "dataGridViewdevo";
            dataGridViewdevo.RowHeadersWidth = 62;
            dataGridViewdevo.Size = new Size(814, 116);
            dataGridViewdevo.TabIndex = 0;
            // 
            // columnaproducto
            // 
            columnaproducto.HeaderText = "Producto";
            columnaproducto.MinimumWidth = 8;
            columnaproducto.Name = "columnaproducto";
            columnaproducto.Width = 150;
            // 
            // cantvendida
            // 
            cantvendida.HeaderText = "Cant.Vendida";
            cantvendida.MinimumWidth = 8;
            cantvendida.Name = "cantvendida";
            cantvendida.Width = 150;
            // 
            // cantdevolver
            // 
            cantdevolver.HeaderText = "Cant.Devolver";
            cantdevolver.MinimumWidth = 8;
            cantdevolver.Name = "cantdevolver";
            cantdevolver.Width = 150;
            // 
            // motivo
            // 
            motivo.HeaderText = "Motivo";
            motivo.MinimumWidth = 8;
            motivo.Name = "motivo";
            motivo.Width = 150;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 8;
            estado.Name = "estado";
            estado.Width = 150;
            // 
            // groupBoxnuevoproducto
            // 
            groupBoxnuevoproducto.BackColor = Color.SeaShell;
            groupBoxnuevoproducto.Controls.Add(dataGridViewnuevoproducto);
            groupBoxnuevoproducto.Location = new Point(302, 446);
            groupBoxnuevoproducto.Name = "groupBoxnuevoproducto";
            groupBoxnuevoproducto.Size = new Size(1038, 162);
            groupBoxnuevoproducto.TabIndex = 136;
            groupBoxnuevoproducto.TabStop = false;
            groupBoxnuevoproducto.Text = "Nuevo Producto";
            // 
            // dataGridViewnuevoproducto
            // 
            dataGridViewnuevoproducto.BackgroundColor = Color.SeaShell;
            dataGridViewnuevoproducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewnuevoproducto.Columns.AddRange(new DataGridViewColumn[] { codigo, producto, cantidad, precio, total });
            dataGridViewnuevoproducto.Location = new Point(27, 30);
            dataGridViewnuevoproducto.Name = "dataGridViewnuevoproducto";
            dataGridViewnuevoproducto.RowHeadersWidth = 62;
            dataGridViewnuevoproducto.Size = new Size(816, 109);
            dataGridViewnuevoproducto.TabIndex = 0;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.MinimumWidth = 8;
            codigo.Name = "codigo";
            codigo.Width = 150;
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.MinimumWidth = 8;
            producto.Name = "producto";
            producto.Width = 150;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 8;
            cantidad.Name = "cantidad";
            cantidad.Width = 150;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 8;
            precio.Name = "precio";
            precio.Width = 150;
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.MinimumWidth = 8;
            total.Name = "total";
            total.Width = 150;
            // 
            // groupBoxtipodevolucion
            // 
            groupBoxtipodevolucion.BackColor = Color.SeaShell;
            groupBoxtipodevolucion.Controls.Add(btnnotadecredito);
            groupBoxtipodevolucion.Controls.Add(btncambio);
            groupBoxtipodevolucion.Controls.Add(btnreembolso);
            groupBoxtipodevolucion.Location = new Point(302, 363);
            groupBoxtipodevolucion.Name = "groupBoxtipodevolucion";
            groupBoxtipodevolucion.Size = new Size(1038, 77);
            groupBoxtipodevolucion.TabIndex = 135;
            groupBoxtipodevolucion.TabStop = false;
            groupBoxtipodevolucion.Text = "Tipo de Devolución";
            // 
            // btnnotadecredito
            // 
            btnnotadecredito.AutoSize = true;
            btnnotadecredito.Location = new Point(510, 30);
            btnnotadecredito.Name = "btnnotadecredito";
            btnnotadecredito.Size = new Size(161, 29);
            btnnotadecredito.TabIndex = 99;
            btnnotadecredito.TabStop = true;
            btnnotadecredito.Text = "Nota de crédito";
            btnnotadecredito.UseVisualStyleBackColor = true;
            // 
            // btncambio
            // 
            btncambio.AutoSize = true;
            btncambio.Location = new Point(236, 30);
            btncambio.Name = "btncambio";
            btncambio.Size = new Size(203, 29);
            btncambio.TabIndex = 99;
            btncambio.TabStop = true;
            btncambio.Text = "Cambio de producto";
            btncambio.UseVisualStyleBackColor = true;
            // 
            // btnreembolso
            // 
            btnreembolso.AutoSize = true;
            btnreembolso.Location = new Point(38, 30);
            btnreembolso.Name = "btnreembolso";
            btnreembolso.Size = new Size(126, 29);
            btnreembolso.TabIndex = 98;
            btnreembolso.TabStop = true;
            btnreembolso.Text = "Reembolso";
            btnreembolso.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            btnimprimir.BackColor = Color.Maroon;
            btnimprimir.ForeColor = SystemColors.ControlLightLight;
            btnimprimir.Location = new Point(1125, 625);
            btnimprimir.Name = "btnimprimir";
            btnimprimir.Size = new Size(215, 34);
            btnimprimir.TabIndex = 134;
            btnimprimir.Text = "Imprimir Comprobante";
            btnimprimir.UseVisualStyleBackColor = false;
            // 
            // btnvalidar
            // 
            btnvalidar.BackColor = Color.Maroon;
            btnvalidar.ForeColor = SystemColors.ControlLightLight;
            btnvalidar.Location = new Point(935, 625);
            btnvalidar.Name = "btnvalidar";
            btnvalidar.Size = new Size(184, 34);
            btnvalidar.TabIndex = 133;
            btnvalidar.Text = "Validar Devolución";
            btnvalidar.UseVisualStyleBackColor = false;
            // 
            // groupBoxdatos
            // 
            groupBoxdatos.BackColor = Color.SeaShell;
            groupBoxdatos.Controls.Add(btnbuscarventa);
            groupBoxdatos.Controls.Add(label3);
            groupBoxdatos.Controls.Add(txtcliente);
            groupBoxdatos.Controls.Add(label2);
            groupBoxdatos.Controls.Add(txtfactura);
            groupBoxdatos.Controls.Add(label1);
            groupBoxdatos.Location = new Point(307, 112);
            groupBoxdatos.Name = "groupBoxdatos";
            groupBoxdatos.Size = new Size(1042, 74);
            groupBoxdatos.TabIndex = 132;
            groupBoxdatos.TabStop = false;
            // 
            // btnbuscarventa
            // 
            btnbuscarventa.BackColor = Color.Maroon;
            btnbuscarventa.ForeColor = SystemColors.ControlLightLight;
            btnbuscarventa.Location = new Point(816, 28);
            btnbuscarventa.Name = "btnbuscarventa";
            btnbuscarventa.Size = new Size(156, 34);
            btnbuscarventa.TabIndex = 86;
            btnbuscarventa.Text = "Buscar Venta";
            btnbuscarventa.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(543, 33);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 84;
            label3.Text = "Fecha Venta:";
            // 
            // txtcliente
            // 
            txtcliente.Location = new Point(364, 27);
            txtcliente.Name = "txtcliente";
            txtcliente.Size = new Size(150, 31);
            txtcliente.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 30);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 2;
            label2.Text = "Cliente:";
            // 
            // txtfactura
            // 
            txtfactura.Location = new Point(114, 30);
            txtfactura.Name = "txtfactura";
            txtfactura.Size = new Size(150, 31);
            txtfactura.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 27);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "No.Factura:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagen_circular_recortada;
            pictureBox1.Location = new Point(1248, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 131;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(316, 44);
            label5.Name = "label5";
            label5.Size = new Size(402, 32);
            label5.TabIndex = 130;
            label5.Text = "Gestión de Devolución ventas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(302, 68);
            label6.Name = "label6";
            label6.Size = new Size(942, 32);
            label6.TabIndex = 129;
            label6.Text = "__________________________________________________________";
            // 
            // Formdevoluciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 852);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(groupBoxdatagrid);
            Controls.Add(groupBoxnuevoproducto);
            Controls.Add(groupBoxtipodevolucion);
            Controls.Add(btnimprimir);
            Controls.Add(btnvalidar);
            Controls.Add(groupBoxdatos);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Formdevoluciones";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxdatagrid.ResumeLayout(false);
            groupBoxdatagrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewdevo).EndInit();
            groupBoxnuevoproducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewnuevoproducto).EndInit();
            groupBoxtipodevolucion.ResumeLayout(false);
            groupBoxtipodevolucion.PerformLayout();
            groupBoxdatos.ResumeLayout(false);
            groupBoxdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label11;
        private Label label15;
        private Label label16;
        private Button button6;
        private Button button5;
        private GroupBox groupBoxdatagrid;
        private DataGridView dataGridViewdevo;
        private DataGridViewTextBoxColumn columnaproducto;
        private DataGridViewTextBoxColumn cantvendida;
        private DataGridViewTextBoxColumn cantdevolver;
        private DataGridViewTextBoxColumn motivo;
        private DataGridViewTextBoxColumn estado;
        private GroupBox groupBoxnuevoproducto;
        private DataGridView dataGridViewnuevoproducto;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn total;
        private GroupBox groupBoxtipodevolucion;
        private RadioButton btnnotadecredito;
        private RadioButton btncambio;
        private RadioButton btnreembolso;
        private Button btnimprimir;
        private Button btnvalidar;
        private GroupBox groupBoxdatos;
        private Button btnbuscarventa;
        private Label label3;
        private TextBox txtcliente;
        private Label label2;
        private TextBox txtfactura;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox2;
        private Label label4;
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
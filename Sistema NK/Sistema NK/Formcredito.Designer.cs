namespace Sistema_NK
{
    partial class Formcredito
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
            panel2 = new Panel();
            panel4 = new Panel();
            btnmenuprincipal = new Button();
            btnsalir = new Button();
            label11 = new Label();
            btnclientes = new Button();
            btncaja = new Button();
            btndevoluciones = new Button();
            btncredito = new Button();
            btnproveedor = new Button();
            btnproductos = new Button();
            btnventas = new Button();
            btncompras = new Button();
            btnusuarios = new Button();
            groupBoxdatos = new GroupBox();
            btnbuscarcliente = new Button();
            cmbclientes = new ComboBox();
            label3 = new Label();
            txtfecha = new TextBox();
            label2 = new Label();
            txtfactura = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnaprobada = new Button();
            lblestado = new Label();
            lbldisponible = new Label();
            lblpendiente = new Label();
            lbllimite = new Label();
            groupBox3 = new GroupBox();
            txtobservaciones = new TextBox();
            cmbvencimiento = new ComboBox();
            cmbcuotas = new ComboBox();
            cmbplazo = new ComboBox();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtsubtotal = new TextBox();
            txtiva = new TextBox();
            txttotal = new TextBox();
            btnvalidar = new Button();
            btnregistrar = new Button();
            btngenerar = new Button();
            groupBoxdatagrid = new GroupBox();
            dataGridViewcredito = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            iva = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            panel4.SuspendLayout();
            groupBoxdatos.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBoxdatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewcredito).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(52, 722);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 0);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1376, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(48, 722);
            panel2.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Controls.Add(btnmenuprincipal);
            panel4.Controls.Add(btnsalir);
            panel4.Controls.Add(label11);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(52, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1324, 47);
            panel4.TabIndex = 4;
            // 
            // btnmenuprincipal
            // 
            btnmenuprincipal.BackColor = Color.Transparent;
            btnmenuprincipal.FlatStyle = FlatStyle.Flat;
            btnmenuprincipal.Font = new Font("PMingLiU-ExtB", 9F);
            btnmenuprincipal.Location = new Point(11, 7);
            btnmenuprincipal.Name = "btnmenuprincipal";
            btnmenuprincipal.Size = new Size(162, 34);
            btnmenuprincipal.TabIndex = 45;
            btnmenuprincipal.Text = "Menú principal";
            btnmenuprincipal.UseVisualStyleBackColor = false;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.Transparent;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("PMingLiU-ExtB", 9F);
            btnsalir.Location = new Point(1007, 7);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(121, 34);
            btnsalir.TabIndex = 44;
            btnsalir.Text = "Cerrar Sesión";
            btnsalir.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(338, 3);
            label11.Name = "label11";
            label11.Size = new Size(407, 38);
            label11.TabIndex = 43;
            label11.Text = "NK Collection            Crédito";
            // 
            // btnclientes
            // 
            btnclientes.BackColor = Color.MistyRose;
            btnclientes.FlatAppearance.BorderSize = 0;
            btnclientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnclientes.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnclientes.FlatStyle = FlatStyle.Flat;
            btnclientes.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclientes.ForeColor = Color.Black;
            btnclientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnclientes.Location = new Point(189, 53);
            btnclientes.Name = "btnclientes";
            btnclientes.Size = new Size(117, 38);
            btnclientes.TabIndex = 74;
            btnclientes.Text = "Clientes";
            btnclientes.UseVisualStyleBackColor = false;
            // 
            // btncaja
            // 
            btncaja.BackColor = Color.White;
            btncaja.FlatAppearance.BorderSize = 0;
            btncaja.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btncaja.FlatAppearance.MouseOverBackColor = Color.Tan;
            btncaja.FlatStyle = FlatStyle.Flat;
            btncaja.Font = new Font("PMingLiU-ExtB", 10F);
            btncaja.ForeColor = Color.Black;
            btncaja.ImageAlign = ContentAlignment.MiddleLeft;
            btncaja.Location = new Point(1066, 53);
            btncaja.Name = "btncaja";
            btncaja.Size = new Size(117, 38);
            btncaja.TabIndex = 75;
            btncaja.Text = "Caja";
            btncaja.UseVisualStyleBackColor = false;
            // 
            // btndevoluciones
            // 
            btndevoluciones.BackColor = Color.MistyRose;
            btndevoluciones.FlatAppearance.BorderSize = 0;
            btndevoluciones.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btndevoluciones.FlatAppearance.MouseOverBackColor = Color.Tan;
            btndevoluciones.FlatStyle = FlatStyle.Flat;
            btndevoluciones.Font = new Font("PMingLiU-ExtB", 10F);
            btndevoluciones.ForeColor = Color.Black;
            btndevoluciones.ImageAlign = ContentAlignment.MiddleLeft;
            btndevoluciones.Location = new Point(927, 53);
            btndevoluciones.Name = "btndevoluciones";
            btndevoluciones.Size = new Size(133, 38);
            btndevoluciones.TabIndex = 76;
            btndevoluciones.Text = "Devoluciones";
            btndevoluciones.UseVisualStyleBackColor = false;
            // 
            // btncredito
            // 
            btncredito.BackColor = Color.White;
            btncredito.FlatAppearance.BorderSize = 0;
            btncredito.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btncredito.FlatAppearance.MouseOverBackColor = Color.Tan;
            btncredito.FlatStyle = FlatStyle.Flat;
            btncredito.Font = new Font("PMingLiU-ExtB", 10F);
            btncredito.ForeColor = Color.Black;
            btncredito.ImageAlign = ContentAlignment.MiddleLeft;
            btncredito.Location = new Point(804, 53);
            btncredito.Name = "btncredito";
            btncredito.Size = new Size(117, 38);
            btncredito.TabIndex = 77;
            btncredito.Text = "Crédito";
            btncredito.UseVisualStyleBackColor = false;
            // 
            // btnproveedor
            // 
            btnproveedor.BackColor = Color.MistyRose;
            btnproveedor.FlatAppearance.BorderSize = 0;
            btnproveedor.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnproveedor.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnproveedor.FlatStyle = FlatStyle.Flat;
            btnproveedor.Font = new Font("PMingLiU-ExtB", 10F);
            btnproveedor.ForeColor = Color.Black;
            btnproveedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnproveedor.Location = new Point(681, 53);
            btnproveedor.Name = "btnproveedor";
            btnproveedor.Size = new Size(117, 38);
            btnproveedor.TabIndex = 78;
            btnproveedor.Text = "Proveedores";
            btnproveedor.UseVisualStyleBackColor = false;
            // 
            // btnproductos
            // 
            btnproductos.BackColor = Color.White;
            btnproductos.FlatAppearance.BorderSize = 0;
            btnproductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnproductos.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnproductos.FlatStyle = FlatStyle.Flat;
            btnproductos.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnproductos.ForeColor = Color.Black;
            btnproductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnproductos.Location = new Point(558, 53);
            btnproductos.Name = "btnproductos";
            btnproductos.Size = new Size(117, 38);
            btnproductos.TabIndex = 79;
            btnproductos.Text = "Productos";
            btnproductos.UseVisualStyleBackColor = false;
            // 
            // btnventas
            // 
            btnventas.BackColor = Color.MistyRose;
            btnventas.FlatAppearance.BorderSize = 0;
            btnventas.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnventas.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnventas.FlatStyle = FlatStyle.Flat;
            btnventas.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnventas.ForeColor = Color.Black;
            btnventas.ImageAlign = ContentAlignment.MiddleLeft;
            btnventas.Location = new Point(435, 53);
            btnventas.Name = "btnventas";
            btnventas.Size = new Size(117, 38);
            btnventas.TabIndex = 80;
            btnventas.Text = "Ventas";
            btnventas.UseVisualStyleBackColor = false;
            // 
            // btncompras
            // 
            btncompras.BackColor = Color.White;
            btncompras.FlatAppearance.BorderSize = 0;
            btncompras.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btncompras.FlatAppearance.MouseOverBackColor = Color.Tan;
            btncompras.FlatStyle = FlatStyle.Flat;
            btncompras.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncompras.ForeColor = Color.Black;
            btncompras.ImageAlign = ContentAlignment.MiddleLeft;
            btncompras.Location = new Point(312, 53);
            btncompras.Name = "btncompras";
            btncompras.Size = new Size(117, 38);
            btncompras.TabIndex = 81;
            btncompras.Text = "Compras";
            btncompras.UseVisualStyleBackColor = false;
            // 
            // btnusuarios
            // 
            btnusuarios.BackColor = Color.White;
            btnusuarios.FlatAppearance.BorderSize = 0;
            btnusuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnusuarios.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnusuarios.FlatStyle = FlatStyle.Flat;
            btnusuarios.Font = new Font("PMingLiU-ExtB", 10F);
            btnusuarios.ForeColor = Color.Black;
            btnusuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnusuarios.Location = new Point(66, 53);
            btnusuarios.Name = "btnusuarios";
            btnusuarios.Size = new Size(117, 38);
            btnusuarios.TabIndex = 82;
            btnusuarios.Text = "Usuarios";
            btnusuarios.UseVisualStyleBackColor = false;
            // 
            // groupBoxdatos
            // 
            groupBoxdatos.Controls.Add(btnbuscarcliente);
            groupBoxdatos.Controls.Add(cmbclientes);
            groupBoxdatos.Controls.Add(label3);
            groupBoxdatos.Controls.Add(txtfecha);
            groupBoxdatos.Controls.Add(label2);
            groupBoxdatos.Controls.Add(txtfactura);
            groupBoxdatos.Controls.Add(label1);
            groupBoxdatos.Location = new Point(58, 107);
            groupBoxdatos.Name = "groupBoxdatos";
            groupBoxdatos.Size = new Size(1125, 74);
            groupBoxdatos.TabIndex = 83;
            groupBoxdatos.TabStop = false;
            groupBoxdatos.Enter += groupBox1_Enter;
            // 
            // btnbuscarcliente
            // 
            btnbuscarcliente.Location = new Point(902, 23);
            btnbuscarcliente.Name = "btnbuscarcliente";
            btnbuscarcliente.Size = new Size(156, 34);
            btnbuscarcliente.TabIndex = 86;
            btnbuscarcliente.Text = "Buscar Cliente";
            btnbuscarcliente.UseVisualStyleBackColor = true;
            btnbuscarcliente.Click += button1_Click;
            // 
            // cmbclientes
            // 
            cmbclientes.FormattingEnabled = true;
            cmbclientes.Location = new Point(623, 24);
            cmbclientes.Name = "cmbclientes";
            cmbclientes.Size = new Size(182, 33);
            cmbclientes.TabIndex = 85;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(543, 33);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 84;
            label3.Text = "Cliente:";
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(364, 27);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(150, 31);
            txtfecha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 33);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 2;
            label2.Text = "Fecha:";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(btnaprobada);
            groupBox2.Controls.Add(lblestado);
            groupBox2.Controls.Add(lbldisponible);
            groupBox2.Controls.Add(lblpendiente);
            groupBox2.Controls.Add(lbllimite);
            groupBox2.Location = new Point(1003, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 196);
            groupBox2.TabIndex = 84;
            groupBox2.TabStop = false;
            // 
            // btnaprobada
            // 
            btnaprobada.Location = new Point(172, 156);
            btnaprobada.Name = "btnaprobada";
            btnaprobada.Size = new Size(112, 34);
            btnaprobada.TabIndex = 4;
            btnaprobada.Text = "Aprobada";
            btnaprobada.UseVisualStyleBackColor = true;
            // 
            // lblestado
            // 
            lblestado.AutoSize = true;
            lblestado.Location = new Point(12, 161);
            lblestado.Name = "lblestado";
            lblestado.Size = new Size(70, 25);
            lblestado.TabIndex = 3;
            lblestado.Text = "Estado:";
            // 
            // lbldisponible
            // 
            lbldisponible.AutoSize = true;
            lbldisponible.Location = new Point(12, 108);
            lbldisponible.Name = "lbldisponible";
            lbldisponible.Size = new Size(101, 25);
            lbldisponible.TabIndex = 2;
            lbldisponible.Text = "Disponible:";
            // 
            // lblpendiente
            // 
            lblpendiente.AutoSize = true;
            lblpendiente.Location = new Point(12, 55);
            lblpendiente.Name = "lblpendiente";
            lblpendiente.Size = new Size(93, 25);
            lblpendiente.TabIndex = 1;
            lblpendiente.Text = "Pendiente:";
            // 
            // lbllimite
            // 
            lbllimite.AutoSize = true;
            lbllimite.Location = new Point(12, 16);
            lbllimite.Name = "lbllimite";
            lbllimite.Size = new Size(63, 25);
            lbllimite.TabIndex = 0;
            lbllimite.Text = "Límite:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtobservaciones);
            groupBox3.Controls.Add(cmbvencimiento);
            groupBox3.Controls.Add(cmbcuotas);
            groupBox3.Controls.Add(cmbplazo);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(1003, 249);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 210);
            groupBox3.TabIndex = 85;
            groupBox3.TabStop = false;
            // 
            // txtobservaciones
            // 
            txtobservaciones.Location = new Point(172, 173);
            txtobservaciones.Name = "txtobservaciones";
            txtobservaciones.Size = new Size(121, 31);
            txtobservaciones.TabIndex = 86;
            // 
            // cmbvencimiento
            // 
            cmbvencimiento.FormattingEnabled = true;
            cmbvencimiento.Location = new Point(175, 117);
            cmbvencimiento.Name = "cmbvencimiento";
            cmbvencimiento.Size = new Size(122, 33);
            cmbvencimiento.TabIndex = 88;
            // 
            // cmbcuotas
            // 
            cmbcuotas.FormattingEnabled = true;
            cmbcuotas.Location = new Point(172, 69);
            cmbcuotas.Name = "cmbcuotas";
            cmbcuotas.Size = new Size(122, 33);
            cmbcuotas.TabIndex = 87;
            // 
            // cmbplazo
            // 
            cmbplazo.FormattingEnabled = true;
            cmbplazo.Location = new Point(172, 19);
            cmbplazo.Name = "cmbplazo";
            cmbplazo.Size = new Size(122, 33);
            cmbplazo.TabIndex = 86;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 173);
            label12.Name = "label12";
            label12.Size = new Size(132, 25);
            label12.TabIndex = 4;
            label12.Text = "Observaciones:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 125);
            label10.Name = "label10";
            label10.Size = new Size(113, 25);
            label10.TabIndex = 3;
            label10.Text = "Vencimiento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 77);
            label9.Name = "label9";
            label9.Size = new Size(71, 25);
            label9.TabIndex = 2;
            label9.Text = "Cuotas:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 27);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 1;
            label8.Text = "Plazo:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(638, 497);
            label13.Name = "label13";
            label13.Size = new Size(83, 25);
            label13.TabIndex = 86;
            label13.Text = "Subtotal:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(647, 545);
            label14.Name = "label14";
            label14.Size = new Size(43, 25);
            label14.TabIndex = 87;
            label14.Text = "IVA:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(647, 596);
            label15.Name = "label15";
            label15.Size = new Size(53, 25);
            label15.TabIndex = 88;
            label15.Text = "Total:";
            // 
            // txtsubtotal
            // 
            txtsubtotal.Location = new Point(727, 491);
            txtsubtotal.Name = "txtsubtotal";
            txtsubtotal.Size = new Size(150, 31);
            txtsubtotal.TabIndex = 89;
            // 
            // txtiva
            // 
            txtiva.Location = new Point(727, 539);
            txtiva.Name = "txtiva";
            txtiva.Size = new Size(150, 31);
            txtiva.TabIndex = 90;
            // 
            // txttotal
            // 
            txttotal.Location = new Point(727, 593);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(150, 31);
            txttotal.TabIndex = 91;
            // 
            // btnvalidar
            // 
            btnvalidar.Location = new Point(625, 676);
            btnvalidar.Name = "btnvalidar";
            btnvalidar.Size = new Size(156, 34);
            btnvalidar.TabIndex = 92;
            btnvalidar.Text = "Validar Crédito";
            btnvalidar.UseVisualStyleBackColor = true;
            // 
            // btnregistrar
            // 
            btnregistrar.Location = new Point(828, 676);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(232, 34);
            btnregistrar.TabIndex = 93;
            btnregistrar.Text = "Registrar Venta a Crédito";
            btnregistrar.UseVisualStyleBackColor = true;
            // 
            // btngenerar
            // 
            btngenerar.Location = new Point(1091, 676);
            btngenerar.Name = "btngenerar";
            btngenerar.Size = new Size(204, 34);
            btngenerar.TabIndex = 94;
            btngenerar.Text = "Generar";
            btngenerar.UseVisualStyleBackColor = true;
            // 
            // groupBoxdatagrid
            // 
            groupBoxdatagrid.Controls.Add(dataGridViewcredito);
            groupBoxdatagrid.Controls.Add(groupBox2);
            groupBoxdatagrid.Controls.Add(groupBox3);
            groupBoxdatagrid.Location = new Point(63, 187);
            groupBoxdatagrid.Name = "groupBoxdatagrid";
            groupBoxdatagrid.Size = new Size(1307, 465);
            groupBoxdatagrid.TabIndex = 95;
            groupBoxdatagrid.TabStop = false;
            // 
            // dataGridViewcredito
            // 
            dataGridViewcredito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewcredito.Columns.AddRange(new DataGridViewColumn[] { codigo, producto, cantidad, precio, iva, subtotal });
            dataGridViewcredito.Location = new Point(0, 60);
            dataGridViewcredito.Name = "dataGridViewcredito";
            dataGridViewcredito.RowHeadersWidth = 62;
            dataGridViewcredito.Size = new Size(962, 89);
            dataGridViewcredito.TabIndex = 0;
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
            // iva
            // 
            iva.HeaderText = "IVA";
            iva.MinimumWidth = 8;
            iva.Name = "iva";
            iva.Width = 150;
            // 
            // subtotal
            // 
            subtotal.HeaderText = "Subtotal";
            subtotal.MinimumWidth = 8;
            subtotal.Name = "subtotal";
            subtotal.Width = 150;
            // 
            // Formcredito
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 722);
            Controls.Add(btngenerar);
            Controls.Add(btnregistrar);
            Controls.Add(btnvalidar);
            Controls.Add(txttotal);
            Controls.Add(txtiva);
            Controls.Add(txtsubtotal);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(groupBoxdatos);
            Controls.Add(btnusuarios);
            Controls.Add(btncompras);
            Controls.Add(btnventas);
            Controls.Add(btnproductos);
            Controls.Add(btnproveedor);
            Controls.Add(btncredito);
            Controls.Add(btndevoluciones);
            Controls.Add(btncaja);
            Controls.Add(btnclientes);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBoxdatagrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formcredito";
            Text = "Formcredito";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBoxdatos.ResumeLayout(false);
            groupBoxdatos.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBoxdatagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewcredito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Button btnmenuprincipal;
        private Button btnsalir;
        private Label label11;
        private Button btnclientes;
        private Button btncaja;
        private Button btndevoluciones;
        private Button btncredito;
        private Button btnproveedor;
        private Button btnproductos;
        private Button btnventas;
        private Button btncompras;
        private Button btnusuarios;
        private GroupBox groupBoxdatos;
        private Label label1;
        private Label label3;
        private TextBox txtfecha;
        private Label label2;
        private TextBox txtfactura;
        private Button btnbuscarcliente;
        private ComboBox cmbclientes;
        private GroupBox groupBox2;
        private Label lbllimite;
        private GroupBox groupBox3;
        private Label lblpendiente;
        private Label lbldisponible;
        private Label lblestado;
        private Button btnaprobada;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private TextBox txtobservaciones;
        private ComboBox cmbvencimiento;
        private ComboBox cmbcuotas;
        private ComboBox cmbplazo;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox txtsubtotal;
        private TextBox txtiva;
        private TextBox txttotal;
        private Button btnvalidar;
        private Button btnregistrar;
        private Button btngenerar;
        private GroupBox groupBoxdatagrid;
        private DataGridView dataGridViewcredito;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn iva;
        private DataGridViewTextBoxColumn subtotal;
    }
}
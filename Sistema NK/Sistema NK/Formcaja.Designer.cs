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
            panel2 = new Panel();
            panel4 = new Panel();
            btnMenuprincipal = new Button();
            btnSalir = new Button();
            label11 = new Label();
            btnUsuarios = new Button();
            btnCompras = new Button();
            btnVentas = new Button();
            btnProductos = new Button();
            btnProveedores = new Button();
            btnReporte = new Button();
            btnMantenimiento = new Button();
            btnAcercade = new Button();
            btnClientes = new Button();
            groupBoxdatos = new GroupBox();
            CBusuario = new ComboBox();
            label2 = new Label();
            txtFecha = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblreferencia = new Label();
            lblmonto = new Label();
            lblconcepto = new Label();
            lbltipo = new Label();
            txtConcepto = new TextBox();
            txtMonto = new TextBox();
            txtReferencia = new TextBox();
            CBtipo = new ComboBox();
            btnGuardarmovimiento = new Button();
            btnCerrarcaja = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            Monto = new DataGridViewTextBoxColumn();
            Conepto = new DataGridViewTextBoxColumn();
            groupBoxnuevoproducto = new GroupBox();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTotalegresos = new TextBox();
            txtTotalingresos = new TextBox();
            txtSaldofinal = new TextBox();
            txtSaldoinicial = new TextBox();
            panel4.SuspendLayout();
            groupBoxdatos.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxnuevoproducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(52, 651);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 0);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1198, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(48, 651);
            panel2.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Controls.Add(btnMenuprincipal);
            panel4.Controls.Add(btnSalir);
            panel4.Controls.Add(label11);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(52, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1146, 47);
            panel4.TabIndex = 6;
            // 
            // btnMenuprincipal
            // 
            btnMenuprincipal.BackColor = Color.Transparent;
            btnMenuprincipal.FlatStyle = FlatStyle.Flat;
            btnMenuprincipal.Font = new Font("PMingLiU-ExtB", 9F);
            btnMenuprincipal.Location = new Point(11, 7);
            btnMenuprincipal.Name = "btnMenuprincipal";
            btnMenuprincipal.Size = new Size(162, 34);
            btnMenuprincipal.TabIndex = 45;
            btnMenuprincipal.Text = "Menú principal";
            btnMenuprincipal.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("PMingLiU-ExtB", 9F);
            btnSalir.Location = new Point(1007, 7);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(121, 34);
            btnSalir.TabIndex = 44;
            btnSalir.Text = "Cerrar Sesión";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(338, 3);
            label11.Name = "label11";
            label11.Size = new Size(370, 38);
            label11.TabIndex = 43;
            label11.Text = "NK Collection            Caja";
            label11.Click += label11_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.White;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("PMingLiU-ExtB", 10F);
            btnUsuarios.ForeColor = Color.Black;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(65, 62);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(117, 38);
            btnUsuarios.TabIndex = 100;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnCompras
            // 
            btnCompras.BackColor = Color.White;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnCompras.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompras.ForeColor = Color.Black;
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(311, 62);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(117, 38);
            btnCompras.TabIndex = 99;
            btnCompras.Text = "Compras";
            btnCompras.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.MistyRose;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnVentas.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = Color.Black;
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(434, 62);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(117, 38);
            btnVentas.TabIndex = 98;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.White;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnProductos.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.Black;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(557, 62);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(117, 38);
            btnProductos.TabIndex = 97;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = Color.MistyRose;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnProveedores.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("PMingLiU-ExtB", 10F);
            btnProveedores.ForeColor = Color.Black;
            btnProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedores.Location = new Point(680, 62);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(117, 38);
            btnProveedores.TabIndex = 96;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = false;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.White;
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnReporte.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("PMingLiU-ExtB", 10F);
            btnReporte.ForeColor = Color.Black;
            btnReporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporte.Location = new Point(803, 62);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(117, 38);
            btnReporte.TabIndex = 95;
            btnReporte.Text = "Reporte";
            btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnMantenimiento
            // 
            btnMantenimiento.BackColor = Color.MistyRose;
            btnMantenimiento.FlatAppearance.BorderSize = 0;
            btnMantenimiento.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnMantenimiento.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnMantenimiento.FlatStyle = FlatStyle.Flat;
            btnMantenimiento.Font = new Font("PMingLiU-ExtB", 10F);
            btnMantenimiento.ForeColor = Color.Black;
            btnMantenimiento.ImageAlign = ContentAlignment.MiddleLeft;
            btnMantenimiento.Location = new Point(926, 62);
            btnMantenimiento.Name = "btnMantenimiento";
            btnMantenimiento.Size = new Size(133, 38);
            btnMantenimiento.TabIndex = 94;
            btnMantenimiento.Text = "Mantenimiento";
            btnMantenimiento.UseVisualStyleBackColor = false;
            // 
            // btnAcercade
            // 
            btnAcercade.BackColor = Color.White;
            btnAcercade.FlatAppearance.BorderSize = 0;
            btnAcercade.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnAcercade.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnAcercade.FlatStyle = FlatStyle.Flat;
            btnAcercade.Font = new Font("PMingLiU-ExtB", 10F);
            btnAcercade.ForeColor = Color.Black;
            btnAcercade.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcercade.Location = new Point(1065, 62);
            btnAcercade.Name = "btnAcercade";
            btnAcercade.Size = new Size(117, 38);
            btnAcercade.TabIndex = 93;
            btnAcercade.Text = "Acerca de";
            btnAcercade.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.MistyRose;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnClientes.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.Black;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(188, 62);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(117, 38);
            btnClientes.TabIndex = 92;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // groupBoxdatos
            // 
            groupBoxdatos.Controls.Add(CBusuario);
            groupBoxdatos.Controls.Add(label2);
            groupBoxdatos.Controls.Add(txtFecha);
            groupBoxdatos.Controls.Add(label1);
            groupBoxdatos.Location = new Point(63, 115);
            groupBoxdatos.Name = "groupBoxdatos";
            groupBoxdatos.Size = new Size(1125, 74);
            groupBoxdatos.TabIndex = 101;
            groupBoxdatos.TabStop = false;
            // 
            // CBusuario
            // 
            CBusuario.FormattingEnabled = true;
            CBusuario.Location = new Point(379, 30);
            CBusuario.Name = "CBusuario";
            CBusuario.Size = new Size(722, 33);
            CBusuario.TabIndex = 85;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 33);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 2;
            label2.Text = "Usuario:";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(114, 30);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(150, 31);
            txtFecha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 27);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Fecha:";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CBtipo);
            groupBox2.Controls.Add(txtReferencia);
            groupBox2.Controls.Add(txtMonto);
            groupBox2.Controls.Add(txtConcepto);
            groupBox2.Controls.Add(lblreferencia);
            groupBox2.Controls.Add(lblmonto);
            groupBox2.Controls.Add(lblconcepto);
            groupBox2.Controls.Add(lbltipo);
            groupBox2.Location = new Point(888, 201);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 196);
            groupBox2.TabIndex = 102;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registrar movimiento ";
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
            // txtConcepto
            // 
            txtConcepto.Location = new Point(111, 65);
            txtConcepto.Name = "txtConcepto";
            txtConcepto.Size = new Size(159, 31);
            txtConcepto.TabIndex = 4;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(88, 111);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(182, 31);
            txtMonto.TabIndex = 5;
            // 
            // txtReferencia
            // 
            txtReferencia.Location = new Point(111, 155);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(159, 31);
            txtReferencia.TabIndex = 6;
            // 
            // CBtipo
            // 
            CBtipo.FormattingEnabled = true;
            CBtipo.Location = new Point(73, 26);
            CBtipo.Name = "CBtipo";
            CBtipo.Size = new Size(197, 33);
            CBtipo.TabIndex = 86;
            // 
            // btnGuardarmovimiento
            // 
            btnGuardarmovimiento.Location = new Point(778, 605);
            btnGuardarmovimiento.Name = "btnGuardarmovimiento";
            btnGuardarmovimiento.Size = new Size(215, 34);
            btnGuardarmovimiento.TabIndex = 105;
            btnGuardarmovimiento.Text = "Guardar movimiento";
            btnGuardarmovimiento.UseVisualStyleBackColor = true;
            // 
            // btnCerrarcaja
            // 
            btnCerrarcaja.Location = new Point(1023, 605);
            btnCerrarcaja.Name = "btnCerrarcaja";
            btnCerrarcaja.Size = new Size(165, 34);
            btnCerrarcaja.TabIndex = 106;
            btnCerrarcaja.Text = "Cerrar caja";
            btnCerrarcaja.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Location = new Point(71, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(783, 323);
            groupBox1.TabIndex = 107;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Conepto, Monto });
            dataGridView1.Location = new Point(16, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(416, 70);
            dataGridView1.TabIndex = 0;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 8;
            Monto.Name = "Monto";
            Monto.Width = 150;
            // 
            // Conepto
            // 
            Conepto.HeaderText = "Concepto";
            Conepto.MinimumWidth = 8;
            Conepto.Name = "Conepto";
            Conepto.Width = 200;
            // 
            // groupBoxnuevoproducto
            // 
            groupBoxnuevoproducto.Controls.Add(dataGridView1);
            groupBoxnuevoproducto.Location = new Point(741, 418);
            groupBoxnuevoproducto.Name = "groupBoxnuevoproducto";
            groupBoxnuevoproducto.Size = new Size(447, 140);
            groupBoxnuevoproducto.TabIndex = 103;
            groupBoxnuevoproducto.TabStop = false;
            groupBoxnuevoproducto.Text = "Tipos de caja";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView2.Location = new Point(6, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(564, 68);
            dataGridView2.TabIndex = 0;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSaldoinicial);
            groupBox3.Controls.Add(txtSaldofinal);
            groupBox3.Controls.Add(txtTotalingresos);
            groupBox3.Controls.Add(txtTotalegresos);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(6, 111);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(428, 206);
            groupBox3.TabIndex = 108;
            groupBox3.TabStop = false;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 161);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 4;
            label4.Text = "Saldo final:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 116);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 5;
            label5.Text = "Total egresos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 69);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 6;
            label6.Text = "Total ingreso:";
            // 
            // txtTotalegresos
            // 
            txtTotalegresos.Location = new Point(165, 110);
            txtTotalegresos.Name = "txtTotalegresos";
            txtTotalegresos.Size = new Size(150, 31);
            txtTotalegresos.TabIndex = 7;
            // 
            // txtTotalingresos
            // 
            txtTotalingresos.Location = new Point(165, 63);
            txtTotalingresos.Name = "txtTotalingresos";
            txtTotalingresos.Size = new Size(150, 31);
            txtTotalingresos.TabIndex = 8;
            // 
            // txtSaldofinal
            // 
            txtSaldofinal.Location = new Point(165, 155);
            txtSaldofinal.Name = "txtSaldofinal";
            txtSaldofinal.Size = new Size(150, 31);
            txtSaldofinal.TabIndex = 9;
            // 
            // txtSaldoinicial
            // 
            txtSaldoinicial.Location = new Point(165, 21);
            txtSaldoinicial.Name = "txtSaldoinicial";
            txtSaldoinicial.Size = new Size(150, 31);
            txtSaldoinicial.TabIndex = 10;
            // 
            // Formcaja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 651);
            Controls.Add(groupBoxnuevoproducto);
            Controls.Add(groupBox1);
            Controls.Add(btnCerrarcaja);
            Controls.Add(btnGuardarmovimiento);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxdatos);
            Controls.Add(btnUsuarios);
            Controls.Add(btnCompras);
            Controls.Add(btnVentas);
            Controls.Add(btnProductos);
            Controls.Add(btnProveedores);
            Controls.Add(btnReporte);
            Controls.Add(btnMantenimiento);
            Controls.Add(btnAcercade);
            Controls.Add(btnClientes);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formcaja";
            Text = "Formcaja";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBoxdatos.ResumeLayout(false);
            groupBoxdatos.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxnuevoproducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Button btnMenuprincipal;
        private Button btnSalir;
        private Label label11;
        private Button btnUsuarios;
        private Button btnCompras;
        private Button btnVentas;
        private Button btnProductos;
        private Button btnProveedores;
        private Button btnReporte;
        private Button btnMantenimiento;
        private Button btnAcercade;
        private Button btnClientes;
        private GroupBox groupBoxdatos;
        private Button btnbuscarcliente;
        private ComboBox CBusuario;
        private TextBox txtfecha;
        private Label label2;
        private TextBox txtFecha;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox CBtipo;
        private TextBox txtReferencia;
        private TextBox txtMonto;
        private TextBox txtConcepto;
        private Label lblreferencia;
        private Label lblmonto;
        private Label lblconcepto;
        private Label lbltipo;
        private Button btnGuardarmovimiento;
        private Button btnCerrarcaja;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Conepto;
        private DataGridViewTextBoxColumn Monto;
        private GroupBox groupBoxnuevoproducto;
        private TextBox txtSaldoinicial;
        private TextBox txtSaldofinal;
        private TextBox txtTotalingresos;
        private TextBox txtTotalegresos;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
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
            // groupBoxnuevoproducto
            // 
            groupBoxnuevoproducto.BackColor = Color.SeaShell;
            groupBoxnuevoproducto.Controls.Add(dataGridView1);
            groupBoxnuevoproducto.Location = new Point(616, 443);
            groupBoxnuevoproducto.Margin = new Padding(2);
            groupBoxnuevoproducto.Name = "groupBoxnuevoproducto";
            groupBoxnuevoproducto.Padding = new Padding(2);
            groupBoxnuevoproducto.Size = new Size(448, 161);
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
            dataGridView1.Margin = new Padding(2);
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
            groupBox1.Location = new Point(20, 223);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
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
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(428, 206);
            groupBox3.TabIndex = 108;
            groupBox3.TabStop = false;
            // 
            // txtSaldoinicial
            // 
            txtSaldoinicial.Location = new Point(165, 21);
            txtSaldoinicial.Margin = new Padding(2);
            txtSaldoinicial.Name = "txtSaldoinicial";
            txtSaldoinicial.Size = new Size(150, 31);
            txtSaldoinicial.TabIndex = 10;
            // 
            // txtSaldofinal
            // 
            txtSaldofinal.Location = new Point(165, 155);
            txtSaldofinal.Margin = new Padding(2);
            txtSaldofinal.Name = "txtSaldofinal";
            txtSaldofinal.Size = new Size(150, 31);
            txtSaldofinal.TabIndex = 9;
            // 
            // txtTotalingresos
            // 
            txtTotalingresos.Location = new Point(165, 62);
            txtTotalingresos.Margin = new Padding(2);
            txtTotalingresos.Name = "txtTotalingresos";
            txtTotalingresos.Size = new Size(150, 31);
            txtTotalingresos.TabIndex = 8;
            // 
            // txtTotalegresos
            // 
            txtTotalegresos.Location = new Point(165, 110);
            txtTotalegresos.Margin = new Padding(2);
            txtTotalegresos.Name = "txtTotalegresos";
            txtTotalegresos.Size = new Size(150, 31);
            txtTotalegresos.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 69);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 6;
            label1.Text = "Total ingreso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 116);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 5;
            label2.Text = "Total egresos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 161);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 4;
            label4.Text = "Saldo final:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 28);
            label3.Margin = new Padding(2, 0, 2, 0);
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
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(564, 122);
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
            btnCerrarcaja.BackColor = Color.FromArgb(64, 0, 0);
            btnCerrarcaja.ForeColor = SystemColors.ControlLightLight;
            btnCerrarcaja.Location = new Point(876, 610);
            btnCerrarcaja.Margin = new Padding(2);
            btnCerrarcaja.Name = "btnCerrarcaja";
            btnCerrarcaja.Size = new Size(165, 34);
            btnCerrarcaja.TabIndex = 138;
            btnCerrarcaja.Text = "Cerrar caja";
            btnCerrarcaja.UseVisualStyleBackColor = false;
            // 
            // btnGuardarmovimiento
            // 
            btnGuardarmovimiento.BackColor = Color.FromArgb(64, 0, 0);
            btnGuardarmovimiento.ForeColor = SystemColors.ControlLightLight;
            btnGuardarmovimiento.Location = new Point(638, 610);
            btnGuardarmovimiento.Margin = new Padding(2);
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
            groupBox2.Location = new Point(696, 235);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(300, 196);
            groupBox2.TabIndex = 135;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registrar movimiento ";
            // 
            // CBtipo
            // 
            CBtipo.FormattingEnabled = true;
            CBtipo.Location = new Point(72, 26);
            CBtipo.Margin = new Padding(2);
            CBtipo.Name = "CBtipo";
            CBtipo.Size = new Size(196, 33);
            CBtipo.TabIndex = 86;
            // 
            // txtReferencia
            // 
            txtReferencia.Location = new Point(111, 155);
            txtReferencia.Margin = new Padding(2);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(159, 31);
            txtReferencia.TabIndex = 6;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(88, 111);
            txtMonto.Margin = new Padding(2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(182, 31);
            txtMonto.TabIndex = 5;
            // 
            // txtConcepto
            // 
            txtConcepto.Location = new Point(111, 65);
            txtConcepto.Margin = new Padding(2);
            txtConcepto.Name = "txtConcepto";
            txtConcepto.Size = new Size(159, 31);
            txtConcepto.TabIndex = 4;
            // 
            // lblreferencia
            // 
            lblreferencia.AutoSize = true;
            lblreferencia.Location = new Point(12, 161);
            lblreferencia.Margin = new Padding(2, 0, 2, 0);
            lblreferencia.Name = "lblreferencia";
            lblreferencia.Size = new Size(96, 25);
            lblreferencia.TabIndex = 3;
            lblreferencia.Text = "Referencia:";
            // 
            // lblmonto
            // 
            lblmonto.AutoSize = true;
            lblmonto.Location = new Point(12, 118);
            lblmonto.Margin = new Padding(2, 0, 2, 0);
            lblmonto.Name = "lblmonto";
            lblmonto.Size = new Size(70, 25);
            lblmonto.TabIndex = 2;
            lblmonto.Text = "Monto:";
            // 
            // lblconcepto
            // 
            lblconcepto.AutoSize = true;
            lblconcepto.Location = new Point(12, 71);
            lblconcepto.Margin = new Padding(2, 0, 2, 0);
            lblconcepto.Name = "lblconcepto";
            lblconcepto.Size = new Size(93, 25);
            lblconcepto.TabIndex = 1;
            lblconcepto.Text = "Concepto:";
            // 
            // lbltipo
            // 
            lbltipo.AutoSize = true;
            lbltipo.Location = new Point(12, 38);
            lbltipo.Margin = new Padding(2, 0, 2, 0);
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
            groupBoxdatos.Location = new Point(20, 143);
            groupBoxdatos.Margin = new Padding(2);
            groupBoxdatos.Name = "groupBoxdatos";
            groupBoxdatos.Padding = new Padding(2);
            groupBoxdatos.Size = new Size(1041, 74);
            groupBoxdatos.TabIndex = 134;
            groupBoxdatos.TabStop = false;
            // 
            // CBusuario
            // 
            CBusuario.FormattingEnabled = true;
            CBusuario.Location = new Point(371, 28);
            CBusuario.Margin = new Padding(2);
            CBusuario.Name = "CBusuario";
            CBusuario.Size = new Size(648, 33);
            CBusuario.TabIndex = 85;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(280, 28);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 25);
            label7.TabIndex = 2;
            label7.Text = "Usuario:";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(84, 28);
            txtFecha.Margin = new Padding(2);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(150, 31);
            txtFecha.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 30);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(61, 25);
            label8.TabIndex = 0;
            label8.Text = "Fecha:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagen_circular_recortada;
            pictureBox1.Location = new Point(967, 7);
            pictureBox1.Margin = new Padding(2);
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
            label5.Location = new Point(36, 43);
            label5.Margin = new Padding(2, 0, 2, 0);
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
            label6.Location = new Point(20, 67);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(942, 32);
            label6.TabIndex = 131;
            label6.Text = "__________________________________________________________";
            // 
            // Formcaja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 768);
            Controls.Add(groupBoxnuevoproducto);
            Controls.Add(groupBox1);
            Controls.Add(btnCerrarcaja);
            Controls.Add(btnGuardarmovimiento);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxdatos);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            Name = "Formcaja";
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
    }
}
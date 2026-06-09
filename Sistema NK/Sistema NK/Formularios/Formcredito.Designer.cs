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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formcredito));
            groupBoxdatos = new GroupBox();
            btnbuscarcliente = new Button();
            cmbclientes = new ComboBox();
            label3 = new Label();
            txtfecha = new TextBox();
            label2 = new Label();
            txtfactura = new TextBox();
            label4 = new Label();
            groupBoxdatagrid = new GroupBox();
            btngenerar = new Button();
            btnregistrar = new Button();
            dataGridViewcredito = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            iva = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            btnvalidar = new Button();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblestado = new Label();
            lbldisponible = new Label();
            lblpendiente = new Label();
            lbllimite = new Label();
            groupBox3 = new GroupBox();
            textBox5 = new TextBox();
            label9 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            cmbvencimiento = new ComboBox();
            cmbplazo = new ComboBox();
            label10 = new Label();
            label8 = new Label();
            txttotal = new TextBox();
            txtiva = new TextBox();
            label13 = new Label();
            txtsubtotal = new TextBox();
            label14 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            btn_ayuda = new Button();
            imageList1 = new ImageList(components);
            groupBoxdatos.SuspendLayout();
            groupBoxdatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewcredito).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxdatos
            // 
            groupBoxdatos.BackColor = Color.SeaShell;
            groupBoxdatos.Controls.Add(btnbuscarcliente);
            groupBoxdatos.Controls.Add(cmbclientes);
            groupBoxdatos.Controls.Add(label3);
            groupBoxdatos.Controls.Add(txtfecha);
            groupBoxdatos.Controls.Add(label2);
            groupBoxdatos.Controls.Add(txtfactura);
            groupBoxdatos.Controls.Add(label4);
            groupBoxdatos.ForeColor = Color.FromArgb(64, 0, 0);
            groupBoxdatos.Location = new Point(133, 130);
            groupBoxdatos.Name = "groupBoxdatos";
            groupBoxdatos.Size = new Size(1023, 74);
            groupBoxdatos.TabIndex = 112;
            groupBoxdatos.TabStop = false;
            // 
            // btnbuscarcliente
            // 
            btnbuscarcliente.BackColor = Color.Maroon;
            btnbuscarcliente.ForeColor = SystemColors.ControlLightLight;
            btnbuscarcliente.Location = new Point(848, 23);
            btnbuscarcliente.Name = "btnbuscarcliente";
            btnbuscarcliente.Size = new Size(156, 34);
            btnbuscarcliente.TabIndex = 86;
            btnbuscarcliente.Text = "Buscar Cliente";
            btnbuscarcliente.UseVisualStyleBackColor = false;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 27);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 0;
            label4.Text = "No.Factura:";
            // 
            // groupBoxdatagrid
            // 
            groupBoxdatagrid.BackColor = Color.SeaShell;
            groupBoxdatagrid.Controls.Add(btngenerar);
            groupBoxdatagrid.Controls.Add(btnregistrar);
            groupBoxdatagrid.Controls.Add(dataGridViewcredito);
            groupBoxdatagrid.Controls.Add(btnvalidar);
            groupBoxdatagrid.Controls.Add(groupBox2);
            groupBoxdatagrid.Controls.Add(groupBox3);
            groupBoxdatagrid.Controls.Add(txttotal);
            groupBoxdatagrid.Controls.Add(txtiva);
            groupBoxdatagrid.Controls.Add(label13);
            groupBoxdatagrid.Controls.Add(txtsubtotal);
            groupBoxdatagrid.Controls.Add(label14);
            groupBoxdatagrid.Controls.Add(label1);
            groupBoxdatagrid.Location = new Point(133, 241);
            groupBoxdatagrid.Name = "groupBoxdatagrid";
            groupBoxdatagrid.Size = new Size(1023, 438);
            groupBoxdatagrid.TabIndex = 113;
            groupBoxdatagrid.TabStop = false;
            // 
            // btngenerar
            // 
            btngenerar.BackColor = Color.Maroon;
            btngenerar.ForeColor = SystemColors.ControlLightLight;
            btngenerar.Location = new Point(848, 388);
            btngenerar.Name = "btngenerar";
            btngenerar.Size = new Size(169, 34);
            btngenerar.TabIndex = 105;
            btngenerar.Text = "Generar";
            btngenerar.UseVisualStyleBackColor = false;
            // 
            // btnregistrar
            // 
            btnregistrar.BackColor = Color.Maroon;
            btnregistrar.ForeColor = SystemColors.ControlLightLight;
            btnregistrar.Location = new Point(592, 388);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(232, 34);
            btnregistrar.TabIndex = 104;
            btnregistrar.Text = "Registrar Venta a Crédito";
            btnregistrar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewcredito
            // 
            dataGridViewcredito.BackgroundColor = Color.SeaShell;
            dataGridViewcredito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewcredito.Columns.AddRange(new DataGridViewColumn[] { codigo, producto, cantidad, precio, iva, subtotal });
            dataGridViewcredito.Location = new Point(24, 36);
            dataGridViewcredito.Name = "dataGridViewcredito";
            dataGridViewcredito.RowHeadersWidth = 62;
            dataGridViewcredito.Size = new Size(959, 121);
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
            // btnvalidar
            // 
            btnvalidar.BackColor = Color.Maroon;
            btnvalidar.ForeColor = SystemColors.ControlLightLight;
            btnvalidar.Location = new Point(415, 388);
            btnvalidar.Name = "btnvalidar";
            btnvalidar.Size = new Size(156, 34);
            btnvalidar.TabIndex = 103;
            btnvalidar.Text = "Validar Crédito";
            btnvalidar.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SeaShell;
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(lblestado);
            groupBox2.Controls.Add(lbldisponible);
            groupBox2.Controls.Add(lblpendiente);
            groupBox2.Controls.Add(lbllimite);
            groupBox2.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox2.Location = new Point(699, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 196);
            groupBox2.TabIndex = 84;
            groupBox2.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(173, 155);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 31);
            textBox4.TabIndex = 92;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(173, 108);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 31);
            textBox3.TabIndex = 91;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 31);
            textBox2.TabIndex = 90;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 31);
            textBox1.TabIndex = 89;
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
            lblpendiente.Location = new Point(12, 60);
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
            groupBox3.BackColor = Color.SeaShell;
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(cmbvencimiento);
            groupBox3.Controls.Add(cmbplazo);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(318, 172);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 210);
            groupBox3.TabIndex = 85;
            groupBox3.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(170, 158);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(124, 31);
            textBox5.TabIndex = 104;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 164);
            label9.Name = "label9";
            label9.Size = new Size(49, 25);
            label9.TabIndex = 103;
            label9.Text = "Tasa:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(170, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(122, 33);
            comboBox1.TabIndex = 90;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 73);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 89;
            label7.Text = "Solicitud:";
            // 
            // cmbvencimiento
            // 
            cmbvencimiento.FormattingEnabled = true;
            cmbvencimiento.Location = new Point(172, 112);
            cmbvencimiento.Name = "cmbvencimiento";
            cmbvencimiento.Size = new Size(122, 33);
            cmbvencimiento.TabIndex = 88;
            // 
            // cmbplazo
            // 
            cmbplazo.FormattingEnabled = true;
            cmbplazo.Location = new Point(172, 19);
            cmbplazo.Name = "cmbplazo";
            cmbplazo.Size = new Size(122, 33);
            cmbplazo.TabIndex = 86;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 120);
            label10.Name = "label10";
            label10.Size = new Size(113, 25);
            label10.TabIndex = 3;
            label10.Text = "Vencimiento:";
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
            // txttotal
            // 
            txttotal.Location = new Point(122, 172);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(150, 31);
            txttotal.TabIndex = 102;
            // 
            // txtiva
            // 
            txtiva.Location = new Point(122, 255);
            txtiva.Name = "txtiva";
            txtiva.Size = new Size(150, 31);
            txtiva.TabIndex = 101;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 178);
            label13.Name = "label13";
            label13.Size = new Size(70, 25);
            label13.TabIndex = 97;
            label13.Text = "Monto:";
            // 
            // txtsubtotal
            // 
            txtsubtotal.Location = new Point(122, 214);
            txtsubtotal.Name = "txtsubtotal";
            txtsubtotal.Size = new Size(150, 31);
            txtsubtotal.TabIndex = 100;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(29, 216);
            label14.Name = "label14";
            label14.Size = new Size(43, 25);
            label14.TabIndex = 98;
            label14.Text = "IVA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 258);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 99;
            label1.Text = "Total:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagen_circular_recortada;
            pictureBox1.Location = new Point(1225, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 111;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(78, 56);
            label5.Name = "label5";
            label5.Size = new Size(259, 32);
            label5.TabIndex = 110;
            label5.Text = "Gestión de Crédito";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(37, 68);
            label6.Name = "label6";
            label6.Size = new Size(1182, 32);
            label6.TabIndex = 109;
            label6.Text = "_________________________________________________________________________";
            label6.Click += label6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1349, 26);
            panel1.TabIndex = 152;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 0);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1323, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(26, 742);
            panel2.TabIndex = 153;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 0, 0);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(26, 742);
            panel3.TabIndex = 154;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 0, 0);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(26, 742);
            panel4.Name = "panel4";
            panel4.Size = new Size(1297, 26);
            panel4.TabIndex = 155;
            // 
            // btn_ayuda
            // 
            btn_ayuda.ImageIndex = 0;
            btn_ayuda.ImageList = imageList1;
            btn_ayuda.Location = new Point(1270, 122);
            btn_ayuda.Name = "btn_ayuda";
            btn_ayuda.Size = new Size(47, 43);
            btn_ayuda.TabIndex = 156;
            btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "boton-de-informacion.png");
            // 
            // Formcredito
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 768);
            Controls.Add(btn_ayuda);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBoxdatos);
            Controls.Add(groupBoxdatagrid);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formcredito";
            groupBoxdatos.ResumeLayout(false);
            groupBoxdatos.PerformLayout();
            groupBoxdatagrid.ResumeLayout(false);
            groupBoxdatagrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewcredito).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBoxdatos;
        private Button btnbuscarcliente;
        private ComboBox cmbclientes;
        private Label label3;
        private TextBox txtfecha;
        private Label label2;
        private TextBox txtfactura;
        private Label label4;
        private GroupBox groupBoxdatagrid;
        private Button btngenerar;
        private Button btnregistrar;
        private DataGridView dataGridViewcredito;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn iva;
        private DataGridViewTextBoxColumn subtotal;
        private Button btnvalidar;
        private GroupBox groupBox2;
        private Label lblestado;
        private Label lbldisponible;
        private Label lblpendiente;
        private Label lbllimite;
        private GroupBox groupBox3;
        private ComboBox cmbvencimiento;
        private ComboBox cmbplazo;
        private Label label10;
        private Label label8;
        private TextBox txttotal;
        private TextBox txtiva;
        private Label label13;
        private TextBox txtsubtotal;
        private Label label14;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label7;
        private TextBox textBox5;
        private Label label9;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btn_ayuda;
        private ImageList imageList1;
    }
}
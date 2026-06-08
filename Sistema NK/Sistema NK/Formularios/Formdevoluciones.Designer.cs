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
            groupBoxdatagrid = new GroupBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label7 = new Label();
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
            groupBoxdatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewdevo).BeginInit();
            groupBoxnuevoproducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewnuevoproducto).BeginInit();
            groupBoxtipodevolucion.SuspendLayout();
            groupBoxdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxdatagrid
            // 
            groupBoxdatagrid.BackColor = Color.SeaShell;
            groupBoxdatagrid.Controls.Add(comboBox1);
            groupBoxdatagrid.Controls.Add(textBox3);
            groupBoxdatagrid.Controls.Add(label7);
            groupBoxdatagrid.Controls.Add(label4);
            groupBoxdatagrid.Controls.Add(dataGridViewdevo);
            groupBoxdatagrid.Location = new Point(12, 236);
            groupBoxdatagrid.Name = "groupBoxdatagrid";
            groupBoxdatagrid.Size = new Size(1038, 165);
            groupBoxdatagrid.TabIndex = 137;
            groupBoxdatagrid.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(9, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 96;
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
            groupBoxnuevoproducto.Location = new Point(12, 518);
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
            groupBoxtipodevolucion.Controls.Add(btncambio);
            groupBoxtipodevolucion.Controls.Add(btnreembolso);
            groupBoxtipodevolucion.Location = new Point(12, 422);
            groupBoxtipodevolucion.Name = "groupBoxtipodevolucion";
            groupBoxtipodevolucion.Size = new Size(1038, 77);
            groupBoxtipodevolucion.TabIndex = 135;
            groupBoxtipodevolucion.TabStop = false;
            groupBoxtipodevolucion.Text = "Tipo de Devolución";
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
            btnimprimir.Location = new Point(840, 710);
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
            btnvalidar.Location = new Point(630, 710);
            btnvalidar.Name = "btnvalidar";
            btnvalidar.Size = new Size(184, 34);
            btnvalidar.TabIndex = 133;
            btnvalidar.Text = "Guardar";
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
            groupBoxdatos.Location = new Point(17, 114);
            groupBoxdatos.Name = "groupBoxdatos";
            groupBoxdatos.Size = new Size(1042, 116);
            groupBoxdatos.TabIndex = 132;
            groupBoxdatos.TabStop = false;
            // 
            // btnbuscarventa
            // 
            btnbuscarventa.BackColor = Color.Maroon;
            btnbuscarventa.ForeColor = SystemColors.ControlLightLight;
            btnbuscarventa.Location = new Point(278, 30);
            btnbuscarventa.Name = "btnbuscarventa";
            btnbuscarventa.Size = new Size(156, 34);
            btnbuscarventa.TabIndex = 86;
            btnbuscarventa.Text = "Buscar Venta";
            btnbuscarventa.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 72);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 84;
            label3.Text = "Fecha Venta:";
            // 
            // txtcliente
            // 
            txtcliente.Location = new Point(114, 66);
            txtcliente.Name = "txtcliente";
            txtcliente.Size = new Size(150, 31);
            txtcliente.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 69);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 2;
            label2.Text = "Cliente:";
            label2.Click += label2_Click;
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
            pictureBox1.Location = new Point(958, 10);
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
            label5.Location = new Point(26, 46);
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
            label6.Location = new Point(12, 70);
            label6.Name = "label6";
            label6.Size = new Size(942, 32);
            label6.TabIndex = 129;
            label6.Text = "__________________________________________________________";
            // 
            // Formdevoluciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 768);
            Controls.Add(groupBoxdatagrid);
            Controls.Add(groupBoxnuevoproducto);
            Controls.Add(groupBoxtipodevolucion);
            Controls.Add(btnimprimir);
            Controls.Add(btnvalidar);
            Controls.Add(groupBoxdatos);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Formdevoluciones";
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
        private Label label4;
        private ComboBox comboBox1;
    }
}
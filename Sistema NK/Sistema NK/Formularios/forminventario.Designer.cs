namespace Sistema_NK
{
    partial class forminventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forminventario));
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            groupBoxnuevoproducto = new GroupBox();
            button16 = new Button();
            dataGridView2 = new DataGridView();
            Código = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Categoría = new DataGridViewTextBoxColumn();
            Stock_actual = new DataGridViewTextBoxColumn();
            Stock_minimo = new DataGridViewTextBoxColumn();
            Unidad = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Precio_venta = new DataGridViewTextBoxColumn();
            Valor_total = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            button7 = new Button();
            label2 = new Label();
            label13 = new Label();
            textBox12 = new TextBox();
            label17 = new Label();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxnuevoproducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagen_circular_recortada;
            pictureBox1.Location = new Point(958, 20);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 132;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(25, 56);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(294, 32);
            label5.TabIndex = 131;
            label5.Text = "Gestión de Inventario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(11, 80);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(942, 32);
            label6.TabIndex = 130;
            label6.Text = "__________________________________________________________";
            // 
            // groupBoxnuevoproducto
            // 
            groupBoxnuevoproducto.BackColor = Color.SeaShell;
            groupBoxnuevoproducto.Controls.Add(button16);
            groupBoxnuevoproducto.Controls.Add(dataGridView2);
            groupBoxnuevoproducto.Location = new Point(25, 354);
            groupBoxnuevoproducto.Margin = new Padding(2);
            groupBoxnuevoproducto.Name = "groupBoxnuevoproducto";
            groupBoxnuevoproducto.Padding = new Padding(2);
            groupBoxnuevoproducto.Size = new Size(1222, 295);
            groupBoxnuevoproducto.TabIndex = 146;
            groupBoxnuevoproducto.TabStop = false;
            groupBoxnuevoproducto.Text = "Lista de productos en inventario";
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(64, 0, 0);
            button16.BackgroundImageLayout = ImageLayout.None;
            button16.Font = new Font("PMingLiU-ExtB", 10F);
            button16.ForeColor = Color.White;
            button16.Location = new Point(12, 241);
            button16.Margin = new Padding(2);
            button16.Name = "button16";
            button16.Size = new Size(151, 42);
            button16.TabIndex = 42;
            button16.Text = "Imprimir reporte";
            button16.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.SeaShell;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Código, Producto, Categoría, Stock_actual, Stock_minimo, Unidad, Estado, Precio_venta, Valor_total });
            dataGridView2.Location = new Point(12, 44);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1180, 158);
            dataGridView2.TabIndex = 0;
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.MinimumWidth = 8;
            Código.Name = "Código";
            Código.Width = 125;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 125;
            // 
            // Categoría
            // 
            Categoría.HeaderText = "Categoría";
            Categoría.MinimumWidth = 6;
            Categoría.Name = "Categoría";
            Categoría.Width = 120;
            // 
            // Stock_actual
            // 
            Stock_actual.HeaderText = "Stock Actual";
            Stock_actual.MinimumWidth = 6;
            Stock_actual.Name = "Stock_actual";
            Stock_actual.Width = 125;
            // 
            // Stock_minimo
            // 
            Stock_minimo.HeaderText = "Stock Minimo";
            Stock_minimo.MinimumWidth = 6;
            Stock_minimo.Name = "Stock_minimo";
            Stock_minimo.Width = 125;
            // 
            // Unidad
            // 
            Unidad.HeaderText = "Unidad";
            Unidad.MinimumWidth = 6;
            Unidad.Name = "Unidad";
            Unidad.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 120;
            // 
            // Precio_venta
            // 
            Precio_venta.HeaderText = "Precio Venta";
            Precio_venta.MinimumWidth = 6;
            Precio_venta.Name = "Precio_venta";
            Precio_venta.Width = 125;
            // 
            // Valor_total
            // 
            Valor_total.HeaderText = "Valor Total";
            Valor_total.MinimumWidth = 6;
            Valor_total.Name = "Valor_total";
            Valor_total.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(textBox12);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button4);
            groupBox1.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(25, 129);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1022, 200);
            groupBox1.TabIndex = 145;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros de búsqueda ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(10, 134);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(200, 32);
            checkBox1.TabIndex = 43;
            checkBox1.Text = "Solo stock bajo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("PMingLiU-ExtB", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(655, 71);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(306, 26);
            comboBox1.TabIndex = 121;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("PMingLiU-ExtB", 9F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(365, 70);
            comboBox3.Margin = new Padding(2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(245, 26);
            comboBox3.TabIndex = 120;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(274, 68);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(38, 34);
            button7.TabIndex = 119;
            button7.Text = "Cerrar Sesión ";
            button7.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 10F);
            label2.Location = new Point(652, 40);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 60;
            label2.Text = "Estado:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("PMingLiU-ExtB", 10F);
            label13.Location = new Point(362, 40);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(86, 20);
            label13.TabIndex = 47;
            label13.Text = "Categoría:";
            // 
            // textBox12
            // 
            textBox12.Font = new Font("PMingLiU-ExtB", 9F);
            textBox12.Location = new Point(12, 70);
            textBox12.Margin = new Padding(2);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(255, 29);
            textBox12.TabIndex = 46;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("PMingLiU-ExtB", 10F);
            label17.Location = new Point(8, 39);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(134, 20);
            label17.TabIndex = 37;
            label17.Text = "Buscar producto:";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 0, 0);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Font = new Font("PMingLiU-ExtB", 10F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(498, 129);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(152, 42);
            button3.TabIndex = 45;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 0, 0);
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Font = new Font("PMingLiU-ExtB", 10F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(288, 129);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(151, 42);
            button4.TabIndex = 41;
            button4.Text = "Limpiar";
            button4.UseVisualStyleBackColor = false;
            // 
            // forminventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 768);
            Controls.Add(groupBoxnuevoproducto);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            Name = "forminventario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxnuevoproducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private GroupBox groupBoxnuevoproducto;
        private Button button16;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Categoría;
        private DataGridViewTextBoxColumn Stock_actual;
        private DataGridViewTextBoxColumn Stock_minimo;
        private DataGridViewTextBoxColumn Unidad;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Precio_venta;
        private DataGridViewTextBoxColumn Valor_total;
        private GroupBox groupBox1;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private Button button7;
        private Label label2;
        private Label label13;
        private TextBox textBox12;
        private Label label17;
        private Button button3;
        private Button button4;
    }
}
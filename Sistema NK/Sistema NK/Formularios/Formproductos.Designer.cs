namespace Sistema_NK
{
    partial class Formproductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formproductos));
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            button7 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label13 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            comboBox4 = new ComboBox();
            label9 = new Label();
            button3 = new Button();
            label2 = new Label();
            textBox7 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label8 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SeaShell;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column9 });
            dataGridView1.Location = new Point(30, 395);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1076, 185);
            dataGridView1.TabIndex = 89;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.HeaderText = "Código";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 110;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre del Articulo";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Categoría";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 130;
            // 
            // Column4
            // 
            Column4.HeaderText = "Marca";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 90;
            // 
            // Column5
            // 
            Column5.HeaderText = "Stock actual";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 130;
            // 
            // Column6
            // 
            Column6.HeaderText = "Stock mínimo";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 160;
            // 
            // Column7
            // 
            Column7.HeaderText = "Precio Venta";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 150;
            // 
            // Column9
            // 
            Column9.HeaderText = "Estado";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.Width = 90;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button4);
            groupBox1.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(30, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1042, 254);
            groupBox1.TabIndex = 97;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Producto";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(868, 211);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(30, 34);
            button7.TabIndex = 121;
            button7.Text = "Cerrar Sesión ";
            button7.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(86, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(316, 31);
            dateTimePicker1.TabIndex = 100;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(14, 32);
            label13.Name = "label13";
            label13.Size = new Size(57, 20);
            label13.TabIndex = 99;
            label13.Text = "Fecha:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(434, 156);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(113, 31);
            textBox6.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(434, 126);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 46;
            label7.Text = "Precio Venta:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(696, 211);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(156, 31);
            textBox5.TabIndex = 45;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(534, 214);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(142, 28);
            comboBox4.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(434, 214);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 43;
            label9.Text = "Buscar por:";
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.ForeColor = Color.White;
            button3.Location = new Point(868, 135);
            button3.Name = "button3";
            button3.Size = new Size(163, 43);
            button3.TabIndex = 42;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 82);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 0;
            label2.Text = "Código:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(222, 156);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(113, 31);
            textBox7.TabIndex = 38;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(77, 73);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 31);
            textBox4.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(619, 77);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 1;
            label3.Text = "Categoria:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(222, 126);
            label8.Name = "label8";
            label8.Size = new Size(125, 20);
            label8.TabIndex = 33;
            label8.Text = "Precio Compra:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 79);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre del Articulo:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 31);
            textBox2.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 123);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 35;
            label10.Text = "Stock Minimo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(396, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 31);
            textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(710, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 28);
            comboBox1.TabIndex = 7;
            // 
            // button4
            // 
            button4.BackColor = Color.Maroon;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.ForeColor = Color.White;
            button4.Location = new Point(868, 86);
            button4.Name = "button4";
            button4.Size = new Size(163, 43);
            button4.TabIndex = 5;
            button4.Text = "Guardar";
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagen_circular_recortada;
            pictureBox1.Location = new Point(976, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 94;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(44, 48);
            label5.Name = "label5";
            label5.Size = new Size(291, 32);
            label5.TabIndex = 93;
            label5.Text = "Gestión de Productos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(30, 72);
            label6.Name = "label6";
            label6.Size = new Size(942, 32);
            label6.TabIndex = 92;
            label6.Text = "__________________________________________________________";
            // 
            // Formproductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 768);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Formproductos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column9;
        private GroupBox groupBox1;
        private TextBox textBox5;
        private ComboBox comboBox4;
        private Label label9;
        private Button button3;
        private Label label2;
        private TextBox textBox7;
        private TextBox textBox4;
        private Label label3;
        private Label label8;
        private Label label1;
        private TextBox textBox2;
        private Label label10;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button4;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label13;
        private Button button7;
    }
}
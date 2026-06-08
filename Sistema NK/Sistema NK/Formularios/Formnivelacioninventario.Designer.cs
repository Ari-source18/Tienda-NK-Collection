namespace Sistema_NK
{
    partial class Formnivelacioninventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formnivelacioninventario));
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            groupBoxnuevoproducto = new GroupBox();
            dataGridView1 = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Código = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Tipo_ajuste = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Motivo = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Observaciones = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            button16 = new Button();
            comboBox1 = new ComboBox();
            label20 = new Label();
            textBox10 = new TextBox();
            label17 = new Label();
            comboBox3 = new ComboBox();
            label18 = new Label();
            button3 = new Button();
            button4 = new Button();
            comboBox2 = new ComboBox();
            label21 = new Label();
            groupBox1 = new GroupBox();
            button7 = new Button();
            textBox6 = new TextBox();
            label12 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxnuevoproducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagen_circular_recortada;
            pictureBox1.Location = new Point(1249, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 132;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(30, 11);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(332, 32);
            label5.TabIndex = 131;
            label5.Text = "Nivelación de inventario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(14, 35);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(942, 32);
            label6.TabIndex = 130;
            label6.Text = "__________________________________________________________";
            // 
            // groupBoxnuevoproducto
            // 
            groupBoxnuevoproducto.BackColor = Color.SeaShell;
            groupBoxnuevoproducto.Controls.Add(dataGridView1);
            groupBoxnuevoproducto.Location = new Point(30, 524);
            groupBoxnuevoproducto.Margin = new Padding(2);
            groupBoxnuevoproducto.Name = "groupBoxnuevoproducto";
            groupBoxnuevoproducto.Padding = new Padding(2);
            groupBoxnuevoproducto.Size = new Size(1207, 215);
            groupBoxnuevoproducto.TabIndex = 143;
            groupBoxnuevoproducto.TabStop = false;
            groupBoxnuevoproducto.Text = "Historial de Nivelaciones";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SeaShell;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, Código, Producto, Tipo_ajuste, Cantidad, Motivo, Usuario, Observaciones });
            dataGridView1.Location = new Point(12, 44);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1164, 158);
            dataGridView1.TabIndex = 0;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 8;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
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
            // Tipo_ajuste
            // 
            Tipo_ajuste.HeaderText = "Tipo de ajuste";
            Tipo_ajuste.MinimumWidth = 6;
            Tipo_ajuste.Name = "Tipo_ajuste";
            Tipo_ajuste.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // Motivo
            // 
            Motivo.HeaderText = "Motivo";
            Motivo.MinimumWidth = 6;
            Motivo.Name = "Motivo";
            Motivo.Width = 125;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            Usuario.Width = 125;
            // 
            // Observaciones
            // 
            Observaciones.HeaderText = "Observaciones";
            Observaciones.MinimumWidth = 6;
            Observaciones.Name = "Observaciones";
            Observaciones.Width = 200;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SeaShell;
            groupBox2.Controls.Add(button16);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label21);
            groupBox2.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox2.Location = new Point(30, 262);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(1022, 258);
            groupBox2.TabIndex = 142;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ajustes de Nivelación ";
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(64, 0, 0);
            button16.BackgroundImageLayout = ImageLayout.None;
            button16.Font = new Font("PMingLiU-ExtB", 10F);
            button16.ForeColor = Color.White;
            button16.Location = new Point(708, 202);
            button16.Margin = new Padding(2);
            button16.Name = "button16";
            button16.Size = new Size(199, 42);
            button16.TabIndex = 124;
            button16.Text = "Generar reporte";
            button16.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("PMingLiU-ExtB", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(366, 70);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(285, 26);
            comboBox1.TabIndex = 123;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(64, 0, 0);
            label20.Location = new Point(11, 178);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(121, 20);
            label20.TabIndex = 122;
            label20.Text = "Observaciones:";
            // 
            // textBox10
            // 
            textBox10.Font = new Font("PMingLiU-ExtB", 9F);
            textBox10.Location = new Point(11, 212);
            textBox10.Margin = new Padding(2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(640, 29);
            textBox10.TabIndex = 57;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("PMingLiU-ExtB", 10F);
            label17.Location = new Point(9, 105);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(142, 20);
            label17.TabIndex = 56;
            label17.Text = "Motivo del ajuste:";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("PMingLiU-ExtB", 9F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(12, 70);
            comboBox3.Margin = new Padding(2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(306, 26);
            comboBox3.TabIndex = 112;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("PMingLiU-ExtB", 10F);
            label18.Location = new Point(364, 41);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(155, 20);
            label18.TabIndex = 47;
            label18.Text = "Cantidad de ajustar:";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 0, 0);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Font = new Font("PMingLiU-ExtB", 10F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(708, 132);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(152, 42);
            button3.TabIndex = 45;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 0, 0);
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Font = new Font("PMingLiU-ExtB", 10F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(708, 56);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(199, 42);
            button4.TabIndex = 41;
            button4.Text = "Nivelar Inventario";
            button4.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("PMingLiU-ExtB", 9F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(11, 146);
            comboBox2.Margin = new Padding(2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(640, 26);
            comboBox2.TabIndex = 110;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("PMingLiU-ExtB", 10F);
            label21.Location = new Point(9, 40);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(117, 20);
            label21.TabIndex = 37;
            label21.Text = "Tipo de ajuste:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(30, 83);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1022, 175);
            groupBox1.TabIndex = 141;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Producto";
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(271, 68);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(30, 34);
            button7.TabIndex = 119;
            button7.Text = "Cerrar Sesión ";
            button7.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("PMingLiU-ExtB", 10F);
            textBox6.Location = new Point(658, 68);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(322, 31);
            textBox6.TabIndex = 61;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("PMingLiU-ExtB", 10F);
            label12.Location = new Point(655, 42);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(86, 20);
            label12.TabIndex = 60;
            label12.Text = "Categoría:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("PMingLiU-ExtB", 10F);
            textBox3.Location = new Point(368, 130);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(202, 31);
            textBox3.TabIndex = 59;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("PMingLiU-ExtB", 10F);
            label8.Location = new Point(361, 109);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 58;
            label8.Text = "Stock físico:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("PMingLiU-ExtB", 9F);
            textBox2.Location = new Point(12, 132);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(298, 29);
            textBox2.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("PMingLiU-ExtB", 10F);
            label4.Location = new Point(10, 108);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 56;
            label4.Text = "Stock en sistema:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("PMingLiU-ExtB", 10F);
            textBox4.Location = new Point(368, 68);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(202, 31);
            textBox4.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 10F);
            label2.Location = new Point(365, 42);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 47;
            label2.Text = "Nombre:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("PMingLiU-ExtB", 9F);
            textBox1.Location = new Point(12, 70);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 29);
            textBox1.TabIndex = 46;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("PMingLiU-ExtB", 9F);
            textBox5.Location = new Point(658, 130);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(182, 29);
            textBox5.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("PMingLiU-ExtB", 10F);
            label9.Location = new Point(655, 110);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 38;
            label9.Text = "Diferencia:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("PMingLiU-ExtB", 10F);
            label10.Location = new Point(10, 41);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 37;
            label10.Text = "Código:";
            // 
            // Formnivelacioninventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 768);
            Controls.Add(groupBoxnuevoproducto);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            Name = "Formnivelacioninventario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxnuevoproducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Tipo_ajuste;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Motivo;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Observaciones;
        private GroupBox groupBox2;
        private Button button16;
        private ComboBox comboBox1;
        private Label label20;
        private TextBox textBox10;
        private Label label17;
        private ComboBox comboBox3;
        private Label label18;
        private Button button3;
        private Button button4;
        private ComboBox comboBox2;
        private Label label21;
        private GroupBox groupBox1;
        private Button button7;
        private TextBox textBox6;
        private Label label12;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox4;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox5;
        private Label label9;
        private Label label10;
    }
}
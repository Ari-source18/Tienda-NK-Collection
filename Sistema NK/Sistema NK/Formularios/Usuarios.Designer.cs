namespace Sistema_NK
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            button1 = new Button();
            label5 = new Label();
            tabControl1 = new TabControl();
            nuevousuario = new TabPage();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            listadeusuarios = new TabPage();
            button2 = new Button();
            textBox3 = new TextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            editar = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            nuevousuario.SuspendLayout();
            groupBox1.SuspendLayout();
            listadeusuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 0, 0);
            button1.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(909, 44);
            button1.Name = "button1";
            button1.Size = new Size(124, 34);
            button1.TabIndex = 84;
            button1.Text = "Ayuda";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(22, 44);
            label5.Name = "label5";
            label5.Size = new Size(277, 32);
            label5.TabIndex = 79;
            label5.Text = "Gestión de Usuarios";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(nuevousuario);
            tabControl1.Controls.Add(listadeusuarios);
            tabControl1.Location = new Point(22, 79);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1011, 604);
            tabControl1.TabIndex = 85;
            // 
            // nuevousuario
            // 
            nuevousuario.Controls.Add(groupBox1);
            nuevousuario.Controls.Add(button4);
            nuevousuario.Controls.Add(button3);
            nuevousuario.Location = new Point(4, 34);
            nuevousuario.Name = "nuevousuario";
            nuevousuario.Padding = new Padding(3);
            nuevousuario.Size = new Size(1003, 566);
            nuevousuario.TabIndex = 0;
            nuevousuario.Text = "Nuevo Usuario";
            nuevousuario.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(6, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(991, 403);
            groupBox1.TabIndex = 81;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Usuario";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("PMingLiU-ExtB", 10F);
            textBox4.Location = new Point(21, 355);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(204, 31);
            textBox4.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("PMingLiU-ExtB", 10F);
            label4.Location = new Point(271, 332);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 52;
            label4.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 10F);
            label1.Location = new Point(21, 324);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 50;
            label1.Text = "Usuario:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("PMingLiU-ExtB", 10F);
            textBox2.Location = new Point(271, 355);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 31);
            textBox2.TabIndex = 49;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("PMingLiU-ExtB", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(68, 256);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 28);
            comboBox1.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("PMingLiU-ExtB", 10F);
            label7.Location = new Point(271, 264);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 40;
            label7.Text = "Estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 10F);
            label2.Location = new Point(21, 256);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 47;
            label2.Text = "Rol:";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("PMingLiU-ExtB", 9F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(340, 264);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(135, 26);
            comboBox2.TabIndex = 42;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("PMingLiU-ExtB", 9F);
            textBox1.Location = new Point(21, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(695, 29);
            textBox1.TabIndex = 46;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("PMingLiU-ExtB", 9F);
            textBox5.Location = new Point(21, 178);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(182, 29);
            textBox5.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("PMingLiU-ExtB", 10F);
            label9.Location = new Point(21, 155);
            label9.Name = "label9";
            label9.Size = new Size(150, 20);
            label9.TabIndex = 38;
            label9.Text = "Correo electrónico:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("PMingLiU-ExtB", 10F);
            label10.Location = new Point(21, 81);
            label10.Name = "label10";
            label10.Size = new Size(148, 20);
            label10.TabIndex = 37;
            label10.Text = "Nombre completo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(21, 24);
            label6.Name = "label6";
            label6.Size = new Size(987, 28);
            label6.TabIndex = 57;
            label6.Text = "___________________________________________________________________________";
            // 
            // button4
            // 
            button4.BackColor = Color.SeaShell;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Font = new Font("PMingLiU-ExtB", 10F);
            button4.Location = new Point(27, 489);
            button4.Name = "button4";
            button4.Size = new Size(151, 43);
            button4.TabIndex = 41;
            button4.Text = "Guardar";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaShell;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Font = new Font("PMingLiU-ExtB", 10F);
            button3.Location = new Point(256, 489);
            button3.Name = "button3";
            button3.Size = new Size(153, 43);
            button3.TabIndex = 45;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = false;
            // 
            // listadeusuarios
            // 
            listadeusuarios.Controls.Add(button2);
            listadeusuarios.Controls.Add(textBox3);
            listadeusuarios.Controls.Add(label8);
            listadeusuarios.Controls.Add(dataGridView1);
            listadeusuarios.Location = new Point(4, 34);
            listadeusuarios.Name = "listadeusuarios";
            listadeusuarios.Padding = new Padding(3);
            listadeusuarios.Size = new Size(1003, 660);
            listadeusuarios.TabIndex = 1;
            listadeusuarios.Text = "Listas de Usuarios";
            listadeusuarios.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(298, 34);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(30, 34);
            button2.TabIndex = 121;
            button2.Text = "Cerrar Sesión ";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("PMingLiU-ExtB", 10F);
            textBox3.Location = new Point(89, 34);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 31);
            textBox3.TabIndex = 85;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 37);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 84;
            label8.Text = "Buscar:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SeaShell;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column4, Column5, Column7, editar });
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(18, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(967, 270);
            dataGridView1.TabIndex = 83;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 250;
            // 
            // Column4
            // 
            Column4.HeaderText = "Usuario";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 90;
            // 
            // Column5
            // 
            Column5.HeaderText = "Rol";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column7
            // 
            Column7.HeaderText = "Correo electrónico";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 120;
            // 
            // editar
            // 
            editar.HeaderText = "Estado";
            editar.MinimumWidth = 8;
            editar.Name = "editar";
            editar.Width = 150;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 768);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Usuarios";
            Text = " ";
            Load += Usuarios_Load;
            tabControl1.ResumeLayout(false);
            nuevousuario.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            listadeusuarios.ResumeLayout(false);
            listadeusuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label5;
        private TabControl tabControl1;
        private TabPage nuevousuario;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private Label label4;
        private Label label1;
        private TextBox textBox2;
        private Button button3;
        private Button button4;
        private ComboBox comboBox1;
        private Label label7;
        private Label label2;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox5;
        private Label label9;
        private Label label10;
        private Label label6;
        private TabPage listadeusuarios;
        private DataGridView dataGridView1;
        private Label label8;
        private Button button2;
        private TextBox textBox3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn editar;
    }
}
namespace Sistema_NK
{
    partial class Categoría
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
            label5 = new Label();
            btncategoria = new Button();
            lblbuscar = new Label();
            maskedTextBox1 = new MaskedTextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(11, 20);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(267, 32);
            label5.TabIndex = 91;
            label5.Text = "Gestión de Clientes";
            // 
            // btncategoria
            // 
            btncategoria.Location = new Point(12, 67);
            btncategoria.Name = "btncategoria";
            btncategoria.Size = new Size(159, 34);
            btncategoria.TabIndex = 92;
            btncategoria.Text = "Nueva Categoría";
            btncategoria.UseVisualStyleBackColor = true;
            // 
            // lblbuscar
            // 
            lblbuscar.AutoSize = true;
            lblbuscar.Location = new Point(353, 67);
            lblbuscar.Name = "lblbuscar";
            lblbuscar.Size = new Size(67, 25);
            lblbuscar.TabIndex = 93;
            lblbuscar.Text = "Buscar:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(426, 64);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(150, 31);
            maskedTextBox1.TabIndex = 94;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(27, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(620, 225);
            dataGridView1.TabIndex = 95;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Categoría";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Descripción";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Estado";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 404);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 96;
            label1.Text = "Total de categoría:";
            // 
            // button1
            // 
            button1.Location = new Point(327, 395);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 97;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Categoría
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(maskedTextBox1);
            Controls.Add(lblbuscar);
            Controls.Add(btncategoria);
            Controls.Add(label5);
            Name = "Categoría";
            Text = "Categoría";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button btncategoria;
        private Label lblbuscar;
        private MaskedTextBox maskedTextBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label1;
        private Button button1;
    }
}
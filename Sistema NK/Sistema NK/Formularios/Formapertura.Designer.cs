namespace Sistema_NK
{
    partial class Formapertura
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
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            txtSaldoinicial = new TextBox();
            txtTotalingresos = new TextBox();
            label1 = new Label();
            label3 = new Label();
            button4 = new Button();
            button1 = new Button();
            label5 = new Label();
            button5 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(txtSaldoinicial);
            groupBox1.Controls.Add(txtTotalingresos);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(11, 11);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(599, 309);
            groupBox1.TabIndex = 140;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagen_circular_recortada;
            pictureBox1.Location = new Point(4, 13);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 134;
            pictureBox1.TabStop = false;
            // 
            // txtSaldoinicial
            // 
            txtSaldoinicial.Location = new Point(415, 74);
            txtSaldoinicial.Margin = new Padding(2);
            txtSaldoinicial.Name = "txtSaldoinicial";
            txtSaldoinicial.Size = new Size(121, 27);
            txtSaldoinicial.TabIndex = 140;
            // 
            // txtTotalingresos
            // 
            txtTotalingresos.Location = new Point(415, 107);
            txtTotalingresos.Margin = new Padding(2);
            txtTotalingresos.Name = "txtTotalingresos";
            txtTotalingresos.Size = new Size(121, 27);
            txtTotalingresos.TabIndex = 139;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 111);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 137;
            label1.Text = "Valor de dolar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 78);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 135;
            label3.Text = "Saldo inicial:";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 0, 0);
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Font = new Font("PMingLiU-ExtB", 10F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(287, 166);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(121, 34);
            button4.TabIndex = 141;
            button4.Text = "Iniciar";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 0, 0);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("PMingLiU-ExtB", 10F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(415, 166);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(121, 34);
            button1.TabIndex = 142;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(265, 17);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(323, 27);
            label5.TabIndex = 143;
            label5.Text = "Gestión de Apertura de caja";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 0, 0);
            button5.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(489, 256);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(99, 27);
            button5.TabIndex = 144;
            button5.Text = "Cerrar Sesión ";
            button5.UseVisualStyleBackColor = false;
            // 
            // Formapertura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(623, 333);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Formapertura";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private TextBox txtSaldoinicial;
        private TextBox txtTotalingresos;
        private Label label1;
        private Label label3;
        private Button button1;
        private Button button4;
        private Label label5;
        private Button button5;
    }
}
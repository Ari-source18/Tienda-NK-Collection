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
            button5 = new Button();
            label5 = new Label();
            btnIniciar = new Button();
            txtSaldoinicial = new TextBox();
            txtValordolar = new TextBox();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnIniciar);
            groupBox1.Controls.Add(txtSaldoinicial);
            groupBox1.Controls.Add(txtValordolar);
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
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(64, 0, 0);
            btnIniciar.BackgroundImageLayout = ImageLayout.None;
            btnIniciar.Font = new Font("PMingLiU-ExtB", 10F);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(347, 164);
            btnIniciar.Margin = new Padding(2);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(121, 34);
            btnIniciar.TabIndex = 141;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            // 
            // txtSaldoinicial
            // 
            txtSaldoinicial.Location = new Point(415, 74);
            txtSaldoinicial.Margin = new Padding(2);
            txtSaldoinicial.Name = "txtSaldoinicial";
            txtSaldoinicial.Size = new Size(121, 27);
            txtSaldoinicial.TabIndex = 140;
            // 
            // txtValordolar
            // 
            txtValordolar.Location = new Point(415, 107);
            txtValordolar.Margin = new Padding(2);
            txtValordolar.Name = "txtValordolar";
            txtValordolar.Size = new Size(121, 27);
            txtValordolar.TabIndex = 139;
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
        private TextBox txtValordolar;
        private Label label1;
        private Label label3;
        private Button btnIniciar;
        private Label label5;
        private Button button5;
    }
}
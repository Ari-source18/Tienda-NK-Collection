namespace Sistema_NK
{
    partial class Pantalla_recuperación
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_recuperación));
            textBox1 = new TextBox();
            btncancelar = new Button();
            btncontinuar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 298);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(428, 31);
            textBox1.TabIndex = 0;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(148, 381);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(112, 34);
            btncancelar.TabIndex = 1;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            // 
            // btncontinuar
            // 
            btncontinuar.Location = new Point(513, 381);
            btncontinuar.Name = "btncontinuar";
            btncontinuar.Size = new Size(112, 34);
            btncontinuar.TabIndex = 2;
            btncontinuar.Text = "Continuar";
            btncontinuar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 211);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 3;
            label1.Text = "Recuperar contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 252);
            label2.Name = "label2";
            label2.Size = new Size(677, 25);
            label2.TabIndex = 4;
            label2.Text = "Ingrese su dirección de correo electrónico y enviaremos un enlace para restablecerla.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 451);
            label3.Name = "label3";
            label3.Size = new Size(230, 25);
            label3.TabIndex = 5;
            label3.Text = "Volver a la pantalla anterior.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(293, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Pantalla_recuperación
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 542);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btncontinuar);
            Controls.Add(btncancelar);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pantalla_recuperación";
            Text = "Pantalla_recuperación";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btncancelar;
        private Button btncontinuar;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
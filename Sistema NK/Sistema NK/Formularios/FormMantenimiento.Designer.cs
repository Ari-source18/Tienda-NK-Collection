namespace Sistema_NK.Formularios
{
    partial class FormMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMantenimiento));
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label7 = new Label();
            btn_Crear = new Button();
            btn_Restaurar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(530, 20);
            label5.Name = "label5";
            label5.Size = new Size(259, 40);
            label5.TabIndex = 98;
            label5.Text = "Mantenimiento";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(41, 39);
            label6.Name = "label6";
            label6.Size = new Size(1278, 32);
            label6.TabIndex = 97;
            label6.Text = "_______________________________________________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("PMingLiU-ExtB", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(304, 239);
            label4.Name = "label4";
            label4.Size = new Size(235, 24);
            label4.TabIndex = 102;
            label4.Text = "Crear copia de seguridad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("PMingLiU-ExtB", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(834, 238);
            label7.Name = "label7";
            label7.Size = new Size(223, 24);
            label7.TabIndex = 103;
            label7.Text = "Restaurar base de datos";
            // 
            // btn_Crear
            // 
            btn_Crear.BackColor = Color.Maroon;
            btn_Crear.FlatStyle = FlatStyle.Flat;
            btn_Crear.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Bold | FontStyle.Italic);
            btn_Crear.ForeColor = SystemColors.ControlLightLight;
            btn_Crear.Location = new Point(372, 551);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new Size(112, 34);
            btn_Crear.TabIndex = 104;
            btn_Crear.Text = "Crear";
            btn_Crear.UseVisualStyleBackColor = false;
            // 
            // btn_Restaurar
            // 
            btn_Restaurar.BackColor = Color.Maroon;
            btn_Restaurar.FlatStyle = FlatStyle.Flat;
            btn_Restaurar.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Bold | FontStyle.Italic);
            btn_Restaurar.ForeColor = SystemColors.ControlLightLight;
            btn_Restaurar.Location = new Point(906, 539);
            btn_Restaurar.Name = "btn_Restaurar";
            btn_Restaurar.Size = new Size(112, 34);
            btn_Restaurar.TabIndex = 105;
            btn_Restaurar.Text = "Restaurar";
            btn_Restaurar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(304, 280);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 253);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 106;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(834, 280);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(235, 253);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 107;
            pictureBox2.TabStop = false;
            // 
            // FormMantenimiento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 824);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Restaurar);
            Controls.Add(btn_Crear);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMantenimiento";
            Text = "FormMantenimiento";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label7;
        private Button btn_Crear;
        private Button btn_Restaurar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
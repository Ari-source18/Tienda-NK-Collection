namespace Sistema_NK
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lbl_recuperar_contrasena = new LinkLabel();
            btnAcceder = new Button();
            panel3 = new Panel();
            txtPassword = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txtUsuario = new TextBox();
            Username = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 560);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lbl_recuperar_contrasena
            // 
            lbl_recuperar_contrasena.ActiveLinkColor = Color.Black;
            lbl_recuperar_contrasena.AutoSize = true;
            lbl_recuperar_contrasena.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_recuperar_contrasena.LinkBehavior = LinkBehavior.NeverUnderline;
            lbl_recuperar_contrasena.LinkColor = Color.Gray;
            lbl_recuperar_contrasena.Location = new Point(509, 461);
            lbl_recuperar_contrasena.Name = "lbl_recuperar_contrasena";
            lbl_recuperar_contrasena.Size = new Size(218, 21);
            lbl_recuperar_contrasena.TabIndex = 13;
            lbl_recuperar_contrasena.TabStop = true;
            lbl_recuperar_contrasena.Text = "¿Olvidaste tu contraseña?";
            lbl_recuperar_contrasena.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.Black;
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Century Gothic", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Location = new Point(423, 392);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(395, 41);
            btnAcceder.TabIndex = 12;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(423, 308);
            panel3.Name = "panel3";
            panel3.Size = new Size(394, 59);
            panel3.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txtPassword.Location = new Point(15, 22);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(366, 24);
            txtPassword.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(392, 38);
            label2.TabIndex = 0;
            label2.Text = "Contraseña";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(Username);
            panel2.Location = new Point(423, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 59);
            panel2.TabIndex = 10;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            txtUsuario.Location = new Point(16, 29);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(366, 24);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // Username
            // 
            Username.Dock = DockStyle.Top;
            Username.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.ForeColor = Color.Gray;
            Username.Location = new Point(0, 0);
            Username.Name = "Username";
            Username.Size = new Size(392, 38);
            Username.TabIndex = 0;
            Username.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(484, 187);
            label1.Name = "label1";
            label1.Size = new Size(243, 25);
            label1.TabIndex = 9;
            label1.Text = "Bienvenido al sistema";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(545, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 129);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 560);
            Controls.Add(lbl_recuperar_contrasena);
            Controls.Add(btnAcceder);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel lbl_recuperar_contrasena;
        private Button btnAcceder;
        private Panel panel3;
        private TextBox txtPassword;
        private Label label2;
        private Panel panel2;
        private TextBox txtUsuario;
        private Label Username;
        private Label label1;
        private PictureBox pictureBox2;
    }
}

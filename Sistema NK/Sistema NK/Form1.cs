using System.Diagnostics.Eventing.Reader;
using Sistema_NK.Formularios;

namespace Sistema_NK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // application.Exit();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ariana" && txtPassword.Text == "12345")
            {
                MessageBox.Show("Bienvenido al Sistema Tienda NK Collection, Ariana");
                Main menu = new Main();
                menu.Show();
                this.Hide();
            }
            else
            {
                if (txtUsuario.Text != "Ariana" || txtPassword.Text != "12345")
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.");
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pantalla_recuperación pantalla = new Pantalla_recuperación();
            pantalla.Show();
            this.Hide();
        }
    }
}

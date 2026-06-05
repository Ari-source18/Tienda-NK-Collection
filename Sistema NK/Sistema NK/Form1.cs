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
            Main menu = new Main();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pantalla_recuperación  pantalla = new Pantalla_recuperación();
            pantalla.Show();
            this.Hide();
        }
    }
}

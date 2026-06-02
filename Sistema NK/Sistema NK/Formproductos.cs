using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_NK
{
    public partial class Formproductos : Form
    {
        public Formproductos()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menú_principal menu = new Menú_principal();
            menu.Show();
            this.Hide();
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            Usuarios Usuario = new Usuarios();
            Usuario.Show();
            this.Hide();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            Formcliente cliente = new Formcliente();
            cliente.Show();
            this.Hide();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            Formproductos productos = new Formproductos();
            productos.Show();
            this.Hide();
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            Formventas ventas = new Formventas();
            ventas.Show();
            this.Hide();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            Formcompras compras = new Formcompras();
            compras.Show();
            this.Hide();
        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            Formproveedores proveedores = new Formproveedores();
            proveedores.Show();
            this.Hide();
        }

        private void btncredito_Click(object sender, EventArgs e)
        {
            Formcredito credito = new Formcredito();
            credito.Show();
            this.Hide();
        }

        private void btndevolucionventas_Click(object sender, EventArgs e)
        {
            Formdevoluciones devoluciones = new Formdevoluciones();
            devoluciones.Show();
            this.Hide();
        }

        private void btndevolucioncompra_Click(object sender, EventArgs e)
        {
            Formdevolucionessobrecompra devolucionessobrecompras = new Formdevolucionessobrecompra();
            devolucionessobrecompras.Show();
            this.Hide();
        }

        private void btncaja_Click(object sender, EventArgs e)
        {
            Formcaja caja = new Formcaja();
            caja.Show();
            this.Hide();
        }

        private void btnnivelacioninventario_Click(object sender, EventArgs e)
        {
            Formnivelacioninventario nivelacioninventario = new Formnivelacioninventario();
            nivelacioninventario.Show();
            this.Hide();
        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            forminventario inventario = new forminventario();
            inventario.Show();
            this.Hide();
        }
    }
}

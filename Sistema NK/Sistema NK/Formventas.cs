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
    public partial class Formventas : Form
    {
        public Formventas()
        {
            InitializeComponent();
        }

       

        private void btnusuarios_Click_1(object sender, EventArgs e)
        {
            Usuarios Usuario = new Usuarios();
            Usuario.Show();
            this.Hide();
        }

        private void btnclientes_Click_1(object sender, EventArgs e)
        {
            Formcliente cliente = new Formcliente();
            cliente.Show();
            this.Hide();
        }

        private void btncompras_Click_1(object sender, EventArgs e)
        {
            Formcompras compras = new Formcompras();
            compras.Show();
            this.Hide();
        }

        private void btnventas_Click_1(object sender, EventArgs e)
        {
            Formventas ventas = new Formventas();
            ventas.Show();
            this.Hide();
        }

        private void btnproductos_Click_1(object sender, EventArgs e)
        {
            Formproductos productos = new Formproductos();
            productos.Show();
            this.Hide();
        }

        private void btnproveedores_Click_1(object sender, EventArgs e)
        {
            Formproveedores proveedores = new Formproveedores();
            proveedores.Show();
            this.Hide();
        }

        private void btncredito_Click_1(object sender, EventArgs e)
        {
            Formcredito credito = new Formcredito();
            credito.Show();
            this.Hide();
        }

        private void btndevolucionventas_Click_1(object sender, EventArgs e)
        {
            Formdevoluciones devoluciones = new Formdevoluciones();
            devoluciones.Show();
            this.Hide();
        }

        private void btndevolucioncompra_Click_1(object sender, EventArgs e)
        {
            Formdevolucionessobrecompra devolucionessobrecompras = new Formdevolucionessobrecompra();
            devolucionessobrecompras.Show();
            this.Hide();
        }

        private void btncaja_Click_1(object sender, EventArgs e)
        {
            Formcaja caja = new Formcaja();
            caja.Show();
            this.Hide();
        }

        private void btnnivelacioninventario_Click_1(object sender, EventArgs e)
        {
            Formnivelacioninventario nivelacioninventario = new Formnivelacioninventario();
            nivelacioninventario.Show();
            this.Hide();
        }

        private void btninventario_Click_1(object sender, EventArgs e)
        {
            forminventario inventario = new forminventario();
            inventario.Show();
            this.Hide();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 
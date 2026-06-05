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
    public partial class Menú_principal : Form
    {
        public Menú_principal()
        {
            InitializeComponent();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            Formcompras compras = new Formcompras();
            compras.Show();
            this.Hide();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            Formcliente cliente = new Formcliente();
            cliente.Show();
            this.Hide();

        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            Usuarios Usuario = new Usuarios();
            Usuario.Show();
            this.Hide();
        }

        private void btnventas_Click(object sender, EventArgs e)
        {

            Formventas ventas = new Formventas();
            ventas.Show();
            this.Hide();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            Formproductos productos = new Formproductos();
            productos.Show();
            this.Hide();
        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            Formproveedores proveedores = new Formproveedores();
            proveedores.Show();
            this.Hide();
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            Formcredito credito = new Formcredito();
            credito.Show();
            this.Hide();
        }

        private void btndevventa_Click(object sender, EventArgs e)
        {
            Formdevoluciones devoluciones = new Formdevoluciones();
            devoluciones.Show();
            this.Hide();
        }

        private void btndevcompra_Click(object sender, EventArgs e)
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


        private void AbrirForm(object formHijo)
        {
            // Revisar que quiren hacer
            for (int i = panel13.Controls.Count; i > 0; i--)
            {

                this.panel13.Controls.RemoveAt(0);
            }
            Form form = formHijo as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panel13.Controls.Add(form);
            this.panel13.Tag = form;
            form.Show();
        }
        private void Menú_principal_Load(object sender, EventArgs e)
        {

        }
    }
}

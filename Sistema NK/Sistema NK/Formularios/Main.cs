using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_NK.Formularios
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void lbl_Cerrar_sesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void AbrirFormularioEnPanel(Form formulario)
        {
            Panel_Hijo.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            Panel_Hijo.Controls.Add(formulario);
            Panel_Hijo.Tag = formulario;

            formulario.Show();
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Formventas());
        }

        private void btn_Mantenimiento_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormMantenimiento());
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Frm_Reportes());
        }

        private void btn_Usuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Usuarios());
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Formcliente());
        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Formproveedores());
        }

        private void btn_Compras_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Formcompras());
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Formproductos());
        }

        private void btn_Caja_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Formcaja());
        }

        private void btn_Devolucion_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Formdevoluciones());
        }

        private void btn_Credito_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Formcredito());
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new forminventario());
        }

        private void btn_Nivelacion_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Formnivelacioninventario());
        }
    }
}

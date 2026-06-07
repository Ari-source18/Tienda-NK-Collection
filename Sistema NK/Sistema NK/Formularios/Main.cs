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
    }
}

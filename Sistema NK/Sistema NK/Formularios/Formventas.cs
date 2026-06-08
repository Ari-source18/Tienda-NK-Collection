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



        private void rdb_Tarjeta_CheckedChanged(object sender, EventArgs e)
        {
            txt_efectivo_cordobas.Visible = false;
            txt_efectivo_dolares.Visible = false;
            txt_interes.Visible = false;
            txtnumerodereferencia.Visible = true;
            txtcantidadT.Visible = true;
            date_credito.Visible = false;
            lbl_numero_referencia.Visible = true;
            lbl_cantidad.Visible = true;
            lbl_interes.Visible = false;
            lbl_efectivo_cordobas.Visible = false;
            lbl_efectivo_dolares.Visible = false;
        }

        private void rdb_Credito_CheckedChanged(object sender, EventArgs e)
        {
            txt_efectivo_cordobas.Visible = false;
            txt_efectivo_dolares.Visible = false;
            txt_interes.Visible = true;
            txtnumerodereferencia.Visible = false;
            txtcantidadT.Visible = false;
            date_credito.Visible = true;
            lbl_numero_referencia.Visible = false;
            lbl_cantidad.Visible = false;
            lbl_interes.Visible = true;
            lbl_efectivo_cordobas.Visible = false;
            lbl_efectivo_dolares.Visible = false;
        }

        private void rdb_Efectivo_CheckedChanged(object sender, EventArgs e)
        {
            txt_efectivo_cordobas.Visible = true;
            txt_efectivo_dolares.Visible = true;
            txt_interes.Visible = false;
            txtnumerodereferencia.Visible = false;
            txtcantidadT.Visible = false;
            date_credito.Visible = false;
            lbl_numero_referencia.Visible = false;
            lbl_cantidad.Visible = false;
            lbl_interes.Visible = false;
            lbl_efectivo_cordobas.Visible = true;
            lbl_efectivo_dolares.Visible = true;
        }

        private void date_credito_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Formventas_Load(object sender, EventArgs e)
        {
            txt_efectivo_cordobas.Visible = false;
            txt_efectivo_dolares.Visible = false;
            txt_interes.Visible = false;
            txtnumerodereferencia.Visible = false;
            txtcantidadT.Visible = false;
            date_credito.Visible = false;
            lbl_numero_referencia.Visible = false;
            lbl_cantidad.Visible = false;
            lbl_interes.Visible = false;
            lbl_efectivo_cordobas.Visible = false;
            lbl_efectivo_dolares.Visible = false;
        }
    }
}
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_NK
{
    public partial class Formventas : Form
    {
        double precio = 0;
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

            lblFecha.Text = DateTime.Today.Date.ToString("d");
            lbl_usuario.Text = "Ariana ";
        }

        private void cmb_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto = cmb_producto.Text;

            if (producto.Equals("Camisa Polo")) txt_codigo.Text = "CAM-001"; txt_categoria.Text = "Camisetas"; precio = 500;
            if (producto.Equals("Pantalón Jeans")) txt_codigo.Text = "PAN-001"; txt_categoria.Text = "Pantalones"; precio = 800;
            if (producto.Equals("Zapatos Deportivos")) txt_codigo.Text = "ZAP-001"; txt_categoria.Text = "Zapatos"; precio = 1200;
            if (producto.Equals("Vestido Casual")) txt_codigo.Text = "VES-001"; txt_categoria.Text = "Vestidos"; precio = 700;
            if (producto.Equals("Chaqueta de Cuero")) txt_codigo.Text = "ABR-001"; txt_categoria.Text = "Abrigos"; precio = 1500;
            if (producto.Equals("Blusa Elegante")) txt_codigo.Text = "BLU-001"; txt_categoria.Text = "Blusas"; precio = 600;
            if (producto.Equals("Falda Plisada")) txt_codigo.Text = "FAL-001"; txt_categoria.Text = "Faldas"; precio = 400;
            if (producto.Equals("Suéter de Lana")) txt_codigo.Text = "ABR-001"; txt_categoria.Text = "Abrigos"; precio = 900;
            if (producto.Equals("Traje de Baño")) txt_codigo.Text = "ROV-002"; txt_categoria.Text = "Ropa Verano"; precio = 300;
            if (producto.Equals("Accesorios de Moda")) txt_codigo.Text = "ACC-001"; txt_categoria.Text = "Accesorios"; precio = 250;

            txt_precio.Text = precio.ToString("");
            {

            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un producto
            if (cmb_producto.SelectedIndex == -1)
                MessageBox.Show("Por favor, seleccione un producto.");
            else if (txt_cantidad_producto.Text == "")
                MessageBox.Show("Por favor, ingrese la cantidad.");

            else
            {
                dtgw_ventas.Rows.Add(cmb_producto.Text, txt_cantidad_producto, txt_precio);
            }
        }

        private void cmb_nombre_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cliente = cmb_nombre_cliente.Text;

            if (cliente.Equals("Ariana Gaitán")) txt_cedula.Text = "441-170108-1002J"; txt_telefono.Text = "+505 83687142"; txt_direccion.Text = "Costado Sur, Iglesia San Antonio";
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_NK
{
    public class Compra
    {
        private string Id_compra;
        private string Id_proveedor;
        private string Id_usuario;
        private string Numero_factura;
        private string Fecha_compra;
        private string Subtotal;
        private string Iva;
        private string Total_compra;
        private string Estado_compra;

        internal Producto Producto
        {
            get => default;
            set
            {
            }
        }

        public Usuario Usuario
        {
            get => default;
            set
            {
            }
        }
    }
}

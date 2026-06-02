using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_NK
{
    internal class Venta
    {
        public string Id_venta;
        public string Id_cliente;
        public string Id_usuario;
        public string Fecha_venta;
        public string Numero_comprobante;
        public string Iva;
        public string Total_venta;
        public string Metodo_pago;
        public string Descuento;

        internal Cliente Cliente
        {
            get => default;
            set
            {
            }
        }

        internal Crédito Crédito
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

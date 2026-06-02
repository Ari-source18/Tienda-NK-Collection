using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_NK
{
    public class Caja
    {
        private string Id_movimiento;
        private string Id_venta;
        private string Id_compra;
        private string Id_detalle_pago_credito;
        private string Tipo_movimiento;
        private string Monto;
        private string Ingresos;
        private string Egresos;
        private string Descripcion;
        private string Fecha;

        public Compra Compra
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

        internal Venta Venta
        {
            get => default;
            set
            {
            }
        }
    }
}

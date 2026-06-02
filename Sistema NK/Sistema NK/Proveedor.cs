using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_NK
{
    internal class Proveedor
    {
        private string Id_proveedor;
        private string Nombre;
        private string Telefono;
        private string Correo;
        private string Direccion;
        private string Ruc;
        private string Estado;
        private string Fecha_registro;

        public Compra Compra
        {
            get => default;
            set
            {
            }
        }
    }
}

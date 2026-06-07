using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_NK.Clases
{
    public class Usuario
    {
        private string Id_usuario;
        private string Id_rol;
        private string Nombre;
        private string Apellido;
        private string Contrasena;
        private string Correo;
        private string Estado;

        internal Cliente Cliente
        {
            get => default;
            set
            {
            }
        }
    }
}

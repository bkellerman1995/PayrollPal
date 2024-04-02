using PayrollPal.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPal.Layers.Entities
{
    public class Usuario
    {
        public string IDUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenna { get; set; }

        public override string ToString()
        {
            return IDUsuario + " - " + NombreUsuario;
        }
    }
}

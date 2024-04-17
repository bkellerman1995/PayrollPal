using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollPal.Enumeraciones;

namespace PayrollPal.Layers.Entities
{
    public class Empresa
    {
        public string IDEmpresa { set; get; }
        public TipoCedulaEmpresa TipoIdentificacion { set; get; }
        public string Nombre { set; get; }
        public string Telefono { set; get; }
        public string Direccion { set; get; }
        public byte[] Logo { set; get; }
        public bool Estado { set; get; }

    }
}

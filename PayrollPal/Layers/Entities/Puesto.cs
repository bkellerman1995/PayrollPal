using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPal.Layers.Entities
{
    public class Puesto
    {
        public string CodigoPuesto { set; get; }
        public string Nombre { set; get; }
        public bool Estado { set; get; }
        public override string ToString()
        {
            return CodigoPuesto + " - " + Nombre;
        }
    }

}

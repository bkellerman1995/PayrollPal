using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPal.Layers.Entities
{
    public class Bitacora
    {
        public int Id { set; get; }
        public DateTime Fecha { set; get; }
        public string Hilo { set; get; }
        public string Nivel { set; get; }
        public string Logger { set; get; }
        public string Mensaje { set; get; }
        public string Excepcion { set; get; }

    }
}

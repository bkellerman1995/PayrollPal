using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPal.Layers.Entities
{
    public class Supervisor
    {
        public string IDSupervisor { set; get; }
        public Rol IDRol { set; get; }
        public string Descripcion { set; get; }


        public Supervisor()
        {
            IDSupervisor = "0";
            IDRol = null;
            Descripcion = Enumeraciones.Rol.Supervisor.ToString();

        }

        public override string ToString()
        {
            return IDSupervisor + " - " + Descripcion;
        }
    }

}

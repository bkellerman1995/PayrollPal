using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPal.Layers.Entities
{
    public class Colaborador
    {
        public string IDColaborador { get; set; }  
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Departamento IDDepartamento { get; set; }
        public decimal SalarioHora { get; set; }
        public byte[] Foto { get; set; }
        public string CorreoElectronico { get; set; }
        public Puesto CodigoPuesto { get; set; }        
        public Rol IDRol { get; set; }
        public string CuentaIBAN { get; set; }        
        public Usuario IDUsuario { get; set; }        
        public Supervisor IDSupervisor { get; set; }
        public bool Estado { get; set; }
        
        public string supID { get; set; }

        public override string ToString()
        {
            return IDColaborador + " - " + Nombre;
        }
    }
}

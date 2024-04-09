using PayrollPal.Layers.BLL;
using PayrollPal.Layers.Entities;
using PayrollPal.Layers.IBLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPal.Entities
{
    public class ControlDeMarcas
    {
        public int idMarca { get; set; }
        public string IdColaborador { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSalida { get; set; }
        public string Fecha { get; set; }
        public double HorasTrabajadas { get; set; }

        /// <summary>
        /// Método para obtener las marcas desde el
        /// JSON y enviarlas a la base de datos
        /// </summary>
        /// <param name="ruta"></param>
        public void ObtenerMarcasJSON (string ruta)
        {
            List<ControlDeMarcas> listaMarcas = new List<ControlDeMarcas>();

            string jsonDatos = "";
            jsonDatos = File.ReadAllText(ruta);

            using (StreamReader lector = new StreamReader(ruta))
            {
                listaMarcas = JSONGenericObject<List<ControlDeMarcas>>.JSonToObject(jsonDatos);

                foreach (var item in listaMarcas)
                {
                    ControlDeMarcas controlMarca = new ControlDeMarcas();
                    controlMarca.idMarca = item.idMarca;
                    controlMarca.IdColaborador = item.IdColaborador;
                    controlMarca.HoraEntrada = item.HoraEntrada;
                    controlMarca.HoraSalida = item.HoraSalida;
                    controlMarca.Fecha = item.Fecha;

                    double horasTrabajadas = Math.Abs(Math.Round(item.HorasTrabajadas, 1));

                    controlMarca.HorasTrabajadas = horasTrabajadas;

                    IBLLControlDeMarcas bLLControlDeMarcas = new BLLControlDeMarcas();
                    bLLControlDeMarcas.CREATE(controlMarca);
                }
                lector.Close();
            }

        }

        public override string ToString()
        {
            return idMarca + " - " + IdColaborador;
        }
    }
}

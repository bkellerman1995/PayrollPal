using PayrollPal.Layers.Entities;
using PayrollPal.Layers.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Reflection;

namespace PayrollPal.Layers.DAL
{

    public class DALBitacora : IDALBitacora
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                         log4net.LogManager.GetLogger("MyControlEventos");
        public List<Bitacora> selectALL()
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Bitacora_Log4Net_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Bitacora_Log4NET");
                }

                List<Bitacora> lista = new List<Bitacora>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        Bitacora bitacora = new Bitacora();
                        bitacora.Id = int.Parse(dr["Id"].ToString());
                        bitacora.Fecha = DateTime.Parse(dr["Fecha"].ToString());
                        bitacora.Hilo = dr["Hilo"].ToString();
                        bitacora.Nivel = dr["Nivel"].ToString();
                        bitacora.Logger = dr["Logger"].ToString();
                        bitacora.Mensaje = dr["Mensaje"].ToString();

                        lista.Add(bitacora);
                    }
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se cargó la lista de usuarios");

                return lista;
            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en el log
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");
                return null;
            }
        }
    }
}

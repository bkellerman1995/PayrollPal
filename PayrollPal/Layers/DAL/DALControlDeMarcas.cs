using PayrollPal.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollPal.Layers.Entities;
using System.Reflection;
using log4net;

namespace PayrollPal.Layers.DAL
{
    public class DALControlDeMarcas
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");
        #region CREATE  
        public static void CREATE (ControlDeMarcas control)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_ControlDeMarcas");
                    command.Parameters.AddWithValue("@idMarca", control.idMarca);
                    command.Parameters.AddWithValue("@IdColaborador", control.IdColaborador);
                    command.Parameters.AddWithValue("@HoraEntrada", control.HoraEntrada);
                    command.Parameters.AddWithValue("@HoraSalida", control.HoraSalida);
                    command.Parameters.AddWithValue("@Fecha", control.Fecha);
                    command.Parameters.AddWithValue("@HorasTrabajadas", control.HorasTrabajadas);

                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        #endregion

        #region UPDATE
        public static void UPDATE(ControlDeMarcas control)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_ControlDeMarcas");
                    command.Parameters.AddWithValue("@idMarca", control.idMarca);
                    command.Parameters.AddWithValue("@IdColaborador", control.IdColaborador);
                    command.Parameters.AddWithValue("@HoraEntrada", control.HoraEntrada);
                    command.Parameters.AddWithValue("@HoraSalida", control.HoraSalida);
                    command.Parameters.AddWithValue("@Fecha", control.Fecha);
                    command.Parameters.AddWithValue("@HorasTrabajadas", control.HorasTrabajadas);

                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se modificó el control de Marcas: " + control.ToString()
                    + "en la base de datos (Tabla Colaborador)");
            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");

            }
        }
        #endregion

        #region SELECT ALL
        public static List<ControlDeMarcas> SelectAll()
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_ControlDeMarcas_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "ControlDeMarcas");
                }

                List<ControlDeMarcas> lista = new List<ControlDeMarcas>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        ControlDeMarcas controlDeMarcas = new ControlDeMarcas();
                        controlDeMarcas.idMarca = int.Parse(dr["idMarca"].ToString());
                        controlDeMarcas.IdColaborador = dr["IdColaborador"].ToString();
                        controlDeMarcas.HoraEntrada = (dr["HoraEntrada"].ToString()).Trim();
                        controlDeMarcas.HoraSalida = (dr["HoraSalida"].ToString()).Trim();
                        controlDeMarcas.Fecha = (dr["Fecha"].ToString());
                        controlDeMarcas.HorasTrabajadas = double.Parse(dr["HorasTrabajadas"].ToString());

                        lista.Add(controlDeMarcas);
                    }
                }
                return lista;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return null;
            }
        }

        #endregion

        #region DELETE
        public static void DELETE()
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_DELETE_ControlDeMarcas");
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        #endregion

    }
}

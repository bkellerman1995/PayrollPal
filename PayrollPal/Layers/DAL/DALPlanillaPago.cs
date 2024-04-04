using PayrollPal.Layers.Entities;
using PayrollPal.Layers.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using PayrollPal.Enumeraciones;

namespace PayrollPal.Layers.DAL
{
    public class DALPlanillaPago
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public static List<PlanillaPago> SelectAll()
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_PlanillaPago_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "PlanillaPago");
                }

                List<PlanillaPago> lista = new List<PlanillaPago>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        PlanillaPago planillaPago = new PlanillaPago();
                        planillaPago.Codigo = dr["Codigo"].ToString();
                        planillaPago.Nombre = dr["Nombre"].ToString();
                        planillaPago.FechaDesde = DateTime.Parse(dr["FechaDesde"].ToString());
                        planillaPago.FechaHasta = DateTime.Parse(dr["FechaHasta"].ToString());
                        planillaPago.FechaPago = DateTime.Parse(dr["FechaPago"].ToString());
                        planillaPago.Estado = (PlanillaEstado)Enum.Parse(typeof (PlanillaEstado),(dr["Estado"].ToString()));


                        lista.Add(planillaPago);
                    }
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se cargó la lista de planillas de pago");

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
        #endregion

        #region SELECT BY ID
        public static PlanillaPago SelectById(string codigo)
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_PlanillaPago_ByID");
                    command.Parameters.AddWithValue("@Codigo", codigo);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "PlanillaPago");
                }

                //Se crea el dataTable
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    PlanillaPago oPlanillaPago = new PlanillaPago();
                    oPlanillaPago.Codigo = dt.Rows[0]["Codigo"].ToString();
                    oPlanillaPago.Nombre = dt.Rows[0]["Nombre"].ToString();
                    oPlanillaPago.FechaDesde = DateTime.Parse(dt.Rows[0]["FechaDesde"].ToString());
                    oPlanillaPago.FechaHasta = DateTime.Parse(dt.Rows[0]["FechaHasta"].ToString());
                    oPlanillaPago.FechaPago = DateTime.Parse(dt.Rows[0]["FechaPago"].ToString());
                    oPlanillaPago.Estado = (PlanillaEstado)Enum.Parse(typeof(PlanillaEstado), (dt.Rows[0]["Estado"].ToString()));
                    return oPlanillaPago;
                }
                return null;
            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");
                return null;
            }
        }
        #endregion

        #region CREATE
        public static void CREATE(PlanillaPago pPlanillaPago)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_PlanillaPago");
                    command.Parameters.AddWithValue("@Codigo", pPlanillaPago.Codigo);
                    command.Parameters.AddWithValue("@Nombre", pPlanillaPago.Nombre);
                    command.Parameters.AddWithValue("@FechaDesde", pPlanillaPago.FechaDesde);
                    command.Parameters.AddWithValue("@FechaHasta", pPlanillaPago.FechaHasta);
                    command.Parameters.AddWithValue("@FechaPago", pPlanillaPago.FechaPago);
                    command.Parameters.AddWithValue("@Estado", pPlanillaPago.Estado.ToString());
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);

                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se agregó la planilla de pago: " + pPlanillaPago.ToString()
                    + " a la base de datos (Tabla PlanillaPago)");
            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en el log
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");
            }
        }
        #endregion

        #region UPDATE

        public static void UPDATE(PlanillaPago pPlanillaPago)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_PlanillaPago");
                    command.Parameters.AddWithValue("@Codigo", pPlanillaPago.Codigo);
                    command.Parameters.AddWithValue("@Nombre", pPlanillaPago.Nombre);
                    command.Parameters.AddWithValue("@FechaDesde", pPlanillaPago.FechaDesde);
                    command.Parameters.AddWithValue("@FechaHasta", pPlanillaPago.FechaHasta);
                    command.Parameters.AddWithValue("@FechaPago", pPlanillaPago.FechaPago);
                    command.Parameters.AddWithValue("@Estado", pPlanillaPago.Estado.ToString());
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se modificó la planilla de pago: " + pPlanillaPago.ToString()
                    + "en la base de datos (Tabla PlanillaPago)");
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

        #region DELETE
        public static void DELETE(string pCodigoPlanilla)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_DELETE_PlanillaPago_ByID");
                    command.Parameters.AddWithValue("@Codigo", pCodigoPlanilla);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se eliminó la planilla de pago con el código: " + pCodigoPlanilla
                    + " en la base de datos (Tabla PlanillaPago)");
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
    }
}

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
using PayrollPal.Enumeraciones;
using log4net;
using PayrollPal.Layers.IBLL;
using PayrollPal.Layers.BLL;


namespace PayrollPal.Layers.DAL
{
    public class DALSolicitudVacaciones : IDALSolicitudVacaciones
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                          log4net.LogManager.GetLogger("MyControlEventos");

        #region SecuenciadorSolicitudVacaciones

        public string SecuenciadorSolicitudVacaciones()
        {
            try
            {
                String secuencia = "";
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_Secuenciador_SecuenciadorSolicitudVacaciones");
                    command.CommandType = CommandType.StoredProcedure;
                    secuencia = db.ExecuteScalar(command).ToString();

                }
                return secuencia;
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

        #region SELECT ALL
        public List<SolicitudVacaciones> SelectAll()
        {
            try
            {
                IBLLColaborador _BLLColaborador = new BLLColaborador();
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_SolicitudVacaciones_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "SolicitudVacaciones");
                }

                List<SolicitudVacaciones> lista = new List<SolicitudVacaciones>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        SolicitudVacaciones solicitud = new SolicitudVacaciones();
                        solicitud.IDSolicitudVacas = dr["IDSolicitudVacas"].ToString();
                        solicitud.IDColaborador = _BLLColaborador.SelectById(dr["IDColaborador"].ToString());
                        solicitud.FechaSolicitud = DateTime.Parse(dr["FechaSolicitud"].ToString());
                        solicitud.FechaSolicitarDesde = DateTime.Parse(dr["FechaSolicitarDesde"].ToString());
                        solicitud.FechaSolicitarHasta = DateTime.Parse(dr["FechaSolicitarHasta"].ToString());
                        solicitud.CantidadDias = int.Parse(dr["CantidadDias"].ToString());
                        solicitud.Observaciones = dr["Observaciones"].ToString();
                        solicitud.Estado = bool.Parse(dr["Estado"].ToString());
                        solicitud.Observaciones_Final = (ObservacionSolicVacaciones)Enum.Parse(typeof(ObservacionSolicVacaciones), (dr["Observaciones_Final"].ToString()));

                        lista.Add(solicitud);
                    }
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se cargó la lista de solicitudes de vacaciones");

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
        public SolicitudVacaciones SelectById(string Id)
        {
            try
            {
                IBLLColaborador _BLLColaborador = new BLLColaborador();
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_SolicitudVacaciones_ByID");
                    command.Parameters.AddWithValue("@IDSolicitudVacas", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "SolicitudVacaciones");
                }

                //Se crea el dataTable
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    SolicitudVacaciones oSolicitud= new SolicitudVacaciones();

                    oSolicitud.IDSolicitudVacas = dt.Rows[0]["IDSolicitudVacas"].ToString();
                    oSolicitud.IDColaborador = _BLLColaborador.SelectById(dt.Rows[0]["IDColaborador"].ToString());
                    oSolicitud.FechaSolicitud = DateTime.Parse(dt.Rows[0]["FechaSolicitud"].ToString());
                    oSolicitud.FechaSolicitarDesde = DateTime.Parse(dt.Rows[0]["FechaSolicitarDesde"].ToString());
                    oSolicitud.FechaSolicitarHasta = DateTime.Parse(dt.Rows[0]["FechaSolicitarHasta"].ToString());
                    oSolicitud.CantidadDias = int.Parse(dt.Rows[0]["CantidadDias"].ToString());
                    oSolicitud.Observaciones = dt.Rows[0]["Observaciones"].ToString();
                    oSolicitud.Estado = bool.Parse(dt.Rows[0]["Estado"].ToString());
                    oSolicitud.Observaciones_Final = (ObservacionSolicVacaciones)Enum.Parse(typeof(ObservacionSolicVacaciones), (dt.Rows[0]["Observaciones_Final"].ToString()));

                    return oSolicitud;
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
        public void CREATE(SolicitudVacaciones pSolicitud)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_SolicitudVacaciones");
                    command.Parameters.AddWithValue("@IDSolicitudVacas", pSolicitud.IDSolicitudVacas);
                    command.Parameters.AddWithValue("@IDColaborador", pSolicitud.IDColaborador.IDColaborador);
                    command.Parameters.AddWithValue("@FechaSolicitud",pSolicitud.FechaSolicitud);
                    command.Parameters.AddWithValue("@FechaSolicitarDesde", pSolicitud.FechaSolicitarDesde);
                    command.Parameters.AddWithValue("@FechaSolicitarHasta", pSolicitud.FechaSolicitarHasta);
                    command.Parameters.AddWithValue("@CantidadDias", pSolicitud.CantidadDias);
                    command.Parameters.AddWithValue("@Observaciones", pSolicitud.Observaciones);
                    command.Parameters.AddWithValue("@Estado", pSolicitud.Estado);
                    command.Parameters.AddWithValue("@Observaciones_Final", pSolicitud.Observaciones_Final);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);

                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se agregó la solicitud de vacaciones: " + pSolicitud.ToString()
                    + " a la base de datos (Tabla SolicitudVacaciones)");
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

        public void UPDATE(SolicitudVacaciones pSolicitud)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_SolicitudVacaciones");
                    command.Parameters.AddWithValue("@IDSolicitudVacas", pSolicitud.IDSolicitudVacas);
                    command.Parameters.AddWithValue("@IDColaborador", pSolicitud.IDColaborador.IDColaborador);
                    command.Parameters.AddWithValue("@FechaSolicitud", pSolicitud.FechaSolicitud);
                    command.Parameters.AddWithValue("@FechaSolicitarDesde", pSolicitud.FechaSolicitarDesde);
                    command.Parameters.AddWithValue("@FechaSolicitarHasta", pSolicitud.FechaSolicitarHasta);
                    command.Parameters.AddWithValue("@CantidadDias", pSolicitud.CantidadDias);
                    command.Parameters.AddWithValue("@Observaciones", pSolicitud.Observaciones);
                    command.Parameters.AddWithValue("@Estado", pSolicitud.Estado);
                    command.Parameters.AddWithValue("@Observaciones_Final", pSolicitud.Observaciones_Final);


                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se modificó la solicitud de vacaciones: " + pSolicitud.ToString()
                    + "en la base de datos (Tabla SolicitudVacaciones)");
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
        public void DELETE(string pSolicitud)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_DELETE_SolicitudVacaciones_ByID");
                    command.Parameters.AddWithValue("@IDSolicitudVacas", pSolicitud);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se eliminó la solicitud de vacaciones con el ID: " + pSolicitud
                    + " en la base de datos (Tabla SolicitudVacaciones)");
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
        #endregion }

    }
}

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

namespace PayrollPal.Layers.DAL
{
    public class IDALPlanilla_Detalle
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SecuenciadorPlanEncabezado

        public static string SecuenciadorPlanDetalle()
        {
            try
            {
                String secuencia = "";
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_Secuenciador_SecuenciadorPlanillaDetalle");
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
        public static List<Planilla_Detalle> SelectAll()
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Planilla_Detalle_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Planilla_Detalle");
                }

                List<Planilla_Detalle> lista = new List<Planilla_Detalle>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        Planilla_Detalle planillaDetalle = new Planilla_Detalle();
                        planillaDetalle.IdDetalle = dr["IdDetalle"].ToString();
                        planillaDetalle.IdEncabezado = BLL.BLLPlanilla_Encabezado.SelectById(dr["IdEncabezado"].ToString());
                        planillaDetalle.IdColaborador = BLL.BLLColaborador.SelectById(dr["IdColaborador"].ToString());
                        planillaDetalle.NombreColaborador = dr["NombreColaborador"].ToString();
                        planillaDetalle.hrsTrabajadas = double.Parse(dr["hrsTrabajadas"].ToString());
                        planillaDetalle.hrsExtras = double.Parse(dr["hrsExtras"].ToString());
                        planillaDetalle.MontoHora = (decimal)(dr["MontoHora"]);
                        planillaDetalle.SalarioBruto = (decimal)(dr["SalarioBruto"]);
                        planillaDetalle.SalarioNeto = (decimal)(dr["SalarioNeto"]);


                        lista.Add(planillaDetalle);
                    }
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se cargó la lista de detalles de planilla");

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
        public static Planilla_Detalle SelectById(string Id)
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Planilla_Detalle_ByID");
                    command.Parameters.AddWithValue("@IdDetalle", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Planilla_Detalle");
                }

                //Se crea el dataTable
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[0];

                    Planilla_Detalle planillaDetalle = new Planilla_Detalle();
                    planillaDetalle.IdDetalle = dt.Rows[0]["IdDetalle"].ToString();
                    planillaDetalle.IdEncabezado = BLL.BLLPlanilla_Encabezado.SelectById(dt.Rows[0]["IdEncabezado"].ToString());
                    planillaDetalle.IdColaborador = BLL.BLLColaborador.SelectById(dt.Rows[0]["IdColaborador"].ToString());
                    planillaDetalle.NombreColaborador = dt.Rows[0]["NombreColaborador"].ToString();
                    planillaDetalle.hrsTrabajadas = double.Parse(dt.Rows[0]["hrsTrabajadas"].ToString());
                    planillaDetalle.hrsExtras = double.Parse(dt.Rows[0]["hrsExtras"].ToString());
                    planillaDetalle.MontoHora = (decimal)(dt.Rows[0]["MontoHora"]);
                    planillaDetalle.SalarioBruto = (decimal)(dt.Rows[0]["SalarioBruto"]);
                    planillaDetalle.SalarioNeto = (decimal)(dt.Rows[0]["SalarioNeto"]);
                    return planillaDetalle;
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
        public static void CREATE(Planilla_Detalle pPlanilla_Detalle)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Planilla_Detalle");
                    command.Parameters.AddWithValue("@IdDetalle", pPlanilla_Detalle.IdDetalle);
                    command.Parameters.AddWithValue("@IdEncabezado", pPlanilla_Detalle.IdEncabezado.IdEncabezado);
                    command.Parameters.AddWithValue("@IdColaborador", pPlanilla_Detalle.IdColaborador.IDColaborador);
                    command.Parameters.AddWithValue("@NombreColaborador", pPlanilla_Detalle.NombreColaborador);
                    command.Parameters.AddWithValue("@hrsTrabajadas", pPlanilla_Detalle.hrsTrabajadas);
                    command.Parameters.AddWithValue("@hrsExtras", pPlanilla_Detalle.hrsExtras);
                    command.Parameters.AddWithValue("@MontoHora", pPlanilla_Detalle.MontoHora);
                    command.Parameters.AddWithValue("@SalarioBruto", pPlanilla_Detalle.SalarioBruto);
                    command.Parameters.AddWithValue("@SalarioNeto", pPlanilla_Detalle.SalarioNeto);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);

                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se agregó el detalle de planilla: " + pPlanilla_Detalle.ToString()
                    + " a la base de datos (Tabla Planilla_Detalle)");
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

        public static void UPDATE(Planilla_Detalle pPlanilla_Detalle)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Planilla_Detalle");
                    command.Parameters.AddWithValue("@IdDetalle", pPlanilla_Detalle.IdDetalle);
                    command.Parameters.AddWithValue("@IdEncabezado", pPlanilla_Detalle.IdEncabezado);
                    command.Parameters.AddWithValue("@IdColaborador", pPlanilla_Detalle.IdColaborador);
                    command.Parameters.AddWithValue("@NombreColaborador", pPlanilla_Detalle.NombreColaborador);
                    command.Parameters.AddWithValue("@hrsTrabajadas", pPlanilla_Detalle.hrsTrabajadas);
                    command.Parameters.AddWithValue("@hrsExtras", pPlanilla_Detalle.hrsExtras);
                    command.Parameters.AddWithValue("@MontoHora", pPlanilla_Detalle.MontoHora);
                    command.Parameters.AddWithValue("@SalarioBruto", pPlanilla_Detalle.SalarioBruto);
                    command.Parameters.AddWithValue("@SalarioNeto", pPlanilla_Detalle.SalarioNeto);


                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se modificó el detalle de planilla: " + pPlanilla_Detalle.ToString()
                    + "en la base de datos (Tabla Planilla_Detalle)");
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
        public static void DELETE(string pPlanillaDetalle)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_DELETE_Planilla_Detalle_ByID");
                    command.Parameters.AddWithValue("@IdDetalle", pPlanillaDetalle);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se eliminó el detalle de planilla con el ID: " + pPlanillaDetalle
                    + " en la base de datos (Tabla Usuario)");
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

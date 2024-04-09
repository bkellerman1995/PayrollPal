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
using PayrollPal.Layers.Entities;
using PayrollPal.Layers.Util;

namespace PayrollPal.Layers.DAL
{
    public class IDALPlanilla_Encabezado
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SecuenciadorPlanEncabezado

        public static string SecuenciadorPlanEnc()
        {
            try
            {
                String secuencia = "";
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_Secuenciador_SecuenciadorPlanillaEncabezado");
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
        public static List<Planilla_Encabezado> SelectAll()
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Planilla_Encabezado_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Planilla_Encabezado");
                }

                List<Planilla_Encabezado> lista = new List<Planilla_Encabezado>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        Planilla_Encabezado planillaEnc = new Planilla_Encabezado();
                        planillaEnc.IdEncabezado = dr["IdEncabezado"].ToString();
                        planillaEnc.Codigo = BLL.BLLPlanillaPago.SelectById(dr["Codigo"].ToString());
                        planillaEnc.TipoCambio = double.Parse(dr["TipoCambio"].ToString());
                        planillaEnc.TotalIngresos = double.Parse(dr["TotalIngresos"].ToString());
                        planillaEnc.TotalGastos = double.Parse(dr["TotalGastos"].ToString());
                        planillaEnc.TotalPagar = double.Parse(dr["TotalPagar"].ToString());

                        lista.Add(planillaEnc);
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
        #endregion

        #region SELECT BY ID
        public static Planilla_Encabezado SelectById(string Id)
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Planilla_Encabezado_ByID");
                    command.Parameters.AddWithValue("@IdEncabezado", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Planilla_Encabezado");
                }

                //Se crea el dataTable
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    Planilla_Encabezado planillaEnc = new Planilla_Encabezado();
                    planillaEnc.IdEncabezado = dt.Rows[0]["IdEncabezado"].ToString();
                    planillaEnc.Codigo = BLL.BLLPlanillaPago.SelectById(dt.Rows[0]["Codigo"].ToString());
                    planillaEnc.TipoCambio = double.Parse(dt.Rows[0]["TipoCambio"].ToString());
                    planillaEnc.TotalIngresos = double.Parse(dt.Rows[0]["TotalIngresos"].ToString());
                    planillaEnc.TotalGastos = double.Parse(dt.Rows[0]["TotalGastos"].ToString());
                    planillaEnc.TotalPagar = double.Parse(dt.Rows[0]["TotalPagar"].ToString());
                    return planillaEnc;
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
        public static void CREATE(Planilla_Encabezado pPlanillaEncabezado)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Planilla_Encabezado");
                    command.Parameters.AddWithValue("@IdEncabezado", pPlanillaEncabezado.IdEncabezado);
                    command.Parameters.AddWithValue("@Codigo", pPlanillaEncabezado.Codigo.Codigo);
                    command.Parameters.AddWithValue("@TipoCambio",pPlanillaEncabezado.TipoCambio);
                    command.Parameters.AddWithValue("@TotalIngresos", pPlanillaEncabezado.TotalIngresos);
                    command.Parameters.AddWithValue("@TotalGastos", pPlanillaEncabezado.TotalGastos);
                    command.Parameters.AddWithValue("@TotalPagar", pPlanillaEncabezado.TotalPagar);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);

                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se agregó el encabezado de Planilla de pago: " + pPlanillaEncabezado.ToString()
                    + " a la base de datos (Tabla Planilla_Encabezado)");
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

        public static void UPDATE(Planilla_Encabezado pPlanillaEncabezado)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Usuario");
                    command.Parameters.AddWithValue("@IdEncabezado", pPlanillaEncabezado.IdEncabezado);
                    command.Parameters.AddWithValue("@NombreCodigoUsuario", pPlanillaEncabezado.Codigo);
                    command.Parameters.AddWithValue("@TipoCambio", pPlanillaEncabezado.TipoCambio);
                    command.Parameters.AddWithValue("@TotalIngresos", pPlanillaEncabezado.TotalIngresos);
                    command.Parameters.AddWithValue("@TotalGastos", pPlanillaEncabezado.TotalGastos);
                    command.Parameters.AddWithValue("@TotalPagar", pPlanillaEncabezado.TotalPagar);


                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se modificó el encabezado de Planilla de pago: " + pPlanillaEncabezado.ToString()
                    + "en la base de datos (Tabla Planilla_Encabezado)");
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
        public static void DELETE(string pIDPlanillaEnc)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_DELETE_Planilla_Encabezado_ByID");
                    command.Parameters.AddWithValue("@IdEncabezado", pIDPlanillaEnc);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se eliminó el encabezado de Planilla de pago: " + pIDPlanillaEnc
                    + " en la base de datos (Tabla Planilla_Encabezado)");
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

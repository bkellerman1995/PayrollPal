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
    public class IDALDeduccionesPercepciones
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SecuenciadorDeduccionesPercepciones

        public static string SecuenciadorDeduccionesPercepciones()
        {
            try
            {
                String secuencia = "";
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_Secuenciador_SecuenciadorDeduccionesPercepciones");
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
        public static List<Deducciones_Percepciones> SelectAll()
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Deducciones_Percepciones_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Deducciones_Percepciones");
                }

                List<Deducciones_Percepciones> lista = new List<Deducciones_Percepciones>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        Deducciones_Percepciones dedPerc = new Deducciones_Percepciones();
                        dedPerc.CodigoDeduccionPercepcion = dr["CodigoDeduccionPercepcion"].ToString();
                        dedPerc.Nombre = dr["Nombre"].ToString();
                        dedPerc.Tipo = (TipoPercepcionDeduccion)Enum.Parse(typeof (TipoPercepcionDeduccion), (dr["Tipo"].ToString()));
                        dedPerc.Valor = double.Parse(dr["Valor"].ToString());
                        dedPerc.TipoValor = (TipoPorcAbs)Enum.Parse(typeof(TipoPorcAbs), (dr["TipoValor"].ToString()));

                        lista.Add(dedPerc);
                    }
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se cargó la lista de deducciones y percepciones");

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
        public static Deducciones_Percepciones SelectById(string codigo)
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Deducciones_Percepciones_ByID");
                    command.Parameters.AddWithValue("@CodigoDeduccionPercepcion", codigo);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Deducciones_Percepciones");
                }

                //Se crea el dataTable
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    Deducciones_Percepciones oDeduccionesPercepciones = new Deducciones_Percepciones();
                    oDeduccionesPercepciones.CodigoDeduccionPercepcion = dt.Rows[0]["CodigoDeduccionPercepcion"].ToString();
                    oDeduccionesPercepciones.Nombre = dt.Rows[0]["Nombre"].ToString();
                    oDeduccionesPercepciones.Tipo = (TipoPercepcionDeduccion)Enum.Parse(typeof(PlanillaEstado), (dt.Rows[0]["Tipo"].ToString()));
                    oDeduccionesPercepciones.Valor = double.Parse(dt.Rows[0]["Valor"].ToString());
                    oDeduccionesPercepciones.TipoValor = (TipoPorcAbs)Enum.Parse(typeof(TipoPorcAbs), (dt.Rows[0]["TipoValor"].ToString()));
                    return oDeduccionesPercepciones;
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
        public static void CREATE(Deducciones_Percepciones pDeduccionesPercepciones)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Deducciones_Percepciones");
                    command.Parameters.AddWithValue("@CodigoDeduccionPercepcion", pDeduccionesPercepciones.CodigoDeduccionPercepcion);
                    command.Parameters.AddWithValue("@Nombre", pDeduccionesPercepciones.Nombre);
                    command.Parameters.AddWithValue("@Tipo", pDeduccionesPercepciones.Tipo);
                    command.Parameters.AddWithValue("@Valor", pDeduccionesPercepciones.Valor);
                    command.Parameters.AddWithValue("@TipoValor", pDeduccionesPercepciones.TipoValor);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);

                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se agregó la deducción/percepción: " + pDeduccionesPercepciones.ToString()
                    + " a la base de datos (Tabla Deducciones_Percepciones)");
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

        public static void UPDATE(Deducciones_Percepciones pDeduccionesPercepciones)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Deducciones_Percepciones");
                    command.Parameters.AddWithValue("@CodigoDeduccionPercepcion", pDeduccionesPercepciones.CodigoDeduccionPercepcion);
                    command.Parameters.AddWithValue("@Nombre", pDeduccionesPercepciones.Nombre);
                    command.Parameters.AddWithValue("@Tipo", pDeduccionesPercepciones.Tipo);
                    command.Parameters.AddWithValue("@Valor", pDeduccionesPercepciones.Valor);
                    command.Parameters.AddWithValue("@TipoValor", pDeduccionesPercepciones.TipoValor);


                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se modificó la deducción/percepción: " + pDeduccionesPercepciones.ToString()
                    + "en la base de datos (Tabla Deducciones_Percepciones)");
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
        public static void DELETE(string pCodigoDeduccionesPercepciones)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_DELETE_Deducciones_Percepciones_ByID");
                    command.Parameters.AddWithValue("@CodigoDeduccionPercepcion", pCodigoDeduccionesPercepciones);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se eliminó la deducción/percepción con el código: " + pCodigoDeduccionesPercepciones
                    + " en la base de datos (Tabla Deducciones_Percepciones)");
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

using PayrollPal.Layers.Entities;
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
using PayrollPal.Layers.BLL;
using PayrollPal.Layers.IBLL;


namespace PayrollPal.Layers.DAL
{
    public class DALDeducciones_Percepciones_Por_Colaborador : IDALDeducciones_Percepciones_Por_Colaborador
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                     log4net.LogManager.GetLogger("MyControlEventos");


        #region SELECT ALL
        public List<Deducciones_Percepciones_Por_Colaborador> SelectAll()
        {
            try
            {
                IBLLDeduccionesPercepciones _BLLDeduccionesPercepciones = new BLLDeduccionesPercepciones();

                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Deducciones_Percepciones_Por_Colaborador_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Deducciones_Percepciones_Por_Colaborador");
                }

                List<Deducciones_Percepciones_Por_Colaborador> lista = new List<Deducciones_Percepciones_Por_Colaborador>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        Deducciones_Percepciones_Por_Colaborador dedPercColab = new Deducciones_Percepciones_Por_Colaborador();
                        dedPercColab.CodigoDeduccionPercepcion = _BLLDeduccionesPercepciones.SelectById(dr["CodigoDeduccionPercepcion"].ToString());
                        dedPercColab.Prioridad = (PrioridadDeduccionPercepcion)Enum.Parse(typeof(PrioridadDeduccionPercepcion), (dr["Prioridad"].ToString()));
                        dedPercColab.Estado = bool.Parse(dr["Estado"].ToString());
                        lista.Add(dedPercColab);
                    }
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se cargó la lista de deducciones y percepcions por colaborador");

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


        #region SELECT TODO
        public List<Deducciones_Percepciones_Por_Colaborador> SelectTodo()
        {
            try
            {
                IBLLDeduccionesPercepciones _BLLDeduccionesPercepciones = new BLLDeduccionesPercepciones();
                IBLLColaborador _BLLColaborador = new BLLColaborador();

                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Deducciones_Percepciones_Por_Colaborador_TODOS");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Deducciones_Percepciones_Por_Colaborador");
                }

                List<Deducciones_Percepciones_Por_Colaborador> lista = new List<Deducciones_Percepciones_Por_Colaborador>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        Deducciones_Percepciones_Por_Colaborador dedPercColab = new Deducciones_Percepciones_Por_Colaborador();
                        dedPercColab.CodigoDeduccionPercepcion = _BLLDeduccionesPercepciones.SelectById(dr["CodigoDeduccionPercepcion"].ToString());
                        dedPercColab.IdColaborador = _BLLColaborador.SelectById(dr["IdColaborador"].ToString());
                        dedPercColab.Prioridad = (PrioridadDeduccionPercepcion)Enum.Parse(typeof(PrioridadDeduccionPercepcion), (dr["Prioridad"].ToString()));
                        dedPercColab.Estado = bool.Parse(dr["Estado"].ToString());
                        lista.Add(dedPercColab);
                    }
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se cargó la lista de deducciones y percepcions por colaborador");

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
        public Deducciones_Percepciones_Por_Colaborador SelectById(string CodigoDeduccionPercepcion, string idColaborador)
        {
            try
            {
                IBLLDeduccionesPercepciones _BLLDeduccionesPercepciones = new BLLDeduccionesPercepciones();
                IBLLColaborador _BLLColaborador = new BLLColaborador();

                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Deducciones_Percepciones_Por_Colaborador_ByCodigoDeduccionPercepcion");
                    command.Parameters.AddWithValue("@CodigoDeduccionPercepcion", CodigoDeduccionPercepcion);
                    command.Parameters.AddWithValue("@IdColaborador", idColaborador);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Deducciones_Percepciones_Por_Colaborador");
                }

                //Se crea el dataTable
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    Deducciones_Percepciones_Por_Colaborador dedPercColab = new Deducciones_Percepciones_Por_Colaborador();
                    dedPercColab.CodigoDeduccionPercepcion = _BLLDeduccionesPercepciones.SelectById(dt.Rows[0]["CodigoDeduccionPercepcion"].ToString());
                    dedPercColab.IdColaborador = _BLLColaborador.SelectById(dt.Rows[0]["IdColaborador"].ToString());
                    dedPercColab.Prioridad = (PrioridadDeduccionPercepcion)Enum.Parse(typeof(PrioridadDeduccionPercepcion), (dt.Rows[0]["Prioridad"].ToString()));
                    return dedPercColab;
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
        public void CREATE(Deducciones_Percepciones_Por_Colaborador pDedPercColab)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Deducciones_Percepciones_Por_Colaborador");
                    command.Parameters.AddWithValue("@CodigoDeduccionPercepcion", pDedPercColab.CodigoDeduccionPercepcion.CodigoDeduccionPercepcion);
                    command.Parameters.AddWithValue("@IdColaborador", pDedPercColab.IdColaborador.IDColaborador);
                    command.Parameters.AddWithValue("@Prioridad", pDedPercColab.Prioridad.ToString());
                    command.Parameters.AddWithValue("@Estado", pDedPercColab.Estado.ToString());
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);

                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se agregó la deducción/percepción " + pDedPercColab.ToString()
                    +" con prioridad: " + pDedPercColab.Prioridad.ToString()
                    + " a la base de datos (Tabla Deducciones_Percepciones_Por_Colaborador)");
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
        public void UPDATE(Deducciones_Percepciones_Por_Colaborador pDedPercColab)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Deducciones_Percepciones_Por_Colaborador");
                    command.Parameters.AddWithValue("@CodigoDeduccionPercepcion", pDedPercColab.CodigoDeduccionPercepcion.CodigoDeduccionPercepcion);
                    command.Parameters.AddWithValue("@IdColaborador", pDedPercColab.IdColaborador.IDColaborador);
                    command.Parameters.AddWithValue("@Prioridad", pDedPercColab.Prioridad.ToString());
                    command.Parameters.AddWithValue("@Estado", pDedPercColab.Estado.ToString());

                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se modificó la deducción/percepción " + pDedPercColab.ToString()
                     + " con prioridad: " + pDedPercColab.IdColaborador.ToString()
                     + " en la base de datos (Tabla Deducciones_Percepciones_Por_Colaborador)");
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
        public void DELETE(string pCodigoDeduccionPercepcion, string pIdColaborador)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_DELETE_Deducciones_Percepciones_Por_Colaborador_ByCodigoDeduccionPercepcion");
                    command.Parameters.AddWithValue("@CodigoDeduccionPercepcion", pCodigoDeduccionPercepcion);
                    command.Parameters.AddWithValue("@IDColaborador", pIdColaborador);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se eliminó la deducción/percepción: " + pCodigoDeduccionPercepcion +
                   " - " + pIdColaborador + " en la base de datos (Tabla Deducciones_Percepciones_Por_Colaborador)");
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

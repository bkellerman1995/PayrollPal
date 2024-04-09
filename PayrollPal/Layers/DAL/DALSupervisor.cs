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
using PayrollPal.Layers.IBLL;
using PayrollPal.Layers.BLL;


namespace PayrollPal.Layers.DAL
{
    public class DALSupervisor : IDALSupervisor
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public List<Supervisor> SelectAll()
        {
            try
            {
                IBLLRol _BLLRol = new BLLRol();
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Supervisor_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Supervisor");
                }

                List<Supervisor> lista = new List<Supervisor>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        Supervisor supervisor = new Supervisor();
                        supervisor.IDSupervisor = dr["IDSupervisor"].ToString();
                        supervisor.IDRol = _BLLRol.SelectById(int.Parse(dr["IDRol"].ToString()));
                        supervisor.Descripcion = dr["Descripcion"].ToString();

                        lista.Add(supervisor);
                    }
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se cargó la lista de supervisores");

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

        #region SecuenciadorSupervisor

        public string SecuenciadorPuestoAumentar()
        {
            try
            {
                String secuencia = "";
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_Secuenciador_Supervisor");
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

        #region SELECT BY ID
        public Supervisor SelectById(string Id)
        {
            try
            {
                IBLLRol _BLLRol = new BLLRol();
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Supervisor_ByID");
                    command.Parameters.AddWithValue("@IDSupervisor", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Supervisor");
                }

                //Se crea el dataTable
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    Supervisor oSupervisor = new Supervisor();
                    oSupervisor.IDSupervisor = dt.Rows[0]["IDSupervisor"].ToString();
                    oSupervisor.IDRol = _BLLRol.SelectById(int.Parse(dt.Rows[0]["IDRol"].ToString()));
                    oSupervisor.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                    return oSupervisor;
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
        public void CREATE(Supervisor pSupervisor)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Supervisor");
                    command.Parameters.AddWithValue("@IDSupervisor", pSupervisor.IDSupervisor);
                    command.Parameters.AddWithValue("@IDRol", pSupervisor.IDRol.IDRol);
                    command.Parameters.AddWithValue("@Descripcion", pSupervisor.Descripcion);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);

                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se agregó el supervisor: " + pSupervisor.ToString()
                    + " a la base de datos (Tabla Supervisor)");
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
        public void UPDATE(Supervisor pSupervisor)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Supervisor");
                    command.Parameters.AddWithValue("@IDSupervisor", pSupervisor.IDSupervisor);
                    command.Parameters.AddWithValue("@IDRol", pSupervisor.IDRol.IDRol);
                    command.Parameters.AddWithValue("@Descripcion", pSupervisor.Descripcion);

                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se modificó el supervisor: " + pSupervisor.ToString()
                    + "en la base de datos (Tabla Supervisor)");
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
        public void DELETE(string pIdSupervisor)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_DELETE_Supervisor_ByID");
                    command.Parameters.AddWithValue("@IDSupervisor", pIdSupervisor);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se eliminó el supervisor con el ID: " + pIdSupervisor
                    + " en la base de datos (Tabla Supervisor)");
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

using PayrollPal.Layers.Entities;
using PayrollPal.Layers.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Reflection;
using System.Windows.Forms;

namespace PayrollPal.Layers.DAL
{
    public class DALEmpresa : IDALEmpresa
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");


        #region SELECT ALL
        public List<Empresa> SelectAll()
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Empresa_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Empresa");
                }

                List<Empresa> lista = new List<Empresa>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        Empresa empresa = new Empresa();
                        empresa.IDEmpresa = dr["IDEmpresa"].ToString();
                        empresa.TipoIdentificacion = dr["TipoIdentificacion"].ToString();
                        empresa.Nombre = dr["Nombre"].ToString();
                        empresa.Telefono = dr["Telefono"].ToString();
                        empresa.Direccion = dr["Direccion"].ToString();
                        empresa.Logo = (byte[])dr["Logo"];
                        empresa.Estado = bool.Parse(dr["Estado"].ToString());

                        lista.Add(empresa);
                    }
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se cargó la empresa");

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
        public Empresa SelectById(string Id)
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Empresa_ByID");
                    command.Parameters.AddWithValue("@IDEmpresa", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Empresa");
                }

                //Se crea el dataTable
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    Empresa empresa = new Empresa();
                    empresa.IDEmpresa = dt.Rows[0]["IDEmpresa"].ToString();
                    empresa.TipoIdentificacion = dt.Rows[0]["TipoIdentificacion"].ToString();
                    empresa.Nombre = dt.Rows[0]["Nombre"].ToString();
                    empresa.Telefono = dt.Rows[0]["Telefono"].ToString();
                    empresa.Direccion = dt.Rows[0]["Direccion"].ToString();
                    empresa.Logo = (byte[])dt.Rows[0]["Logo"];
                    empresa.Estado = bool.Parse(dt.Rows[0]["Estado"].ToString());
                    return empresa;
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
        public void Create(Empresa pEmpresa)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Empresa");
                    command.Parameters.AddWithValue("@IDEmpresa", pEmpresa.IDEmpresa);
                    command.Parameters.AddWithValue("@TipoIdentificacion", pEmpresa.TipoIdentificacion);
                    command.Parameters.AddWithValue("@Nombre", pEmpresa.Nombre);
                    command.Parameters.AddWithValue("@Telefono", pEmpresa.Telefono);
                    command.Parameters.AddWithValue("@Direccion", pEmpresa.Direccion);
                    command.Parameters.AddWithValue("@Logo", pEmpresa.Logo);
                    command.Parameters.AddWithValue("@Estado", pEmpresa.Estado);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);

                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se agregó la empresa: " + pEmpresa.ToString()
                    + " a la base de datos (Tabla Empresa)");
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

        public void Update(Empresa pEmpresa)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Empresa");
                    command.Parameters.AddWithValue("@IDEmpresa", pEmpresa.IDEmpresa);
                    command.Parameters.AddWithValue("@TipoIdentificacion", pEmpresa.TipoIdentificacion);
                    command.Parameters.AddWithValue("@Nombre", pEmpresa.Nombre);
                    command.Parameters.AddWithValue("@Telefono", pEmpresa.Telefono);
                    command.Parameters.AddWithValue("@Direccion", pEmpresa.Direccion);
                    command.Parameters.AddWithValue("@Logo", pEmpresa.Logo);
                    command.Parameters.AddWithValue("@Estado", pEmpresa.Estado);
                    command.CommandType = CommandType.StoredProcedure;


                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se modificó la empresa: " + pEmpresa.ToString()
                    + "en la base de datos (Tabla Usuario)");
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
        public void Delete(string pEmpresa)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_DELETE_Empresa_ByID");
                    command.Parameters.AddWithValue("@IDEmpresa", pEmpresa);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se eliminó a la empresa con el ID: " + pEmpresa
                    + " en la base de datos (Tabla Empresa)");
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

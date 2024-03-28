using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using PayrollPal.Entities;
using PayrollPal.Layers.Entities;
using PayrollPal.Layers.Util;
using System.Reflection;

namespace PayrollPal.Layers.DAL
{
    public class DALUsuario
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public static List<Usuario> SelectAll()
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Usuario_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Usuario");
                }

                List<Usuario> lista = new List<Usuario>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        Usuario usuario = new Usuario();
                        usuario.IDUsuario = dr["IDUsuario"].ToString();
                        usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                        usuario.Contrasenna = Criptografia.DecrypthAES(dr["Contrasenna"].ToString());

                        lista.Add(usuario);
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
        public static Usuario SelectById(string Id)
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Usuario_ByID");
                    command.Parameters.AddWithValue("@IDUsuario", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Usuario");
                }

                //Se crea el dataTable
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    Usuario oUsuario = new Usuario();
                    oUsuario.IDUsuario = dt.Rows[0]["IDUsuario"].ToString();
                    oUsuario.NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
                    oUsuario.Contrasenna = dt.Rows[0]["Contrasenna"].ToString();
                    return oUsuario;
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
        public static void CREATE(Usuario pUsuario)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Usuario");
                    command.Parameters.AddWithValue("@IDUsuario", pUsuario.IDUsuario);
                    command.Parameters.AddWithValue("@NombreUsuario", pUsuario.NombreUsuario);
                    command.Parameters.AddWithValue("@Contrasenna", Criptografia.EncrypthAES(pUsuario.Contrasenna));
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);

                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se agregó el usuario: " + pUsuario.ToString()
                    + " a la base de datos (Tabla Usuario)");
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
        public static void UPDATE(Usuario pUsuario)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Usuario");
                    command.Parameters.AddWithValue("@IDUsuario", pUsuario.IDUsuario);
                    command.Parameters.AddWithValue("@NombreUsuario", pUsuario.NombreUsuario);
                    command.Parameters.AddWithValue("@Contrasenna", Criptografia.EncrypthAES(pUsuario.Contrasenna));

                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se modificó el usuario: " + pUsuario.ToString()
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
        public static void DELETE(string pIdUsuario)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_DELETE_Usuario_ByID");
                    command.Parameters.AddWithValue("@IDUsuario", pIdUsuario);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se eliminó el usuario con el ID: " + pIdUsuario
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

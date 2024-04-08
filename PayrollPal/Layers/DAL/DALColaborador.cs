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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PayrollPal.Layers.DAL {
    public class DALColaborador
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public static List<Colaborador> SelectAll()
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Colaborador_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Colaborador");
                }

                List<Colaborador> lista = new List<Colaborador>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        Colaborador colaborador = new Colaborador();
                        colaborador.IDColaborador = dr["IdColaborador"].ToString();
                        colaborador.Nombre = dr["Nombre"].ToString();
                        colaborador.Apellido1 = dr["Apellido1"].ToString();
                        colaborador.Apellido2 = dr["Apellido2"].ToString();
                        colaborador.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                        colaborador.Direccion = dr["Direccion"].ToString();
                        colaborador.FechaIngreso = DateTime.Parse(dr["FechaIngreso"].ToString());
                        colaborador.IDDepartamento = BLL.BLLDepartamento.SelectById(dr["IDDepartamento"].ToString());
                        colaborador.SalarioHora = decimal.Parse(dr["SalarioHora"].ToString());
                        colaborador.CorreoElectronico = dr["CorreoElectronico"].ToString();
                        colaborador.CodigoPuesto = BLL.BLLPuesto.SelectById(dr["CodigoPuesto"].ToString());
                        colaborador.IDRol = BLL.BLLRol.SelectById(int.Parse(dr["IDRol"].ToString()));
                        colaborador.CuentaIBAN = dr["CuentaIBAN"].ToString();
                        colaborador.IDUsuario = BLL.BLLUsuario.SelectById(dr["IDUsuario"].ToString());
                        colaborador.IDSupervisor = BLL.BLLSupervisor.SelectById(dr["IDSupervisor"].ToString());
                        colaborador.Foto = (byte[])dr["Foto"];
                        colaborador.Estado = bool.Parse(dr["Estado"].ToString());


                        lista.Add(colaborador);
                    }
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se cargó la lista de colaboradores");

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
        public static Colaborador SelectById(string Id)
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Colaborador_ByID");
                    command.Parameters.AddWithValue("@IdColaborador", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Colaborador");
                }

                //Se crea el dataTable
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    Colaborador oColaborador = new Colaborador();
                    oColaborador.IDColaborador = dt.Rows[0]["IdColaborador"].ToString();
                    oColaborador.Nombre = dt.Rows[0]["Nombre"].ToString();
                    oColaborador.Apellido1 = dt.Rows[0]["Apellido1"].ToString();
                    oColaborador.Apellido2 = dt.Rows[0]["Apellido2"].ToString();
                    oColaborador.FechaNacimiento = DateTime.Parse(dt.Rows[0]["FechaNacimiento"].ToString());
                    oColaborador.Direccion = dt.Rows[0]["Direccion"].ToString();
                    oColaborador.FechaIngreso = DateTime.Parse(dt.Rows[0]["FechaIngreso"].ToString());
                    oColaborador.IDDepartamento = BLL.BLLDepartamento.SelectById(dt.Rows[0]["IDDepartamento"].ToString());
                    oColaborador.SalarioHora = decimal.Parse(dt.Rows[0]["SalarioHora"].ToString());
                    oColaborador.CorreoElectronico = dt.Rows[0]["CorreoElectronico"].ToString();
                    oColaborador.CodigoPuesto = BLL.BLLPuesto.SelectById(dt.Rows[0]["CodigoPuesto"].ToString());
                    oColaborador.IDRol = BLL.BLLRol.SelectById(int.Parse(dt.Rows[0]["IDRol"].ToString()));
                    oColaborador.CuentaIBAN = dt.Rows[0]["CuentaIBAN"].ToString();
                    oColaborador.IDUsuario = BLL.BLLUsuario.SelectById(dt.Rows[0]["IDUsuario"].ToString());
                    oColaborador.IDSupervisor = BLL.BLLSupervisor.SelectById(dt.Rows[0]["IDSupervisor"].ToString());
                    oColaborador.Foto = (byte[])dt.Rows[0]["Foto"];
                    oColaborador.Estado = bool.Parse(dt.Rows[0]["Estado"].ToString());
                    return oColaborador;
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

        #region SELECT Colaborador BY ID Supervisor

        public static List<Colaborador> SelectColaboradorIdSupervisor (string Id)
        {
            try
            {
                DataSet ds = null;  // Crear Dataset
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Colaborador_ByIDSupervisor");  // Crear SqlCommand
                    command.Parameters.AddWithValue("@IDSupervisor", Id);  // Pasar Parametros
                    command.CommandType = CommandType.StoredProcedure;  // Asignar Store Procedure
                    ds = db.ExecuteReader(command, "Colaborador");
                }
                List<Colaborador> lista = new List<Colaborador>();  // Crear Lista
                if (ds.Tables[0].Rows.Count > 0)   // Cargar Lista con objetos segun tabla del dataset
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Colaborador colaborador = new Colaborador();
                        colaborador.IDColaborador = dr["IdColaborador"].ToString();
                        colaborador.Nombre = dr["Nombre"].ToString();
                        colaborador.Apellido1 = dr["Apellido1"].ToString();
                        colaborador.Apellido2 = dr["Apellido2"].ToString();
                        colaborador.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                        colaborador.Direccion = dr["Direccion"].ToString();
                        colaborador.FechaIngreso = DateTime.Parse(dr["FechaIngreso"].ToString());
                        colaborador.IDDepartamento = BLL.BLLDepartamento.SelectById(dr["IDDepartamento"].ToString());
                        colaborador.SalarioHora = decimal.Parse(dr["SalarioHora"].ToString());
                        colaborador.CorreoElectronico = dr["CorreoElectronico"].ToString();
                        colaborador.CodigoPuesto = BLL.BLLPuesto.SelectById(dr["CodigoPuesto"].ToString());
                        colaborador.IDRol = BLL.BLLRol.SelectById(int.Parse(dr["IDRol"].ToString()));
                        colaborador.CuentaIBAN = dr["CuentaIBAN"].ToString();
                        colaborador.IDUsuario = BLL.BLLUsuario.SelectById(dr["IDUsuario"].ToString());
                        colaborador.IDSupervisor = BLL.BLLSupervisor.SelectById(dr["IDSupervisor"].ToString());
                        colaborador.Foto = (byte[])dr["Foto"];
                        colaborador.Estado = bool.Parse(dr["Estado"].ToString());
                        lista.Add(colaborador);  // Agregar el objeto a la lista
                    }
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region SELECT Solo colaboradores

        public static List<Colaborador> SelectSoloColaboradores ()
        {
            try
            {
                DataSet ds = null;  // Crear Dataset
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Colaborador_SoloColaboradores");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Colaborador");
                }
                List<Colaborador> lista = new List<Colaborador>();  // Crear Lista
                if (ds.Tables[0].Rows.Count > 0)   // Cargar Lista con objetos segun tabla del dataset
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Colaborador colaborador = new Colaborador();
                        colaborador.IDColaborador = dr["IdColaborador"].ToString();
                        colaborador.Nombre = dr["Nombre"].ToString();
                        colaborador.Apellido1 = dr["Apellido1"].ToString();
                        colaborador.Apellido2 = dr["Apellido2"].ToString();
                        colaborador.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                        colaborador.Direccion = dr["Direccion"].ToString();
                        colaborador.FechaIngreso = DateTime.Parse(dr["FechaIngreso"].ToString());
                        colaborador.IDDepartamento = BLL.BLLDepartamento.SelectById(dr["IDDepartamento"].ToString());
                        colaborador.SalarioHora = decimal.Parse(dr["SalarioHora"].ToString());
                        colaborador.CorreoElectronico = dr["CorreoElectronico"].ToString();
                        colaborador.CodigoPuesto = BLL.BLLPuesto.SelectById(dr["CodigoPuesto"].ToString());
                        colaborador.IDRol = BLL.BLLRol.SelectById(int.Parse(dr["IDRol"].ToString()));
                        colaborador.CuentaIBAN = dr["CuentaIBAN"].ToString();
                        colaborador.IDUsuario = BLL.BLLUsuario.SelectById(dr["IDUsuario"].ToString());
                        colaborador.IDSupervisor = BLL.BLLSupervisor.SelectById(dr["IDSupervisor"].ToString());
                        colaborador.Foto = (byte[])dr["Foto"];
                        colaborador.Estado = bool.Parse(dr["Estado"].ToString());
                        lista.Add(colaborador);  // Agregar el objeto a la lista
                    }
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region SELECT Colaboradores con la misma Deduccion/Percepcion asignada
        public static List<Colaborador> SELECTColaboradoresmismaDeduccionPercepcion()
        {
            try
            {
                DataSet ds = null;  // Crear Dataset
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Colaboradores_ConMismasDeduccionesPercepciones_Asignadas_ALL");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Colaborador");
                }
                List<Colaborador> lista = new List<Colaborador>();  // Crear Lista
                if (ds.Tables[0].Rows.Count > 0)   // Cargar Lista con objetos segun tabla del dataset
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Colaborador colaborador = new Colaborador();
                        colaborador.IDColaborador = dr["IdColaborador"].ToString();
                        colaborador.Nombre = dr["Nombre"].ToString();
                        colaborador.Apellido1 = dr["Apellido1"].ToString();
                        colaborador.Apellido2 = dr["Apellido2"].ToString();
                        colaborador.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                        colaborador.Direccion = dr["Direccion"].ToString();
                        colaborador.FechaIngreso = DateTime.Parse(dr["FechaIngreso"].ToString());
                        colaborador.IDDepartamento = BLL.BLLDepartamento.SelectById(dr["IDDepartamento"].ToString());
                        colaborador.SalarioHora = decimal.Parse(dr["SalarioHora"].ToString());
                        colaborador.CorreoElectronico = dr["CorreoElectronico"].ToString();
                        colaborador.CodigoPuesto = BLL.BLLPuesto.SelectById(dr["CodigoPuesto"].ToString());
                        colaborador.IDRol = BLL.BLLRol.SelectById(int.Parse(dr["IDRol"].ToString()));
                        colaborador.CuentaIBAN = dr["CuentaIBAN"].ToString();
                        colaborador.IDUsuario = BLL.BLLUsuario.SelectById(dr["IDUsuario"].ToString());
                        colaborador.IDSupervisor = BLL.BLLSupervisor.SelectById(dr["IDSupervisor"].ToString());
                        colaborador.Foto = (byte[])dr["Foto"];
                        colaborador.Estado = bool.Parse(dr["Estado"].ToString());
                        lista.Add(colaborador);  // Agregar el objeto a la lista
                    }
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region SELECT Solo Colaboradores Sin Deducciones Percepciones Asignadas
        public static List<Colaborador> SelectSoloSoloColaboradoresSinDedPerc()
        {

            try
            {
                DataSet ds = null;  // Crear Dataset
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Colaboradores_SinDeduccionesPercepciones_Asignadas_ALL");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Colaborador");
                }
                List<Colaborador> lista = new List<Colaborador>();  // Crear Lista
                if (ds.Tables[0].Rows.Count > 0)   // Cargar Lista con objetos segun tabla del dataset
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Colaborador colaborador = new Colaborador();
                        colaborador.IDColaborador = dr["IdColaborador"].ToString();
                        colaborador.Nombre = dr["Nombre"].ToString();
                        colaborador.Apellido1 = dr["Apellido1"].ToString();
                        colaborador.Apellido2 = dr["Apellido2"].ToString();
                        colaborador.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                        colaborador.Direccion = dr["Direccion"].ToString();
                        colaborador.FechaIngreso = DateTime.Parse(dr["FechaIngreso"].ToString());
                        colaborador.IDDepartamento = BLL.BLLDepartamento.SelectById(dr["IDDepartamento"].ToString());
                        colaborador.SalarioHora = decimal.Parse(dr["SalarioHora"].ToString());
                        colaborador.CorreoElectronico = dr["CorreoElectronico"].ToString();
                        colaborador.CodigoPuesto = BLL.BLLPuesto.SelectById(dr["CodigoPuesto"].ToString());
                        colaborador.IDRol = BLL.BLLRol.SelectById(int.Parse(dr["IDRol"].ToString()));
                        colaborador.CuentaIBAN = dr["CuentaIBAN"].ToString();
                        colaborador.IDUsuario = BLL.BLLUsuario.SelectById(dr["IDUsuario"].ToString());
                        colaborador.IDSupervisor = BLL.BLLSupervisor.SelectById(dr["IDSupervisor"].ToString());
                        colaborador.Foto = (byte[])dr["Foto"];
                        colaborador.Estado = bool.Parse(dr["Estado"].ToString());
                        lista.Add(colaborador);  // Agregar el objeto a la lista
                    }
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CREATE
        public static void CREATE(Colaborador pColaborador)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Colaborador");
                    command.Parameters.AddWithValue("@IdColaborador", pColaborador.IDColaborador.ToString().Replace("-",""));
                    command.Parameters.AddWithValue("@Nombre", pColaborador.Nombre);
                    command.Parameters.AddWithValue("@Apellido1", pColaborador.Apellido1);
                    command.Parameters.AddWithValue("@Apellido2", pColaborador.Apellido2);
                    command.Parameters.AddWithValue("@FechaNacimiento", pColaborador.FechaNacimiento);
                    command.Parameters.AddWithValue("@Direccion", pColaborador.Direccion);
                    command.Parameters.AddWithValue("@FechaIngreso", pColaborador.FechaIngreso);
                    command.Parameters.AddWithValue("@IDDepartamento", pColaborador.IDDepartamento.IDDepartamento);
                    command.Parameters.AddWithValue("@SalarioHora", pColaborador.SalarioHora);
                    command.Parameters.AddWithValue("@Foto", pColaborador.Foto);
                    command.Parameters.AddWithValue("@CorreoElectronico", pColaborador.CorreoElectronico);
                    command.Parameters.AddWithValue("@CodigoPuesto", pColaborador.CodigoPuesto.CodigoPuesto);
                    command.Parameters.AddWithValue("@IDRol", pColaborador.IDRol.IDRol);
                    command.Parameters.AddWithValue("@CuentaIBAN", pColaborador.CuentaIBAN);
                    command.Parameters.AddWithValue("@IDUsuario", pColaborador.IDUsuario.IDUsuario);
                    command.Parameters.AddWithValue("@IDSupervisor", pColaborador.IDSupervisor.IDSupervisor);
                    command.Parameters.AddWithValue("@Estado", pColaborador.Estado);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);

                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se agregó el colaborador: " + pColaborador.ToString()
                    + " a la base de datos (Tabla Colaborador)");
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
        public static void UPDATE(Colaborador pColaborador)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Colaborador");
                    command.Parameters.AddWithValue("@IdColaborador", pColaborador.IDColaborador.ToString().Replace("-", ""));
                    command.Parameters.AddWithValue("@Nombre", pColaborador.Nombre);
                    command.Parameters.AddWithValue("@Apellido1", pColaborador.Apellido1);
                    command.Parameters.AddWithValue("@Apellido2", pColaborador.Apellido2);
                    command.Parameters.AddWithValue("@FechaNacimiento", pColaborador.FechaNacimiento);
                    command.Parameters.AddWithValue("@Direccion", pColaborador.Direccion);
                    command.Parameters.AddWithValue("@FechaIngreso", pColaborador.FechaIngreso);
                    command.Parameters.AddWithValue("@IDDepartamento", pColaborador.IDDepartamento.IDDepartamento);
                    command.Parameters.AddWithValue("@SalarioHora", pColaborador.SalarioHora);
                    command.Parameters.AddWithValue("@Foto", pColaborador.Foto);
                    command.Parameters.AddWithValue("@CorreoElectronico", pColaborador.CorreoElectronico);
                    command.Parameters.AddWithValue("@CodigoPuesto", pColaborador.CodigoPuesto.CodigoPuesto);
                    command.Parameters.AddWithValue("@IDRol", pColaborador.IDRol.IDRol);
                    command.Parameters.AddWithValue("@CuentaIBAN", pColaborador.CuentaIBAN);
                    command.Parameters.AddWithValue("@IDUsuario", pColaborador.IDUsuario.IDUsuario);
                    command.Parameters.AddWithValue("@IDSupervisor", pColaborador.IDSupervisor.IDSupervisor);
                    command.Parameters.AddWithValue("@Estado", pColaborador.Estado);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se modificó el colaborador: " + pColaborador.ToString()
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

        #region DELETE
        public static void DELETE(string pIdColaborador)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_DELETE_Colaborador_ByID");
                    command.Parameters.AddWithValue("@IdColaborador", pIdColaborador.ToString());
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }

                //Salvar un mensaje de info en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Info("Se eliminó el colaborador con el ID: " + pIdColaborador
                    + " en la base de datos (Tabla Colaborador)");
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



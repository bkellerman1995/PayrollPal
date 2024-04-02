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
                        colaborador.Direccion = dr["Contrasenna"].ToString();
                        colaborador.FechaIngreso = DateTime.Parse(dr["FechaIngreso"].ToString());
                        colaborador.IDDepartamento = BLL.BLLDepartamento.SelectById(dr["IDDepartamento"].ToString());
                        colaborador.SalarioHora = decimal.Parse(dr["SalarioHora"].ToString());
                        colaborador.Foto = (byte[])dr["Foto"];
                        colaborador.CorreoElectronico = dr["CorreoElectronico"].ToString();
                        colaborador.CodigoPuesto = BLL.BLLPuesto.SelectById(int.Parse(dr["CodigoPuesto"].ToString()));
                        colaborador.IDRol = BLL.BLLRol.SelectById(int.Parse(dr["IDRol"].ToString()));
                        colaborador.CuentaIBAN = dr["CuentaIBAN"].ToString();
                        colaborador.IDUsuario = BLL.BLLUsuario.SelectById(dr["IDUsuario"].ToString());
                        //colaborador.IDSupervisor = BLL.bll.SelectById(dr["IDSupervisor"].ToString());
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
                    oColaborador.Direccion = dt.Rows[0]["Contrasenna"].ToString();
                    oColaborador.FechaIngreso = DateTime.Parse(dt.Rows[0]["FechaIngreso"].ToString());
                    oColaborador.IDDepartamento = BLL.BLLDepartamento.SelectById(dt.Rows[0]["IDDepartamento"].ToString());
                    oColaborador.SalarioHora = decimal.Parse(dt.Rows[0]["SalarioHora"].ToString());
                    oColaborador.Foto = (byte[])dt.Rows[0]["Foto"];
                    oColaborador.CorreoElectronico = dt.Rows[0]["CorreoElectronico"].ToString();
                    oColaborador.CodigoPuesto = BLL.BLLPuesto.SelectById(int.Parse(dt.Rows[0]["CodigoPuesto"].ToString()));
                    oColaborador.IDRol = BLL.BLLRol.SelectById(int.Parse(dt.Rows[0]["IDRol"].ToString()));
                    oColaborador.CuentaIBAN = dt.Rows[0]["CuentaIBAN"].ToString();
                    oColaborador.IDUsuario = BLL.BLLUsuario.SelectById(dt.Rows[0]["IDUsuario"].ToString());
                    //colaborador.IDSupervisor = BLL.bll.SelectById(dr["IDSupervisor"].ToString());
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

        #region CREATE
        public static void CREATE(Colaborador pColaborador)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Colaborador");
                    command.Parameters.AddWithValue("@IdColaborador", pColaborador.IDUsuario.ToString().Replace("-",""));
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
                    command.Parameters.AddWithValue("@IdColaborador", pColaborador.IDUsuario.ToString().Replace("-", ""));
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
        public static void DELETE(int pIdColaborador)
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



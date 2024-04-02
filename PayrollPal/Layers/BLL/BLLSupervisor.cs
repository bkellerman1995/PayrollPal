using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace PayrollPal.Layers.BLL
{
    public class BLLSupervisor
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public static List<Supervisor> SelectAll()
        {

            return DAL.DALUsuario.SelectAll();
        }
        #endregion

        #region SELECT BY ID
        public static Supervisor SelectById(string Id)
        {
            return DAL.DALUsuario.SelectById(Id);
        }
        #endregion

        #region CREATE
        public static void Create(Supervisor pSupervisor)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearUsuario(pUsuario.IDUsuario))
            {
                MessageBox.Show("El usuario con ID: " + pUsuario.IDUsuario + " ya existe" +
                    "¿Desea actualizarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    DAL.DALUsuario.UPDATE(pUsuario);
                }

            }
            else
            {
                DAL.DALUsuario.CREATE(pUsuario);
            }

        }
        #endregion

        #region UPDATE
        public static void Update(Supervisor pSupervisor)
        {
            DAL.DALUsuario.UPDATE(pUsuario);
        }
        #endregion

        #region DELETE
        public static void Delete(string pIdSupervisor)
        {
            DAL.DALUsuario.DELETE(pIdUsuario);
        }
        #endregion

        #region EXISTE
        public static bool ChequearSupervisor(string pIdSupervisor)
        {
            bool existe = false;

            if (SelectById(pIDUsuario) != null)
            {
                existe = true;
            }
            return existe;
        }
        #endregion

    }
}

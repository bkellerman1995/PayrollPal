using PayrollPal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using PayrollPal.Layers.Entities;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PayrollPal.Layers.BLL
{
    public class BLLUsuario
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public static List<Usuario> SelectAll()
        {

            return DAL.DALUsuario.SelectAll();
        }
        #endregion

        #region SELECT BY ID
        public static Usuario SelectById(string Id)
        {
            return DAL.DALUsuario.SelectById(Id);
        }
        #endregion

        #region CREATE
        public static void Create(Usuario pUsuario)
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
        public static void Update(Usuario pUsuario)
        {
            DAL.DALUsuario.UPDATE(pUsuario);
        }
        #endregion

        #region DELETE
        public static void Delete(string pIdUsuario)
        {
            DAL.DALUsuario.DELETE(pIdUsuario);
        }
        #endregion

        #region EXISTE
        public static bool ChequearUsuario(string pIDUsuario)
        {
            bool existe = false;

            if (SelectById(pIDUsuario)!=null)
            {
                existe = true;
            }
            return existe;
        }
        #endregion

    }
}

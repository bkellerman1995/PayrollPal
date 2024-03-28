using PayrollPal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using PayrollPal.Layers.Entities;

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
            DAL.DALUsuario.CREATE(pUsuario);
        }
        #endregion

        #region UPDATE
        public static void Update (Usuario pUsuario)
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

    }
}

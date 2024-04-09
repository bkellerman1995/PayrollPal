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
using log4net;

namespace PayrollPal.Layers.DAL
{
    public interface IDALUsuario
    {
        
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        List<Usuario> SelectAll();
        #endregion

        #region SELECT BY ID
        Usuario SelectById(string Id);
        #endregion

        #region SELECT ALL NO ASIGNADO
        List<Usuario> SelectAllNoAsignado();
        #endregion

        #region CREATE
        void CREATE(Usuario pUsuario);
        #endregion

        #region UPDATE

        void UPDATE(Usuario pUsuario);
        #endregion

        #region DELETE
        void DELETE(string pIdUsuario);
        #endregion
    }
}

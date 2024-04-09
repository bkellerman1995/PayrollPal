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

namespace PayrollPal.Layers.DAL
{
    public interface IDALRol
    {
        
                             

        #region SELECT ALL
        List<Rol> SelectAll();

        #endregion

        #region SELECT BY ID
        Rol SelectById(int Id);

        #endregion

        #region CREATE
        void CREATE(Rol pRol);

        #endregion


        #region DELETE
        void DELETE(int pIDRol);

        #endregion
    }
}

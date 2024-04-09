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
    public interface IDALDepartamento
    {
                             

        #region SELECT ALL
        List<Departamento> SelectAll();

        #endregion

        #region SELECT BY ID
        Departamento SelectById(string Id);

        #endregion

        #region CREATE
        void CREATE(Departamento pDepartamento);

        #endregion

        #region UPDATE
        void UPDATE(Departamento pDepartamento);

        #endregion

        #region DELETE
        void DELETE(string pIdDepartamento);

        #endregion
    }
}

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
using PayrollPal.Layers.Entities;
using PayrollPal.Layers.DAL;

namespace PayrollPal.Layers.IBLL
{
    public interface IBLLPuesto
    {

                     

        #region SELECT ALL
        List<Puesto> SelectAll();

        #endregion

        #region SecuenciadorPuesto

        string SecuenciadorPuesto();


        #endregion

        #region SELECT BY ID
        Puesto SelectById(string Id);

        #endregion

        #region CREATE
        void Create(Puesto pPuesto);

        #endregion

        #region UPDATE
        void Update(Puesto pPuesto);

        #endregion

        #region DELETE
        void Delete(string pCodigoPuesto);

        #endregion

        #region EXISTE
        bool ChequearPuesto(string pCodigoPuesto);

        #endregion
    }
}

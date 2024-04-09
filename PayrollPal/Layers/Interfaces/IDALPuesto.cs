using PayrollPal.Layers.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace PayrollPal.Layers.DAL
{
    public interface IDALPuesto
    {
        
                             

        #region SecuenciadorPuesto

        string SecuenciadorPuestoAumentar();


        #endregion


        #region SELECT ALL
        List<Puesto> SelectAll();

        #endregion

        #region SELECT BY ID
        Puesto SelectById(string Id);

        #endregion

        #region CREATE
        void CREATE(Puesto pPuesto);

        #endregion

        #region UPDATE
        void UPDATE(Puesto pPuesto);

        #endregion

        #region DELETE
        void DELETE(string pCodigoPuesto);

        #endregion
    }
}

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
using PayrollPal.Enumeraciones;

namespace PayrollPal.Layers.DAL
{
    public interface DALDeduccionesPercepciones
    {
        
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SecuenciadorDeduccionesPercepciones

        string SecuenciadorDeduccionesPercepciones();

        #endregion

        #region SELECT ALL
        List<Deducciones_Percepciones> SelectAll();

        #endregion

        #region SELECT BY ID
        Deducciones_Percepciones SelectById(string codigo);

        #endregion

        #region CREATE
        void CREATE(Deducciones_Percepciones pDeduccionesPercepciones);

        #endregion

        #region UPDATE

        void UPDATE(Deducciones_Percepciones pDeduccionesPercepciones);

        #endregion

        #region DELETE
        void DELETE(string pCodigoDeduccionesPercepciones);

        #endregion
    }
}

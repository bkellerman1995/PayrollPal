using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using PayrollPal.Layers.DAL;

namespace PayrollPal.Layers.IBLL
{
    public interface IBLLDeduccionesPercepciones
    {

                             

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
        void Create(Deducciones_Percepciones pDeducciones_Percepciones);

        #endregion

        #region UPDATE
        void Update(Deducciones_Percepciones pDeduccionesPercepciones);

        #endregion

        #region DELETE
        void Delete(string pCodigoDeduccionesPercepciones);

        #endregion

        #region EXISTE
        bool ChequearDeducciones_Percepciones(string pCodigoDeduccionPercepcion);

        #endregion

    }
}

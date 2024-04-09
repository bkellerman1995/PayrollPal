using PayrollPal.Enumeraciones;
using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPal.Layers.IBLL
{
    public interface IBLLDeducciones_Percepciones_Por_Colaborador
    {

                     

        #region SELECT ALL
        List<Deducciones_Percepciones_Por_Colaborador> SelectAll();

        #endregion

        #region SELECT TODOS    
        List<Deducciones_Percepciones_Por_Colaborador> SelectTodo();

        #endregion

        #region SELECT BY ID
        Deducciones_Percepciones_Por_Colaborador SelectById(string codigoDeduccionPercepcion, string idColaborador);

        #endregion

        #region CREATE
        void Create(Deducciones_Percepciones_Por_Colaborador pDedPercColab);

        #endregion

        #region UPDATE
        void Update(Deducciones_Percepciones_Por_Colaborador pDedPercColab);

        #endregion

        #region DELETE
        void Delete(string pCodigoDeduccionPercepcion, string pIdColaborador);

        #endregion

        #region EXISTE
        bool ChequearpDedPercColab(string pCodigoDeduccionPercepcion, string pIDColaborador);

        #endregion
    }
}

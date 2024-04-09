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
using PayrollPal.Enumeraciones;

namespace PayrollPal.Layers.DAL
{
    public interface IDALDeducciones_Percepciones_Por_Colaborador
    {
        
                     


        #region SELECT ALL
        List<Deducciones_Percepciones_Por_Colaborador> SelectAll();

        #endregion


        #region SELECT TODO
        List<Deducciones_Percepciones_Por_Colaborador> SelectTodo();

        #endregion

        #region SELECT BY ID
        Deducciones_Percepciones_Por_Colaborador SelectById(string CodigoDeduccionPercepcion, string idColaborador);

        #endregion

        #region CREATE
        void CREATE(Deducciones_Percepciones_Por_Colaborador pDedPercColab);

        #endregion

        #region UPDATE
        void UPDATE(Deducciones_Percepciones_Por_Colaborador pDedPercColab);

        #endregion

        #region DELETE
        void DELETE(string pCodigoDeduccionPercepcion, string pIdColaborador);

        #endregion
    }
}

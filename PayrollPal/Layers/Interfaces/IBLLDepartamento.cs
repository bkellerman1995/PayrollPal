using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPal.Layers.IBLL
{
    public interface IBLLDepartamento
    {
        #region SELECT ALL
        List<Departamento> SelectAll();
        #endregion

        #region SELECT BY ID
        Departamento SelectById(string Id);

        #endregion

        #region CREATE
        void Create(Departamento pDepartamento);

        #endregion

        #region UPDATE
        void Update(Departamento pDepartamento);

        #endregion

        #region DELETE
        void Delete(string pIdDepartamento);

        #endregion

        #region EXISTE
        bool ChequearDepartamento(string pIDDepartamento);

        #endregion
    }
}

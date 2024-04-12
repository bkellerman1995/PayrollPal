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
    public interface IBLLSupervisor
    {

        #region SELECT ALL
        List<Supervisor> SelectAll();

        #endregion

        #region SELECT ALL NO ASIGNADO
        List<Supervisor> SelectAllNoAsignado();
        #endregion

        #region SecuenciadorSupervisor

        string SecuenciadorPuesto();


        #endregion

        #region SELECT BY ID
        Supervisor SelectById(string Id);

        #endregion

        #region CREATE
        void Create(Supervisor pSupervisor);

        #endregion

        #region UPDATE
        void Update(Supervisor pSupervisor);

        #endregion

        #region DELETE
        void Delete(string pIdSupervisor);

        #endregion

        #region EXISTE
        bool ChequearSupervisor(string pIdSupervisor);

        #endregion

    }
}

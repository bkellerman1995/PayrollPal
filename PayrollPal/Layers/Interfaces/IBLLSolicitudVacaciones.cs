using PayrollPal.Layers.DAL;
using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPal.Layers
{
    public interface IBLLSolicitudVacaciones
    {

        #region SecuenciadorSolicitudVacaciones

        string SecuenciadorSolicitudVacaciones();


        #endregion

        #region SELECT ALL
        List<SolicitudVacaciones> SelectAll();

        #endregion

        #region SELECT BY ID
        SolicitudVacaciones SelectById(string Id);

        #endregion

        #region CREATE
        void Create(SolicitudVacaciones pSolicitud);

        #endregion

        #region UPDATE
        void Update(SolicitudVacaciones pSolicitud);

        #endregion

        #region DELETE
        void Delete(string pIdSolicitud);

        #endregion

        #region EXISTE
        bool ChequearSolicitudVacaciones(string pSolicitud);
 
        #endregion

    }
}

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
using PayrollPal.Enumeraciones;
using log4net;

namespace PayrollPal.Layers.DAL
{
    public interface DALSolicitudVacaciones
    {
        
                          log4net.LogManager.GetLogger("MyControlEventos");

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
        void CREATE(SolicitudVacaciones pSolicitud);

        #endregion

        #region UPDATE

        void UPDATE(SolicitudVacaciones pSolicitud);

        #endregion

        #region DELETE
        void DELETE(string pSolicitud);

        #endregion }

    }
}

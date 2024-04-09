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
    public class BLLSolicitudVacaciones : IBLLSolicitudVacaciones
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SecuenciadorSolicitudVacaciones

        public string SecuenciadorSolicitudVacaciones()
        {
            IDALSolicitudVacaciones dALSolicitudVacaciones = new DALSolicitudVacaciones();
            return dALSolicitudVacaciones.SecuenciadorSolicitudVacaciones();
        }

        #endregion

        #region SELECT ALL
        public List<SolicitudVacaciones> SelectAll()
        {
            IDALSolicitudVacaciones dALSolicitudVacaciones = new DALSolicitudVacaciones();
            return dALSolicitudVacaciones.SelectAll();
        }
        #endregion

        #region SELECT BY ID
        public SolicitudVacaciones SelectById(string Id)
        {
            IDALSolicitudVacaciones dALSolicitudVacaciones = new DALSolicitudVacaciones();
            return dALSolicitudVacaciones.SelectById(Id);
        }
        #endregion

        #region CREATE
        public void Create(SolicitudVacaciones pSolicitud)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearSolicitudVacaciones(pSolicitud.IDSolicitudVacas))
            {
                MessageBox.Show("La solicitud de vacaciones con ID: " + pSolicitud.IDSolicitudVacas + " ya existe" +
                    "¿Desea actualizarla?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    IDALSolicitudVacaciones dALSolicitudVacaciones = new DALSolicitudVacaciones();
                    dALSolicitudVacaciones.UPDATE(pSolicitud);
                }

            }
            else
            {
                IDALSolicitudVacaciones dALSolicitudVacaciones = new DALSolicitudVacaciones();
                dALSolicitudVacaciones.CREATE(pSolicitud);
            }

        }
        #endregion

        #region UPDATE
        public void Update(SolicitudVacaciones pSolicitud)
        {
            IDALSolicitudVacaciones dALSolicitudVacaciones = new DALSolicitudVacaciones();
            dALSolicitudVacaciones.UPDATE(pSolicitud);
        }
        #endregion

        #region DELETE
        public void Delete(string pIdSolicitud)
        {
            IDALSolicitudVacaciones dALSolicitudVacaciones = new DALSolicitudVacaciones();
            dALSolicitudVacaciones.DELETE(pIdSolicitud);
        }
        #endregion

        #region EXISTE
        public bool ChequearSolicitudVacaciones(string pSolicitud)
        {
            bool existe = false;

            if (SelectById(pSolicitud) != null)
            {
                existe = true;
            }
            return existe;
        }
        #endregion

    }
}

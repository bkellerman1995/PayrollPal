using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPal.Layers
{
    public class BLLSolicitudVacaciones
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public static List<SolicitudVacaciones> SelectAll()
        {

            return DAL.DALSolicitudVacaciones.SelectAll();
        }
        #endregion

        #region SELECT BY ID
        public static SolicitudVacaciones SelectById(string Id)
        {
            return DAL.DALSolicitudVacaciones.SelectById(Id);
        }
        #endregion

        #region CREATE
        public static void Create(SolicitudVacaciones pSolicitud)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearSolicitudVacaciones(pSolicitud.IDSolicitudVacas))
            {
                MessageBox.Show("La solicitud de vacaciones con ID: " + pSolicitud.IDSolicitudVacas + " ya existe" +
                    "¿Desea actualizarla?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    DAL.DALSolicitudVacaciones.UPDATE(pSolicitud);
                }

            }
            else
            {
                DAL.DALSolicitudVacaciones.CREATE(pSolicitud);
            }

        }
        #endregion

        #region UPDATE
        public static void Update(SolicitudVacaciones pSolicitud)
        {
            DAL.DALSolicitudVacaciones.UPDATE(pSolicitud);
        }
        #endregion

        #region DELETE
        public static void Delete(string pIdSolicitud)
        {
            DAL.DALSolicitudVacaciones.DELETE(pIdSolicitud);
        }
        #endregion

        #region EXISTE
        public static bool ChequearSolicitudVacaciones(string pSolicitud)
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

using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using PayrollPal.Layers.DAL;
using PayrollPal.Layers.IBLL;

namespace PayrollPal.Layers.BLL
{
    public class BLLDeduccionesPercepciones : IBLLDeduccionesPercepciones
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SecuenciadorDeduccionesPercepciones

        public string SecuenciadorDeduccionesPercepciones()
        {
            IDALDeduccionesPercepciones dALDeduccionesPercepciones = new DALDeduccionesPercepciones();
            return dALDeduccionesPercepciones.SecuenciadorDeduccionesPercepciones();
        }

        #endregion

        #region SELECT ALL
        public List<Deducciones_Percepciones> SelectAll()
        {
            IDALDeduccionesPercepciones dALDeduccionesPercepciones = new DALDeduccionesPercepciones();
            return dALDeduccionesPercepciones.SelectAll();
        }
        #endregion

        #region SELECT BY ID
        public Deducciones_Percepciones SelectById(string codigo)
        {
            IDALDeduccionesPercepciones dALDeduccionesPercepciones = new DALDeduccionesPercepciones();
            return dALDeduccionesPercepciones.SelectById(codigo);
        }
        #endregion

        #region CREATE
        public void Create(Deducciones_Percepciones pDeducciones_Percepciones)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearDeducciones_Percepciones(pDeducciones_Percepciones.CodigoDeduccionPercepcion))
            {
                MessageBox.Show("La deducción/percepción con código: " + pDeducciones_Percepciones.CodigoDeduccionPercepcion + " ya existe" +
                    "¿Desea actualizarla?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    IDALDeduccionesPercepciones dALDeduccionesPercepciones = new DALDeduccionesPercepciones();
                    dALDeduccionesPercepciones.UPDATE(pDeducciones_Percepciones);
                }

            }
            else
            {
                IDALDeduccionesPercepciones dALDeduccionesPercepciones = new DALDeduccionesPercepciones();
                dALDeduccionesPercepciones.CREATE(pDeducciones_Percepciones);
            }

        }
        #endregion

        #region UPDATE
        public void Update(Deducciones_Percepciones pDeduccionesPercepciones)
        {
            IDALDeduccionesPercepciones dALDeduccionesPercepciones = new DALDeduccionesPercepciones();
            dALDeduccionesPercepciones.UPDATE(pDeduccionesPercepciones);
        }
        #endregion

        #region DELETE
        public void Delete(string pCodigoDeduccionesPercepciones)
        {
            IDALDeduccionesPercepciones dALDeduccionesPercepciones = new DALDeduccionesPercepciones();
            dALDeduccionesPercepciones.DELETE(pCodigoDeduccionesPercepciones);
        }
        #endregion

        #region EXISTE
        public bool ChequearDeducciones_Percepciones(string pCodigoDeduccionPercepcion)
        {
            bool existe = false;

            if (SelectById(pCodigoDeduccionPercepcion) != null)
            {
                existe = true;
            }
            return existe;
        }
        #endregion

    }
}

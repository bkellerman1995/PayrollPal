using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using PayrollPal.Layers.DAL;
using PayrollPal.Entities;
using PayrollPal.Layers.IBLL;

namespace PayrollPal.Layers.BLL
{
    public class BLLColaborador : IBLLColaborador
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                         log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public List<Colaborador> SelectAll()
        {
            IDALColaborador dALColaborador = new DALColaborador();
            return dALColaborador.SelectAll();
        }
        #endregion

        #region SecuenciadorColaborador

        public string SecuenciadorColaborador()
        {
            IDALColaborador dALColaborador = new DALColaborador();
            return dALColaborador.SecuenciadorColaboradorumentar();
        }

        #endregion

        #region SELECT BY ID
        public Colaborador SelectById(string Id)
        {
            IDALColaborador dALColaborador = new DALColaborador();
            return dALColaborador.SelectById(Id);
        }
        #endregion

        #region SELECT Solo Colaboradores
        public List<Colaborador> SelectSoloColaboradores()
        {
            IDALColaborador dALColaborador = new DALColaborador();
            return dALColaborador.SelectSoloColaboradores();
        }
        #endregion

        #region SELECT Colaboradores con la misma Deduccion/Percepcion asignada
        public List<Colaborador> SELECTColaboradoresmismaDeduccionPercepcion()
        {
            IDALColaborador dALColaborador = new DALColaborador();
            return dALColaborador.SELECTColaboradoresmismaDeduccionPercepcion();
        }
        #endregion


        #region SELECT Solo Colaboradores Sin Deducciones Percepciones Asignadas
        public List<Colaborador> SelectSoloColaboradoresSinDedPerc()
        {
            IDALColaborador dALColaborador = new DALColaborador();
            return dALColaborador.SelectSoloColaboradoresSinDedPerc();
        }
        #endregion

        #region SELECT Colaborador BY ID Supervisor
        public List<Colaborador> SelectColaboradorIdSupervisor(string Id)
        {
            IDALColaborador dALColaborador = new DALColaborador();
            return dALColaborador.SelectColaboradorIdSupervisor(Id);
        }

        #endregion

        #region CREATE
        public void Create(Colaborador pColaborador)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearColaborador(pColaborador.IDColaborador))
            {
                MessageBox.Show("El colaborador con ID: " + pColaborador.IDUsuario + " ya existe" +
                    "¿Desea actualizarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    IDALColaborador dALColaborador = new DALColaborador();
                    dALColaborador.UPDATE(pColaborador);
                }

            }
            else
            {
                IDALColaborador dALColaborador = new DALColaborador();
                dALColaborador.CREATE(pColaborador);
            }

        }
        #endregion

        #region UPDATE
        public void Update(Colaborador pColaborador)
        {
            IDALColaborador dALColaborador = new DALColaborador();
            dALColaborador.UPDATE(pColaborador);
        }
        #endregion

        #region DELETE
        public void Delete(string pIdColaborador)
        {
            IDALColaborador dALColaborador = new DALColaborador();
            dALColaborador.DELETE(pIdColaborador);
        }
        #endregion

        #region EXISTE
        public bool ChequearColaborador(string pColaborador)
        {
            bool existe = false;

            if (SelectById(pColaborador) != null)
            {
                existe = true;
            }
            return existe;
        }
        #endregion

        #region CalcularHorasOrdinariasExtraordinarias

        public void CalcularHorasOrdExt(Colaborador oColab, PlanillaPago oPago, Planilla_Detalle planillaDetalle)
        {
            double horasOrdinarias = 0;
            double horasExtraordinarias = 0;
            IBLLControlDeMarcas bLLControlDeMarcas = new BLLControlDeMarcas();
            List<ControlDeMarcas> listaMarcas = bLLControlDeMarcas.SelectAll().Where(marca => marca.IdColaborador == oColab.IDColaborador
            && (DateTime.ParseExact((marca.Fecha), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            >= oPago.FechaDesde) && (DateTime.ParseExact((marca.Fecha), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            <= oPago.FechaHasta)).ToList();

            foreach (var marca in listaMarcas)
            {
                if (marca.HorasTrabajadas > 48)
                {
                    horasOrdinarias += 48;
                    horasExtraordinarias += marca.HorasTrabajadas - horasOrdinarias;
                }
                else
                {
                    horasOrdinarias += marca.HorasTrabajadas;
                }
            }

            planillaDetalle.hrsTrabajadas = horasOrdinarias;
            planillaDetalle.hrsExtras = horasExtraordinarias;

        }

        #endregion
    }
}

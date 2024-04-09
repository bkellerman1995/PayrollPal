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

namespace PayrollPal.Layers.IBLL
{
    public interface IBLLColaborador
    {

                         

        #region SELECT ALL
        List<Colaborador> SelectAll();

        #endregion

        #region SecuenciadorColaborador

        string SecuenciadorColaborador();

        #endregion

        #region SELECT BY ID
        Colaborador SelectById(string Id);

        #endregion

        #region SELECT Solo Colaboradores
        List<Colaborador> SelectSoloColaboradores();

        #endregion

        #region SELECT Colaboradores con la misma Deduccion/Percepcion asignada
        List<Colaborador> SELECTColaboradoresmismaDeduccionPercepcion();

        #endregion


        #region SELECT Solo Colaboradores Sin Deducciones Percepciones Asignadas
        List<Colaborador> SelectSoloColaboradoresSinDedPerc();

        #endregion

        #region SELECT Colaborador BY ID Supervisor
        List<Colaborador> SelectColaboradorIdSupervisor(string Id);


        #endregion

        #region CREATE
        void Create(Colaborador pColaborador);

        #endregion

        #region UPDATE
        void Update(Colaborador pColaborador);

        #endregion

        #region DELETE
        void Delete(string pIdColaborador);

        #endregion

        #region EXISTE
        bool ChequearColaborador(string pColaborador);

        #endregion

        #region CalcularHorasOrdinariasExtraordinarias

        void CalcularHorasOrdExt(Colaborador oColab, PlanillaPago oPago, Planilla_Detalle planillaDetalle);


        #endregion
    }
}

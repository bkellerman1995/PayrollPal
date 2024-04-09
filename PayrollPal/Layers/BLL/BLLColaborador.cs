﻿using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using PayrollPal.Layers.DAL;
using PayrollPal.Entities;

namespace PayrollPal.Layers.BLL
{
    public class BLLColaborador
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                         log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public static List<Colaborador> SelectAll()
        {

            return DAL.DALColaborador.SelectAll();
        }
        #endregion

        #region SecuenciadorColaborador

        public static string SecuenciadorColaborador()
        {
            return DALColaborador.SecuenciadorColaboradorumentar();
        }

        #endregion

        #region SELECT BY ID
        public static Colaborador SelectById(string Id)
        {
            return DAL.DALColaborador.SelectById(Id);
        }
        #endregion

        #region SELECT Solo Colaboradores
        public static List<Colaborador> SelectSoloColaboradores()
        {

            return DAL.DALColaborador.SelectSoloColaboradores();
        }
        #endregion

        #region SELECT Colaboradores con la misma Deduccion/Percepcion asignada
        public static List<Colaborador> SELECTColaboradoresmismaDeduccionPercepcion()
        {

            return DAL.DALColaborador.SELECTColaboradoresmismaDeduccionPercepcion();
        }
        #endregion


        #region SELECT Solo Colaboradores Sin Deducciones Percepciones Asignadas
        public static List<Colaborador> SelectSoloColaboradoresSinDedPerc()
        {

            return DAL.DALColaborador.SelectSoloColaboradoresSinDedPerc();
        }
        #endregion

        #region SELECT Colaborador BY ID Supervisor
        public static List<Colaborador> SelectColaboradorIdSupervisor(string Id)
        {
            return DAL.DALColaborador.SelectColaboradorIdSupervisor(Id);
        }

        #endregion

        #region CREATE
        public static void Create(Colaborador pColaborador)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearColaborador(pColaborador.IDColaborador))
            {
                MessageBox.Show("El colaborador con ID: " + pColaborador.IDUsuario + " ya existe" +
                    "¿Desea actualizarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    DAL.DALColaborador.UPDATE(pColaborador);
                }

            }
            else
            {
                DAL.DALColaborador.CREATE(pColaborador);
            }

        }
        #endregion

        #region UPDATE
        public static void Update(Colaborador pColaborador)
        {
            DAL.DALColaborador.UPDATE(pColaborador);
        }
        #endregion

        #region DELETE
        public static void Delete(string pIdColaborador)
        {
            DAL.DALColaborador.DELETE(pIdColaborador);
        }
        #endregion

        #region EXISTE
        public static bool ChequearColaborador(string pColaborador)
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

        public static void CalcularHorasOrdExt(Colaborador oColab, PlanillaPago oPago, Planilla_Detalle planillaDetalle)
        {
            double horasOrdinarias = 0;
            double horasExtraordinarias = 0;
            List<ControlDeMarcas> listaMarcas = BLLControlDeMarcas.SelectAll().Where(marca => marca.IdColaborador == oColab.IDColaborador
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

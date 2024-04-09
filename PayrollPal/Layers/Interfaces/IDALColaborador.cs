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
using log4net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PayrollPal.Layers.DAL {
    public interface DALColaborador
    {
        
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        List<Colaborador> SelectAll();
        #endregion


        #region SecuenciadorColaborador

        string SecuenciadorColaboradorumentar();

        #endregion

        #region SELECT BY ID
        Colaborador SelectById(string Id);

        #endregion

        #region SELECT Colaborador BY ID Supervisor

        List<Colaborador> SelectColaboradorIdSupervisor(string Id);

        #endregion

        #region SELECT Solo colaboradores

        List<Colaborador> SelectSoloColaboradores();


        #endregion

        #region SELECT Colaboradores con la misma Deduccion/Percepcion asignada
        List<Colaborador> SELECTColaboradoresmismaDeduccionPercepcion();

        #endregion

        #region SELECT Solo Colaboradores Sin Deducciones Percepciones Asignadas
        List<Colaborador> SelectSoloColaboradoresSinDedPerc();
        #endregion

        #region CREATE
        void CREATE(Colaborador pColaborador);

        #endregion

        #region UPDATE
        void UPDATE(Colaborador pColaborador);

        #endregion

        #region DELETE
        void DELETE(string pIdColaborador);

        #endregion
    }
}



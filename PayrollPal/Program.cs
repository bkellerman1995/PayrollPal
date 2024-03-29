using PayrollPal.Layers.UI.Mantenimientos;
using PayrollPal.UI.Consultas;
using PayrollPal.UI.Mantenimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPal
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMantenimientoPuestos());
        }
    }
}

using imposicion;
using System;
using System.Windows.Forms;
using ImposicionForm = imposicion.FrmImposicion;

namespace tutasa
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.Run(new tutasa.Admision.Admision());
        }
    }
}

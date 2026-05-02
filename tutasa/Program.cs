using System;
using System.Windows.Forms;
using ImposicionForm = imposicion.Imposicion;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            // Puedes cambiar ImposicionForm() por Admision.Admision() si quieres ver la nueva pantalla al iniciar
            Application.Run(new tutasa.Admision.Admision());
        }
    }
}
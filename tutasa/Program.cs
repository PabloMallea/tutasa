using imposicion;
using System;
using System.Windows.Forms;

namespace tutasa
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // IMPORTANTE: Asegurate que acá diga el nombre de tu form
            Application.Run(new FrmImposicion());
        }
    }
}

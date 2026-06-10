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
            //Ac� se instancia el formulario correspondiente y se lo establece como formulario principal de ejecuci�n de la aplicaci�n.
            Application.Run(new tutasa.RendicionHDRtransporte.RendicionHDRtransporte());

        }
    }
}

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
            //Acá se instancia el formulario correspondiente y se lo establece como formulario principal de ejecución de la aplicación.
            Application.Run(new tutasa.ImposicionCallCenter.ImposicionCallCenter());

        }
    }
}

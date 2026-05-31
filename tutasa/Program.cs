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

          

            //Pantalla de Admisión 
            //Application.Run(new tutasa.Admision.Admision());

            //Pantalla de Consulta de Estado Interna
            Application.Run(new tutasa.ConsultaEstadoInterna.ConsultaEstadoInterna());

            //Pantalla de Imposición Agencia
            //Application.Run(new tutasa.Imposicion_Agencia.Imposicion_Agencia());

            //Pantalla de Rendición HDR Transporte
            //Application.Run(new tutasa.RendicionHDRtransporte.RendicionHDRtransporte());

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.Almacenes
{
    public enum EstadoGuiaEnum
    {//Reever la revisión de Andrés para comentar los estados
        Impuesta,
        PlanificadaRetiro,
        EnProcesoRetiro,
        PendienteAdmision,
        Admitida,
        PlanificadaTransporte,
        EnTransporte,
        EnDestino,
        PlanificadaDistribucion,
        EnProcesoDistribucion,
        PendienteDeEntrega,
        Entregada,
        Facturada
    }
}

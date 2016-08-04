using Mapeable;
using System.Collections.Generic;
using Certificados.DS.MapeosABaseDeDatos;

namespace WebApplication1.Certificados.ConsultarTodasLasEmisiones.ViewModels
{
    public static class MapeoAEmisionesRealizadasVista
    {
        public static List<EmisionRealizadaVista> Mapee(List<RegistroDeEmision> lasEmisiones)
        {
            return new MapeoDeColecciones<RegistroDeEmision, EmisionRealizadaVista>().Mapee(lasEmisiones);
        }
    }
}
using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
using Mapeable;

namespace Certificados.DS.GenerarEmision.ConPolimorfismo
{
    public class DatosDeLaEmisionExtranjera : DatosDeLaEmision
    {
        public override DatosParaUnCertificadoDigital DatosDeAutenticacion
        {
            get
            {
                return new Mapeo<DatosDeLaEmision, 
                    DatosParaUnCertificadoDigitalExtranjeroDeAutenticacion>().Mapee(this);
            }
        }

        public override DatosParaUnCertificadoDigital DatosDeFirma
        {
            get
            {
                return new Mapeo<DatosDeLaEmision, 
                    DatosParaUnCertificadoDigitalExtranjeroDeFirma>().Mapee(this);
            }
        }
    }
}

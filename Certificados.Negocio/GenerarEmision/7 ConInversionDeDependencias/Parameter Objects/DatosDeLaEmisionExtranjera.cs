using Certificados.Negocio.GenerarCertificados.ConPolimorfismo;
using Mapeable;

namespace Certificados.Negocio.GenerarEmision.ConInversionDeDependencias
{
    public abstract class DatosDeLaEmisionExtranjera : DatosDeLaEmision
    {
        public override DatosParaUnCertificadoDigital DatosDeAutenticacion
        {
            get
            {
                return new Mapeo<DatosDeLaEmision, DatosParaUnCertificadoDigitalExtranjeroDeAutenticacion>().Mapee(this);
            }
        }

        public override DatosParaUnCertificadoDigital DatosDeFirma
        {
            get
            {
                return new Mapeo<DatosDeLaEmision, DatosParaUnCertificadoDigitalExtranjeroDeFirma>().Mapee(this);
            }
        }
    }
}
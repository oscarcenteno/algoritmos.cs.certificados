namespace Sujetos
{
    public abstract class InformacionNacional : InformacionFormateada
    {
        public override string OU
        {
            get
            {
                return "OU=CIUDADANO";
            }
        }

        public override string SerialNumber
        {
            get
            {
                return $"SERIALNUMBER=CPF-{Identificacion}";
            }
        }
    }
}
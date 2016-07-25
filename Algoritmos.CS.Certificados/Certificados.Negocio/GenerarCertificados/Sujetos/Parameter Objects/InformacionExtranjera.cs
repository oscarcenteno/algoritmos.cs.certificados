namespace Sujetos
{
    public abstract class InformacionExtranjera : InformacionFormateada
    {
        public override string OU
        {
            get
            {
                return "OU=EXTRANJERO";
            }
        }

        public override string SerialNumber
        {
            get
            {
                return $"SERIALNUMBER=NUP-{Identificacion}";
            }
        }
    }
}

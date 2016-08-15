namespace Sujetos
{
    public class InformacionDelSolicitante
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }

        public string NombreEnMayuscula
        {
            get
            {
                return Nombre.ToUpper();
            }
        }
        public string ApellidosUnidos
        {
            get
            {
                return $"{PrimerApellido} {SegundoApellido}";
            }
        }
    }
}

namespace Sujetos
{
    public class CN
    {
        private string elProposito;
        private string elNombreEnMayuscula;
        private string losApellidosFormateados;

        public CN(InformacionFormateada laInformacion)
        {
            elProposito = DetermineElProposito(laInformacion);
            elNombreEnMayuscula = laInformacion.NombreEnMayuscula;
            losApellidosFormateados = laInformacion.ApellidosFormateados;
        }

        private static string DetermineElProposito(InformacionFormateada laInformacion)
        {
            return laInformacion.Proposito;
        }

        public string ComoTexto()
        {
            return $"CN={elNombreEnMayuscula} {losApellidosFormateados} ({elProposito})";
        }
    }
}
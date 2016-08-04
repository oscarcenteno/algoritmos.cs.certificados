using System.Data.Entity;
using System.Linq;

namespace Certificados.DS.MapeosABaseDeDatos
{
    public class RepositorioDeParametros
    { 
        public string ObtengaLaDireccionDeRevocacion()
        {
            const string crl = "direccionDeRevocacion";
            return new EmisionDBContext().Parametros.Where(c => c.Nombre == crl).First().Valor;
        }

        public int ObtengaLosAñosDeVigencia()
        {
            const string añosDeVigencia = "añosDeVigencia";
            string elValor= new EmisionDBContext().Parametros.Where(c => c.Nombre == añosDeVigencia).First().Valor;

            return int.Parse(elValor);
        }

    }
}
using System.Data.Entity;
using System.Linq;

namespace Certificados.DS.MapeosABaseDeDatos
{
    public class RepositorioDeParametros
    { 
        public string ObtengaLaDireccionDeRevocacion()
        {
            EmisionDBContext elContexto = new EmisionDBContext();
            DbSet<RegistroDeParametro> laTablaDeParametros = elContexto.Parametros;

            const string crl = "direccionDeRevocacion";
            var laConsultaDeParametros = laTablaDeParametros.Where(c => c.Nombre == crl);
            RegistroDeParametro elParametroBuscado = laConsultaDeParametros.First();

            return elParametroBuscado.Valor;
        }

        public int ObtengaLosAñosDeVigencia()
        {
            EmisionDBContext elContexto = new EmisionDBContext();
            DbSet<RegistroDeParametro> laTablaDeParametros = elContexto.Parametros;
            const string añosDeVigencia = "añosDeVigencia";
            var laConsultaDeParametros = laTablaDeParametros.Where(c => c.Nombre == añosDeVigencia);
            RegistroDeParametro elParametroBuscado = laConsultaDeParametros.First();
            var elValorBuscado = elParametroBuscado.Valor;

            return int.Parse(elValorBuscado);
        }

    }
}
using System;
using System.Data.Entity;

namespace Certificados.DS.MapeosABaseDeDatos
{
    public class EmisionDBInitializer : DropCreateDatabaseIfModelChanges<EmisionDBContext>
    {
        protected override void Seed(EmisionDBContext contexto)
        {
            RegistroDeParametro elParametroDeDireccionDeRevocacion;
            elParametroDeDireccionDeRevocacion = new RegistroDeParametro()
            {
                Nombre = "direccionDeRevocacion",
                Valor = "http://firma.cr/revocacion.crl",
                FechaDeRegistro = DateTime.Now
            };
            contexto.Parametros.Add(elParametroDeDireccionDeRevocacion);

            RegistroDeParametro elParametroDeAñosDeVigencia;
            elParametroDeAñosDeVigencia = new RegistroDeParametro()
            {
                Nombre = "añosDeVigencia",
                Valor = "4",
                FechaDeRegistro = DateTime.Now
            };
            contexto.Parametros.Add(elParametroDeAñosDeVigencia);

            base.Seed(contexto);
        }
    }
}
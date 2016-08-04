using Certificados.DS.GenerarEmision.ConInversionDeDependencias;
using Mapeable;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Certificados.Emitir.RequestModels
{
    public class DatosDelExtranjero
    {
        [Required(ErrorMessage = "La identificación es requerida.")]
        [DisplayName("Identificación")]
        public string Identificacion { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El primer apellido es requerido.")]
        [DisplayName("Primer apellido")]
        public string PrimerApellido { get; set; }

        [DisplayName("Segundo apellido")]
        public string SegundoApellido { get; set; }

        public DatosDeLaEmisionExtranjeraConDependencias ComoObjeto()
        {
            return new Mapeo<DatosDelExtranjero, DatosDeLaEmisionExtranjeraConDependencias>().Mapee(this);
        }
    }
}
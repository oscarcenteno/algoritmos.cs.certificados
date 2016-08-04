using Certificados.DS.GenerarEmision.ConInversionDeDependencias;
using Mapeable;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Certificados.Emitir.RequestModels
{
    public class DatosDelNacional
    {
        [Required(ErrorMessage = "La cédula es requerida.")]
        [DisplayName("Cédula")]
        public string Identificacion { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Su primer apellido es requerido.")]
        [DisplayName("Primer apellido")]
        public string PrimerApellido { get; set; }

        [Required(ErrorMessage = "El segundo apellido es requerido.")]
        public string SegundoApellido { get; set; }

        public DatosDeLaEmisionNacionalConDependencias ComoObjeto()
        {
            return new Mapeo<DatosDelNacional, DatosDeLaEmisionNacionalConDependencias>().Mapee(this);
        }
    }
}
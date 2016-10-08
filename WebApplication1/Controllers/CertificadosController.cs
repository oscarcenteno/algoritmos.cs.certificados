using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using WebApplication1.Certificados.Emitir.RequestModels;
using WebApplication1.Certificados.ConsultarLosCertificados.ViewModels;
using WebApplication1.Certificados.ConsultarTodasLasEmisiones.ViewModels;
using Certificados.BS.RegistrarEmision.ConObjetos;
using Certificados.DS.MapeosABaseDeDatos;
using Certificados.DS.GenerarEmision.ConInversionDeDependencias;

namespace WebApplication1.Controllers
{
    public class CertificadosController : Controller
    {
        // GET: Certificados
        public ActionResult Index()
        {
            List<RegistroDeEmision> losRegistros = RepositorioDeEmisiones.ConsulteTodas();

            List<EmisionRealizadaVista> lasVistas;
            lasVistas = MapeoAEmisionesRealizadasVista.Mapee(losRegistros);

            return View(lasVistas);
        }

        // GET: Certificados/Details/5
        public ActionResult Details(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            RegistroDeEmision elRegistro = RepositorioDeEmisiones.ObtengaPorId(id);

            List<CertificadoVista> lasVistas;
            lasVistas = new MapeoACertificadosVista(elRegistro).ComoLista();

            return View(lasVistas);
        }

        // GET: Certificados/EmitaANacional
        public ActionResult EmitaANacional()
        {
            return View();
        }

        // POST: Certificados/EmitaANacional
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmitaANacional(DatosDelNacional losDatos)
        {
            if (ModelState.IsValid)
            {
                DatosDeLaEmisionNacionalConDependencias losDatosConDependencias;
                losDatosConDependencias = losDatos.ComoObjeto();
                ProcesoDeEmision.Ejecute(losDatosConDependencias);

                return RedirectToAction("Index");
            }

            return View(losDatos);
        }

        // GET: Certificados/EmitaAExtranjero
        public ActionResult EmitaAExtranjero()
        {
            return View();
        }

        // POST: Certificados/EmitaAExatranjero
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmitaAExtranjero(DatosDelExtranjero losDatos)
        {
            if (ModelState.IsValid)
            {
                DatosDeLaEmisionExtranjeraConDependencias losDatosConDependencias;
                losDatosConDependencias = losDatos.ComoObjeto();
                ProcesoDeEmision.Ejecute(losDatosConDependencias);

                return RedirectToAction("Index");
            }

            return View(losDatos);
        }
    }
}
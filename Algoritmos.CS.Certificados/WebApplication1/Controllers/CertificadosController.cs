using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using WebApplication1.Certificados.Emitir.RequestModels;
using WebApplication1.Certificados.ConsultarLosCertificados.ViewModels;
using WebApplication1.Certificados.ConsultarTodasLasEmisiones.ViewModels;
using Certificados.BS.RegistrarEmision.ConObjetos;
using Certificados.DS.Consultas;
using Certificados.DS.MapeosABaseDeDatos;

namespace WebApplication1.Controllers
{
    public class CertificadosController : Controller
    {
        // GET: Certificados
        public ActionResult Index()
        {
            List<EmisionRealizadaVista> lasEmisiones = ObtengaLasEmisionesParaMostrar();
            return View(lasEmisiones);
        }

        private static List<EmisionRealizadaVista> ObtengaLasEmisionesParaMostrar()
        {
            List<RegistroDeEmision> lasEmisiones = ConsulteTodasLasEmisiones();

            return MapeeALaVista(lasEmisiones);
        }

        private static List<EmisionRealizadaVista> MapeeALaVista(List<RegistroDeEmision> lasEmisiones)
        {
            return MapeoAEmisionesRealizadasVista.Mapee(lasEmisiones);
        }

        private static List<RegistroDeEmision> ConsulteTodasLasEmisiones()
        {
            return RepositorioDeEmisiones.ConsulteTodas();
        }

        // GET: Certificados/Details/5
        public ActionResult Details(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            List<CertificadoEmitidoVista> losCertificados;
            losCertificados = ObtengaLosCertificados(id);

            return View(losCertificados);
        }

        private static List<CertificadoEmitidoVista> ObtengaLosCertificados(int id)
        {
            RegistroDeEmision laEmision;
            laEmision = ObtengaLaEmisionPorId(id);

            return MapeeALaVista(laEmision);
        }

        private static RegistroDeEmision ObtengaLaEmisionPorId(int id)
        {
            return RepositorioDeEmisiones.ObtengaPorId(id);
        }

        private static List<CertificadoEmitidoVista> MapeeALaVista(RegistroDeEmision losCertificados)
        {
            return MapeoACertificadosEmitidosVista.Mapee(losCertificados);
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
                var laSolicitud = losDatos.ComoObjeto();
                new ProcesoDeEmision(laSolicitud).Ejecute();

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
                var laSolicitud = losDatos.ComoObjeto();
                new ProcesoDeEmision(laSolicitud).Ejecute();

                return RedirectToAction("Index");
            }

            return View(losDatos);
        }
    }
}
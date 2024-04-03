using Microsoft.AspNetCore.Mvc;
using MvcCoreClienteWCF.Services;
using ServiceReferenceEscenas;

namespace MvcCoreClienteWCF.Controllers
{
    public class EscenasController : Controller
    {
        private ServiceEscenas service;

        public EscenasController(ServiceEscenas service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            Escena[] escenas = await this.service.GetEscenasAsync();
            return View(escenas);
        }
        [HttpPost]
        public async Task<IActionResult> Index(int idpelicula)
        {
            Escena[] escenas = await this.service.GetEscenasAsync();
            ViewData["DATOS"] = await this.service.GetEscenasPelis(idpelicula);

            return View(escenas);
        }
    }
}

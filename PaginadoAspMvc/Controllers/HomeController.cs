using PaginadoAspMvc.Models;
using PaginadoAspMvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaginadoAspMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int pagina = 1)
        {
            var CantidadRegistroPorPagina = 12;

            using (var context = new ContextMvc())
            {
                var personas = context.Personas.OrderBy(x => x.Id)
                     .Skip((pagina - 1) * CantidadRegistroPorPagina)
                     .Take(CantidadRegistroPorPagina).ToList();
                var totalDeRegistro = context.Personas.Count();

                var model = new IndexViewModels();
                model.personas = personas;
                model.PaginaActual = pagina;
                model.TotalDeRegistros = totalDeRegistro;
                model.ResgistrosPorPagina = CantidadRegistroPorPagina;

                return View(model);
            }
                
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using PW3TPFinal.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PW3TPFinal.Controllers
{
    public class PeliculasController : Controller
    {
        // GET: Peliculas
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Reserva()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Peliculas p)
        {
            return RedirectToAction("Inicio");
        }
    }
}
using PW3TPFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PW3TPFinal.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Inicio()
        {
            CresmontContext carteleras = new CresmontContext();
            List<Carteleras> listCartelera = carteleras.Carteleras.ToList();
            return View(listCartelera);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Usuarios u)
        {
            return RedirectToAction("Inicio");
        }
    }
}
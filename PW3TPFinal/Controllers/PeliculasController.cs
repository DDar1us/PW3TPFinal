﻿using PW3TPFinal.Models;
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
        public ActionResult Reserva(Peliculas p)
        {
            return RedirectToAction("Inicio");
        }
    }
}
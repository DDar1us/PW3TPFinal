﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PW3TPFinal.Controllers
{
    public class AdministracionController : Controller
    {
        // GET: Administracion
        public ActionResult Inicio()
        {
            return View();
        }
        public ActionResult Sedes()
        {
            return View();
        }
        public ActionResult Carteleras()
        {
            return View();
        }
        public ActionResult Reportes()
        {
            return View();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendamentoConsultas.Controllers
{
    public class ConsultasController : Controller
    {
        // GET: Consultas
        public ActionResult Index()
        {
            return View();
        }
    }
}
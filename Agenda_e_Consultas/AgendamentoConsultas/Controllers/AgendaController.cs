﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendamentoConsultas.Controllers
{
    public class AgendaController : Controller
    {
        // GET: Agenda
        public ActionResult CadastroMedico()
        {
            return View();
        }
    }
}
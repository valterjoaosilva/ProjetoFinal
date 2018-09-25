using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgendamentoConsultas.Models;
using AgendamentoConsultas.DAO;

namespace AgendamentoConsultas.Controllers
{
    public class ConvenioController : Controller
    {
        // GET: Convenio
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegistroConvenio()
        {            
            return View();
        }
        public ActionResult Adiciona(Convenio convenio)
        {
            ConvenioDAO dao = new ConvenioDAO();
            dao.Adiciona(convenio);

            return RedirectToAction("Index", "Convenio");
        }

    }
}
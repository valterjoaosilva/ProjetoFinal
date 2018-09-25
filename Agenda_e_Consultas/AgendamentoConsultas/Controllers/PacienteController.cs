using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgendamentoConsultas.Models;
using AgendamentoConsultas.DAO;

namespace AgendamentoConsultas.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult Index(Paciente paciente)
        {
            ConvenioDAO dao = new ConvenioDAO();
            ViewBag.Convenios = dao.Lista();

            return View();
        }
    }
}
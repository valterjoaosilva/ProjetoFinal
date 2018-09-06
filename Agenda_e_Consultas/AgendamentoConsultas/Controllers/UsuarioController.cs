using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendamentoConsultas.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Adiciona(Medico medico)
        {

            MedicosDAO dao = new MedicosDAO();
            dao.Adiciona(medico);

            return RedirectToAction("Index", "Medico");

        }
    }
}
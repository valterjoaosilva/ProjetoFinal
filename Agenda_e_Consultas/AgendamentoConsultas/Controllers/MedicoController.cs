using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgendamentoConsultas.DAO;
using AgendamentoConsultas.Models;
namespace AgendamentoConsultas.Controllers
{
    public class MedicoController : Controller
    {
        // GET: Medico
        public ActionResult Medicosindex()
        {
            MedicosDAO dao = new MedicosDAO();            
            ViewBag.Medicos = dao.Lista();            
            return View();

        }
    }
}
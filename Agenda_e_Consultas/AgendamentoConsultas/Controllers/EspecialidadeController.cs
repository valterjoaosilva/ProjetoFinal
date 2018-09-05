using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgendamentoConsultas.DAO;
using AgendamentoConsultas.Models;

namespace AgendamentoConsultas.Controllers
{
    public class EspecialidadeController : Controller
    {
        // GET: Especialidade
        public ActionResult Index()
        {
            EspecialidadesDAO dao = new EspecialidadesDAO();
            ViewBag.Especialidade = dao.Lista();
            return View();
        }
        
       
        public ActionResult Form()
        {
            
            return View();
        }
        public ActionResult Adiciona(Especialidade especialidade)
        {
            EspecialidadesDAO dao = new EspecialidadesDAO();
            dao.Adiciona(especialidade);

            return RedirectToAction("Index", "Especialidade");

        }
    }
}
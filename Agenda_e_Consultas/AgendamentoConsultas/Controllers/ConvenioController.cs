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
            ConvenioDAO dao = new ConvenioDAO();
            ViewBag.Convenios = dao.Lista();

            return View();
        }

        public ActionResult Form()
        {            
            return View();
        }
        public ActionResult Adiciona(Convenio convenio)
        {
            ConvenioDAO dao = new ConvenioDAO();
            dao.Adiciona(convenio);

            return RedirectToAction("Index", "Convenio");
        }
        public ActionResult Remover(int id)
        {
            ConvenioDAO dao = new ConvenioDAO();
            Convenio convenio = dao.BuscaPorId(id);
            dao.Remover(convenio);

            return RedirectToAction("Index", "Convenio");
        }


        public ActionResult ViewEditar(int id)
        {
            ConvenioDAO dao = new ConvenioDAO();
            ViewBag.Convenio = dao.BuscaPorId(id);

            return View();
        }

        public ActionResult Editar(int id, Convenio convenio)
        {
            ConvenioDAO dao = new ConvenioDAO();

            Convenio conv = dao.BuscaPorId(id);
            conv.ConvenioNome = convenio.ConvenioNome;
           

            dao.Atualiza(conv);
            return RedirectToAction("Index", "Convenio");
        }
    }
}
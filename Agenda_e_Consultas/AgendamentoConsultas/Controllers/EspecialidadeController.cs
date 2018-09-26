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
            ViewBag.Especialidades = dao.Lista();
            
            return View();
        }
        
       
        public ActionResult Form()
        {
            EspecialidadesDAO dao = new EspecialidadesDAO();
            ViewBag.Especialidade = dao.Lista();

            return View();
        }
        public ActionResult Adiciona(Especialidade especialidade)
        {
            EspecialidadesDAO dao = new EspecialidadesDAO();
            dao.Adiciona(especialidade);

            return RedirectToAction("Index", "Especialidade");


        }
        public ActionResult Remover(int id)
        {


            EspecialidadesDAO dao = new EspecialidadesDAO();
            Especialidade especialidade = dao.BuscaPorId(id);
            dao.Remover(especialidade);

            return RedirectToAction("index", "Especialidade");
        }

        public ActionResult ViewEditar(int id)
        {
            EspecialidadesDAO dao = new EspecialidadesDAO();           
            
            ViewBag.Especialidade = dao.BuscaPorId(id);

            return View();
        }

        public ActionResult Editar(int id, Medico medico)
        {
            MedicosDAO dao = new MedicosDAO();

            Medico med = dao.BuscaPorId(id);
            med.Nome = medico.Nome;
            med.EspecialidadeId = medico.EspecialidadeId;
            med.Descricao = medico.Descricao;

            dao.Atualiza(med);
            return RedirectToAction("Medicosindex", "Medico");
        }

    }
}
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
        public ActionResult Form()
        {
            EspecialidadesDAO especialidadesDAO = new EspecialidadesDAO();
            IList<Especialidade> especialidades = especialidadesDAO.Lista();
            ViewBag.Especialidades = especialidades;
            return View();
        }
        public ActionResult Adiciona(Medico medico)
        {
                       
            MedicosDAO dao = new MedicosDAO();
            dao.Adiciona(medico);

            return RedirectToAction("Medicosindex", "Medico");
            
        }

        public ActionResult Remover(int id)
        {


            MedicosDAO dao = new MedicosDAO();
            Medico medico = dao.BuscaPorId(id);
            dao.Remover(medico);

            return RedirectToAction("Medicosindex", "Medico");
        }

        public ActionResult ViewEditar(int id)
        {
            MedicosDAO dao = new MedicosDAO();
            EspecialidadesDAO especialidadesDAO = new EspecialidadesDAO();
            ViewBag.Especialidades  = especialidadesDAO.Lista();
            ViewBag.Medico = dao.BuscaPorId(id);

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
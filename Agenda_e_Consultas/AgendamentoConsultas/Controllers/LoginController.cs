using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgendamentoConsultas.Models;
using AgendamentoConsultas.DAO;

namespace AgendamentoConsultas.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Autentica(String login, String senha)
        {
            PacienteDAO dao = new PacienteDAO();
            Paciente paciente = dao.Busca(login, senha);
            if (paciente != null)
            {
                Session["pacienteLogado"] = paciente;
                return RedirectToAction("Index", "Login");

            }
            else
            {
                return RedirectToAction("index");
            }
        }
        
    }
}
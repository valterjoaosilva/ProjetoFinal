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
        // GET: Pacientes
        public ActionResult Index(Paciente paciente)
        {
            ConvenioDAO dao = new ConvenioDAO();
            ViewBag.Convenios = dao.Lista();

            return View();
        }

      
        public ActionResult Adiciona(Paciente paciente)
        {

            PacienteDAO dao = new PacienteDAO();
            dao.Adiciona(paciente);

            return RedirectToAction("Index", "Pacientes");

        }
        

        public ActionResult Remover(int id)
        {


            PacienteDAO dao = new PacienteDAO();
            Paciente paciente = dao.BuscaPorId(id);
            dao.Remover(paciente);

            return RedirectToAction("Index", "Pacientes");
        }

        public ActionResult ViewEditar(int id)
        {
            PacienteDAO dao = new PacienteDAO();
            ConvenioDAO convenioDAO = new ConvenioDAO();
            ViewBag.Convenio = convenioDAO.Lista();
            ViewBag.Paciente = dao.BuscaPorId(id);

            return View();
        }



        public ActionResult Editar(int id, Paciente paciente)
        {
            PacienteDAO dao = new PacienteDAO();

            Paciente pac = dao.BuscaPorId(id);

            pac.Nome = paciente.Nome;
            pac.Cpf = paciente.Cpf;
            pac.DataNascimento = paciente.DataNascimento;
            pac.Sexo = paciente.Sexo;
            pac.Cep = paciente.Cep;
            pac.Endereco = paciente.Endereco;
            pac.Bairro = paciente.Bairro;
            pac.Complemento = paciente.Complemento;
            pac.Cidade = paciente.Cidade;
            pac.Uf = paciente.Uf;
            pac.Telefone = paciente.Telefone;
            pac.Celular = paciente.Celular;
            pac.ConvenioId = paciente.ConvenioId;
            pac.Email = paciente.Email;
            pac.Senha = paciente.Senha;
            pac.ConfirmarSenha = paciente.ConfirmarSenha;
               

            dao.Atualiza(pac);
            return RedirectToAction("Index", "Pacientes");
        }
    }
}
  
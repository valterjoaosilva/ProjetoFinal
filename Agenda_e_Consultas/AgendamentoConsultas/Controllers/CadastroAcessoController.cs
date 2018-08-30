using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendamentoConsultas.Controllers
{
    public class CadastroAcessoController : Controller
    {
        // GET: CadastroAcesso
        public ActionResult CadastroAcessoIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar()
        {
            int i = 1;
            return View();
        }
    }
}
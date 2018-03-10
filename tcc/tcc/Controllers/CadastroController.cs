using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using tcc.Models;

namespace tcc.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult CadastraUsuario(tb_usuarios teste)
        {
            ModelState.AddModelError("TxSenha", "Usuário Desativado!");

            return View();
        }
    }
}
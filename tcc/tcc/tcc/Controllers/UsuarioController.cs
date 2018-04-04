using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tcc.Models;

namespace tcc.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View("Cadastro");
        }

        public ActionResult CadastraUsuario(tb_usuarios objUsuario)
        {
            if (!String.IsNullOrEmpty(objUsuario.tx_nome) && !String.IsNullOrEmpty(objUsuario.tx_login) && !String.IsNullOrEmpty(objUsuario.tx_email) && !String.IsNullOrEmpty(objUsuario.tx_senha))
            {

                //Créditos iniciais
                objUsuario.in_creditos = 5;
                Usuario usuario = new Usuario();
                usuario.cadastraUsuario(objUsuario);
                ViewBag.Status = "Dados gravados com Êxito";
                return View("Cadastro");

            }

            else
            {
                ModelState.AddModelError("Usuario", "Preencha todos os dados do formulário");
                return View("Cadastro", objUsuario);
            }


        }
    }
}
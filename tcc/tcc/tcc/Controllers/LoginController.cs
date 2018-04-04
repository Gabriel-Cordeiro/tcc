using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using tcc.Models;

namespace tcc.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login(string returnUrl)
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            //Verifica se a pagina recebe um parametro de redirecionamento e retira a URL adicional
            if (string.IsNullOrEmpty(returnUrl))
            {

                return View();
            }
            //Variavel que verifica se a pagina foi acessada por redirecionamento
            TempData["Autenticacao"] = "Redirecionamento";

            return Redirect("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(tb_usuarios login)
        {

            if (ModelState.IsValid)
            {

                Usuario usuarioDao = new Usuario();
                var usuarioLogin = usuarioDao.UsuarioPorLoginEsenha(login);

                if (usuarioLogin != null)
                {
                    FormsAuthentication.SetAuthCookie(login.tx_login, false);
                    Response.Cookies.Add(new HttpCookie("PerfilLogin", usuarioLogin.tx_nome.ToString()));
                    Response.Cookies.Add(new HttpCookie("PerfilCreditos", usuarioLogin.in_creditos.ToString()));
                    return RedirectToAction("Index", "Principal");
                }
                else
                {
                    ModelState.AddModelError("UsuarioIncorreto", "Dados não encontrados, verifique se foi digitado corretamente");
                    return View("Login");
                }

            }
            return RedirectToAction("Login");
        }
    }
}
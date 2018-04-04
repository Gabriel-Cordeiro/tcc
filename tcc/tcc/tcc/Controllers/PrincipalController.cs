using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace tcc.Controllers
{
 
    public class PrincipalController : Controller
    {
        // GET: Principal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Deslogar()
        {

            FormsAuthentication.SignOut();

            //Expira o cookie do Perfil Login
            Response.Cookies["PerfilLogin"].Expires = DateTime.Now.AddDays(-1);

            return Redirect("../Login/Login");

        }
    }
}
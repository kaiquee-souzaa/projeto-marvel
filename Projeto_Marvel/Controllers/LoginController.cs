using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto_Marvel.Models;

namespace Projeto_Marvel.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(LOGIN login)
        {
            if (ModelState.IsValid)
            {
                using (var db = new Projeto_QuadrinhoEntities1())
                {
                    var v = db.LOGIN.Where(a => a.USUARIO.Equals(login.USUARIO) && a.SENHA.Equals(login.SENHA)).FirstOrDefault();
                    if (v != null)
                    {
                        return RedirectToAction("Eventos", "Home");
                    }
                    else
                    {
                        ViewBag.alerta = "<script>" + "alert('Área reservada para pessoas cadastradas');" + "</script>";
                    }

                }
            }
            return View(login);
        }
    }
}
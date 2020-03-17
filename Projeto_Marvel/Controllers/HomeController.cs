using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto_Marvel.Models;

namespace Projeto_Marvel.Controllers
{
    public class HomeController : Controller
    {
        private Projeto_QuadrinhoEntities1 db = new Projeto_QuadrinhoEntities1();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult QmSomos()
        {
            return View();
        }

        public ActionResult Listar()
        {
            return View(db.FALE.ToList());
        }

        public ActionResult Contato(FALE fale)
        {
            if (ModelState.IsValid)
            {
                db.FALE.Add(fale);
                db.SaveChanges();

                return RedirectToAction("Listar");
            }

            else
            {
                return View("Contato");
            }
        }

        public ActionResult ComoChegar()
        {
            return View();
        }

        public ActionResult Eventos()
        {
            return View();
        }
    }
}
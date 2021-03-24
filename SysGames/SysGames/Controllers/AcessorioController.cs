using SysGames.Dal;
using SysGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SysGames.Controllers
{
    public class AcessorioController : Controller
    {
        // GET: Acessorio
        private SysGamesContext db = new SysGamesContext();

        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Acessorio acessorio) {
            if (ModelState.IsValid) {
                db.Acessorios.Add(acessorio);
                db.SaveChanges();
                return RedirectToAction("Index", "Produto");
            }
            return View(acessorio);
        }
    }
}

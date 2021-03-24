using SysGames.Dal;
using SysGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SysGames.Controllers {
    public class JogoController : Controller {
        private SysGamesContext db = new SysGamesContext();

        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Jogo jogo) {
            if (ModelState.IsValid) {
                db.Jogos.Add(jogo);
                db.SaveChanges();
                return RedirectToAction("Index", "Produto");
            }
            return View(jogo);
        }
    }
}

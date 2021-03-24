using SysGames.Dal;
using SysGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SysGames.Controllers {
    public class VideogameController : Controller {
        private SysGamesContext db = new SysGamesContext();

        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Videogame videogame) {
            if (ModelState.IsValid) {
                db.Videogames.Add(videogame);
                db.SaveChanges();
                return RedirectToAction("Index", "Produto");
            }
            return View(videogame);
        }
    }
}
using GuessGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuessGame.Controllers
{
    public class GuessGameController : Controller
    {
        // GET: GuessGame
        public ActionResult Index()
        {
            Session["Answer"] = new Random().Next(1, 10);
            return View();
        }
        private bool GuessWasCorrect(int guess)
        {
            return guess == (int)Session["Answer"];
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(GuessGameModel model)
        {
            if (ModelState.IsValid)
            {
                var win = GuessWasCorrect(model.Guess);
                if (win) return RedirectToAction("Winner");

                ViewBag.Win = win;
            }

            return View(model);
        }

        public ActionResult Winner()
        {
            return View("Winner");

        }
    }
}
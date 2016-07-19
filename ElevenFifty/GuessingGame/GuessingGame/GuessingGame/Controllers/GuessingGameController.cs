using GuessingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuessingGame.Controllers
{
    public class GuessingGameController : Controller
    {
        // GET: GuessingGame
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
        public ActionResult Index(GuessingGameModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Win = GuessWasCorrect(model.Guess);
            }
            return View(model);
        }

    }
}
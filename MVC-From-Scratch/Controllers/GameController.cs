using Microsoft.AspNetCore.Mvc;
using MVC_From_Scratch.Models;

namespace MVC_From_Scratch.Controllers
{
    public class GameController : Controller
    {
        [HttpPost]
        public IActionResult GameGuess(int guess)
        {
            if (!(string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd")) || guess <= 0) || guess >= 100)
            {
                int storeRnd = (int)HttpContext.Session.GetInt32("intRnd");
                string respons = GuessGameNr.MatchGuess(Convert.ToInt32(guess), storeRnd);

                ViewBag.Msg = respons;
            }
            else
            {
                ViewBag.Msg = "Hutta in ett nummber";
            }
            return View();
        }

        [HttpGet]
        public IActionResult GameGuess()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd")))
            {
                int getRnd = GuessGameNr.GetRandom(100);
                HttpContext.Session.SetInt32("intRnd", getRnd);
                ViewBag.Rnd = getRnd;
            }
            else
            {
                ViewBag.Rnd = HttpContext.Session.GetString("intRnd");
            }
            return View();
        }


        [HttpGet]

        public IActionResult BortBort()
        {
            int getRnd = GuessGameNr.GetRandom(100);
            HttpContext.Session.SetInt32("intRnd", getRnd);
            return RedirectToAction(nameof(GameGuess));
        }
    }
}

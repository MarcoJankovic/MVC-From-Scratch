using Microsoft.AspNetCore.Mvc;

namespace MVC_From_Scratch.Controllers
{
    public class DoctorController : Controller
    {
        [HttpPost]
        public IActionResult FeverCheck(double temp)
        {
            if(temp != 0)
            {
                ViewBag.Msg = Models.Doctor.Diagnose(temp);
                return View();
            }
            else
            {
                ViewBag.Msg = "Temperature not found!.";
                return View();
            }
        }

        [HttpGet]

        public IActionResult FeverCheck()
        {
            return View();
        }
    }
}

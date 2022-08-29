using Microsoft.AspNetCore.Mvc;
using CH02FutureValueChristensen.Models;

namespace CH02FutureValueChristensen.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            ViewBag.FV = model.CalculateFutureValue();
            return View(model);
        }
    }
}

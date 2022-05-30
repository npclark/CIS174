using FirstResponsiveWebAppClark.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppClark.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = null;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureAgeModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.AgeThisYear();
            }
            else
            {
                ViewBag.FV = null;
            }
            return View(model);
        }
    }
}

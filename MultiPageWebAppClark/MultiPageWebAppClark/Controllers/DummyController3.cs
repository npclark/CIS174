using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiPageWebAppClark.Controllers
{
    public class DummyController3 : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return Content("Dummy Controller, Action Index");
        }

        [Route("About")]
        public IActionResult About()
        {
            return Content("Dummy Controller, Action About");
        }
    }
}

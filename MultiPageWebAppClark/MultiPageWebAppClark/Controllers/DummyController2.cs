using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiPageWebAppClark.Controllers
{
    public class DummyController2 : Controller
    {
        public IActionResult Index(string id = "index", int page = 4)
        {
            return Content("Dummy Controller, Action Index, id: " + id + " page: " + page.ToString());
        }
    }
}

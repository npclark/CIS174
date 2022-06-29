using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiPageWebAppClark.Controllers
{
    public class DummyController1 : Controller
    {
        public IActionResult Index()
        {
            return Content("Dummy Controller, Index action");
        }

        public IActionResult Post(string id = "all")
        {
            return Content("Dummy Controller, Post action, id " + id);
        }
    }
}

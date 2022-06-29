using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiPageWebAppClark.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MultiPageWebAppClark.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(c => c.ContactName).ToList();
            return View(contacts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
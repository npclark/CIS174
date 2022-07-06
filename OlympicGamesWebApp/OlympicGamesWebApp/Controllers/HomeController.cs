using Microsoft.AspNetCore.Mvc;
using OlympicGamesWebApp.Models;
using System.Diagnostics;

namespace OlympicGamesWebApp.Controllers
{
    public class HomeController : Controller
    {
        private CountryContext context;

        public HomeController(CountryContext ctx)
        {
            context = ctx;
        }

        public ViewResult Index(string activeGame = "all", string activeSport = "all", string activeType = "all")
        {
            ViewBag.ActiveGame = activeGame;
            ViewBag.ActiveSport = activeSport;
            ViewBag.ActiveType = activeType;

            List<Game> games = context.Games.ToList();
            List<Sport> sports = context.Sports.ToList();
            List<Type> types = context.Types.ToList();

            games.Insert(0, new Game { GameID = "all", GameName = "All" });
            sports.Insert(0, new Sport { SportID = "all", SportName = "All" });
            types.Insert(0, new Type { TypeID = "all", TypeName = "All" });

            ViewBag.Games = games;
            ViewBag.Sports = sports;
            ViewBag.Types = types;

            IQueryable<Country> query = context.Countries;
            if (activeGame != "all")
                query = query.Where(t => t.Game.GameID.ToLower() == activeGame.ToLower());
            if (activeSport != "all")
                query = query.Where(t => t.Sport.SportID.ToLower() == activeSport.ToLower());
            if (activeType != "all")
                query = query.Where(t => t.Type.TypeID.ToLower() == activeType.ToLower());

            var countries = query.ToList();
            return View(countries);
        }
       /* private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
    }*/
}
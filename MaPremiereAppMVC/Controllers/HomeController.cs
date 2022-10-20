using MaPremiereAppMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MaPremiereAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Crash()
        {
            throw new Exception("Je veux tout casser!");
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            this._logger.LogInformation("Chargement de privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        protected override void Dispose(bool disposing)
        {
            _logger.LogInformation($"Controller : {nameof(HomeController)} est supprimé");
            base.Dispose(disposing);
        }
    }
}
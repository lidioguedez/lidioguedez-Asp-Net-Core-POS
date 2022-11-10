using Asp_Net_Core_POS.Core.ViewModels;
using Asp_Net_Core_POS.Logic.Interface;
using Asp_Net_Core_POS.Logic.Repository.Interfases;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Asp_Net_Core_POS.Areas.Inventario.Controllers
{
    [Area("Inventario")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBodegaServices _bodegaService;

        public HomeController(ILogger<HomeController> logger, IBodegaServices bodegaService)
        {
            _logger = logger;
            _bodegaService = bodegaService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult ErrorAsync()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
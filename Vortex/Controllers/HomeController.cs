using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Vortex.Models;
using Vortex.Service;

namespace Vortex.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            ViewBag.Invocador = null;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> IndexAsync(Invocador nome)
        {
            Busca_Invocador buscaInvocador = new Busca_Invocador();

            var Bordas = new List<int> () { 30, 50, 75, 100, 125, 150, 175, 200, 225, 250, 275, 300, 325, 350, 375, 400, 425, 450, 475, 500 };

            Invocador invocador = await buscaInvocador.GetInvocadorAsync(nome.name);
            ViewBag.Invocador = invocador;

            int Borda = 0;
            foreach (int borda in Bordas) {
                if ( invocador.summonerLevel >= borda)
                {
                    Borda = borda;
                }
            }
            ViewBag.Borda = Borda;

            return View();
        }

        [HttpPost]
        public IActionResult Index(Invocador nome, string page)
        {
            switch (page)
            {
                case "Partidas":
                    return View(PrivacyAsync(nome.accountId));
                default:
                    break;
            }
            return View();
        }
        public async Task<IActionResult> PrivacyAsync(string id_invocador)
        {

            return View();
        }

        public IActionResult Detalhada()
        {
                 Busca_Champions buscaChampions = new Busca_Champions();

            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

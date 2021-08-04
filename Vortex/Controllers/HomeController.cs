using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Vortex.Models;
using Vortex.Service;

namespace Vortex.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMemoryCache _invocador;

        public HomeController(ILogger<HomeController> logger, IMemoryCache invocador)
        {
            _logger = logger;
            _invocador = invocador;
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

            Invocador invocador = await buscaInvocador.GetInvocadorAsync(nome.name);
            var invocadorKey = "Invocador";
            string invocadorJson = JsonConvert.SerializeObject(invocador);
            var cacheConfig = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromHours(3));
            _invocador.Set(invocadorKey, invocadorJson,cacheConfig);
            ViewBag.Invocador = invocador;

            var Bordas = new List<int>() { 30, 50, 75, 100, 125, 150, 175, 200, 225, 250, 275, 300, 325, 350, 375, 400, 425, 450, 475, 500 };
            int Borda = 0;
            foreach (int borda in Bordas)
            {
                if ( invocador.summonerLevel >= borda)
                {
                    Borda = borda;
                }
            }
            ViewBag.Borda = Borda;

            return View();
        }

        public async Task<IActionResult> PartidasAsync()
        {
            var invocadorKey = "Invocador";
            string invocadorJson = _invocador.Get<string>(invocadorKey);
            Invocador invocador = JsonConvert.DeserializeObject<Invocador>(invocadorJson);
            _ = new Busca_Champions().GetSicronizaDadosAsync(); 
            Busca_Partidas busca_Partidas = new Busca_Partidas();
            List<PartidaCompleta> partidas = await busca_Partidas.GetPartidasAsync(invocador.accountId);
            ViewBag.Partidas = partidas; 
            return View();
        }

        public async Task<IActionResult> DetalhadaAsync()
        {
            Busca_Partidas busca_Partidas = new Busca_Partidas();

            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

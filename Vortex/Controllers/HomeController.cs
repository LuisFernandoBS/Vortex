using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public async Task<IActionResult> PrivacyAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://br1.api.riotgames.com/lol/match/v4/matchlists/by-account/hqwUuZ7BjrHmz4AtiPfSA8tWjvdw-XmFJzKZDhzuiU4uhd8");

                //HTTP GET
                HttpResponseMessage resposta = await client.GetAsync("?api_key=RGAPI-53a9f29d-94f5-4ae9-949b-8f240e3650f1");

                ViewBag.Partidas = "";
                if (resposta.IsSuccessStatusCode)
                {
                    var result = resposta.Content.ReadAsStringAsync().Result;
                    var dados = JsonConvert.DeserializeObject<PartidasTotal>(result);
                    ViewBag.Partidas = dados;
                }

            }
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

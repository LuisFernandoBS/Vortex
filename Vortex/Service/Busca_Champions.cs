using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Vortex.Models;

namespace Vortex.Service
{
    public class Busca_Champions
    {
        public async Task<ListaChampion> GetChampionsrAsync()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage resposta = await client.GetAsync("https://ddragon.leagueoflegends.com/cdn/11.15.1/data/pt_BR/champion.json");
                string conteudo = resposta.Content.ReadAsStringAsync().Result;

                return resposta.IsSuccessStatusCode ? JsonConvert.DeserializeObject<ListaChampion>(conteudo) : null;
            }
        }

        public async Task<object> GetChampionsTesterAsync()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage resposta = await client.GetAsync("https://ddragon.leagueoflegends.com/cdn/11.15.1/data/pt_BR/champion.json");
                string conteudo = resposta.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<ListaChampion>(conteudo);
            }
        }
    }
}

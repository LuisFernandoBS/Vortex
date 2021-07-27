using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Vortex.Models;

namespace Vortex.Service
{
    public class Busca_Champions : Api
    {
        public async Task<ListaChampion> GetChampionsrAsync()
        {
            using (var client = new HttpClient())
            {
                string versao = await DdragonVersion();
                HttpResponseMessage resposta = await client.GetAsync("https://ddragon.leagueoflegends.com/cdn/"+ versao + "/data/pt_BR/champion.json");
                string conteudo = resposta.Content.ReadAsStringAsync().Result;

                return resposta.IsSuccessStatusCode ? JsonConvert.DeserializeObject<ListaChampion>(conteudo) : null;
            }
        }

    }
}

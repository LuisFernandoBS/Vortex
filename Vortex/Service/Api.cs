using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Vortex.Service
{
    public class Api
    {
        public string Key { get; set; }

        public Api()
        {
            Key = GetKey("Service/Key.txt");
        }

        public string GetKey(string path)
        {
            StreamReader sr = new StreamReader(path);
            return sr.ReadToEnd();
        }

        protected string GetURI(string path)
        {
            return "https://br1.api.riotgames.com/lol/" + path + "?api_key=" + Key;
        }

        protected async Task<HttpResponseMessage> GET(string URL)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetAsync(URL);

                return  result;
            }
        }
        public async Task<string> DdragonVersion()
        {
            using (HttpClient client = new HttpClient())
            {
                var resposta = await client.GetAsync("https://ddragon.leagueoflegends.com/api/versions.json");

                string conteudo = resposta.Content.ReadAsStringAsync().Result;

                var listaVersoes = resposta.IsSuccessStatusCode? JsonConvert.DeserializeObject<List<string>>(conteudo) : null;

                return listaVersoes != null ? listaVersoes.FirstOrDefault() : null;
            }
        }

        public string ChampionJson()
        {
            StreamReader dados = new StreamReader("wwwroot/source/Champions.txt");
            return dados.ReadToEnd();
        }
    }
}

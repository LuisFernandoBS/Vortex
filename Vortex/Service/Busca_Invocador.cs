using Newtonsoft.Json;
using System.Threading.Tasks;
using Vortex.Models;

namespace Vortex.Service
{
    public class Busca_Invocador : Api
    {
        public async Task<Invocador> GetInvocadorAsync(string Nome)
        {
            string path = "summoner/v4/summoners/by-name/" + Nome;

            var resposta = await GET(GetURI(path));
            string conteudo = resposta.Content.ReadAsStringAsync().Result;

            return resposta.IsSuccessStatusCode ? JsonConvert.DeserializeObject<Invocador>(conteudo) : null;
        }

    }
}

using System.IO;
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
    }
}

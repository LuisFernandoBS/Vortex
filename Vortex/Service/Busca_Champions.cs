﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
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

        public async Task GetVerificaDadosAsync()
        {
            string caminho = "wwwroot/source/Champions.json";
            string versao = await DdragonVersion();
            StreamReader dados = new StreamReader("wwwroot/source/Champions.json");
            List<ChampionJson> listajson = JsonConvert.DeserializeObject<List<ChampionJson>>(dados.ReadToEnd());
            dados.Close();
            if (!(listajson[0].Versao).Equals(versao))
            {
                ListaChampion listaChampion = await GetChampionsrAsync();
                await SetJsonChampionAsync(caminho, listaChampion);
            }
        }

        public async Task SetJsonChampionAsync(string caminho, ListaChampion listaChampion)
        {
            string versao = await DdragonVersion();
            StreamWriter dados = new StreamWriter(caminho);
            List<ChampionJson> listajson = new List<ChampionJson>();
            Dictionary<string, Champion> champions = listaChampion.Data;
            foreach (KeyValuePair<string, Champion> item in champions)
            {
                Champion champion = item.Value;
                ChampionJson championJson = new ChampionJson
                {
                    Key = champion.Key,
                    Name = champion.Name,
                    Versao = versao,
                };
                listajson.Add(championJson);
            }
            string json = JsonConvert.SerializeObject(listajson);
            dados.Write(json);
            dados.Close();
        }

        public async Task<string> GetImgChampionAsync(long key)
        {
            await GetChampionsrAsync();
            StreamReader dados = new StreamReader("wwwroot/source/Champions.json");
            List<ChampionJson> listajson = JsonConvert.DeserializeObject<List<ChampionJson>>(dados.ReadToEnd());
            foreach (ChampionJson champion in listajson)
            {
                if (key.Equals(champion.Key))
                {
                    return champion.Name;
                }
            }
            return null;
        }

    }
}

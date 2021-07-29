using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vortex.Models;

namespace Vortex.Service
{
    public class Busca_Partidas : Api
    {
        public async Task<List<PartidaCompleta>> GetPartidasAsync(string id_invocador)
        {
            /*Busca Partidas do invocador informado*/
            string path = "match/v4/matchlists/by-account/"+ id_invocador;
            var resposta = await GET(GetURI(path));
            string conteudo = resposta.Content.ReadAsStringAsync().Result;

            /*Verifica se a busca teve sucesso*/
            if (resposta.IsSuccessStatusCode)
            {
                /*Transforma o resultado da busca em um objeto*/ 
                var dados = JsonConvert.DeserializeObject<PartidasTotal>(conteudo);

                /*Pega as partidas do Objeto e tranforma em uma lista*/
                List<Partida> partidas = dados.matches;
                /*Cria uma instacia da classe modelo para view*/
                List<PartidaCompleta> partidasCompleta = new List<PartidaCompleta>();

                Busca_Champions buscaChampions = new Busca_Champions();

                int cont = 0;
                /*Faz um loop na lista de partidas para criar a classe modelo*/
                foreach (Partida partida in partidas)
                {
                    if (cont <= 10)
                    {
                        /*Cria um objeto com os dados de cada partida*/
                        PartidaCompleta partidaComp = new PartidaCompleta
                        {
                            champion = buscaChampions.GetImgChampion(partida.champion),
                            partida = partida.gameId,
                        };
                        /*Adiciona o objeto criado a uma lista de partidas modelo*/
                        partidasCompleta.Add(partidaComp);
                        cont += 1;
                    }
                    else
                    {
                        break;
                    }
                }
                return partidasCompleta;
            }

            return null;
        }
    }
}

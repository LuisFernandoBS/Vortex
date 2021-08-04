using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vortex.Models
{
    public class PartidaCompleta
    {
        public ChampionBasic Champion { get; set; }
        public long Partida { get; set; }
        public PartidaBasic Informacoes { get; set; }
    }
}

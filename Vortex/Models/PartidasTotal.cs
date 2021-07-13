using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vortex.Models
{
    public class PartidasTotal
    {
        public int startIndex { get; set; }
        public int endIndex { get; set; }
        public int totalGames { get; set; }
        public List<Partida> matches { get; set; }
    }
}

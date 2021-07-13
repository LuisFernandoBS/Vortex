using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vortex.Models
{
    public class Invocador
    {
        public string id { get; set; }
        public string accountId { get; set; }
        public string puuid { get; set; }
        public string name { get; set; }
        public int profileIconId { get; set; }   
        public long revisionDate { get; set; }
        public long summonerLevel { get; set; }
    }
}

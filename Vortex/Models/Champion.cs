using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vortex.Models
{
    public class Champion
    {
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string version { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public string partype { get; set; }
        public List<String> tags { get; set; }

    }
}

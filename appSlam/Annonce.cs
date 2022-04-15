using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSlam
{
    public class Annonce
    {
        public int id { get; set; }
        public string designation { get; set; }
        public string description { get; set; }
        public string datepost { get; set; }
        public string ville { get; set; }
        public string region { get; set; }
        public string codepostal { get; set; }
        public string nom { get; set; }
        public string mail { get; set; }
        public string telephone { get; set; }
        public string utilisateur { get; set; }
        public string[] type { get; set; }
        public string[] fichier { get; set; }
        public string prix { get; set; }
    }
}

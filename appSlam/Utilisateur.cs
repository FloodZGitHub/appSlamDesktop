using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSlam
{
    internal class Utilisateur
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string dateinscription { get; set; }
        public string nomEquipage { get; set; }
        public string[] messagerecu { get; set; }
        public string[] messageenvoi { get; set; }
        public string[] annonces { get; set; }
        public string user { get; set; }
    }
}

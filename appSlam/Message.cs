using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSlam
{
    internal class Message
    {
        public int id { get; set; }
        public string contenu { get; set; }
        public string dateenvoi { get; set; }
        public string userrecu { get; set; }
        public string userenvoi { get; set; }
    }
}

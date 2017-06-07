using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpDiscord.Models.User
{
    class UserGuildModel
    {
        public string id {get; set;}
        public string name {get; set;}
        public string icon {get; set;}
        public bool owner {get; set;}
        public int permissions  {get; set;}
    }
}

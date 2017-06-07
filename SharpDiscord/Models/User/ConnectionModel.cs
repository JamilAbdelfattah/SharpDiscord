using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpDiscord.Models.User
{
    class ConnectionModel
    {
        public string id   {get; set;}
        public string name {get; set;}
        public string type {get; set;}
        public bool revoked {get; set;}
        public string[] integrations {get; set;}
    }
}

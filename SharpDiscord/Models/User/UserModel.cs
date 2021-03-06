﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpDiscord.Models.User
{
    class UserModel
    {
        public string id {get; set;}
        public string username {get; set;}
        public string discriminator {get; set;}
        public string avatar {get; set;}
        public bool bot {get; set;}
        public bool mfa_enabled {get; set;}
        public bool verified {get; set;}
        public string email {get; set;}
    }
}

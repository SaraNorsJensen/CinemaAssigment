﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.UserFiles
{
    internal class User
    {
        public  Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool IsLoggedIn = false;
 
    }
}

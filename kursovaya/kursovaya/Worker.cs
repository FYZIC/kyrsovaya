using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
     class Worker
    { 
        public string Login { get; private set; }
        public string Password { get; private set; }

        public Worker(string password, string login)
        {
            Login = login;
            Password = password;
        }
    }
}

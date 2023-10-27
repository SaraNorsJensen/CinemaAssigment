using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater
{
    internal interface IUserService
    {
        List<User> GetAllUsers();
        void AddNewUSer(string Username, string Code);
    }
}

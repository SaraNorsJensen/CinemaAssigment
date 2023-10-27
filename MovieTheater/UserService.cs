using MovieTheater.UserFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater
{
    internal class UserService : IUserService
    {
        public List<User> GetAllUsers()
        {
            return AllUsers;
        }

        public void AddNewUSer(string username, string code)
        {
            AllUsers.Add(new User(){Username = username, Password = code,Id = Guid.NewGuid(), IsLoggedIn=true});
        }

        private List<User> AllUsers = new List<User>()
        {
           new User {Username="Sara", Password="123", Id=Guid.NewGuid()} 
        };
    }   
}
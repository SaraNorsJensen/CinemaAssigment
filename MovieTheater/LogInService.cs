using MovieTheater.UserFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater
{
     internal class LogInService
    {
        private static IUserService us = new UserService();
        private List<User> UsedUsers = us.GetAllUsers();

        private List<string> UsedUserNamesFunction() 
        {
            List<string> UsedUserNames = new List<string>();

            foreach (User user in UsedUsers)
            {
                UsedUserNames.Add(user.Username);
            }
            return UsedUserNames;
        } 

        public bool SignUp(string AttemptedUsername, string AttempedCode)
        {
            List<string> UsedUserNames = UsedUserNamesFunction();

            if (!UsedUserNames.Contains(AttemptedUsername))
            {
                us.AddNewUSer(AttemptedUsername, AttempedCode);
                return true;
            }

            return false;
        }

        public bool LogIn(string AttemptedUsername, string AttempedCode)
        {
            List<string> UsedUserNames = UsedUserNamesFunction();

            if (UsedUserNames.Contains(AttemptedUsername))
            {
                User TempUser = UsedUsers.Find(u => u.Username == AttemptedUsername);

                if (TempUser.Password == AttempedCode)
                {
                    TempUser.IsLoggedIn = true;

                    return true;
                }
            }

            return false;
        }
    }
}

using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Factory
{
    public class UserFactory
    {
        public static User CreateUser(string Email, string Password, string Name)
        {
            return new User
            {
                UserName = Name,
                UserEmail = Email,
                UserPassword = Password
            };
        }
    }
}
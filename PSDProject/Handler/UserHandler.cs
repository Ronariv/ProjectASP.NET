using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Handler
{
    public class UserHandler
    {
        public static dynamic IsUniqueEmail(string email)
        {
            return UserRepository.IsUniqueEmail(email);
        }

        public static dynamic IsValidCredential(string email, string password)
        {
            return UserRepository.IsValidCredential(email, password);
        }
        public static void Register(string email, string password, string name)
        {
            UserRepository.Register(email, password, name);
        }

    }
}
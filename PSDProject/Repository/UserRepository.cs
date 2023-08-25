using PSDProject.Factory;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public class UserRepository
    {
        public static Database1Entities2 db = new Database1Entities2();
        public static dynamic IsUniqueEmail(string email)
        {
            var users = db.Users.Where(x => x.UserEmail == email).FirstOrDefault();

            return users;
        }

        public static dynamic IsValidCredential(string email, string password)
        {
            var members = db.Users.Where(x => x.UserEmail == email && x.UserPassword == password).FirstOrDefault();

            return members;
        }
        public static void Register(string email, string password, string name)
        {
            db.Users.Add(UserFactory.CreateUser(email, password, name));
            db.SaveChanges();
        }
        
    }
}
using NutriGenius.Data.Entities.Abstract_Class;
using NutriGenius.Data.Entities.Enums;
using NutriGeniusForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NutriGenius.Data.Entities.Classes
{
    public class User
    {

        public int Id { get; set; }

        public string UserName { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }
        public int Height { get; set; }

        public double Weight { get; set; }

        public List<Meal> Meals { get; set; } = new();

        private string Sha256(string password)
        {
            using (SHA256 hash = SHA256.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password))
                    .Select(x => x.ToString("X2")));
            }
        }

        public void SignIn(User newUser, NutriGeniusDbContext db)
        {
            newUser.Password = Sha256(newUser.Password);
            db.Users.Add(newUser);
            db.SaveChanges();
        }

        public bool LogIn(User user, NutriGeniusDbContext db, string userName, string password)
        {
            if(db.Users.Any(x => x.Password == Sha256(password)) && db.Users.Any(x => x.UserName == userName))
            {
                return true;
            }

            return false;
            
        }
    }
}

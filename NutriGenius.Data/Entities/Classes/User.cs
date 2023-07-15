using NutriGenius.Data.Entities.Abstract_Class;
using NutriGenius.Data.Entities.Enums;
using NutriGenius.Data.Exceptions;
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


        private string password = null!;

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 60)
                {
                    if (value.Length < 8 || !(value.Any(x => Char.IsUpper(x)) &&
                            value.Any(x => Char.IsLower(x))))
                    {
                        throw new PasswordException();
                    }
                }
                password = value;
            }
        }


        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                if ((DateTime.Now.Year - value.Year) < 15)
                {
                    throw new AgeException();
                }

                birthDate = value;
            }
        }

        public Gender Gender { get; set; }

        private int height;

        public int Height
        {
            get { return height; }
            set
            {
                if (value <= 70 || value >= 250)
                {
                    throw new ArgumentOutOfRangeException();
                }
                height = value;
            }
        }


        private double weight;
        private DateTime birthDate;

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value <= 30 || value >= 300)
                {
                    throw new ArgumentOutOfRangeException();
                }
                weight = value;
            }
        }

        public List<UserFoodPortionMeal> UserFoodPortionMeals { get; set; } = new();


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

        public bool LogIn(NutriGeniusDbContext db, string userName, string password)
        {
            if (db.Users.Any(x => x.Password == Sha256(password) && x.UserName == userName))
            {
                return true;
            }

            return false;

        }
    }
}

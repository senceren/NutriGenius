using NutriGenius.Data.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriGenius.Data.Entities.Abstract_Class
{
    public abstract class Meal
    {
        public int Id { get; set; }

        public abstract string MealName { get; }

        public DateTime MealDate { get; set; }

        public double Calorie { get; set; } 



        public List<User> Users { get; set; } = new();

        public List<Food> Foods { get; set; } = new();
    }
}

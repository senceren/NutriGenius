using NutriGenius.Data.Entities.Abstract_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriGenius.Data.Entities.Classes
{
    public class UserFoodPortionMeal
    {
        
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int FoodId { get; set; } 
        public Food Food { get; set; } = null!;

        public int PortionId { get; set; }
        public Portion Portion { get; set; } = null!;

        public int MealId { get; set; }
        public Meal Meal { get; set; } = null!;

    }
}

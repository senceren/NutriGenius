using Microsoft.EntityFrameworkCore;
using NutriGenius.Data.Entities;
using NutriGenius.Data.Entities.Classes;
using NutriGenius.Data.Entities.SubClasses_Meal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace NutriGeniusForm
{
    public partial class TrendlerForm : Form
    {
        NutriGeniusDbContext db = new NutriGeniusDbContext();
        User? user = SessionManager.CurrentUser;

        public TrendlerForm()
        {
            InitializeComponent();
            LoadData();
            UserFoods(0);
            AllUserFoods(0);
            Top5Food();
            lblName.Text = user.FirstName;
        }

        private void Top5Food()
        {
            var mostFavFoods = db.UserFoodPortionMeals
                        .Include(x => x.Food)
                        .GroupBy(uf => uf.FoodId)
                        .OrderByDescending(g => g.Count())
                        .Take(5)
                        .Select(g => new { Ad = g.First().Food.FoodName, Adet = g.Count() });

            foreach (var food in mostFavFoods)
            {
                lstTop5.Items.Add(food);
            }

        }

        private void LoadData()
        {
            user = db.Users
                 .Include(u => u.UserFoodPortionMeals)
                 .ThenInclude(uf => uf.Meal)
                 .Include(u => u.UserFoodPortionMeals)
                 .ThenInclude(uf => uf.Food)
                 .FirstOrDefault(u => u.Id == user.Id)!;
        }

        private void AllUserFoods(int reportType)
        {
            lblBreakfastSum.Text = FindFoodName(FindFoodId(FindUserMealFoodPortion("Kahvaltı", 1, reportType)));
            lblLunchSum.Text = FindFoodName(FindFoodId(FindUserMealFoodPortion("Öğle Yemeği", 1, reportType)));
            lblDinnerSum.Text = FindFoodName(FindFoodId(FindUserMealFoodPortion("Akşam Yemeği", 1, reportType)));
            lblSnackSum.Text = FindFoodName(FindFoodId(FindUserMealFoodPortion("Ara Öğün", 1, reportType)));

        }

        private void UserFoods(int reportType)
        {
            lblBreakfastUser.Text = FindFoodName(FindFoodId(FindUserMealFoodPortion("Kahvaltı", 0, reportType)));
            lblLunchUser.Text = FindFoodName(FindFoodId(FindUserMealFoodPortion("Öğle Yemeği", 0, reportType)));
            lblDinnerUser.Text = FindFoodName(FindFoodId(FindUserMealFoodPortion("Akşam Yemeği", 0, reportType)));
            lblSnackUser.Text = FindFoodName(FindFoodId(FindUserMealFoodPortion("Ara Öğün", 0, reportType)));
        }

        private string FindFoodName(int foodId)
        {
            if (foodId == 0)
                return "Bu hafta öğünlerin boş :)";
            return db.Foods.Where(x => x.Id == foodId).FirstOrDefault()!.FoodName;
        }

        private List<UserFoodPortionMeal> FindUserMealFoodPortion(string mealName, int option, int reportType)
        {
            int dayNo = reportType == 0 ? -(int)DateTime.Now.DayOfWeek : -DateTime.Now.Day;

            if (option == 0)
            {
                return user.UserFoodPortionMeals.Where(x => x.Meal!.MealName == mealName).Where(x => x.Meal!.MealDate > DateTime.Now.AddDays(dayNo) && x.Meal.MealDate <= DateTime.Now).ToList();
            }
            else
            {
                var ufs = new List<UserFoodPortionMeal>();

                foreach (User user in db.Users.Include(u => u.UserFoodPortionMeals).ThenInclude(uf => uf.Meal))
                {
                    ufs.AddRange(user.UserFoodPortionMeals.Where(x => x.Meal!.MealName == mealName).Where(x => x.Meal!.MealDate > DateTime.Now.AddDays(dayNo) && x.Meal.MealDate.Day <= DateTime.Now.Day).ToList());
                }
                return ufs;
            }
        }
        private static int FindFoodId(List<UserFoodPortionMeal> ufList)
        {
            int maxCount = 0;
            int count = 0;
            int maxFoodId = 0;

            var foodList = ufList.Select(uf => uf.FoodId).ToList();

            foreach (int foodId in foodList.Distinct())
            {
                count = foodList.Count(f => f == foodId);


                if (count > maxCount)
                {
                    maxCount = count;
                    maxFoodId = foodId;
                }

            }
            return maxFoodId;
        }

        private void mtnMonthly_Click(object sender, EventArgs e)
        {
            UserFoods(1);
            AllUserFoods(1);
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            UserFoods(0);
            AllUserFoods(0);
        }
    }
}

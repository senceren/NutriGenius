using Microsoft.EntityFrameworkCore;
using NutriGenius.Data.Entities;
using NutriGenius.Data.Entities.Classes;
using NutriGenius.Data.Entities.SubClasses_Meal;
using System;
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
        User user = SessionManager.CurrentUser;
        User? dbUser;
        public TrendlerForm()
        {
            InitializeComponent();
            LoadData();
            UserFoods(-7);
            AllUserFoods(-7);

            lblName.Text = user.FirstName;
        }

        private void LoadData()
        {
            dbUser = db.Users
              .Include(u => u.UserFoodPortionMeals)
              .ThenInclude(uf => uf.Meal)
              .Include(u => u.UserFoodPortionMeals)
              .ThenInclude(uf => uf.Food)
              .Include(u => u.UserFoodPortionMeals)
              .ThenInclude(uf => uf.Portion)
              .FirstOrDefault(u => u.Id == user.Id);
        }

        private void AllUserFoods(int day)
        {
            List<UserFoodPortionMeal> breakfasts = db.UserFoodPortionMeals.Where(x => x.Meal.MealName == "Kahvaltı").Where(x => x.Meal.MealDate.Day > DateTime.Now.AddDays(day).Day && x.Meal.MealDate.Day <= DateTime.Now.Day).ToList();

            List<UserFoodPortionMeal> lunches = db.UserFoodPortionMeals.Where(x => x.Meal.MealName == "Öğle Yemeği").Where(x => x.Meal.MealDate.Day > DateTime.Now.AddDays(day).Day && x.Meal.MealDate.Day <= DateTime.Now.Day).ToList();

            List<UserFoodPortionMeal> dinners = db.UserFoodPortionMeals.Where(x => x.Meal.MealName == "Akşam Yemeği").Where(x => x.Meal.MealDate.Day > DateTime.Now.AddDays(day).Day && x.Meal.MealDate.Day <= DateTime.Now.Day).ToList();

            List<UserFoodPortionMeal> snacks = db.UserFoodPortionMeals.Where(x => x.Meal.MealName == "Ara Öğün").Where(x => x.Meal.MealDate.Day > DateTime.Now.AddDays(day).Day && x.Meal.MealDate.Day <= DateTime.Now.Day).ToList();

            int maxBreakfastFoodId = FindFoodId(breakfasts);
            int maxLunchFoodId = FindFoodId(lunches);
            int maxDinnerFoodId = FindFoodId(dinners);
            int maxSnackFoodId = FindFoodId(snacks);

            lblBreakfastSum.Text = db.UserFoodPortionMeals.Where(x => x.FoodId == maxBreakfastFoodId).First().Food.FoodName;

            lblLunchSum.Text = db.UserFoodPortionMeals.Where(x => x.FoodId == maxLunchFoodId).First().Food.FoodName;

            lblDinnerSum.Text = db.UserFoodPortionMeals.Where(x => x.FoodId == maxDinnerFoodId).First().Food.FoodName;

            lblSnackSum.Text = db.UserFoodPortionMeals.Where(x => x.FoodId == maxSnackFoodId).First().Food.FoodName;

        }
        private void UserFoods(int day)
        {
            List<UserFoodPortionMeal> ufListBr = dbUser!.UserFoodPortionMeals.Where(x => x.Meal.MealName == "Kahvaltı"
           && x.Meal.MealDate.Day > DateTime.Now.AddDays(day).Day && x.Meal.MealDate.Day <= DateTime.Now.Day).ToList();

            List<UserFoodPortionMeal> ufListLn = dbUser.UserFoodPortionMeals.Where(x => x.Meal.MealName == "Öğle Yemeği"
           && x.Meal.MealDate.Day > DateTime.Now.AddDays(day).Day && x.Meal.MealDate.Day <= DateTime.Now.Day).ToList();

            List<UserFoodPortionMeal> ufListDn = dbUser.UserFoodPortionMeals.Where(x => x.Meal.MealName == "Akşam Yemeği"
           && x.Meal.MealDate.Day > DateTime.Now.AddDays(day).Day && x.Meal.MealDate.Day <= DateTime.Now.Day).ToList();

            List<UserFoodPortionMeal> ufListSn = dbUser.UserFoodPortionMeals.Where(x => x.Meal.MealName == "Ara Öğün"
           && x.Meal.MealDate.Day > DateTime.Now.AddDays(day).Day && x.Meal.MealDate.Day <= DateTime.Now.Day).ToList();

            int maxBreakfastFoodId = FindFoodId(ufListBr);
            int maxLunchFoodId = FindFoodId(ufListLn);
            int maxDinnerFoodId = FindFoodId(ufListDn);
            int maxSnackFoodId = FindFoodId(ufListSn);

            lblBreakfastUser.Text = dbUser.UserFoodPortionMeals.Where(x => x.FoodId == maxBreakfastFoodId).First().Food.FoodName;

            lblLunchUser.Text = dbUser.UserFoodPortionMeals.Where(x => x.FoodId == maxLunchFoodId).First().Food.FoodName;

            lblDinnerUser.Text = dbUser.UserFoodPortionMeals.Where(x => x.FoodId == maxDinnerFoodId).First().Food.FoodName;

            lblSnackUser.Text = dbUser.UserFoodPortionMeals.Where(x => x.FoodId == maxSnackFoodId).First().Food.FoodName;

        }

        private static int FindFoodId(List<UserFoodPortionMeal> ufList)
        {
            int maxCount = 0;
            int count = 0;
            int maxFoodId = 0;

            for (int i = 0; i < ufList.Count - 1; i++)
            {
                count = 0;

                for (int j = i + 1; j < ufList.Count; j++)
                {
                    if (ufList[i].FoodId == ufList[j].FoodId)
                    {
                        count++;
                    }

                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxFoodId = ufList[i].FoodId;
                }

            }

            if (maxFoodId == 0)
            {
                maxFoodId = ufList[0].FoodId;
            }

            return maxFoodId;
        }



        private void mtnMonthly_Click(object sender, EventArgs e)
        {
            UserFoods(-30);
            AllUserFoods(-30);

        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            UserFoods(-7);
            AllUserFoods(-7);
        }
    }
}

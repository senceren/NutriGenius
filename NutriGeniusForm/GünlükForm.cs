using NutriGenius.Data.Entities.Abstract_Class;
using NutriGenius.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NutriGenius.Data.Entities.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace NutriGeniusForm
{
    public partial class GünlükForm : Form
    {
        NutriGeniusDbContext db = new NutriGeniusDbContext();
        NutriGenius.Data.Entities.Classes.User user = SessionManager.CurrentUser;
        Meal meal;
        NutriGenius.Data.Entities.Classes.User? dbUser;
        public GünlükForm()
        {
            Connect();
            InitializeComponent();
            ListOfMeals();

        }

        private void ListCalories(List<UserFoodPortionMeal> userMeals)
        {
            if (userMeals.Count == 0)
            {
                lblBreakfastCalorie.Text = lblLunchCalorie.Text = lblDinnerCalorie.Text = lblSnackCalorie.Text = lblTotalMealCalorie.Text = userMeals.Count.ToString();
                return;
            }

            lblBreakfastCalorie.Text = userMeals.FirstOrDefault(um => um.Meal?.MealName == "Kahvaltı")?.Meal?.Calorie.ToString();
            lblLunchCalorie.Text = userMeals.FirstOrDefault(um => um.Meal?.MealName == "Öğle Yemeği")?.Meal?.Calorie.ToString();
            lblDinnerCalorie.Text = userMeals.FirstOrDefault(um => um.Meal?.MealName == "Akşam Yemeği")?.Meal?.Calorie.ToString();
            lblSnackCalorie.Text = userMeals.FirstOrDefault(um => um.Meal?.MealName == "Ara Öğün")?.Meal?.Calorie.ToString();
            lblTotalMealCalorie.Text = userMeals.Sum(uf => uf.Portion!.Calorie * uf.Portion.Amount).ToString();
        }

        private void ListOfMeals()
        {

            lstBreakfast.Items.Clear();
            lstLunch.Items.Clear();
            lstDinner.Items.Clear();
            lstSnack.Items.Clear();

            var userMeal = dbUser.UserFoodPortionMeals.Where(uf => uf.Meal?.MealDate == dtpDate.Value.Date).ToList();

            foreach (var item in userMeal.Where(x => x.Meal.MealName == "Kahvaltı"))
            {
                lstBreakfast.Items.Add(item.Food.FoodName);
            }

            foreach (var item in userMeal.Where(x => x.Meal.MealName == "Ara Öğün"))
            {
                lstSnack.Items.Add(item.Food.FoodName);
            }

            foreach (var item in userMeal.Where(x => x.Meal.MealName == "Öğle Yemeği"))
            {
                lstLunch.Items.Add(item.Food.FoodName);
            }

            foreach (var item in userMeal.Where(x => x.Meal.MealName == "Akşam Yemeği"))
            {
                lstDinner.Items.Add(item.Food.FoodName);
            }

            ListCalories(userMeal);

        }

        private void Connect()
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

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ListOfMeals();
        }
    }
}

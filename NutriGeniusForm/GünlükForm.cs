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

        private void ListOfMeals()
        {

            lstBreakfast.Items.Clear();
            lstLunch.Items.Clear();
            lstDinner.Items.Clear();
            lstSnack.Items.Clear();

            foreach (var item in dbUser.UserFoodPortionMeals.Where(x => x.Meal.MealName == "Kahvaltı" && x.Meal.MealDate == dtpDate.Value.Date))
            {
                lstBreakfast.Items.Add(item.Food.FoodName);
            }

            foreach (var item in dbUser.UserFoodPortionMeals.Where(x => x.Meal.MealName == "Ara Öğün" && x.Meal.MealDate == dtpDate.Value.Date))
            {
                lstSnack.Items.Add(item.Food.FoodName);
            }

            foreach (var item in dbUser.UserFoodPortionMeals.Where(x => x.Meal.MealName == "Öğle Yemeği" && x.Meal.MealDate == dtpDate.Value.Date))
            {
                lstLunch.Items.Add(item.Food.FoodName);
            }

            foreach (var item in dbUser.UserFoodPortionMeals.Where(x => x.Meal.MealName == "Akşam Yemeği" && x.Meal.MealDate == dtpDate.Value.Date))
            {
                lstDinner.Items.Add(item.Food.FoodName);
            }



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

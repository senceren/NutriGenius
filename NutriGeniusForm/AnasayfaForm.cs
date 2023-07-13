using Microsoft.EntityFrameworkCore;
using NutriGenius.Data.Entities;
using NutriGenius.Data.Entities.Abstract_Class;
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

namespace NutriGeniusForm
{
    public partial class AnasayfaForm : Form
    {
        NutriGeniusDbContext db = new NutriGeniusDbContext();
        User user = SessionManager.CurrentUser;
        User dbUser;
        Meal? meal;

        public AnasayfaForm()
        {
            InitializeComponent();
            lblName.Text = user.FirstName;
            

        }


        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            meal = new Breakfast() { MealDate = DateTime.Now.Date };

            CheckMeal();

            SessionManager.CurrentMeal = meal;
            new YemekEkleForm().ShowDialog();


        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            meal = new Lunch() { MealDate = DateTime.Now.Date  };

            CheckMeal();

            SessionManager.CurrentMeal = meal;
            new YemekEkleForm().ShowDialog();
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            meal = new Dinner() { MealDate = DateTime.Now.Date };

            CheckMeal();

            SessionManager.CurrentMeal = meal;
            new YemekEkleForm().ShowDialog();
        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            meal = new Snack() { MealDate = DateTime.Now.Date };

            CheckMeal();

            SessionManager.CurrentMeal = meal;
            new YemekEkleForm().ShowDialog();
        }

        private void CheckMeal()
        {
            bool shouldAddMeal = true;
            dbUser = db.Users.Include(x => x.Meals).FirstOrDefault(x => x.UserName == user.UserName)!;

            if (dbUser.Meals.Any(m => m.MealName.Equals(meal!.MealName))
                && dbUser.Meals.Any(m => m.MealDate.Date == meal!.MealDate.Date))
            {
                shouldAddMeal = false;
            }

            if (shouldAddMeal)
            {
                dbUser.Meals.Add(meal);
                db.SaveChanges();
            }
        }
    }
}

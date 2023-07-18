﻿using Microsoft.EntityFrameworkCore;
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
        User? dbUser;
        Meal meal;
        List<UserFoodPortionMeal> userMeals;

        public AnasayfaForm()
        {
            LoadData();
            InitializeComponent();
            ShowUserName();
            ShowMealCalorie();
            LoadGlasses();

        }

        private void LoadData()
        {
            dbUser = db.Users
                .Include(u => u.UserFoodPortionMeals)
                .ThenInclude(uf => uf.Meal)
                .Include(u => u.UserFoodPortionMeals)
                .ThenInclude(uf => uf.Portion)
                .FirstOrDefault(u => u.Id == user.Id);
        }

        private void LoadGlasses()
        {

            lblWater.Text = (dbUser.TotalGlass * 0.2).ToString("F1");

            for (int i = 0; i < 10; i++)
            {
                var lvi = new ListViewItem();

                if (i < dbUser.TotalGlass)
                {
                    lvi.ImageKey = "dolu.png";
                    lvwWater.Items.Add(lvi);
                }
                else
                {
                    lvi.ImageKey = "bos.png";
                    lvwWater.Items.Add(lvi);
                }

            }

        }

        private void ShowUserName()
        {
            lblName.Text = user.FirstName;
        }

        private void ShowMealCalorie()
        {
            userMeals = dbUser!.UserFoodPortionMeals.Where(uf => uf.Meal?.MealDate == dtpDate.Value.Date).ToList();

            if (userMeals.Count() == 0)
                return;

            lblBreakfastCalorie.Text = userMeals.FirstOrDefault(um => um.Meal?.MealName == "Kahvaltı")?.Meal?.Calorie.ToString();
            lblLunchCalorie.Text = userMeals.FirstOrDefault(um => um.Meal?.MealName == "Öğle Yemeği")?.Meal?.Calorie.ToString();
            lblDinnerCalorie.Text = userMeals.FirstOrDefault(um => um.Meal?.MealName == "Akşam Yemeği")?.Meal?.Calorie.ToString();
            lblSnackCalorie.Text = userMeals.FirstOrDefault(um => um.Meal?.MealName == "Ara Öğün")?.Meal?.Calorie.ToString();
            lblSumCalorie.Text = userMeals.Sum(um => um.Portion?.Calorie * um.Portion.Amount).ToString();
        }


        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            meal = userMeals?.FirstOrDefault(uf => uf.Meal!.MealName == "Kahvaltı")?.Meal;

            if (meal == null)
            {
                meal = new Breakfast() { MealDate = DateTime.Now.Date };
            }

            CheckMeal(meal);

        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            meal = userMeals?.FirstOrDefault(uf => uf.Meal!.MealName == "Öğle Yemeği")?.Meal;

            if (meal == null)
            {
                meal = new Lunch() { MealDate = DateTime.Now.Date };
            }

            CheckMeal(meal);
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            meal = userMeals?.FirstOrDefault(uf => uf.Meal!.MealName == "Akşam Yemeği")?.Meal;

            if (meal == null)
            {
                meal = new Dinner() { MealDate = DateTime.Now.Date };
            }

            CheckMeal(meal);
        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            meal = userMeals?.FirstOrDefault(uf => uf.Meal!.MealName == "Ara Öğün")?.Meal;

            if (meal == null)
            {
                meal = new Snack() { MealDate = DateTime.Now.Date };
            }

            CheckMeal(meal);
        }

        private void CheckMeal(Meal meal)
        {
            SessionManager.CurrentMeal = meal;
            db.Entry(meal).State = EntityState.Detached; // takip etmeyi bırak
            db.SaveChanges();
            Close();
            new YemekEkleForm().ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new ProfilForm().ShowDialog();
        }

        private void lvwWater_DoubleClick(object sender, EventArgs e)
        {

            double water = dbUser.TotalGlass * 0.2;
            var lvwClicked = lvwWater.SelectedItems[0];

            if (lvwClicked.ImageKey == "bos.png")
            {
                water += 0.2;
                lvwClicked.ImageKey = "dolu.png";
                lblWater.Text = water.ToString("F1");
                dbUser.TotalGlass++;
            }
            else
            {
                water -= 0.2;
                lvwClicked.ImageKey = "bos.png";
                lblWater.Text = water.ToString("F1");
                dbUser.TotalGlass--;
            }

            if (water == 2)
            {
                lblTebrik.Visible = true;
            }
            else
            {
                lblTebrik.Visible = false;
            }

            db.SaveChanges();
        }
    }
}

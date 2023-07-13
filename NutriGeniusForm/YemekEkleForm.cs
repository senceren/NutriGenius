using Microsoft.EntityFrameworkCore;
using NutriGenius.Data.Entities;
using NutriGenius.Data.Entities.Abstract_Class;
using NutriGenius.Data.Entities.Classes;
using NutriGenius.Data.Entities.Enums;
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
    public partial class YemekEkleForm : Form
    {
        NutriGeniusDbContext db = new NutriGeniusDbContext();
        User user = SessionManager.CurrentUser;
        Meal meal = SessionManager.CurrentMeal;
        List<Food> selectedFoods = new List<Food>();

        FoodCategory foodCategory;
        Food food;
        Portion portion;
        double piece;

        public YemekEkleForm()
        {
            InitializeComponent();
            Connect();
            ListFoodCategories();
            selectedFoods.AddRange(db.Users.Include(u => u.Meals).ThenInclude(m => m.Foods).ThenInclude(m => m.Portions).FirstOrDefault(u => u.Id == user.Id).Meals.FirstOrDefault(m => m.MealName == meal.MealName).Foods);
            UpdateFoods();

            lblMealName.Text = meal.MealName;

        }

        private void Connect()
        {
            db.Entry(user).State = EntityState.Unchanged;
            db.Entry(user).Collection(x => x.Meals).Load();
        }

        private void ListPortions()
        {
            cbPortions.DataSource = null;
            Food food = (Food)cbFoods.SelectedItem;
            cbPortions.DataSource = (db.Foods.Include(x => x.Portions).First(x => x.Id == food.Id))
                .Portions.ToList();


        }

        private void ListFoods()
        {
            cbFoods.DataSource = null;
            cbFoods.DataSource = db.Foods
                .Where(x => x.FoodCategory.Id == ((FoodCategory)cbFoodCategory.SelectedItem).Id)
                .ToList();
        }

        private void ListFoodCategories()
        {
            cbFoodCategory.DataSource = null;
            cbFoodCategory.DataSource = db.FoodCategories.ToList();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Connect();

            DialogResult sonuc = MessageBox.Show($"Yemekleri {meal.MealName} öğünüze eklemek istediğinize emin misiniz?", "Ekleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);



            if (sonuc == DialogResult.Yes)
            {
                // öğüne daha önce yemek eklendiyse caloriyi üstüne ekle

                var x = user.Meals.First(x => x.MealName == meal.MealName);

                x.Foods.AddRange(selectedFoods);



                foreach (var item in x.Foods)
                {
                    foreach (var portion in item.Portions)
                    {
                        if (!portion.IsIncluded)
                        {
                            x.Calorie += portion.Calorie;
                            portion.IsIncluded = true;
                        }

                    }
                }

                //x.Calorie += x.Foods.Sum(x => x.Portions.FirstOrDefault().Calorie);

                db.SaveChanges();
                MessageBox.Show("Yemekler başarıyla eklenmiştir.");
            }


        }

        private void cbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFoodCategory.SelectedIndex == -1)
                return;

            ListFoods();

        }


        private void btnAddFood_Click(object sender, EventArgs e)
        {
            new KullanıcıYemekEkleForm().ShowDialog();
        }

        private void cbFoods_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFoods.SelectedIndex == -1) return;

            ListPortions();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            foodCategory = (FoodCategory)cbFoodCategory.SelectedItem;
            food = (Food)cbFoods.SelectedItem;
            portion = (Portion)cbPortions.SelectedItem;
            piece = (double)nudPiece.Value;

            portion.Amount = piece;


            Food selectedFood = new Food()
            {
                FoodName = food.FoodName,
                FoodCategoryId = foodCategory.Id,
            };

            selectedFood.Portions.Add(portion);

            if (selectedFoods.Any(x => x.FoodName == selectedFood.FoodName))
            {
                MessageBox.Show("Eklemek istediğiniz ürün listede mevcuttur.");
                return;
            }

            selectedFoods.Add(selectedFood);

            UpdateFoods();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFoods.SelectedRows.Count < 0)
                return;

            string deletedFoodName = dgvFoods.SelectedRows[0].Cells[0].Value.ToString()!;
            Food deletedFood = selectedFoods.FirstOrDefault(x => x.FoodName == deletedFoodName)!;


            DialogResult dialogResult = MessageBox.Show("Seçili ürünü silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dialogResult == DialogResult.Yes)
            {
                selectedFoods.Remove(deletedFood);
                UpdateFoods();
            }

        }

        private void UpdateFoods()
        {
            dgvFoods.DataSource = null;
            dgvFoods.DataSource = selectedFoods.Select(f => new
            {
                f.FoodName,
                FoodCalorie = f.Portions.First().Calorie * f.Portions.FirstOrDefault().Amount
            }).ToList();
        }

    }
}

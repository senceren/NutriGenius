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
        List<UserFoodPortionMeal> selectedUfs = new List<UserFoodPortionMeal>();

        Food food;
        Portion portion;
        double piece;

        public YemekEkleForm()
        {
            Connect();
            InitializeComponent();
            ListFoodCategories();
            lblMealName.Text = meal.MealName;
            UpdateFoods();
        }

        private void Connect()
        {
            if (db.Entry(meal).State == EntityState.Detached) // burda takip et
            {
                db.Attach(meal);
            }

            selectedUfs.AddRange(db.UserFoodPortionMeals.Include(uf => uf.User).Include(uf => uf.Meal).Include(uf => uf.Food).Include(uf => uf.Portion)
               .Where(uf => uf.UserId == user.Id && uf.MealId == meal.Id && uf.Meal!.MealDate == meal.MealDate));

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
            food = (Food)cbFoods.SelectedItem;
            portion = (Portion)cbPortions.SelectedItem;
            piece = (double)nudPiece.Value;
            portion.Amount = piece;

            if (selectedUfs.Any(x => x.FoodId == food.Id))
            {
                MessageBox.Show("Eklemek istediğiniz ürün listede mevcuttur.");
                return;
            }

            selectedUfs.Add(new UserFoodPortionMeal()
            {
                User = db.Users.FirstOrDefault(u => u.Id == user.Id),
                UserId = db.Users.FirstOrDefault(u => u.Id == user.Id)!.Id,
                Meal = meal,
                MealId = meal.Id,
                Food = food,
                FoodId = food!.Id,
                Portion = portion,
                PortionId = portion.Id
            });

            UpdateFoods();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFoods.SelectedRows.Count < 0)
                return;


            UserFoodPortionMeal deletedUfpm = (UserFoodPortionMeal)dgvFoods.SelectedRows[0].DataBoundItem;


            DialogResult dialogResult = MessageBox.Show("Seçili ürünü silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dialogResult == DialogResult.Yes)
            {
                selectedUfs.Remove(deletedUfpm);
                UpdateFoods();
            }

        }

        private void UpdateFoods()
        {
            dgvFoods.DataSource = null;
            dgvFoods.DataSource = selectedUfs.Select(f => new
            {
                f.Food.FoodName,
                FoodCalorie = (f.Portion.Calorie) * (f.Portion.Amount)
            }).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult result = MessageBox.Show($"Yemekleri {meal.MealName} öğünüze eklemek istediğinize emin misiniz?", "Ekleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);


                if (result == DialogResult.No) return;

                meal.UserFoodPortionMeals.RemoveAll(uf => uf.UserId == user.Id);
                meal.UserFoodPortionMeals.AddRange(selectedUfs);
                meal.Calorie = 0;
                meal.Calorie += meal.UserFoodPortionMeals.Sum(uf => uf.Portion!.Calorie * uf.Portion.Amount);

                db.SaveChanges();
                MessageBox.Show($"Seçili yemekler {meal.MealName} öğününe başarıyla eklenmiştir.");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void cbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFoodCategory.SelectedIndex == -1)
                return;

            ListFoods();
        }

        private void YemekEkleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            new AnasayfaForm().ShowDialog();
        }
    }
}

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
    public partial class KullanıcıYemekEkleForm : Form
    {
        NutriGeniusDbContext db = new NutriGeniusDbContext();
        public KullanıcıYemekEkleForm()
        {
            InitializeComponent();
            ListCategories();
        }

        private void ListCategories()
        {
            cbFoodCategories.DataSource = null;
            cbFoodCategories.DataSource = db.FoodCategories.ToList();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                string foodName = txtFoodName.Text;
                int foodCategoryId = ((FoodCategory)cbFoodCategories.SelectedItem).Id;
                string calorie = txtCalorie.Text;

                if(string.IsNullOrEmpty(foodName) || string.IsNullOrEmpty(calorie) ||
                    cbFoodCategories.SelectedIndex == -1 || cbPortions.SelectedIndex == -1)
                {
                    MessageBox.Show("Tüm alanların doldurulması zorunludur.");
                    return;
                }

                if(db.Foods.Any(x => x.FoodName.ToLower().Equals(foodName.ToLower())))
                {
                    MessageBox.Show("Bu yemek zaten mevcut!");
                    return;
                }

                db.Foods.Add(new Food()
                {
                    FoodName = foodName,
                    FoodCategoryId = foodCategoryId,
                    Portions = new List<Portion>()
                    {
                            new Portion() { Amount = 1, Unit = (Unit)cbPortions.SelectedIndex, Calorie = Convert.ToDouble(calorie) }
                    }
                }
                );

                db.SaveChanges();
                MessageBox.Show("Yemek başarıyla eklenmiştir.");
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Kalori sayısal bir değer olmak zorundadır.");
            }



        }
    }
}

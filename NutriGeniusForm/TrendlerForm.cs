using Microsoft.EntityFrameworkCore;
using NutriGenius.Data.Entities;
using NutriGenius.Data.Entities.Classes;
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
    public partial class TrendlerForm : Form
    {
        NutriGeniusDbContext db = new NutriGeniusDbContext();
        User user = SessionManager.CurrentUser;
        public TrendlerForm()
        {
            InitializeComponent();
            // kullacının bir haftada sabah en cok yediği yemek 
            // kullacının bir ayda sabah en cok yediği yemek 

            // tüm kullacının bir haftada sabah en cok yediği yemek 
            // tüm kullacının bir ayda sabah en cok yediği yemek 

            // tüm kullanıcılarda tüm öğünlerde yenen top 5 yemek 

            Top5Food();
            lblName.Text = user.FirstName;
        }

        private void Top5Food()
        {
            Dictionary<int, int> IdyemekTekrarı = new Dictionary<int, int>();
            

            foreach (var item in db.Users.Include(x => x.UserFoodPortionMeals))
            {
                foreach (var item1 in item.UserFoodPortionMeals)
                {
                    int Id = item1.FoodId;
                    int yemekTekrarı = 1;
                    // yemeklere gezicez. her yemeğin ıdsini ve adetini tutucaz.
                    // ıdsi tüm geçmiş
                    IdyemekTekrarı.Add(Id, yemekTekrarı);

                }

            }

            //dgvTop5.DataSource = IdyemekTekrarı.GroupBy(x => x.Key).ToDictionary(g => g.Sum(x => x.Value)).OrderByDescending(x => x.Value).Take(5).ToList();


        }
    }
}

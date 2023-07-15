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
    public partial class ProfilForm : Form
    {
        User user = SessionManager.CurrentUser;
        NutriGeniusDbContext db = new NutriGeniusDbContext();
        public ProfilForm()
        {
            InitializeComponent();
            PersonelInformations();
            Connect();
        }

        private void Connect()
        {
            db.Entry(user).State = EntityState.Unchanged;
           
        }

        private void PersonelInformations()
        {
            lblName.Text = user.FirstName;

            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtHeight.Text = user.Height.ToString();
            txtWeight.Text = user.Weight.ToString();
            txtBirthDate.Text = user.BirthDate.ToString("dd/MM/yyyy");
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            new GünlükForm().ShowDialog();
        }

        private void btnTrendies_Click(object sender, EventArgs e)
        {
            new TrendlerForm().ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFirstName.Text) ||
                   string.IsNullOrEmpty(txtLastName.Text) ||                 
                   string.IsNullOrEmpty(txtHeight.Text) ||
                   string.IsNullOrEmpty(txtWeight.Text))
                  
                {
                    MessageBox.Show("İlgili alanlar boş olamaz!");
                    return;
                }

                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.Height = Convert.ToInt32(txtHeight.Text);
                user.Weight = Convert.ToInt32(txtWeight.Text);

                DialogResult dialogResult = MessageBox.Show("Değişiklikleri kaydetmek istediğinize emin misiniz?", "Kayıt Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (dialogResult == DialogResult.Yes)
                {
                    db.SaveChanges();
                    MessageBox.Show("Değişiklikler başarıyla kaydedilmiştir.");
                }


            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(FormatException))
                {
                    MessageBox.Show("Boy/kilo girişi sayısal değer olmalıdır!");
                }

                else if (ex.GetType() == typeof(ArgumentOutOfRangeException))
                {
                    MessageBox.Show("Boy veya Kilo hatalıdır!");
                }
                else
                {
                    MessageBox.Show("Hata Oluştu!");
                }



            }

        }
    }
}

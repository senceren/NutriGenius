
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
    public partial class GirisForm : Form
    {
        NutriGeniusDbContext db = new NutriGeniusDbContext();
        public GirisForm()
        {
            InitializeComponent();
            txtUserName.Text = "yaziciefkan@yandex.com";
            txtPassword.Text = "1233456Aa";
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text == "" || txtUserName.Text == "")
            {
                MessageBox.Show("Alanların doldurulması zorunludur.");
            }

            User? logInUser = new User();
            
            if (logInUser.LogIn(db, txtUserName.Text, txtPassword.Text))

            {
                logInUser = db.Users.FirstOrDefault(x => x.UserName == txtUserName.Text);
                SessionManager.CurrentUser = logInUser!;
                new AnasayfaForm().ShowDialog();
            }
            else
            {
                MessageBox.Show("Şifre veya kullanıcı hatalıdır!");
            }


        }
    }
}

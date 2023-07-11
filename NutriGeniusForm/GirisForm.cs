
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
        public GirisForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            using(var db = new NutriGeniusDbContext())
            {
                User logInUser = new User();

                if(logInUser.LogIn(logInUser, db, txtUserName.Text, txtPassword.Text))
              
                {
                    Form form = new AnasayfaForm();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Şifre veya kullanıcı hatalıdır!");
                }

            }
        }
    }
}

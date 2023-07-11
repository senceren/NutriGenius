﻿using NutriGenius.Data.Entities.Classes;
using NutriGenius.Data.Exceptions;
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
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            using (var db = new NutriGeniusDbContext())
            {
                try
                {
                    if (string.IsNullOrEmpty(txtFirstName.Text) ||
                       string.IsNullOrEmpty(txtLastName.Text) ||
                       string.IsNullOrEmpty(txtUserName.Text) ||
                       string.IsNullOrEmpty(txtPassword.Text) ||
                       string.IsNullOrEmpty(txtHeight.Text) ||
                       string.IsNullOrEmpty(txtWeight.Text) ||
                       (rbFemale.Checked! && rbMale.Checked!) ||
                       dtpBirthDate.Value > DateTime.Now ||
                       cbMail.SelectedIndex == -1)
                    {
                        MessageBox.Show("Yıldızlı alanların doldurulması zorunludur.");
                        return;
                    }

                    if (txtUserName.Text.Contains("@"))
                    {
                        MessageBox.Show("Kullanıcı adı birden fazla \"@\" içeremez!");
                        return;
                    }

                    if (db.Users.Any(x =>
                    x.UserName == string.Join
                    ("", txtUserName.Text, cbMail.SelectedItem.ToString())))
                    {
                        MessageBox.Show("Girdiğiniz kullanıcı adı sistemde mevcuttur.");
                        return;
                    }


                    User newUser = new User()
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Gender = rbFemale.Checked ? NutriGenius.Data.Entities.Enums.Gender.Female :
                         NutriGenius.Data.Entities.Enums.Gender.Male,
                        BirthDate = dtpBirthDate.Value,
                        Height = Convert.ToInt32(txtHeight.Text),
                        Weight = Convert.ToInt64(txtWeight.Text),
                        UserName = string.Join("", txtUserName.Text, cbMail.SelectedItem.ToString()),
                        Password = txtPassword.Text,
                    };

                    newUser.SignIn(newUser, db);
                    MessageBox.Show("Kayıt başarıyla oluşturulmuştur.");
                }
                catch (Exception ex)
                {
                    if (ex.GetType() == typeof(FormatException))
                    {
                        MessageBox.Show("Boy/kilo girişi sayısal değer olmalıdır!");
                    }

                    if (ex.GetType() == typeof(ArgumentOutOfRangeException))
                    {
                        MessageBox.Show("Boy veya Kilo hatalıdır!");
                    }

                    if (ex.GetType() == typeof(PasswordException))
                    {
                        MessageBox.Show("Şifre uzunluğu en az 8 karakter olmalı ve en az 1 adet büyük ve 1 küçük harf içermelidir.");
                    }

                }

            }

        }
    }
}

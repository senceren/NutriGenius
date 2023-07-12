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
    public partial class AcilisForm : Form
    {
        public AcilisForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            new KayitForm().ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            new GirisForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AnasayfaForm().ShowDialog();    
        }
    }
}

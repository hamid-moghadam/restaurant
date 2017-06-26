using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            string user = txtResUser.Text;
            string pass = txtResPass.Text;
            DomainClasses.Restaurant current = Service.GetCurrentRestaurant();
            bool login = current.CanLogin(user, pass);
            if (login)
            {
                Service.ChangeForm(new Main(),this);
            }
            else
                MessageBox.Show("یوزرنیم یا پسور اشتباه است");
        }
    }
}

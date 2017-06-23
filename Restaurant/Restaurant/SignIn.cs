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
            DomainClasses.Restaurant current = DomainClasses.Restaurant.GetCurrent();
            MessageBox.Show(current.CanLogin(user, pass) ? "خوش آمدی" : "یوزرنیم یا پسور اشتباه است");
        }
    }
}

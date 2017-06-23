using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainClasses.Hash;

namespace Restaurant
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtResName.Text;
            string owner = txtResOwner.Text;
            string user = txtResUser.Text;
            string pass = txtResPass.Text;
            int tax = 0;
            int.TryParse(txtResTax.Text,out tax);
            DomainClasses.Restaurant r = new DomainClasses.Restaurant(name,owner,user,pass,tax);
            string message = r.Save();
            MessageBox.Show(message);
        }

        private void SignUp_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            if (e.InputLanguage.Culture.TwoLetterISOLanguageName == "en")
                foreach (var control in Controls.OfType<TextBox>())
                {
                    control.TextAlign = HorizontalAlignment.Left;
                }
            else
                foreach (var control in Controls.OfType<TextBox>())
                {
                    control.TextAlign = HorizontalAlignment.Right;
                }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyV2
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login l = new Login();  
            l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(firstName.Text == "")
            {
                MessageBox.Show("Please provide a First Name");
                return;
            }
            if (lastName.Text == "")
            {
                MessageBox.Show("Please provide a Last Name");
                return;
            }
            if (userName.Text == "")
            {
                MessageBox.Show("Please provide a UserName");
                return;
            }
            if (emailAddress.Text == "")
            {
                MessageBox.Show("Please provide an Email Address");
                return;
            }
            if (password.Text == "")
            {
                MessageBox.Show("Please provide a Password");
                return;
            }
            if (password2.Text == "")
            {
                MessageBox.Show("Please confirm Password");
                return;
            }

           if(!IsValidEmail(emailAddress.Text))
            {
                MessageBox.Show("Invalid Email");
                return;
            }

           if(password.Text != password2.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            Login l = new Login();
            l.Show();
            this.Hide();
        }

        public static bool IsValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}

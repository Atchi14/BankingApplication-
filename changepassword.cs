using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class changepassword : Form
    {
        public changepassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bankingdbEntities bdb = new bankingdbEntities();

            if (oldpass.Text != string.Empty || newpass.Text != string.Empty || repass.Text == string.Empty)
            {
         Admin  ad = bdb.Admins.FirstOrDefault(a => a.Username.Equals(usertxt.Text));
                if (ad != null)
                {
                    if (ad.Password.Equals(oldpass.Text))
                    {
                        ad.Password = newpass.Text;

                        bdb.Admins.Add(ad);
                        bdb.SaveChanges();


                        MessageBox.Show("Password Change Sucessfully");

                    }
                    else
                    {
                        MessageBox.Show("Password incorrect");
                    }
                }

            }
        }

    }
}
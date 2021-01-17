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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bankingdbEntities dbb = new bankingdbEntities();

            if (usrtxt.Text!=string.Empty || passtxt.Text!=string.Empty)
            {
                var user1 = dbb.Admins.FirstOrDefault(a => a.Username.Equals(usrtxt.Text));
                if (user1!=null)
                {
                    if (user1.Password.Equals(passtxt.Text))
                    {
                        Menu m1 = new Menu();
                        m1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("incorrect  password");
                    }
                }
                else
                {
                    MessageBox.Show("null value");

                }

            }
            else
            {
                MessageBox.Show("please enter a valid username");
            }
        }
    }
}

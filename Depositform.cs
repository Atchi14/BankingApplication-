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
    public partial class Depositform : Form
    {
        public Depositform()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loaddate()
        {
           label2.Text = DateTime.Now.ToString("MM/dd/yyyy");

            //throw new NotImplementedException();
        }

        private void loadmode()
        {
          comboBox1.Items.Add("Cash");
           comboBox1.Items.Add("Chque");
            //throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         bankingdbEntities bdb = new bankingdbEntities();
            decimal b = Convert.ToDecimal(textBox1.Text);
            var item = (from u in bdb.UserAccounts
                        where u.Account_no == b
                        select u).FirstOrDefault();

           textBox2.Text = item.Name;
           textBox3.Text = Convert.ToString(item.Balance);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bankingdbEntities bdb = new bankingdbEntities();

           NewAccount nc = new NewAccount();
          debit dp = new debit();
            dp.Date = label2.Text;
            dp.Accountno = Convert.ToDecimal(textBox1.Text);
            dp.Name = textBox2.Text;
            dp.Oldbalance = Convert.ToDecimal(textBox3.Text);
            dp.Mode = comboBox1.SelectedItem.ToString();
            dp.Debamount = Convert.ToDecimal(textBox4.Text);
           bdb.debits.Add(dp);
          bdb.SaveChanges();
            decimal b = Convert.ToDecimal(textBox1.Text);
            var item = (from u in bdb.UserAccounts
                        where u.Account_no == b
                        select u).FirstOrDefault();
            item.Balance = item.Balance + Convert.ToDecimal(textBox2.Text);

           bdb.SaveChanges();
            MessageBox.Show("Deposit money Sucessfully");







        }
    }
}

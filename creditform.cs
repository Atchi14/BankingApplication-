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
    public partial class creditform : Form
    {
        public creditform()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loadmode()
        {
            comboBox1.Items.Add("cash");
            comboBox1.Items.Add("cheque");

            //    throw new NotImplementedException();
        }

        private void loaddate()
        {
            datelbl.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
            //throw new NotImplementedException();
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
       bankingdbEntities bdb = new bankingdbEntities();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in bdb.UserAccounts
                        where u.Account_no == b
                        select u).FirstOrDefault();

            nametxt.Text = item.Name;
            oldbaltxt.Text = Convert.ToString(item.Balance);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bankingdbEntities bdb = new bankingdbEntities();
            NewAccount nc = new NewAccount();
           
           debit dp = new debit();
            dp.Date = datelbl.Text;
            dp.Accountno = Convert.ToDecimal(acctxt.Text);
            dp.Name = nametxt.Text;
            dp.Oldbalance = Convert.ToDecimal(oldbaltxt.Text);
            dp.Mode = comboBox1.SelectedItem.ToString();
            dp.Debamount= Convert.ToDecimal(Deposittxt.Text);
           bdb.debits.Add(dp);
            bdb.SaveChanges();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in bdb.UserAccounts
                        where u.Account_no == b
                        select u).FirstOrDefault();
            item.Balance = item.Balance + Convert.ToDecimal(Deposittxt.Text);

           bdb.SaveChanges();
            MessageBox.Show("Deposit money Sucessfully");

        }
    }
}

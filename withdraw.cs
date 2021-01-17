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
    public partial class withdraw : Form
    {
        public withdraw()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loadmode()
        {
           modetxt.Items.Add("Cash");
           modetxt.Items.Add("Chque");
            //throw new NotImplementedException();
        }

        private void loaddate()
        {
          labelbtn.Text = DateTime.Now.ToString("MM/dd/yyyy");
            //throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            bankingdbEntities bdb = new bankingdbEntities();
            NewAccount nc = new NewAccount();
            debit dp = new debit();

            dp.Date = labelbtn.Text;
            dp.Accountno = Convert.ToDecimal(textBox1.Text);
            dp.Name = Nametxt.Text;
            dp.Oldbalance = Convert.ToDecimal(oldbalancetxt.Text);
            dp.Mode = modetxt.SelectedItem.ToString();
            dp.Debamount = Convert.ToDecimal(amounttxt.Text);
            bdb.debits.Add(dp);
            bdb.SaveChanges();
            decimal b = Convert.ToDecimal(textBox1.Text);
            var item = (from u in bdb.UserAccounts
                        where u.Account_no == b
                        select u).FirstOrDefault();
            item.Balance = item.Balance - Convert.ToDecimal(amounttxt.Text);

            bdb.SaveChanges();
            MessageBox.Show("Debit money Sucessfully");



        }

        private void button2_Click(object sender, EventArgs e)
        {

            bankingdbEntities bdb = new bankingdbEntities();
            decimal b = Convert.ToDecimal(textBox1.Text);
            var item = (from u in bdb.UserAccounts
                        where u.Account_no == b
                        select u).FirstOrDefault();

            Nametxt.Text = item.Name;
            oldbalancetxt.Text = Convert.ToString(item.Balance);


        }
    }
}

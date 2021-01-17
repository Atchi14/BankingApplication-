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
    public partial class fdform : Form
    {
        public fdform()
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
            decimal d = Convert.ToDecimal(accnotxt.Text);
            var query = bdb.UserAccounts.Where(x => x.Account_no == d).SingleOrDefault();
            FD fdform1 = new FD();
            fdform1.AccountnO = Convert.ToDecimal(accnotxt.Text);
            fdform1.Mode = modetxt.SelectedItem.ToString();
            fdform1.Rupees = rupeestxt.Text;
            fdform1.Period = Convert.ToInt32(periodtxt.Text);
            fdform1.Interestrate = Convert.ToDecimal(intersttxt.Text);
            fdform1.Startdate = DateTime.Now.ToString("MM/dd/yyyy");
            fdform1.Maturitydate = (DateTime.Now.AddDays(Convert.ToInt32(periodtxt.Text))).ToString("MM/dd/yyyy");
            fdform1.Maturityamount = ((Convert.ToDecimal(rupeestxt.Text) * Convert.ToInt32(periodtxt.Text) * Convert.ToDecimal(intersttxt.Text)) / (100 * 12 * 30)) + (Convert.ToDecimal(rupeestxt.Text));
            bdb.FDs.Add(fdform1);
            bdb.SaveChanges();

            MessageBox.Show("FD Started Now");
            decimal amount = Convert.ToDecimal(rupeestxt.Text);
            decimal alamount = Convert.ToDecimal(query.Balance);
            decimal fdamount = alamount - amount;
            query.Balance = fdamount;
            bdb.SaveChanges();

            //bankingdbEntities dbe = new BankingSystemEntities();
            //decimal d = Convert.ToDecimal(Acctext.Text);
            //var query = dbe.userAccounts.Where(x => x.Account_No == d).SingleOrDefault();
            //FD fdform = new FD();
            //fdform.Account_NO = Convert.ToDecimal(Acctext.Text);
            //fdform.Mode = Modcombox.SelectedItem.ToString();
            //fdform.Rupees = Rupeetext.Text;
            //fdform.Period = Convert.ToInt32(Periodyrtext.Text);
            //fdform.Interest_rate = Convert.ToDecimal(interesttext.Text);
            //fdform.Start_Date = DateTime.Now.ToString("MM/dd/yyyy");
            //fdform.Maturity_Date = (DateTime.Now.AddDays(Convert.ToInt32(Periodyrtext.Text))).ToString("MM/dd/yyyy");
            //fdform.Maturity_Amount = ((Convert.ToDecimal(Rupeetext.Text) * Convert.ToInt32(Periodyrtext.Text) * Convert.ToDecimal(interesttext.Text)) / (100 * 12 * 30)) + (Convert.ToDecimal(Rupeetext.Text));
            //dbe.FDs.Add(fdform);
            //dbe.SaveChanges();
            //MessageBox.Show("FD Started Now");
            //decimal amount = Convert.ToDecimal(Rupeetext.Text);
            //decimal alamount = Convert.ToDecimal(query.balance);
            //decimal fdamount = alamount - amount;
            //query.balance = fdamount;
            //dbe.SaveChanges();

            // wait 2 minutes i am comming


        }

  
    }
}

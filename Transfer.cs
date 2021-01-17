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
    public partial class Transfer : Form
    {
        
    

        public Transfer()
        {
            InitializeComponent();
            loaddate();
        }

        private void loaddate()
        {
            datelbl.Text = DateTime.Now.ToString("MM/dd/yyyy");
            //throw new NotImplementedException();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            bankingdbEntities bdb = new bankingdbEntities();
            decimal b = Convert.ToDecimal(fromacctxt.Text);
            var item = (from u in bdb.UserAccounts
                        where u.Account_no == b
                        select u).FirstOrDefault();
            decimal bl = Convert.ToDecimal(item.Balance);
            decimal tb = Convert.ToDecimal(amounttxt.Text);
            decimal trfacc = Convert.ToDecimal(destaccount.Text);
            if (bl >= tb)
            {

                UserAccount item2 = (from u in bdb.UserAccounts
                                     where u.Account_no == trfacc
                                     select u).FirstOrDefault();

                item2.Balance = item2.Balance + tb;
                item.Balance = item.Balance - tb;
                bdb.SaveChanges();

              TransferTabel tr = new TransferTabel();
                tr.Accountno = Convert.ToDecimal(fromacctxt.Text);
                tr.ToTransfer = Convert.ToDecimal(destaccount.Text);
                tr.Date = DateTime.Now.ToString();
                tr.Name = nametxt.Text;
                tr.balance = Convert.ToDecimal(amounttxt.Text);
               
                bdb.SaveChanges();

                bdb.TransferTabels.Add(tr);
                MessageBox.Show("Transfer Money Sucessfully");
            }
        }
            private void button1_Click(object sender, EventArgs e)
            {

                bankingdbEntities bdb = new bankingdbEntities();
                decimal b = Convert.ToDecimal(fromacctxt.Text);
                var item = (from u in bdb.UserAccounts
                            where u.Account_no == b
                            select u).FirstOrDefault();

                nametxt.Text = item.Name;
                currentamount.Text = Convert.ToString(item.Balance);
            }

        }

    }

    


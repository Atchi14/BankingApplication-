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
    public partial class Balancesheet : Form
    {
       
        public Balancesheet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bankingdbEntities bdb = new bankingdbEntities();
            decimal b = Convert.ToDecimal(textBox1.Text);
            var item = (from u in bdb.debits
                        where u.Accountno == b
                        select u);
            dataGridView1.DataSource = item.ToList();

            var item1 = (from u in bdb.deposits
                         where u.Accountno == b
                         select u);
            dataGridView2.DataSource = item1.ToList();


            var item2 = (from u in bdb.TransferTabels
                         where u.Accountno == b
                         select u);
            dataGridView3.DataSource = item2.ToList();
        }

       
    }
}

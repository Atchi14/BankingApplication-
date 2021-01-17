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
    public partial class allcustomer : Form
    {
        public allcustomer()
        {
            
            InitializeComponent();
            bindgrid();
        }
        private void bindgrid()
        {
            //dataGridView1.AutoGenerateColumns = false;

            bankingdbEntities bdb = new bankingdbEntities();
            var item = bdb.UserAccounts.ToList();
            dataGridView1.DataSource = item;
            //throw new NotImplementedException();
        }

        //private void allcustomer_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'bankingdbDataSet.UserAccount' table. You can move, or remove it, as needed.
        //    this.userAccountTableAdapter.Fill(this.bankingdbDataSet.UserAccount);

        //}
    }
}

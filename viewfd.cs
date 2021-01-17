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
    public partial class viewfd : Form
    {
        BindingList<FD> bi;
     bankingdbEntities bdb;
        public viewfd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bi = new BindingList<FD>();
        bdb = new bankingdbEntities();
            string date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            MessageBox.Show(date);
            var item = bdb.FDs.Where(a => a.Startdate.Equals(date));

            dataGridView1.DataSource = item.ToList();
        }
    }
}

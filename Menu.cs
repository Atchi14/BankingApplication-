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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAccount newac = new NewAccount();
            newac.MdiParent = this;
            newac.Show();

        }

        private void updateSearchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Updatesearch ups = new Updatesearch();
          ups.MdiParent = this;
           ups.Show();

        }

        private void allcustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
         allcustomer allc = new allcustomer();
            allc.MdiParent = this;
           allc.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Depositform dep = new Depositform();
            dep.MdiParent = this;
            dep.Show();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
        withdraw wt = new withdraw();
           wt.MdiParent = this;
           wt.Show();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Transfer tra = new Transfer();
        tra.MdiParent = this;
           tra.Show();

        }

        private void fDFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
          fdform ff = new fdform();
          ff.MdiParent = this;
           ff.Show();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Balancesheet bs = new Balancesheet();
          bs.MdiParent = this;
     bs.Show();

        }

        private void viewFDToolStripMenuItem_Click(object sender, EventArgs e)
        {
          viewfd vf = new viewfd();
           vf.MdiParent = this;
         vf.Show();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout lg = new logout();
           lg.MdiParent = this;
          lg.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changepassword cp = new changepassword();
            cp.MdiParent = this;
            cp.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
          exit ext = new exit();
           ext.MdiParent = this;
           ext.Show();
        }
    }
}

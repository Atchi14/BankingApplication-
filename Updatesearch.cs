using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class Updatesearch : Form
    {
        bankingdbEntities bdb;
        MemoryStream ms;
        BindingList<UserAccount> bi;
        public Updatesearch()
        {
            InitializeComponent();
        }

        private void Updatesearch_Load(object sender, EventArgs e)
        {

        }

        private void acctxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mothertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void fathertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void phonetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addresstext_TextChanged(object sender, EventArgs e)
        {

        }

        private void districttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void statetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bdb = new bankingdbEntities();
            decimal a = Convert.ToDecimal(acctxt.Text);
            UserAccount acc = bdb.UserAccounts.First(s => s.Account_no.Equals(a));
            acc.Account_no = Convert.ToDecimal(acctxt.Text);
            acc.Name = nametxt.Text;
            acc.Date = dateTimePicker1.Value.ToString();
            acc.Mothername= mothertxt.Text;
            acc.Fathername = fathertxt.Text;
            acc.Phoneno = phonetxt.Text;
            if (radiomale.Checked == true)
            {
                acc.Gender = "male";
            }
            else
            {
                if (radiofemale.Checked == true)
                    acc.Gender = "female";
            }
            if (radioothers.Checked == true)
            {
                acc.Mariatial_status = "married";
            }
            else
            {
                if (radiomarried.Checked == true)
                    acc.Mariatial_status = "Un-Married";
            }

            Image img = pictureBox1.Image;
            //MessageBox.Show(img.RawFormat.ToString());
            if (img.RawFormat != null)
            {
                if (ms != null)
                {
                    img.Save(ms, img.RawFormat);
                    acc.Picture = ms.ToArray();
                }
            }
            acc.Address = addresstext.Text;
            acc.District = districttxt.Text;
            acc.State = statetxt.Text;



            bdb.SaveChanges();
            MessageBox.Show("Update Record");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bi.RemoveAt(dataGridView1.SelectedRows[0].Index);

            bdb = new bankingdbEntities();
            decimal a = Convert.ToDecimal(acctxt.Text);
            UserAccount acc = bdb.UserAccounts.First(s => s.Account_no.Equals(a));
           bdb.UserAccounts.Remove(acc);
            bdb.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bi = new BindingList<UserAccount>();
            bdb = new bankingdbEntities();
            decimal acno = Convert.ToDecimal(acctxt.Text);
            var item = bdb.UserAccounts.Where(a => a.Account_no == acno);
            foreach (var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bi = new BindingList<UserAccount>();
            bdb = new bankingdbEntities();
            var item = bdb.UserAccounts.Where(a => a.Name == nametxt.Text);
            foreach (var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {

                Image img = Image.FromFile(opendlg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           bdb = new bankingdbEntities();
            decimal accno = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            //MessageBox.Show(item.ToString());
            var item = bdb.UserAccounts.Where(a => a.Account_no == accno).FirstOrDefault();
            //MessageBox.Show(item.Gender.ToString());
           acctxt.Text = item.Account_no.ToString();
            nametxt.Text = item.Name;
           mothertxt.Text = item.Mothername;
           fathertxt.Text = item.Fathername;
           phonetxt.Text = item.Phoneno;
           addresstext.Text = item.Address;
            byte[] img = item.Picture;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            districttxt.Text = item.District;
           statetxt.Text = item.State;
            if (item.Gender == "male")
            {
                radiofemale.Checked = true;
            }
            else
            {
                if (item.Gender.ToString() == "female")
                    radiofemale.Checked = true;
            }

            if (item.Mariatial_status == "married")
            {
                radioothers.Checked = true;
            }
            else
            {
                if (item.Mariatial_status == "Un-Married")
                    radiomarried.Checked = true;
            }






        }
    }
}
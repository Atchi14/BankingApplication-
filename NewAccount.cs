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
    public partial class NewAccount : Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        decimal no;
        bankingdbEntities bdb;
        MemoryStream ms;
       

        public NewAccount()
        {
            InitializeComponent();
            loaddate();
            loadstate();
            loadaccount();


        }

        private void loadaccount()
        {
            //throw new NotImplementedException();
            bdb = new bankingdbEntities();

            var item = bdb.UserAccounts.ToArray();
            no = item.LastOrDefault().Account_no + 1;
            accnotext.Text = Convert.ToString(no);

        }


        private void loadstate()
        {
            comboBox1.Items.Add("Ap");


            //throw new NotImplementedException();
        }

        private void loaddate()
        {

            labeldate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            //throw new NotImplementedException();
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                gender = "male";

            }
            else if (radioButton2.Checked)
            {
                gender = "female";

            }





            if (radioButton3.Checked)
            {
                m_status = "married";

            }
            else if (radioButton4.Checked)
            {
                m_status = "Un-Married";

            }


            bdb = new bankingdbEntities();

            UserAccount acc = new UserAccount();
            acc.Account_no = Convert.ToDecimal(accnotext.Text);
            acc.Name = nametxt.Text;
            acc.DOB = dateTimePicker1.Value.ToString();
            acc.Phoneno = Phonetxt.Text;
            acc.Address = richTextBox1.Text;
            acc.District = disttxt.Text;
            acc.State = comboBox1.SelectedItem.ToString(); ;
            acc.Gender = gender;
            acc.Mariatial_status = m_status;
            acc.Mothername = mottxt.Text;
            acc.Fathername = Fathtxt.Text;
            acc.Balance = Convert.ToDecimal(baltxt.Text);
            acc.Date = labeldate.Text;
            acc.Picture = ms.ToArray();
            bdb.UserAccounts.Add(acc);
            bdb.SaveChanges();
            MessageBox.Show("file saved");


        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog opendlg = new OpenFileDialog();
        //    if (opendlg.ShowDialog() == DialogResult.OK)
        //    {

        //        Image img = Image.FromFile(opendlg.FileName);
        //        pictureBox1.Image = img;
        //        ms = new MemoryStream();
        //        img.Save(ms, img.RawFormat);

        //    }
        //}

        private void button1_Click_1(object sender, EventArgs e)
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
    }
}


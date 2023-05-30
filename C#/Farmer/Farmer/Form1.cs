using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Farmer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            dbcon();
        }

        MySqlConnection con;
        void dbcon()
        {
            try
            {
                con = new MySqlConnection("server=localhost; user=root; database=fertilizer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        void admine()
        {
            //login l=new login();
            
            //try
            //{
            //    string sql="select *from user where Uname='" +l.txtun.Text + "' and Password ='" + txtpw.Text + "'
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            
        }


        public void showform(object form)
        {
            main.Controls.Clear();
            Form frm = form as Form;
            frm.TopLevel = false;
            main.Controls.Add(frm);
            main.Tag = frm;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           showform(new fertilizer());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (admin.type == "A")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                homeToolStripMenuItem.Enabled = true;
                accountToolStripMenuItem.Enabled = true;
                searchToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
                acreTextToolStripMenuItem.Enabled = true;
                logoutToolStripMenuItem.Enabled = true;
            }
            else if (admin.type == "U")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = true;
                button5.Enabled = true;
                homeToolStripMenuItem.Enabled = true;
                accountToolStripMenuItem.Enabled = true;
                createAccountToolStripMenuItem.Enabled = false;
                deleteAccountToolStripMenuItem.Enabled = false;
                searchToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = false;
                acreTextToolStripMenuItem.Enabled = true;
                logoutToolStripMenuItem.Enabled = true;
            }
            time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showform(new farmer());
        }

        private void fertilizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit s = new Edit();
            s.TopLevel = false;
            main.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showform(new welcome());
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            season s = new season();
            s.TopLevel = false;
            main.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search s = new search();
            s.TopLevel = false;
            main.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void farmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farmerEdit s = new farmerEdit();
            s.TopLevel = false;
            main.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createacc s = new createacc();
            s.TopLevel = false;
            main.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acchange s = new acchange();
            s.TopLevel = false;
            main.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Billing s = new Billing();
            s.TopLevel = false;
            main.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ataccess s = new ataccess();
            s.TopLevel = false;
            main.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void acreTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
           taxt s = new taxt();
            s.TopLevel = false;
            main.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}

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
using System.Text.RegularExpressions;

namespace Farmer
{
    public partial class acchange : Form
    {
        public acchange()
        {
            InitializeComponent();
            dbcon();
        }

        MySqlConnection con;
        void dbcon()
        {
            try
            {
                con = new MySqlConnection("server=localhost;user=root;pwd= ; database=fertilizer ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void clear()
        {
            txtname.Clear();
            txtemail.Clear();
            txtepass.Clear();
            newpass.Clear();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                txtname.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Focus();
                return;
            }

            if (txtemail.Text == "")
            {
                txtemail.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemail.Focus();
                return;
            }
            if (txtepass.Text == "")
            {
                txtepass.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter Email Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtepass.Focus();
                return;
            }
            if (newpass.Text == "")
            {
                newpass.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter New Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newpass.Focus();
                return;
            }

            try
            {
                con.Open();
                String sql = "update user set Password='" + newpass.Text + "' where E_pw='" + txtepass.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Update");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtname.BackColor = Color.White;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txtepass.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void newpass_TextChanged(object sender, EventArgs e)
        {
            txtepass.BackColor = Color.White;
        }

        private void txtemail_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void txtepass_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void acchange_Load(object sender, EventArgs e)
        {
            txtname.Focus();
        }

        private void txtepass_KeyUp_1(object sender, KeyEventArgs e)
        {
            try
            {
                con.Open();
                String sql = "select * from user where Email='" + txtemail.Text + "' and E_pw ='" + txtepass.Text + "' ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    msg1.ForeColor = System.Drawing.Color.Red;
                    msg1.Text = "Invalid";
                    newpass.Enabled = false;
                }
                else
                {
                    msg1.ForeColor = System.Drawing.Color.Green;
                    msg1.Text = "Ok";
                    newpass.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void txtemail_KeyUp_1(object sender, KeyEventArgs e)
        {

            try
            {
                con.Open();
                String sql = "select * from user where Uname='" + txtname.Text + "' and Email ='" + txtemail.Text + "' ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    msg.ForeColor = System.Drawing.Color.Red;
                    msg.Text = "Invalid";
                    txtepass.Enabled = false;
                }
                else
                {
                    msg.ForeColor = System.Drawing.Color.Green;
                    msg.Text = "Ok";
                    txtepass.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
        //    string pattern = "^([0-9a-zA-Z]([-\\.\\w]*@[0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        //    if (Regex.IsMatch(txtemail.Text, pattern))
        //    {
        //        errorProvider1.Clear();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(this.txtemail, "Please provide mail address");
        //        return;
        //    }
        }
    }
}

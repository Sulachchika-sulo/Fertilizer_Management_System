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
    public partial class createacc : Form
    {
        public createacc()
        {
            InitializeComponent();
            dbconne();
        }

        MySqlConnection con;
        String type;

        void dbconne()
        {
            try
            {
                con = new MySqlConnection("server=localhost;user=root;pwd= ; database=fertilizer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void delete()
        {
            uname.Clear();
            txtpass.Clear();
            txtemail.Clear();
            epass.Clear();
            ctype.SelectedItem = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (uname.Text == "")
            {
                uname.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uname.Focus();
                return;
            }

            if (txtpass.Text == "")
            {
                txtpass.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Focus();
                return;
            }
            if (txtemail.Text == "")
            {
                txtemail.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemail.Focus();
                return;
            }
            if (epass.Text == "")
            {
                epass.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter Email Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                epass.Focus();
                return;
            }

            if (ctype.SelectedItem == null)
            {
                ctype.BackColor = Color.LightGreen;
                MessageBox.Show("Please Select the type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
            try
            {
                type = ctype.SelectedItem.ToString();

                con.Open();
                String sql = "insert into user(Uname,Password,Type,Email,E_pw) values('" + uname.Text + "', '" + txtpass.Text + "','" + type + "','" + txtemail.Text + "', '" + epass.Text + "')";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved");
                delete();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            uname.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete();
            //Application.Exit();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpass.BackColor = Color.White;
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            txtemail.BackColor = Color.White;
        }

        private void epass_TextChanged(object sender, EventArgs e)
        {
            epass.BackColor = Color.White;
        }

        private void txtpass_TextChanged_1(object sender, EventArgs e)
        {
            txtpass.BackColor = Color.White;
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*@[0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(txtemail.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtemail,"Please provide mail address");
                return;
            }
        }
    }
}

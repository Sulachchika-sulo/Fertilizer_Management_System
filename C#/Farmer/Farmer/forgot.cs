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
    public partial class forgot : Form
    {
        public forgot()
        {
            InitializeComponent();
            dbconnection();
        }

        MySqlConnection con;

        void dbconnection()
        {
            try
            {
                con = new MySqlConnection("server=localhost; user=root; database=fertilizer");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtemail.Text=="")
            {
                MessageBox.Show("Please Enter the Email", "user Alert");
                txtemail.Focus();
            }
            else
            {
                if (txtpw.Text == "")
                {
                    MessageBox.Show("Please Enter the Password", "user Alert");
                    txtpw.Focus();
                }
                else
                {
                    try
                    {
                        con.Open();
                        String sql = "select * from user where Email='" + txtemail.Text + "' and E_pw ='" + txtpw.Text + "' ";
                        MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        Form1 f1 = new Form1();

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Sorry your username and password wroing", "user Alert");
                        }
                        else
                        {
                            this.Hide();
                            f1.Show();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    con.Close();
                }
            }
        }

        private void forgot_Load(object sender, EventArgs e)
        {
            txtemail.Focus();
        }

        private void txtpw_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (txtpw.PasswordChar == '\0')
            //{
            //    bhide.BringToFront();
            //    txtpw.PasswordChar = '*';
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (txtpw.PasswordChar == '*')
            //{
            //    bhide.BringToFront();
            //    txtpw.PasswordChar = '\0';
            //}
        }
    }
}

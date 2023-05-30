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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            dbconnection();
            txtun.Focus();
        }
        MySqlConnection con;
        void dbconnection()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(130, 0, 0, 0);
           
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtun.Text == "")
            {
                MessageBox.Show("Please Enter the User Name", "user Alert");
            }
            else
            {
                if (txtpw.Text == "")
                {
                    MessageBox.Show("Please Enter the Password", "user Alert");
                }
                else
                {
                    try
                    {
                        con.Open();
                        String sql = "select * from user where Uname='" + txtun.Text + "' and Password ='" + txtpw.Text + "' ";
                        MySqlCommand cmd= new MySqlCommand(sql,con);
                        MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        DataSet ds=new DataSet();
                        da.Fill(ds);



                            int i = ds.Tables[0].Rows.Count;

                            if (i == 1)
                            {
                                MySqlDataReader dr = cmd.ExecuteReader(); 
                                if (dr.Read())
                                {

                                    if (dr[2].ToString() == "Admin")
                                    {
                                        admin.type = "A";
      
                                    }
                                    else
                                    {
                                        admin.type = "U";
                                    }


                                }
                                Form1 f1 = new Form1();
                                this.Hide();
                                f1.Show();

                            }
                            else
                            {
                                MessageBox.Show("Sorry your username and password wroing", "user Alert");
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

        private void txtun_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtpw_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtpw_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpw_KeyUp_1(object sender, KeyEventArgs e)
        {
            
            String sql = "select * from user where Uname='" + txtun.Text + "' and Password ='" + txtpw.Text + "' ";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

           
            if (dt.Rows.Count == 0)
            {
                msg2.ForeColor = System.Drawing.Color.Tomato;
                msg2.Text = "Invalid";

            }
            else
            {
                msg2.ForeColor = System.Drawing.Color.Yellow;
                msg2.Text = "Ok";
                //txtpw.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            forgot f = new forgot();
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (txtpw.PasswordChar == '*')
            //{
            //    shi.BringToFront();
            //    txtpw.PasswordChar = '*';
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

            
        }

        private void txtpw_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void spw_MouseClick(object sender, MouseEventArgs e)
        {
            //if (txtpw.PasswordChar == '\0')
            //{
            //    spw.BringToFront();
            //    txtpw.PasswordChar = '\0';
            //}
        }
    }
}

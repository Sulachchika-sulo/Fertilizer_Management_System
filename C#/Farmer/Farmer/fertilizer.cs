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
    public partial class fertilizer : Form
    {
        public fertilizer()
        {
            InitializeComponent();
            dbconnecter();
            txtid.Focus();
            txtkg.Hide();
            txtl.Hide();
            
        }

        MySqlConnection con;
        int xkg, xliter;
       

        void dbconnecter()
        {
            try
            {
                con = new MySqlConnection("server=localhost;user=root;pwd= ;database=fertilizer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void delete()
        {
            txtid.Clear();
            txtname.Clear();
            txtkg.Clear();
            txtl.Clear();
            txtdis.Clear();
            rdkg.Checked = false;
            rdl.Checked = false;
            txtid.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("No Information");
            }
            delete();
            txtkg.Hide();
            txtl.Hide();
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (txtid.Text == "")
            //{
            //    txtid.BackColor = Color.LightGreen;
            //    MessageBox.Show("Please Enter Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtid.Focus();
            //    return;
            //}
            //else
            //{
                if (txtname.Text == "")
                {
                    txtname.BackColor = Color.LightGreen;
                    MessageBox.Show("Please Enter  Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtname.Focus();
                    return;
                }
                //if ((rdkg.Checked = false) || (rdl.Checked = false))
                //{

                //    MessageBox.Show("Please Select Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                if ((txtkg.Text == "") && (txtl.Text == ""))
                {
                    txtkg.BackColor = Color.LightGreen;
                    txtl.BackColor = Color.LightGreen;
                    MessageBox.Show("Please Enter Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    if (rdkg.Checked)
                    {
                        xkg = int.Parse(txtkg.Text);
                    }
                    if (rdl.Checked)
                    {
                        xliter = int.Parse(txtl.Text);
                    }

                    con.Open();
                    string sql = "insert into ferti (F_Id,F_Name,kg,liter,Date,Description) values('" + txtid.Text + "','" + txtname.Text + "','" + xkg + "','" + xliter + "','" + txtdate.Text + "','" + txtdis.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Saved", "Conformation");
                    delete();
                    txtkg.Hide();
                    txtl.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            
                  
        }

        private void txtdate_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void fertilizer_Load(object sender, EventArgs e)
        {
            txtdate.Text = DateTime.Now.ToShortDateString();
        }

        private void rdkg_CheckedChanged(object sender, EventArgs e)
        {
            if (rdkg.Checked)
            {
                txtl.Hide();
                txtkg.Show();
                txtkg.Focus();
            }
        }

        private void rdl_CheckedChanged(object sender, EventArgs e)
        {
            if (rdl.Checked)
            {
                txtkg.Hide();
                txtl.Show();
                txtl.Focus();
            }
        }

        private void maha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtkg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (! char.IsDigit(e.KeyChar) && ! char.IsControl(e.KeyChar) && e.KeyChar !='.')
            {
                MessageBox.Show("Please Enter only Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
               
            }
            else
            {
                 e.Handled = false;
            }
        }

        private void txtl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Please Enter only Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;

            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
           txtid.BackColor = Color.White;
           txtname.Clear();
           txtdis.Clear();
           txtkg.Clear();
           txtl.Clear();
            
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            //if (txtid.Text == "")
            //{
            //    txtid.BackColor = Color.LightGreen;
            //    MessageBox.Show("Please Enter Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtid.Focus();
            //    return;
            //}
           
            txtname.BackColor = Color.White;
        }

        private void txtkg_TextChanged(object sender, EventArgs e)
        {
            //if (txtid.Text == "")
            //{
            //    txtid.BackColor = Color.LightGreen;
            //    MessageBox.Show("Please Enter Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtid.Focus();
            //    return;
            //}
            txtkg.BackColor = Color.White;
        }

        private void txtl_TextChanged(object sender, EventArgs e)
        {
        //    if (txtid.Text == "")
        //    {
        //        txtid.BackColor = Color.LightGreen;
        //        MessageBox.Show("Please Enter Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        txtid.Focus();
        //        return;
        //    }
            txtl.BackColor = Color.White;
        }

        private void txtdis_TextChanged(object sender, EventArgs e)
        {
            //if (txtid.Text == "")
            //{
            //    txtid.BackColor = Color.LightGreen;
            //    MessageBox.Show("Please Enter Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtid.Focus();
            //    return;
            //}
           
        }
    }
}


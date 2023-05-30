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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
            dbconnection();
            txtkg.Hide();
            txtl.Hide();
            display();
        }
        
        MySqlConnection con;
        //string txtseason;
        int xkg, xliter;

        void dbconnection()
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
            txtsearch.Clear();
            txtname.Clear();
            txtl.Clear();
            txtkg.Clear();
            txtid.Clear();
            txtdis.Clear();
            txtdate.Clear();
            rdkg.Checked = false;
            rdl.Checked = false;
            txtsearch.Focus();
            txtkg.Hide();
            txtl.Hide();
            

        }

        void display()
        {

            try
            {
                con.Open();
                String sql = "select* from ferti";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                txtid.BackColor = Color.LightGreen;
                MessageBox.Show("Please Select Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtid.Focus();
                return;
            }

            if (txtname.Text == "")
            {
                txtname.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Focus();
                return;
            }

            if (rdkg.Checked)
            {
                if (txtkg.Text == "")
                {
                    txtkg.BackColor = Color.LightGreen;
                    MessageBox.Show("Please  Enter Qty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtkg.Focus();
                    return;
                }
            }
            if (rdl.Checked)
            {
                if (txtl.Text == "")
                {
                    txtl.BackColor = Color.LightGreen;
                    MessageBox.Show("Please  Enter Qty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtl.Focus();
                    return;
                }
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
                String sql = "update ferti set F_Name='" + txtname.Text + " ',kg='"+xkg+"',liter='"+xliter+"',Date='"+txtdate.Text+"',Description='"+txtdis.Text+"' where F_Id='"+txtid.Text+"';" ;
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Update","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                delete();
                txtkg.Hide();
                txtl.Hide();

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //txtname.Enabled = true;
            //rdkg.Enabled = true;
            //rdl.Enabled = true;
            //txtdis.Enabled = true;
            
            //con.Open();
            //try
            //{
            //    String sql = "select * from ferti where F_Id = '"+txtsearch.Text+"' ";
            //    MySqlCommand cmd = new MySqlCommand(sql, con);

            //    MySqlDataReader adr = cmd.ExecuteReader();

            //    if (adr.Read())
            //    {
            //        txtid.Text = adr.GetString("F_Id");
            //        txtname.Text = adr.GetString("F_Name");
            //        txtkg.Text = adr.GetInt32("kg").ToString();
            //        txtl.Text = adr.GetInt32("liter").ToString();
            //        txtdate.Text = adr.GetString("Date");
            //        rdkg.Checked = adr.GetBoolean("kg");
            //        rdl.Checked = adr.GetBoolean("liter");
            //        txtdis.Text = adr.GetString("Description");

            //        txtsearch.Focus();
                   

            //    }
            //    else
            //    {
            //        MessageBox.Show("No Data");
            //        txtsearch.Focus();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtid.Text=="")
            {
                txtid.BackColor = Color.LightGreen;
                MessageBox.Show("Please Select Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtid.Focus();
                return;
            }
            
            con.Open();
            try
            {
                if (MessageBox.Show("Are you want to Delete ", "Delete message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    String sql = "delete from ferti where F_Id = '" + txtsearch.Text + "' ";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    delete();
                    MessageBox.Show("Successsfully Deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

             display();
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

        private void txtkg_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Edit_Load(object sender, EventArgs e)
        {
            //if (txtsearch.Text == "")
            //{
            //    btse.Enabled = false;
            //}
           
            //txtid.Enabled = false;
            //txtname.Enabled = false;
            //rdkg.Enabled = false;
            //rdl.Enabled = false;
            //txtdis.Enabled = false;
            //txtdate.Enabled = false;
            txtsearch.Focus();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                String sql = "select* from ferti where F_Id like '" + txtsearch.Text + "%' ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
       
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtkg.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (txtkg.Text == "0")
            {
                rdkg.Checked = false;
            }
            else
            {
                rdkg.Checked = true;
            }
            txtl.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (txtl.Text == "0")
            {
                rdl.Checked = false;
            }
            else
            {
                rdl.Checked = true;
            }
            txtdate.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtdis.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}

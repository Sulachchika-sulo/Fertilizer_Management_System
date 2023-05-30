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
    public partial class farmerEdit : Form
    {
        public farmerEdit()
        {
            InitializeComponent();
            dbconnection();
            display();
        }

        MySqlConnection con;

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

        void cleardata()
        {
            txtsea.Clear();
            txtplr.Clear();
            txtname.Clear();
            txtnic.Clear();
            txtadd.Clear();
            txtper.Clear();
            txtcon.Clear();
            txttell.Clear();
            txtsea.Focus();
        }
        void display()
        {
            con.Open();
            try
            {
               
                String sql = "select* from farmer";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

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

        //void dis()
        //{
        //    try
        //    {
        //        String q = "select* from farmer";
        //        MySqlDataAdapter da = new MySqlDataAdapter(q, con);

        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridView1.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void txtsea_TextChanged(object sender, EventArgs e)
        {
            txtsea.BackColor = Color.White;
            con.Open();
            try
            {
               
                String sql = "select* from farmer where PLR like '" + txtsea.Text + "%' ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            if (txtplr.Text == "")
            {
                txtplr.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter  search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (txtname.Text == "")
            {

                txtname.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter  name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Focus();
                return;
            }
            if (txtper.Text == "")
            {
                txtper.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter  Perches", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtper.Focus();
                return;
            }
            if (txtnic.Text == "")
            {

                txtnic.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter  NIC No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnic.Focus();
                return;
            }
            if (txtadd.Text == "")
            {
                txtadd.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter  NIC No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtadd.Focus();
                return;
            }
            if (txtcon.Text == "")
            {
                txtcon.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter  Continent", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcon.Focus();
                return;
            }
            con.Open();
            try
            {

                String sql = "update farmer set Name='" + txtname.Text + "',NIC= '" + txtnic.Text + "', Perches= '" + txtper.Text + "', Address= '" + txtadd.Text + "', Continent= '" + txtcon.Text + "', Tell_No= '" + txttell.Text + "' where PLR= '" + txtplr.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Update");
                cleardata();
                txtsea.Focus();

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

        private void delete_Click(object sender, EventArgs e)
        {
            if (txtplr.Text == "")
            {
                txtplr.BackColor = Color.LightGreen;
                MessageBox.Show("Please Select Id");
                txtplr.Focus();
                return;
            }

            if (MessageBox.Show("Are you want to Delete All the Table Record", "Delete message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                try
                {
                   
                    String sql = ("delete from billing where PLR= '" + txtplr.Text + "';DELETE FROM taxt where PLR= '" + txtplr.Text + "';Delete from farmer where PLR= '" + txtplr.Text + "'");
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted");
                    cleardata();
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
        }

        private void txtper_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txttell_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            txtname.BackColor = Color.White;
        }

        private void txtper_TextChanged(object sender, EventArgs e)
        {
            txtper.BackColor = Color.White;
        }

        private void txtcon_TextChanged(object sender, EventArgs e)
        {
            txtcon.BackColor = Color.White;
        }

        private void txtnic_TextChanged(object sender, EventArgs e)
        {
            txtnic.BackColor = Color.White;
        }

        private void txtadd_TextChanged(object sender, EventArgs e)
        {
            txtadd.BackColor = Color.White;
        }

        private void farmerEdit_Load(object sender, EventArgs e)
        {
            //txtname.Enabled = false;
            //txtnic.Enabled = false;
            //txtper.Enabled = false;
            //txtcon.Enabled = false;
            //txtadd.Enabled = false;
            //txttell.Enabled = false;
            txtsea.Focus();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtplr.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtnic.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtper.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtadd.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtcon.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txttell.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}

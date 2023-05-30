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
    public partial class farmer : Form
    {
        public farmer()
        {
            InitializeComponent();
            dbconnection();
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
        void delete()
        {
            txtplr.Clear();
            txtname.Clear();
            txtnic.Clear();
            txtadd.Clear();
            txtpea.Clear();
            txtcon.Clear();
            txttell.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
                     

        }

        private void farmer_Load(object sender, EventArgs e)
        {

        }

        private void main2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtplr.Text == "")
            {
                txtplr.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter PLR No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtplr.Focus();
                return;
            }
            if (txtname.Text == "")
            {
                txtname.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Focus();
                return;
            }
            if (txtnic.Text == "")
            {
                txtnic.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter NIC No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnic.Focus();
                return;
            }
            if (txtpea.Text == "")
            {
                txtpea.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter Perches", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpea.Focus();
                return;
            }
            if (txtcon.Text == "")
            {
                txtcon.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter Continent", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcon.Focus();
                return;
            }
            if (txtadd.Text == "")
            {
                txtadd.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtadd.Focus();
                return;
            }
            try
            {
                int xplr = int.Parse(txtplr.Text);
                txtplr.Text = xplr.ToString();

                int xper = int.Parse(txtpea.Text);
                txtpea.Text = xper.ToString();

                con.Open();
                String sql = "insert into farmer (PLR,Name,NIC,Perches,Address,Continent,Tell_No) values('" + xplr + "','" + txtname.Text + "','" + txtnic.Text + "','" + txtpea.Text + "','" + txtadd.Text + "','" + txtcon.Text + "','" + txttell.Text + "')";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");
                delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            delete();
        }

        private void txtpea_KeyPress(object sender, KeyPressEventArgs e)
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
            if ((e.KeyChar > 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Please Enter only Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }
        }

        private void txtplr_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtplr_TextChanged(object sender, EventArgs e)
        {
            txtplr.BackColor = Color.White;
        }

        private void txtpea_TextChanged(object sender, EventArgs e)
        {
            txtpea.BackColor = Color.White;
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            txtname.BackColor = Color.White;
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
    }
}

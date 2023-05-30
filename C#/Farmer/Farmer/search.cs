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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
            dbconnection();
        }

        MySqlConnection con;
        void dbconnection()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             try
                {
                    con.Open();
                    String sql = "select * from farmer where PLR like '"+txtpl.Text+"%'";
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String sql = "select * from ferti where F_Id like '"+txtid.Text+"%' ";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String sql = "select * from farmer ";
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
            try
            {
                con.Open();
                String sql = "select * from ferti ";
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String sql = "select billing.BillNo, farmer.Name, farmer.PLR, farmer.Perches, farmer.Continent, billing.season, billing.Date  from  farmer , billing  where billing.BillNo like '" + textBox2.Text + "%' ";
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String sql = "select * from sea ";
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
    }
}

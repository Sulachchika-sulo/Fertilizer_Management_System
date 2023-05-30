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
    public partial class ataccess : Form
    {
        public ataccess()
        {
            InitializeComponent();
            dbconnection();
        }

        MySqlConnection con;

        void dbconnection()
        {
            try
            {
                con = new MySqlConnection("server=localhost; user=root; pwd= ; database= fertilizer");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void display()
        {

            try
            {
                string sql = "select Uname, Email,Type from user";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "select Uname, Email,Type from user";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string _uname, _email, _type;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _uname = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            _email = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            _type = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                String sql = "delete from user where Email='" + _email + "' ";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted", "Conformation");
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }
    }
}

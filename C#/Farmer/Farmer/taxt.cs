using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Farmer
{
    public partial class taxt : Form
    {
        public taxt()
        {
            InitializeComponent();
            dbcon();
        }
        MySqlConnection con;

        void dbcon()
        {
            try
            {
                con = new MySqlConnection("server=localhost;user=root; database= fertilizer;convert zero datetime=True");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void invoice()
        {
            try
            {
                con.Open();
                string invo;
                String sql = "select No from taxt order by No Desc";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int i = int.Parse(dr[0].ToString()) + 1;
                    invo = i.ToString("AB-0000");
                }
                else if (Convert.IsDBNull(dr))
                {
                    invo = ("AB-0001");
                }
                else
                {
                    invo = ("AB-0001");
                }
                tbill.Text = invo.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
      


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string sql = "select *from taxt where PLR='" + txtplr.Text + "' ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable at = new DataTable();
                da.Fill(at);
                dataGridView1.DataSource = at;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
           
        }

        private void txtyear_TextChanged(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string sql = "select *from taxt where year(date)='" + txtyear.Text + "' ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable at = new DataTable();
                da.Fill(at);
               
                dataGridView1.DataSource = at;
                
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void pprint_Click(object sender, EventArgs e)
        {

            //if (tplr.Text == "")
            //{
            //    tplr.BackColor = Color.LightGreen;
            //    MessageBox.Show("Please Enter PLR No");
            //    tplr.Focus();
            //    return;
            //}
            //if (ttax.Text == "")
            //{
            //    ttax.BackColor = Color.LightGreen;
            //    MessageBox.Show("Please Enter Tax value");
            //    ttax.Focus();
            //    return;
            //}
            //try
            //{

            //    con.Open();
            //    string sql = "insert into taxt(No,PLR,Date,tax) values('null','" + tplr.Text + "','" + tdate.Text + "','" + double.Parse(ttax.Text) + "')";
            //    MySqlCommand cm = new MySqlCommand(sql, con);
            //    cm.ExecuteNonQuery();
            //    MessageBox.Show("Successfully Save");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //con.Close();

          
        }

          

        private void tdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            tdate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            try
            {
                con.Open();
                string sql = "select *from taxt ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable at = new DataTable();
                da.Fill(at);
                dataGridView1.DataSource = at;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void tplr_TextChanged(object sender, EventArgs e)
        {
            tplr.BackColor = Color.White;
            //try
            //{
            //    con.Open();
            //    string sql = "select Name,Perches,Address,Continent from farmer where PLR='" + tplr.Text + "' ";
            //    MySqlCommand cmd = new MySqlCommand(sql, con);
            //    MySqlDataReader adr = cmd.ExecuteReader();

            //    if (adr.Read())
            //    {
            //        tname.Text = adr.GetString("Name");
            //        tacre.Text = adr.GetInt32("Perches").ToString();
            //        tadd.Text = adr.GetString("Address");
            //        tcon.Text = adr.GetString("Continent");
            //      }
            //   else
            //    {
            //        MessageBox.Show("No Data");
            //    }
               
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //con.Close();
        }

        private void ttax_TextChanged(object sender, EventArgs e)
        {
            ttax.BackColor = Color.White;
        }

        private void ttax_KeyPress(object sender, KeyPressEventArgs e)
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

        private void prefresh_Click(object sender, EventArgs e)
        {
           
            try
            {
                con.Open();
                string sql = "select *from taxt ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable at = new DataTable();
                da.Fill(at);
               
                dataGridView1.DataSource = at;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            txtplr.Clear();
            txtyear.Clear();
        }

        private void taxt_Load(object sender, EventArgs e)
        {
            invoice();
        }

        private void tcon_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
           
        }

        private void pprint_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void tplr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            try
            {
                con.Open();
                string sql = "select Name,Perches,Address,Continent from farmer where PLR='" + tplr.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader adr = cmd.ExecuteReader();

                if (adr.Read())
                {
                    tname.Text = adr.GetString("Name");
                    tacre.Text = adr.GetInt32("Perches").ToString();
                    tadd.Text = adr.GetString("Address");
                    tcon.Text = adr.GetString("Continent");
                }
                else
                {
                    MessageBox.Show("No Data");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            }
        }

        private void printp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tacre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void tname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbill_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tplr.Text == "")
            {
                tplr.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter PLR No");
                tplr.Focus();
                return;
            }
            if (ttax.Text == "")
            {
                ttax.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter Tax value");
                ttax.Focus();
                return;
            }
            try
            {

                con.Open();
                string sql = "insert into taxt(No,PLR,Date,tax) values('null','" + tplr.Text + "','" + tdate.Text + "','" + double.Parse(ttax.Text) + "')";
                MySqlCommand cm = new MySqlCommand(sql, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Successfully Save");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            acre a = new acre();
            a.b1 = tbill.Text;
            a.p1 = tplr.Text;
            a.c1 = tcon.Text;
            a.n1 = tname.Text;
            a.ac = tacre.Text;
            a.a1 = tadd.Text;
            a.t1 = ttax.Text;
            a.ShowDialog();

            tbill.Clear();
            tplr.Clear();
            tcon.Clear();
            tname.Clear();
            tacre.Clear();
            tadd.Clear();
            ttax.Clear();
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "select Name,Perches,Address,Continent from farmer where PLR='" + tplr.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader adr = cmd.ExecuteReader();

                if (adr.Read())
                {
                    tname.Text = adr.GetString("Name");
                    tacre.Text = adr.GetInt32("Perches").ToString();
                    tadd.Text = adr.GetString("Address");
                    tcon.Text = adr.GetString("Continent");
                }
                else
                {
                    MessageBox.Show("No Data");
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

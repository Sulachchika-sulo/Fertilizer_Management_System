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
    public partial class season : Form
    {
        public season()
        {
            InitializeComponent();
            dbconnection();
        }

        MySqlConnection con;
        int n = 1;
        int n1 = 1;
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

        void dgclear()
        {
            loaddata.Rows.Clear();
            datashow.Rows.Clear();
        }

        void display()
        {
           
            try
            {
                string sql = "select * from sea";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                loaddata.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void txtsea_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmaha_CheckedChanged_1(object sender, EventArgs e)
        {
           
        }

        private void cyala_CheckedChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String sql = "select F_Id,F_Name,kg,liter from ferti where F_Id like '"+txtsea.Text+"%' ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                datamaha.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        string fname,fid,kg,liter,sea;
       
       
        private void datamaha_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            fid = datamaha.SelectedRows[0].Cells[0].Value.ToString();
            fname = datamaha.SelectedRows[0].Cells[1].Value.ToString();
           kg= datamaha.SelectedRows[0].Cells[2].Value.ToString();
          liter = datamaha.SelectedRows[0].Cells[2].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                       
            if (!cmaha.Checked && !cyala.Checked)
            {
                MessageBox.Show("Select related Season");
            }
            else
            {
                if (txtqty.Text == "")
                {
                    MessageBox.Show("Enter the Qty");
                }

                try
                {
                    if (datamaha.SelectedRows.Count > 0)
                    {

                        if (cmaha.Checked)
                        {
                            sea = "Maha";
                        }
                        if (cyala.Checked)
                        {
                            sea = "Yala";
                        }
                        DataGridViewRow newrow = new DataGridViewRow();
                        newrow.CreateCells(showdata);
                        newrow.Cells[0].Value = n;
                        newrow.Cells[1].Value = fid;
                        newrow.Cells[2].Value = fname;
                        newrow.Cells[3].Value = double.Parse(txtqty.Text);
                        newrow.Cells[4].Value = sea;
                        showdata.Rows.Add(newrow);
                        n++;
                        txtqty.Clear();
                    }
                    else
                    {
                        MessageBox.Show(" Please Select the Row");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        
        

        private void button3_Click(object sender, EventArgs e)
        {
            txtsea.Clear();
            cmaha.Checked = false;
            cyala.Checked = false;
            txtqty.Clear();
            datamaha.DataSource = null;
            showdata.Rows.Clear();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (showdata.SelectedRows.Count > 0)
            {

                try
                {
                    con.Open();
                    for (int x = 0; x < showdata.Rows.Count - 1; x++)
                    {
                        string sql = "insert into sea (sid,sname,season,qty) values('" + showdata.Rows[x].Cells[1].Value + "', '" + showdata.Rows[x].Cells[2].Value + "','" + showdata.Rows[x].Cells[4].Value + "','" + showdata.Rows[x].Cells[3].Value + "') ";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("Successfully Saved", "Conformation");
                    showdata.Rows.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Insert the Info");
            }
        }

        void clean()
        {
            loaddata.DataSource = null;
            datashow.Rows.Clear();
            rdm1.Checked = false;
            rdy1.Checked = false;
            txt_qty.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clean();
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String sql = "select * from sea";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                loaddata.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
           
        }

        private void loaddata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        string id, sname,_sea,ssea,aqty,no;
        private void loaddata_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            id = loaddata.SelectedRows[0].Cells[0].Value.ToString();
            sname = loaddata.SelectedRows[0].Cells[1].Value.ToString();
            ssea = loaddata.SelectedRows[0].Cells[2].Value.ToString();
            aqty = loaddata.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void datamaha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void season_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String sql = "select F_Id,F_Name,kg,liter from ferti ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                datamaha.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //if (datashow.SelectedRows.Count > 0)
            //{
                con.Open();
                try
                {

                    for (int y = 0; y < datashow.Rows.Count - 1; y++)
                    {
                        string sql = "update sea set sname='" + datashow.Rows[y].Cells[2].Value + "',season='" + datashow.Rows[y].Cells[4].Value + "',qty='" + datashow.Rows[y].Cells[3].Value + "' where sid= '" + datashow.Rows[y].Cells[1].Value + "' ";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("Successfully Saved", "Conformation");
                    showdata.Rows.Clear();
                    display();
                    datashow.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            //}
            ////else
            ////{
            //    MessageBox.Show("Please Insert Rows");
           //}
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (!rdm1.Checked && !rdy1.Checked )
            {
                MessageBox.Show("Select related item");
            }
            else
            {
                if (txt_qty.Text == "")
                {
                    MessageBox.Show("Enter Qty");
                }
                else
                {
                    if (rdm1.Checked)
                    {
                        _sea = "Maha";
                    }
                    if (rdy1.Checked)
                    {
                        _sea = "Yala";
                    }

                    try
                    {
                        DataGridViewRow newrow = new DataGridViewRow();
                        newrow.CreateCells(datashow);
                        newrow.Cells[0].Value = n1;
                        newrow.Cells[1].Value = id;
                        newrow.Cells[2].Value = sname;
                        newrow.Cells[3].Value = double.Parse(txt_qty.Text);
                        newrow.Cells[4].Value = _sea;
                        datashow.Rows.Add(newrow);
                        n++;
                        txt_qty.Clear();
                        rdm1.Checked = false;
                        rdy1.Checked = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void datashow_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = datashow.SelectedRows[0].Cells[1].Value.ToString();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (loaddata.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you want to Delete ", "Delete message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        String sql = "delete from sea where sid='" + id + "' ";
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
            }
            else
            {
                MessageBox.Show("Please Select Delete Row");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (showdata.SelectedRows.Count > 0)
            {
                showdata.Rows.Remove(showdata.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Please Select Delete Row");
            }
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            txtqty.BackColor = Color.White;
            
            
        }
    }
}

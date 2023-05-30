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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            dbconnection();
        }

        MySqlConnection con;
        public String name, season,cdate;
       public int  tot;
       int qty;
        int n = 1;

        void dbconnection()
        {
            try
            {
                con = new MySqlConnection("server=localhost;user=root;pwd= ;database=fertilizer; convert zero datetime=True");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void delete()
        {
            txtplr.Clear();
            txtper.Clear();
            txtname.Clear();
            txtnic.Clear();
            txtcon.Clear();
            txtadd.Clear();
            txtsea.Clear();
            dataGridView1.Rows.Clear();
            button1.Enabled = true;
            txtplr.ReadOnly = false;
            msg2.ForeColor = System.Drawing.Color.White;
            msg2.Text = "Acre Tax";
            invoice();

        }

       
        void invoice()
        {
            try
            {
                con.Open();
                string invo;
                String sql = "select BillNo from billing order by BillNo Desc";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int i = int.Parse(dr[0].ToString()) + 1;
                    invo = i.ToString("FB-0000");
                }
                else if (Convert.IsDBNull(dr))
                {
                    invo = ("FB-0001");
                }
                else
                {
                    invo = ("FB-0001");
                }
                txtbill.Text = invo.ToString();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
       
        int tper = 0;
        void dissea()
        {
           

            //try
            //{
            //    con.Open();
            //    String query = "select sname,season,qty from sea";
            //    MySqlCommand mcv = new MySqlCommand(query, con);
            //    MySqlDataReader mdrv = mcv.ExecuteReader();

            //    while (mdrv.Read())
            //    {
            //        DataGridViewRow dg = new DataGridViewRow();
            //        dg.CreateCells(dataGridView1);
            //        dg.Cells[0].Value = n;
            //        name= mdrv.GetString("sname");
            //        dg.Cells[1].Value =name;
            //        txtsea.Text = mdrv.GetString("season");
            //        qty = mdrv.GetInt32("qty");
            //        tper = int.Parse(txtper.Text);
            //        tot = qty * tper;
            //        dg.Cells[2].Value = tot;
            //        dataGridView1.Rows.Add(dg);
            //        n++;

            //        viewdata obj = new viewdata() { No = n.ToString(), F_Name =name , Qty = tot.ToString() };
            //        viewdataBindingSource.Add(obj);
            //        viewdataBindingSource.MoveLast();
                                      
            //    }
            //    mdrv.Close();


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //con.Close();           
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtplr.Text == "")
            {
                txtplr.BackColor = Color.LightGreen;
                MessageBox.Show("No data fro clean");
                txtplr.Focus();
                return;
            }
            delete();
            txtplr.Focus();
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 l = new Form1();
            this.Hide();
            l.Show();
        }

       

        private void Billing_Load(object sender, EventArgs e)
        {
            txtplr.Focus();
            txtd.Text = DateTime.Now.ToShortDateString();
            invoice();
            viewdataBindingSource.DataSource = new List<viewdata>();
           

        }


        private void button3_Click(object sender, EventArgs e)
        {
           

        }
              
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtplr.Text == "")
            {
                txtplr.BackColor = Color.LightGreen;
                MessageBox.Show("Please Enter PLR No");
                txtplr.Focus();
                return;
            }

            try
            {
                con.Open();
                String sql = "insert into billing ( BillNo,PLR,  Season ,Date) values ('"+txtbill.Text+"', '" + int.Parse(txtplr.Text) + "', '" + txtsea.Text + "','" + txtd.Text + "')";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved", "Conformation");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            

            using (dataprint frm = new dataprint(viewdataBindingSource.DataSource as List<viewdata>, string.Format("{0}", txtbill.Text), string.Format("{0}", txtplr.Text), string.Format("{0}", txtname.Text), string.Format("{0}", txtsea.Text), string.Format("{0}", txtnic.Text), string.Format("{0}", txtcon.Text), string.Format("{0}", txtadd.Text), string.Format("{0}", txtd.Text))) 
            {
                frm.ShowDialog();
            }

           
        }

        private void txtbill_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

       
        private void txtplr_TextChanged(object sender, EventArgs e)
        {
                    txtplr.BackColor = Color.White;
                    //try
                    //{
                    //    con.Open();
                    //    String sql = "select Name,NIC,Perches,Address,Continent from farmer where PLR = '" + txtplr.Text + "' ";
                    //    MySqlCommand cmd = new MySqlCommand(sql, con);

                    //    MySqlDataReader adr = cmd.ExecuteReader();

                    //    if (adr.Read())
                    //    {
                    //        txtname.Text = adr.GetString("Name");
                    //        txtnic.Text = adr.GetString("NIC");
                    //        txtper.Text = adr.GetString("Perches");
                    //        txtadd.Text = adr.GetString("Address");
                    //        txtcon.Text = adr.GetString("Continent");

                    //        txtplr.ReadOnly = true;
                    //    }
                    //    adr.Close();


                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.Message);
                    //}
                    //con.Close();

                    //try
                    //{
                    //    con.Open();
                    //       String query = "select sname,season,qty from sea";
                    //        MySqlCommand mcvs = new MySqlCommand(query, con);
                    //        MySqlDataReader mdr = mcvs.ExecuteReader();

                    //        while (mdr.Read())
                    //        {
                    //            DataGridViewRow dg = new DataGridViewRow();
                    //            dg.CreateCells(dataGridView1);
                    //            dg.Cells[0].Value = n;
                    //            name = mdr.GetString("sname");
                    //            dg.Cells[1].Value = name;
                    //            txtsea.Text = mdr.GetString("season");
                    //            qty = mdr.GetInt32("qty");
                    //            tper = int.Parse(txtper.Text);
                    //            tot = qty * tper;
                    //            dg.Cells[2].Value = tot;
                    //            dataGridView1.Rows.Add(dg);
                    //            n++;

                    //            viewdata obj = new viewdata() { No = n.ToString(), F_Name = name, Qty = tot.ToString() };
                    //            viewdataBindingSource.Add(obj);
                    //            viewdataBindingSource.MoveLast();

                    //        }
                          
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.Message);
                    //}
                    //   con.Close();                           
        }

        private void txtnic_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void txtplr_KeyUp(object sender, KeyEventArgs e)
        {
            //try
            //{
            //    con.Open();
            //    string sql = "select *from taxt where PLR='" + txtplr.Text + "'  and year(date)= year(curdate()) ";
            //    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);

            //    if (dt.Rows.Count == 0)
            //    {
            //        msg2.ForeColor = System.Drawing.Color.Tomato;
            //        msg2.Text = "Invalid";
                    
                    

            //    }
            //    else
            //    {
            //        msg2.ForeColor = System.Drawing.Color.Yellow;
            //        msg2.Text = "Ok";

            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String sql = "select Name,NIC,Perches,Address,Continent from farmer where PLR = '" + txtplr.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataReader adr = cmd.ExecuteReader();

                if (adr.Read())
                {
                    txtname.Text = adr.GetString("Name");
                    txtnic.Text = adr.GetString("NIC");
                    txtper.Text = adr.GetString("Perches");
                    txtadd.Text = adr.GetString("Address");
                    txtcon.Text = adr.GetString("Continent");

                    txtplr.ReadOnly = true;
                }
                adr.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            try
            {
                con.Open();
                String query = "select sname,season,qty from sea";
                MySqlCommand mcvs = new MySqlCommand(query, con);
                MySqlDataReader mdr = mcvs.ExecuteReader();
                


                while (mdr.Read())
                {
                    DataGridViewRow dg = new DataGridViewRow();
                    dg.CreateCells(dataGridView1);
                    dg.Cells[0].Value = n;
                    name = mdr.GetString("sname");
                    dg.Cells[1].Value = name;
                    txtsea.Text = mdr.GetString("season");
                    qty = mdr.GetInt32("qty");
                    tper = int.Parse(txtper.Text);
                    tot = qty * tper;
                    dg.Cells[2].Value = tot;
                    dataGridView1.Rows.Add(dg);
                   
                    viewdata obj = new viewdata() { No = n.ToString(), F_Name = name, Qty = tot.ToString() };
                    viewdataBindingSource.Add(obj);
                    viewdataBindingSource.MoveLast();
                    n++;
                }
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();  
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                con.Open();
                string sql = "select *from taxt where PLR='" + txtplr.Text + "'  and year(date)= year(curdate()) ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    msg2.ForeColor = System.Drawing.Color.Red;
                    msg2.Text = "Invalid";
                    MessageBox.Show("Not payed Acre Tax");
                    button1.Enabled = false;
                   


                }
                else
                {
                    msg2.ForeColor = System.Drawing.Color.Yellow;
                    msg2.Text = "Ok";


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

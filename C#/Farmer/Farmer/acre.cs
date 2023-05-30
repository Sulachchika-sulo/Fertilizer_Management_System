using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Farmer
{
    public partial class acre : Form
    {
        private String date;
        public string  b1, n1, p1, a1, c1, ac, t1;

        public acre()
        {
            InitializeComponent();
            date=DateTime.Now.ToString("M/d/yyyy");
        }


        private void printq(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            tax = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.tax.Width / 2), this.tax.Location.Y);
        }
        private Bitmap memoryimg;
        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));

        }
        private void acre_Load(object sender, EventArgs e)
        {
            ldate.Text=date;
            lbill.Text = b1;
            lname.Text = n1;
            lplr.Text = p1;
            ladd.Text = a1;
            ltax.Text = t1;
            lcon.Text = c1;
            la.Text = ac;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
           
            printq(this.tax);


        }
    }
}

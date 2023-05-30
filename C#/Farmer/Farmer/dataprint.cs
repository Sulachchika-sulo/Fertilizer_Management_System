using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer
{
    public partial class dataprint : Form
    {
        List<viewdata> _list;
        string _billno, _plr, _name, _sea, _nic, _con, _add, _date;
 
        public dataprint(List<viewdata>datasource,string billno, string plr,string name,string sea, string nic,string con,string add,string date)
        {
            InitializeComponent();
            _list = datasource;
            _billno = billno;
            _plr = plr;
            _name = name;
            _sea = sea;
            _nic = nic;
            _con = con;
            _add = add;
            _date = date;
        }

        private void dataprint_Load(object sender, EventArgs e)
        {
            viewdataBindingSource.DataSource = _list;
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pbillno",_billno),
                new Microsoft.Reporting.WinForms.ReportParameter("pplr",_plr),
                new Microsoft.Reporting.WinForms.ReportParameter("pname",_name),
                new Microsoft.Reporting.WinForms.ReportParameter("psea",_sea),
                new Microsoft.Reporting.WinForms.ReportParameter("pnic",_nic),
                new Microsoft.Reporting.WinForms.ReportParameter("pcon",_con),
                new Microsoft.Reporting.WinForms.ReportParameter("padd",_add),
                new Microsoft.Reporting.WinForms.ReportParameter("pdate",_date)
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Reporting.WinForms;

namespace QLyBanHangViTinh
{
    public partial class frmrptMatHang : Form
    {
        public frmrptMatHang()
        {
            InitializeComponent();
        }

        private void frmrptMatHang_Load(object sender, EventArgs e)
        {
            string cnstr;
            SqlConnection cn;
            cnstr = ConfigurationManager.ConnectionStrings["cnstrApp"].ConnectionString;
            cn = new SqlConnection(cnstr);

            string sql = "Select * From MatHang";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);

            ReportDataSource rds = new ReportDataSource("tbMatHang", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = @"..\..\rptMatHang.rdlc";
            this.reportViewer1.RefreshReport();
        }

        private void btntruyxuat_Click(object sender, EventArgs e)
        {
            frmrptMatHang frm = new frmrptMatHang();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

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
    public partial class frmrptNhanVien : Form
    {
        public frmrptNhanVien()
        {
            InitializeComponent();
        }

        private void frmrptNhanVien_Load(object sender, EventArgs e)
        {
            string cnstr;
            SqlConnection cn;
            cnstr = ConfigurationManager.ConnectionStrings["cnstrApp"].ConnectionString;
            cn = new SqlConnection(cnstr);

            string sql = "Select * From NhanVien";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);

            ReportDataSource rds = new ReportDataSource("tbNhanVien", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = @"..\..\rptNhanVien.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}

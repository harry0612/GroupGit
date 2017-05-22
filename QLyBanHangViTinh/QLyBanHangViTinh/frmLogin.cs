using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLyBanHangViTinh
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=.;Initial Catalog=QLyVT;Integrated Security=True");
        }
        public DataTable checkLog(string user, string pass)
        {
            string sql = "select * from PhanQuyen where TenDangNhap = '" + user + "' and MatKhau='" + pass + "' ";
            SqlConnection con = getConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        private void btLog_Click(object sender, EventArgs e)
        {
            if (this.txtUser.TextLength == 0 || this.txtPass.TextLength == 0)
            {
                this.lbstatus.ForeColor = Color.Red;
                this.lbstatus.Text = "Ban chua nhap tai khoan hoac mat khau";
            }
            else
            {
                DataTable dt = new DataTable();
                dt = checkLog(this.txtUser.Text, this.txtPass.Text);
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    frmMain frM = new frmMain();
                    frM.Show();
                }
                else
                {
                    this.lbstatus.ForeColor = Color.Red;
                    this.lbstatus.Text = "Tai khoan khong ton tai";
                    this.txtUser.Clear();
                    this.txtPass.Clear();
                    this.txtUser.Focus();
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btLog;
            try
            {
                SqlConnection con = getConnect();
                this.status.Text = "Ket noi co so du lieu thanh cong";
            }
            catch (Exception)
            {

                this.status.Text = "Ket noi co so du lieu that bai";
            }
        }

        private void btRest_Click(object sender, EventArgs e)
        {
            this.txtUser.Clear();
            this.txtPass.Clear();
            this.txtUser.Focus();
            this.lbstatus.ResetText();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Ban co chac muon thoat hay khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
        }
    }
}

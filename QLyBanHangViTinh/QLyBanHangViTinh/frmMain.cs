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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void matHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMatHang frm = new frmMatHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac muon thoat hay khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvien frm = new frmNhanvien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrptMatHang frm = new frmrptMatHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrptNhanVien frm = new frmrptNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

    
    }
}

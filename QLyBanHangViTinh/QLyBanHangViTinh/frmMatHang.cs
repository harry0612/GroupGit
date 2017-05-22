using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLyBanHangViTinh
{
    public partial class frmMatHang : Form
    {
        public frmMatHang()
        {
            InitializeComponent();
        }
        private void LoadData()
        {

            List<MatHang> list = new List<MatHang>();
            list = new MatHangBUS().LoadData();
            gvMatHang.DataSource = list;

        }
        private void frmMatHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gvMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.gvMatHang.Rows[e.RowIndex];
            txtMaMH.Text = row.Cells["MaMatHang"].Value.ToString();
            txtTenMH.Text = row.Cells["TenMatHang"].Value.ToString();
            txtMaNCC.Text = row.Cells["MaNhaCungCap"].Value.ToString();
            txtTenNCC.Text = row.Cells["TenNhaCungCap"].Value.ToString();
            txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
            txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString();
            txtMaLT.Text = row.Cells["MaLoaiTien"].Value.ToString();
            txtNamSX.Text = row.Cells["NamSanXuat"].Value.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                MatHang N = new MatHang(txtMaMH.Text, txtTenMH.Text, txtMaNCC.Text, txtTenNCC.Text, int.Parse(txtDonGia.Text), int.Parse(txtGiaBan.Text), txtMaLT.Text, int.Parse(txtNamSX.Text));
                if (new BUS.MatHangBUS().Insert(N) == 1)
                    MessageBox.Show("Trùng mã mặt hàng");
                else
                    MessageBox.Show("Thêm dữ liệu thành công");
                LoadData();

            }
            catch (Exception)
            {
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                MatHang N = new MatHang(txtMaMH.Text, txtTenMH.Text, txtMaNCC.Text, txtTenNCC.Text, int.Parse(txtDonGia.Text), int.Parse(txtGiaBan.Text), txtMaLT.Text, int.Parse(txtNamSX.Text));
                if (new BUS.MatHangBUS().Delete(N) == 1)
                    MessageBox.Show("Xóa thành công");
                else
                    MessageBox.Show("Không có mã mặt hàng");
                LoadData();

            }
            catch (Exception)
            {
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                MatHang N = new MatHang(txtMaMH.Text, txtTenMH.Text, txtMaNCC.Text, txtTenNCC.Text, int.Parse(txtDonGia.Text), int.Parse(txtGiaBan.Text), txtMaLT.Text, int.Parse(txtNamSX.Text));
                if (new BUS.MatHangBUS().Update(N) == 1)
                    MessageBox.Show("Cập nhật thành công");
                else
                    MessageBox.Show("Mã mặt hàng không tồn tại");
                LoadData();

            }
            catch (Exception)
            {
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Ban co chac muon thoat hay khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            this.txtMaMH.Clear();
            this.txtTenMH.Clear();
            this.txtMaNCC.Clear();
            this.txtTenNCC.Clear();
            this.txtDonGia.Clear();
            this.txtGiaBan.Clear();
            this.txtMaLT.Clear();
            this.txtNamSX.Clear();
            this.txtMaMH.Focus();
        }
    }
}

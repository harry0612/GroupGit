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
    public partial class frmNhanvien : Form
    {
        NhanvienBUS nhanvienh = new NhanvienBUS();
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void LoadData()
        {

            List<Nhanvien> list = new List<Nhanvien>();
            list = new NhanvienBUS().LoadData();
            gvNV.DataSource = list;

        }
        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bttrove_Click(object sender, EventArgs e)
        {
            frmNhanvien_Load(sender, e);
        }

        private void gvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gvNV.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtQuayGD.Text = row.Cells["TenQuayGiaoDich"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSdt.Text = row.Cells["SoDienThoai"].Value.ToString();
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            this.txtMaNV.Clear();
            this.txtHoTen.Clear();
            this.txtQuayGD.Clear();
            this.txtDiaChi.Clear();
            this.txtSdt.Clear();
            this.txtMaNV.Focus();
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                Nhanvien N = new Nhanvien(txtMaNV.Text, txtHoTen.Text, txtQuayGD.Text, txtDiaChi.Text, txtSdt.Text);
                if (new BUS.NhanvienBUS().Insert(N) == 1)
                    MessageBox.Show("Trùng mã nhân viên");
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
                Nhanvien N = new Nhanvien(txtMaNV.Text, txtHoTen.Text, txtQuayGD.Text, txtDiaChi.Text, txtSdt.Text);
                if (new BUS.NhanvienBUS().Delete(N) == 1)
                    MessageBox.Show("Xóa thành công");
                else
                    MessageBox.Show("Không có mã nhân viên");
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
                Nhanvien N = new Nhanvien(txtMaNV.Text, txtHoTen.Text, txtQuayGD.Text, txtDiaChi.Text, txtSdt.Text);
                if (new BUS.NhanvienBUS().Update(N) == 1)
                    MessageBox.Show("Cập nhật thành công");
                else
                    MessageBox.Show("Mã nhân viên không tồn tại");
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
    }
}

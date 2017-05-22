using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class MatHang
    {
        #region 1- Attributes
        private string _maMatHang;
        private string _tenMatHang;
        private string _maNhaCungCap;
        private string _tenNhaCungCap;
        private int _donGia;
        private int _giaBan;
        private string _maLoaiTien;
        private int _namSanXuat;
         #endregion

         #region 2 - Properties
         public string MaMatHang
         {
             get { return _maMatHang; }
             set { _maMatHang = value; }
         }
         public string TenMatHang
         {
             get { return _tenMatHang; }
             set { _tenMatHang = value; }
         }
         public string MaNhaCungCap
         {
             get { return _maNhaCungCap; }
             set { _maNhaCungCap = value; }
         }
         public string TenNhaCungCap
         {
             get { return _tenNhaCungCap; }
             set { _tenNhaCungCap = value; }
         }
         public int DonGia
         {
             get { return _donGia; }
             set { _donGia = value; }
         }
         public int GiaBan
         {
             get { return _giaBan; }
             set { _giaBan = value; }
         }
         public string MaLoaiTien
         {
             get { return _maLoaiTien; }
             set { _maLoaiTien = value; }
         }
         public int NamSanXuat
         {
             get { return _namSanXuat; }
             set { _namSanXuat = value; }
         }
         #endregion

         #region 3 - Contructors
         public MatHang()
         {
             _maMatHang = "";
             _tenMatHang = "";
             _maNhaCungCap = "";
             _tenNhaCungCap = "";
             _donGia = 0;
             _giaBan = 0;
             _maLoaiTien = "";
             _namSanXuat = 0;
         }

         public MatHang(string mmh, string tmh, string mncc, string tncc, int dg, int gb, string mlt, int nsx)
         {
             _maMatHang = mmh;
             _tenMatHang = tmh;
             _maNhaCungCap = mncc;
             _tenNhaCungCap = tncc;
             _donGia = dg;
             _giaBan = gb;
             _maLoaiTien = mlt;
             _namSanXuat = nsx;
         }

         public MatHang(MatHang N)
         {
             _maMatHang = N._maMatHang;
             _tenMatHang = N._tenMatHang;
             _maNhaCungCap = N._maNhaCungCap;
             _tenNhaCungCap = N._tenNhaCungCap;
             _donGia = N._donGia;
             _giaBan = N._giaBan;
             _maLoaiTien = N._maLoaiTien;
             _namSanXuat = N._namSanXuat;
         }

         #endregion
    }
}

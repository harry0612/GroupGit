using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Nhanvien
    {
        #region 1- Attributes
        private string _maNV;
        private string _hoTen;
        private string _tenQuayGiaoDich;
        private string _diaChi;
        private string _soDienThoai;
        #endregion

        #region 2 - Properties
        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }
        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        public string TenQuayGiaoDich
        {
            get { return _tenQuayGiaoDich; }
            set { _tenQuayGiaoDich = value; }
        }
        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        public string SoDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }
        #endregion

        #region 3 - Contructors
        public Nhanvien()
        {
            _maNV = "";
            _hoTen = "";
            _tenQuayGiaoDich = "";
            _diaChi = "";
            _soDienThoai = "";
        }

        public Nhanvien(string mnv, string ht, string tqgd, string dc, string sdt)
        {
            _maNV = mnv;
            _hoTen = ht;
            _tenQuayGiaoDich = tqgd;
            _diaChi = dc;
            _soDienThoai = sdt;
        }

        public Nhanvien(Nhanvien N)
        {
            _maNV = N._maNV;
            _hoTen = N._hoTen;
            _tenQuayGiaoDich = N._tenQuayGiaoDich;
            _diaChi = N._diaChi;
            _soDienThoai = N._soDienThoai;
        }

        #endregion
    }
}

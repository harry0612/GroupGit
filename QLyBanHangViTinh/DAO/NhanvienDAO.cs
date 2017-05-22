using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class NhanvienDAO
    {
        DataProvider dp;
        DataView dwNV;
        DataTable dt;
        SqlDataAdapter ad;
        public NhanvienDAO()
        {
            dp = new DataProvider();
        }
        
        
        #region 1 - Retrieving
        public List<Nhanvien> LoadData()
        {
            try
            {
                dp.Connect();
                string sqlstr = "SELECT * FROM NhanVien";
                List<Nhanvien> list = new List<Nhanvien>();
                SqlDataReader dr = dp.ExecuteReader(sqlstr);
                //List<Nhanvien> list = new List<Nhanvien>();
                while (dr.Read())
                {
                    string maNV = dr.GetString(0);
                    string hoTen = dr.GetString(1);
                    string tenQuayGiaoDich = dr.GetString(2);
                    string diaChi = dr.GetString(3);
                    string soDienThoai = dr.GetString(4);
                    Nhanvien N = new Nhanvien(maNV,hoTen,tenQuayGiaoDich,diaChi,soDienThoai);
                    list.Add(N);
                }
                dr.Close();
                return list;


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dp.Disconnect();
            }
        }

        public void Insert(Nhanvien N)
        {
            try
            {
                dp.Connect();
                string sql = "INSERT INTO Nhanvien VALUES('" + N.MaNV + "', '" + N.HoTen + "', '" + N.TenQuayGiaoDich + "', '" + N.DiaChi + "', " + N.SoDienThoai + ")";
                dp.ExecuteQuery(sql);


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dp.Disconnect();
            }
        }

        public void Delete(Nhanvien n)
        {
            try
            {
                dp.Connect();
                string sql = "Delete from NhanVien where MaNV='" + n.MaNV + "'";
                dp.ExecuteQuery(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dp.Disconnect();
            }
        }

        public void Update(Nhanvien n)
        {
            try
            {
                dp.Connect();
                string sql = "Update NhanVien set HoTen = N'" + n.HoTen + "', TenQuayGiaoDich = '" + n.TenQuayGiaoDich + "', DiaChi = '" + n.DiaChi + "', SoDienThoai = '" + n.SoDienThoai + "' where MaNV = '" + n.MaNV + "' ";
                dp.ExecuteQuery(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dp.Disconnect();
            }
        }
        public int XetTrungMK(Nhanvien N)
        {
            string s = N.MaNV;
            string sql = "IF EXISTS (SELECT * FROM NhanVien WHERE MaNV = '" + s + "') SELECT 1 ELSE SELECT 0";
            try
            {
                dp.Connect();
                SqlCommand cmd = new SqlCommand(sql, dp.CN);
                int n = int.Parse(cmd.ExecuteScalar().ToString());
                return n;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dp.Disconnect();
            }
        }
        #endregion
    }
}

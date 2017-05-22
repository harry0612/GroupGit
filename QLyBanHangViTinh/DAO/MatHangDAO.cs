using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class MatHangDAO
    {
        DataProvider dp;
        public MatHangDAO()
        {
            dp = new DataProvider();
        }

        #region 1 - Retrieving
        public List<MatHang> LoadData()
        {
            try
            {
                dp.Connect();
                string sqlstr = "SELECT * FROM MatHang";
                List<MatHang> list = new List<MatHang>();
                SqlDataReader dr = dp.ExecuteReader(sqlstr);
                //List<MatHang> list = new List<MatHang>();
                while (dr.Read())
                {
                    string maMatHang = dr.GetString(0);
                    string tenMatHang = dr.GetString(1);
                    string maNhaCungCap = dr.GetString(2);
                    string tenNhaCungCap = dr.GetString(3);
                    int donGia = dr.GetInt32(4);
                    int giaBan = dr.GetInt32(5);
                    string maLoaiTien = dr.GetString(6);
                    int namSanXuat = dr.GetInt32(7);
                    MatHang N = new MatHang(maMatHang,tenMatHang,maNhaCungCap,tenNhaCungCap,donGia,giaBan,maLoaiTien,namSanXuat);
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

        public void Insert(MatHang N)
        {
            try
            {
                dp.Connect();
                string sql = "INSERT INTO MatHang VALUES('" + N.MaMatHang + "', '" + N.TenMatHang + "', '" + N.MaNhaCungCap + "', '" + N.TenNhaCungCap + "', '" + N.DonGia + "', '" + N.GiaBan + "', '" + N.MaLoaiTien + "', " + N.NamSanXuat + ")";
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

        public void Delete(MatHang k)
        {
            try
            {
                dp.Connect();
                string sql = "Delete from MatHang where MaMatHang='" + k.MaMatHang + "'";
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

        public void Update(MatHang n)
        {
            try
            {
                dp.Connect();
                string sql = "Update MatHang set TenMatHang = N'" + n.TenMatHang + "', MaNhaCungCap = '" + n.MaNhaCungCap + "', TenNhaCungCap = '" + n.TenNhaCungCap + "', DonGia = '" + n.DonGia + "', GiaBan = '" + n.GiaBan + "', MaLoaiTien = '" + n.MaLoaiTien + "', NamSanXuat = '" + n.NamSanXuat + "' where MaMatHang = '" + n.MaMatHang + "' ";
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
        public int XetTrungMK(MatHang N)
        {
            string s = N.MaMatHang;
            string sql = "IF EXISTS (SELECT * FROM MatHang WHERE MaMatHang = '" + s + "') SELECT 1 ELSE SELECT 0";
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

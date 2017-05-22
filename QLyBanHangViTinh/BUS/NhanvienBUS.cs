using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class NhanvienBUS
    {
        NhanvienDAO da = new NhanvienDAO();
        public List<Nhanvien> LoadData()
        {
            return new NhanvienDAO().LoadData();
        }

        public int Insert(Nhanvien N)
        {
            if (new DAO.NhanvienDAO().XetTrungMK(N) == 1)
                return 1;
            else
            {
                new DAO.NhanvienDAO().Insert(N);
                return 0;
            }
        }

        public int Delete(Nhanvien n)
        {
            if (new DAO.NhanvienDAO().XetTrungMK(n) == 1)
            {
                new DAO.NhanvienDAO().Delete(n);
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Update(Nhanvien n)
        {
            if (new DAO.NhanvienDAO().XetTrungMK(n) == 1)
            {
                new DAO.NhanvienDAO().Update(n);
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}

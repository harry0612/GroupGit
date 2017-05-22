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
    public class MatHangBUS
    {
        public List<MatHang> LoadData()
        {

            return new MatHangDAO().LoadData();
        }

        public int Insert(MatHang N)
        {
            if (new DAO.MatHangDAO().XetTrungMK(N) == 1)
                return 1;
            else
            {
                new DAO.MatHangDAO().Insert(N);
                return 0;
            }
        }

        public int Delete(MatHang n)
        {
            if (new DAO.MatHangDAO().XetTrungMK(n) == 1)
            {
                new DAO.MatHangDAO().Delete(n);
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Update(MatHang n)
        {
            if (new DAO.MatHangDAO().XetTrungMK(n) == 1)
            {
                new DAO.MatHangDAO().Update(n);
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}

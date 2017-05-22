using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DataProvider
    {
        #region 1 - Connection
        const string _cnstr = "Server =.; Database = QLyVT; Integrated Security = true";
        private SqlConnection _cn;

        public SqlConnection CN
        {
            get { return _cn; }
            //set { myVar = value; }
        }

        public DataProvider()
        {
            _cn = new SqlConnection(_cnstr);
        }

        public void Connect()
        {
            try
            {
                if (_cn != null && _cn.State == ConnectionState.Closed)
                    _cn.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void Disconnect()
        {
            try
            {
                if (_cn.State == ConnectionState.Open)
                    _cn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 2 - Execute
        public SqlDataReader ExecuteReader(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, _cn);
            return (cmd.ExecuteReader());
        }

        public void ExecuteQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, _cn);
            cmd.ExecuteNonQuery();
        }
        #endregion
    }
}

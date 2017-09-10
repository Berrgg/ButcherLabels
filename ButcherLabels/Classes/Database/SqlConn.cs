using System;
using System.Data.SqlClient;

namespace ButcherLabels.Classes.Database
{
    public class SqlConn : IConnection
    {
        public string _connectionString { get; private set; }

        public SqlConn(string connectionString)
        {
            if(connectionString != null)
                _connectionString = connectionString;
        }

        public SqlConnection GetSqlConnection()
        {
            SqlConnection sqlConn = new SqlConnection(_connectionString);
            return sqlConn;
        }

        public bool TestConnection()
        {
            var conn = new SqlConnection(_connectionString);

            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
               return false;
               throw new Exception(ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Dispose();
            }
        }
    }
}

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

            using (conn)
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                    return true;
                else
                    return false;
            }
        }
    }
}

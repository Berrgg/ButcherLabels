using System.Data;
using System.Data.SqlClient;


namespace ButcherLabels.Classes.Database
{
    public class SqlDataTable
    {
        public SqlConnection _sqlConnection { get; private set; }

        public static DataTable GetDatatable(SqlConnection sqlConn, string sqlQuery)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery,sqlConn);

            dataAdapter.Fill(dt);
            return dt;
        }
    }
}

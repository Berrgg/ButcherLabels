using System;
using System.Data;
using ButcherLabels.Classes.Database;

namespace ButcherLabels
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            SetButchersLabels();
          //  ConnectionString();
        }

        private void ConnectionString()
        {
            var conn = new SqlConn(SIConnectionString());

            if(conn.TestConnection())
                Console.WriteLine("OK");
            else
                Console.WriteLine("Wrong");
        }

        private string SIConnectionString()
        {
            string server = ("10.3.1.7");
            string database = ("Production");
            string user = ("siuser");
            string passwd = ("si");

            var connStr = new SqlConnectionString(server, database, user, passwd);
            return connStr.ConnString();
        }

        private void SetButchersLabels()
        {
            var sqlQuery = ("SELECT * FROM tblFactory");
            var sqlConn = new SqlConn(SIConnectionString());
            var sqlDatatable = new SqlDataTable();
            var dt = new DataTable();
            dt = SqlDataTable.GetDatatable(sqlConn.GetSqlConnection(), sqlQuery);
        }
    }
}

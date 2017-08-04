using System;
using ButcherLabels.Classes.Database;

namespace ButcherLabels
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
          //  ConnectionString();
        }

        private void ConnectionString()
        {
            var connectionString = new SqlConnectionString("10.3.1.7", "Production", "siuser", "si");
            var conn = new SqlConn(connectionString);

            if(conn.TestConnection())
                Console.WriteLine("OK");
            else
                Console.WriteLine("Wrong");
        }

        private void SetButchersLabels()
        {

        }
    }
}

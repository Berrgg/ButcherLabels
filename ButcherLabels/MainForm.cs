using System;
using System.Data;
using System.Windows.Forms;
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

        private void navBtnSettings_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage2;

            var sett = Properties.Settings.Default;
            txtServer.EditValue = sett.ServerQNS;
            txtDatabase.EditValue = sett.Database;
            txtDatabaseSI.EditValue = sett.DatabaseSI;
            txtUserName.EditValue = sett.User;
            txtUserNameSI.EditValue = sett.UserSI;
            txtPassword.EditValue = sett.Password;
            txtPasswordSI.EditValue = sett.PasswordSI;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage1;
        }

        private void navBtnExit_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var sett = Properties.Settings.Default;
            sett.ServerQNS = txtServer.Text;
            sett.Database = txtDatabase.Text;
            sett.DatabaseSI = txtDatabaseSI.Text;
            sett.User = txtUserName.Text;
            sett.UserSI = txtUserNameSI.Text;
            sett.Password = txtPassword.Text;
            sett.PasswordSI = txtPasswordSI.Text;
            sett.Save();
        }
    }
}

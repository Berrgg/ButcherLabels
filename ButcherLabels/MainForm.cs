using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using ButcherLabels.Classes.Database;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace ButcherLabels
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            SetButchersLabels();
        }

        private string SIConnectionString()
        {
            var settings = Properties.Settings.Default;
            var connStr = new SqlConnectionString(settings.ServerQNS,settings.DatabaseSI,settings.UserSI,settings.PasswordSI);
            return connStr.ConnString();
        }

        private string DbConnectionString()
        {
            var settings = Properties.Settings.Default;
            var connStr = new SqlConnectionString(settings.ServerQNS, settings.Database, settings.User, settings.Password);
            return connStr.ConnString();
        }

        private void SetButchersLabels()
        {
            var sqlConn = new SqlConn(DbConnectionString());

            try
            {
                if (sqlConn.TestConnection())
                {
                    var sqlDatatable = new SqlDataTable();
                    var dt = new DataTable();

                    var sqlQuery = "SELECT * FROM tblFactory";
                    dt = SqlDataTable.GetDatatable(sqlConn.GetSqlConnection(), sqlQuery);
                    SetControlsLookUpEdit(lookUpEdit_Factory, dt, "FactoryName", "IdFactory", "Factory");

                    sqlQuery = "SELECT * FROM tblCustomer";
                    dt = SqlDataTable.GetDatatable(sqlConn.GetSqlConnection(), sqlQuery);
                    SetControlsLookUpEdit(lookUpEdit_Customer, dt, "CustomerName", "IdCustomer", "Customer");

                    sqlQuery = "SELECT * FROM tblShift";
                    dt = SqlDataTable.GetDatatable(sqlConn.GetSqlConnection(), sqlQuery);
                    SetControlsLookUpEdit(lookUpEdit_Shift, dt, "Shift", "IdShift", "Shift");
                }
                else
                    throw new Exception("Unexpected error when tried to connect to server");
            }
            catch (Exception Ex)
            {
                var message = string.Format(Ex.Message);
                var title = "Database connection";
                XtraMessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetControlsLookUpEdit(LookUpEdit control, DataTable dataTable, string displayMember, string valueMember,
                                            string caption)
        {
            var _control = control.Properties;
            _control.DataSource = null;
            _control.DataSource = dataTable;
            _control.DisplayMember = displayMember;
            _control.ValueMember = valueMember;
            _control.AppearanceDropDown.FontSizeDelta = 12;
            _control.AppearanceDropDownHeader.FontSizeDelta = 12;
  
            LookUpColumnInfoCollection column = _control.Columns;
            column.Clear();
            column.Add(new LookUpColumnInfo(displayMember, caption));
        }

        #region Events
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

        #endregion
    }
}

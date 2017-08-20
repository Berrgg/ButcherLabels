using System;
using System.Data;
using System.Windows.Forms;
using ButcherLabels.Classes.Database;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;

namespace ButcherLabels
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            SetButchersLabels();
            SetControlValidation_ButcherLabels();
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
                    var sqlQuery = string.Empty; 

                    sqlQuery = "SELECT * FROM tblCustomer";
                    dt = SqlDataTable.GetDatatable(sqlConn.GetSqlConnection(), sqlQuery);
                    SetControlsLookUpEdit(lookUpEdit_Customer, dt, "CustomerName", "IdCustomer", "Customer");

                    sqlQuery = "SELECT * FROM tblShift";
                    dt = SqlDataTable.GetDatatable(sqlConn.GetSqlConnection(), sqlQuery);
                    SetControlsLookUpEdit(lookUpEdit_Shift, dt, "Shift", "IdShift", "Shift");
                }
                else
                    throw new Exception("Unexpected error when tried to connect to server and download data.");
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

        private void SetControlsLookUpEditProductList()
        {
            var sqlConn = new SqlConn(DbConnectionString());
            var sett = Properties.Settings.Default;
            int factoryId = sett.Factory;
            string customerId = lookUpEdit_Customer.EditValue.ToString();
            string sqlQuery = "SELECT * FROM v_ButcherLabelsProductList WHERE IdCustomer=" + customerId + " AND IdFactory="+factoryId+"";
            var dt = new DataTable();
            dt = SqlDataTable.GetDatatable(sqlConn.GetSqlConnection(), sqlQuery);

            var control = lookUpEdit_Product.Properties;
            control.DataSource = null;
            control.DataSource = dt;
            control.DisplayMember = "Description";
            control.ValueMember = "ProdCode";
            control.AppearanceDropDown.FontSizeDelta = 10;
            control.AppearanceDropDownHeader.FontSizeDelta = 10;

            LookUpColumnInfoCollection columns = control.Columns;
            columns.Clear();
            columns.Add(new LookUpColumnInfo("ProdCode", 150, "Code"));
            columns.Add(new LookUpColumnInfo("Description", 400,"Description"));
            columns.Add(new LookUpColumnInfo("CustomerName", 120, "Customer"));
            columns.Add(new LookUpColumnInfo("LabelType", 100, "Label"));
        }

        private ConditionValidationRule EmptyFieldValidationRule()
        {
            var validationRule = new ConditionValidationRule();
            validationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            validationRule.ErrorText = "Field cannot be empty";
            validationRule.ErrorType = ErrorType.Critical;

            return validationRule;
        }

        private void SetControlValidation_ButcherLabels()
        {
            var emptyValidationRule = new ConditionValidationRule();
            emptyValidationRule = EmptyFieldValidationRule();

            dxValidationProvider1.SetValidationRule(dateEdit_ProdDate, emptyValidationRule);
            dxValidationProvider1.SetValidationRule(lookUpEdit_Customer, emptyValidationRule);
            dxValidationProvider1.SetValidationRule(lookUpEdit_Shift, emptyValidationRule);
            dxValidationProvider1.SetValidationRule(lookUpEdit_Product, emptyValidationRule);
            dxValidationProvider1.SetValidationRule(textEdit_Barcode, emptyValidationRule);
        }

        private void ValidateControlsButcherLabels()
        {
            dxValidationProvider1.Validate(dateEdit_ProdDate);
            dxValidationProvider1.Validate(lookUpEdit_Customer);
            dxValidationProvider1.Validate(lookUpEdit_Shift);
            dxValidationProvider1.Validate(lookUpEdit_Product);
            dxValidationProvider1.Validate(textEdit_Barcode);
        }

        private void GetDataFromSI()
        {
            var sqlConn = new SqlConn(SIConnectionString());

            try
            {
                if (sqlConn.TestConnection())
                {
                    var sqlDt = new SqlDataTable();
                    var sqlQuery = string.Empty;
                    var dt = new DataTable();

                    sqlQuery = "select inventorybatch.product, inventory.description, lot, batchno, palletid, udf1, udf2, udf3, " +
                                "udf4, killdate, origqty " +
                                "from inventorybatch join inventory on inventorybatch.product = inventory.product " +
                                "where palletid = '111000083844'";
                    dt = SqlDataTable.GetDatatable(sqlConn.GetSqlConnection(), sqlQuery);
                }
                else
                    throw new Exception("Unexpected error when tried to connect to SI database and download data.");
            }
            catch (Exception ex)
            {
                var message = string.Format(ex.Message);
                var title = "SI database connection";
                XtraMessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void navBtnHome_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage3;
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

        private void btnFactoryQNS_Click(object sender, EventArgs e)
        {
            var sett = Properties.Settings.Default;
            sett.Factory = Convert.ToInt32(((SimpleButton)sender).Tag);
            sett.Save();
            navigationFrame1.SelectedPage = navigationPage1;
        }

        private void btnFactoryEK_Click(object sender, EventArgs e)
        {
            var sett = Properties.Settings.Default;
            sett.Factory = Convert.ToInt32(((SimpleButton)sender).Tag);
            sett.Save();
            navigationFrame1.SelectedPage = navigationPage1;
        }

        private void lookUpEdit_Customer_EditValueChanged(object sender, EventArgs e)
        {
            SetControlsLookUpEditProductList();
        }

        private void lookUpEdit_Product_EditValueChanged(object sender, EventArgs e)
        {
            textEdit_Group.Text = lookUpEdit_Product.GetColumnValue("MachineName").ToString();
            string color = lookUpEdit_Product.GetColumnValue("LabelType").ToString();
            lblColorLabel.Text = string.Format("Please ensure that the {0} labels are loaded in the printer.", color);
        }

        private void simpleButton_PrintLabel_Click(object sender, EventArgs e)
        {
            ValidateControlsButcherLabels();

            if(dxValidationProvider1.GetInvalidControls().Count <= 0)
            {
                GetDataFromSI();
            }

        }
       #endregion

    }
}

using System;
using System.Data;
using System.Windows.Forms;
using ButcherLabels.Classes;
using ButcherLabels.Classes.Database;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Grid;

namespace ButcherLabels
{
    public partial class MainForm : XtraForm
    {
        private DataTable _butcherLabelsTable;
        private SqlQueryBatchPallet.PalletBatchField _batchOrPallet { get; set; }

        public MainForm()
        {
            InitializeComponent();
            SetButchersLabels();
            SetControlValidation_ButcherLabels();
            SetDataTableForGridViewBatch();
            SetGridViewBatchControl();
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

                    lookUpEdit_Product.Enabled = false;
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

            lookUpEdit_Product.Enabled = true;
            lblColorLabel.Text = string.Empty;

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
          //  dxValidationProvider1.SetValidationRule(textEdit_Barcode, emptyValidationRule);
        }

        private void ValidateControlsButcherLabels()
        {
            dxValidationProvider1.Validate(dateEdit_ProdDate);
            dxValidationProvider1.Validate(lookUpEdit_Customer);
            dxValidationProvider1.Validate(lookUpEdit_Shift);
            dxValidationProvider1.Validate(lookUpEdit_Product);
         //   dxValidationProvider1.Validate(textEdit_Barcode);
        }

        private void GetDataFromSI(string barCode)
        {
            var sqlConn = new SqlConn(SIConnectionString());
            DataTable dt = new DataTable();

            try
            {
                if (sqlConn.TestConnection())
                {
                    var sqlQuery = string.Empty;
                    string batchPallet = string.Empty;

                    switch (barCode.Length)
                    {
                        case 14:
                            batchPallet = barCode.Substring(2);
                            _batchOrPallet = SqlQueryBatchPallet.PalletBatchField.palletid;
                            sqlQuery = SqlQueryBatchPallet.SelectPalletBatch(_batchOrPallet, batchPallet);
                            break;
                        case 22:
                            batchPallet = barCode.Substring(0, 12);
                            _batchOrPallet = SqlQueryBatchPallet.PalletBatchField.batchno;
                            sqlQuery = SqlQueryBatchPallet.SelectPalletBatch(_batchOrPallet, batchPallet);
                            break;  
                        default:
                            batchPallet = barCode;
                            _batchOrPallet = SqlQueryBatchPallet.PalletBatchField.batchno;
                            sqlQuery = SqlQueryBatchPallet.SelectPalletBatch(_batchOrPallet, batchPallet);
                            break;
                    }

                    if(_butcherLabelsTable != null)
                    {
                        dt = SqlDataTable.GetDatatable(sqlConn.GetSqlConnection(), sqlQuery);
                        _butcherLabelsTable.Merge(dt);
                    }
                    else
                    {
                        dt = SqlDataTable.GetDatatable(sqlConn.GetSqlConnection(), sqlQuery);
                        _butcherLabelsTable = dt;
                    }
                    AddDataToGridView(dt);
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

        private void SetDataTableForGridViewBatch()
        {
            DataTable dt = new DataTable("Batch");
            dt.Columns.Add("Code",typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("KillDate", typeof(DateTime));
            dt.Columns.Add("Weight", typeof(decimal));
            dt.Columns.Add("Batch", typeof(string));

            gridControl_Batch.DataSource = dt;
        }

        private void SetGridViewBatchControl()
        {
            GridView gv = (GridView)(gridControl_Batch.MainView);
            gv.Columns[0].Width = 50;
            gv.Columns[1].Width = 200;
            gv.Columns[3].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gv.Columns[3].DisplayFormat.FormatString = "n2";

            gv.OptionsSelection.EnableAppearanceFocusedCell = false;
            gv.OptionsSelection.EnableAppearanceFocusedRow = false;
            gv.OptionsSelection.EnableAppearanceHideSelection = false;

            gv.OptionsCustomization.AllowSort = false;
        }

        private void AddDataToGridView(DataTable dataTable)
        {
            DataTable gridDataTable = (DataTable)(gridControl_Batch.DataSource);

            foreach (DataRow dr in dataTable.Rows)
            {
                DataRow newRow = gridDataTable.NewRow();
                newRow[0] = dr[0];
                newRow[1] = dr[1];
                newRow[2] = dr[8];
                newRow[3] = dr[9];

                gridDataTable.Rows.Add(newRow);
            }
        }

        private void InsertLabelDataIntoDatabase(int BatchNumber)
        {
            var sqlConnection = new SqlConn(DbConnectionString());
          //  DataTable dt = _butcherLabelsTable;

            foreach (DataRow dr in _butcherLabelsTable.Rows)
            {
                var insert = new InsertCommand(sqlConnection.GetSqlConnection());

                insert.ProductionDate = (DateTime)(dateEdit_ProdDate.EditValue);
                insert.ProdCode = lookUpEdit_Product.GetColumnValue("ProdCode").ToString();
                insert.ProdDescription = lookUpEdit_Product.Text;
                insert.Customer = lookUpEdit_Customer.Text;
                insert.Shift = lookUpEdit_Shift.Text;
                insert.LabelDescription = lookUpEdit_Product.GetColumnValue("LabelType").ToString();
                insert.RawMaterialCode = dr["product"].ToString();
                insert.RawMaterialDescription = dr["description"].ToString();

                switch (_batchOrPallet)
                {
                    case SqlQueryBatchPallet.PalletBatchField.palletid:
                        insert.PalletId = dr["palletid"].ToString();
                        break;
                    case SqlQueryBatchPallet.PalletBatchField.batchno:
                        insert.BatchNumber = dr["batchno"].ToString();
                        break;
                    default:
                        break;
                }

                insert.Udf2 = dr["udf2"].ToString();
                insert.Udf3 = dr["udf3"].ToString();
                insert.Udf4 = dr["udf4"].ToString();
                insert.KillDate = (DateTime)(dr["killdate"]);   
                insert.Lot = dr["lot"].ToString();
                insert.LabelBatchNumber = BatchNumber;
                insert.Weight = (decimal)(dr["Weight"]);
                insert.FactoryId = Properties.Settings.Default.Factory;

                insert.ExecuteInsertLabel();
            }
        }

        private void GetDataForGridViewBatch()
        {
            try
            {
                string sqlQuery = string.Empty;
                DataTable dt = new DataTable("Batch");
                var sqlConn = new SqlConn(DbConnectionString());

                sqlQuery = "SELECT RawMaterialCode AS Code, RawMaterialDescription AS Description, KillDate, Weight, LabelBatchNumber AS Batch "+
                            "FROM tblButcherLabelsData "+
                            "WHERE ProductionDate = '"+ string.Format("{0:MM/dd/yyyy}", dateEdit_ProdDate.EditValue) + "' AND "+
                            "Customer='"+ lookUpEdit_Customer.Text +"' AND Shift='"+ lookUpEdit_Shift.Text +"' AND "+
                            "ProdCode='"+ lookUpEdit_Product.GetColumnValue("ProdCode").ToString() + "' AND "+
                            "FactoryId='"+ Properties.Settings.Default.Factory +"'";
                dt = SqlDataTable.GetDatatable(sqlConn.GetSqlConnection(), sqlQuery);
                gridControl_Batch.DataSource = null;
                gridControl_Batch.DataSource = dt;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Download data from database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddLabelBatchNumberToGridView(DataTable GridViewDataTable, int BatchNumber, string ColumnName)
        {
            foreach (DataRow dr in GridViewDataTable.Rows)
            {
                if (dr.IsNull(ColumnName))
                    dr[ColumnName] = BatchNumber;
            }
        }

        private bool CanTakeDataForGridView()
        {
            if (lookUpEdit_Customer.Text != string.Empty && lookUpEdit_Shift.Text != string.Empty && lookUpEdit_Product.Text != string.Empty)
                return true;
            else
                return false;
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
            dateEdit_ProdDate.EditValue = DateTime.Today;
        }

        private void btnFactoryEK_Click(object sender, EventArgs e)
        {
            var sett = Properties.Settings.Default;
            sett.Factory = Convert.ToInt32(((SimpleButton)sender).Tag);
            sett.Save();
            navigationFrame1.SelectedPage = navigationPage1;
            dateEdit_ProdDate.EditValue = DateTime.Today;
        }

        private void lookUpEdit_Customer_EditValueChanged(object sender, EventArgs e)
        {
            SetControlsLookUpEditProductList();
            gridControl_Batch.DataSource = null;
            if (CanTakeDataForGridView()) GetDataForGridViewBatch();
        }

        private void lookUpEdit_Product_EditValueChanged(object sender, EventArgs e)
        {
            textEdit_Group.Text = lookUpEdit_Product.GetColumnValue("MachineName").ToString();
            string color = lookUpEdit_Product.GetColumnValue("LabelType").ToString();
            lblColorLabel.Text = string.Format("Please ensure that the {0} labels are loaded in the printer.", color);
            if(CanTakeDataForGridView()) GetDataForGridViewBatch();
        }

        private void lookUpEdit_Shift_EditValueChanged(object sender, EventArgs e)
        {
            if (CanTakeDataForGridView()) GetDataForGridViewBatch();
        }

        private void simpleButton_PrintLabel_Click(object sender, EventArgs e)
        {
            ValidateControlsButcherLabels();

            if(dxValidationProvider1.GetInvalidControls().Count <= 0)
            {
                DataTable gridControlDataTable = (DataTable)(gridControl_Batch.DataSource);
                int batchNumber = Functions.MaxNumber(gridControlDataTable, "Batch") + 1;

                AddLabelBatchNumberToGridView(gridControlDataTable, batchNumber, "Batch");
                InsertLabelDataIntoDatabase(batchNumber);
                textEdit_Barcode.EditValue = null;
                textEdit_Barcode.Enabled = true;
            }
        }

        private void textEdit_Barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textEdit_Barcode.Enabled = false;
                GetDataFromSI(textEdit_Barcode.Text);
            }
        }

        private void gridView_Batch_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
          if (e.RowHandle >= 0)
            {
                string category = view.GetRowCellDisplayText(e.RowHandle, view.Columns["Batch"]);
                if (category == string.Empty)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Yellow;
                }
            }
      }

        private void simpleButton_Cancel_Click(object sender, EventArgs e)
        {
            DataTable gridDataTable = (DataTable)(gridControl_Batch.DataSource);
            if(gridDataTable != null && gridDataTable.Rows.Count > 0)
                gridDataTable.Rows.RemoveAt(gridDataTable.Rows.Count - 1);

            if(_butcherLabelsTable != null && _butcherLabelsTable.Rows.Count > 0)
                _butcherLabelsTable.Rows.RemoveAt(_butcherLabelsTable.Rows.Count - 1);

            textEdit_Barcode.EditValue = null;
            textEdit_Barcode.Enabled = true;
        }
        #endregion

    }
}

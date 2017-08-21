using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ButcherLabels.Classes
{
    public class InsertCommand
    {
        private SqlConnection _connection;
        public Nullable<System.DateTime> ProductionDate { get; set; }
        public string ProdCode { get; set; } = string.Empty;
        public string ProdDescription { get; set; } = string.Empty;
        public string Customer { get; set; } = string.Empty;
        public string Shift { get; set; } = string.Empty;
        public string LabelDescription { get; set; } = string.Empty;
        public string RawMaterialDescription { get; set; } = string.Empty;
        public string BatchNumber { get; set; } = string.Empty;
        public string PalletId { get; set; } = string.Empty;
        public string Udf2 { get; set; } = string.Empty;
        public string Udf3 { get; set; } = string.Empty;
        public string Udf4 { get; set; } = string.Empty;
        public Nullable<System.DateTime> KillDate { get; set; }
        public string Lot { get; set; } = string.Empty;
        public int LabelBatchNumber { get; set; } = 0;
        public double Weight { get; set; } = 0.00;

        public InsertCommand(SqlConnection connection)
        {
            _connection = connection;
        }

        public void ExecuteInsertLabel()
        {
            try
            {
                _connection.Open();
                string sqlQuery = "INSERT INTO dbo.tblButcherLabelsData(ProductionDate, ProdCode, ProdDescription, Customer, Shift, LabelDescription, RawMaterialDescription, BatchNumber, PalletID, Udf2, Udf3, Udf4, KillDate, Lot, LabelBatchNumber, Weight) " +
                                    "VALUES(@ProductionDate, @ProdCode, @ProdDescription, @Customer, @Shift, @LabelDescription, @RawMaterialDescription, @BatchNumber, @PalletId, @Udf2, @Udf3, @Udf4, @Killdate, @Lot, @LabelBatchNumber, @Weight)";

                SqlCommand cmd = new SqlCommand(sqlQuery, _connection);
                cmd.Parameters.Add("@ProductionDate", SqlDbType.DateTime).Value = ProductionDate;
                cmd.Parameters.Add("@ProdCode", SqlDbType.VarChar).Value = ProdCode;
                cmd.Parameters.Add("@ProdDescription", SqlDbType.VarChar).Value = ProdDescription;
                cmd.Parameters.Add("@Customer", SqlDbType.VarChar).Value = Customer;
                cmd.Parameters.Add("@Shift", SqlDbType.VarChar).Value = Shift;
                cmd.Parameters.Add("@LabelDescription", SqlDbType.VarChar).Value = LabelDescription;
                cmd.Parameters.Add("@RawMaterialDescription", SqlDbType.VarChar).Value = RawMaterialDescription;
                cmd.Parameters.Add("@BatchNumber", SqlDbType.VarChar).Value = BatchNumber;
                cmd.Parameters.Add("@PalletId", SqlDbType.VarChar).Value = PalletId;
                cmd.Parameters.Add("Udf2", SqlDbType.VarChar).Value = Udf2;
                cmd.Parameters.Add("@Udf3", SqlDbType.VarChar).Value = Udf3;
                cmd.Parameters.Add("@Udf4", SqlDbType.VarChar).Value = Udf4;
                cmd.Parameters.Add("@KillDate", SqlDbType.DateTime).Value = KillDate;
                cmd.Parameters.Add("@Lot", SqlDbType.VarChar).Value = Lot;
                cmd.Parameters.Add("@LabelBatchNumber", SqlDbType.Int).Value = LabelBatchNumber;
                cmd.Parameters.Add("@Weight", SqlDbType.Decimal).Value = Weight;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
               // throw new Exception("An error occured when during INSERT data to tblButcherLabelsData.");
            }
            finally
            {
                if (_connection != null)
                    _connection.Dispose();
            }
        }

    }
}

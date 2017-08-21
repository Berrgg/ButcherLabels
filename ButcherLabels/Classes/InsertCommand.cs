using System;
using System.Data.SqlClient;
using System.Data;

namespace ButcherLabels.Classes
{
    public class InsertCommand
    {
        private SqlConnection _connection;
        public Nullable<System.DateTime> ProductionDate { get; set; }
        public string ProdCode { get; set; }
        public string ProdDescription { get; set; }
        public string Customer { get; set; }
        public string Shift { get; set; }
        public string LabelDescription { get; set; }
        public string RawMaterialDescription { get; set; }
        public string BatchNumber { get; set; }
        public string PalletId { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public Nullable<System.DateTime> KillDate { get; set; }
        public string Lot { get; set; }
        public int LabelBatchNumber { get; set; }
        public double Weight { get; set; }
        public int IdFactory { get; set; }

        public InsertCommand(SqlConnection connection)
        {
            _connection = connection;
        }

        public void ExecuteInsertLabel()
        {
            try
            {
                _connection.Open();
                string sqlQuery = "INSERT INTO dbo.tblButcherLabelsData(ProductionDate, ProdCode, ProdDescription, Customer, Shift, LabelDescription, RawMaterialDescription, BatchNumber, PalletID, Udf2, Udf3, Udf4, KillDate, Lot, LabelBatchNumber, Weight, IdFactory) " +
                                    "VALUES(@ProductionDate, @ProdCode, @ProdDescription, @Customer, @Shift, @LabelDescription, @RawMaterialDescription, @BatchNumber, @PalletId, @Udf2, @Udf3, @Udf4, @Killdate, @Lot, @LabelBatchNumber, @Weight, @IdFactory)";

                SqlCommand cmd = new SqlCommand(sqlQuery, _connection);
                cmd.Parameters.Add("@ProductionDate", SqlDbType.DateTime).Value = (object)ProductionDate ?? DBNull.Value;
                cmd.Parameters.Add("@ProdCode", SqlDbType.VarChar).Value = (object)ProdCode ?? DBNull.Value;
                cmd.Parameters.Add("@ProdDescription", SqlDbType.VarChar).Value = (object)ProdDescription ?? DBNull.Value;
                cmd.Parameters.Add("@Customer", SqlDbType.VarChar).Value = (object)Customer ?? DBNull.Value;
                cmd.Parameters.Add("@Shift", SqlDbType.VarChar).Value = (object)Shift ?? DBNull.Value;
                cmd.Parameters.Add("@LabelDescription", SqlDbType.VarChar).Value = (object)LabelDescription ?? DBNull.Value;
                cmd.Parameters.Add("@RawMaterialDescription", SqlDbType.VarChar).Value = (object)RawMaterialDescription ?? DBNull.Value;
                cmd.Parameters.Add("@BatchNumber", SqlDbType.VarChar).Value = (object)BatchNumber ?? DBNull.Value;
                cmd.Parameters.Add("@PalletId", SqlDbType.VarChar).Value = (object)PalletId ?? DBNull.Value;
                cmd.Parameters.Add("Udf2", SqlDbType.VarChar).Value = (object)Udf2 ?? DBNull.Value;
                cmd.Parameters.Add("@Udf3", SqlDbType.VarChar).Value = (object)Udf3 ?? DBNull.Value;
                cmd.Parameters.Add("@Udf4", SqlDbType.VarChar).Value = (object)Udf4 ?? DBNull.Value;
                cmd.Parameters.Add("@KillDate", SqlDbType.DateTime).Value = (object)KillDate ?? DBNull.Value;
                cmd.Parameters.Add("@Lot", SqlDbType.VarChar).Value = (object)Lot ?? DBNull.Value;
                cmd.Parameters.Add("@LabelBatchNumber", SqlDbType.Int).Value = (object)LabelBatchNumber ?? 0;
                cmd.Parameters.Add("@Weight", SqlDbType.Decimal).Value = (object)Weight ?? 0.00;
                cmd.Parameters.Add("@IdFactory", SqlDbType.Int).Value = (object)IdFactory ?? DBNull.Value;
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

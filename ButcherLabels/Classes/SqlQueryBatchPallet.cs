
namespace ButcherLabels.Classes
{
    public static class SqlQueryBatchPallet
    {
        public enum PalletBatchField
        {
            palletid,
            batchno,
        };

        public static string SelectPalletBatch(PalletBatchField field, string palletId)
        {
            string select1 = "SELECT inventorybatch.product, inventory.description, lot, ";
            string select2 = field.ToString();
            string select3 = ", udf1, udf2, udf3, udf4, killdate, sum(origqty) as Weight ";
            string from = "FROM inventorybatch join inventory on inventorybatch.product = inventory.product ";
            string where = "WHERE palletid = ";
            string param1 = "'" + palletId + "'";
            string groupBy = "Group by inventorybatch.product, inventory.description, lot, ";
            string groupByParam = "palletid";
            string groupBy2 = ", udf1, udf2, udf3, udf4, killdate";
            return string.Concat(select1, select2, select3, from, where, param1, groupBy, groupByParam, groupBy2);
        }
    }
}

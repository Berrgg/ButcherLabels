using System;
using System.Data;

namespace ButcherLabels.Classes
{
    public static class Functions
    {
        public static int MaxNumber(DataTable dt, string ColumnName)
        {
            int max = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (!dr.IsNull(ColumnName))
                {
                    int number = dr.Field<int>(ColumnName);
                    max = Math.Max(number, max);
                }
            }
            return max;
        }
    }
}

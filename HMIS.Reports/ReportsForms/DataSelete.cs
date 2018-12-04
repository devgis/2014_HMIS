using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FYSOFT.HMIS.Reports.ReportsForms
{
    public class DataSelete
    {
        public static DataTable Select(DataTable Source, String FilterExpression)
        {
            DataTable DataResult = Source.Clone();
            DataRow[] dr = Source.Copy().Select(FilterExpression);
            foreach (DataRow drTemp in dr)
            {
                DataRow drNew = DataResult.NewRow();
                for (int i = 0; i < DataResult.Columns.Count; i++)
                {
                    drNew[i] = drTemp[i];
                }
                DataResult.Rows.Add(drNew);
            }
            return DataResult;
        }
    }
}

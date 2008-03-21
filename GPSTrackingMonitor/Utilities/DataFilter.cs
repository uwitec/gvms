using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GPSTrackingMonitor.Utilities
{
    class DataFilter
    {
        public static List<object> GetDistinctRowsFromDataTable(DataTable dataSource,string fieldName)
        {
            if (dataSource == null || string.IsNullOrEmpty(fieldName)) throw new ArgumentNullException();
            if (!dataSource.Columns.Contains(fieldName)) throw new ArgumentException("fieldName");

            DataRow[] drTemps = dataSource.Select("", fieldName + " desc");
            object oPreValue = new object();
            object oCurValue = oPreValue;
            int iIndex = 0;

            List<object> oResult = new List<object>();

            foreach (DataRow dr in drTemps)
            {
                oCurValue = dr[fieldName];

                if (oPreValue != oCurValue || iIndex == 0)
                {
                    oResult.Add(oCurValue);
                    oPreValue = oCurValue;
                }

                iIndex++;
            }

            return oResult;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GPSTrackingMonitor.TrackingReplay
{
    class TrackingData
    {
        public static TrackingReplay.TrackPoints GetHistoryTrackingData(string carNumber,DateTime startTime,DateTime endTime)
        {
            if (startTime - endTime > new TimeSpan() || string.IsNullOrEmpty(carNumber))
                return new TrackPoints();

            System.Data.OleDb.OleDbConnection oConn = BaseHandler.DatabaseManager.GetOleDbConnection(GlobeVariables.HistToryTrackingRecorderDatabase);

            string sDataTableName = GlobeVariables.HistoryTrackingRecorderDatatableName;
            string sQueryString = string.Format("select distinct * from {0} where carnumber='{1}'", sDataTableName, carNumber);
            
            DataTable dtTrackings = BaseHandler.DatabaseManager.GetData(oConn, sQueryString);
            //string sFilterString = string.Format("currentTime >= #{0}# and currentTime <= #{1}#", startTime.ToString() + "." + startTime.Millisecond.ToString(), endTime.ToString() + "." + endTime.Millisecond.ToString());

            //dtTrackings.Columns["currenttime"].Expression = "convert(currenttime,'System.DateTime')";
            //dtTrackings.Columns["currenttime"].DataType = typeof(DateTime);
            //DataRow[] drResults = dtTrackings.Select(sFilterString, "currenttime desc");
            
            TrackPoints oInputData = ConvertDataTableToTrackingPoints(dtTrackings,startTime,endTime);
            oInputData.Sort((new BaseHandler.MyComparison<TrackingReplay.TrackPoint>()).GetComparison(GPSTrackingMonitor.BaseHandler.ComparisonType.ASC));

            return oInputData;
        }

        private static TrackingReplay.TrackPoints ConvertDataTableToTrackingPoints(DataTable trackingTable)
        {
            TrackingReplay.TrackPoints oTrackingPoints = new TrackPoints();
            TrackingReplay.TrackPoint oTrackingPoint;

            foreach (DataRow dr in trackingTable.Rows)
            {
                oTrackingPoint = new TrackPoint();

                oTrackingPoint.ID = Int32.Parse(dr["geoid"].ToString());
                oTrackingPoint.X = double.Parse(dr["x"].ToString());
                oTrackingPoint.Y = double.Parse(dr["y"].ToString());
                oTrackingPoint.TimeStamp = DateTime.Parse(dr["currenttime"].ToString());

                oTrackingPoints.Add(oTrackingPoint);
            }

            return oTrackingPoints;
        }

        private static TrackingReplay.TrackPoints ConvertDataTableToTrackingPoints(DataTable trackingTable, DateTime startTime, DateTime endTime)
        {
            TrackingReplay.TrackPoints oTrackingPoints = new TrackPoints();
            TrackingReplay.TrackPoint oTrackingPoint;
            DateTime tCurTime;

            foreach (DataRow dr in trackingTable.Rows)
            {
                tCurTime = DateTime.Parse(dr["currenttime"].ToString());
                if (!(tCurTime >= startTime && tCurTime <= endTime))
                    continue;

                oTrackingPoint = new TrackPoint();

                oTrackingPoint.ID = Int32.Parse(dr["geoid"].ToString());
                oTrackingPoint.X = double.Parse(dr["x"].ToString());
                oTrackingPoint.Y = double.Parse(dr["y"].ToString());
                oTrackingPoint.TimeStamp = tCurTime;

                oTrackingPoints.Add(oTrackingPoint);
            }

            return oTrackingPoints;
        }
    }
}

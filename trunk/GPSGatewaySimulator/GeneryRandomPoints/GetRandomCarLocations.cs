using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GPSGatewaySimulator.RandomPoints
{
    class GetRandomCarLocations
    {
        public Queue<CommnicationMessage.GPSTrackingMessage> GetCarLocationsQueue()
        {
            DataTable dtTemp = new DataTable();

            System.Data.OleDb.OleDbConnection oConn = BaseHandler.DatabaseManager.GetOleDbConnection(GlobeVariables.RandomPointsDBPath);
            
            int iRowsCount = BaseHandler.DatabaseManager.GetColumnMaximmValue(oConn, "carlocation", "geoid");
            Random oRandomGeoId = new Random();
            string sGeoId = oRandomGeoId.Next(0, iRowsCount).ToString();

            string sQueryString = string.Format("select * from carlocation where geoid={0}", sGeoId);
            dtTemp = BaseHandler.DatabaseManager.GetData(oConn, sQueryString);

            Queue<CommnicationMessage.GPSTrackingMessage> oQueueResult = new Queue<CommnicationMessage.GPSTrackingMessage>();
            foreach (DataRow dr in dtTemp.Rows)
            {
                oQueueResult.Enqueue(HistoryTrakings.DataStructConverter.DataRowToCommInfos(dr));
            }

            return oQueueResult;
        }

        
    }
}

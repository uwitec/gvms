using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GPSGatewaySimulator.RandomPoints
{
    class GetRandomCarLocations
    {
        #region public methods

        public Queue<CommnicationMessage.GPSTrackingMessage> GetCarLocationsQueue()
        {
            DataTable dtTemp = new DataTable();

            System.Data.OleDb.OleDbConnection oConn = BaseHandler.DatabaseManager.GetOleDbConnection(GlobeVariables.RandomPointsDBPath);
            
            int iMaxValue = BaseHandler.DatabaseManager.GetColumnMaximmValue(oConn, "carlocation", "OrderIndex");
            Random oRandomIndex = new Random();
            string sOrderIndex = oRandomIndex.Next(0, iMaxValue).ToString();

            string sQueryString = string.Format("select * from carlocation where orderindex={0}", sOrderIndex);
            dtTemp = BaseHandler.DatabaseManager.GetData(oConn, sQueryString);

            Queue<CommnicationMessage.GPSTrackingMessage> oQueueResult = new Queue<CommnicationMessage.GPSTrackingMessage>();
            foreach (DataRow dr in dtTemp.Rows)
            {
                oQueueResult.Enqueue(HistoryTrakings.DataStructConverter.DataRowToCommInfos(dr));
            }

            return oQueueResult;
        }

        #endregion
    }
}

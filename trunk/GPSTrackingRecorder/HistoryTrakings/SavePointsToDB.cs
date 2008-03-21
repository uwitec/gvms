using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using GPSTrackingRecorder.RandomPoints;

namespace GPSTrackingRecorder.HistoryTrackings
{
    class SavePointsToDB
    {
        #region public methods

        public static void SaveToDB(Queue<CommnicationMessage.GPSTrackingMessage> carInfosQueue)
        {
            DataTable dtResult = new TrackingDataTableStruct();
            OleDbConnection oConn = BaseHandler.DatabaseManager.GetOleDbConnection(GlobeVariables.HistoryPointsDBPath);
            string sTableName = "historyTracking";

            while (carInfosQueue.Count != 0)
            {
                DataRow dr = dtResult.NewRow();

                CommnicationMessage.GPSTrackingMessage oCarInfos = carInfosQueue.Dequeue();
                HistoryTrackings.DataStructConverter.CommInfosToDataRow(oCarInfos, ref dr);

                dtResult.Rows.Add(dr);
            }
           
            SavePointsToDB.LoadPointsToDB(oConn, sTableName, dtResult);
        }

        public static void LoadPointsToDB(OleDbConnection connection, string tableNameInDB, DataTable pointsTable)
        {
            int iCarCount = 30;     //设置车辆数目
            string[] sCarNumberAndPhones = new string[iCarCount];

            for (int i = 0; i < iCarCount; i++)
            {
                sCarNumberAndPhones[i] = GeneryRandomString.GetRandomString(RandomStringType.NumberAndChar, 10, i) + "#" + GeneryRandomString.GetRandomString(RandomStringType.OnlyNumber, 11, i);
            }

            connection.Open();
            OleDbCommand oCmd = new OleDbCommand();
            oCmd.Connection = connection;
            oCmd.CommandText = string.Format("insert into {0}(GeoID,CarNumber,X,Y,Phone,Direction,CurrentTime) values(?,?,?,?,?,?,?)", tableNameInDB);

            Random rnd = new Random();
            DateTime oBaseTime = DateTime.Now;

            foreach (DataRow dr in pointsTable.Rows)
            {
                string[] sCarNumberAndPhone = sCarNumberAndPhones[rnd.Next(0, iCarCount - 1)].Split('#');
                string sCarNumber = sCarNumberAndPhone[0];
                string sPhone = sCarNumberAndPhone[1];
                oBaseTime = oBaseTime.AddMilliseconds(1234);

                oCmd.Parameters.Clear();
                oCmd.Parameters.AddWithValue("@GeoID", dr["GeoId"]);
                oCmd.Parameters.AddWithValue("@CarNumber", sCarNumber);
                oCmd.Parameters.AddWithValue("@X", dr["x"]);
                oCmd.Parameters.AddWithValue("@Y", dr["y"]);
                oCmd.Parameters.AddWithValue("@Phone", sPhone);
                oCmd.Parameters.AddWithValue("@Direction", GeneryRandomString.GetRandomString(RandomStringType.OnlyNumber, 2, pointsTable.Rows.IndexOf(dr)));
                oCmd.Parameters.AddWithValue("@CurrentTime", oBaseTime.AddMilliseconds(1234).ToString() + "." + oBaseTime.Millisecond.ToString());

                oCmd.ExecuteNonQuery();
            }

            connection.Close();
        }


        public static void DeleteAllPointsInDB(OleDbConnection connection, string tableNameInDB)
        {
            string sCmd = "delete from " + tableNameInDB;

            connection.Open();
            OleDbCommand oCmd = new OleDbCommand(sCmd, connection);
            oCmd.ExecuteNonQuery();

            connection.Close();
        }

        #endregion
    }
}

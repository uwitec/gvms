using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace GPSGatewaySimulator.RandomPoints
{
    public class LoadRandomPointToDB
    {   
        private string _preGeoId;
        private string[] _carInfos;
        private int _orderIndex;

        #region public methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="tableNameInDB"></param>
        /// <param name="pointsTable"></param>
        public void LoadPointsToDB(OleDbConnection connection,string tableNameInDB, DataTable pointsTable)
        {
            int iCarCount = GlobeVariables.DefaultCarNumber;     //设置车辆数目
            string[] sCarNumberAndPhones = new string[iCarCount];

            for (int i = 0; i < iCarCount; i++)
            {
                sCarNumberAndPhones[i] =  GeneryRandomString.GetRandomString(RandomStringType.NumberAndChar, 8,i) + "#" + GeneryRandomString.GetRandomString(RandomStringType.OnlyNumber, 11,i);
            }

            connection.Open();
            OleDbCommand oCmd = new OleDbCommand();
            oCmd.Connection = connection;
            oCmd.CommandText = string.Format("insert into {0}(GeoID,CarNumber,X,Y,Phone,Direction,CurrentTime,OrderIndex) values(?,?,?,?,?,?,?,?)", tableNameInDB);

            Random rnd = new Random();
            DateTime oBaseTime = DateTime.Now;
            this._carInfos = sCarNumberAndPhones[rnd.Next(0, iCarCount - 1)].Split('#');
            this._orderIndex = 0;

            foreach (DataRow dr in pointsTable.Rows)
            {
                //如果需要根据线段的条数来决定车辆数，请去掉以下注释
               // if (dr["GeoId"].ToString() != this._preGeoId) 
               // {
                    this._carInfos = sCarNumberAndPhones[rnd.Next(0,iCarCount - 1)].Split('#');
                    this._orderIndex=0;
             //   }

                //this._preGeoId = dr["GeoId"].ToString();
                string sCarNumber = this._carInfos[0];
                string sPhone = this._carInfos[1];
                this._orderIndex++;
                oBaseTime = Convert.ToDateTime(dr["currenttime"]);

                oCmd.Parameters.Clear();
                oCmd.Parameters.AddWithValue("@GeoID", dr["GeoId"]);
                oCmd.Parameters.AddWithValue("@CarNumber",sCarNumber);
                oCmd.Parameters.AddWithValue("@X",dr["x"]);
                oCmd.Parameters.AddWithValue("@Y",dr["y"]);
                oCmd.Parameters.AddWithValue("@Phone", sPhone);
                oCmd.Parameters.AddWithValue("@Direction", GeneryRandomString.GetRandomString(RandomStringType.OnlyNumber, 2,pointsTable.Rows.IndexOf(dr)));
                oCmd.Parameters.AddWithValue("@CurrentTime", oBaseTime.ToString("yyyy-MM-dd HH:mm:ss") + "." + oBaseTime.Millisecond.ToString());
                oCmd.Parameters.AddWithValue("@OrderIndex", this._orderIndex.ToString());
                
                oCmd.ExecuteNonQuery();
            }

            connection.Close(); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="tableNameInDB"></param>
        public void DeleteAllPointsInDB(OleDbConnection connection,string tableNameInDB)
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

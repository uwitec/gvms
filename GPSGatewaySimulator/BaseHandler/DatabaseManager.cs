using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using MapObjects2;


namespace GPSGatewaySimulator.BaseHandler
{
    class DatabaseManager
    {
        #region public methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="DBPath"></param>
        /// <returns></returns>
        public static OleDbConnection GetOleDbConnection(string DBPath)
        {
            string sConn = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0}; User Id=; Password=;", DBPath);

            OleDbConnection oConn = new OleDbConnection(sConn);
            
            try
            {
                oConn.Open();
            }
            catch
            {
                throw;// new Exception("���ݿ����ӷ����쳣����ȷ��ָ�������ݿ�·����ȷ.");
            }
            finally
            {
                if (oConn.State == ConnectionState.Open)
                    oConn.Close();
            }

            return oConn;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public static DataTable GetData(OleDbConnection connection, string queryString)
        {
            DataTable dtResult = null;

            try
            {
                connection.Open();

                OleDbCommand oCmd = new OleDbCommand(queryString, connection);
                OleDbDataAdapter oAdpter = new OleDbDataAdapter(oCmd);

                dtResult = new DataTable();
                oAdpter.Fill(dtResult);

                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message,ex.InnerException);
            }

            return dtResult;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="tableName"></param>
        /// <param name="keyFieldName"></param>
        /// <returns></returns>
        public static int GetColumnMaximmValue(OleDbConnection connection, string tableName, string keyFieldName)
        {
            string sQueryString = string.Format("select max({0}) as maxvalue from {1}", keyFieldName, tableName);

            DataTable dtTemp = DatabaseManager.GetData(connection, sQueryString);

            if (dtTemp == null)
                return 0;

            return Convert.ToInt32(dtTemp.Rows[0]["maxvalue"]);
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace GPSTrackingMonitor.BaseHandler
{
    class DatabaseManager
    {
        #region public methods

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
                throw new Exception("数据库连接发生异常，请确定指定的数据库路径正确.");
            }
            finally
            {
                if (oConn.State == ConnectionState.Open)
                    oConn.Close();
            }

            return oConn;
        }

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
                throw new Exception(ex.Message, ex.InnerException);
            }

            return dtResult;
        }

        public static int GetColumnMaximmValue(OleDbConnection connection, string tableName, string keyFieldName)
        {
            string sQueryString = string.Format("select max({0}) as maxvalue from {1}", keyFieldName, tableName);

            DataTable dtTemp = DatabaseManager.GetData(connection, sQueryString);

            if (dtTemp == null)
                return 0;

            return Convert.ToInt32(dtTemp.Rows[0]["maxvalue"]);
        }

        public static string[] GetTablesNameFromDatabase(OleDbConnection connection)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

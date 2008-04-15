using System;
using System.Collections.Generic;
using System.Text;

namespace GPSTrackingMonitor.Configures
{
    [Serializable]
    class TrackingReplayConfigureStruct
    {  
        #region fields
    
        private DatabaseTypeEnum _databaseType = DatabaseTypeEnum.Unknown;
        private string _databaseUserName = string.Empty;
        private string _databasePassword = string.Empty;
        private string _databaseServerAdress = string.Empty;
        private int _databasePort = 0;
        private string _localDatabaseLocation = string.Empty;
        private string _trackingTableName = string.Empty;

        #endregion

        #region properties

        /// <summary>
        /// 
        /// </summary>
        public DatabaseTypeEnum DatabaseType
        {
            get { return this._databaseType; }
            set { this._databaseType = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string DatabaseUserName
        {
            get { return this._databaseUserName; }
            set { this._databaseUserName = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string DatabasePassword
        {
            get { return this._databasePassword; }
            set { this._databasePassword = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string DatabaseServerAdress
        {
            get { return this._databaseServerAdress; }
            set { this._databaseServerAdress = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int DatabasePort
        {
            get { return this._databasePort; }
            set { this._databasePort = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string LocalDatabaseLocation
        {
            get { return this._localDatabaseLocation; }
            set { this._localDatabaseLocation = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string TrackingTableName
        {
            get { return this._trackingTableName; }
            set { this._trackingTableName = value; }
        }

        #endregion
    }
}

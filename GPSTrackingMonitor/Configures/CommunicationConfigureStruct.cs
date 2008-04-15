using System;
using System.Collections.Generic;
using System.Text;

namespace GPSTrackingMonitor.Configures
{
    [Serializable]
    class CommunicationConfigureStruct
    {
        #region fields

        private string _messageServerAddress = string.Empty;
        private int _localMessageLiseningPort = 820527;

        #endregion

        #region properties

        /// <summary>
        /// 
        /// </summary>
        public string MessageServerAddress
        {
            get { return this._messageServerAddress; }
            set { this._messageServerAddress = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int LocalMessageLiseningPort
        {
            get { return this._localMessageLiseningPort; }
            set { this._localMessageLiseningPort = value; }
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GPSTrackingMonitor.Configures
{
    [Serializable]
    class CommunicationConfigureInfos
    {
        #region fields

        private int _liseningPort;

        #endregion

        #region properties

        public int LiseningPort
        {
            get { return this._liseningPort; }
            set { this._liseningPort = value; }
        }

        #endregion
    }
}

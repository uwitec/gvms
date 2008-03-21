using System;
using System.Collections.Generic;
using System.Text;

namespace GPSTrackingMonitor.Configures
{
    [Serializable]
    class ConfigureInfos
    {
        #region fields

        private CommunicationConfigureInfos _communicationConfigure;

        #endregion

        #region public properties

        public CommunicationConfigureInfos CommunicationConfigure
        {
            get { return this._communicationConfigure; }
            set { this._communicationConfigure = value; }
        }

        #endregion

    }
}

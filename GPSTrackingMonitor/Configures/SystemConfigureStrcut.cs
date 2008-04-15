using System;
using System.Collections.Generic;
using System.Text;

namespace GPSTrackingMonitor.Configures
{
    [Serializable]
    class SystemConfigureStrcut
    {
        #region fields

        private string _projectFilePath = string.Empty;
        private int _maxOfMessageCache = 100;
        private int _intervalCarUpdate = 1000;

        #endregion

        #region properties

        /// <summary>
        /// 
        /// </summary>
        public string ProjectFilePath
        {
            get { return this._projectFilePath; }
            set { this._projectFilePath = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int MaxOfMessageCache
        {
            get { return this._maxOfMessageCache; }
            set { this._maxOfMessageCache = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int IntervalCarUpdate
        {
            get { return this._intervalCarUpdate; }
            set { this._intervalCarUpdate = value; }
        }

        #endregion
    }
}

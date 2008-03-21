using System;
using System.Collections.Generic;
using System.Text;

namespace GPSTrackingMonitor.Communications
{
    public class MessageArguments:EventArgs
    {
        #region fields

        private MessagePool _messageCollection = new MessagePool();

        #endregion

        #region constructor

        public MessageArguments()
        {
        }

        public MessageArguments(MessagePool messageCollection)
        {
            this._messageCollection = messageCollection;
        }

        #endregion

        #region properties

        public MessagePool MessageCollection
        {
            get { return this._messageCollection; }
            set { this._messageCollection = value; }
        }

        #endregion

    }
}

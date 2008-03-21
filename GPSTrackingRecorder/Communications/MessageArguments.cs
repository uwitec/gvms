using System;
using System.Collections.Generic;
using System.Text;

namespace GPSTrackingRecorder.Communications
{
    class MessageArguments:EventArgs
    {
        #region fields

        private CommnicationMessage.GPSTrackingMessage _message;

        #endregion

        #region constructors

        public MessageArguments()
        {
        }

        public MessageArguments(CommnicationMessage.GPSTrackingMessage message)
        {
            this._message = message;
        }

        #endregion

        #region properties

        public CommnicationMessage.GPSTrackingMessage Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        #endregion

    }
}

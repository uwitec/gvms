using System;
using System.Collections.Generic;
using System.Text;


namespace GPSGatewaySimulator.Communications
{
    class MessageArguments:EventArgs
    {
        #region fields

        /// <summary>
        /// 
        /// </summary>
        private CommnicationMessage.GPSTrackingMessage _message;

        #endregion

        #region constructors

        /// <summary>
        /// 
        /// </summary>
        public MessageArguments()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public MessageArguments(CommnicationMessage.GPSTrackingMessage message)
        {
            this._message = message;
        }

        #endregion

        #region properties

        /// <summary>
        /// 
        /// </summary>
        public CommnicationMessage.GPSTrackingMessage Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        #endregion

    }
}

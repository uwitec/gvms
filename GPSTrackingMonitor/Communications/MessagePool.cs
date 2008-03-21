using System;
using System.Collections.Generic;
using System.Text;

namespace GPSTrackingMonitor.Communications
{
    public class MessagePool : System.Collections.Generic.Dictionary<string, CommnicationMessage.GPSTrackingMessage>
    {
        public MessagePool CurrentCacheCopy()
        {
            return this.MemberwiseClone() as MessagePool;
        }
    }
}

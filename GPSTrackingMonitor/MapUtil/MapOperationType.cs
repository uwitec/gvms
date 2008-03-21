using System;
using System.Collections.Generic;
using System.Text;

namespace GPSTrackingMonitor.MapUtil
{
    /// <summary>
    /// 
    /// </summary>
    public enum MapOperationType
    {   
        /// <summary>
        /// 
        /// </summary>
        None = 0,

        /// <summary>
        /// 
        /// </summary>
        ZoomIn = 1,

        /// <summary>
        /// 
        /// </summary>
        ZoomOut = 2,

        /// <summary>
        /// 
        /// </summary>
        Pan = 3,

        /// <summary>
        /// 
        /// </summary>
        FullExtent = 4,

        /// <summary>
        /// 
        /// </summary>
        Preview = 5,

        /// <summary>
        /// 
        /// </summary>
        NextView = 6,

        /// <summary>
        /// 
        /// </summary>
        Identify = 7,

        /// <summary>
        /// 
        /// </summary>
        Measure = 8,

        /// <summary>
        /// 
        /// </summary>
        Refresh = 9,

        /// <summary>
        /// 
        /// </summary>
        Clear = 10,

        /// <summary>
        /// 
        /// </summary>
        FetchPoint = 11
    }
}

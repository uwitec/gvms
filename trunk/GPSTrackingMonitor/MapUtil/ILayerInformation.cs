using System;
using System.Collections.Generic;
using System.Text;
using MapObjects2;

namespace GPSTrackingMonitor.MapUtil
{
    /// <summary>
    /// 
    /// </summary>
    class ILayerInformation
    {
        /// <summary>
        /// 
        /// </summary>
        string LayerName;

        /// <summary>
        /// 
        /// </summary>
        string DataSource;

        /// <summary>
        /// 
        /// </summary>
        double MinVisibleScale;

        /// <summary>
        /// 
        /// </summary>
        double MaxVisibleScale;

        /// <summary>
        /// 
        /// </summary>
        MOLayerType LayerType;

        /// <summary>
        /// 
        /// </summary>
        ShapeTypeConstants ShapeType;
    }

    /// <summary>
    /// 
    /// </summary>
    public enum MOLayerType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageLayer = 1,

        /// <summary>
        /// 
        /// </summary>
        VectorLayer = 2
    }
}

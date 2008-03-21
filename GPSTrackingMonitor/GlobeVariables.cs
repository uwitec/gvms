/******************************************************
 * Create Author : lionyue
 * Create Date   : 2007.12.19
 * 
 * Use:
 *      1、存放系统中的静态常量
 *      2、作为一个中间层，为各个窗体之间传递内部数据
 * 
 * Last Modify Author :
 * Last Modify Date   :
 * 
 * *****************************************************/


using System;
using System.Collections.Generic;
using System.Text;

namespace GPSTrackingMonitor
{
    class GlobeVariables
    {
        public static List<MapUtil.LayerInformations> LayersInformationSet = new List<GPSTrackingMonitor.MapUtil.LayerInformations>();

        public static MapUtil.MapOperationType CurrentOperation = new GPSTrackingMonitor.MapUtil.MapOperationType();

        public static AxMapObjects2.AxMap MapControl = new AxMapObjects2.AxMap();

        public static string ConfigureFileName = System.Windows.Forms.Application.StartupPath + "\\" + "configure.xml";

        public static RealtimeMonite.TrackingDataTableStruct RealtimeCarInfosTable = new RealtimeMonite.TrackingDataTableStruct();

        public static Communications.SocketClient CarInfosReceiver = new GPSTrackingMonitor.Communications.SocketClient();

        public static string HistToryTrackingRecorderDatabase = @"Q:\项目\SIOGR项目\GPSTracking\trunk\GPSTrackingRecorder\bin\Debug\data\HistoryPoints.mdb";

        public static string HistoryTrackingRecorderDatatableName = "HistoryTracking";

        public static int MaxMessagesCacheCount = 1000;

        public static GPSTrackingMonitor.Communications.MessagePool MessagesCache = new GPSTrackingMonitor.Communications.MessagePool();

        public static int IntervalUpdate = 1000;//单位：毫秒
        
    }
}

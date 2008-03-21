using System;
using System.Collections.Generic;
using System.Text;

namespace GPSTrackingRecorder
{
    class GlobeVariables
    {    
        /// <summary>
        /// 车辆历史位置信息数据库的路径
        /// </summary>
        public static string HistoryPointsDBPath = System.Windows.Forms.Application.StartupPath + @"\data\historypoints.mdb";

        /// <summary>
        /// 默认监听端口
        /// </summary>
        public static readonly int DefaultLiseningPort = 8205;

        /// <summary>
        /// 默认gps网关服务器地址
        /// </summary>
        public static readonly string DefaultServerIP = "10.10.10.213";

        /// <summary>
        /// 队列默认容量
        /// </summary>
        public static readonly int DefaultQueueMax = 100;
    }
}

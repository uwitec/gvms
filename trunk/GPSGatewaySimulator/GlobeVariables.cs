using System;
using System.Collections.Generic;
using System.Text;

namespace GPSGatewaySimulator
{
    class GlobeVariables
    {
        /// <summary>
        /// 车辆随机位置信息数据库的路径
        /// </summary>
        public static string RandomPointsDBPath = System.Windows.Forms.Application.StartupPath + @"\data\randompoints.mdb";

        /// <summary>
        /// socket客户端接收数据的默认端口
        /// </summary>
        public static readonly int DefaultReceivePort = 8205;

        /// <summary>
        /// socket服务端发送消息的默认间隔时间
        /// </summary>
        public static readonly int DefaultSendInterval = 1000;

        /// <summary>
        /// 设置模拟的车辆数目
        /// </summary>
        public static readonly int DefaultCarNumber = 1000;

    }
}

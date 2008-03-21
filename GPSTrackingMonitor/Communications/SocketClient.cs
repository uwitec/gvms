using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace GPSTrackingMonitor.Communications
{
    class SocketClient
    {
        #region fields

        private Thread _thread;        
        private Socket _socket;
        private int _listeningPort = 8205;
        private string _serverIP = Dns.GetHostAddresses(Dns.GetHostName())[0].ToString();
        private bool _connectionClosed = false;
        private System.Windows.Forms.Timer _timer;

        #endregion

        #region properties

        /// <summary>
        /// 本地监听端口
        /// </summary>
        public int ListenigPort
        {
            get { return this._listeningPort; }
            set { this._listeningPort = value; }
        }

        /// <summary>
        /// 服务器IP
        /// </summary>
        public string ServerIP
        {
            get { return this._serverIP; }
            set { this._serverIP = value; }
        }

        #endregion

        #region constructors

        public SocketClient()
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="serverIP">服务器IP</param>
        /// <param name="listeningPort">本地监听端口</param>
        public SocketClient(string serverIP, int listeningPort)
        {
            this._serverIP = serverIP;
            this._listeningPort = listeningPort;
        }

        #endregion

        #region public methods

        /// <summary>
        /// 开始接收消息
        /// </summary>
        /// <param name="serverIP"></param>
        /// <param name="listeningPort"></param>
        public void StartReceiveMessage()
        {
            try
            {
                this.InitSocket(this._serverIP, this._listeningPort);

                if (this._thread == null || this._thread.ThreadState == ThreadState.Stopped)
                    this._thread = new Thread(new ThreadStart(ReceiveMessages));

                if (this._thread != null && this._thread.ThreadState == ThreadState.Unstarted)
                {
                    this._connectionClosed = false;
                    this._thread.Start();
                }

                if (this._timer == null || this._timer.Enabled == false)
                {
                    this._timer = new System.Windows.Forms.Timer();
                    this._timer.Interval = GlobeVariables.IntervalUpdate;
                    this._timer.Tick += new EventHandler(_timer_Tick);

                    this._timer.Start();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            this.OnProcessMessage(new MessageArguments(GlobeVariables.MessagesCache.CurrentCacheCopy()));
        }

        /// <summary>
        /// 停止接收消息
        /// </summary>
        public void StopReceiveMessage()
        {
            try
            {
                this._connectionClosed = true;

                if (this._thread != null && this._thread.IsAlive)
                {
                    this._thread.Abort();
                    this._thread.Join();
                }

                if (this._socket != null && this._socket.IsBound)
                {
                    this._socket.Shutdown(SocketShutdown.Receive);
                    this._socket.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region private methods

        /// <summary>
        /// 初始化socket
        /// </summary>
        /// <param name="serverIP"></param>
        /// <param name="listeningPort"></param>
        private void InitSocket(string serverIP, int listeningPort)
        {
            IPEndPoint oIPEndPoint = new IPEndPoint(this.ParseIP(serverIP), listeningPort);
            this._socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            this._socket.Bind(oIPEndPoint);
        }

        /// <summary>
        /// 在监听端口上循环读取消息（采用的是阻塞式的接收方式）
        /// </summary>
        private void ReceiveMessages()
        {
            do
            {
                //本地取消命令发生时，终止循环监听（目前还不能通过远程服务器的消息指令来终止循环）
                if (this._connectionClosed == true) break;

                byte[] oBuffer = new byte[10240];
                int iMessageLength = this._socket.Receive(oBuffer);
                CommnicationMessage.GPSTrackingMessage oMessage = (CommnicationMessage.GPSTrackingMessage)CommnicationMessage.ObjectSerialize.DeserializeBytesToObject(oBuffer, iMessageLength, CommnicationMessage.ObjectSerialize.SeralizeFormatType.BinaryFormat);

                if (GlobeVariables.MessagesCache.ContainsKey(oMessage.CarNumber)) GlobeVariables.MessagesCache.Remove(oMessage.CarNumber);
                
                GlobeVariables.MessagesCache.Add(oMessage.CarNumber, oMessage);
            }
            while (true);
        }

        /// <summary>
        /// 解析IP地址
        /// </summary>
        /// <param name="ipString">ip字符串</param>
        /// <returns></returns>
        private IPAddress ParseIP(string ipString)
        {
            try
            {
                return Dns.GetHostAddresses(ipString)[0];
            }
            catch
            {
                throw new Exception("请确定您输入的IP地址正确.");
            }
        }

        #endregion

        #region events

        /// <summary>
        /// 消息处理委托事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void ProcessMessageHandler(object sender, MessageArguments e);

        /// <summary>
        /// 消息处理委托事件实例
        /// </summary>
        public event ProcessMessageHandler ProcessMessageEvent;

        /// <summary>
        /// 抛出消息处理事件
        /// </summary>
        /// <param name="e"></param>
        protected void OnProcessMessage(MessageArguments e)
        {
            if (this.ProcessMessageEvent != null && e.MessageCollection != null)
                ProcessMessageEvent(null, e);
        }

        #endregion

        #region IDisposable 成员

        public void Dispose()
        {
            this.StopReceiveMessage();

            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool dispoisng)
        {
            if (dispoisng)
            {
                if (this._thread != null)
                {
                    this._thread = null;
                }

                if (this._socket != null)
                    this._socket = null;               
            }
        }

        #endregion
    }
}

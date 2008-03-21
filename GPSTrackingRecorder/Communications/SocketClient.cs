using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace GPSTrackingRecorder.Communications 
{
    class SocketClient:IDisposable
    {
        #region fields

        private Queue<CommnicationMessage.GPSTrackingMessage> _messageCollection;
        private int _queueMaxCount = 50;


        private Thread _thread;
        private Socket _socket;
        private int _listeningPort = 8205;
        private string _serverIP = Dns.GetHostAddresses(Dns.GetHostName())[0].ToString();
        private bool _connectionClosed = false;

        #endregion

        #region properties

        /// <summary>
        /// 消息队列的容量，当队列中达到这个值时，队列中的数据将保存到数据库中去。
        /// </summary>
        public int QueueMaxCount
        {
            get { return this._queueMaxCount; }
            set { this._queueMaxCount = value; }
        }


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
                    this._messageCollection = new Queue<CommnicationMessage.GPSTrackingMessage>();

                    this._thread.Start();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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

                    if(this._messageCollection != null && this._messageCollection.Count > 0)
                        HistoryTrackings.SavePointsToDB.SaveToDB(this._messageCollection);   
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
        private void InitSocket(string serverIP,int listeningPort)
        {
            IPEndPoint oIPEndPoint = new IPEndPoint(this.ParseIP(serverIP), listeningPort);
            this._socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            this._socket.Bind(oIPEndPoint);
        }

        /// <summary>
        /// 在监听端口上循环读取消息
        /// </summary>
        private void ReceiveMessages()
        {  
            //do
            //{
            //    byte[] oBuffer = new byte[10240];
            //    int iMessageLength = this._socket.Receive(oBuffer);
            //    CommnicationMessage.GPSTrackingMessage oMessage = (CommnicationMessage.GPSTrackingMessage)CommnicationMessage.ObjectSerialize.DeserializeBytesToObject(oBuffer, iMessageLength, CommnicationMessage.ObjectSerialize.SeralizeFormatType.BinaryFormat);

            //    this.OnProcessMessage(new MessageArguments(oMessage));
            //    //this._messageCollection.Enqueue(oMessage);


            //    if (this._messageCollection.Count == this._queueMaxCount)
            //        HistoryTrakings.SavePointsToDB.SaveToDB(this._messageCollection);                

            //    //if (this._messageCollection.Count == this._queueMaxCount)
            //    //    HistoryTrakings.SavePointsToDB.SaveToDB(this._messageCollection);                

            //}
            //while (true);

            do
            {
                //本地取消命令发生时，终止循环监听（目前还不能通过远程服务器的消息指令来终止循环）
                if (this._connectionClosed == true) break;

                byte[] oBuffer = new byte[10240];
                int iMessageLength = this._socket.Receive(oBuffer);
                CommnicationMessage.GPSTrackingMessage oMessage = (CommnicationMessage.GPSTrackingMessage)CommnicationMessage.ObjectSerialize.DeserializeBytesToObject(oBuffer, iMessageLength, CommnicationMessage.ObjectSerialize.SeralizeFormatType.BinaryFormat);

                this.OnProcessMessage(new MessageArguments(oMessage));
                this._messageCollection.Enqueue(oMessage);

                if (this._messageCollection.Count == this._queueMaxCount)
                    HistoryTrackings.SavePointsToDB.SaveToDB(this._messageCollection);   
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
            if (this.ProcessMessageEvent != null && e.Message != null)
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSGatewaySimulator
{
    public partial class frmMain : Form
    {
        #region fields

        private Communications.SocketServer _socketServer = new GPSGatewaySimulator.Communications.SocketServer();
        private Communications.SocketClient _socketClient = new GPSGatewaySimulator.Communications.SocketClient();
        private HistoryTrakings.TrackingDataTableStruct _tableTrackingPoints = new GPSGatewaySimulator.HistoryTrakings.TrackingDataTableStruct();
        private int _port = 0;
        private int _interval = 0;
        private int _simulatedCarNumner = 0;


        #endregion

        #region constructors

        public frmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region private methods

        private void InitDataGridView()
        {
            this._tableTrackingPoints.DefaultView.AllowDelete = true;
            this.dgvRealtimeDataView.DataSource = this._tableTrackingPoints.DefaultView;
            this.dgvRealtimeDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this._tableTrackingPoints.DefaultView.ListChanged += new ListChangedEventHandler(DefaultView_ListChanged);

            foreach (DataColumn col in this._tableTrackingPoints.Columns)
            {
                DataGridViewColumn colView = dgvRealtimeDataView.Columns[col.ColumnName];
                colView.HeaderText = col.Caption;
            }
        }

        private void InitControlState()
        {
            this.tlsStartViewRealtimeData.Enabled = true;
            this.tlsStopViewRealtimeData.Enabled = false;
            this.tlsStartSimulator.Enabled = true;
            this.tlsStopSimulator.Enabled = false;

        }

        #endregion

        #region events

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.InitControlState();
            this.InitDataGridView();
        }

        void DefaultView_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (this._tableTrackingPoints.DefaultView.Count == 100)
                this.tlsClearRealtimeData_Click(this.tlsClearRealtimeData, EventArgs.Empty);
        }

        private void tslStartSimulator_Click(object sender, EventArgs e)
        {
            frmSendMessage oFrmSendMessage = new frmSendMessage();

            if (oFrmSendMessage.ShowDialog() != DialogResult.OK)
            {
                this._port = GlobeVariables.DefaultReceivePort;
                this._interval = GlobeVariables.DefaultSendInterval;
                this._simulatedCarNumner = GlobeVariables.DefaultCarNumber;
            }
            else
            {
                this._interval = oFrmSendMessage.Interval;
                this._port = oFrmSendMessage.Port;
                this._simulatedCarNumner = oFrmSendMessage.SimulatedCarNumber;
            }

            this._socketServer.Intervalue = this._interval;
            this._socketServer.RemoteLiseningPort = this._port;
            this._socketServer.StartSendMessage();

            this.tlsStartSimulator.Enabled = false;
            this.tlsStopSimulator.Enabled = true;
            this.lblServerInfos.Text = string.Format("接收端口：{0}    间隔时间：{1}毫秒", this._port.ToString(), this._interval.ToString());
        }

        private void tlsStopSimulator_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("当前操作将导致客户端接收不到车辆位置信息，确定需要停止服务吗？\r\n\r\n", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            
            this._socketServer.StopSendMessage();

            this.tlsStartSimulator.Enabled = true;
            this.tlsStopSimulator.Enabled = false;
        }

        private void tlsGetRandomData_Click(object sender, EventArgs e)
        {
            if (!this.tlsStartSimulator.Enabled)
            {
                MessageBox.Show("在提取坐标点之前， 请先停止GPS模拟器服务.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmLoadRandomLocation oFrmLoadRandomLocation = new frmLoadRandomLocation();
            oFrmLoadRandomLocation.Show();
        }

      
        private void tlsStartViewRealtimeData_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this._socketClient.ProcessMessageEvent += new GPSGatewaySimulator.Communications.SocketClient.ProcessMessageHandler(_socketClient_ProcessMessageEvent);
            this._socketClient.ListenigPort = this._port;
            this._socketClient.ServerIP = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName())[0].ToString();
            this._socketClient.StartReceiveMessage();

            this.tlsStartViewRealtimeData.Enabled = false;
            this.tlsStopViewRealtimeData.Enabled = true;
        }

        void _socketClient_ProcessMessageEvent(object sender, GPSGatewaySimulator.Communications.MessageArguments e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    DataRow dr = this._tableTrackingPoints.NewRow();
                    HistoryTrakings.DataStructConverter.CommInfosToDataRow(e.Message, ref dr);
                    this._tableTrackingPoints.Rows.Add(dr);
                });
            }
            catch { }
        }

        private void tlsStopViewRealtimeData_Click(object sender, EventArgs e)
        {
            this._socketClient.StopReceiveMessage();

            this.tlsStartViewRealtimeData.Enabled = true;
            this.tlsStopViewRealtimeData.Enabled = false;
        }

        private void tlsClearRealtimeData_Click(object sender, EventArgs e)
        {
            int iCount = this._tableTrackingPoints.DefaultView.Count;

            for (int i = iCount - 1; i >= 0; i--)
            {
                this._tableTrackingPoints.DefaultView.Delete(i);
            }
        }

        private void tlsExit_Click(object sender, EventArgs e)
        {
            if (!tlsStartSimulator.Enabled)
            {
                this._socketServer.StopSendMessage();
            }

            if (!this.tlsStartViewRealtimeData.Enabled)
            {
                this._socketClient.StopReceiveMessage();
            }

            this._socketClient = null;
            this._socketServer = null;
            this._tableTrackingPoints.Dispose();

            //GC.Collect();
            this.Close();
        }

        #endregion

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否确定需要关闭系统?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            System.Diagnostics.Process oThisProcess = System.Diagnostics.Process.GetCurrentProcess();
            oThisProcess.Kill();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.Hide();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }
    }
}

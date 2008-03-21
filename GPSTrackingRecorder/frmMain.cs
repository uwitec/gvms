using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSTrackingRecorder
{
    public partial class frmMain : Form
    {
        #region fields

        private Communications.SocketClient _socketClient = new GPSTrackingRecorder.Communications.SocketClient();
        private HistoryTrackings.TrackingDataTableStruct _tableTrackingPoints = new GPSTrackingRecorder.HistoryTrackings.TrackingDataTableStruct();
        private int _port = 0;
        private int _interval = 0;

        #endregion

        #region constructors

        public frmMain()
        {
            InitializeComponent();

            this.tlsStartRecorder.Enabled = true;
            this.tlsStopRecorder.Enabled = false;
           
            this._tableTrackingPoints.DefaultView.AllowDelete = true;
            this._tableTrackingPoints.DefaultView.ListChanged += new ListChangedEventHandler(DefaultView_ListChanged);
            this.dgvRealtimeDataView.DataSource = this._tableTrackingPoints.DefaultView;
            this.dgvRealtimeDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataColumn col in this._tableTrackingPoints.Columns)
            {
                DataGridViewColumn colView = dgvRealtimeDataView.Columns[col.ColumnName];
                colView.HeaderText = col.Caption;
            }
        }

     

        #endregion

        #region events

        void DefaultView_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (this._tableTrackingPoints.DefaultView.Count == 100)
                this.tlsClearRealtimeData_Click(this.tlsClearRealtimeData, EventArgs.Empty);
        }

        private void tlsExit_Click(object sender, EventArgs e)
        {
            if (!this.tlsStartRecorder.Enabled)
            {
                this._socketClient.StopReceiveMessage();
            }

            this._socketClient = null;
            this._tableTrackingPoints.Dispose();

            GC.Collect();
            this.Close();
        }

        private void tslStartRecorder_Click(object sender, EventArgs e)
        {   
            int iQueueMax = 0;
            int iLiseningPort = 0;

            frmSocketConfig oFrmSocketConfig = new frmSocketConfig();

            if (oFrmSocketConfig.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("请先配置好轨迹记录服务参数。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Int32.TryParse(oFrmSocketConfig.LiseningPort,out iLiseningPort))
            {
                MessageBox.Show("请确定指定的端口号参数正确.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Int32.TryParse(oFrmSocketConfig.QueueMax,out iQueueMax))
            {
                MessageBox.Show("请确定指定的消息队列容量参数正确.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this._socketClient.ProcessMessageEvent += new GPSTrackingRecorder.Communications.SocketClient.ProcessMessageHandler(_socketClient_ProcessMessageEvent);
            this._socketClient.ListenigPort = 8205;
            this._socketClient.ServerIP = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName())[0].ToString();
            this._socketClient.StartReceiveMessage();

            this.tlsStartRecorder.Enabled = false;
            this.tlsStopRecorder.Enabled = true;
        }

        void _socketClient_ProcessMessageEvent(object sender, GPSTrackingRecorder.Communications.MessageArguments e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    DataRow dr = this._tableTrackingPoints.NewRow();
                    HistoryTrackings.DataStructConverter.CommInfosToDataRow(e.Message, ref dr);
                    this._tableTrackingPoints.Rows.Add(dr);
                });
            }
            catch { }
        }

        private void tlsStopRecorder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("当前操作将导致不能记录下车辆的历史位置信息，确定需要停止服务吗？\r\n\r\n", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            this._socketClient.StopReceiveMessage();

            this.tlsStartRecorder.Enabled = true;
            this.tlsStopRecorder.Enabled = false;
        }

        private void tlsClearRealtimeData_Click(object sender, EventArgs e)
        {

            int iCount = this._tableTrackingPoints.DefaultView.Count;

            for (int i = iCount - 1; i >= 0; i--)
            {
                this._tableTrackingPoints.DefaultView.Delete(i);
            }
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
    }
}
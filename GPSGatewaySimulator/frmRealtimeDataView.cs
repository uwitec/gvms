using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSGatewaySimulator
{
    public partial class frmRealtimeDataView : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private HistoryTrakings.TrackingDataTableStruct _tableTrackingPoints;
 
        public frmRealtimeDataView()
        {
            InitializeComponent();
            this._tableTrackingPoints = new GPSGatewaySimulator.HistoryTrakings.TrackingDataTableStruct();
            this._tableTrackingPoints.DefaultView.AllowDelete = true;
            this.dgvRealtimeDataView.DataSource = this._tableTrackingPoints.DefaultView;

            foreach (DataColumn col in this._tableTrackingPoints.Columns)
            {
                DataGridViewColumn colView = dgvRealtimeDataView.Columns[col.ColumnName];
                colView.HeaderText = col.Caption;
            }
        }

        Communications.SocketClient oSocketClient = new GPSGatewaySimulator.Communications.SocketClient();
        private void button1_Click(object sender, EventArgs e)
        {        
            oSocketClient.ProcessMessageEvent += new GPSGatewaySimulator.Communications.SocketClient.ProcessMessageHandler(SocketClient_ProcessMessageEvent);
            oSocketClient.StartReceiveMessage(1234); 
        }

        void SocketClient_ProcessMessageEvent(object sender, GPSGatewaySimulator.Communications.MessageArguments e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            int iCount = this._tableTrackingPoints.DefaultView.Count;

            for (int i = iCount -1; i >=0 ; i--)
            {
                this._tableTrackingPoints.DefaultView.Delete(i);
            }
            //this.dgvRealtimeDataView.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oSocketClient.StopReceiveMessage();
        }

        
    }
}
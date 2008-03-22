/***********************************************
 * 
 * 
 * 
 * 
 * 
 * 
 * Use:
 *      1、存放所有的实时车辆数据
 *      2、车辆数据的字段包括：车辆ID，车牌号，X坐标，Y坐标，方向，时间，车主，手机号码 * 
 * 
 * *********************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommnicationMessage;

namespace GPSTrackingMonitor
{
    public partial class frmRealtimeCarInfos : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        #region constructors

        public frmRealtimeCarInfos()
        {
            InitializeComponent();
        }

        #endregion

        #region fields

        private static frmRealtimeCarInfos _instance;

        #endregion

        #region properties

        public static frmRealtimeCarInfos Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmRealtimeCarInfos();

                return _instance;
            }
        }

        #endregion

        #region events

        private void frmRealtimeCarInfos_Load(object sender, EventArgs e)
        {
            this.InitDataGirdView();

            GlobeVariables.CarInfosReceiver.ProcessMessageEvent += new GPSTrackingMonitor.Communications.SocketClient.ProcessMessageHandler(CarInfosReceiver_ProcessMessageEvent);
        }

        private void CarInfosReceiver_ProcessMessageEvent(object sender, GPSTrackingMonitor.Communications.MessageArguments e)
        {   
            try
            {
                this.Invoke((MethodInvoker)delegate
                {

                    GPSTrackingMonitor.Communications.MessagePool.ValueCollection oTrackingMessages = e.MessageCollection.Values;

                    foreach (CommnicationMessage.GPSTrackingMessage oTrackingMessage in oTrackingMessages)
                    {
                        DataRow dr = GlobeVariables.RealtimeCarInfosTable.NewRow();

                        RealtimeMonite.DataStructConverter.CommInfosToDataRow(oTrackingMessage, ref dr);
                        RealtimeMonite.TrackingDataTableStruct.UpdateRow(dr, ref GlobeVariables.RealtimeCarInfosTable);
                    }
                });
            }
            catch { }
        }

        private void frmRealtimeCarInfos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall || e.CloseReason == CloseReason.FormOwnerClosing)
                GlobeVariables.CarInfosReceiver.ProcessMessageEvent -= CarInfosReceiver_ProcessMessageEvent;
        }

        private void mnuTrackingReplay_Click(object sender, EventArgs e)
        {
            string sCarNumber = this.GetSelectedCarNumber();
            frmTackingReplay.Instance.SetCarNumber(sCarNumber);
            frmTackingReplay.Instance.Show();
        }

        private void mnuViewTailInfos_Click(object sender, EventArgs e)
        {
            if (this.dgvRealtimeCarInfos.DataSource != null
                        && this.dgvRealtimeCarInfos.RowCount > 0
                        && this.dgvRealtimeCarInfos.SelectedRows.Count > 0)
            {
                DataGridViewRow drSelected = this.dgvRealtimeCarInfos.SelectedRows[0];

                frmCarDetailInfos oFrmCarDetails = new frmCarDetailInfos
                    (drSelected.Cells["carnumber"].Value.ToString(),
                    drSelected.Cells["phone"].Value.ToString(),
                    drSelected.Cells["x"].Value.ToString(),
                    drSelected.Cells["y"].Value.ToString(),
                    drSelected.Cells["direction"].Value.ToString());

                oFrmCarDetails.ShowDialog();
            }
        }

        private void mnuCarLocate_Click(object sender, EventArgs e)
        {
            string sCarNumber = this.GetSelectedCarNumber();
            MapObjects2.GeoEvent oGeoEvent = GlobeVariables.MapControl.TrackingLayer.FindEvent(sCarNumber);
            MapObjects2.Point oCarLocation = new MapObjects2.PointClass();

            oCarLocation.X = oGeoEvent.X;
            oCarLocation.Y = oGeoEvent.Y;

            MapUtil.MapOperation oMapOper = new GPSTrackingMonitor.MapUtil.MapOperation();
            oMapOper.ZoomAndCenterMap(0.02, oCarLocation, ref GlobeVariables.MapControl);
            GlobeVariables.MapControl.Refresh();

            GlobeVariables.MapControl.FlashShape(oCarLocation, 5);
        }

        private void mnuStatistic_Click(object sender, EventArgs e)
        {
            frmStatistic oFrmStatistic = new frmStatistic();
            oFrmStatistic.Text = this.dgvRealtimeCarInfos.RowCount.ToString();
            oFrmStatistic.Show();

        }

        private void dgvRealtimeCarInfos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.mnuCarLocate_Click(this.mnuCarLocate, EventArgs.Empty);
        }

        private void mnuCarSearch_Click(object sender, EventArgs e)
        {
            frmCarSearcher oFrmSearcher = new frmCarSearcher();
            oFrmSearcher.Show();
        }

        #endregion

        #region private methods

        private void InitDataGirdView()
        {
            this.dgvRealtimeCarInfos.DataSource = GlobeVariables.RealtimeCarInfosTable;
            this.dgvRealtimeCarInfos.Sort(dgvRealtimeCarInfos.Columns["carNumber"], ListSortDirection.Descending);

            this.dgvRealtimeCarInfos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataColumn col in GlobeVariables.RealtimeCarInfosTable.Columns)
            {
                DataGridViewColumn colView = this.dgvRealtimeCarInfos.Columns[col.ColumnName];
                colView.HeaderText = col.Caption;
            }
        }

        private string GetSelectedCarNumber()
        {
            if (this.dgvRealtimeCarInfos.DataSource != null
                         && this.dgvRealtimeCarInfos.RowCount > 0
                         && this.dgvRealtimeCarInfos.SelectedRows.Count > 0)
            {
                return this.dgvRealtimeCarInfos.SelectedRows[0].Cells["CarNumber"].Value.ToString();
            }
            else return string.Empty;
        }

        #endregion
    }
}
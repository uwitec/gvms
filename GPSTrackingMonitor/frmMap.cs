using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MapObjects2;

namespace GPSTrackingMonitor
{
    public partial class frmMap : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        #region fields

        private MapObjects2.Rectangle _mapFullExtent;
        private MapObjects2.Line _measureLine = new LineClass();
        private double _mapScale = 0;
        private frmIdentify _frmIdentify = new frmIdentify();
        private RealtimeMonite.GeoeventUpdate _geoeventUpdate;
        private GPSTrackingMonitor.Communications.MessagePool _currentMessageCollection;
        private static frmMap _instance;
        
        #endregion

        #region constructor

        public frmMap()
        {
            InitializeComponent();

            this._frmIdentify.Hide();
        }

        #endregion

        #region properties

        public static frmMap Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmMap();

                return _instance;
            }
        }

        public AxMapObjects2.AxMap MapControl
        {
            get { return this.mapControl; }
        }

        #endregion

        #region events

        private void frmMap_Load(object sender, EventArgs e)
        {   
            this._mapFullExtent = mapControl.FullExtent;

            GlobeVariables.MainMapControl = this.mapControl;
            this.mapControl.FullRedrawOnPan = false;
            this.mapControl.TrackingLayerDrawing = TrackingLayerDrawConstants.moDrawSmooth;
            
            this._geoeventUpdate = new GPSTrackingMonitor.RealtimeMonite.GeoeventUpdate(this.mapControl);
            GlobeVariables.CarInfosReceiver.ProcessMessageEvent += new GPSTrackingMonitor.Communications.SocketClient.ProcessMessageHandler(CarInfosReceiver_ProcessMessageEvent);
        }

        private void CarInfosReceiver_ProcessMessageEvent(object sender, GPSTrackingMonitor.Communications.MessageArguments e)
        {
            this._currentMessageCollection = e.MessageCollection;
            Invoke((MethodInvoker)delegate { this._geoeventUpdate.UpdateCarLocation(e.MessageCollection); });
        }
        
        private void tlsZoomIn_Click(object sender, EventArgs e)
        {
            this.mapControl.MousePointer = MapObjects2.MousePointerConstants.moZoomIn;
            GlobeVariables.CurrentOperation = GPSTrackingMonitor.MapUtil.MapOperationType.ZoomIn;
        }

        private void tlsDefault_Click(object sender, EventArgs e)
        {
            this.mapControl.MousePointer = MapObjects2.MousePointerConstants.moDefault;
            GlobeVariables.CurrentOperation = GPSTrackingMonitor.MapUtil.MapOperationType.None;
        }

        private void tlsZoomOut_Click(object sender, EventArgs e)
        {
            this.mapControl.MousePointer = MapObjects2.MousePointerConstants.moZoomOut;
            GlobeVariables.CurrentOperation = GPSTrackingMonitor.MapUtil.MapOperationType.ZoomOut;
        }

        private void tlsPan_Click(object sender, EventArgs e)
        {
            this.mapControl.MousePointer = MapObjects2.MousePointerConstants.moPan;
            GlobeVariables.CurrentOperation = GPSTrackingMonitor.MapUtil.MapOperationType.Pan;
        }

        private void tlsFullExtent_Click(object sender, EventArgs e)
        {
            this.mapControl.Extent = this._mapFullExtent;
            //GlobeVariables.CurrentOperation = GPSTrackingMonitor.MapUtil.MapOperationType.FullExtent;
        }

        private void tlsPreview_Click(object sender, EventArgs e)
        {
            //GlobeVariables.CurrentOperation = GPSTrackingMonitor.MapUtil.MapOperationType.Preview;
        }

        private void tlsNextView_Click(object sender, EventArgs e)
        {
           // GlobeVariables.CurrentOperation = GPSTrackingMonitor.MapUtil.MapOperationType.NextView;

        }

        private void tlsRefresh_Click(object sender, EventArgs e)
        {
            this.mapControl.Refresh();
           // GlobeVariables.CurrentOperation = GPSTrackingMonitor.MapUtil.MapOperationType.Refresh;
        }

        private void tlsMeasure_Click(object sender, EventArgs e)
        {
            this.mapControl.MousePointer = MapObjects2.MousePointerConstants.moCross;
            GlobeVariables.CurrentOperation = GPSTrackingMonitor.MapUtil.MapOperationType.Measure;
        }

        private void tlsIdentify_Click(object sender, EventArgs e)
        {
            this.mapControl.MousePointer = MapObjects2.MousePointerConstants.moIdentify;
            GlobeVariables.CurrentOperation = GPSTrackingMonitor.MapUtil.MapOperationType.Identify;
        }

        private void tlsClear_Click(object sender, EventArgs e)
        {
            this.mapControl.TrackingLayer.ClearEvents();
            //GlobeVariables.CurrentOperation = GPSTrackingMonitor.MapUtil.MapOperationType.Clear;
        }

        private void mapControl_MouseDownEvent(object sender, AxMapObjects2._DMapEvents_MouseDownEvent e)
        {
            MapObjects2.Point oMousePosition = mapControl.ToMapPoint(e.x, e.y);
            MapUtil.MapOperation oMapOper = new GPSTrackingMonitor.MapUtil.MapOperation();

            switch (GlobeVariables.CurrentOperation)
            {
                case GPSTrackingMonitor.MapUtil.MapOperationType.ZoomIn:
                    oMapOper.ZoomInMap(mapControl.TrackRectangle(),ref mapControl);
                    break;
                case GPSTrackingMonitor.MapUtil.MapOperationType.ZoomOut:
                    oMapOper.ZoomOutMap(mapControl.TrackRectangle(), ref mapControl);
                    break;
                case GPSTrackingMonitor.MapUtil.MapOperationType.Pan:
                    mapControl.Pan();
                    break;
                case GPSTrackingMonitor.MapUtil.MapOperationType.Measure:
                    this._measureLine = mapControl.TrackLine();
                    this.labMeasure.Text = string.Format("长度 ： {0} 米", oMapOper.ComputeDistance(this._measureLine).ToString());
                    break;
                case GPSTrackingMonitor.MapUtil.MapOperationType.Identify:                  
                    MapUtil.FeatureInformations oFeatureInfos = oMapOper.GetIdentifyFeatureInfos(oMousePosition, this.mapControl,GlobeVariables.MapInfosCollection);
                    this._frmIdentify.UpdateFeatureInfos(oFeatureInfos, MousePosition);
                    break;
                case GPSTrackingMonitor.MapUtil.MapOperationType.FetchPoint:
                    this.OnPointFetched(oMousePosition);
                    break;
                default:
                    break;
            }
        }
        
        private void mapControl_MouseMoveEvent(object sender, AxMapObjects2._DMapEvents_MouseMoveEvent e)
        {
            MapObjects2.Point oMousePosition = mapControl.ToMapPoint(e.x, e.y);
            this.labCoordinates.Text = string.Format("坐标 ： X = {0}, Y = {1}", oMousePosition.X.ToString(), oMousePosition.Y.ToString());
        }

        private void mapControl_AfterTrackingLayerDraw(object sender, AxMapObjects2._DMapEvents_AfterTrackingLayerDrawEvent e)
        {
            //绘制导航地图中的视图范围框线
            frmNavigation.Instance.DrawMainMapViewExtent(this.mapControl.Extent);

            //更新比例尺
            MapUtil.MapOperation oMapOper = new GPSTrackingMonitor.MapUtil.MapOperation();
            this.lblScale.Text = string.Format("比例尺 ： 1 : {0}", Convert.ToInt32(oMapOper.ComputeMapScale(this.mapControl)).ToString());

            Invoke((MethodInvoker)delegate{this._geoeventUpdate.UpdateLabelLocation(this._currentMessageCollection);});
        }

        public delegate void LayerAddedEventHandler(object sender, EventArgs e);
        public  event LayerAddedEventHandler LayersAddedEvent;
        protected virtual void OnLayersAdded(EventArgs e)
        {
            if (LayersAddedEvent != null && e != null)
            {
                LayersAddedEvent(null, e);
            }
        }      


        public delegate void PointFetchedEventHandler(object sender,MapObjects2.Point e);
        public event PointFetchedEventHandler PointFetchedEvent;
        protected virtual void OnPointFetched(MapObjects2.Point e)
        {
            if (PointFetchedEvent != null && e != null)
            {
                PointFetchedEvent(null, e);
            }
        }



        private void tlsFullScreen_Click(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            //this.Owner = null;
        }

        private void frmMap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall || e.CloseReason == CloseReason.FormOwnerClosing)
                GlobeVariables.CarInfosReceiver.ProcessMessageEvent -= CarInfosReceiver_ProcessMessageEvent;
        }

        #endregion

       

        private void mapControl_BeforeLayerDraw(object sender, AxMapObjects2._DMapEvents_BeforeLayerDrawEvent e)
        {
            if (e.index == this.mapControl.Layers.Count - 1)
            {
                //绘制导航地图中的视图范围框线
                frmNavigation.Instance.DrawMainMapViewExtent(this.mapControl.Extent);

                //更新比例尺
                MapUtil.MapOperation oMapOper = new MapUtil.MapOperation();
                this._mapScale = oMapOper.ComputeMapScale(this.mapControl);
                this.lblScale.Text = string.Format("比例尺 ： 1 : {0}", this._mapScale.ToString());
            }

            object oLayer = this.mapControl.Layers.Item(e.index);
            int iMinScale = 0;
            int iMaxScale = 0;
            string[] sScales = new string[2];

            if (oLayer is MapObjects2.MapLayer)
            {
                sScales = (oLayer as MapLayer).Tag.Split('-');
                iMinScale = int.Parse(sScales[0]);
                iMaxScale = int.Parse(sScales[1]);

                if (iMinScale == 0 && iMaxScale == 0) return;

                if (this._mapScale >= iMinScale && this._mapScale <= iMaxScale)
                {
                    (oLayer as MapLayer).Visible = true;
                }
                else
                {
                    (oLayer as MapLayer).Visible = false;
                }
            }
            else if (oLayer is MapObjects2.ImageLayer)
            {
                sScales = (oLayer as ImageLayer).Tag.Split('-');
                iMinScale = int.Parse(sScales[0]);
                iMaxScale = int.Parse(sScales[1]);

                if (iMinScale == 0 && iMaxScale == 0) return;

                if (this._mapScale >= iMinScale && this._mapScale <= iMaxScale)
                {
                    (oLayer as ImageLayer).Visible = true;
                }
                else
                {
                    (oLayer as ImageLayer).Visible = false;
                }
            }
        }
    }
}
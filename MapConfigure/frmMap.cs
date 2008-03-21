using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MapObjects2;

namespace MapConfigure
{
    public partial class frmMap : WeifenLuo.WinFormsUI.Docking.DockContent        
    {
        #region fields

        private MapObjects2.Rectangle _mapFullExtent;
        private MapObjects2.Line _measureLine = new LineClass();
        private frmIdentify _frmIdentify = new frmIdentify();
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

            GlobeVariables.MapControl = this.mapControl;
            this.mapControl.FullRedrawOnPan = false;
        }

        private void tlsZoomIn_Click(object sender, EventArgs e)
        {
            this.mapControl.MousePointer = MapObjects2.MousePointerConstants.moZoomIn;
            GlobeVariables.CurrentOperation = MapUtil.MapOperationType.ZoomIn;
        }

        private void tlsDefault_Click(object sender, EventArgs e)
        {
            this.mapControl.MousePointer = MapObjects2.MousePointerConstants.moDefault;
            GlobeVariables.CurrentOperation = MapUtil.MapOperationType.None;
        }

        private void tlsZoomOut_Click(object sender, EventArgs e)
        {
            this.mapControl.MousePointer = MapObjects2.MousePointerConstants.moZoomOut;
            GlobeVariables.CurrentOperation = MapUtil.MapOperationType.ZoomOut;
        }

        private void tlsPan_Click(object sender, EventArgs e)
        {
            this.mapControl.MousePointer = MapObjects2.MousePointerConstants.moPan;
            GlobeVariables.CurrentOperation = MapUtil.MapOperationType.Pan;
        }

        private void tlsFullExtent_Click(object sender, EventArgs e)
        {
            this.mapControl.Extent = this._mapFullExtent;
            //GlobeVariables.CurrentOperation = MapUtil.MapOperationType.FullExtent;
        }

        private void tlsPreview_Click(object sender, EventArgs e)
        {
            //GlobeVariables.CurrentOperation = MapUtil.MapOperationType.Preview;
        }

        private void tlsNextView_Click(object sender, EventArgs e)
        {
            // GlobeVariables.CurrentOperation = MapUtil.MapOperationType.NextView;

        }

        private void tlsRefresh_Click(object sender, EventArgs e)
        {
            this.mapControl.Refresh();
            // GlobeVariables.CurrentOperation = MapUtil.MapOperationType.Refresh;
        }

        private void tlsMeasure_Click(object sender, EventArgs e)
        {
            this.mapControl.MousePointer = MapObjects2.MousePointerConstants.moCross;
            GlobeVariables.CurrentOperation = MapUtil.MapOperationType.Measure;
        }

        private void tlsIdentify_Click(object sender, EventArgs e)
        {
            this.mapControl.MousePointer = MapObjects2.MousePointerConstants.moIdentify;
            GlobeVariables.CurrentOperation = MapUtil.MapOperationType.Identify;
        }

        private void tlsClear_Click(object sender, EventArgs e)
        {
            this.mapControl.TrackingLayer.ClearEvents();
            //GlobeVariables.CurrentOperation = MapUtil.MapOperationType.Clear;
        }

        private void mapControl_MouseDownEvent(object sender, AxMapObjects2._DMapEvents_MouseDownEvent e)
        {
            MapObjects2.Point oMousePosition = mapControl.ToMapPoint(e.x, e.y);
            MapUtil.MapOperation oMapOper = new MapUtil.MapOperation();

            switch (GlobeVariables.CurrentOperation)
            {
                case MapUtil.MapOperationType.ZoomIn:
                    oMapOper.ZoomInMap(mapControl.TrackRectangle(), ref mapControl);
                    break;
                case MapUtil.MapOperationType.ZoomOut:
                    oMapOper.ZoomOutMap(mapControl.TrackRectangle(), ref mapControl);
                    break;
                case MapUtil.MapOperationType.Pan:
                    mapControl.Pan();
                    break;
                case MapUtil.MapOperationType.Measure:
                    this._measureLine = mapControl.TrackLine();
                    this.labMeasure.Text = string.Format("长度 ： {0} 米", oMapOper.ComputeDistance(this._measureLine).ToString());
                    break;
                case MapUtil.MapOperationType.Identify:
                    MapUtil.FeatureInformations oFeatureInfos = oMapOper.GetIdentifyFeatureInfos(oMousePosition, this.mapControl);
                    this._frmIdentify.UpdateFeatureInfos(oFeatureInfos, MousePosition);
                    break;
                case MapUtil.MapOperationType.FetchPoint:
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
            MapUtil.MapOperation oMapOper = new MapUtil.MapOperation();
            this.lblScale.Text = string.Format("比例尺 ： 1 : {0}", Convert.ToInt32(oMapOper.ComputeMapScale(this.mapControl)).ToString());
        }

        private void tlsLoadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFileDialog = new OpenFileDialog();
            oFileDialog.Filter = "ESRI Shapefile(*.shp) | *.shp| All Support Format(*.*) | *.*";
            oFileDialog.Multiselect = true;
            oFileDialog.InitialDirectory = @"D:\项目\SIOGR项目\GPSTracking\trunk\mapdata";

            if (oFileDialog.ShowDialog() == DialogResult.OK)
            {
                MapUtil.MapOperation oMapOper = new MapUtil.MapOperation();
                List<string> oLayerPaths = new List<string>(oFileDialog.FileNames);

                List<MapUtil.LayerInformations> oLayerInfosCollection = oMapOper.LoadLayers(oLayerPaths, ref mapControl);
                GlobeVariables.LayersInformationSet.AddRange(oLayerInfosCollection);
                frmLegend.Instance.LoadLayersToLegend(this.mapControl);
                frmNavigation.Instance.LoadBackgroudlayer(GlobeVariables.LayersInformationSet);
            }
        }

        public delegate void LayerAddedEventHandler(object sender, EventArgs e);
        public event LayerAddedEventHandler LayersAddedEvent;
        protected virtual void OnLayersAdded(EventArgs e)
        {
            if (LayersAddedEvent != null && e != null)
            {
                LayersAddedEvent(null, e);
            }
        }


        public delegate void PointFetchedEventHandler(object sender, MapObjects2.Point e);
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
           
        }

        #endregion

        
    }
}
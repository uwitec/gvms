using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSTrackingMonitor
{
    public partial class frmNavigation : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        #region constructors

        public frmNavigation()
        {
            InitializeComponent();
        }

        #endregion

        #region fields

        private static frmNavigation _instance;

        #endregion

        #region properties

        public static frmNavigation Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmNavigation();

                return _instance;
            }
        }

        public AxMapObjects2.AxMap MapControl
        {
            get { return this.mapControl; }
        }

        #endregion

        #region public methods

        public void LoadLayersToNavigation(AxMapObjects2.AxMap mapControl)
        {
            if (mapControl == null || mapControl.Layers.Count == 0) return;

            object oLayer = null;
            object oBackLayer = null;

            short iLayersCount = mapControl.Layers.Count;

            for (short i = 0; i < iLayersCount; i++)
            {
                oLayer = mapControl.Layers.Item(i);

                if (oLayer is MapObjects2.MapLayer &&  (oLayer as MapObjects2.MapLayer).shapeType == MapObjects2.ShapeTypeConstants.moShapeTypePolygon)
                    oBackLayer = oLayer;
            }

            
            if (oBackLayer == null && iLayersCount > 0)
                oBackLayer = mapControl.Layers.Item(iLayersCount - 1);

            this.mapControl.Layers.Clear();
            this.mapControl.Layers.Add(oBackLayer);
            this.mapControl.Refresh();
        }

        public void DrawMainMapViewExtent(MapObjects2.Rectangle viewExtent)
        {
            this.mapControl.TrackingLayer.ClearEvents();
            this.mapControl.TrackingLayer.AddEvent(viewExtent, 0);
        }

        #endregion

        #region events

        private void frmNavigation_Load(object sender, EventArgs e)
        {
            this.mapControl.TrackingLayer.SymbolCount = 1;
            this.mapControl.TrackingLayer.get_Symbol(0).Outline = true;
            this.mapControl.TrackingLayer.get_Symbol(0).OutlineColor = (uint)MapObjects2.ColorConstants.moRed;
            this.mapControl.TrackingLayer.get_Symbol(0).SymbolType = MapObjects2.SymbolTypeConstants.moFillSymbol;
            this.mapControl.TrackingLayer.get_Symbol(0).Style = (short)MapObjects2.FillStyleConstants.moTransparentFill;
        }

        private void frmNavigation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
            base.OnFormClosing(e);
        }

        #endregion

    }
}
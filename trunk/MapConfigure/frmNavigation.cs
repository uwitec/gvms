using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MapConfigure
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

        public void LoadBackgroudlayer(List<ProjectUtil.ILayerStruct> layerInfosCollection)
        {
            this.mapControl.Layers.Clear();
            MapUtil.MapOperation oMapOper = new MapConfigure.MapUtil.MapOperation();

            foreach (ProjectUtil.ILayerStruct layerInfos in layerInfosCollection)
            {
                if (layerInfos.LayerType == (short)MapObjects2.LayerTypeConstants.moMapLayer &&
                    (layerInfos as ProjectUtil.MapLayerInfoStruct).ShapeType == (short)MapObjects2.ShapeTypeConstants.moShapeTypePolygon)
                {
                    this.mapControl.Layers.Add(oMapOper.GetLayerByName(GlobeVariables.MapControl,(layerInfos as ProjectUtil.MapLayerInfoStruct).Name));
                }
            }
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
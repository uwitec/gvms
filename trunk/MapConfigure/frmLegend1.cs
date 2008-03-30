using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MapConfigure
{
    public partial class frmLegend1 : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private AxMapObjects2.AxMap _mapObject = null;
        private object _selectedLayer = null;
        public frmLegend1()
        {
            InitializeComponent();

            this._mapObject = GlobeVariables.MapControl;
            object oMapControl = GlobeVariables.MapControl as object;
            this.mapLegend.setMapSource(ref oMapControl);
        }

        private static frmLegend1 _instance = null;
        public static frmLegend1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmLegend1();
                return _instance;
            }
        }

        public void LoadLayer()
        {
            this.mapLegend.LoadLegend();

            if (this._selectedLayer == null && this._mapObject.Layers.Count > 0)
            {
                short iLayerIndex = 0;
                this._selectedLayer = this._mapObject.Layers.Item(iLayerIndex);
                this.mapLegend.set_Active(ref iLayerIndex, true);
            }
        }

        private void mapLegend_LayerDblClick(object sender, AxSampleLegendControl.__legend_LayerDblClickEvent e)
        {
            this.mnuSetProperty_Click(sender, null);
        }

        private void mapLegend_MouseDownEvent(object sender, AxSampleLegendControl.__legend_MouseDownEvent e)
        {
            if (e.button == 2)
            {
                this._selectedLayer = this._mapObject.Layers.Item(this.mapLegend.getActiveLayer());
                this.mnuLayerProperty.Show(this.mapLegend, this.PointToClient(MousePosition));
            }
                
        }

        private void mnuViewAttributes_Click(object sender, EventArgs e)
        {
            if (this._selectedLayer == null || this._selectedLayer is MapObjects2.ImageLayer)
                return;

            MapUtil.MapOperation oMapOper = new MapConfigure.MapUtil.MapOperation();
            frmAttributesData oFrmAttributeData = new frmAttributesData(this._selectedLayer as MapObjects2.MapLayer);
            oFrmAttributeData.ShowDialog();
        }

        private void mnuIsLayerVisible_Click(object sender, EventArgs e)
        {
            if (this._selectedLayer == null || this._selectedLayer is MapObjects2.ImageLayer)
                return;

            mnuIsLayerVisible.Checked = !mnuIsLayerVisible.Checked;
            MapUtil.MapOperation oMapOper = new MapConfigure.MapUtil.MapOperation();

            if (this._selectedLayer is MapObjects2.ImageLayer)
                (this._selectedLayer as MapObjects2.ImageLayer).Visible = mnuIsLayerVisible.Checked;
            else if (this._selectedLayer is MapObjects2.MapLayer)
                (this._selectedLayer as MapObjects2.MapLayer).Visible = mnuIsLayerVisible.Checked;

            this._mapObject.Refresh();
        }

        private void mnuZoomToLayer_Click(object sender, EventArgs e)
        {
            if (this._selectedLayer == null)
                return;

            MapUtil.MapOperation oMapOper = new MapConfigure.MapUtil.MapOperation();

            if (this._selectedLayer is MapObjects2.ImageLayer)
                this._mapObject.Extent = (this._selectedLayer as MapObjects2.ImageLayer).Extent;
            else if (this._selectedLayer is MapObjects2.MapLayer)
                this._mapObject.Extent = (this._selectedLayer as MapObjects2.MapLayer).Extent;

            this._mapObject.Refresh();
        }

        private void mnuSetProperty_Click(object sender, EventArgs e)
        {
            MapUtil.MapOperation oMapOper = new MapConfigure.MapUtil.MapOperation();
            object oLayer = this._mapObject.Layers.Item(this.mapLegend.getActiveLayer());
            frmLayerProperties oFrmLayerProperties = new frmLayerProperties(this._mapObject, oLayer);

            if (oFrmLayerProperties.ShowDialog() == DialogResult.OK)
                this.mapLegend.LoadLegend();
        }


        private void SetConextMenuState()
        {
            if (this._selectedLayer is MapObjects2.ImageLayer)
            {
                this.mnuIsLayerVisible.Checked = (this._selectedLayer as MapObjects2.ImageLayer).Visible;
                this.mnuViewAttributes.Visible = false;
            }
            else if (this._selectedLayer is MapObjects2.MapLayer)
            {
                this.mnuIsLayerVisible.Checked = (this._selectedLayer as MapObjects2.MapLayer).Visible;
                this.mnuViewAttributes.Visible = true;
            }
        }

        private void SetLayersVisibility(bool isVisible)
        {
            short iLayersCount = this._mapObject.Layers.Count;

            for (short i = 0; i < iLayersCount; i++)
            {
                this.mapLegend.set_LayerVisible(ref i, isVisible);
            }

            this._mapObject.Refresh();
        }

        private void frmLegend1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    e.Cancel = true;
            //    this.Hide();
            //}
            //base.OnFormClosing(e);
        }

        private void tlsSetAllLayersVisible_Click(object sender, EventArgs e)
        {
            this.SetLayersVisibility(true);
        }

        private void tlsSetAllLayerHidden_Click(object sender, EventArgs e)
        {
            this.SetLayersVisibility(false);
        }

        private void mapLegend_AfterReorder(object sender, EventArgs e)
        {
            //this.mapLegend.ShowAllLegend();
        }

        private void mapLegend_AfterSetLayerVisible(object sender, AxSampleLegendControl.__legend_AfterSetLayerVisibleEvent e)
        {
            this._mapObject.RefreshRect(this._mapObject.Extent);
        }
    }
}
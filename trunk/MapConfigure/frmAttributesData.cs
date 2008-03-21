using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MapConfigure
{
    public partial class frmAttributesData : Form
    {
        MapObjects2.MapLayer _mapLayer;

        public frmAttributesData(MapObjects2.MapLayer layer)
        {
            InitializeComponent();

            this._mapLayer = layer;
            
        }

        private void frmAttributesData_Shown(object sender, EventArgs e)
        {
            if (this._mapLayer == null)
                return;

            this.BeginInvoke((MethodInvoker)delegate { this.LoadDataToGridView(this._mapLayer); });
        }

        private void LoadDataToGridView(MapObjects2.MapLayer layer)
        {
            Utilities.LayerProperty oLayerProperty = new MapConfigure.Utilities.LayerProperty();

            try
            {
                this.lblLayerDescription.Text = string.Format("Í¼²ãÃû³Æ £º {0}", layer.Name);

                System.Data.DataTable dtlayerAttributes = oLayerProperty.GetAttributesByLayer(layer);
                this.dgvViewAttributes.DataSource = dtlayerAttributes;
            }
            finally
            {
                oLayerProperty = null;
            }
        }
    }
}
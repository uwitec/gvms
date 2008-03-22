using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MapConfigure
{
    public partial class frmLayerProperties : Form
    {
        private MapObjects2.MapLayer _layer = null;

        public frmLayerProperties(MapObjects2.MapLayer layer)
        {
            InitializeComponent();

            if (layer == null)
                throw new Exception("layer is null,please set a valid layer.");

            this._layer = layer;
        }

        private void frmLayerProperties_Load(object sender, EventArgs e)
        {

        }

        private void InitPars()
        {

        }
    }
}
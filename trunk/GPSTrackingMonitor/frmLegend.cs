using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSTrackingMonitor
{
    public partial class frmLegend : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public frmLegend()
        {
            InitializeComponent();

            this.pnlLegend.AutoScroll = true;
        }

        private static frmLegend _instance;
        public static frmLegend Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmLegend();

                return _instance;
            }
        }

        private AxMapObjects2.AxMap _mapObject;

        public void LoadLayersToLegend(AxMapObjects2.AxMap mapObject)
        {
             if (mapObject == null)
                return;

            this._mapObject = mapObject;

            int iLayersCount = 0;
            iLayersCount = mapObject.Layers.Count;
            pnlLegend.Controls.Clear();

            int iCtrlsCounter = 0;
            for (int i = 0; i < iLayersCount; i++)
            {
                CheckBox oCkbLayer = new CheckBox();
               object oLayer = mapObject.Layers.Item(i);
                if(oLayer is MapObjects2.MapLayer)
                {
                    MapObjects2.MapLayer oMapLayer = oLayer as MapObjects2.MapLayer;
                    oCkbLayer.Text = oMapLayer.Name;
                    oCkbLayer.Checked = oMapLayer.Visible;

                    if(oMapLayer.shapeType == MapObjects2.ShapeTypeConstants.moShapeTypePoint || oMapLayer.shapeType == MapObjects2.ShapeTypeConstants.moShapeTypeMultipoint)
                        oCkbLayer.Image = Properties.Resources.pointShape;
                    else if(oMapLayer.shapeType == MapObjects2.ShapeTypeConstants.moShapeTypeEllipse || oMapLayer.shapeType == MapObjects2.ShapeTypeConstants.moShapeTypeLine || oMapLayer.shapeType == MapObjects2.ShapeTypeConstants.moShapeTypeRectangle)
                        oCkbLayer.Image = Properties.Resources.lineShape;
                    else if (oMapLayer.shapeType == MapObjects2.ShapeTypeConstants.moShapeTypePolygon)
                        oCkbLayer.Image = Properties.Resources.polygonShape; 
                }
                else if (oLayer is MapObjects2.ImageLayer)
                {
                    MapObjects2.ImageLayer oImageLayer = oLayer as MapObjects2.ImageLayer;

                    oCkbLayer.Image = Properties.Resources.image;
                    oCkbLayer.Text = oImageLayer.Name;
                    oCkbLayer.Checked = oImageLayer.Visible;
                }

                oCkbLayer.Visible = true;
                oCkbLayer.AutoSize = true;
                oCkbLayer.FlatStyle = FlatStyle.Flat;
                 oCkbLayer.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Left);
                oCkbLayer.ImageAlign = ContentAlignment.MiddleLeft;
                oCkbLayer.TextAlign = ContentAlignment.MiddleRight;
                oCkbLayer.TextImageRelation = TextImageRelation.ImageBeforeText;

                oCkbLayer.CheckedChanged += new EventHandler(CkbLayer_CheckedChanged);
               // oCkbLayer.MouseDown += new MouseEventHandler(CkbLayer_MouseDown);

                this.pnlLegend.Controls.Add(oCkbLayer);
                oCkbLayer.Location = new System.Drawing.Point(30, iCtrlsCounter * (oCkbLayer.Height + 12) + 20);
                iCtrlsCounter++;
            }

            this.pnlLegend.Refresh();
        }

        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
            base.OnFormClosing(e);
        }

        private void SetLayersVisibility(bool isVisible)
        {
             int iLayersCount = this.pnlLegend.Controls.Count;

            for(int i =0;i< iLayersCount;i++)
            {
                object oLayer = this._mapObject.Layers.Item(i);

                if(oLayer is MapObjects2.MapLayer)
                {
                    (oLayer as MapObjects2.MapLayer).Visible = isVisible;
                }
                else if (oLayer is MapObjects2.ImageLayer)
                {
                    (oLayer as MapObjects2.ImageLayer).Visible = isVisible;
                }

                (pnlLegend.Controls[i] as CheckBox).Checked = isVisible;
            }

            this._mapObject.Refresh();
        }

        private void CkbLayer_CheckedChanged(object sender, EventArgs e)
        {
            if (this._mapObject == null)
                return;

            CheckBox oCkbLayer = (CheckBox)sender;
            object oLayer = this._mapObject.Layers.Item(pnlLegend.Controls.IndexOf(oCkbLayer));

            if(oLayer is MapObjects2.ImageLayer)
                (oLayer as MapObjects2.ImageLayer).Visible = oCkbLayer.Checked;
            else if (oLayer is MapObjects2.MapLayer)
                (oLayer as MapObjects2.MapLayer).Visible = oCkbLayer.Checked;
            
            this._mapObject.RefreshRect(this._mapObject.Extent);
        }

        private void mnuAllLayerVisible_Click(object sender, EventArgs e)
        {
            this.SetLayersVisibility(true);
        }

        private void mnuAllLayersUnvisible_Click(object sender, EventArgs e)
        {
            this.SetLayersVisibility(false);
        }
    }
}
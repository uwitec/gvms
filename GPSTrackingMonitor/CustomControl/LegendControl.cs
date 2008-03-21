using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GPSTrackingMonitor.CustomControl
{
    public partial class LegendControl : TreeView
    {
        public LegendControl()
        {
            InitializeComponent();

            this.DrawMode = TreeViewDrawMode.OwnerDrawAll;
            this.DrawNode += new DrawTreeNodeEventHandler(LegendControl_DrawNode);
            this.Click += new EventHandler(LegendControl_Click);
            this.NodeMouseClick += new TreeNodeMouseClickEventHandler(LegendControl_NodeMouseClick);
        }

        void LegendControl_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        void LegendControl_Click(object sender, EventArgs e)
        {
            
        }

        void LegendControl_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                //绘制图层组合节点
                this.DrawLayerGroupNode(e);
            }
            else if (e.Node.Level == 1)
            {
                //绘制涂层节点
                this.DrawLayerNode(e);
            }
            else if (e.Node.Level == 2)
            {
                //绘制颜色序列节点
                this.DrawColorSchemdualNode(e);
            }
        }

        private void DrawLayerGroupNode(DrawTreeNodeEventArgs e)
        {
            Rectangle oNodeBounds = e.Bounds;
           // e.Graphics.DrawImage(Properties.Resources.layers_3, 0, 0);
        }

        private void DrawLayerNode(DrawTreeNodeEventArgs e)
        {
           
        }

        private void DrawColorSchemdualNode(DrawTreeNodeEventArgs e)
        {
           
        }

        public int AddLayerGroup(string groupText)
        {
          return  this.Nodes.Add(new TreeNode(groupText));
        }

        public int AddLayer(string layerName)
        {
            return 0;
        }
    }
}

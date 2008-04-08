namespace MapConfigure
{
    partial class frmMap
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMap));
            this.toolMapOperation = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblScale = new System.Windows.Forms.Label();
            this.labCoordinates = new System.Windows.Forms.Label();
            this.labMeasure = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.mapControl = new AxMapObjects2.AxMap();
            this.tlsDefault = new System.Windows.Forms.ToolStripButton();
            this.tlsZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tlsZoomOut = new System.Windows.Forms.ToolStripButton();
            this.tlsPan = new System.Windows.Forms.ToolStripButton();
            this.tlsFullExtent = new System.Windows.Forms.ToolStripButton();
            this.tlsRefresh = new System.Windows.Forms.ToolStripButton();
            this.tlsMeasure = new System.Windows.Forms.ToolStripButton();
            this.tlsIdentify = new System.Windows.Forms.ToolStripButton();
            this.tlsLoadData = new System.Windows.Forms.ToolStripButton();
            this.tlsClearAllLayers = new System.Windows.Forms.ToolStripButton();
            this.toolMapOperation.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            this.SuspendLayout();
            // 
            // toolMapOperation
            // 
            this.toolMapOperation.BackColor = System.Drawing.SystemColors.Control;
            this.toolMapOperation.Dock = System.Windows.Forms.DockStyle.None;
            this.toolMapOperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.tlsDefault,
            this.tlsZoomIn,
            this.tlsZoomOut,
            this.tlsPan,
            this.tlsFullExtent,
            this.tlsRefresh,
            this.toolStripSeparator1,
            this.tlsMeasure,
            this.tlsIdentify,
            this.tlsLoadData,
            this.tlsClearAllLayers});
            this.toolMapOperation.Location = new System.Drawing.Point(3, 0);
            this.toolMapOperation.Name = "toolMapOperation";
            this.toolMapOperation.Size = new System.Drawing.Size(252, 25);
            this.toolMapOperation.TabIndex = 1;
            this.toolMapOperation.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // pnlStatus
            // 
            this.pnlStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlStatus.Controls.Add(this.lblScale);
            this.pnlStatus.Controls.Add(this.labCoordinates);
            this.pnlStatus.Controls.Add(this.labMeasure);
            this.pnlStatus.Location = new System.Drawing.Point(0, 461);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(538, 30);
            this.pnlStatus.TabIndex = 3;
            // 
            // lblScale
            // 
            this.lblScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScale.AutoSize = true;
            this.lblScale.Location = new System.Drawing.Point(317, 9);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(65, 12);
            this.lblScale.TabIndex = 3;
            this.lblScale.Text = "比例尺 ： ";
            // 
            // labCoordinates
            // 
            this.labCoordinates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labCoordinates.AutoSize = true;
            this.labCoordinates.Location = new System.Drawing.Point(29, 9);
            this.labCoordinates.Name = "labCoordinates";
            this.labCoordinates.Size = new System.Drawing.Size(53, 12);
            this.labCoordinates.TabIndex = 2;
            this.labCoordinates.Text = "坐标 ： ";
            // 
            // labMeasure
            // 
            this.labMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labMeasure.AutoSize = true;
            this.labMeasure.Location = new System.Drawing.Point(402, 9);
            this.labMeasure.Name = "labMeasure";
            this.labMeasure.Size = new System.Drawing.Size(53, 12);
            this.labMeasure.TabIndex = 0;
            this.labMeasure.Text = "长度 ： ";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.BackColor = System.Drawing.SystemColors.Control;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pnlStatus);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.mapControl);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(541, 494);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            this.toolStripContainer1.RightToolStripPanel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripContainer1.Size = new System.Drawing.Size(541, 519);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolMapOperation);
            // 
            // mapControl
            // 
            this.mapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mapControl.Location = new System.Drawing.Point(3, 3);
            this.mapControl.Name = "mapControl";
            this.mapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mapControl.OcxState")));
            this.mapControl.Size = new System.Drawing.Size(535, 452);
            this.mapControl.TabIndex = 4;
            this.mapControl.MouseDownEvent += new AxMapObjects2._DMapEvents_MouseDownEventHandler(this.mapControl_MouseDownEvent);
            this.mapControl.MouseMoveEvent += new AxMapObjects2._DMapEvents_MouseMoveEventHandler(this.mapControl_MouseMoveEvent);
            this.mapControl.BeforeLayerDraw += new AxMapObjects2._DMapEvents_BeforeLayerDrawEventHandler(this.mapControl_BeforeLayerDraw);
            this.mapControl.AfterTrackingLayerDraw += new AxMapObjects2._DMapEvents_AfterTrackingLayerDrawEventHandler(this.mapControl_AfterTrackingLayerDraw);
            // 
            // tlsDefault
            // 
            this.tlsDefault.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsDefault.Image = global::MapConfigure.Properties.Resources.Edit;
            this.tlsDefault.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsDefault.Name = "tlsDefault";
            this.tlsDefault.Size = new System.Drawing.Size(23, 22);
            this.tlsDefault.Text = "指针";
            this.tlsDefault.Click += new System.EventHandler(this.tlsDefault_Click);
            // 
            // tlsZoomIn
            // 
            this.tlsZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsZoomIn.Image = global::MapConfigure.Properties.Resources.ZoomIn;
            this.tlsZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsZoomIn.Name = "tlsZoomIn";
            this.tlsZoomIn.Size = new System.Drawing.Size(23, 22);
            this.tlsZoomIn.Text = "放大";
            this.tlsZoomIn.Click += new System.EventHandler(this.tlsZoomIn_Click);
            // 
            // tlsZoomOut
            // 
            this.tlsZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsZoomOut.Image = global::MapConfigure.Properties.Resources.ZoomOut;
            this.tlsZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsZoomOut.Name = "tlsZoomOut";
            this.tlsZoomOut.Size = new System.Drawing.Size(23, 22);
            this.tlsZoomOut.Text = "缩小";
            this.tlsZoomOut.Click += new System.EventHandler(this.tlsZoomOut_Click);
            // 
            // tlsPan
            // 
            this.tlsPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsPan.Image = global::MapConfigure.Properties.Resources.Pan;
            this.tlsPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsPan.Name = "tlsPan";
            this.tlsPan.Size = new System.Drawing.Size(23, 22);
            this.tlsPan.Text = "漫游";
            this.tlsPan.Click += new System.EventHandler(this.tlsPan_Click);
            // 
            // tlsFullExtent
            // 
            this.tlsFullExtent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsFullExtent.Image = global::MapConfigure.Properties.Resources.FullExtent;
            this.tlsFullExtent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsFullExtent.Name = "tlsFullExtent";
            this.tlsFullExtent.Size = new System.Drawing.Size(23, 22);
            this.tlsFullExtent.Text = "全图";
            this.tlsFullExtent.Click += new System.EventHandler(this.tlsFullExtent_Click);
            // 
            // tlsRefresh
            // 
            this.tlsRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsRefresh.Image = global::MapConfigure.Properties.Resources.Refresh;
            this.tlsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsRefresh.Name = "tlsRefresh";
            this.tlsRefresh.Size = new System.Drawing.Size(23, 22);
            this.tlsRefresh.Text = "刷新地图";
            this.tlsRefresh.Click += new System.EventHandler(this.tlsRefresh_Click);
            // 
            // tlsMeasure
            // 
            this.tlsMeasure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsMeasure.Image = global::MapConfigure.Properties.Resources.measure;
            this.tlsMeasure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsMeasure.Name = "tlsMeasure";
            this.tlsMeasure.Size = new System.Drawing.Size(23, 22);
            this.tlsMeasure.Text = "距离测量";
            this.tlsMeasure.Click += new System.EventHandler(this.tlsMeasure_Click);
            // 
            // tlsIdentify
            // 
            this.tlsIdentify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsIdentify.Image = global::MapConfigure.Properties.Resources.Identify;
            this.tlsIdentify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsIdentify.Name = "tlsIdentify";
            this.tlsIdentify.Size = new System.Drawing.Size(23, 22);
            this.tlsIdentify.Text = "点击查询";
            this.tlsIdentify.Click += new System.EventHandler(this.tlsIdentify_Click);
            // 
            // tlsLoadData
            // 
            this.tlsLoadData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsLoadData.Image = global::MapConfigure.Properties.Resources.layers_3;
            this.tlsLoadData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsLoadData.Name = "tlsLoadData";
            this.tlsLoadData.Size = new System.Drawing.Size(23, 22);
            this.tlsLoadData.Text = "加载地图";
            this.tlsLoadData.Click += new System.EventHandler(this.tlsLoadData_Click);
            // 
            // tlsClearAllLayers
            // 
            this.tlsClearAllLayers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsClearAllLayers.Image = global::MapConfigure.Properties.Resources.Delete;
            this.tlsClearAllLayers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsClearAllLayers.Name = "tlsClearAllLayers";
            this.tlsClearAllLayers.Size = new System.Drawing.Size(23, 22);
            this.tlsClearAllLayers.Text = "toolStripButton1";
            this.tlsClearAllLayers.Click += new System.EventHandler(this.tlsClearAllLayers_Click);
            // 
            // frmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 519);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "frmMap";
            this.TabText = "地图";
            this.Text = "地图";
            this.toolMapOperation.ResumeLayout(false);
            this.toolMapOperation.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolMapOperation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlsDefault;
        private System.Windows.Forms.ToolStripButton tlsZoomIn;
        private System.Windows.Forms.ToolStripButton tlsZoomOut;
        private System.Windows.Forms.ToolStripButton tlsPan;
        private System.Windows.Forms.ToolStripButton tlsFullExtent;
        private System.Windows.Forms.ToolStripButton tlsRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlsMeasure;
        private System.Windows.Forms.ToolStripButton tlsIdentify;
        private System.Windows.Forms.ToolStripButton tlsLoadData;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.Label labCoordinates;
        private System.Windows.Forms.Label labMeasure;
        private AxMapObjects2.AxMap mapControl;
        private System.Windows.Forms.ToolStripButton tlsClearAllLayers;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}
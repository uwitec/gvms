namespace GPSTrackingMonitor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMap));
            this.toolMapOperation = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsDefault = new System.Windows.Forms.ToolStripButton();
            this.tlsZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tlsZoomOut = new System.Windows.Forms.ToolStripButton();
            this.tlsPan = new System.Windows.Forms.ToolStripButton();
            this.tlsFullExtent = new System.Windows.Forms.ToolStripButton();
            this.tlsPreview = new System.Windows.Forms.ToolStripButton();
            this.tlsNextView = new System.Windows.Forms.ToolStripButton();
            this.tlsRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsMeasure = new System.Windows.Forms.ToolStripButton();
            this.tlsIdentify = new System.Windows.Forms.ToolStripButton();
            this.tlsClear = new System.Windows.Forms.ToolStripButton();
            this.tlsLoadData = new System.Windows.Forms.ToolStripButton();
            this.tlsFullScreen = new System.Windows.Forms.ToolStripButton();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblScale = new System.Windows.Forms.Label();
            this.labCoordinates = new System.Windows.Forms.Label();
            this.labMeasure = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.imlShapeTypeImages = new System.Windows.Forms.ImageList(this.components);
            this.mapControl = new AxMapObjects2.AxMap();
            this.toolMapOperation.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            this.SuspendLayout();
            // 
            // toolMapOperation
            // 
            this.toolMapOperation.AutoSize = false;
            this.toolMapOperation.BackColor = System.Drawing.SystemColors.Control;
            this.toolMapOperation.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolMapOperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.tlsDefault,
            this.tlsZoomIn,
            this.tlsZoomOut,
            this.tlsPan,
            this.tlsFullExtent,
            this.tlsPreview,
            this.tlsNextView,
            this.tlsRefresh,
            this.toolStripSeparator1,
            this.tlsMeasure,
            this.tlsIdentify,
            this.tlsClear,
            this.tlsLoadData,
            this.tlsFullScreen});
            this.toolMapOperation.Location = new System.Drawing.Point(797, 0);
            this.toolMapOperation.Name = "toolMapOperation";
            this.toolMapOperation.Size = new System.Drawing.Size(40, 503);
            this.toolMapOperation.TabIndex = 0;
            this.toolMapOperation.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(38, 6);
            // 
            // tlsDefault
            // 
            this.tlsDefault.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsDefault.Image = global::GPSTrackingMonitor.Properties.Resources.Edit;
            this.tlsDefault.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsDefault.Name = "tlsDefault";
            this.tlsDefault.Size = new System.Drawing.Size(38, 20);
            this.tlsDefault.Text = "指针";
            this.tlsDefault.Click += new System.EventHandler(this.tlsDefault_Click);
            // 
            // tlsZoomIn
            // 
            this.tlsZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsZoomIn.Image = global::GPSTrackingMonitor.Properties.Resources.ZoomIn;
            this.tlsZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsZoomIn.Name = "tlsZoomIn";
            this.tlsZoomIn.Size = new System.Drawing.Size(38, 20);
            this.tlsZoomIn.Text = "放大";
            this.tlsZoomIn.Click += new System.EventHandler(this.tlsZoomIn_Click);
            // 
            // tlsZoomOut
            // 
            this.tlsZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsZoomOut.Image = global::GPSTrackingMonitor.Properties.Resources.ZoomOut;
            this.tlsZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsZoomOut.Name = "tlsZoomOut";
            this.tlsZoomOut.Size = new System.Drawing.Size(38, 20);
            this.tlsZoomOut.Text = "缩小";
            this.tlsZoomOut.Click += new System.EventHandler(this.tlsZoomOut_Click);
            // 
            // tlsPan
            // 
            this.tlsPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsPan.Image = global::GPSTrackingMonitor.Properties.Resources.Pan;
            this.tlsPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsPan.Name = "tlsPan";
            this.tlsPan.Size = new System.Drawing.Size(38, 20);
            this.tlsPan.Text = "漫游";
            this.tlsPan.Click += new System.EventHandler(this.tlsPan_Click);
            // 
            // tlsFullExtent
            // 
            this.tlsFullExtent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsFullExtent.Image = global::GPSTrackingMonitor.Properties.Resources.FullExtent;
            this.tlsFullExtent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsFullExtent.Name = "tlsFullExtent";
            this.tlsFullExtent.Size = new System.Drawing.Size(38, 20);
            this.tlsFullExtent.Text = "全图";
            this.tlsFullExtent.Click += new System.EventHandler(this.tlsFullExtent_Click);
            // 
            // tlsPreview
            // 
            this.tlsPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsPreview.Image = global::GPSTrackingMonitor.Properties.Resources.PanLeft;
            this.tlsPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsPreview.Name = "tlsPreview";
            this.tlsPreview.Size = new System.Drawing.Size(38, 20);
            this.tlsPreview.Text = "后一视图";
            this.tlsPreview.Click += new System.EventHandler(this.tlsPreview_Click);
            // 
            // tlsNextView
            // 
            this.tlsNextView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsNextView.Image = global::GPSTrackingMonitor.Properties.Resources.PanRight;
            this.tlsNextView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsNextView.Name = "tlsNextView";
            this.tlsNextView.Size = new System.Drawing.Size(38, 20);
            this.tlsNextView.Text = "前一视图";
            this.tlsNextView.Click += new System.EventHandler(this.tlsNextView_Click);
            // 
            // tlsRefresh
            // 
            this.tlsRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsRefresh.Image = global::GPSTrackingMonitor.Properties.Resources.ArcView_switch_selection;
            this.tlsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsRefresh.Name = "tlsRefresh";
            this.tlsRefresh.Size = new System.Drawing.Size(38, 20);
            this.tlsRefresh.Text = "刷新地图";
            this.tlsRefresh.Click += new System.EventHandler(this.tlsRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(38, 6);
            // 
            // tlsMeasure
            // 
            this.tlsMeasure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsMeasure.Image = global::GPSTrackingMonitor.Properties.Resources.measure;
            this.tlsMeasure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsMeasure.Name = "tlsMeasure";
            this.tlsMeasure.Size = new System.Drawing.Size(38, 20);
            this.tlsMeasure.Text = "距离测量";
            this.tlsMeasure.Click += new System.EventHandler(this.tlsMeasure_Click);
            // 
            // tlsIdentify
            // 
            this.tlsIdentify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsIdentify.Image = global::GPSTrackingMonitor.Properties.Resources.Identify;
            this.tlsIdentify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsIdentify.Name = "tlsIdentify";
            this.tlsIdentify.Size = new System.Drawing.Size(38, 20);
            this.tlsIdentify.Text = "点击查询";
            this.tlsIdentify.Click += new System.EventHandler(this.tlsIdentify_Click);
            // 
            // tlsClear
            // 
            this.tlsClear.AutoSize = false;
            this.tlsClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsClear.Image = global::GPSTrackingMonitor.Properties.Resources.Delete;
            this.tlsClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsClear.Name = "tlsClear";
            this.tlsClear.Size = new System.Drawing.Size(38, 20);
            this.tlsClear.Text = "清楚零时图形";
            this.tlsClear.Click += new System.EventHandler(this.tlsClear_Click);
            // 
            // tlsLoadData
            // 
            this.tlsLoadData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsLoadData.Image = global::GPSTrackingMonitor.Properties.Resources.folder_open;
            this.tlsLoadData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsLoadData.Name = "tlsLoadData";
            this.tlsLoadData.Size = new System.Drawing.Size(38, 20);
            this.tlsLoadData.Text = "toolStripButton4";
            this.tlsLoadData.Click += new System.EventHandler(this.tlsLoadData_Click);
            // 
            // tlsFullScreen
            // 
            this.tlsFullScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("tlsFullScreen.Image")));
            this.tlsFullScreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsFullScreen.Name = "tlsFullScreen";
            this.tlsFullScreen.Size = new System.Drawing.Size(38, 20);
            this.tlsFullScreen.Text = "全屏";
            this.tlsFullScreen.Click += new System.EventHandler(this.tlsFullScreen_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlStatus.Controls.Add(this.lblScale);
            this.pnlStatus.Controls.Add(this.labCoordinates);
            this.pnlStatus.Controls.Add(this.labMeasure);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 473);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(797, 30);
            this.pnlStatus.TabIndex = 2;
            // 
            // lblScale
            // 
            this.lblScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScale.AutoSize = true;
            this.lblScale.Location = new System.Drawing.Point(576, 9);
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(38, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(38, 20);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(38, 20);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // imlShapeTypeImages
            // 
            this.imlShapeTypeImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imlShapeTypeImages.ImageSize = new System.Drawing.Size(16, 16);
            this.imlShapeTypeImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // mapControl
            // 
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.Name = "mapControl";
            this.mapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mapControl.OcxState")));
            this.mapControl.Size = new System.Drawing.Size(797, 473);
            this.mapControl.TabIndex = 7;
            this.mapControl.BeforeTrackingLayerDraw += new AxMapObjects2._DMapEvents_BeforeTrackingLayerDrawEventHandler(this.mapControl_BeforeTrackingLayerDraw);
            this.mapControl.MouseDownEvent += new AxMapObjects2._DMapEvents_MouseDownEventHandler(this.mapControl_MouseDownEvent);
            this.mapControl.MouseMoveEvent += new AxMapObjects2._DMapEvents_MouseMoveEventHandler(this.mapControl_MouseMoveEvent);
            this.mapControl.AfterTrackingLayerDraw += new AxMapObjects2._DMapEvents_AfterTrackingLayerDrawEventHandler(this.mapControl_AfterTrackingLayerDraw);
            // 
            // frmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 503);
            this.Controls.Add(this.mapControl);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.toolMapOperation);
            this.Name = "frmMap";
            this.TabText = "frmMap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMap_FormClosing);
            this.Load += new System.EventHandler(this.frmMap_Load);
            this.toolMapOperation.ResumeLayout(false);
            this.toolMapOperation.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolMapOperation;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton tlsZoomIn;
        private System.Windows.Forms.ToolStripButton tlsZoomOut;
        private System.Windows.Forms.ToolStripButton tlsFullExtent;
        private System.Windows.Forms.ToolStripButton tlsPreview;
        private System.Windows.Forms.ToolStripButton tlsNextView;
        private System.Windows.Forms.ToolStripButton tlsClear;
        private System.Windows.Forms.ToolStripButton tlsMeasure;
        private System.Windows.Forms.ToolStripButton tlsDefault;
        private System.Windows.Forms.ToolStripButton tlsIdentify;
        private System.Windows.Forms.ToolStripButton tlsPan;
        private System.Windows.Forms.ToolStripButton tlsRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label labMeasure;
        private System.Windows.Forms.Label labCoordinates;
        private System.Windows.Forms.ToolStripButton tlsLoadData;
        private System.Windows.Forms.ImageList imlShapeTypeImages;
        private System.Windows.Forms.ToolStripButton tlsFullScreen;
        private AxMapObjects2.AxMap mapControl;
        private System.Windows.Forms.Label lblScale;
    }
}
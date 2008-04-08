namespace MapConfigure
{
    partial class frmLegend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLegend));
            this.mapLegend = new AxSampleLegendControl.Axlegend();
            this.mnuLayerProperty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlsSetAllLayersVisible = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsSetAllLayerHidden = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuViewAttributes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIsLayerVisible = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuZoomToLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteLayer = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mapLegend)).BeginInit();
            this.mnuLayerProperty.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapLegend
            // 
            this.mapLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapLegend.Enabled = true;
            this.mapLegend.Location = new System.Drawing.Point(0, 0);
            this.mapLegend.Name = "mapLegend";
            this.mapLegend.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mapLegend.OcxState")));
            this.mapLegend.Size = new System.Drawing.Size(301, 437);
            this.mapLegend.TabIndex = 0;
            this.mapLegend.MouseDownEvent += new AxSampleLegendControl.@__legend_MouseDownEventHandler(this.mapLegend_MouseDownEvent);
            this.mapLegend.LayerDblClick += new AxSampleLegendControl.@__legend_LayerDblClickEventHandler(this.mapLegend_LayerDblClick);
            this.mapLegend.AfterReorder += new System.EventHandler(this.mapLegend_AfterReorder);
            this.mapLegend.AfterSetLayerVisible += new AxSampleLegendControl.@__legend_AfterSetLayerVisibleEventHandler(this.mapLegend_AfterSetLayerVisible);
            // 
            // mnuLayerProperty
            // 
            this.mnuLayerProperty.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsSetAllLayersVisible,
            this.tlsSetAllLayerHidden,
            this.toolStripSeparator1,
            this.mnuDeleteLayer,
            this.mnuIsLayerVisible,
            this.mnuViewAttributes,
            this.mnuZoomToLayer,
            this.mnuSetProperty});
            this.mnuLayerProperty.Name = "mnuLayerProperty";
            this.mnuLayerProperty.Size = new System.Drawing.Size(153, 186);
            // 
            // tlsSetAllLayersVisible
            // 
            this.tlsSetAllLayersVisible.Name = "tlsSetAllLayersVisible";
            this.tlsSetAllLayersVisible.Size = new System.Drawing.Size(152, 22);
            this.tlsSetAllLayersVisible.Text = "所有图层可见";
            this.tlsSetAllLayersVisible.Click += new System.EventHandler(this.tlsSetAllLayersVisible_Click);
            // 
            // tlsSetAllLayerHidden
            // 
            this.tlsSetAllLayerHidden.Name = "tlsSetAllLayerHidden";
            this.tlsSetAllLayerHidden.Size = new System.Drawing.Size(152, 22);
            this.tlsSetAllLayerHidden.Text = "所有图层隐藏";
            this.tlsSetAllLayerHidden.Click += new System.EventHandler(this.tlsSetAllLayerHidden_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuViewAttributes
            // 
            this.mnuViewAttributes.Name = "mnuViewAttributes";
            this.mnuViewAttributes.Size = new System.Drawing.Size(152, 22);
            this.mnuViewAttributes.Text = "查看属性数据";
            this.mnuViewAttributes.Click += new System.EventHandler(this.mnuViewAttributes_Click);
            // 
            // mnuIsLayerVisible
            // 
            this.mnuIsLayerVisible.Name = "mnuIsLayerVisible";
            this.mnuIsLayerVisible.Size = new System.Drawing.Size(152, 22);
            this.mnuIsLayerVisible.Text = "是否可见";
            this.mnuIsLayerVisible.Click += new System.EventHandler(this.mnuIsLayerVisible_Click);
            // 
            // mnuZoomToLayer
            // 
            this.mnuZoomToLayer.Name = "mnuZoomToLayer";
            this.mnuZoomToLayer.Size = new System.Drawing.Size(152, 22);
            this.mnuZoomToLayer.Text = "缩放到图层";
            this.mnuZoomToLayer.Click += new System.EventHandler(this.mnuZoomToLayer_Click);
            // 
            // mnuSetProperty
            // 
            this.mnuSetProperty.Name = "mnuSetProperty";
            this.mnuSetProperty.Size = new System.Drawing.Size(152, 22);
            this.mnuSetProperty.Text = "属性";
            this.mnuSetProperty.Click += new System.EventHandler(this.mnuSetProperty_Click);
            // 
            // mnuDeleteLayer
            // 
            this.mnuDeleteLayer.Name = "mnuDeleteLayer";
            this.mnuDeleteLayer.Size = new System.Drawing.Size(152, 22);
            this.mnuDeleteLayer.Text = "删除图层";
            this.mnuDeleteLayer.Click += new System.EventHandler(this.mnuDeleteLayer_Click);
            // 
            // frmLegend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 437);
            this.Controls.Add(this.mapLegend);
            this.HideOnClose = true;
            this.Name = "frmLegend";
            this.TabText = "图层控制";
            this.Text = "图层控制";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLegend_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mapLegend)).EndInit();
            this.mnuLayerProperty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxSampleLegendControl.Axlegend mapLegend;
        private System.Windows.Forms.ContextMenuStrip mnuLayerProperty;
        private System.Windows.Forms.ToolStripMenuItem mnuViewAttributes;
        private System.Windows.Forms.ToolStripMenuItem mnuIsLayerVisible;
        private System.Windows.Forms.ToolStripMenuItem mnuZoomToLayer;
        private System.Windows.Forms.ToolStripMenuItem mnuSetProperty;
        private System.Windows.Forms.ToolStripMenuItem tlsSetAllLayersVisible;
        private System.Windows.Forms.ToolStripMenuItem tlsSetAllLayerHidden;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteLayer;
    }
}
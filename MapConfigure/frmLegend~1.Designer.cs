namespace MapConfigure
{
    partial class frmLegendbk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLegendbk));
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.mnuLegend = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAllLayerVisible = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAllLayersUnvisible = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLayerProperty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuViewAttributes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIsLayerVisible = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuZoomToLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLegend.SuspendLayout();
            this.mnuLayerProperty.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLegend
            // 
            this.pnlLegend.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLegend.ContextMenuStrip = this.mnuLegend;
            this.pnlLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLegend.Location = new System.Drawing.Point(0, 0);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(342, 482);
            this.pnlLegend.TabIndex = 0;
            // 
            // mnuLegend
            // 
            this.mnuLegend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAllLayerVisible,
            this.mnuAllLayersUnvisible});
            this.mnuLegend.Name = "mnuLegend";
            this.mnuLegend.Size = new System.Drawing.Size(155, 48);
            // 
            // mnuAllLayerVisible
            // 
            this.mnuAllLayerVisible.Name = "mnuAllLayerVisible";
            this.mnuAllLayerVisible.Size = new System.Drawing.Size(154, 22);
            this.mnuAllLayerVisible.Text = "全部图层可见";
            this.mnuAllLayerVisible.Click += new System.EventHandler(this.mnuAllLayerVisible_Click);
            // 
            // mnuAllLayersUnvisible
            // 
            this.mnuAllLayersUnvisible.Name = "mnuAllLayersUnvisible";
            this.mnuAllLayersUnvisible.Size = new System.Drawing.Size(154, 22);
            this.mnuAllLayersUnvisible.Text = "全部图层不可见";
            this.mnuAllLayersUnvisible.Click += new System.EventHandler(this.mnuAllLayersUnvisible_Click);
            // 
            // mnuLayerProperty
            // 
            this.mnuLayerProperty.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewAttributes,
            this.mnuIsLayerVisible,
            this.mnuZoomToLayer,
            this.mnuSetProperty});
            this.mnuLayerProperty.Name = "mnuLayerProperty";
            this.mnuLayerProperty.Size = new System.Drawing.Size(143, 92);
            // 
            // mnuViewAttributes
            // 
            this.mnuViewAttributes.Name = "mnuViewAttributes";
            this.mnuViewAttributes.Size = new System.Drawing.Size(142, 22);
            this.mnuViewAttributes.Text = "查看属性数据";
            this.mnuViewAttributes.Click += new System.EventHandler(this.mnuViewAttributes_Click);
            // 
            // mnuIsLayerVisible
            // 
            this.mnuIsLayerVisible.Name = "mnuIsLayerVisible";
            this.mnuIsLayerVisible.Size = new System.Drawing.Size(142, 22);
            this.mnuIsLayerVisible.Text = "是否可见";
            this.mnuIsLayerVisible.Click += new System.EventHandler(this.mnuIsLayerVisible_Click);
            // 
            // mnuZoomToLayer
            // 
            this.mnuZoomToLayer.Name = "mnuZoomToLayer";
            this.mnuZoomToLayer.Size = new System.Drawing.Size(142, 22);
            this.mnuZoomToLayer.Text = "缩放到图层";
            this.mnuZoomToLayer.Click += new System.EventHandler(this.mnuZoomToLayer_Click);
            // 
            // mnuSetProperty
            // 
            this.mnuSetProperty.Name = "mnuSetProperty";
            this.mnuSetProperty.Size = new System.Drawing.Size(142, 22);
            this.mnuSetProperty.Text = "属性";
            this.mnuSetProperty.Click += new System.EventHandler(this.mnuSetProperty_Click);
            // 
            // frmLegendbk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 482);
            this.Controls.Add(this.pnlLegend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLegendbk";
            this.TabText = "图层控制";
            this.Text = "frmLegend";
            this.Load += new System.EventHandler(this.frmLegend_Load);
            this.mnuLegend.ResumeLayout(false);
            this.mnuLayerProperty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.ContextMenuStrip mnuLegend;
        private System.Windows.Forms.ToolStripMenuItem mnuAllLayerVisible;
        private System.Windows.Forms.ToolStripMenuItem mnuAllLayersUnvisible;
        private System.Windows.Forms.ContextMenuStrip mnuLayerProperty;
        private System.Windows.Forms.ToolStripMenuItem mnuViewAttributes;
        private System.Windows.Forms.ToolStripMenuItem mnuIsLayerVisible;
        private System.Windows.Forms.ToolStripMenuItem mnuZoomToLayer;
        private System.Windows.Forms.ToolStripMenuItem mnuSetProperty;

    }
}
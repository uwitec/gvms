namespace GPSTrackingMonitor
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
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.mnuLegend = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAllLayerVisible = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAllLayersUnvisible = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLegend
            // 
            this.pnlLegend.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLegend.ContextMenuStrip = this.mnuLegend;
            this.pnlLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLegend.Location = new System.Drawing.Point(0, 0);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(252, 367);
            this.pnlLegend.TabIndex = 0;
            // 
            // mnuLegend
            // 
            this.mnuLegend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAllLayerVisible,
            this.mnuAllLayersUnvisible});
            this.mnuLegend.Name = "mnuLegend";
            this.mnuLegend.Size = new System.Drawing.Size(159, 48);
            // 
            // mnuAllLayerVisible
            // 
            this.mnuAllLayerVisible.Name = "mnuAllLayerVisible";
            this.mnuAllLayerVisible.Size = new System.Drawing.Size(158, 22);
            this.mnuAllLayerVisible.Text = "全部图层可见";
            this.mnuAllLayerVisible.Click += new System.EventHandler(this.mnuAllLayerVisible_Click);
            // 
            // mnuAllLayersUnvisible
            // 
            this.mnuAllLayersUnvisible.Name = "mnuAllLayersUnvisible";
            this.mnuAllLayersUnvisible.Size = new System.Drawing.Size(158, 22);
            this.mnuAllLayersUnvisible.Text = "全部图层不可见";
            this.mnuAllLayersUnvisible.Click += new System.EventHandler(this.mnuAllLayersUnvisible_Click);
            // 
            // frmLegend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 367);
            this.Controls.Add(this.pnlLegend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLegend";
            this.TabText = "图层控制";
            this.Text = "frmLegend";
            this.mnuLegend.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.ContextMenuStrip mnuLegend;
        private System.Windows.Forms.ToolStripMenuItem mnuAllLayerVisible;
        private System.Windows.Forms.ToolStripMenuItem mnuAllLayersUnvisible;

    }
}
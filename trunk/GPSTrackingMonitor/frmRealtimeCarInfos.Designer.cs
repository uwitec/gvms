namespace GPSTrackingMonitor
{
    partial class frmRealtimeCarInfos
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
            this.dgvRealtimeCarInfos = new System.Windows.Forms.DataGridView();
            this.cmnRealtimeCarInfos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuViewDetailInfos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCarSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCarLocate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTrackingReplay = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuStatistic = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealtimeCarInfos)).BeginInit();
            this.cmnRealtimeCarInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRealtimeCarInfos
            // 
            this.dgvRealtimeCarInfos.AllowUserToAddRows = false;
            this.dgvRealtimeCarInfos.AllowUserToResizeRows = false;
            this.dgvRealtimeCarInfos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRealtimeCarInfos.ContextMenuStrip = this.cmnRealtimeCarInfos;
            this.dgvRealtimeCarInfos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRealtimeCarInfos.Location = new System.Drawing.Point(0, 0);
            this.dgvRealtimeCarInfos.Name = "dgvRealtimeCarInfos";
            this.dgvRealtimeCarInfos.ReadOnly = true;
            this.dgvRealtimeCarInfos.RowTemplate.Height = 23;
            this.dgvRealtimeCarInfos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRealtimeCarInfos.Size = new System.Drawing.Size(795, 288);
            this.dgvRealtimeCarInfos.TabIndex = 0;
            this.dgvRealtimeCarInfos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRealtimeCarInfos_CellDoubleClick);
            // 
            // cmnRealtimeCarInfos
            // 
            this.cmnRealtimeCarInfos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewDetailInfos,
            this.toolStripSeparator3,
            this.mnuCarSearch,
            this.mnuCarLocate,
            this.toolStripSeparator2,
            this.mnuTrackingReplay,
            this.toolStripSeparator1,
            this.mnuStatistic});
            this.cmnRealtimeCarInfos.Name = "cmnRealtimeCarInfos";
            this.cmnRealtimeCarInfos.Size = new System.Drawing.Size(153, 154);
            // 
            // mnuViewDetailInfos
            // 
            this.mnuViewDetailInfos.Name = "mnuViewDetailInfos";
            this.mnuViewDetailInfos.Size = new System.Drawing.Size(152, 22);
            this.mnuViewDetailInfos.Text = "查看详细信息";
            this.mnuViewDetailInfos.Click += new System.EventHandler(this.mnuViewTailInfos_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuCarSearch
            // 
            this.mnuCarSearch.Name = "mnuCarSearch";
            this.mnuCarSearch.Size = new System.Drawing.Size(152, 22);
            this.mnuCarSearch.Text = "查找车辆";
            this.mnuCarSearch.Click += new System.EventHandler(this.mnuCarSearch_Click);
            // 
            // mnuCarLocate
            // 
            this.mnuCarLocate.Name = "mnuCarLocate";
            this.mnuCarLocate.Size = new System.Drawing.Size(152, 22);
            this.mnuCarLocate.Text = "定位车辆";
            this.mnuCarLocate.Click += new System.EventHandler(this.mnuCarLocate_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuTrackingReplay
            // 
            this.mnuTrackingReplay.Name = "mnuTrackingReplay";
            this.mnuTrackingReplay.Size = new System.Drawing.Size(152, 22);
            this.mnuTrackingReplay.Text = "回放轨迹";
            this.mnuTrackingReplay.Click += new System.EventHandler(this.mnuTrackingReplay_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuStatistic
            // 
            this.mnuStatistic.Name = "mnuStatistic";
            this.mnuStatistic.Size = new System.Drawing.Size(152, 22);
            this.mnuStatistic.Text = "统计报表";
            this.mnuStatistic.Click += new System.EventHandler(this.mnuStatistic_Click);
            // 
            // frmRealtimeCarInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 288);
            this.Controls.Add(this.dgvRealtimeCarInfos);
            this.Name = "frmRealtimeCarInfos";
            this.TabText = "frmCarData";
            this.Text = "frmCarData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRealtimeCarInfos_FormClosing);
            this.Load += new System.EventHandler(this.frmRealtimeCarInfos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealtimeCarInfos)).EndInit();
            this.cmnRealtimeCarInfos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRealtimeCarInfos;
        private System.Windows.Forms.ContextMenuStrip cmnRealtimeCarInfos;
        private System.Windows.Forms.ToolStripMenuItem mnuViewDetailInfos;
        private System.Windows.Forms.ToolStripMenuItem mnuTrackingReplay;
        private System.Windows.Forms.ToolStripMenuItem mnuCarLocate;
        private System.Windows.Forms.ToolStripMenuItem mnuStatistic;
        private System.Windows.Forms.ToolStripMenuItem mnuCarSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
namespace GPSTrackingRecorder
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgvRealtimeDataView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsLabel = new System.Windows.Forms.ToolStripLabel();
            this.tlsStartRecorder = new System.Windows.Forms.ToolStripButton();
            this.tlsStopRecorder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsClearRealtimeData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsExit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealtimeDataView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRealtimeDataView
            // 
            this.dgvRealtimeDataView.AllowUserToAddRows = false;
            this.dgvRealtimeDataView.AllowUserToResizeRows = false;
            this.dgvRealtimeDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRealtimeDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRealtimeDataView.Location = new System.Drawing.Point(3, 17);
            this.dgvRealtimeDataView.Name = "dgvRealtimeDataView";
            this.dgvRealtimeDataView.RowTemplate.Height = 23;
            this.dgvRealtimeDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRealtimeDataView.Size = new System.Drawing.Size(874, 391);
            this.dgvRealtimeDataView.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvRealtimeDataView);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(880, 411);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "实时数据";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 504);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(880, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.tlsLabel,
            this.tlsStartRecorder,
            this.tlsStopRecorder,
            this.toolStripSeparator4,
            this.toolStripSeparator3,
            this.tlsClearRealtimeData,
            this.toolStripSeparator9,
            this.toolStripSeparator10,
            this.tlsExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 68);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(880, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tlsLabel
            // 
            this.tlsLabel.Name = "tlsLabel";
            this.tlsLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // tlsStartRecorder
            // 
            this.tlsStartRecorder.Image = ((System.Drawing.Image)(resources.GetObject("tlsStartRecorder.Image")));
            this.tlsStartRecorder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsStartRecorder.Name = "tlsStartRecorder";
            this.tlsStartRecorder.Size = new System.Drawing.Size(97, 22);
            this.tlsStartRecorder.Text = "启动轨迹记录";
            this.tlsStartRecorder.Click += new System.EventHandler(this.tslStartRecorder_Click);
            // 
            // tlsStopRecorder
            // 
            this.tlsStopRecorder.Image = ((System.Drawing.Image)(resources.GetObject("tlsStopRecorder.Image")));
            this.tlsStopRecorder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsStopRecorder.Name = "tlsStopRecorder";
            this.tlsStopRecorder.Size = new System.Drawing.Size(97, 22);
            this.tlsStopRecorder.Text = "停止轨迹记录";
            this.tlsStopRecorder.Click += new System.EventHandler(this.tlsStopRecorder_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tlsClearRealtimeData
            // 
            this.tlsClearRealtimeData.Image = ((System.Drawing.Image)(resources.GetObject("tlsClearRealtimeData.Image")));
            this.tlsClearRealtimeData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsClearRealtimeData.Name = "tlsClearRealtimeData";
            this.tlsClearRealtimeData.Size = new System.Drawing.Size(97, 22);
            this.tlsClearRealtimeData.Text = "清除实时消息";
            this.tlsClearRealtimeData.Click += new System.EventHandler(this.tlsClearRealtimeData_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // tlsExit
            // 
            this.tlsExit.Image = ((System.Drawing.Image)(resources.GetObject("tlsExit.Image")));
            this.tlsExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsExit.Name = "tlsExit";
            this.tlsExit.Size = new System.Drawing.Size(73, 22);
            this.tlsExit.Text = "退出系统";
            this.tlsExit.Click += new System.EventHandler(this.tlsExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImage = global::GPSTrackingRecorder.Properties.Resources._2007718101835228_1_;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 68);
            this.panel1.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 526);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "GPS轨迹记录服务系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealtimeDataView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRealtimeDataView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel tlsLabel;
        private System.Windows.Forms.ToolStripButton tlsStartRecorder;
        private System.Windows.Forms.ToolStripButton tlsStopRecorder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tlsClearRealtimeData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton tlsExit;
        private System.Windows.Forms.Panel panel1;
    }
}


namespace GPSGatewaySimulator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsLabel = new System.Windows.Forms.ToolStripLabel();
            this.tlsStartSimulator = new System.Windows.Forms.ToolStripButton();
            this.tlsStopSimulator = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsGetRandomData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsStartViewRealtimeData = new System.Windows.Forms.ToolStripButton();
            this.tlsStopViewRealtimeData = new System.Windows.Forms.ToolStripButton();
            this.tlsClearRealtimeData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsExit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvRealtimeDataView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblServerInfos = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealtimeDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.tlsLabel,
            this.tlsStartSimulator,
            this.tlsStopSimulator,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.tlsGetRandomData,
            this.toolStripSeparator7,
            this.toolStripSeparator8,
            this.tlsStartViewRealtimeData,
            this.tlsStopViewRealtimeData,
            this.tlsClearRealtimeData,
            this.toolStripSeparator9,
            this.toolStripSeparator10,
            this.tlsExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 68);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(887, 25);
            this.toolStrip1.TabIndex = 1;
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
            // tlsStartSimulator
            // 
            this.tlsStartSimulator.Image = ((System.Drawing.Image)(resources.GetObject("tlsStartSimulator.Image")));
            this.tlsStartSimulator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsStartSimulator.Name = "tlsStartSimulator";
            this.tlsStartSimulator.Size = new System.Drawing.Size(85, 22);
            this.tlsStartSimulator.Text = "启动模拟器";
            this.tlsStartSimulator.Click += new System.EventHandler(this.tslStartSimulator_Click);
            // 
            // tlsStopSimulator
            // 
            this.tlsStopSimulator.Image = ((System.Drawing.Image)(resources.GetObject("tlsStopSimulator.Image")));
            this.tlsStopSimulator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsStopSimulator.Name = "tlsStopSimulator";
            this.tlsStopSimulator.Size = new System.Drawing.Size(85, 22);
            this.tlsStopSimulator.Text = "停止模拟器";
            this.tlsStopSimulator.Click += new System.EventHandler(this.tlsStopSimulator_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tlsGetRandomData
            // 
            this.tlsGetRandomData.Image = ((System.Drawing.Image)(resources.GetObject("tlsGetRandomData.Image")));
            this.tlsGetRandomData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsGetRandomData.Name = "tlsGetRandomData";
            this.tlsGetRandomData.Size = new System.Drawing.Size(97, 22);
            this.tlsGetRandomData.Text = "提取坐标数据";
            this.tlsGetRandomData.Click += new System.EventHandler(this.tlsGetRandomData_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // tlsStartViewRealtimeData
            // 
            this.tlsStartViewRealtimeData.Image = ((System.Drawing.Image)(resources.GetObject("tlsStartViewRealtimeData.Image")));
            this.tlsStartViewRealtimeData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsStartViewRealtimeData.Name = "tlsStartViewRealtimeData";
            this.tlsStartViewRealtimeData.Size = new System.Drawing.Size(97, 22);
            this.tlsStartViewRealtimeData.Text = "显示实时消息";
            this.tlsStartViewRealtimeData.Click += new System.EventHandler(this.tlsStartViewRealtimeData_Click);
            // 
            // tlsStopViewRealtimeData
            // 
            this.tlsStopViewRealtimeData.Image = ((System.Drawing.Image)(resources.GetObject("tlsStopViewRealtimeData.Image")));
            this.tlsStopViewRealtimeData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsStopViewRealtimeData.Name = "tlsStopViewRealtimeData";
            this.tlsStopViewRealtimeData.Size = new System.Drawing.Size(121, 22);
            this.tlsStopViewRealtimeData.Text = "停止显示实时消息";
            this.tlsStopViewRealtimeData.Click += new System.EventHandler(this.tlsStopViewRealtimeData_Click);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblServerInfos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 512);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(887, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvRealtimeDataView);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(887, 419);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "实时数据";
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
            this.dgvRealtimeDataView.Size = new System.Drawing.Size(881, 399);
            this.dgvRealtimeDataView.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImage = global::GPSGatewaySimulator.Properties.Resources._2007718101835228_1_;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 68);
            this.panel1.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "2341234";
            this.notifyIcon1.BalloonTipTitle = "dfgsdfg";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "GPS模拟网关";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // lblServerInfos
            // 
            this.lblServerInfos.Name = "lblServerInfos";
            this.lblServerInfos.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 534);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "GPS网关模拟服务系统";
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealtimeDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripButton tlsStartSimulator;
        private System.Windows.Forms.ToolStripButton tlsStopSimulator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tlsGetRandomData;
        private System.Windows.Forms.ToolStripButton tlsExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel tlsLabel;
        private System.Windows.Forms.ToolStripButton tlsStartViewRealtimeData;
        private System.Windows.Forms.ToolStripButton tlsStopViewRealtimeData;
        private System.Windows.Forms.ToolStripButton tlsClearRealtimeData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.DataGridView dgvRealtimeDataView;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripStatusLabel lblServerInfos;
    }
}


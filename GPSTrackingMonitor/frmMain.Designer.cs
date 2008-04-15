namespace GPSTrackingMonitor
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExitSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuViewLegendForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewNavigateForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewCarInfosForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.mnuMapConfgiure = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsSystemConfig = new System.Windows.Forms.ToolStripButton();
            this.mnuAbout = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuSoftLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutUS = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.加载电子地图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.图层控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripSplitButton1,
            this.toolStripSeparator3,
            this.tlsSystemConfig,
            this.toolStripSeparator4,
            this.mnuAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 94);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1019, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 649);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1019, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockPanel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanel.Location = new System.Drawing.Point(0, 119);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(1019, 530);
            this.dockPanel.TabIndex = 5;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenProject,
            this.mnuExitSystem});
            this.toolStripButton1.Image = global::GPSTrackingMonitor.Properties.Resources.folder_closed;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton1.Text = "文件";
            // 
            // mnuOpenProject
            // 
            this.mnuOpenProject.Name = "mnuOpenProject";
            this.mnuOpenProject.Size = new System.Drawing.Size(131, 22);
            this.mnuOpenProject.Text = "打开工程...";
            this.mnuOpenProject.Click += new System.EventHandler(this.mnuOpenProject_Click);
            // 
            // mnuExitSystem
            // 
            this.mnuExitSystem.Name = "mnuExitSystem";
            this.mnuExitSystem.Size = new System.Drawing.Size(131, 22);
            this.mnuExitSystem.Text = "退出系统";
            this.mnuExitSystem.Click += new System.EventHandler(this.mnuExitSystem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewLegendForm,
            this.mnuViewNavigateForm,
            this.mnuViewCarInfosForm});
            this.toolStripButton2.Image = global::GPSTrackingMonitor.Properties.Resources.flowchart_2;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton2.Text = "视图";
            // 
            // mnuViewLegendForm
            // 
            this.mnuViewLegendForm.Name = "mnuViewLegendForm";
            this.mnuViewLegendForm.Size = new System.Drawing.Size(146, 22);
            this.mnuViewLegendForm.Text = "图层控制";
            this.mnuViewLegendForm.Click += new System.EventHandler(this.mnuViewLegendForm_Click);
            // 
            // mnuViewNavigateForm
            // 
            this.mnuViewNavigateForm.Name = "mnuViewNavigateForm";
            this.mnuViewNavigateForm.Size = new System.Drawing.Size(146, 22);
            this.mnuViewNavigateForm.Text = "导航图";
            this.mnuViewNavigateForm.Click += new System.EventHandler(this.mnuViewNavigateForm_Click);
            // 
            // mnuViewCarInfosForm
            // 
            this.mnuViewCarInfosForm.Checked = true;
            this.mnuViewCarInfosForm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuViewCarInfosForm.Name = "mnuViewCarInfosForm";
            this.mnuViewCarInfosForm.Size = new System.Drawing.Size(146, 22);
            this.mnuViewCarInfosForm.Text = "实时车辆信息";
            this.mnuViewCarInfosForm.Click += new System.EventHandler(this.mnuViewCarInfosForm_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMapConfgiure});
            this.toolStripSplitButton1.Image = global::GPSTrackingMonitor.Properties.Resources.wrench;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripSplitButton1.Text = "工具";
            // 
            // mnuMapConfgiure
            // 
            this.mnuMapConfgiure.Name = "mnuMapConfgiure";
            this.mnuMapConfgiure.Size = new System.Drawing.Size(122, 22);
            this.mnuMapConfgiure.Text = "地图配置";
            this.mnuMapConfgiure.Click += new System.EventHandler(this.mnuMapConfgiure_Click);
            // 
            // tlsSystemConfig
            // 
            this.tlsSystemConfig.Image = global::GPSTrackingMonitor.Properties.Resources.application_Arcplot;
            this.tlsSystemConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsSystemConfig.Name = "tlsSystemConfig";
            this.tlsSystemConfig.Size = new System.Drawing.Size(75, 22);
            this.tlsSystemConfig.Text = "系统配置";
            this.tlsSystemConfig.Click += new System.EventHandler(this.tlsSystemConfig_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSoftLicense,
            this.mnuAboutUS});
            this.mnuAbout.Image = global::GPSTrackingMonitor.Properties.Resources.information;
            this.mnuAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(66, 22);
            this.mnuAbout.Text = "关  于";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuSoftLicense
            // 
            this.mnuSoftLicense.Name = "mnuSoftLicense";
            this.mnuSoftLicense.Size = new System.Drawing.Size(152, 22);
            this.mnuSoftLicense.Text = "共享协议";
            this.mnuSoftLicense.Click += new System.EventHandler(this.mnuSoftLicense_Click);
            // 
            // mnuAboutUS
            // 
            this.mnuAboutUS.Name = "mnuAboutUS";
            this.mnuAboutUS.Size = new System.Drawing.Size(152, 22);
            this.mnuAboutUS.Text = "关于我们";
            this.mnuAboutUS.Click += new System.EventHandler(this.mnuAboutUS_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1019, 94);
            this.pnlHeader.TabIndex = 0;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加载电子地图ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(44, 22);
            this.toolStripDropDownButton1.Text = "文件";
            // 
            // 加载电子地图ToolStripMenuItem
            // 
            this.加载电子地图ToolStripMenuItem.Name = "加载电子地图ToolStripMenuItem";
            this.加载电子地图ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.加载电子地图ToolStripMenuItem.Text = "加载电子地图";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图层控制ToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(44, 22);
            this.toolStripDropDownButton2.Text = "视图";
            // 
            // 图层控制ToolStripMenuItem
            // 
            this.图层控制ToolStripMenuItem.Name = "图层控制ToolStripMenuItem";
            this.图层控制ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.图层控制ToolStripMenuItem.Text = "图层控制";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 671);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlHeader);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "车辆监控系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 加载电子地图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem 图层控制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenProject;
        private System.Windows.Forms.ToolStripMenuItem mnuExitSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuViewLegendForm;
        private System.Windows.Forms.ToolStripMenuItem mnuViewNavigateForm;
        private System.Windows.Forms.ToolStripMenuItem mnuViewCarInfosForm;
        private System.Windows.Forms.ToolStripButton tlsSystemConfig;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem mnuMapConfgiure;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuSoftLicense;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutUS;
    }
}


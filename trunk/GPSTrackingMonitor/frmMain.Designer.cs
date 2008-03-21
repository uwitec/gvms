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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExitSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuViewLegendForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewNavigateForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewCarInfosForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsSystemConfig = new System.Windows.Forms.ToolStripButton();
            this.mnuAbout = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblProjectInfos = new System.Windows.Forms.Label();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.加载电子地图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.图层控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.tlsSystemConfig,
            this.mnuAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 69);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1019, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenProject,
            this.mnuExitSystem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
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
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
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
            // tlsSystemConfig
            // 
            this.tlsSystemConfig.Image = ((System.Drawing.Image)(resources.GetObject("tlsSystemConfig.Image")));
            this.tlsSystemConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsSystemConfig.Name = "tlsSystemConfig";
            this.tlsSystemConfig.Size = new System.Drawing.Size(75, 22);
            this.tlsSystemConfig.Text = "系统配置";
            this.tlsSystemConfig.Click += new System.EventHandler(this.tlsSystemConfig_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Image = ((System.Drawing.Image)(resources.GetObject("mnuAbout.Image")));
            this.mnuAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(51, 22);
            this.mnuAbout.Text = "关于";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
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
            this.dockPanel.Location = new System.Drawing.Point(0, 94);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(1019, 555);
            this.dockPanel.TabIndex = 5;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.Controls.Add(this.lblProjectInfos);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1019, 69);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblProjectInfos
            // 
            this.lblProjectInfos.AutoSize = true;
            this.lblProjectInfos.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectInfos.Enabled = false;
            this.lblProjectInfos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProjectInfos.Font = new System.Drawing.Font("楷体_GB2312", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProjectInfos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProjectInfos.Location = new System.Drawing.Point(37, 9);
            this.lblProjectInfos.Name = "lblProjectInfos";
            this.lblProjectInfos.Size = new System.Drawing.Size(426, 24);
            this.lblProjectInfos.TabIndex = 0;
            this.lblProjectInfos.Text = "SIOGR OpenSource-GPS-Car-Monitor";
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton mnuAbout;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.Label lblProjectInfos;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenProject;
        private System.Windows.Forms.ToolStripMenuItem mnuExitSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuViewLegendForm;
        private System.Windows.Forms.ToolStripMenuItem mnuViewNavigateForm;
        private System.Windows.Forms.ToolStripMenuItem mnuViewCarInfosForm;
        private System.Windows.Forms.ToolStripButton tlsSystemConfig;
    }
}


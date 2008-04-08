namespace MapConfigure
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.mnuOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAsProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAddLayers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.mnuIsViewLayerControlWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIsViewMapNavigateWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuSoftLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutUS = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 97);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1021, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenProject,
            this.mnuSaveProject,
            this.mnuSaveAsProject,
            this.toolStripSeparator1,
            this.mnuAddLayers,
            this.toolStripSeparator2,
            this.mnuExit});
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton1.Text = "文件";
            // 
            // mnuOpenProject
            // 
            this.mnuOpenProject.Name = "mnuOpenProject";
            this.mnuOpenProject.Size = new System.Drawing.Size(131, 22);
            this.mnuOpenProject.Text = "打开 ...";
            this.mnuOpenProject.Click += new System.EventHandler(this.mnuOpenProject_Click);
            // 
            // mnuSaveProject
            // 
            this.mnuSaveProject.Name = "mnuSaveProject";
            this.mnuSaveProject.Size = new System.Drawing.Size(131, 22);
            this.mnuSaveProject.Text = "保存 ...";
            this.mnuSaveProject.Click += new System.EventHandler(this.mnuSaveProject_Click);
            // 
            // mnuSaveAsProject
            // 
            this.mnuSaveAsProject.Name = "mnuSaveAsProject";
            this.mnuSaveAsProject.Size = new System.Drawing.Size(131, 22);
            this.mnuSaveAsProject.Text = "另存为 ...";
            this.mnuSaveAsProject.Click += new System.EventHandler(this.mnuSaveAsProject_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // mnuAddLayers
            // 
            this.mnuAddLayers.Name = "mnuAddLayers";
            this.mnuAddLayers.Size = new System.Drawing.Size(131, 22);
            this.mnuAddLayers.Text = "添加图层...";
            this.mnuAddLayers.Click += new System.EventHandler(this.mnuAddLayers_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(128, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(131, 22);
            this.mnuExit.Text = "退出";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 651);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1021, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanel.Location = new System.Drawing.Point(0, 122);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.ShowDocumentIcon = true;
            this.dockPanel.Size = new System.Drawing.Size(1021, 529);
            this.dockPanel.TabIndex = 5;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIsViewLayerControlWindow,
            this.mnuIsViewMapNavigateWindow});
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton2.Tag = "f";
            this.toolStripButton2.Text = "视图";
            // 
            // mnuIsViewLayerControlWindow
            // 
            this.mnuIsViewLayerControlWindow.Checked = true;
            this.mnuIsViewLayerControlWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuIsViewLayerControlWindow.Name = "mnuIsViewLayerControlWindow";
            this.mnuIsViewLayerControlWindow.Size = new System.Drawing.Size(122, 22);
            this.mnuIsViewLayerControlWindow.Text = "图层管理";
            this.mnuIsViewLayerControlWindow.Click += new System.EventHandler(this.mnuIsViewLayerControlWindow_Click);
            // 
            // mnuIsViewMapNavigateWindow
            // 
            this.mnuIsViewMapNavigateWindow.Checked = true;
            this.mnuIsViewMapNavigateWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuIsViewMapNavigateWindow.Name = "mnuIsViewMapNavigateWindow";
            this.mnuIsViewMapNavigateWindow.Size = new System.Drawing.Size(122, 22);
            this.mnuIsViewMapNavigateWindow.Text = "地图导航";
            this.mnuIsViewMapNavigateWindow.Click += new System.EventHandler(this.mnuIsViewMapNavigateWindow_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSoftLicense,
            this.mnuAboutUS});
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton3.Text = "关于";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.BackgroundImage = global::MapConfigure.Properties.Resources._234;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 97);
            this.panel1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 673);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "地图配置";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenProject;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveProject;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAsProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuAddLayers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem mnuIsViewLayerControlWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuIsViewMapNavigateWindow;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem mnuSoftLicense;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutUS;
    }
}


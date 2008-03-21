namespace GPSTrackingMonitor
{
    partial class frmConfigure
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
            this.tabConfigure = new System.Windows.Forms.TabControl();
            this.tbpCarConfig = new System.Windows.Forms.TabPage();
            this.txtSymbolIndex = new System.Windows.Forms.TextBox();
            this.picPreviewSymbol = new System.Windows.Forms.PictureBox();
            this.cbbFontNames = new System.Windows.Forms.ComboBox();
            this.tbpSocketCommunicationConfig = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpTrackingReplayConfig = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.symbolSelector = new GPSTrackingMonitor.CustomControl.SymbolSelector();
            this.tabConfigure.SuspendLayout();
            this.tbpCarConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewSymbol)).BeginInit();
            this.tbpSocketCommunicationConfig.SuspendLayout();
            this.tbpTrackingReplayConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConfigure
            // 
            this.tabConfigure.Controls.Add(this.tbpCarConfig);
            this.tabConfigure.Controls.Add(this.tbpSocketCommunicationConfig);
            this.tabConfigure.Controls.Add(this.tbpTrackingReplayConfig);
            this.tabConfigure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabConfigure.Location = new System.Drawing.Point(0, 0);
            this.tabConfigure.Name = "tabConfigure";
            this.tabConfigure.SelectedIndex = 0;
            this.tabConfigure.Size = new System.Drawing.Size(735, 584);
            this.tabConfigure.TabIndex = 0;
            // 
            // tbpCarConfig
            // 
            this.tbpCarConfig.Controls.Add(this.txtSymbolIndex);
            this.tbpCarConfig.Controls.Add(this.picPreviewSymbol);
            this.tbpCarConfig.Controls.Add(this.cbbFontNames);
            this.tbpCarConfig.Controls.Add(this.symbolSelector);
            this.tbpCarConfig.Location = new System.Drawing.Point(4, 21);
            this.tbpCarConfig.Name = "tbpCarConfig";
            this.tbpCarConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCarConfig.Size = new System.Drawing.Size(727, 559);
            this.tbpCarConfig.TabIndex = 1;
            this.tbpCarConfig.Text = "车辆配置";
            this.tbpCarConfig.UseVisualStyleBackColor = true;
            // 
            // txtSymbolIndex
            // 
            this.txtSymbolIndex.Location = new System.Drawing.Point(532, 260);
            this.txtSymbolIndex.Name = "txtSymbolIndex";
            this.txtSymbolIndex.Size = new System.Drawing.Size(164, 21);
            this.txtSymbolIndex.TabIndex = 4;
            // 
            // picPreviewSymbol
            // 
            this.picPreviewSymbol.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picPreviewSymbol.Location = new System.Drawing.Point(520, 42);
            this.picPreviewSymbol.Name = "picPreviewSymbol";
            this.picPreviewSymbol.Size = new System.Drawing.Size(199, 178);
            this.picPreviewSymbol.TabIndex = 3;
            this.picPreviewSymbol.TabStop = false;
            // 
            // cbbFontNames
            // 
            this.cbbFontNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbFontNames.FormattingEnabled = true;
            this.cbbFontNames.Location = new System.Drawing.Point(20, 16);
            this.cbbFontNames.Name = "cbbFontNames";
            this.cbbFontNames.Size = new System.Drawing.Size(189, 20);
            this.cbbFontNames.TabIndex = 2;
            this.cbbFontNames.SelectedIndexChanged += new System.EventHandler(this.cbbFontNames_SelectedIndexChanged);
            // 
            // tbpSocketCommunicationConfig
            // 
            this.tbpSocketCommunicationConfig.Controls.Add(this.label5);
            this.tbpSocketCommunicationConfig.Controls.Add(this.label4);
            this.tbpSocketCommunicationConfig.Controls.Add(this.label3);
            this.tbpSocketCommunicationConfig.Controls.Add(this.label2);
            this.tbpSocketCommunicationConfig.Location = new System.Drawing.Point(4, 21);
            this.tbpSocketCommunicationConfig.Name = "tbpSocketCommunicationConfig";
            this.tbpSocketCommunicationConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSocketCommunicationConfig.Size = new System.Drawing.Size(727, 559);
            this.tbpSocketCommunicationConfig.TabIndex = 0;
            this.tbpSocketCommunicationConfig.Text = "通信配置";
            this.tbpSocketCommunicationConfig.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "服务器地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "本地监听端口";
            // 
            // tbpTrackingReplayConfig
            // 
            this.tbpTrackingReplayConfig.Controls.Add(this.label11);
            this.tbpTrackingReplayConfig.Controls.Add(this.label10);
            this.tbpTrackingReplayConfig.Controls.Add(this.label9);
            this.tbpTrackingReplayConfig.Controls.Add(this.label8);
            this.tbpTrackingReplayConfig.Controls.Add(this.label7);
            this.tbpTrackingReplayConfig.Controls.Add(this.label6);
            this.tbpTrackingReplayConfig.Location = new System.Drawing.Point(4, 21);
            this.tbpTrackingReplayConfig.Name = "tbpTrackingReplayConfig";
            this.tbpTrackingReplayConfig.Size = new System.Drawing.Size(727, 559);
            this.tbpTrackingReplayConfig.TabIndex = 2;
            this.tbpTrackingReplayConfig.Text = "轨迹回放配置";
            this.tbpTrackingReplayConfig.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "端口";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(164, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "用户名";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "密码";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "数据库位置（access）";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "数据表名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "数据库类型";
            // 
            // symbolSelector
            // 
            this.symbolSelector.AutoScroll = true;
            this.symbolSelector.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.symbolSelector.Location = new System.Drawing.Point(20, 42);
            this.symbolSelector.Name = "symbolSelector";
            this.symbolSelector.Size = new System.Drawing.Size(479, 465);
            this.symbolSelector.TabIndex = 1;
            // 
            // frmConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 584);
            this.Controls.Add(this.tabConfigure);
            this.Name = "frmConfigure";
            this.Text = "frmConfigure";
            this.Load += new System.EventHandler(this.frmConfigure_Load);
            this.tabConfigure.ResumeLayout(false);
            this.tbpCarConfig.ResumeLayout(false);
            this.tbpCarConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewSymbol)).EndInit();
            this.tbpSocketCommunicationConfig.ResumeLayout(false);
            this.tbpSocketCommunicationConfig.PerformLayout();
            this.tbpTrackingReplayConfig.ResumeLayout(false);
            this.tbpTrackingReplayConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConfigure;
        private System.Windows.Forms.TabPage tbpSocketCommunicationConfig;
        private System.Windows.Forms.TabPage tbpCarConfig;
        private System.Windows.Forms.ComboBox cbbFontNames;
        private GPSTrackingMonitor.CustomControl.SymbolSelector symbolSelector;
        private System.Windows.Forms.PictureBox picPreviewSymbol;
        private System.Windows.Forms.TextBox txtSymbolIndex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbpTrackingReplayConfig;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;


    }
}
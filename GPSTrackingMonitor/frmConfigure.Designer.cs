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
            this.tbpSystemConfig = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.numIntervalCarUpdate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numMaxOfMessageCache = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProjectFilePath = new System.Windows.Forms.TextBox();
            this.lblProjectFilePath = new System.Windows.Forms.Label();
            this.btnProjectFileBrowser = new System.Windows.Forms.Button();
            this.tbpCarConfig = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlCarLabelColor = new System.Windows.Forms.Panel();
            this.btnCarLabelFont = new System.Windows.Forms.Button();
            this.lblCarLabelColor = new System.Windows.Forms.Label();
            this.lblCarLabelFont = new System.Windows.Forms.Label();
            this.picPreviewSymbol = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSymbolIndex = new System.Windows.Forms.Label();
            this.txtSymbolIndex = new System.Windows.Forms.TextBox();
            this.numSymbolRotation = new System.Windows.Forms.NumericUpDown();
            this.lblSymbolRotation = new System.Windows.Forms.Label();
            this.lblSymbolSize = new System.Windows.Forms.Label();
            this.lblSymbolColor = new System.Windows.Forms.Label();
            this.pnlSymbolColor = new System.Windows.Forms.Panel();
            this.numSymbolSize = new System.Windows.Forms.NumericUpDown();
            this.cbbFontNames = new System.Windows.Forms.ComboBox();
            this.tbpSocketCommunicationConfig = new System.Windows.Forms.TabPage();
            this.txtLocalLisentingPort = new System.Windows.Forms.TextBox();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.lblLocalLisentingPort = new System.Windows.Forms.Label();
            this.tbpTrackingReplayConfig = new System.Windows.Forms.TabPage();
            this.btnBrowseLocalDatabase = new System.Windows.Forms.Button();
            this.txtLocalDatabaseLocation = new System.Windows.Forms.TextBox();
            this.cbbTrackingTableName = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTestDatabaseConnection = new System.Windows.Forms.Button();
            this.txtDatabasePort = new System.Windows.Forms.TextBox();
            this.txtDatabaseServerAdress = new System.Windows.Forms.TextBox();
            this.txtDatabasePassword = new System.Windows.Forms.TextBox();
            this.txtDatabaseUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbDatabaseTypes = new System.Windows.Forms.ComboBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApplication = new System.Windows.Forms.Button();
            this.txtCommunicationServerIP = new System.Windows.Forms.TextBox();
            this.symSelector = new GPSTrackingMonitor.CustomControl.SymbolSelector();
            this.tabConfigure.SuspendLayout();
            this.tbpSystemConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervalCarUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxOfMessageCache)).BeginInit();
            this.tbpCarConfig.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewSymbol)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSymbolRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSymbolSize)).BeginInit();
            this.tbpSocketCommunicationConfig.SuspendLayout();
            this.tbpTrackingReplayConfig.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConfigure
            // 
            this.tabConfigure.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabConfigure.Controls.Add(this.tbpSystemConfig);
            this.tabConfigure.Controls.Add(this.tbpCarConfig);
            this.tabConfigure.Controls.Add(this.tbpSocketCommunicationConfig);
            this.tabConfigure.Controls.Add(this.tbpTrackingReplayConfig);
            this.tabConfigure.Location = new System.Drawing.Point(3, 2);
            this.tabConfigure.Name = "tabConfigure";
            this.tabConfigure.SelectedIndex = 0;
            this.tabConfigure.Size = new System.Drawing.Size(492, 393);
            this.tabConfigure.TabIndex = 0;
            // 
            // tbpSystemConfig
            // 
            this.tbpSystemConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpSystemConfig.Controls.Add(this.label5);
            this.tbpSystemConfig.Controls.Add(this.numIntervalCarUpdate);
            this.tbpSystemConfig.Controls.Add(this.label4);
            this.tbpSystemConfig.Controls.Add(this.numMaxOfMessageCache);
            this.tbpSystemConfig.Controls.Add(this.label3);
            this.tbpSystemConfig.Controls.Add(this.txtProjectFilePath);
            this.tbpSystemConfig.Controls.Add(this.lblProjectFilePath);
            this.tbpSystemConfig.Controls.Add(this.btnProjectFileBrowser);
            this.tbpSystemConfig.Location = new System.Drawing.Point(4, 24);
            this.tbpSystemConfig.Name = "tbpSystemConfig";
            this.tbpSystemConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSystemConfig.Size = new System.Drawing.Size(484, 365);
            this.tbpSystemConfig.TabIndex = 3;
            this.tbpSystemConfig.Text = "系统配置";
            this.tbpSystemConfig.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "(毫秒)";
            // 
            // numIntervalCarUpdate
            // 
            this.numIntervalCarUpdate.Location = new System.Drawing.Point(138, 136);
            this.numIntervalCarUpdate.Name = "numIntervalCarUpdate";
            this.numIntervalCarUpdate.Size = new System.Drawing.Size(153, 21);
            this.numIntervalCarUpdate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "车辆更新时间间隔:";
            // 
            // numMaxOfMessageCache
            // 
            this.numMaxOfMessageCache.Location = new System.Drawing.Point(137, 70);
            this.numMaxOfMessageCache.Name = "numMaxOfMessageCache";
            this.numMaxOfMessageCache.Size = new System.Drawing.Size(153, 21);
            this.numMaxOfMessageCache.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "消息最大缓存数目:";
            // 
            // txtProjectFilePath
            // 
            this.txtProjectFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProjectFilePath.Location = new System.Drawing.Point(137, 20);
            this.txtProjectFilePath.Name = "txtProjectFilePath";
            this.txtProjectFilePath.Size = new System.Drawing.Size(277, 21);
            this.txtProjectFilePath.TabIndex = 2;
            // 
            // lblProjectFilePath
            // 
            this.lblProjectFilePath.AutoSize = true;
            this.lblProjectFilePath.Location = new System.Drawing.Point(49, 23);
            this.lblProjectFilePath.Name = "lblProjectFilePath";
            this.lblProjectFilePath.Size = new System.Drawing.Size(83, 12);
            this.lblProjectFilePath.TabIndex = 1;
            this.lblProjectFilePath.Text = "工程文件路径:";
            // 
            // btnProjectFileBrowser
            // 
            this.btnProjectFileBrowser.Location = new System.Drawing.Point(416, 20);
            this.btnProjectFileBrowser.Name = "btnProjectFileBrowser";
            this.btnProjectFileBrowser.Size = new System.Drawing.Size(31, 21);
            this.btnProjectFileBrowser.TabIndex = 0;
            this.btnProjectFileBrowser.Text = "...";
            this.btnProjectFileBrowser.UseVisualStyleBackColor = true;
            this.btnProjectFileBrowser.Click += new System.EventHandler(this.btnProjectFileBrowser_Click);
            // 
            // tbpCarConfig
            // 
            this.tbpCarConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpCarConfig.Controls.Add(this.groupBox3);
            this.tbpCarConfig.Controls.Add(this.picPreviewSymbol);
            this.tbpCarConfig.Controls.Add(this.groupBox2);
            this.tbpCarConfig.Location = new System.Drawing.Point(4, 24);
            this.tbpCarConfig.Name = "tbpCarConfig";
            this.tbpCarConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCarConfig.Size = new System.Drawing.Size(484, 365);
            this.tbpCarConfig.TabIndex = 1;
            this.tbpCarConfig.Text = "车辆配置";
            this.tbpCarConfig.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pnlCarLabelColor);
            this.groupBox3.Controls.Add(this.btnCarLabelFont);
            this.groupBox3.Controls.Add(this.lblCarLabelColor);
            this.groupBox3.Controls.Add(this.lblCarLabelFont);
            this.groupBox3.Location = new System.Drawing.Point(4, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(472, 49);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "车辆标注设置";
            // 
            // pnlCarLabelColor
            // 
            this.pnlCarLabelColor.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pnlCarLabelColor.BackColor = System.Drawing.Color.Yellow;
            this.pnlCarLabelColor.Location = new System.Drawing.Point(330, 18);
            this.pnlCarLabelColor.Name = "pnlCarLabelColor";
            this.pnlCarLabelColor.Size = new System.Drawing.Size(116, 20);
            this.pnlCarLabelColor.TabIndex = 3;
            this.pnlCarLabelColor.Click += new System.EventHandler(this.pnlCarLabelColor_Click);
            // 
            // btnCarLabelFont
            // 
            this.btnCarLabelFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarLabelFont.Location = new System.Drawing.Point(57, 14);
            this.btnCarLabelFont.Name = "btnCarLabelFont";
            this.btnCarLabelFont.Size = new System.Drawing.Size(138, 28);
            this.btnCarLabelFont.TabIndex = 2;
            this.btnCarLabelFont.Text = "标 注 字 体";
            this.btnCarLabelFont.UseVisualStyleBackColor = true;
            this.btnCarLabelFont.Click += new System.EventHandler(this.btnCarLabelFont_Click);
            // 
            // lblCarLabelColor
            // 
            this.lblCarLabelColor.AutoSize = true;
            this.lblCarLabelColor.Location = new System.Drawing.Point(262, 22);
            this.lblCarLabelColor.Name = "lblCarLabelColor";
            this.lblCarLabelColor.Size = new System.Drawing.Size(65, 12);
            this.lblCarLabelColor.TabIndex = 1;
            this.lblCarLabelColor.Text = "标注颜色：";
            // 
            // lblCarLabelFont
            // 
            this.lblCarLabelFont.AutoSize = true;
            this.lblCarLabelFont.Location = new System.Drawing.Point(11, 22);
            this.lblCarLabelFont.Name = "lblCarLabelFont";
            this.lblCarLabelFont.Size = new System.Drawing.Size(41, 12);
            this.lblCarLabelFont.TabIndex = 0;
            this.lblCarLabelFont.Text = "字体：";
            // 
            // picPreviewSymbol
            // 
            this.picPreviewSymbol.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picPreviewSymbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreviewSymbol.Location = new System.Drawing.Point(355, 37);
            this.picPreviewSymbol.Name = "picPreviewSymbol";
            this.picPreviewSymbol.Size = new System.Drawing.Size(117, 104);
            this.picPreviewSymbol.TabIndex = 3;
            this.picPreviewSymbol.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSymbolIndex);
            this.groupBox2.Controls.Add(this.txtSymbolIndex);
            this.groupBox2.Controls.Add(this.numSymbolRotation);
            this.groupBox2.Controls.Add(this.lblSymbolRotation);
            this.groupBox2.Controls.Add(this.lblSymbolSize);
            this.groupBox2.Controls.Add(this.lblSymbolColor);
            this.groupBox2.Controls.Add(this.pnlSymbolColor);
            this.groupBox2.Controls.Add(this.numSymbolSize);
            this.groupBox2.Controls.Add(this.cbbFontNames);
            this.groupBox2.Controls.Add(this.symSelector);
            this.groupBox2.Location = new System.Drawing.Point(5, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 306);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "车辆图形设置";
            // 
            // lblSymbolIndex
            // 
            this.lblSymbolIndex.AutoSize = true;
            this.lblSymbolIndex.Location = new System.Drawing.Point(356, 164);
            this.lblSymbolIndex.Name = "lblSymbolIndex";
            this.lblSymbolIndex.Size = new System.Drawing.Size(47, 12);
            this.lblSymbolIndex.TabIndex = 13;
            this.lblSymbolIndex.Text = "索引号:";
            // 
            // txtSymbolIndex
            // 
            this.txtSymbolIndex.AllowDrop = true;
            this.txtSymbolIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSymbolIndex.Enabled = false;
            this.txtSymbolIndex.Location = new System.Drawing.Point(407, 159);
            this.txtSymbolIndex.Name = "txtSymbolIndex";
            this.txtSymbolIndex.Size = new System.Drawing.Size(55, 21);
            this.txtSymbolIndex.TabIndex = 12;
            // 
            // numSymbolRotation
            // 
            this.numSymbolRotation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numSymbolRotation.Location = new System.Drawing.Point(407, 275);
            this.numSymbolRotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numSymbolRotation.Name = "numSymbolRotation";
            this.numSymbolRotation.Size = new System.Drawing.Size(55, 21);
            this.numSymbolRotation.TabIndex = 11;
            this.numSymbolRotation.ValueChanged += new System.EventHandler(this.numSymbolRotation_ValueChanged);
            // 
            // lblSymbolRotation
            // 
            this.lblSymbolRotation.AutoSize = true;
            this.lblSymbolRotation.Location = new System.Drawing.Point(368, 278);
            this.lblSymbolRotation.Name = "lblSymbolRotation";
            this.lblSymbolRotation.Size = new System.Drawing.Size(35, 12);
            this.lblSymbolRotation.TabIndex = 10;
            this.lblSymbolRotation.Text = "旋转:";
            // 
            // lblSymbolSize
            // 
            this.lblSymbolSize.AutoSize = true;
            this.lblSymbolSize.Location = new System.Drawing.Point(368, 240);
            this.lblSymbolSize.Name = "lblSymbolSize";
            this.lblSymbolSize.Size = new System.Drawing.Size(35, 12);
            this.lblSymbolSize.TabIndex = 9;
            this.lblSymbolSize.Text = "大小:";
            // 
            // lblSymbolColor
            // 
            this.lblSymbolColor.AutoSize = true;
            this.lblSymbolColor.Location = new System.Drawing.Point(368, 199);
            this.lblSymbolColor.Name = "lblSymbolColor";
            this.lblSymbolColor.Size = new System.Drawing.Size(35, 12);
            this.lblSymbolColor.TabIndex = 8;
            this.lblSymbolColor.Text = "颜色:";
            // 
            // pnlSymbolColor
            // 
            this.pnlSymbolColor.BackColor = System.Drawing.Color.Red;
            this.pnlSymbolColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSymbolColor.Location = new System.Drawing.Point(407, 193);
            this.pnlSymbolColor.Name = "pnlSymbolColor";
            this.pnlSymbolColor.Size = new System.Drawing.Size(55, 21);
            this.pnlSymbolColor.TabIndex = 7;
            this.pnlSymbolColor.Click += new System.EventHandler(this.pnlSymbolColor_Click);
            // 
            // numSymbolSize
            // 
            this.numSymbolSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numSymbolSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numSymbolSize.Location = new System.Drawing.Point(407, 234);
            this.numSymbolSize.Name = "numSymbolSize";
            this.numSymbolSize.Size = new System.Drawing.Size(55, 21);
            this.numSymbolSize.TabIndex = 6;
            this.numSymbolSize.ValueChanged += new System.EventHandler(this.numSymbolSize_ValueChanged);
            // 
            // cbbFontNames
            // 
            this.cbbFontNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbFontNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbFontNames.FormattingEnabled = true;
            this.cbbFontNames.Location = new System.Drawing.Point(119, 11);
            this.cbbFontNames.Name = "cbbFontNames";
            this.cbbFontNames.Size = new System.Drawing.Size(225, 20);
            this.cbbFontNames.TabIndex = 2;
            this.cbbFontNames.SelectedIndexChanged += new System.EventHandler(this.cbbFontNames_SelectedIndexChanged);
            // 
            // tbpSocketCommunicationConfig
            // 
            this.tbpSocketCommunicationConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpSocketCommunicationConfig.Controls.Add(this.txtCommunicationServerIP);
            this.tbpSocketCommunicationConfig.Controls.Add(this.txtLocalLisentingPort);
            this.tbpSocketCommunicationConfig.Controls.Add(this.lblServerIP);
            this.tbpSocketCommunicationConfig.Controls.Add(this.lblLocalLisentingPort);
            this.tbpSocketCommunicationConfig.Location = new System.Drawing.Point(4, 24);
            this.tbpSocketCommunicationConfig.Name = "tbpSocketCommunicationConfig";
            this.tbpSocketCommunicationConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSocketCommunicationConfig.Size = new System.Drawing.Size(484, 365);
            this.tbpSocketCommunicationConfig.TabIndex = 0;
            this.tbpSocketCommunicationConfig.Text = "通信配置";
            this.tbpSocketCommunicationConfig.UseVisualStyleBackColor = true;
            // 
            // txtLocalLisentingPort
            // 
            this.txtLocalLisentingPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalLisentingPort.Location = new System.Drawing.Point(119, 62);
            this.txtLocalLisentingPort.Name = "txtLocalLisentingPort";
            this.txtLocalLisentingPort.Size = new System.Drawing.Size(162, 21);
            this.txtLocalLisentingPort.TabIndex = 3;
            this.txtLocalLisentingPort.Text = "8205";
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(29, 26);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(71, 12);
            this.lblServerIP.TabIndex = 1;
            this.lblServerIP.Text = "服务器地址:";
            // 
            // lblLocalLisentingPort
            // 
            this.lblLocalLisentingPort.AutoSize = true;
            this.lblLocalLisentingPort.Location = new System.Drawing.Point(17, 65);
            this.lblLocalLisentingPort.Name = "lblLocalLisentingPort";
            this.lblLocalLisentingPort.Size = new System.Drawing.Size(83, 12);
            this.lblLocalLisentingPort.TabIndex = 0;
            this.lblLocalLisentingPort.Text = "本地监听端口:";
            // 
            // tbpTrackingReplayConfig
            // 
            this.tbpTrackingReplayConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpTrackingReplayConfig.Controls.Add(this.btnBrowseLocalDatabase);
            this.tbpTrackingReplayConfig.Controls.Add(this.txtLocalDatabaseLocation);
            this.tbpTrackingReplayConfig.Controls.Add(this.cbbTrackingTableName);
            this.tbpTrackingReplayConfig.Controls.Add(this.label11);
            this.tbpTrackingReplayConfig.Controls.Add(this.label8);
            this.tbpTrackingReplayConfig.Controls.Add(this.label7);
            this.tbpTrackingReplayConfig.Controls.Add(this.groupBox1);
            this.tbpTrackingReplayConfig.Location = new System.Drawing.Point(4, 24);
            this.tbpTrackingReplayConfig.Name = "tbpTrackingReplayConfig";
            this.tbpTrackingReplayConfig.Size = new System.Drawing.Size(484, 365);
            this.tbpTrackingReplayConfig.TabIndex = 2;
            this.tbpTrackingReplayConfig.Text = "轨迹回放配置";
            this.tbpTrackingReplayConfig.UseVisualStyleBackColor = true;
            // 
            // btnBrowseLocalDatabase
            // 
            this.btnBrowseLocalDatabase.Location = new System.Drawing.Point(422, 204);
            this.btnBrowseLocalDatabase.Name = "btnBrowseLocalDatabase";
            this.btnBrowseLocalDatabase.Size = new System.Drawing.Size(31, 21);
            this.btnBrowseLocalDatabase.TabIndex = 6;
            this.btnBrowseLocalDatabase.Text = "...";
            this.btnBrowseLocalDatabase.UseVisualStyleBackColor = true;
            this.btnBrowseLocalDatabase.Click += new System.EventHandler(this.btnBrowseLocalDatabase_Click);
            // 
            // txtLocalDatabaseLocation
            // 
            this.txtLocalDatabaseLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalDatabaseLocation.Location = new System.Drawing.Point(102, 204);
            this.txtLocalDatabaseLocation.Name = "txtLocalDatabaseLocation";
            this.txtLocalDatabaseLocation.Size = new System.Drawing.Size(319, 21);
            this.txtLocalDatabaseLocation.TabIndex = 12;
            // 
            // cbbTrackingTableName
            // 
            this.cbbTrackingTableName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrackingTableName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbTrackingTableName.FormattingEnabled = true;
            this.cbbTrackingTableName.Location = new System.Drawing.Point(102, 248);
            this.cbbTrackingTableName.Name = "cbbTrackingTableName";
            this.cbbTrackingTableName.Size = new System.Drawing.Size(202, 20);
            this.cbbTrackingTableName.TabIndex = 11;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "数据库位置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "轨迹表表名";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTestDatabaseConnection);
            this.groupBox1.Controls.Add(this.txtDatabasePort);
            this.groupBox1.Controls.Add(this.txtDatabaseServerAdress);
            this.groupBox1.Controls.Add(this.txtDatabasePassword);
            this.groupBox1.Controls.Add(this.txtDatabaseUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbDatabaseTypes);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 178);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // btnTestDatabaseConnection
            // 
            this.btnTestDatabaseConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestDatabaseConnection.Location = new System.Drawing.Point(350, 142);
            this.btnTestDatabaseConnection.Name = "btnTestDatabaseConnection";
            this.btnTestDatabaseConnection.Size = new System.Drawing.Size(71, 30);
            this.btnTestDatabaseConnection.TabIndex = 19;
            this.btnTestDatabaseConnection.Text = "测试连接";
            this.btnTestDatabaseConnection.UseVisualStyleBackColor = true;
            // 
            // txtDatabasePort
            // 
            this.txtDatabasePort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatabasePort.Location = new System.Drawing.Point(309, 96);
            this.txtDatabasePort.Name = "txtDatabasePort";
            this.txtDatabasePort.Size = new System.Drawing.Size(108, 21);
            this.txtDatabasePort.TabIndex = 18;
            // 
            // txtDatabaseServerAdress
            // 
            this.txtDatabaseServerAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatabaseServerAdress.Location = new System.Drawing.Point(98, 98);
            this.txtDatabaseServerAdress.Name = "txtDatabaseServerAdress";
            this.txtDatabaseServerAdress.Size = new System.Drawing.Size(110, 21);
            this.txtDatabaseServerAdress.TabIndex = 17;
            // 
            // txtDatabasePassword
            // 
            this.txtDatabasePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatabasePassword.Location = new System.Drawing.Point(308, 51);
            this.txtDatabasePassword.Name = "txtDatabasePassword";
            this.txtDatabasePassword.Size = new System.Drawing.Size(109, 21);
            this.txtDatabasePassword.TabIndex = 16;
            // 
            // txtDatabaseUserName
            // 
            this.txtDatabaseUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatabaseUserName.Location = new System.Drawing.Point(98, 51);
            this.txtDatabaseUserName.Name = "txtDatabaseUserName";
            this.txtDatabaseUserName.Size = new System.Drawing.Size(109, 21);
            this.txtDatabaseUserName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "数据库端口";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "服务器地址";
            // 
            // cbbDatabaseTypes
            // 
            this.cbbDatabaseTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDatabaseTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbDatabaseTypes.FormattingEnabled = true;
            this.cbbDatabaseTypes.Location = new System.Drawing.Point(98, 16);
            this.cbbDatabaseTypes.Name = "cbbDatabaseTypes";
            this.cbbDatabaseTypes.Size = new System.Drawing.Size(202, 20);
            this.cbbDatabaseTypes.TabIndex = 10;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(24, 53);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(41, 12);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "用户名";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(271, 60);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(29, 12);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "密码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "数据库类型";
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(247, 407);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(71, 30);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确　定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(333, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取　消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApplication
            // 
            this.btnApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplication.Location = new System.Drawing.Point(420, 407);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Size = new System.Drawing.Size(71, 30);
            this.btnApplication.TabIndex = 5;
            this.btnApplication.Text = "应　用";
            this.btnApplication.UseVisualStyleBackColor = true;
            this.btnApplication.Click += new System.EventHandler(this.btnApplication_Click);
            // 
            // txtCommunicationServerIP
            // 
            this.txtCommunicationServerIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommunicationServerIP.Location = new System.Drawing.Point(119, 24);
            this.txtCommunicationServerIP.Name = "txtCommunicationServerIP";
            this.txtCommunicationServerIP.Size = new System.Drawing.Size(162, 21);
            this.txtCommunicationServerIP.TabIndex = 4;
            // 
            // symSelector
            // 
            this.symSelector.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.symSelector.AutoScroll = true;
            this.symSelector.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.symSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.symSelector.Location = new System.Drawing.Point(11, 34);
            this.symSelector.Name = "symSelector";
            this.symSelector.Size = new System.Drawing.Size(333, 266);
            this.symSelector.TabIndex = 1;
            // 
            // frmConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 449);
            this.Controls.Add(this.btnApplication);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabConfigure);
            this.Name = "frmConfigure";
            this.Text = "frmConfigure";
            this.Load += new System.EventHandler(this.frmConfigure_Load);
            this.tabConfigure.ResumeLayout(false);
            this.tbpSystemConfig.ResumeLayout(false);
            this.tbpSystemConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervalCarUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxOfMessageCache)).EndInit();
            this.tbpCarConfig.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewSymbol)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSymbolRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSymbolSize)).EndInit();
            this.tbpSocketCommunicationConfig.ResumeLayout(false);
            this.tbpSocketCommunicationConfig.PerformLayout();
            this.tbpTrackingReplayConfig.ResumeLayout(false);
            this.tbpTrackingReplayConfig.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConfigure;
        private System.Windows.Forms.TabPage tbpSocketCommunicationConfig;
        private System.Windows.Forms.TabPage tbpCarConfig;
        private System.Windows.Forms.ComboBox cbbFontNames;
        private GPSTrackingMonitor.CustomControl.SymbolSelector symSelector;
        private System.Windows.Forms.PictureBox picPreviewSymbol;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.Label lblLocalLisentingPort;
        private System.Windows.Forms.TabPage tbpTrackingReplayConfig;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tbpSystemConfig;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtProjectFilePath;
        private System.Windows.Forms.Label lblProjectFilePath;
        private System.Windows.Forms.Button btnProjectFileBrowser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApplication;
        private System.Windows.Forms.NumericUpDown numSymbolRotation;
        private System.Windows.Forms.Label lblSymbolRotation;
        private System.Windows.Forms.Label lblSymbolSize;
        private System.Windows.Forms.Label lblSymbolColor;
        private System.Windows.Forms.Panel pnlSymbolColor;
        private System.Windows.Forms.NumericUpDown numSymbolSize;
        private System.Windows.Forms.TextBox txtSymbolIndex;
        private System.Windows.Forms.Label lblSymbolIndex;
        private System.Windows.Forms.TextBox txtLocalLisentingPort;
        private System.Windows.Forms.ComboBox cbbDatabaseTypes;
        private System.Windows.Forms.Button btnBrowseLocalDatabase;
        private System.Windows.Forms.TextBox txtLocalDatabaseLocation;
        private System.Windows.Forms.ComboBox cbbTrackingTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatabasePort;
        private System.Windows.Forms.TextBox txtDatabaseServerAdress;
        private System.Windows.Forms.TextBox txtDatabasePassword;
        private System.Windows.Forms.TextBox txtDatabaseUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMaxOfMessageCache;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTestDatabaseConnection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numIntervalCarUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCarLabelColor;
        private System.Windows.Forms.Label lblCarLabelFont;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlCarLabelColor;
        private System.Windows.Forms.Button btnCarLabelFont;
        private System.Windows.Forms.TextBox txtCommunicationServerIP;


    }
}
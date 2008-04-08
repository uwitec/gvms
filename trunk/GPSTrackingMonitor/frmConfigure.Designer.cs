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
            this.txtProjectFilePath = new System.Windows.Forms.TextBox();
            this.lblProjectFilePath = new System.Windows.Forms.Label();
            this.btnProjectFileBrowser = new System.Windows.Forms.Button();
            this.tbpCarConfig = new System.Windows.Forms.TabPage();
            this.lblSymbolIndex = new System.Windows.Forms.Label();
            this.txtSymbolIndex = new System.Windows.Forms.TextBox();
            this.numSymbolRotation = new System.Windows.Forms.NumericUpDown();
            this.lblSymbolRotation = new System.Windows.Forms.Label();
            this.lblSymbolSize = new System.Windows.Forms.Label();
            this.lblSymbolColor = new System.Windows.Forms.Label();
            this.pnlSymbolColor = new System.Windows.Forms.Panel();
            this.numSymbolSize = new System.Windows.Forms.NumericUpDown();
            this.lblTrueTypeFonts = new System.Windows.Forms.Label();
            this.cbbFontNames = new System.Windows.Forms.ComboBox();
            this.picPreviewSymbol = new System.Windows.Forms.PictureBox();
            this.tbpSocketCommunicationConfig = new System.Windows.Forms.TabPage();
            this.txtLocalLisentingPort = new System.Windows.Forms.TextBox();
            this.txtServerIP = new System.Windows.Forms.MaskedTextBox();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.lblLocalLisentingPort = new System.Windows.Forms.Label();
            this.tbpTrackingReplayConfig = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbbDatabaseTypes = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApplication = new System.Windows.Forms.Button();
            this.symSelector = new GPSTrackingMonitor.CustomControl.SymbolSelector();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabConfigure.SuspendLayout();
            this.tbpSystemConfig.SuspendLayout();
            this.tbpCarConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSymbolRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSymbolSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewSymbol)).BeginInit();
            this.tbpSocketCommunicationConfig.SuspendLayout();
            this.tbpTrackingReplayConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
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
            this.tbpSystemConfig.Controls.Add(this.numericUpDown2);
            this.tbpSystemConfig.Controls.Add(this.label4);
            this.tbpSystemConfig.Controls.Add(this.numericUpDown1);
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
            this.lblProjectFilePath.Location = new System.Drawing.Point(15, 23);
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
            this.tbpCarConfig.Controls.Add(this.lblSymbolIndex);
            this.tbpCarConfig.Controls.Add(this.txtSymbolIndex);
            this.tbpCarConfig.Controls.Add(this.numSymbolRotation);
            this.tbpCarConfig.Controls.Add(this.lblSymbolRotation);
            this.tbpCarConfig.Controls.Add(this.lblSymbolSize);
            this.tbpCarConfig.Controls.Add(this.lblSymbolColor);
            this.tbpCarConfig.Controls.Add(this.pnlSymbolColor);
            this.tbpCarConfig.Controls.Add(this.numSymbolSize);
            this.tbpCarConfig.Controls.Add(this.lblTrueTypeFonts);
            this.tbpCarConfig.Controls.Add(this.cbbFontNames);
            this.tbpCarConfig.Controls.Add(this.picPreviewSymbol);
            this.tbpCarConfig.Controls.Add(this.symSelector);
            this.tbpCarConfig.Location = new System.Drawing.Point(4, 24);
            this.tbpCarConfig.Name = "tbpCarConfig";
            this.tbpCarConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCarConfig.Size = new System.Drawing.Size(484, 365);
            this.tbpCarConfig.TabIndex = 1;
            this.tbpCarConfig.Text = "车辆配置";
            this.tbpCarConfig.UseVisualStyleBackColor = true;
            // 
            // lblSymbolIndex
            // 
            this.lblSymbolIndex.AutoSize = true;
            this.lblSymbolIndex.Location = new System.Drawing.Point(355, 196);
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
            this.txtSymbolIndex.Location = new System.Drawing.Point(411, 191);
            this.txtSymbolIndex.Name = "txtSymbolIndex";
            this.txtSymbolIndex.Size = new System.Drawing.Size(56, 21);
            this.txtSymbolIndex.TabIndex = 12;
            // 
            // numSymbolRotation
            // 
            this.numSymbolRotation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numSymbolRotation.Location = new System.Drawing.Point(412, 322);
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
            this.lblSymbolRotation.Location = new System.Drawing.Point(368, 326);
            this.lblSymbolRotation.Name = "lblSymbolRotation";
            this.lblSymbolRotation.Size = new System.Drawing.Size(35, 12);
            this.lblSymbolRotation.TabIndex = 10;
            this.lblSymbolRotation.Text = "旋转:";
            // 
            // lblSymbolSize
            // 
            this.lblSymbolSize.AutoSize = true;
            this.lblSymbolSize.Location = new System.Drawing.Point(367, 285);
            this.lblSymbolSize.Name = "lblSymbolSize";
            this.lblSymbolSize.Size = new System.Drawing.Size(35, 12);
            this.lblSymbolSize.TabIndex = 9;
            this.lblSymbolSize.Text = "大小:";
            // 
            // lblSymbolColor
            // 
            this.lblSymbolColor.AutoSize = true;
            this.lblSymbolColor.Location = new System.Drawing.Point(367, 238);
            this.lblSymbolColor.Name = "lblSymbolColor";
            this.lblSymbolColor.Size = new System.Drawing.Size(35, 12);
            this.lblSymbolColor.TabIndex = 8;
            this.lblSymbolColor.Text = "颜色:";
            // 
            // pnlSymbolColor
            // 
            this.pnlSymbolColor.BackColor = System.Drawing.Color.Red;
            this.pnlSymbolColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSymbolColor.Location = new System.Drawing.Point(412, 234);
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
            this.numSymbolSize.Location = new System.Drawing.Point(412, 280);
            this.numSymbolSize.Name = "numSymbolSize";
            this.numSymbolSize.Size = new System.Drawing.Size(55, 21);
            this.numSymbolSize.TabIndex = 6;
            this.numSymbolSize.ValueChanged += new System.EventHandler(this.numSymbolSize_ValueChanged);
            // 
            // lblTrueTypeFonts
            // 
            this.lblTrueTypeFonts.AutoSize = true;
            this.lblTrueTypeFonts.Location = new System.Drawing.Point(27, 14);
            this.lblTrueTypeFonts.Name = "lblTrueTypeFonts";
            this.lblTrueTypeFonts.Size = new System.Drawing.Size(95, 12);
            this.lblTrueTypeFonts.TabIndex = 5;
            this.lblTrueTypeFonts.Text = "请选择一个字体:";
            // 
            // cbbFontNames
            // 
            this.cbbFontNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbFontNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbFontNames.FormattingEnabled = true;
            this.cbbFontNames.Location = new System.Drawing.Point(137, 11);
            this.cbbFontNames.Name = "cbbFontNames";
            this.cbbFontNames.Size = new System.Drawing.Size(165, 20);
            this.cbbFontNames.TabIndex = 2;
            this.cbbFontNames.SelectedIndexChanged += new System.EventHandler(this.cbbFontNames_SelectedIndexChanged);
            // 
            // picPreviewSymbol
            // 
            this.picPreviewSymbol.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picPreviewSymbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreviewSymbol.Location = new System.Drawing.Point(359, 37);
            this.picPreviewSymbol.Name = "picPreviewSymbol";
            this.picPreviewSymbol.Size = new System.Drawing.Size(117, 138);
            this.picPreviewSymbol.TabIndex = 3;
            this.picPreviewSymbol.TabStop = false;
            // 
            // tbpSocketCommunicationConfig
            // 
            this.tbpSocketCommunicationConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpSocketCommunicationConfig.Controls.Add(this.txtLocalLisentingPort);
            this.tbpSocketCommunicationConfig.Controls.Add(this.txtServerIP);
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
            this.txtLocalLisentingPort.Size = new System.Drawing.Size(105, 21);
            this.txtLocalLisentingPort.TabIndex = 3;
            this.txtLocalLisentingPort.Text = "8205";
            // 
            // txtServerIP
            // 
            this.txtServerIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerIP.Location = new System.Drawing.Point(119, 23);
            this.txtServerIP.Mask = "000.000.000.000";
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.RejectInputOnFirstFailure = true;
            this.txtServerIP.Size = new System.Drawing.Size(105, 21);
            this.txtServerIP.TabIndex = 2;
            this.txtServerIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.tbpTrackingReplayConfig.Controls.Add(this.button1);
            this.tbpTrackingReplayConfig.Controls.Add(this.textBox1);
            this.tbpTrackingReplayConfig.Controls.Add(this.comboBox1);
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
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(309, 96);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(108, 21);
            this.textBox5.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(98, 98);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(110, 21);
            this.textBox4.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(308, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(109, 21);
            this.textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(98, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 21);
            this.textBox2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 91);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(102, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 21);
            this.textBox1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 271);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 20);
            this.comboBox1.TabIndex = 11;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "端口";
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
            this.lblPassword.Location = new System.Drawing.Point(258, 62);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(29, 12);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "密码";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "数据库位置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "轨迹表表名";
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
            // 
            // symSelector
            // 
            this.symSelector.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.symSelector.AutoScroll = true;
            this.symSelector.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.symSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.symSelector.Location = new System.Drawing.Point(6, 37);
            this.symSelector.Name = "symSelector";
            this.symSelector.Size = new System.Drawing.Size(347, 320);
            this.symSelector.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "消息最大缓存数目";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(137, 70);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(153, 21);
            this.numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(150, 136);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(153, 21);
            this.numericUpDown2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "车辆更新时间间隔";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "(毫秒)";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(350, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 30);
            this.button2.TabIndex = 19;
            this.button2.Text = "测试连接";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
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
            this.tbpCarConfig.ResumeLayout(false);
            this.tbpCarConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSymbolRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSymbolSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewSymbol)).EndInit();
            this.tbpSocketCommunicationConfig.ResumeLayout(false);
            this.tbpSocketCommunicationConfig.PerformLayout();
            this.tbpTrackingReplayConfig.ResumeLayout(false);
            this.tbpTrackingReplayConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private System.Windows.Forms.Label lblTrueTypeFonts;
        private System.Windows.Forms.TextBox txtSymbolIndex;
        private System.Windows.Forms.Label lblSymbolIndex;
        private System.Windows.Forms.MaskedTextBox txtServerIP;
        private System.Windows.Forms.TextBox txtLocalLisentingPort;
        private System.Windows.Forms.ComboBox cbbDatabaseTypes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;


    }
}
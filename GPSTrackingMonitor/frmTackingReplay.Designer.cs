namespace GPSTrackingMonitor
{
    partial class frmTackingReplay
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
            this.lblCarNumber = new System.Windows.Forms.Label();
            this.cbbCarNumber = new System.Windows.Forms.ComboBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.trbSmoothScale = new System.Windows.Forms.TrackBar();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblTimeTo = new System.Windows.Forms.Label();
            this.lblSmoothScale = new System.Windows.Forms.Label();
            this.lblReplayTimesegment = new System.Windows.Forms.Label();
            this.btnReplay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblReplaySpeed = new System.Windows.Forms.Label();
            this.trbReplaySpeed = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trbSmoothScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbReplaySpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarNumber
            // 
            this.lblCarNumber.AutoSize = true;
            this.lblCarNumber.Location = new System.Drawing.Point(24, 25);
            this.lblCarNumber.Name = "lblCarNumber";
            this.lblCarNumber.Size = new System.Drawing.Size(71, 12);
            this.lblCarNumber.TabIndex = 0;
            this.lblCarNumber.Text = "车牌号码  :";
            // 
            // cbbCarNumber
            // 
            this.cbbCarNumber.FormattingEnabled = true;
            this.cbbCarNumber.Location = new System.Drawing.Point(107, 22);
            this.cbbCarNumber.Name = "cbbCarNumber";
            this.cbbCarNumber.Size = new System.Drawing.Size(322, 20);
            this.cbbCarNumber.TabIndex = 1;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "yyyy年MM月dd日 HH:mm";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(107, 62);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(146, 21);
            this.dtpStartTime.TabIndex = 2;
            // 
            // trbSmoothScale
            // 
            this.trbSmoothScale.Location = new System.Drawing.Point(107, 98);
            this.trbSmoothScale.Maximum = 100;
            this.trbSmoothScale.Name = "trbSmoothScale";
            this.trbSmoothScale.Size = new System.Drawing.Size(322, 42);
            this.trbSmoothScale.TabIndex = 3;
            this.trbSmoothScale.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trbSmoothScale.ValueChanged += new System.EventHandler(this.trbSmoothScale_ValueChanged);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "yyyy年MM月dd日 HH:mm";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(282, 62);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(147, 21);
            this.dtpEndTime.TabIndex = 4;
            // 
            // lblTimeTo
            // 
            this.lblTimeTo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblTimeTo.AutoSize = true;
            this.lblTimeTo.Location = new System.Drawing.Point(259, 66);
            this.lblTimeTo.Name = "lblTimeTo";
            this.lblTimeTo.Size = new System.Drawing.Size(17, 12);
            this.lblTimeTo.TabIndex = 5;
            this.lblTimeTo.Text = "--";
            // 
            // lblSmoothScale
            // 
            this.lblSmoothScale.AutoSize = true;
            this.lblSmoothScale.Location = new System.Drawing.Point(24, 104);
            this.lblSmoothScale.Name = "lblSmoothScale";
            this.lblSmoothScale.Size = new System.Drawing.Size(71, 12);
            this.lblSmoothScale.TabIndex = 6;
            this.lblSmoothScale.Text = "回放平滑度:";
            // 
            // lblReplayTimesegment
            // 
            this.lblReplayTimesegment.AutoSize = true;
            this.lblReplayTimesegment.Location = new System.Drawing.Point(24, 66);
            this.lblReplayTimesegment.Name = "lblReplayTimesegment";
            this.lblReplayTimesegment.Size = new System.Drawing.Size(71, 12);
            this.lblReplayTimesegment.TabIndex = 7;
            this.lblReplayTimesegment.Text = "回放时间段:";
            // 
            // btnReplay
            // 
            this.btnReplay.Location = new System.Drawing.Point(107, 217);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(105, 28);
            this.btnReplay.TabIndex = 8;
            this.btnReplay.Text = "开始回放";
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(243, 217);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(105, 28);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "停止回放";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblPercent.Location = new System.Drawing.Point(229, 124);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(17, 12);
            this.lblPercent.TabIndex = 10;
            this.lblPercent.Text = "0%";
            // 
            // lblReplaySpeed
            // 
            this.lblReplaySpeed.AutoSize = true;
            this.lblReplaySpeed.Location = new System.Drawing.Point(24, 160);
            this.lblReplaySpeed.Name = "lblReplaySpeed";
            this.lblReplaySpeed.Size = new System.Drawing.Size(71, 12);
            this.lblReplaySpeed.TabIndex = 12;
            this.lblReplaySpeed.Text = "回放速度  :";
            // 
            // trbReplaySpeed
            // 
            this.trbReplaySpeed.Location = new System.Drawing.Point(107, 146);
            this.trbReplaySpeed.Maximum = 100;
            this.trbReplaySpeed.Name = "trbReplaySpeed";
            this.trbReplaySpeed.Size = new System.Drawing.Size(322, 42);
            this.trbReplaySpeed.TabIndex = 11;
            this.trbReplaySpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // frmTackingReplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 257);
            this.Controls.Add(this.lblReplaySpeed);
            this.Controls.Add(this.trbReplaySpeed);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.lblReplayTimesegment);
            this.Controls.Add(this.lblSmoothScale);
            this.Controls.Add(this.lblTimeTo);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.trbSmoothScale);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.cbbCarNumber);
            this.Controls.Add(this.lblCarNumber);
            this.Name = "frmTackingReplay";
            this.TabText = "frmTackingReplay";
            this.Text = "frmTackingReplay";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTackingReplay_FormClosing);
            this.Load += new System.EventHandler(this.frmTackingReplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbSmoothScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbReplaySpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarNumber;
        private System.Windows.Forms.ComboBox cbbCarNumber;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.TrackBar trbSmoothScale;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label lblTimeTo;
        private System.Windows.Forms.Label lblSmoothScale;
        private System.Windows.Forms.Label lblReplayTimesegment;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblReplaySpeed;
        private System.Windows.Forms.TrackBar trbReplaySpeed;
    }
}
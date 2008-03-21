namespace GPSTrackingRecorder
{
    partial class frmSocketConfig
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
            this.lblServerIP = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQueueMax = new System.Windows.Forms.TextBox();
            this.txtLiseningPort = new System.Windows.Forms.TextBox();
            this.lblQueueMax = new System.Windows.Forms.Label();
            this.lblLiseningPort = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(19, 26);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(101, 12);
            this.lblServerIP.TabIndex = 0;
            this.lblServerIP.Text = "消息服务器地址 :";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(99, 149);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(106, 36);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确  定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(127, 23);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(139, 21);
            this.txtServerIP.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQueueMax);
            this.groupBox1.Controls.Add(this.txtLiseningPort);
            this.groupBox1.Controls.Add(this.txtServerIP);
            this.groupBox1.Controls.Add(this.lblQueueMax);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.lblLiseningPort);
            this.groupBox1.Controls.Add(this.lblServerIP);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 201);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtQueueMax
            // 
            this.txtQueueMax.Location = new System.Drawing.Point(127, 107);
            this.txtQueueMax.Name = "txtQueueMax";
            this.txtQueueMax.Size = new System.Drawing.Size(139, 21);
            this.txtQueueMax.TabIndex = 7;
            // 
            // txtLiseningPort
            // 
            this.txtLiseningPort.Location = new System.Drawing.Point(126, 62);
            this.txtLiseningPort.Name = "txtLiseningPort";
            this.txtLiseningPort.Size = new System.Drawing.Size(139, 21);
            this.txtLiseningPort.TabIndex = 6;
            // 
            // lblQueueMax
            // 
            this.lblQueueMax.AutoSize = true;
            this.lblQueueMax.Location = new System.Drawing.Point(19, 110);
            this.lblQueueMax.Name = "lblQueueMax";
            this.lblQueueMax.Size = new System.Drawing.Size(101, 12);
            this.lblQueueMax.TabIndex = 5;
            this.lblQueueMax.Text = "消息队列容量   :";
            // 
            // lblLiseningPort
            // 
            this.lblLiseningPort.AutoSize = true;
            this.lblLiseningPort.Location = new System.Drawing.Point(19, 65);
            this.lblLiseningPort.Name = "lblLiseningPort";
            this.lblLiseningPort.Size = new System.Drawing.Size(101, 12);
            this.lblLiseningPort.TabIndex = 4;
            this.lblLiseningPort.Text = "本地监听端口   :";
            // 
            // frmSocketConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 221);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSocketConfig";
            this.Text = "轨迹记录服务器参数设置";
            this.Load += new System.EventHandler(this.frmSocketConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLiseningPort;
        private System.Windows.Forms.Label lblQueueMax;
        private System.Windows.Forms.TextBox txtQueueMax;
        private System.Windows.Forms.TextBox txtLiseningPort;
    }
}
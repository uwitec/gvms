namespace GPSGatewaySimulator
{
    partial class frmSendMessage
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
            this.btnStartSend = new System.Windows.Forms.Button();
            this.lblSenderPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartSend
            // 
            this.btnStartSend.Location = new System.Drawing.Point(83, 90);
            this.btnStartSend.Name = "btnStartSend";
            this.btnStartSend.Size = new System.Drawing.Size(74, 30);
            this.btnStartSend.TabIndex = 2;
            this.btnStartSend.Text = "确  定";
            this.btnStartSend.UseVisualStyleBackColor = true;
            this.btnStartSend.Click += new System.EventHandler(this.btnStartSend_Click);
            // 
            // lblSenderPort
            // 
            this.lblSenderPort.AutoSize = true;
            this.lblSenderPort.Location = new System.Drawing.Point(15, 15);
            this.lblSenderPort.Name = "lblSenderPort";
            this.lblSenderPort.Size = new System.Drawing.Size(77, 12);
            this.lblSenderPort.TabIndex = 9;
            this.lblSenderPort.Text = "接收端端口 :";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(93, 13);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(124, 21);
            this.txtPort.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.btnStartSend);
            this.groupBox1.Controls.Add(this.txtInterval);
            this.groupBox1.Location = new System.Drawing.Point(5, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 126);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "间隔时间   :";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(93, 50);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(124, 21);
            this.txtInterval.TabIndex = 11;
            // 
            // frmSendMessage
            // 
            this.ClientSize = new System.Drawing.Size(234, 137);
            this.Controls.Add(this.lblSenderPort);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSendMessage";
            this.Load += new System.EventHandler(this.frmSendMessage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartSend;
        private System.Windows.Forms.Label lblSenderPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInterval;
    }
}
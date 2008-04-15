namespace GPSTrackingMonitor
{
    partial class frmSenderExceptionInfos
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
            this.btnSendBugs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtErrorInfos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUserLeavedWords = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendBugs
            // 
            this.btnSendBugs.Location = new System.Drawing.Point(448, 377);
            this.btnSendBugs.Name = "btnSendBugs";
            this.btnSendBugs.Size = new System.Drawing.Size(77, 35);
            this.btnSendBugs.TabIndex = 1;
            this.btnSendBugs.Text = "发送报告";
            this.btnSendBugs.UseVisualStyleBackColor = true;
            this.btnSendBugs.Click += new System.EventHandler(this.btnSendBugs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = Properties.Resources._123;
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtErrorInfos
            // 
            this.txtErrorInfos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtErrorInfos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtErrorInfos.Location = new System.Drawing.Point(7, 20);
            this.txtErrorInfos.Multiline = true;
            this.txtErrorInfos.Name = "txtErrorInfos";
            this.txtErrorInfos.ReadOnly = true;
            this.txtErrorInfos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtErrorInfos.Size = new System.Drawing.Size(532, 95);
            this.txtErrorInfos.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtErrorInfos);
            this.groupBox1.Location = new System.Drawing.Point(5, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 126);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "错误信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUserLeavedWords);
            this.groupBox2.Location = new System.Drawing.Point(5, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 116);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "您的留言";
            // 
            // txtUserLeavedWords
            // 
            this.txtUserLeavedWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserLeavedWords.Location = new System.Drawing.Point(6, 20);
            this.txtUserLeavedWords.Multiline = true;
            this.txtUserLeavedWords.Name = "txtUserLeavedWords";
            this.txtUserLeavedWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserLeavedWords.Size = new System.Drawing.Size(533, 88);
            this.txtUserLeavedWords.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(368, 377);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "退 出";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(184, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 98);
            this.label1.TabIndex = 8;
            this.label1.Text = "  \r\n　由于时间和精力等方面的原因，该应用程序还没能达到\r\n非常完美的程度，对此我们深感抱歉。同时也希望您对我\r\n们的工作给与支持，将出现的bug提交给我们，我" +
                "们将在最\r\n短的时间内提供解决方案。\r\n　　非常谢谢您的配合！\r\n";
            // 
            // frmSenderExceptionInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSendBugs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSenderExceptionInfos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "报告Bugs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSendBugs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtErrorInfos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUserLeavedWords;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
    }
}
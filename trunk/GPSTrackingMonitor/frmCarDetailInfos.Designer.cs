namespace GPSTrackingMonitor
{
    partial class frmCarDetailInfos
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCarNumber = new System.Windows.Forms.TextBox();
            this.lblCarNumber = new System.Windows.Forms.Label();
            this.txtDirection = new System.Windows.Forms.TextBox();
            this.lblDirection = new System.Windows.Forms.Label();
            this.txtCoordinate = new System.Windows.Forms.TextBox();
            this.lblCoordinate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(166, 172);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 29);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确  定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 60);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 12);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "联系电话";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(89, 57);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(154, 21);
            this.txtPhone.TabIndex = 2;
            // 
            // txtCarNumber
            // 
            this.txtCarNumber.Location = new System.Drawing.Point(89, 17);
            this.txtCarNumber.Name = "txtCarNumber";
            this.txtCarNumber.Size = new System.Drawing.Size(154, 21);
            this.txtCarNumber.TabIndex = 6;
            // 
            // lblCarNumber
            // 
            this.lblCarNumber.AutoSize = true;
            this.lblCarNumber.Location = new System.Drawing.Point(22, 21);
            this.lblCarNumber.Name = "lblCarNumber";
            this.lblCarNumber.Size = new System.Drawing.Size(53, 12);
            this.lblCarNumber.TabIndex = 5;
            this.lblCarNumber.Text = "车牌号码";
            // 
            // txtDirection
            // 
            this.txtDirection.Location = new System.Drawing.Point(89, 135);
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Size = new System.Drawing.Size(154, 21);
            this.txtDirection.TabIndex = 10;
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(15, 144);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(53, 12);
            this.lblDirection.TabIndex = 9;
            this.lblDirection.Text = "行驶方向";
            // 
            // txtCoordinate
            // 
            this.txtCoordinate.Location = new System.Drawing.Point(89, 98);
            this.txtCoordinate.Name = "txtCoordinate";
            this.txtCoordinate.Size = new System.Drawing.Size(154, 21);
            this.txtCoordinate.TabIndex = 16;
            // 
            // lblCoordinate
            // 
            this.lblCoordinate.AutoSize = true;
            this.lblCoordinate.Location = new System.Drawing.Point(15, 101);
            this.lblCoordinate.Name = "lblCoordinate";
            this.lblCoordinate.Size = new System.Drawing.Size(29, 12);
            this.lblCoordinate.TabIndex = 15;
            this.lblCoordinate.Text = "坐标";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDirection);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.txtCoordinate);
            this.groupBox1.Controls.Add(this.lblDirection);
            this.groupBox1.Controls.Add(this.txtCarNumber);
            this.groupBox1.Controls.Add(this.lblCoordinate);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Location = new System.Drawing.Point(7, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 223);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // frmCarDetailInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 230);
            this.Controls.Add(this.lblCarNumber);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCarDetailInfos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "车辆详细信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCarNumber;
        private System.Windows.Forms.Label lblCarNumber;
        private System.Windows.Forms.TextBox txtDirection;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TextBox txtCoordinate;
        private System.Windows.Forms.Label lblCoordinate;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
namespace GPSGatewaySimulator
{
    partial class frmSetLoadParas
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
            this.txtLayerPath = new System.Windows.Forms.TextBox();
            this.btnBrowseLayerPath = new System.Windows.Forms.Button();
            this.lblLayerPath = new System.Windows.Forms.Label();
            this.btnGetRandomPoints = new System.Windows.Forms.Button();
            this.txtPointCount = new System.Windows.Forms.MaskedTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdbAllPoints = new System.Windows.Forms.RadioButton();
            this.rdbSetCountPoints = new System.Windows.Forms.RadioButton();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLayerPath
            // 
            this.txtLayerPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLayerPath.Location = new System.Drawing.Point(72, 12);
            this.txtLayerPath.Name = "txtLayerPath";
            this.txtLayerPath.Size = new System.Drawing.Size(179, 21);
            this.txtLayerPath.TabIndex = 6;
            // 
            // btnBrowseLayerPath
            // 
            this.btnBrowseLayerPath.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowseLayerPath.Location = new System.Drawing.Point(252, 12);
            this.btnBrowseLayerPath.Name = "btnBrowseLayerPath";
            this.btnBrowseLayerPath.Size = new System.Drawing.Size(36, 20);
            this.btnBrowseLayerPath.TabIndex = 5;
            this.btnBrowseLayerPath.Text = "...";
            this.btnBrowseLayerPath.UseVisualStyleBackColor = true;
            this.btnBrowseLayerPath.Click += new System.EventHandler(this.btnBrowseLayerPath_Click);
            // 
            // lblLayerPath
            // 
            this.lblLayerPath.AutoEllipsis = true;
            this.lblLayerPath.AutoSize = true;
            this.lblLayerPath.Location = new System.Drawing.Point(13, 18);
            this.lblLayerPath.Name = "lblLayerPath";
            this.lblLayerPath.Size = new System.Drawing.Size(53, 12);
            this.lblLayerPath.TabIndex = 4;
            this.lblLayerPath.Text = "地图路径";
            // 
            // btnGetRandomPoints
            // 
            this.btnGetRandomPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetRandomPoints.Location = new System.Drawing.Point(28, 130);
            this.btnGetRandomPoints.Name = "btnGetRandomPoints";
            this.btnGetRandomPoints.Size = new System.Drawing.Size(82, 33);
            this.btnGetRandomPoints.TabIndex = 7;
            this.btnGetRandomPoints.Text = "提取随机点";
            this.btnGetRandomPoints.UseVisualStyleBackColor = true;
            this.btnGetRandomPoints.Click += new System.EventHandler(this.btnGetRandomPoints_Click);
            // 
            // txtPointCount
            // 
            this.txtPointCount.BeepOnError = true;
            this.txtPointCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPointCount.Location = new System.Drawing.Point(206, 85);
            this.txtPointCount.Mask = "9999999999999";
            this.txtPointCount.Name = "txtPointCount";
            this.txtPointCount.Size = new System.Drawing.Size(82, 21);
            this.txtPointCount.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(144, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 33);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdbAllPoints
            // 
            this.rdbAllPoints.AutoSize = true;
            this.rdbAllPoints.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbAllPoints.Location = new System.Drawing.Point(15, 90);
            this.rdbAllPoints.Name = "rdbAllPoints";
            this.rdbAllPoints.Size = new System.Drawing.Size(82, 16);
            this.rdbAllPoints.TabIndex = 12;
            this.rdbAllPoints.Text = "提取全部点";
            this.rdbAllPoints.UseVisualStyleBackColor = true;
            this.rdbAllPoints.CheckedChanged += new System.EventHandler(this.rdbAllPoints_CheckedChanged);
            // 
            // rdbSetCountPoints
            // 
            this.rdbSetCountPoints.AutoSize = true;
            this.rdbSetCountPoints.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbSetCountPoints.Location = new System.Drawing.Point(118, 90);
            this.rdbSetCountPoints.Name = "rdbSetCountPoints";
            this.rdbSetCountPoints.Size = new System.Drawing.Size(82, 16);
            this.rdbSetCountPoints.TabIndex = 13;
            this.rdbSetCountPoints.Text = "指定点数量";
            this.rdbSetCountPoints.UseVisualStyleBackColor = true;
            this.rdbSetCountPoints.CheckedChanged += new System.EventHandler(this.rdbSetCountPoints_CheckedChanged);
            // 
            // txtInterval
            // 
            this.txtInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInterval.Location = new System.Drawing.Point(72, 48);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(141, 21);
            this.txtInterval.TabIndex = 15;
            // 
            // lblInterval
            // 
            this.lblInterval.AutoEllipsis = true;
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(13, 54);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(53, 12);
            this.lblInterval.TabIndex = 14;
            this.lblInterval.Text = "时间间隔";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "(单位：秒)";
            // 
            // frmSetLoadParas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 183);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.rdbSetCountPoints);
            this.Controls.Add(this.rdbAllPoints);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPointCount);
            this.Controls.Add(this.btnGetRandomPoints);
            this.Controls.Add(this.txtLayerPath);
            this.Controls.Add(this.btnBrowseLayerPath);
            this.Controls.Add(this.lblLayerPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSetLoadParas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLayerPath;
        private System.Windows.Forms.Button btnBrowseLayerPath;
        private System.Windows.Forms.Label lblLayerPath;
        private System.Windows.Forms.Button btnGetRandomPoints;
        private System.Windows.Forms.MaskedTextBox txtPointCount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdbAllPoints;
        private System.Windows.Forms.RadioButton rdbSetCountPoints;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label label1;
    }
}
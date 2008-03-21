namespace GPSGatewaySimulator
{
    partial class frmRealtimeDataView
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
            this.pnlOperation = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvRealtimeDataView = new System.Windows.Forms.DataGridView();
            this.pnlOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealtimeDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOperation
            // 
            this.pnlOperation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOperation.Controls.Add(this.button3);
            this.pnlOperation.Controls.Add(this.button2);
            this.pnlOperation.Controls.Add(this.button1);
            this.pnlOperation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOperation.Location = new System.Drawing.Point(0, 409);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(597, 110);
            this.pnlOperation.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Location = new System.Drawing.Point(81, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(252, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(389, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRealtimeDataView
            // 
            this.dgvRealtimeDataView.AllowUserToAddRows = false;
            this.dgvRealtimeDataView.AllowUserToResizeRows = false;
            this.dgvRealtimeDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRealtimeDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRealtimeDataView.Location = new System.Drawing.Point(0, 0);
            this.dgvRealtimeDataView.Name = "dgvRealtimeDataView";
            this.dgvRealtimeDataView.RowTemplate.Height = 23;
            this.dgvRealtimeDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRealtimeDataView.Size = new System.Drawing.Size(597, 409);
            this.dgvRealtimeDataView.TabIndex = 1;
            // 
            // frmRealtimeDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 519);
            this.Controls.Add(this.dgvRealtimeDataView);
            this.Controls.Add(this.pnlOperation);
            this.Name = "frmRealtimeDataView";
            this.TabText = "frmRealtimeDataView";
            this.Text = "frmRealtimeDataView";
            this.pnlOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealtimeDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvRealtimeDataView;
    }
}
namespace GPSGatewaySimulator
{
    partial class frmLoadRandomLocation
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
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvRandomPoints = new System.Windows.Forms.DataGridView();
            this.btnLoadPointsIntoDatabase = new System.Windows.Forms.Button();
            this.btnAddRandomPoints = new System.Windows.Forms.Button();
            this.btnViewRandomData = new System.Windows.Forms.Button();
            this.dgvRandomDatabase = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandomPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandomDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(344, 527);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 32);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "退  出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvRandomPoints
            // 
            this.dgvRandomPoints.AllowUserToAddRows = false;
            this.dgvRandomPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRandomPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandomPoints.Location = new System.Drawing.Point(5, 12);
            this.dgvRandomPoints.Name = "dgvRandomPoints";
            this.dgvRandomPoints.RowTemplate.Height = 23;
            this.dgvRandomPoints.Size = new System.Drawing.Size(471, 495);
            this.dgvRandomPoints.TabIndex = 9;
            // 
            // btnLoadPointsIntoDatabase
            // 
            this.btnLoadPointsIntoDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadPointsIntoDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPointsIntoDatabase.Location = new System.Drawing.Point(146, 527);
            this.btnLoadPointsIntoDatabase.Name = "btnLoadPointsIntoDatabase";
            this.btnLoadPointsIntoDatabase.Size = new System.Drawing.Size(79, 32);
            this.btnLoadPointsIntoDatabase.TabIndex = 11;
            this.btnLoadPointsIntoDatabase.Text = "导入数据库";
            this.btnLoadPointsIntoDatabase.UseVisualStyleBackColor = true;
            this.btnLoadPointsIntoDatabase.Click += new System.EventHandler(this.btnLoadPointsIntoDatabase_Click);
            // 
            // btnAddRandomPoints
            // 
            this.btnAddRandomPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRandomPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRandomPoints.Location = new System.Drawing.Point(47, 527);
            this.btnAddRandomPoints.Name = "btnAddRandomPoints";
            this.btnAddRandomPoints.Size = new System.Drawing.Size(79, 32);
            this.btnAddRandomPoints.TabIndex = 10;
            this.btnAddRandomPoints.Text = "添加随机点";
            this.btnAddRandomPoints.UseVisualStyleBackColor = true;
            this.btnAddRandomPoints.Click += new System.EventHandler(this.btnAddRandomPoints_Click);
            // 
            // btnViewRandomData
            // 
            this.btnViewRandomData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewRandomData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRandomData.Location = new System.Drawing.Point(245, 527);
            this.btnViewRandomData.Name = "btnViewRandomData";
            this.btnViewRandomData.Size = new System.Drawing.Size(79, 32);
            this.btnViewRandomData.TabIndex = 13;
            this.btnViewRandomData.Text = "查看数据库";
            this.btnViewRandomData.UseVisualStyleBackColor = true;
            this.btnViewRandomData.Click += new System.EventHandler(this.btnViewRandomData_Click);
            // 
            // dgvRandomDatabase
            // 
            this.dgvRandomDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRandomDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandomDatabase.Location = new System.Drawing.Point(242, 197);
            this.dgvRandomDatabase.Name = "dgvRandomDatabase";
            this.dgvRandomDatabase.RowTemplate.Height = 23;
            this.dgvRandomDatabase.Size = new System.Drawing.Size(181, 140);
            this.dgvRandomDatabase.TabIndex = 14;
            // 
            // frmLoadRandomLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 571);
            this.Controls.Add(this.dgvRandomDatabase);
            this.Controls.Add(this.btnViewRandomData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvRandomPoints);
            this.Controls.Add(this.btnLoadPointsIntoDatabase);
            this.Controls.Add(this.btnAddRandomPoints);
            this.Name = "frmLoadRandomLocation";
            this.TabText = "frmLoadRandomLocation";
            this.Text = "提取随机坐标点";
            this.Load += new System.EventHandler(this.frmLoadRandomLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandomPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandomDatabase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvRandomPoints;
        private System.Windows.Forms.Button btnLoadPointsIntoDatabase;
        private System.Windows.Forms.Button btnAddRandomPoints;
        private System.Windows.Forms.Button btnViewRandomData;
        private System.Windows.Forms.DataGridView dgvRandomDatabase;

    }
}
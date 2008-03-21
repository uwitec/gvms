namespace GPSTrackingMonitor
{
    partial class frmCarSearcher
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
            this.lblCarNumber = new System.Windows.Forms.Label();
            this.txtCarNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlSearchType = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchType = new System.Windows.Forms.Label();
            this.cbbSearchType = new System.Windows.Forms.ComboBox();
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.pnlSearchedByCarNumber = new System.Windows.Forms.Panel();
            this.ckbAllMatched = new System.Windows.Forms.CheckBox();
            this.pnlSeachedByCustomFilter = new System.Windows.Forms.Panel();
            this.btnAdvanceFilter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomFilter = new System.Windows.Forms.TextBox();
            this.pnlSearchedByLocation = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFetchPoint = new System.Windows.Forms.Button();
            this.txtSearchRaduis = new System.Windows.Forms.TextBox();
            this.txtCoordX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCoordY = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.pnlSearchType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            this.pnlSearchedByCarNumber.SuspendLayout();
            this.pnlSeachedByCustomFilter.SuspendLayout();
            this.pnlSearchedByLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(335, 440);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 31);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确   定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblCarNumber
            // 
            this.lblCarNumber.AutoSize = true;
            this.lblCarNumber.Location = new System.Drawing.Point(4, 18);
            this.lblCarNumber.Name = "lblCarNumber";
            this.lblCarNumber.Size = new System.Drawing.Size(53, 12);
            this.lblCarNumber.TabIndex = 1;
            this.lblCarNumber.Text = "车牌号码";
            // 
            // txtCarNumber
            // 
            this.txtCarNumber.AcceptsReturn = true;
            this.txtCarNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarNumber.Location = new System.Drawing.Point(63, 13);
            this.txtCarNumber.Name = "txtCarNumber";
            this.txtCarNumber.Size = new System.Drawing.Size(254, 21);
            this.txtCarNumber.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlSearchType);
            this.groupBox1.Controls.Add(this.dgvSearchResult);
            this.groupBox1.Controls.Add(this.pnlSearchedByCarNumber);
            this.groupBox1.Controls.Add(this.pnlSeachedByCustomFilter);
            this.groupBox1.Controls.Add(this.pnlSearchedByLocation);
            this.groupBox1.Location = new System.Drawing.Point(7, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 422);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // pnlSearchType
            // 
            this.pnlSearchType.Controls.Add(this.btnSearch);
            this.pnlSearchType.Controls.Add(this.lblSearchType);
            this.pnlSearchType.Controls.Add(this.cbbSearchType);
            this.pnlSearchType.Location = new System.Drawing.Point(8, 11);
            this.pnlSearchType.Name = "pnlSearchType";
            this.pnlSearchType.Size = new System.Drawing.Size(400, 44);
            this.pnlSearchType.TabIndex = 23;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(324, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 32);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "查  询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchType
            // 
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Location = new System.Drawing.Point(3, 18);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(53, 12);
            this.lblSearchType.TabIndex = 6;
            this.lblSearchType.Text = "查询方式";
            this.lblSearchType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbbSearchType
            // 
            this.cbbSearchType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSearchType.FormattingEnabled = true;
            this.cbbSearchType.Items.AddRange(new object[] {
            "根据车牌号码",
            "根据位置范围",
            "自定义过滤条件"});
            this.cbbSearchType.Location = new System.Drawing.Point(63, 14);
            this.cbbSearchType.Name = "cbbSearchType";
            this.cbbSearchType.Size = new System.Drawing.Size(244, 20);
            this.cbbSearchType.TabIndex = 5;
            this.cbbSearchType.SelectedIndexChanged += new System.EventHandler(this.cbbSearchType_SelectedIndexChanged);
            // 
            // dgvSearchResult
            // 
            this.dgvSearchResult.AllowUserToAddRows = false;
            this.dgvSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Location = new System.Drawing.Point(9, 256);
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.ReadOnly = true;
            this.dgvSearchResult.RowTemplate.Height = 23;
            this.dgvSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchResult.Size = new System.Drawing.Size(399, 154);
            this.dgvSearchResult.TabIndex = 22;
            this.dgvSearchResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchResult_CellDoubleClick);
            // 
            // pnlSearchedByCarNumber
            // 
            this.pnlSearchedByCarNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchedByCarNumber.Controls.Add(this.lblCarNumber);
            this.pnlSearchedByCarNumber.Controls.Add(this.ckbAllMatched);
            this.pnlSearchedByCarNumber.Controls.Add(this.txtCarNumber);
            this.pnlSearchedByCarNumber.Location = new System.Drawing.Point(8, 51);
            this.pnlSearchedByCarNumber.Name = "pnlSearchedByCarNumber";
            this.pnlSearchedByCarNumber.Size = new System.Drawing.Size(400, 48);
            this.pnlSearchedByCarNumber.TabIndex = 21;
            // 
            // ckbAllMatched
            // 
            this.ckbAllMatched.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbAllMatched.AutoSize = true;
            this.ckbAllMatched.Location = new System.Drawing.Point(323, 14);
            this.ckbAllMatched.Name = "ckbAllMatched";
            this.ckbAllMatched.Size = new System.Drawing.Size(72, 16);
            this.ckbAllMatched.TabIndex = 4;
            this.ckbAllMatched.Text = "精确查询";
            this.ckbAllMatched.UseVisualStyleBackColor = true;
            // 
            // pnlSeachedByCustomFilter
            // 
            this.pnlSeachedByCustomFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeachedByCustomFilter.Controls.Add(this.btnAdvanceFilter);
            this.pnlSeachedByCustomFilter.Controls.Add(this.label4);
            this.pnlSeachedByCustomFilter.Controls.Add(this.txtCustomFilter);
            this.pnlSeachedByCustomFilter.Location = new System.Drawing.Point(8, 105);
            this.pnlSeachedByCustomFilter.Name = "pnlSeachedByCustomFilter";
            this.pnlSeachedByCustomFilter.Size = new System.Drawing.Size(400, 68);
            this.pnlSeachedByCustomFilter.TabIndex = 20;
            // 
            // btnAdvanceFilter
            // 
            this.btnAdvanceFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdvanceFilter.Location = new System.Drawing.Point(333, 22);
            this.btnAdvanceFilter.Name = "btnAdvanceFilter";
            this.btnAdvanceFilter.Size = new System.Drawing.Size(62, 27);
            this.btnAdvanceFilter.TabIndex = 11;
            this.btnAdvanceFilter.Text = "高级...";
            this.btnAdvanceFilter.UseVisualStyleBackColor = true;
            this.btnAdvanceFilter.Click += new System.EventHandler(this.btnAdvanceFilter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "过滤条件";
            // 
            // txtCustomFilter
            // 
            this.txtCustomFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomFilter.Location = new System.Drawing.Point(63, 10);
            this.txtCustomFilter.Multiline = true;
            this.txtCustomFilter.Name = "txtCustomFilter";
            this.txtCustomFilter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCustomFilter.Size = new System.Drawing.Size(254, 55);
            this.txtCustomFilter.TabIndex = 10;
            // 
            // pnlSearchedByLocation
            // 
            this.pnlSearchedByLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchedByLocation.Controls.Add(this.label1);
            this.pnlSearchedByLocation.Controls.Add(this.label3);
            this.pnlSearchedByLocation.Controls.Add(this.btnFetchPoint);
            this.pnlSearchedByLocation.Controls.Add(this.txtSearchRaduis);
            this.pnlSearchedByLocation.Controls.Add(this.txtCoordX);
            this.pnlSearchedByLocation.Controls.Add(this.label6);
            this.pnlSearchedByLocation.Controls.Add(this.label5);
            this.pnlSearchedByLocation.Controls.Add(this.txtCoordY);
            this.pnlSearchedByLocation.Location = new System.Drawing.Point(9, 176);
            this.pnlSearchedByLocation.Name = "pnlSearchedByLocation";
            this.pnlSearchedByLocation.Size = new System.Drawing.Size(399, 79);
            this.pnlSearchedByLocation.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "(单位：米)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "X坐标";
            // 
            // btnFetchPoint
            // 
            this.btnFetchPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFetchPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFetchPoint.Location = new System.Drawing.Point(280, 43);
            this.btnFetchPoint.Name = "btnFetchPoint";
            this.btnFetchPoint.Size = new System.Drawing.Size(115, 31);
            this.btnFetchPoint.TabIndex = 16;
            this.btnFetchPoint.Text = "地图交互";
            this.btnFetchPoint.UseVisualStyleBackColor = true;
            this.btnFetchPoint.Click += new System.EventHandler(this.btnFetchPoint_Click);
            // 
            // txtSearchRaduis
            // 
            this.txtSearchRaduis.AcceptsReturn = true;
            this.txtSearchRaduis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchRaduis.Location = new System.Drawing.Point(72, 46);
            this.txtSearchRaduis.Name = "txtSearchRaduis";
            this.txtSearchRaduis.Size = new System.Drawing.Size(104, 21);
            this.txtSearchRaduis.TabIndex = 15;
            // 
            // txtCoordX
            // 
            this.txtCoordX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoordX.Location = new System.Drawing.Point(45, 9);
            this.txtCoordX.Name = "txtCoordX";
            this.txtCoordX.Size = new System.Drawing.Size(141, 21);
            this.txtCoordX.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "搜索范围";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Y坐标";
            // 
            // txtCoordY
            // 
            this.txtCoordY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoordY.Location = new System.Drawing.Point(252, 8);
            this.txtCoordY.Name = "txtCoordY";
            this.txtCoordY.Size = new System.Drawing.Size(144, 21);
            this.txtCoordY.TabIndex = 13;
            // 
            // frmCarSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(433, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Name = "frmCarSearcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "frmCarSearcher";
            this.Text = "frmCarSearcher";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCarSearcher_Load);
            this.groupBox1.ResumeLayout(false);
            this.pnlSearchType.ResumeLayout(false);
            this.pnlSearchType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            this.pnlSearchedByCarNumber.ResumeLayout(false);
            this.pnlSearchedByCarNumber.PerformLayout();
            this.pnlSeachedByCustomFilter.ResumeLayout(false);
            this.pnlSeachedByCustomFilter.PerformLayout();
            this.pnlSearchedByLocation.ResumeLayout(false);
            this.pnlSearchedByLocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblCarNumber;
        private System.Windows.Forms.TextBox txtCarNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbAllMatched;
        private System.Windows.Forms.Label lblSearchType;
        private System.Windows.Forms.ComboBox cbbSearchType;
        private System.Windows.Forms.TextBox txtCustomFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCoordX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFetchPoint;
        private System.Windows.Forms.TextBox txtSearchRaduis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCoordY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdvanceFilter;
        private System.Windows.Forms.Panel pnlSearchedByCarNumber;
        private System.Windows.Forms.Panel pnlSeachedByCustomFilter;
        private System.Windows.Forms.Panel pnlSearchedByLocation;
        private System.Windows.Forms.DataGridView dgvSearchResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSearchType;
        private System.Windows.Forms.Button btnSearch;
    }
}
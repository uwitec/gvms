namespace GPSTrackingMonitor
{
    partial class frmAdvanceFilter
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
            this.lstFields = new System.Windows.Forms.ListBox();
            this.btnOperationEquel = new System.Windows.Forms.Button();
            this.btnOperationNot = new System.Windows.Forms.Button();
            this.btnOperationParenthesis = new System.Windows.Forms.Button();
            this.btnOperationMatch = new System.Windows.Forms.Button();
            this.btnOperationOr = new System.Windows.Forms.Button();
            this.btnOperationSmallerEquel = new System.Windows.Forms.Button();
            this.btnOperationSmaller = new System.Windows.Forms.Button();
            this.btnOperationAnd = new System.Windows.Forms.Button();
            this.btnOperationLargerEquel = new System.Windows.Forms.Button();
            this.btnOperationLarger = new System.Windows.Forms.Button();
            this.btnOperationLike = new System.Windows.Forms.Button();
            this.btnOperationNotEquel = new System.Windows.Forms.Button();
            this.btnListUniqueValues = new System.Windows.Forms.Button();
            this.lstUniqueValues = new System.Windows.Forms.ListBox();
            this.txtFilterString = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveFilterExpression = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnLoadFilterExpression = new System.Windows.Forms.Button();
            this.btnClearFilterString = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFields
            // 
            this.lstFields.FormattingEnabled = true;
            this.lstFields.ItemHeight = 12;
            this.lstFields.Location = new System.Drawing.Point(10, 13);
            this.lstFields.Name = "lstFields";
            this.lstFields.Size = new System.Drawing.Size(337, 88);
            this.lstFields.TabIndex = 0;
            this.lstFields.DoubleClick += new System.EventHandler(this.lstFields_DoubleClick);
            // 
            // btnOperationEquel
            // 
            this.btnOperationEquel.Location = new System.Drawing.Point(11, 111);
            this.btnOperationEquel.Name = "btnOperationEquel";
            this.btnOperationEquel.Size = new System.Drawing.Size(38, 22);
            this.btnOperationEquel.TabIndex = 1;
            this.btnOperationEquel.Text = "=";
            this.btnOperationEquel.UseVisualStyleBackColor = true;
            this.btnOperationEquel.Click += new System.EventHandler(this.btnOperationEquel_Click);
            // 
            // btnOperationNot
            // 
            this.btnOperationNot.Location = new System.Drawing.Point(109, 210);
            this.btnOperationNot.Name = "btnOperationNot";
            this.btnOperationNot.Size = new System.Drawing.Size(38, 22);
            this.btnOperationNot.TabIndex = 2;
            this.btnOperationNot.Text = "not";
            this.btnOperationNot.UseVisualStyleBackColor = true;
            this.btnOperationNot.Click += new System.EventHandler(this.btnOperationNot_Click);
            // 
            // btnOperationParenthesis
            // 
            this.btnOperationParenthesis.Location = new System.Drawing.Point(60, 210);
            this.btnOperationParenthesis.Name = "btnOperationParenthesis";
            this.btnOperationParenthesis.Size = new System.Drawing.Size(38, 22);
            this.btnOperationParenthesis.TabIndex = 3;
            this.btnOperationParenthesis.Text = "()";
            this.btnOperationParenthesis.UseVisualStyleBackColor = true;
            this.btnOperationParenthesis.Click += new System.EventHandler(this.btnOperationParenthesis_Click);
            // 
            // btnOperationMatch
            // 
            this.btnOperationMatch.Location = new System.Drawing.Point(11, 210);
            this.btnOperationMatch.Name = "btnOperationMatch";
            this.btnOperationMatch.Size = new System.Drawing.Size(38, 22);
            this.btnOperationMatch.TabIndex = 4;
            this.btnOperationMatch.Text = "%";
            this.btnOperationMatch.UseVisualStyleBackColor = true;
            this.btnOperationMatch.Click += new System.EventHandler(this.btnOperationMatch_Click);
            // 
            // btnOperationOr
            // 
            this.btnOperationOr.Location = new System.Drawing.Point(109, 177);
            this.btnOperationOr.Name = "btnOperationOr";
            this.btnOperationOr.Size = new System.Drawing.Size(38, 22);
            this.btnOperationOr.TabIndex = 5;
            this.btnOperationOr.Text = "or";
            this.btnOperationOr.UseVisualStyleBackColor = true;
            this.btnOperationOr.Click += new System.EventHandler(this.btnOperationOr_Click);
            // 
            // btnOperationSmallerEquel
            // 
            this.btnOperationSmallerEquel.Location = new System.Drawing.Point(60, 177);
            this.btnOperationSmallerEquel.Name = "btnOperationSmallerEquel";
            this.btnOperationSmallerEquel.Size = new System.Drawing.Size(38, 22);
            this.btnOperationSmallerEquel.TabIndex = 6;
            this.btnOperationSmallerEquel.Text = "<=";
            this.btnOperationSmallerEquel.UseVisualStyleBackColor = true;
            this.btnOperationSmallerEquel.Click += new System.EventHandler(this.btnOperationSmallerEquel_Click);
            // 
            // btnOperationSmaller
            // 
            this.btnOperationSmaller.Location = new System.Drawing.Point(11, 177);
            this.btnOperationSmaller.Name = "btnOperationSmaller";
            this.btnOperationSmaller.Size = new System.Drawing.Size(38, 22);
            this.btnOperationSmaller.TabIndex = 7;
            this.btnOperationSmaller.Text = "<";
            this.btnOperationSmaller.UseVisualStyleBackColor = true;
            this.btnOperationSmaller.Click += new System.EventHandler(this.btnOperationSmaller_Click);
            // 
            // btnOperationAnd
            // 
            this.btnOperationAnd.Location = new System.Drawing.Point(109, 144);
            this.btnOperationAnd.Name = "btnOperationAnd";
            this.btnOperationAnd.Size = new System.Drawing.Size(38, 22);
            this.btnOperationAnd.TabIndex = 8;
            this.btnOperationAnd.Text = "and";
            this.btnOperationAnd.UseVisualStyleBackColor = true;
            this.btnOperationAnd.Click += new System.EventHandler(this.btnOperationAnd_Click);
            // 
            // btnOperationLargerEquel
            // 
            this.btnOperationLargerEquel.Location = new System.Drawing.Point(60, 144);
            this.btnOperationLargerEquel.Name = "btnOperationLargerEquel";
            this.btnOperationLargerEquel.Size = new System.Drawing.Size(38, 22);
            this.btnOperationLargerEquel.TabIndex = 9;
            this.btnOperationLargerEquel.Text = ">=";
            this.btnOperationLargerEquel.UseVisualStyleBackColor = true;
            this.btnOperationLargerEquel.Click += new System.EventHandler(this.btnOperationLargerEquel_Click);
            // 
            // btnOperationLarger
            // 
            this.btnOperationLarger.Location = new System.Drawing.Point(11, 144);
            this.btnOperationLarger.Name = "btnOperationLarger";
            this.btnOperationLarger.Size = new System.Drawing.Size(38, 22);
            this.btnOperationLarger.TabIndex = 10;
            this.btnOperationLarger.Text = ">";
            this.btnOperationLarger.UseVisualStyleBackColor = true;
            this.btnOperationLarger.Click += new System.EventHandler(this.btnOperationLarger_Click);
            // 
            // btnOperationLike
            // 
            this.btnOperationLike.Location = new System.Drawing.Point(109, 111);
            this.btnOperationLike.Name = "btnOperationLike";
            this.btnOperationLike.Size = new System.Drawing.Size(38, 22);
            this.btnOperationLike.TabIndex = 11;
            this.btnOperationLike.Text = "like";
            this.btnOperationLike.UseVisualStyleBackColor = true;
            this.btnOperationLike.Click += new System.EventHandler(this.btnOperationLike_Click);
            // 
            // btnOperationNotEquel
            // 
            this.btnOperationNotEquel.Location = new System.Drawing.Point(60, 111);
            this.btnOperationNotEquel.Name = "btnOperationNotEquel";
            this.btnOperationNotEquel.Size = new System.Drawing.Size(38, 22);
            this.btnOperationNotEquel.TabIndex = 12;
            this.btnOperationNotEquel.Text = "<>";
            this.btnOperationNotEquel.UseVisualStyleBackColor = true;
            this.btnOperationNotEquel.Click += new System.EventHandler(this.btnOperationNotEquel_Click);
            // 
            // btnListUniqueValues
            // 
            this.btnListUniqueValues.Location = new System.Drawing.Point(233, 205);
            this.btnListUniqueValues.Name = "btnListUniqueValues";
            this.btnListUniqueValues.Size = new System.Drawing.Size(103, 27);
            this.btnListUniqueValues.TabIndex = 13;
            this.btnListUniqueValues.Text = "列出所有值";
            this.btnListUniqueValues.UseVisualStyleBackColor = true;
            this.btnListUniqueValues.Click += new System.EventHandler(this.btnListUniqueValues_Click);
            // 
            // lstUniqueValues
            // 
            this.lstUniqueValues.FormattingEnabled = true;
            this.lstUniqueValues.ItemHeight = 12;
            this.lstUniqueValues.Location = new System.Drawing.Point(160, 111);
            this.lstUniqueValues.Name = "lstUniqueValues";
            this.lstUniqueValues.Size = new System.Drawing.Size(187, 88);
            this.lstUniqueValues.TabIndex = 14;
            this.lstUniqueValues.DoubleClick += new System.EventHandler(this.lstUniqueValues_DoubleClick);
            // 
            // txtFilterString
            // 
            this.txtFilterString.Location = new System.Drawing.Point(11, 238);
            this.txtFilterString.Multiline = true;
            this.txtFilterString.Name = "txtFilterString";
            this.txtFilterString.Size = new System.Drawing.Size(336, 118);
            this.txtFilterString.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveFilterExpression);
            this.groupBox1.Controls.Add(this.btnVerify);
            this.groupBox1.Controls.Add(this.btnLoadFilterExpression);
            this.groupBox1.Controls.Add(this.btnClearFilterString);
            this.groupBox1.Controls.Add(this.txtFilterString);
            this.groupBox1.Controls.Add(this.btnOperationNotEquel);
            this.groupBox1.Controls.Add(this.lstUniqueValues);
            this.groupBox1.Controls.Add(this.lstFields);
            this.groupBox1.Controls.Add(this.btnListUniqueValues);
            this.groupBox1.Controls.Add(this.btnOperationEquel);
            this.groupBox1.Controls.Add(this.btnOperationNot);
            this.groupBox1.Controls.Add(this.btnOperationLike);
            this.groupBox1.Controls.Add(this.btnOperationParenthesis);
            this.groupBox1.Controls.Add(this.btnOperationLarger);
            this.groupBox1.Controls.Add(this.btnOperationMatch);
            this.groupBox1.Controls.Add(this.btnOperationLargerEquel);
            this.groupBox1.Controls.Add(this.btnOperationOr);
            this.groupBox1.Controls.Add(this.btnOperationAnd);
            this.groupBox1.Controls.Add(this.btnOperationSmallerEquel);
            this.groupBox1.Controls.Add(this.btnOperationSmaller);
            this.groupBox1.Location = new System.Drawing.Point(2, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 395);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btnSaveFilterExpression
            // 
            this.btnSaveFilterExpression.Location = new System.Drawing.Point(278, 364);
            this.btnSaveFilterExpression.Name = "btnSaveFilterExpression";
            this.btnSaveFilterExpression.Size = new System.Drawing.Size(64, 22);
            this.btnSaveFilterExpression.TabIndex = 22;
            this.btnSaveFilterExpression.Text = "保存...";
            this.btnSaveFilterExpression.UseVisualStyleBackColor = true;
            this.btnSaveFilterExpression.Click += new System.EventHandler(this.btnSaveFilterExpression_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(104, 364);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(64, 22);
            this.btnVerify.TabIndex = 21;
            this.btnVerify.Text = "验证";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnLoadFilterExpression
            // 
            this.btnLoadFilterExpression.Location = new System.Drawing.Point(191, 364);
            this.btnLoadFilterExpression.Name = "btnLoadFilterExpression";
            this.btnLoadFilterExpression.Size = new System.Drawing.Size(64, 22);
            this.btnLoadFilterExpression.TabIndex = 20;
            this.btnLoadFilterExpression.Text = "加载...";
            this.btnLoadFilterExpression.UseVisualStyleBackColor = true;
            this.btnLoadFilterExpression.Click += new System.EventHandler(this.btnLoadFilterExpression_Click);
            // 
            // btnClearFilterString
            // 
            this.btnClearFilterString.Location = new System.Drawing.Point(17, 364);
            this.btnClearFilterString.Name = "btnClearFilterString";
            this.btnClearFilterString.Size = new System.Drawing.Size(64, 22);
            this.btnClearFilterString.TabIndex = 19;
            this.btnClearFilterString.Text = "清除";
            this.btnClearFilterString.UseVisualStyleBackColor = true;
            this.btnClearFilterString.Click += new System.EventHandler(this.btnClearFilterString_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(275, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 32);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "取  消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(181, 401);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 32);
            this.btnOK.TabIndex = 24;
            this.btnOK.Text = "确  定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmAdvanceFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 439);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAdvanceFilter";
            this.Text = "设置过滤条件";
            this.Load += new System.EventHandler(this.frmAdvanceFilter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFields;
        private System.Windows.Forms.Button btnOperationEquel;
        private System.Windows.Forms.Button btnOperationNot;
        private System.Windows.Forms.Button btnOperationParenthesis;
        private System.Windows.Forms.Button btnOperationMatch;
        private System.Windows.Forms.Button btnOperationOr;
        private System.Windows.Forms.Button btnOperationSmallerEquel;
        private System.Windows.Forms.Button btnOperationSmaller;
        private System.Windows.Forms.Button btnOperationAnd;
        private System.Windows.Forms.Button btnOperationLargerEquel;
        private System.Windows.Forms.Button btnOperationLarger;
        private System.Windows.Forms.Button btnOperationLike;
        private System.Windows.Forms.Button btnOperationNotEquel;
        private System.Windows.Forms.Button btnListUniqueValues;
        private System.Windows.Forms.ListBox lstUniqueValues;
        private System.Windows.Forms.TextBox txtFilterString;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearFilterString;
        private System.Windows.Forms.Button btnSaveFilterExpression;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnLoadFilterExpression;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}
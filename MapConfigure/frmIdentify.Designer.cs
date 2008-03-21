namespace MapConfigure
{
    partial class frmIdentify
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
            this.pnlLayerInfos = new System.Windows.Forms.Panel();
            this.labLayerInfos = new System.Windows.Forms.Label();
            this.lsvFeatureProperties = new System.Windows.Forms.ListView();
            this.colFieldName = new System.Windows.Forms.ColumnHeader();
            this.colPropertyValue = new System.Windows.Forms.ColumnHeader();
            this.pnlLayerInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // 
            // pnlLayerInfos
            // 
            this.pnlLayerInfos.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLayerInfos.Controls.Add(this.labLayerInfos);
            this.pnlLayerInfos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLayerInfos.Location = new System.Drawing.Point(0, 184);
            this.pnlLayerInfos.Name = "pnlLayerInfos";
            this.pnlLayerInfos.Size = new System.Drawing.Size(253, 31);
            this.pnlLayerInfos.TabIndex = 0;
            // 
            // labLayerInfos
            // 
            this.labLayerInfos.AutoSize = true;
            this.labLayerInfos.Location = new System.Drawing.Point(12, 10);
            this.labLayerInfos.Name = "labLayerInfos";
            this.labLayerInfos.Size = new System.Drawing.Size(0, 12);
            this.labLayerInfos.TabIndex = 0;
            // 
            // lsvFeatureProperties
            // 
            this.lsvFeatureProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFieldName,
            this.colPropertyValue});
            this.lsvFeatureProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvFeatureProperties.GridLines = true;
            this.lsvFeatureProperties.Location = new System.Drawing.Point(0, 0);
            this.lsvFeatureProperties.Name = "lsvFeatureProperties";
            this.lsvFeatureProperties.Size = new System.Drawing.Size(253, 184);
            this.lsvFeatureProperties.TabIndex = 1;
            this.lsvFeatureProperties.UseCompatibleStateImageBehavior = false;
            this.lsvFeatureProperties.View = System.Windows.Forms.View.Details;
            // 
            // colFieldName
            // 
            this.colFieldName.Text = "字段名称";
            this.colFieldName.Width = 107;
            // 
            // colPropertyValue
            // 
            this.colPropertyValue.Text = "属性值";
            this.colPropertyValue.Width = 140;
            // 
            // frmIdentify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(253, 215);
            this.Controls.Add(this.lsvFeatureProperties);
            this.Controls.Add(this.pnlLayerInfos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIdentify";
            this.Text = "要素属性";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIdentify_FormClosing);
            this.pnlLayerInfos.ResumeLayout(false);
            this.pnlLayerInfos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLayerInfos;
        private System.Windows.Forms.Label labLayerInfos;
        private System.Windows.Forms.ListView lsvFeatureProperties;
        private System.Windows.Forms.ColumnHeader colFieldName;
        private System.Windows.Forms.ColumnHeader colPropertyValue;

    }
}
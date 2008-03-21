namespace MapConfigure
{
    partial class frmAttributesData
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
            this.dgvViewAttributes = new System.Windows.Forms.DataGridView();
            this.lblLayerDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAttributes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewAttributes
            // 
            this.dgvViewAttributes.AllowUserToAddRows = false;
            this.dgvViewAttributes.AllowUserToResizeColumns = false;
            this.dgvViewAttributes.AllowUserToResizeRows = false;
            this.dgvViewAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewAttributes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewAttributes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvViewAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAttributes.Location = new System.Drawing.Point(2, 34);
            this.dgvViewAttributes.Name = "dgvViewAttributes";
            this.dgvViewAttributes.RowTemplate.Height = 23;
            this.dgvViewAttributes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewAttributes.Size = new System.Drawing.Size(544, 422);
            this.dgvViewAttributes.TabIndex = 6;
            // 
            // lblLayerDescription
            // 
            this.lblLayerDescription.AutoSize = true;
            this.lblLayerDescription.Location = new System.Drawing.Point(23, 9);
            this.lblLayerDescription.Name = "lblLayerDescription";
            this.lblLayerDescription.Size = new System.Drawing.Size(41, 12);
            this.lblLayerDescription.TabIndex = 7;
            this.lblLayerDescription.Text = "label1";
            // 
            // frmAttributesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 468);
            this.Controls.Add(this.lblLayerDescription);
            this.Controls.Add(this.dgvViewAttributes);
            this.Name = "frmAttributesData";
            this.Text = "frmAttributesData";
            this.Shown += new System.EventHandler(this.frmAttributesData_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAttributes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewAttributes;
        private System.Windows.Forms.Label lblLayerDescription;


    }
}
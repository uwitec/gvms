namespace GPSTrackingMonitor.CustomControl
{
    partial class SymbolSelector
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picSymbols = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSymbols)).BeginInit();
            this.SuspendLayout();
            // 
            // picSymbols
            // 
            this.picSymbols.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picSymbols.Location = new System.Drawing.Point(256, 100);
            this.picSymbols.Name = "picSymbols";
            this.picSymbols.Size = new System.Drawing.Size(100, 133);
            this.picSymbols.TabIndex = 0;
            this.picSymbols.TabStop = false;
            // 
            // SymbolSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picSymbols);
            this.Name = "SymbolSelector";
            this.Size = new System.Drawing.Size(410, 306);
            ((System.ComponentModel.ISupportInitialize)(this.picSymbols)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSymbols;
    }
}

namespace MapConfigure
{
    partial class frmTruetypeSymbolSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.symbolSelectorControl1 = new SymbolSelector.SymbolSelectorControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(521, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 148);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // symbolSelectorControl1
            // 
            this.symbolSelectorControl1.Location = new System.Drawing.Point(25, 52);
            this.symbolSelectorControl1.Name = "symbolSelectorControl1";
            this.symbolSelectorControl1.Size = new System.Drawing.Size(477, 452);
            this.symbolSelectorControl1.TabIndex = 3;
            this.symbolSelectorControl1.SymbolSelected += new SymbolSelector.SymbolSelectorControl.SymbolSelectedEventHandler(this.symbolSelectorControl1_SymbolSelected);
            // 
            // frmTruetypeSymbolSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 516);
            this.Controls.Add(this.symbolSelectorControl1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmTruetypeSymbolSelection";
            this.Text = "frmTruetypeSymbolSelection";
            this.ResumeLayout(false);

        }

        #endregion        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private SymbolSelector.SymbolSelectorControl symbolSelectorControl1;
        
    }
}
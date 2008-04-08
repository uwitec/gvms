/***********************************************
* 
* 
* 
* 
* 
* 
* Use:
*      1、对当前系统中的可变参数进行配置
*      2、这些可变参数包括:信息
* 
* *********************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSTrackingMonitor
{
    public partial class frmConfigure : Form
    {
        #region fields

        private Font _currentFont = null;
        private int _selectedSymbolIndex = 0;

        #endregion

        #region constructor

        public frmConfigure()
        {
            InitializeComponent();
        }

        #endregion

        #region event

        #region event - this form

        private void frmConfigure_Load(object sender, EventArgs e)
        {
            this.InitSystemConfigureTab();
            this.InitCarConfigureTab();
            this.InitCommunicationConfigureTab();
            this.InitTrackingReplayConfigureTab();
        }

        #endregion

        #region event - 系统配置

        private void btnProjectFileBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();

            oOpenFileDialog.Filter = "工程文件 (*.gvp) | *.gvp";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtProjectFilePath.Text = oOpenFileDialog.FileName;
            }
        }

        #endregion

        #region event - 车辆符号设置

        protected void symbolSelector_SymboSelectedEvent(object sender, GPSTrackingMonitor.CustomControl.SymbolSelectedEventArgs e)
        {
            this._currentFont = e.CurrentFont;
            this._selectedSymbolIndex = e.SymbolIndex;

            txtSymbolIndex.Text = e.SymbolIndex.ToString();
            pnlSymbolColor.BackColor = Color.Red;
            numSymbolSize.Value = (decimal)e.CurrentFont.Size;
            numSymbolRotation.Value = 0;

            Utilities.GDIPlus.DrawSymbolOnControl(this.picPreviewSymbol, e.CurrentFont, e.SymbolIndex, e.CurrentFont.Size, 0, this.pnlSymbolColor.BackColor);
        }

        private void cbbFontNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily oFontFamily = new FontFamily(cbbFontNames.Text);
            Font oFont = new Font(oFontFamily, 40, FontStyle.Regular, GraphicsUnit.Pixel);

            symSelector.ListCharactors(oFont);
        }

        private void numSymbolSize_ValueChanged(object sender, EventArgs e)
        {
            Utilities.GDIPlus.DrawSymbolOnControl(this.picPreviewSymbol, this._currentFont,
                this._selectedSymbolIndex, (float)this.numSymbolSize.Value, (float)this.numSymbolRotation.Value, this.pnlSymbolColor.BackColor);
        }

        private void numSymbolRotation_ValueChanged(object sender, EventArgs e)
        {
            Utilities.GDIPlus.DrawSymbolOnControl(this.picPreviewSymbol, this._currentFont,
                this._selectedSymbolIndex, (float)this.numSymbolSize.Value, (float)this.numSymbolRotation.Value, this.pnlSymbolColor.BackColor);
        }

        private void pnlSymbolColor_Click(object sender, EventArgs e)
        {
            ColorDialog oColorDialog = new ColorDialog();

            oColorDialog.Color = this.pnlSymbolColor.BackColor;
            if (oColorDialog.ShowDialog() == DialogResult.OK)
            {
                this.pnlSymbolColor.BackColor = oColorDialog.Color;

                Utilities.GDIPlus.DrawSymbolOnControl(this.picPreviewSymbol, this._currentFont,
               this._selectedSymbolIndex, (float)this.numSymbolSize.Value, (float)this.numSymbolRotation.Value, this.pnlSymbolColor.BackColor);
            }
        }
        #endregion

        #region event - 通信配置



        #endregion

        #endregion

        #region methods

        private void InitSystemConfigureTab()
        {

        }

        private void InitCarConfigureTab()
        {
            using (IEnumerator<string> oFontNames = symSelector.GetAllFontNames().GetEnumerator())
            {
                string sCurValue = string.Empty;
                while (oFontNames.MoveNext())
                {
                    sCurValue = oFontNames.Current;

                    if (!sCurValue.Contains("ESRI")) continue;

                    this.cbbFontNames.Items.Add(sCurValue);
                }

                if (this.cbbFontNames.Items.Count > 0)
                    this.cbbFontNames.SelectedIndex = 0;
            }

            this.symSelector.SymboSelectedEvent += new GPSTrackingMonitor.CustomControl.SymbolSelector.SymbolSelectedEventHandler(symbolSelector_SymboSelectedEvent);
        }

        private void InitCommunicationConfigureTab()
        {
            string[] sDatabaseTypes = new string[] { "Access", "PostgreSQL", "Oracle", "SQL Server" };
            this.cbbDatabaseTypes.DataSource = sDatabaseTypes;
        }

        private void InitTrackingReplayConfigureTab()
        {

        }

        #endregion
    }
}
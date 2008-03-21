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
        public frmConfigure()
        {
            InitializeComponent();
        }

        private void frmConfigure_Load(object sender, EventArgs e)
        {
            using (IEnumerator<string> oFontNames = symbolSelector.GetAllFontNames().GetEnumerator())
            {
                string sCurValue = string.Empty;
                while (oFontNames.MoveNext())
                {
                    sCurValue = oFontNames.Current;
                    this.cbbFontNames.Items.Add(sCurValue);
                }

                if (this.cbbFontNames.Items.Count > 0)
                    this.cbbFontNames.SelectedIndex = 0;
            }

            this.symbolSelector.SymboSelectedEvent += new GPSTrackingMonitor.CustomControl.SymbolSelector.SymbolSelectedEventHandler(symbolSelector_SymboSelectedEvent);
        }

        void symbolSelector_SymboSelectedEvent(object sender, GPSTrackingMonitor.CustomControl.SymbolSelectedEventArgs e)
        {
            Graphics g = this.picPreviewSymbol.CreateGraphics();
            g.Clear(this.picPreviewSymbol.BackColor);

            g.ScaleTransform(4, 4);
            g.TranslateTransform(5, 5);
            g.FillPath(new SolidBrush(Color.DarkRed), e.SymbolOutline);

            txtSymbolIndex.Text = e.SymbolIndex.ToString();
        }

        private void cbbFontNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily oFontFamily = new FontFamily(cbbFontNames.Text);
            Font oFont = new Font(oFontFamily, 40, FontStyle.Regular, GraphicsUnit.Pixel);

            symbolSelector.ListCharactors(oFont);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace GPSTrackingMonitor.CustomControl
{
    public partial class SymbolSelector : UserControl
    {
        #region fields

        private Graphics _graphics;
        private Font _curFont;
        private int _fontSize;
        private int _selectedSymbolIndex;

        #endregion

        #region constructors

        public SymbolSelector()
        {
            InitializeComponent();

            this.AutoScroll = true;
            this.picSymbols.Location = new Point(0, 0);
            this.picSymbols.SizeMode = PictureBoxSizeMode.AutoSize;
            this.picSymbols.MouseClick += new MouseEventHandler(picSymbols_MouseClick);
        }

        #endregion

        #region events

        void picSymbols_MouseClick(object sender, MouseEventArgs e)
        {
            this.DrawSelectionRetangle(e.Location);
            this._selectedSymbolIndex = (e.X / this._fontSize) + (e.Y / this._fontSize) * 16;
            this.OnSymbolSelected(sender, new SymbolSelectedEventArgs(this.GetSymbolOutlineByIndex(this._selectedSymbolIndex), this._selectedSymbolIndex,this._curFont));
        }

        public delegate void SymbolSelectedEventHandler(object sender, SymbolSelectedEventArgs e);
        public event SymbolSelectedEventHandler SymboSelectedEvent;
        protected virtual void OnSymbolSelected(object sender, SymbolSelectedEventArgs e)
        {
            if (this.SymboSelectedEvent != null && e != null)
                this.SymboSelectedEvent(sender, e);
        }

        #endregion

        #region private methods

        private void DrawSelectionRetangle(Point mouseLocation)
        {
            this.picSymbols.Refresh();
            Graphics g = this.picSymbols.CreateGraphics();
            Rectangle oRect = new Rectangle();
            oRect.X = (mouseLocation.X / this._fontSize) * this._fontSize;
            oRect.Y = (mouseLocation.Y / this._fontSize) * this._fontSize;
            oRect.Width = oRect.Height = this._fontSize;
            g.FillRectangle(new SolidBrush(Color.FromArgb(50,255,0,0)) ,oRect);
        }

        private void DrawGridLines(ref Graphics g)
        {
            for (int i = 0; i < 17; i++)
            {
                g.DrawLine(new Pen(Color.Blue, 1), new Point(0, i * this._fontSize), new Point(16 * this._fontSize, i * this._fontSize));
            }

            for (int i = 0; i < 17; i++)
            {
                g.DrawLine(new Pen(Color.Blue, 1), new Point(i * this._fontSize, 0), new Point(i * this._fontSize, 16 * this._fontSize));
            }
        }

        private void DrawCharactorsOutLines(ref Graphics g)
        {
            System.Drawing.Drawing2D.GraphicsPath oOutline = new System.Drawing.Drawing2D.GraphicsPath();
            int iSymbolIndex = 0;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    string sCharactor = new string(Convert.ToChar(iSymbolIndex++), 1);
                    oOutline = new System.Drawing.Drawing2D.GraphicsPath();
                    oOutline.AddString(sCharactor, this._curFont.FontFamily, (int)FontStyle.Regular, this._fontSize - 7, new Point(j * this._fontSize, i * this._fontSize), StringFormat.GenericDefault);
                    g.FillPath(new SolidBrush(Color.Black), oOutline);
                    oOutline.Dispose();
                    //g.DrawString(sCharactor, this._curFont, new SolidBrush(Color.Black), new RectangleF(j * this._fontSize , i * this._fontSize, this._fontSize, this._fontSize), StringFormat.GenericTypographic);
                }
            }
        }

        private System.Drawing.Drawing2D.GraphicsPath GetSymbolOutlineByIndex(int symbolIndex)
        {
            System.Drawing.Drawing2D.GraphicsPath oOutline = new System.Drawing.Drawing2D.GraphicsPath();
            string sCharactor = new string(Convert.ToChar(symbolIndex), 1);
            oOutline.AddString(sCharactor, this._curFont.FontFamily, (int)FontStyle.Regular, this._fontSize, new Point(0, 0), StringFormat.GenericDefault);

            return oOutline;
        }

        #endregion

        #region pubic methods

        /// <summary>
        /// get all fonts' name
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetAllFontNames()
        {
            InstalledFontCollection oFontCollection = new InstalledFontCollection();

            foreach (FontFamily oFamily in oFontCollection.Families)
            {
                yield return oFamily.Name;
            }
        }     
        
        /// <summary>
        /// draw charactors in canvas
        /// </summary>
        /// <param name="symbolFont"></param>
        public void ListCharactors(Font symbolFont)
        {
            this._fontSize = (int)symbolFont.Size;
            this._curFont = new Font(symbolFont.FontFamily, symbolFont.Size, FontStyle.Regular, GraphicsUnit.Pixel);
            this.picSymbols.Image = new Bitmap(16 * this._fontSize, 16 * this._fontSize);
            this._graphics = Graphics.FromImage(this.picSymbols.Image);
            this._graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            this._graphics.Clear(Color.White);

            this.DrawGridLines(ref this._graphics);
            this.DrawCharactorsOutLines(ref this._graphics);

            this._graphics.Dispose();
        }

        #endregion
    }

    
    public class SymbolSelectedEventArgs
    {
        #region fields

        private System.Drawing.Drawing2D.GraphicsPath _symbolOutline;
        private int _symbolIndex;
        private Font _currentFont;

        #endregion

        #region constructors

        public SymbolSelectedEventArgs()
        {
        }

        public SymbolSelectedEventArgs(System.Drawing.Drawing2D.GraphicsPath symbolOutline,int symbolIndex,Font currentFont)
        {
            this._symbolIndex = symbolIndex;
            this._symbolOutline = symbolOutline;
            this._currentFont = currentFont;
        }

        #endregion

        #region properties

        public System.Drawing.Drawing2D.GraphicsPath SymbolOutline
        {
            get { return this._symbolOutline; }
            internal set { this._symbolOutline = value; }
        }

        public int SymbolIndex
        {
            get { return this._symbolIndex; }
            internal set { this._symbolIndex = value; }
        }

        public Font CurrentFont
        {
            get { return this._currentFont; }
            set { this._currentFont = value; }
        }

        #endregion
    }
}

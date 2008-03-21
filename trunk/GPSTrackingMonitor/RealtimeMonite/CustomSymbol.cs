using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace GPSTrackingMonitor.RealtimeMonite
{
    public class CustomSymbol : ESRI.MapObjects2.Custom.ICustomMarker
    {
        private Graphics _graphics;
        private Image _canvas;
        private Font _symbolFont;
        private string _extendedInfos;
        private int _symbolIndex;
        private double _extendedInfosFontSize;


        private Color _extentedInfosColor = Color.Yellow;
        private Color _symbolColor = Color.Black;
        private double _rotation = 0;
        private Font _extendedInfosFont;

        public CustomSymbol(string symbolFontName, string labelFontName, double symbolSize, double labelSize, int symbolIndex, string labelValue)
        {
            this._symbolFont = new Font(symbolFontName, (float)symbolSize);
            this._extendedInfos = labelValue;
            this._symbolIndex = symbolIndex;
            this._extendedInfosFontSize = labelSize;
            this._extendedInfosFont = new Font(labelFontName, (float)labelSize);
        }

        public Color ExtendedInfosColor
        {
            get { return this._extentedInfosColor; }
            set { this._extentedInfosColor = value; }
        }

        public Color SymbolColor
        {
            get { return this._symbolColor; }
            set { this._symbolColor = value; }
        }

        public double Rotation
        {
            get { return this._rotation; }
            set { this._rotation = value; }
        }

        public Font ExtendedInfosFont
        {
            get
            {
                return this._extendedInfosFont;
            }
            set
            {
                if (value != null && this._extendedInfosFont != null)
                    this._extendedInfosFont = new Font((value as Font).Name, (float)this._extendedInfosFontSize);
            }
        }

        #region ICustomMarker ≥…‘±


        public void Draw(int hDC, int x, int y)
        {
            this._graphics = Graphics.FromHdc((IntPtr)hDC);
            System.Drawing.Drawing2D.GraphicsPath oSysmbolOutPath = new System.Drawing.Drawing2D.GraphicsPath();

            if (this._graphics != null && this._symbolFont != null)
            {
                this._graphics.TranslateTransform(1f, 1f);
                this._graphics.DrawString(new string(((char)this._symbolIndex), 1), this._symbolFont, new SolidBrush(this._symbolColor), (float)x, (float)y);
                this._graphics.DrawString(this._extendedInfos, new Font(this._extendedInfosFont.Name, (float)this._extendedInfosFontSize), new SolidBrush(this._extentedInfosColor), (float)x, (float)y);

               
                this._graphics.RotateTransform((float)this._rotation);
            }
            this._graphics.Dispose();
        }

        public void ResetDC(int hDC)
        {

        }

        public void SetupDC(int hDC, double dpi, object pBaseSym)
        {

            Console.Write(pBaseSym.ToString());
        }

        #endregion
    }
}

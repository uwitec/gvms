using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GPSTrackingMonitor.Utilities
{
    class GDIPlus
    {
        public static void DrawSymbolOnControl(System.Windows.Forms.Control canvalControl, 
            Font symbolFont,int symbolIndex, float symbolSize, float symbolRotation,Color symbolColor)
        {
            GraphicsPath oPath = new GraphicsPath();
            string sSymbol = new String((char)symbolIndex,1);

            symbolSize = symbolSize < 1 ? 1 : symbolSize;

            oPath.AddString(sSymbol, symbolFont.FontFamily, (int)FontStyle.Regular, symbolSize, new PointF(0f, 0f), StringFormat.GenericDefault);

            Image oImage = new Bitmap(canvalControl.Width, canvalControl.Height);
            Graphics g = Graphics.FromImage(oImage);

            g.SmoothingMode = SmoothingMode.HighQuality;
            g.RotateTransform(symbolRotation);
            g.FillPath(new SolidBrush(symbolColor), oPath);

            canvalControl.BackgroundImage = oImage;
            canvalControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }
    }
}

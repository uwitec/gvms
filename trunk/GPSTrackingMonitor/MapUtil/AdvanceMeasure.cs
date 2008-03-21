using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GPSTrackingMonitor.MapUtil
{
    class AdvanceMeasure
    {
        #region fields

        private Graphics _graphics;
        private GraphicsPath _measureLine;
        private Point _prePoint;
        private Point _curPoint;
        private bool _startDraw = false;
        private System.Windows.Forms.Control _mapControl;

        #endregion

        #region public methods

        public void MearseMouseDown(System.Drawing.Point mousePosition, System.Windows.Forms.Control mapControl)
        {
            if (this._graphics == null)
            {
                this._mapControl = mapControl;
                this._graphics = mapControl.CreateGraphics();
                this._measureLine = new GraphicsPath();
            }

            this._graphics.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(mousePosition.X - 3, mousePosition.Y - 3, 6, 6));

            if (this._measureLine.PointCount == 0 && this._startDraw == false)
            {
                this._curPoint = this._prePoint = mousePosition;
                this._startDraw = true;
            }
            else
            {
                this._prePoint = this._curPoint;
                this._curPoint = mousePosition;
                this._measureLine.AddLine(this._prePoint, this._curPoint);
                this._graphics.DrawPath(new System.Drawing.Pen(Color.Blue, 4), this._measureLine);
            }
        }

        public void MeasureMouseMove(System.Drawing.Point mousePosition)
        {   
            if (this._measureLine.PointCount > 0)
            {
                PointF oPointF = this._measureLine.GetLastPoint();
                Point oPoint = new Point((int)oPointF.X, (int)oPointF.Y);
                this.drawLine(this._graphics, oPoint, mousePosition, this._mapControl);
            }
        }

        public void MeasureMouseUp(System.Drawing.Point mousePosition)
        {

        }

        #endregion

        #region private methods

        private void drawLine(Graphics graphics, Point startPoint, Point endPoint,System.Windows.Forms.Control mapControl)
        {
            BufferedGraphicsContext context = BufferedGraphicsManager.Current;
            BufferedGraphics bg = context.Allocate(graphics, mapControl.ClientRectangle);
            bg.Graphics.Clear(mapControl.BackColor);
            bg.Graphics.DrawPath(new System.Drawing.Pen(Color.Blue, 4), this._measureLine);
            bg.Graphics.DrawLine(new System.Drawing.Pen(Color.Blue,4), startPoint, endPoint);
            bg.Render();
            bg.Dispose();
            bg = null;
        }

        #endregion

    }
}

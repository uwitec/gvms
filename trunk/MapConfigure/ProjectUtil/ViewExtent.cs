using System;
using System.Collections.Generic;
using System.Text;

namespace MapConfigure.ProjectUtil
{
    [Serializable]
    public class ViewExtent
    {
        #region fields

        private double _minX = 0;
        private double _minY = 0;
        private double _maxX = 0;
        private double _maxY = 0;
        private double _width = 0;
        private double _height = 0;

        #endregion

        #region properties

        public double MinX
        {
            get { return this._minX; }
            set { this._minX = value; }
        }

        public double MinY
        {
            get { return this._minY; }
            set { this._minY = value; }
        }

        public double MaxX
        {
            get { return this._maxX; }
            set { this._maxX = value; }
        }

        public double MaxY
        {
            get { return this._maxY; }
            set { this._maxY = value; }
        }

        public double Width
        {
            get { return this._width; }
            set { this._width = value; }
        }

        public double Height
        {
            get { return this._height; }
            set { this._height = value; }
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace GPSTrackingMonitor.Configures
{
    [Serializable]
    class CarSymbolConfigureStrcut
    {
        #region fields

        private string _carSymbolFontName = "ESRI Transportation & Civic";
        private int _carSymbolIndex = 106;
        private double _carSymbolSize = 35;
        private double _carSymbolRotation = 0;
        private Color _carSymbolColor = Color.Red;
        private Font _carLabelFont = new Font("Arial",9f, FontStyle.Regular);
        private Color _carLabelColor = Color.Yellow;

        #endregion

        #region properties

        /// <summary>
        /// 
        /// </summary>
        public string CarSymbolFontName
        {
            get { return this._carSymbolFontName; }
            set { this._carSymbolFontName = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int CarSymbolIndex
        {
            get { return this._carSymbolIndex; }
            set { this._carSymbolIndex = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double CarSymbolSize
        {
            get { return this._carSymbolSize; }
            set { this._carSymbolSize = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double CarSymbolRotation
        {
            get { return this._carSymbolRotation; }
            set { this._carSymbolRotation = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Color CarSymbolColor
        {
            get { return this._carSymbolColor; }
            set { this._carSymbolColor = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Font CarLabelFont
        {
            get { return this._carLabelFont; }
            set { this._carLabelFont = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Color CarLabelColor
        {
            get { return this._carLabelColor; }
            set { this._carLabelColor = value; }
        }

        #endregion

    }
}

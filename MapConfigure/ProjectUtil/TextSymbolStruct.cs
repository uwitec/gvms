using System;
using System.Collections.Generic;
using System.Text;

namespace MapConfigure.ProjectUtil
{
    class TextSymbolStruct
    {
        private System.Drawing.Color _textColor = System.Drawing.Color.Black;
        private bool _fitted = false;
        private stdole.StdFont _textFont = new stdole.StdFontClass();
        private double _height = 0;
        private short _horizontalAlignment = 0;
        private short _verticalAlignment = 0;
        private double _rotation = 0;

        public System.Drawing.Color TextColor
        {
            get { return this._textColor; }
            set { this._textColor = value; }
        }

        public bool Fitted
        {
            get { return this._fitted; }
            set { this._fitted = value; }
        }

        public stdole.StdFont TextFont
        {
            get { return this._textFont; }
            set { this._textFont = value; }
        }

        public double Height
        {
            get { return this._height; }
            set { this._height = value; }
        }

        public short HorizontalAlignment
        {
            get { return this._horizontalAlignment; }
            set { this._horizontalAlignment = value; }
        }

        public short VerticalAlignment
        {
            get { return this._verticalAlignment; }
            set { this._verticalAlignment = value; }
        }

        public double Rotation
        {
            get { return this._rotation; }
            set { this._rotation = value; }
        }
    }
}

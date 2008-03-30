using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MapConfigure.ProjectUtil
{
    [Serializable]
    public class SymbolStruct
    {
        #region fields

        private bool _centerOnAscent = false;
        private short _characterIndex = 0;
        private Color _fillColor = Color.Black;
        private object _curstomSymbol = null;
        private string _fontName = string.Empty;
        private bool _outLine = false;
        private Color _outLineColor = Color.Transparent;
        private double _rotation = 0;
        private short _size = 0;
        private short _style = 0;
        private short _symbolType = 0;

        #endregion

        #region properties

        public bool CenterOnAscent
        {
            get { return this._centerOnAscent; }
            set { this._centerOnAscent = value; }
        }

        public short CharacterIndex
        {
            get { return this._characterIndex; }
            set { this._characterIndex = value; }
        }

        public Color FillColor
        {
            get { return this._fillColor; }
            set { this._fillColor = value; }
        }

        public object CustomSymbol
        {
            get { return this._curstomSymbol; }
            set { this._curstomSymbol = value; }
        }

        public string FontName
        {
            get { return this._fontName; }
            set { this._fontName = value; }
        }

        public bool OutLine
        {
            get { return this._outLine; }
            set { this._outLine = value; }
        }

        public Color OutLineColor
        {
            get { return this._outLineColor; }
            set { this._outLineColor = value; }
        }

        public double Rotation
        {
            get { return this._rotation; }
            set { this._rotation = value; }
        }

        public short Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        public short Style
        {
            get { return this._style; }
            set { this._style = value; }
        }

        public short SymbolType
        {
            get { return this._symbolType; }
            set { this._symbolType = value; }
        }

        #endregion
    }
}

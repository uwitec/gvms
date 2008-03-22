using System;
using System.Collections.Generic;
using System.Text;

namespace MapConfigure.ProjectUtil
{
    [Serializable]
    internal class LabelRenderStruct : IRenderStruct
    {
        #region fields

        private bool _allowDuplicates = false;
        private bool _drawBackground = false;
        private string _field = string.Empty;
        private string _fittedField = string.Empty;
        private bool _flip = false;
        private string _heightField = string.Empty;
        private string _levelField = string.Empty;
        private short _maxLevel = 0;
        private short _minLevel = 0;
        private string _rotationField = string.Empty;
        private bool _splineText = false;
        private short _symbolCount = 0;
        private string _symbolField = string.Empty;
        private string _tag = string.Empty;
        private string _xOffsetField = string.Empty;
        private string _yOffsetField = string.Empty;
        private List<TextSymbolStruct> _symbolList = new List<TextSymbolStruct>();

        #endregion

        #region properties

        public bool AllowDuplicates
        {
            get { return this._allowDuplicates; }
            set { this._allowDuplicates = value; }
        }

        public bool DrawBackground
        {
            get { return this._drawBackground; }
            set { this._drawBackground = value; }
        }

        public string Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        public string FittedField
        {
            get { return this._fittedField; }
            set { this._fittedField = value; }
        }

        public bool Flip
        {
            get { return this._flip; }
            set { this._flip = value; }
        }

        public string HeightField
        {
            get { return this._heightField; }
            set { this._heightField = value; }
        }

        public string LevelField
        {
            get { return this._levelField; }
            set { this._levelField = value; }
        }

        public short MaxLevel
        {
            get { return this._maxLevel; }
            set { this._maxLevel = value; }
        }

        public short MinLevel
        {
            get { return this._minLevel; }
            set { this._minLevel = value; }
        }

        public string RotationField
        {
            get { return this._rotationField; }
            set { this._rotationField = value; }
        }

        public bool SplinedText
        {
            get { return this._splineText; }
            set { this._splineText = value; }
        }

        public short SymbolCount
        {
            get { return this._symbolCount; }
            set { this._symbolCount = value; }
        }

        public string SymbolField
        {
            get { return this._symbolField; }
            set { this._symbolField = value; }
        }

        public string Tag
        {
            get { return this._tag; }
            set { this._tag = value; }
        }

        public string XOffsetField
        {
            get { return this._xOffsetField; }
            set { this._xOffsetField = value; }
        }

        public string YOffsetField
        {
            get { return this._yOffsetField; }
            set { this._yOffsetField = value; }
        }

        public List<TextSymbolStruct> SymbolList
        {
            get { return this._symbolList; }
            set { this._symbolList = value; }
        }

        #endregion

        #region IRenderStruct ≥…‘±

        public RenderType LayerRenderType
        {
            get { return RenderType.LabelRender; }
        }

        #endregion
    }
}

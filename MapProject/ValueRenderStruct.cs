using System;
using System.Collections.Generic;
using System.Text;

namespace MapProject
{
    [Serializable]
    public class ValueRenderStruct : IRenderStruct
    {
        #region fields

        private SymbolStruct _defaultSymbol = new SymbolStruct();
        private string _field = string.Empty;
        private string _rotationField = string.Empty;
        private string _scaleField = string.Empty;
        private short _symbolType = 0;
        private string _tag = string.Empty;
        private bool _useDefault = false;
        private short _valueCount = 0;
        private List<SymbolStruct> _symbolList = new List<SymbolStruct>();
        private List<string> _valueList = new List<string>();

        #endregion

        #region properties

        public SymbolStruct DefaultSymbol
        {
            get { return this._defaultSymbol; }
            set { this._defaultSymbol = value; }
        }

        public string Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        public string RotationField
        {
            get { return this._rotationField; }
            set { this._rotationField = value; }
        }

        public string ScaleField
        {
            get { return this._scaleField; }
            set { this._scaleField = value; }
        }

        public short SymbolType
        {
            get { return this._symbolType; }
            set { this._symbolType = value; }
        }

        public string Tag
        {
            get { return this._tag; }
            set { this._tag = value; }
        }

        public bool UseDefault
        {
            get { return this._useDefault; }
            set { this._useDefault = value; }
        }

        public short ValueCount
        {
            get { return this._valueCount; }
            set { this._valueCount = value; }
        }

        public List<SymbolStruct> SymbolList
        {
            get { return this._symbolList; }
            set { this._symbolList = value; }
        }

        public List<string> ValueList
        {
            get { return this._valueList; }
            set { this._valueList = value; }
        }

        #endregion


        #region IRenderStruct ≥…‘±

        public RenderType LayerRenderType
        {
            get { return RenderType.ValueRender; }
        }

        #endregion
    }
}

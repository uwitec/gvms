using System;
using System.Collections.Generic;
using System.Text;

namespace MapProject
{
    [Serializable]
    public class MapLayerInfoStruct : ILayerStruct
    {
        #region fields

        private string _datasetName = string.Empty;
        private string _aliasName = string.Empty;
        private string _fileName = string.Empty;
        private short _shapeType = 0;
        private double _minLevel = 0;
        private double _maxLevel = 0;
        private SymbolStruct _symbol = new SymbolStruct();
        private short _layerType = 0;
        private IRenderStruct _render = null;
        private bool _visible = true;

        #endregion

        #region properties
    
        public SymbolStruct Symbol
        {
            get { return this._symbol; }
            set { this._symbol = value; }
        }

        public IRenderStruct Render
        {
            get { return this._render; }
            set { this._render = value; }
        }

        #endregion

        #region ILayerStruct ≥…‘±


        public short LayerType
        {
            get{return this._layerType;}
            set { this._layerType = value; }
        }

        public string DataSetName
        {
            get { return this._datasetName; }
            set { this._datasetName = value; }
        }

        public string AliasName
        {
            get { return this._aliasName; }
            set { this._aliasName = value; }
        }

        public short ShapeType
        {
            get { return this._shapeType; }
            set { this._shapeType = value; }
        }

        public double MinLevel
        {
            get { return this._minLevel; }
            set { this._minLevel = value; }
        }

        public double MaxLevel
        {
            get { return this._maxLevel; }
            set { this._maxLevel = value; }
        }

        public string FileName
        {
            get { return this._fileName; }
            set { this._fileName = value; }
        }

        public bool Visible
        {
            get { return this._visible; }
            set { this._visible = value; }
        }

        #endregion
    }
}

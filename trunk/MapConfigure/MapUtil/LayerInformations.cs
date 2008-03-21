using System;
using System.Collections.Generic;
using System.Text;
using MapObjects2;

namespace MapConfigure.MapUtil
{
    public class LayerInformations
    {
        #region fields

        private string _layerName;
        private LayerTypeConstants _moLayerType;
        private ShapeTypeConstants _moShapeType;
        private object _moLayer;

        #endregion

        #region constructor

        public LayerInformations()
        {
        }

        public LayerInformations(object moLayer, string layerName, LayerTypeConstants moLayerType, ShapeTypeConstants moShapeType)
        {
            this._moLayer = moLayer;
            this._layerName = layerName;
            this._moLayerType = moLayerType;
            this._moShapeType = moShapeType;
        }

        #endregion

        #region properties

        public object MoLayer
        {
            get { return this._moLayer; }
            set { this._moLayer = value; }
        }

        public string LayerName
        {
            get { return this._layerName; }
            set { this._layerName = value; }
        }

        public LayerTypeConstants MoLayerType
        {
            get { return this._moLayerType; }
            set { this._moLayerType = value; }
        }

        public ShapeTypeConstants MoShapeType
        {
            get { return this._moShapeType; }
            set { this._moShapeType = value; }
        }

        #endregion
    }
}

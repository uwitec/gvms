using System;
using System.Collections.Generic;
using System.Text;

namespace MapConfigure.MapUtil
{
    public class FeatureInformations
    {
        #region fields

        private Dictionary<string, string> _fieldsAndValuesCollection;
        private ProjectUtil.ILayerStruct _layerInfos;
        private object _geometry;
        
        #endregion

        #region public methods

        public Dictionary<string, string> FieldsAndValuesCollection
        {
            get { return this._fieldsAndValuesCollection; }
            set { this._fieldsAndValuesCollection = value; }
        }

        public object Geometry
        {
            get { return this._geometry; }
            set { this._geometry = value; }
        }

        public ProjectUtil.ILayerStruct CurrentLayerInfos
        {
            get { return this._layerInfos; }
            set { this._layerInfos = value; }
        }

        #endregion
    }
}

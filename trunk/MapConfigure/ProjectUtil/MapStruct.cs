using System;
using System.Collections.Generic;
using System.Text;

namespace MapConfigure.ProjectUtil
{
    public class MapStruct
    {
        private List<ILayerStruct> _layers = new List<ILayerStruct>();
        private object _coordinateSystem = null;
        private ViewExtent _bbox = new ViewExtent();
        private string _geoDataSetPath = string.Empty;

        public List<ILayerStruct> Layers
        {
            get { return this._layers; }
            set { this._layers = value; }
        }

        public object CoordinateSystem
        {
            get { return this._coordinateSystem; }
            set { this._coordinateSystem = value; }
        }

        public ViewExtent BBox
        {
            get { return this._bbox; }
            set { this._bbox = value; }
        }

        public string GeoDataSetPath
        {
            get { return this._geoDataSetPath; }
            set { this._geoDataSetPath = value; }
        }

        public ILayerStruct FindLayer(string layerName)
        {
           return  this.Layers.Find
               (new Predicate<ILayerStruct>
               (delegate (ILayerStruct layerStrcut) 
               { return layerStrcut.Name == layerName; }
               ));
        }
    }
}

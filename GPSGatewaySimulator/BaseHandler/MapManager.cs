using System;
using System.Collections.Generic;
using System.Text;
using MapObjects2;

namespace GPSGatewaySimulator.BaseHandler
{
    class MapManager
    {
        #region public methods

        public MapLayer GetLayer(string layerPath)
        {
            if (!System.IO.File.Exists(layerPath))
                return null;

            GeoDataset oGeoDataset = null;
            DataConnection oConn = new DataConnectionClass();
            MapLayer oLayer = null;

            oConn.Database = System.IO.Path.GetDirectoryName(layerPath);

            if (oConn.Connect())
            {
                oGeoDataset = oConn.FindGeoDataset(System.IO.Path.GetFileName(layerPath).Replace(System.IO.Path.GetExtension(layerPath), string.Empty));

                if (!oGeoDataset.Equals(null))
                {
                    oLayer = new MapLayerClass();
                    oLayer.GeoDataset = oGeoDataset;
                    oConn.Disconnect();
                }
            }

            return oLayer;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MapConfigure.Utilities
{
    class LayerProperty
    {
        public MapUtil.LayerInformations GetLayerInformationByName(string layerName, List<MapUtil.LayerInformations> layerInfosCollection)
        {
            if (string.IsNullOrEmpty(layerName) || layerInfosCollection == null)
                return null;

            MapUtil.LayerInformations oLayerInfos = new MapConfigure.MapUtil.LayerInformations();

            foreach (MapUtil.LayerInformations item in layerInfosCollection)
            {
                if (item.LayerName == layerName)
                    return item;
            }

            return null;
        }

        public System.Data.DataTable GetAttributesByLayer(MapObjects2.MapLayer layer)
        {
            if (layer == null)
                return null;

            short iColumnsCount = 0;
            string sFieldName = null;
            DataTable dtLayerAttribute = new DataTable();

            MapObjects2.Recordset oAttributeRecordes = layer.Records;
            MapObjects2.TableDesc oAtributeColumns = oAttributeRecordes.TableDesc;

            iColumnsCount = oAtributeColumns.FieldCount;
            for (short i = 0; i < iColumnsCount; i++)
            {
                DataColumn oColumn = new DataColumn(oAtributeColumns.get_FieldName(i));
                dtLayerAttribute.Columns.Add(oColumn);
            }

            oAttributeRecordes.MoveFirst();
            while (!oAttributeRecordes.EOF)
            {
                DataRow oNewRow = dtLayerAttribute.NewRow();

                for (short i = 0; i < iColumnsCount; i++)
                {
                    sFieldName = oAttributeRecordes.TableDesc.get_FieldName(i).ToString();
                    oNewRow[sFieldName] = oAttributeRecordes.Fields.Item(sFieldName).ValueAsString;
                }

                dtLayerAttribute.Rows.Add(oNewRow);
                oAttributeRecordes.MoveNext();
            }

            return dtLayerAttribute;
        }

        public void SetLayerVisibility(string layerName, bool visible, List<MapUtil.LayerInformations> layerInfosCollection)
        {
            MapUtil.LayerInformations oLayerInfos = this.GetLayerInformationByName(layerName, layerInfosCollection);

            if (oLayerInfos.MoLayerType == MapObjects2.LayerTypeConstants.moImageLayer) (oLayerInfos.MoLayer as MapObjects2.ImageLayer).Visible = visible;
            else if(oLayerInfos.MoLayerType == MapObjects2.LayerTypeConstants.moMapLayer) (oLayerInfos.MoLayer as MapObjects2.MapLayer).Visible = visible;
        }

        public void SetLayerVisibility(object layer, bool visible)
        {
            if (layer is MapObjects2.ImageLayer) (layer as MapObjects2.ImageLayer).Visible = visible;
            else if (layer is MapObjects2.MapLayer) (layer as MapObjects2.MapLayer).Visible = visible;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MapProject;

namespace MapConfigure.Utilities
{
    class LayerProperty
    {
        public ILayerStruct GetLayerInformationByName(string layerName, List<ILayerStruct> layerInfosCollection)
        {
            if (string.IsNullOrEmpty(layerName) || layerInfosCollection == null)
                return null;

            foreach (ILayerStruct item in layerInfosCollection)
            {
                if (item.DataSetName == layerName)
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

        public void SetLayerVisibility(string layerName, bool visible)
        {
            MapUtil.MapOperation oMapOper = new MapConfigure.MapUtil.MapOperation();
            object oLayer = oMapOper.GetLayerByName(GlobeVariables.MapControl, layerName);

            this.SetLayerVisibility(oLayer, visible);
        }

        public void SetLayerVisibility(object layer, bool visible)
        {
            if (layer is MapObjects2.ImageLayer) (layer as MapObjects2.ImageLayer).Visible = visible;
            else if (layer is MapObjects2.MapLayer) (layer as MapObjects2.MapLayer).Visible = visible;
        }
    }
}

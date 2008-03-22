using System;
using System.Collections.Generic;
using System.Text;

namespace MapConfigure.MapUtil
{
    class LayerRender
    {
        #region public methods

        #region value render
        
        /// <summary>
        /// 给图层设置唯一值渲染
        /// </summary>
        /// <param name="layer"></param>
        /// <param name="renderFieldName"></param>
        public  void SetValueRenderToLayer(MapObjects2.MapLayer layer,string renderFieldName)
        {
            MapObjects2.ValueMapRenderer oValueMapRender = new MapObjects2.ValueMapRendererClass();
            MapObjects2.Recordset oRecords = new MapObjects2.RecordsetClass();
            short iIndex = 0;

            if (layer.shapeType == MapObjects2.ShapeTypeConstants.moShapeTypePoint)
                oValueMapRender.SymbolType = MapObjects2.SymbolTypeConstants.moPointSymbol;
            else if (layer.shapeType == MapObjects2.ShapeTypeConstants.moShapeTypeLine)
                oValueMapRender.SymbolType = MapObjects2.SymbolTypeConstants.moLineSymbol;
            else if (layer.shapeType == MapObjects2.ShapeTypeConstants.moShapeTypePolygon)
                oValueMapRender.SymbolType = MapObjects2.SymbolTypeConstants.moFillSymbol;

            oValueMapRender.Field = renderFieldName;
            oRecords.MoveFirst();

            while (!oRecords.EOF)
            {
                oValueMapRender.set_Value(iIndex, oRecords.Fields.Item(renderFieldName).ValueAsString);

                oRecords.MoveNext();
                iIndex++;
            }

            layer.Renderer = oValueMapRender;
        }


        /// <summary>
        /// 将已设置好的样式添加到唯一值渲染中去
        /// </summary>
        /// <param name="layer"></param>
        /// <param name="symbols"></param>
        public void SetSymbolsToValueRenderedLayer(MapObjects2.MapLayer layer, Dictionary<string,MapObjects2.Symbol> symbols)
        {
            if (layer.Renderer == null)
                throw new Exception("the layer has not set a render.");

            if (layer.Renderer is MapObjects2.ValueMapRenderer)
                throw new Exception("the layer has a render,but not a valuerender.");

            Dictionary<string, MapObjects2.Symbol>.KeyCollection oKeys = symbols.Keys;
            MapObjects2.ValueMapRenderer oValueRender = layer.Renderer as MapObjects2.ValueMapRenderer;
            int iValueIndex = -1;
            MapObjects2.Symbol oSymbol = null;

            foreach (string sKey in oKeys)
            {
                iValueIndex = this.GetValueIndexByRenderValue(oValueRender, sKey);

                if (iValueIndex != -1 && symbols.TryGetValue(sKey, out oSymbol))
                    this.CopySymbolToAnother(oSymbol, oValueRender.get_Symbol((short)iValueIndex));
            }
        }

        #endregion

        #endregion

        #region private methods

        private int GetValueIndexByRenderValue(MapObjects2.ValueMapRenderer render,string renderValue)
        {
            int iValueCount = render.ValueCount;

            for (short i = 0; i < iValueCount; i++)
            {
                if (renderValue.Equals(render.get_Value(i)))
                    return (int)i;
            }

            return -1;
        }

        private void CopySymbolToAnother(MapObjects2.Symbol fromSymbol, MapObjects2.Symbol toSymbol)
        {
            toSymbol.SymbolType = fromSymbol.SymbolType;
            toSymbol.CenterOnAscent = fromSymbol.CenterOnAscent;
            toSymbol.CharacterIndex = fromSymbol.CharacterIndex;
            toSymbol.Color = fromSymbol.Color;
            toSymbol.Custom = fromSymbol.Custom;
            toSymbol.Font = toSymbol.Font;
            toSymbol.Outline = fromSymbol.Outline;
            toSymbol.OutlineColor = fromSymbol.OutlineColor;
            toSymbol.Rotation = fromSymbol.Rotation;
            toSymbol.Size = fromSymbol.Size;
            toSymbol.Style = fromSymbol.Style;
            toSymbol.SymbolType = fromSymbol.SymbolType;
        }

        #endregion
    }
}

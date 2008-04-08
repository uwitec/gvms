using System;
using System.Collections.Generic;
using System.Text;
using MapObjects2;
using System.Drawing;

namespace MapConfigure.MapUtil
{
    class LayerStyles
    {
        #region public methods

        #region  set render

        /// <summary>
        /// 给图层设置唯一值渲染
        /// </summary>
        /// <param name="layer"></param>
        /// <param name="renderFieldName"></param>
        public MapObjects2.ValueMapRenderer GetUniqueValueRender(MapObjects2.MapLayer layer, string renderFieldName)
        {
            MapObjects2.ValueMapRenderer oValueMapRender = new MapObjects2.ValueMapRendererClass();
            MapObjects2.Recordset oRecords = layer.Records;
            MapObjects2.Strings oStrings = new StringsClass();

            if (layer.shapeType == ShapeTypeConstants.moShapeTypePoint)
                oValueMapRender.SymbolType = SymbolTypeConstants.moPointSymbol;
            else if (layer.shapeType == ShapeTypeConstants.moShapeTypeLine)
                oValueMapRender.SymbolType = SymbolTypeConstants.moLineSymbol;
            else if (layer.shapeType == ShapeTypeConstants.moShapeTypePolygon)
                oValueMapRender.SymbolType = SymbolTypeConstants.moFillSymbol;
          
            oValueMapRender.Field = renderFieldName;
            oStrings.Unique = true;
            oRecords.MoveFirst();

            while (!oRecords.EOF)
            {
                oStrings.Add(oRecords.Fields.Item(renderFieldName).ValueAsString);

                oRecords.MoveNext();
            }
            
            oValueMapRender.ValueCount = oStrings.Count;
            for (short i = 0; i < oStrings.Count; i++) oValueMapRender.set_Value(i, oStrings.Item(i));

            return oValueMapRender;
        }

        public MapObjects2.ClassBreaksRenderer GetClassBreaksRender(MapObjects2.MapLayer layer, string renderFieldName, int breaksCount, Color startColor, Color endColor)
        {
            MapObjects2.ClassBreaksRenderer oClassBreakRender = new MapObjects2.ClassBreaksRendererClass();

            if (layer.shapeType == ShapeTypeConstants.moShapeTypePoint)
                oClassBreakRender.SymbolType = SymbolTypeConstants.moPointSymbol;
            else if (layer.shapeType == ShapeTypeConstants.moShapeTypeLine)
                oClassBreakRender.SymbolType = SymbolTypeConstants.moLineSymbol;
            else if (layer.shapeType == ShapeTypeConstants.moShapeTypePolygon)
                oClassBreakRender.SymbolType = SymbolTypeConstants.moFillSymbol;

            oClassBreakRender.Field = renderFieldName;
            oClassBreakRender.BreakCount = (short)breaksCount;

            MapObjects2.Statistics oStatistic = layer.Records.CalculateStatistics(renderFieldName);
            double dInterval = (oStatistic.Max - oStatistic.Min) / breaksCount;

            for (short i = 0; i < breaksCount; i++)
            {
                oClassBreakRender.set_Break(i, oStatistic.Min + dInterval * i);
            }

            oClassBreakRender.RampColors((uint)Utilities.Converter.ConvertSystemtoIntegerColor(startColor), (uint)Utilities.Converter.ConvertSystemtoIntegerColor(endColor));
            
            return oClassBreakRender;
        }


        public MapObjects2.LabelRenderer GetLabelRender(string labelFieldName,bool allowDuplicates, bool flip,
            double minLevel, double maxLevel, System.Drawing.Color labelColor, string labelFontName,double labelSize, double rotation,
            MapObjects2.AlignmentConstants horizontalAlignment, MapObjects2.AlignmentConstants verticalAlignment)
        {
            MapObjects2.LabelRenderer oLabelRender = new MapObjects2.LabelRendererClass();

            oLabelRender.Field = labelFieldName;
            oLabelRender.AllowDuplicates = allowDuplicates;
            oLabelRender.Flip = flip;
            oLabelRender.MaxLevel = (short)maxLevel;
            oLabelRender.MinLevel = (short)minLevel;
            oLabelRender.SymbolCount = 1;
            oLabelRender.get_Symbol(0).Color = (uint)Utilities.Converter.ConvertSystemtoIntegerColor(labelColor);
            oLabelRender.get_Symbol(0).Font.Name = labelFontName;
            oLabelRender.get_Symbol(0).Font.Size = (decimal)labelSize;
            oLabelRender.get_Symbol(0).HorizontalAlignment = horizontalAlignment;
            oLabelRender.get_Symbol(0).VerticalAlignment = verticalAlignment;
            oLabelRender.get_Symbol(0).Rotation = rotation;

            return oLabelRender;
        }

        public MapObjects2.GroupRenderer GetGroupRender(List<object> renders)
        {
            MapObjects2.GroupRenderer oGroupRender = new MapObjects2.GroupRendererClass();

            foreach (object oRender in renders)
            {
                if (oRender is MapObjects2.ValueMapRenderer
                    || oRender is MapObjects2.ClassBreaksRenderer
                    || oRender is MapObjects2.LabelRenderer)
                    oGroupRender.Add(oRender);
            }

            return oGroupRender;
        }

        #endregion

        #region set symbol

        /// <summary>
        /// 将已设置好的样式添加到唯一值渲染中去
        /// </summary>
        /// <param name="layer"></param>
        /// <param name="symbols"></param>
        public void SetSymbolsToValueRenderedLayer(MapObjects2.MapLayer layer, Dictionary<string, MapObjects2.Symbol> symbols)
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

        public short GetSymbolStyleByName(MapObjects2.ShapeTypeConstants shapeType, string symbolStyleName)
        {
            if (shapeType == ShapeTypeConstants.moShapeTypePoint)
            {
                if (symbolStyleName == MarkerStyleConstants.moCircleMarker.ToString())
                    return (short)MarkerStyleConstants.moCircleMarker;
                else if (symbolStyleName == MarkerStyleConstants.moCrossMarker.ToString())
                    return (short)MarkerStyleConstants.moCrossMarker;
                else if (symbolStyleName == MarkerStyleConstants.moSquareMarker.ToString())
                    return (short)MarkerStyleConstants.moSquareMarker;
                else if (symbolStyleName == MarkerStyleConstants.moTriangleMarker.ToString())
                    return (short)MarkerStyleConstants.moTriangleMarker;
                else if (symbolStyleName == MarkerStyleConstants.moTrueTypeMarker.ToString())
                    return (short)MarkerStyleConstants.moTrueTypeMarker;
            }
            else if (shapeType == ShapeTypeConstants.moShapeTypeLine)
            {
                if (symbolStyleName == LineStyleConstants.moDashDotDotLine.ToString())
                    return (short)LineStyleConstants.moDashDotDotLine;
                else if (symbolStyleName == LineStyleConstants.moDashDotLine.ToString())
                    return (short)LineStyleConstants.moDashDotLine;
                else if (symbolStyleName == LineStyleConstants.moDashLine.ToString())
                    return (short)LineStyleConstants.moDashLine;
                else if (symbolStyleName == LineStyleConstants.moDotLine.ToString())
                    return (short)LineStyleConstants.moDotLine;
                else if (symbolStyleName == LineStyleConstants.moSolidLine.ToString())
                    return (short)LineStyleConstants.moSolidLine;
            }
            else if (shapeType == ShapeTypeConstants.moShapeTypePolygon)
            {
                if (symbolStyleName == FillStyleConstants.moCrossFill.ToString())
                    return (short)FillStyleConstants.moCrossFill;
                else if (symbolStyleName == FillStyleConstants.moDarkGrayFill.ToString())
                    return (short)FillStyleConstants.moDarkGrayFill;
                else if (symbolStyleName == FillStyleConstants.moDiagonalCrossFill.ToString())
                    return (short)FillStyleConstants.moDiagonalCrossFill;
                else if (symbolStyleName == FillStyleConstants.moDownwardDiagonalFill.ToString())
                    return (short)FillStyleConstants.moDownwardDiagonalFill;
                else if (symbolStyleName == FillStyleConstants.moGrayFill.ToString())
                    return (short)FillStyleConstants.moGrayFill;
                    else if (symbolStyleName == FillStyleConstants.moHorizontalFill.ToString())
                    return (short)FillStyleConstants.moHorizontalFill;
                else if (symbolStyleName == FillStyleConstants.moLightGrayFill.ToString())
                    return (short)FillStyleConstants.moLightGrayFill;
                else if (symbolStyleName == FillStyleConstants.moSolidFill.ToString())
                    return (short)FillStyleConstants.moSolidFill;
                else if (symbolStyleName == FillStyleConstants.moTransparentFill.ToString())
                    return (short)FillStyleConstants.moTransparentFill;
                else if (symbolStyleName == FillStyleConstants.moUpwardDiagonalFill.ToString())
                    return (short)FillStyleConstants.moUpwardDiagonalFill;
                else if (symbolStyleName == FillStyleConstants.moVerticalFill.ToString())
                    return (short)FillStyleConstants.moVerticalFill;
            }

            return (short)-1;
        }

        public MapObjects2.AlignmentConstants GetLabelAlignmentByName(string alignmentName)
        {
            if (alignmentName == MapObjects2.AlignmentConstants.moAlignBaseline.ToString())
                return AlignmentConstants.moAlignBaseline;
            else if (alignmentName == MapObjects2.AlignmentConstants.moAlignBottom.ToString())
                return AlignmentConstants.moAlignBottom;
            else if (alignmentName == MapObjects2.AlignmentConstants.moAlignCenter.ToString())
                return AlignmentConstants.moAlignCenter;
            else if (alignmentName == MapObjects2.AlignmentConstants.moAlignLeft.ToString())
                return AlignmentConstants.moAlignLeft;
            else if (alignmentName == MapObjects2.AlignmentConstants.moAlignRight.ToString())
                return AlignmentConstants.moAlignRight;
            else if (alignmentName == MapObjects2.AlignmentConstants.moAlignTop.ToString())
                return AlignmentConstants.moAlignTop;
            else
                return AlignmentConstants.moAlignCenter;

        }

        #endregion

        #endregion

        #region private methods

        private int GetValueIndexByRenderValue(MapObjects2.ValueMapRenderer render, string renderValue)
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

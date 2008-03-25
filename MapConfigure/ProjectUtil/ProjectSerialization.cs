using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime;

namespace MapConfigure.ProjectUtil
{
    class ProjectSerialization
    {
        #region public methods

        public  void SerializeProject(MapStruct map,string saveFileName)
        {
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter oFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            System.IO.FileStream oFileStream = new System.IO.FileStream(saveFileName, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite);
            oFormatter.Serialize(oFileStream, map);
        }

        public  MapStruct DeserializeProject(string projectFileName)
        {
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter oFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            MapStruct oMap = new MapStruct();

            using (System.IO.FileStream oFileStream = new System.IO.FileStream(projectFileName, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                oMap = oFormatter.Deserialize(oFileStream) as MapStruct;
            }

            return oMap;
        }

        public void LoadProjectByMapInfos(MapStruct mapInfos,AxMapObjects2.AxMap mapControl)
        {
            List<ILayerStruct> oLayers = mapInfos.Layers;
            MapObjects2.DataConnection oConn = new MapObjects2.DataConnectionClass();

            oConn.Database = mapInfos.GeoDataSetPath;

            oConn.Connect();

            foreach (ILayerStruct oLayer in oLayers)
            {
                if (oLayer is MapLayerInfoStruct && oConn.Connected)
                {
                    MapObjects2.MapLayer oMapLayer = new MapObjects2.MapLayerClass();
                    oMapLayer.GeoDataset = oConn.FindGeoDataset(oLayer.Name);

                    this.SetLayerRender(oMapLayer, (oLayer as MapLayerInfoStruct).Render);
                    this.ConvertSymbol((oLayer as MapLayerInfoStruct).Symbol, oMapLayer.Symbol);

                    mapControl.Layers.Add(oMapLayer);
                }
                else if (oLayer is ImageLayerInfoStruct)
                {
                    //not implement
                    //MapObjects2.ImageLayer oImageLayer = new MapObjects2.ImageLayerClass();
                    //oImageLayer.Name = oLayer.Name;
                }
            }

            if(oConn.Connected) oConn.Disconnect();

            mapControl.Extent.Top = mapInfos.BBox.MinX;
            mapControl.Extent.Left = mapInfos.BBox.MinY;
            mapControl.Extent.Bottom = mapInfos.BBox.MaxX;
            mapControl.Extent.Right = mapInfos.BBox.MaxY;
            mapControl.CoordinateSystem = mapInfos.CoordinateSystem;
        }

        public MapStruct SaveMapInfosToProject(AxMapObjects2.AxMap mapControl,string geoDataSetPath)
        {
            MapStruct oMapStruct = new MapStruct();

            oMapStruct.BBox.MinX = mapControl.Extent.Top;
            oMapStruct.BBox.MinY = mapControl.Extent.Left;
            oMapStruct.BBox.MaxX = mapControl.Extent.Bottom;
            oMapStruct.BBox.MaxY = mapControl.Extent.Right;
            oMapStruct.BBox.Width = mapControl.Extent.Width;
            oMapStruct.BBox.Height = mapControl.Extent.Height;

            oMapStruct.CoordinateSystem = mapControl.CoordinateSystem;
            oMapStruct.GeoDataSetPath = geoDataSetPath;

            short iLayersCount = mapControl.Layers.Count;
            for (short i = 0; i < iLayersCount; i++)
            {
                object oLayer = mapControl.Layers.Item(i);

                if (oLayer is MapObjects2.MapLayer)
                {
                    MapObjects2.MapLayer oMapLayer = oLayer as MapObjects2.MapLayer;
                    MapLayerInfoStruct oMapLayerStruct = new MapLayerInfoStruct();

                    oMapLayerStruct.LayerType = (short)oMapLayer.LayerType;
                    oMapLayerStruct.Name = oMapLayer.Name;
                    oMapLayerStruct.ShapeType = (short)oMapLayer.shapeType;

                    oMapLayerStruct.Render = this.ExportLayerRender(oMapLayer);
                    this.DeconvertSymbol(oMapLayer.Symbol, oMapLayerStruct.Symbol);
                }
                else if (oLayer is MapObjects2.ImageLayer)
                {
                    throw new NotImplementedException();
                }
            }

            return oMapStruct;
        }

        #endregion

        #region private methods

        #region set layer render and symbol

        private void SetLayerRender(MapObjects2.MapLayer layer, IRenderStruct render)
        {
            if (render.LayerRenderType == RenderType.ValueRender) layer.Renderer = this.GetValueRender(render as ValueRenderStruct);
            else if (render.LayerRenderType == RenderType.ClassBreakRender) layer.Renderer = this.GetClassBreakRender(render as ClassBreakRenderStruct);
            else if (render.LayerRenderType == RenderType.LabelRender) layer.Renderer = this.GetLabelRender(render as LabelRenderStruct);
            else if (render.LayerRenderType == RenderType.GroupRender) layer.Renderer = this.GetGroupRender(render as GroupRenderStruct);
        }

        private void ConvertSymbol(SymbolStruct fromSymbol,MapObjects2.Symbol toSymbol)
        {
            toSymbol.CenterOnAscent = fromSymbol.CenterOnAscent;
            toSymbol.CharacterIndex = fromSymbol.CharacterIndex;
            toSymbol.Color = Convert.ToUInt32(fromSymbol.FillColor.ToArgb());
            toSymbol.Custom = fromSymbol.CustomSymbol;
            toSymbol.Font.Name = fromSymbol.FontName;
            toSymbol.Outline = fromSymbol.OutLine;
            toSymbol.OutlineColor = Convert.ToUInt32(fromSymbol.OutLineColor.ToArgb());
            toSymbol.Rotation = fromSymbol.Rotation;
            toSymbol.Size = fromSymbol.Size;
            toSymbol.Style = fromSymbol.Style;
            toSymbol.SymbolType = (MapObjects2.SymbolTypeConstants)fromSymbol.SymbolType;
        }

        private void ConvertTextSymbol(TextSymbolStruct fromSymbol, MapObjects2.TextSymbol toSymbol)
        {
            toSymbol.Color = (uint)fromSymbol.TextColor.ToArgb();
            toSymbol.Fitted = fromSymbol.Fitted;
            toSymbol.Font = fromSymbol.TextFont;
            toSymbol.Height = fromSymbol.Height;
            toSymbol.HorizontalAlignment = (MapObjects2.AlignmentConstants)fromSymbol.HorizontalAlignment;
            toSymbol.VerticalAlignment = (MapObjects2.AlignmentConstants)fromSymbol.VerticalAlignment;
            toSymbol.Rotation = fromSymbol.Rotation;
        }

        private MapObjects2.ValueMapRenderer GetValueRender(ValueRenderStruct render)
        {
            MapObjects2.ValueMapRenderer oMapRender = new MapObjects2.ValueMapRendererClass();

            this.ConvertSymbol(render.DefaultSymbol, oMapRender.DefaultSymbol);

            oMapRender.Field = render.Field;
            oMapRender.RotationField = render.RotationField;
            oMapRender.ScalingField = render.ScaleField;
            oMapRender.SymbolType = (MapObjects2.SymbolTypeConstants)render.SymbolType;
            oMapRender.Tag = render.Tag;
            oMapRender.UseDefault = render.UseDefault;
            oMapRender.ValueCount = render.ValueCount;

            short iIndex = 0;
            foreach (SymbolStruct oSymbol in render.SymbolList)
            {
                ConvertSymbol(oSymbol, oMapRender.get_Symbol(iIndex));

                iIndex++;
            }

            return oMapRender;
        }

        private MapObjects2.ClassBreaksRenderer GetClassBreakRender(ClassBreakRenderStruct render)
        {
            MapObjects2.ClassBreaksRenderer oMapRender = new MapObjects2.ClassBreaksRendererClass();
            short iIndex = 0;

            oMapRender.BreakCount = render.BreakCount;
            oMapRender.DrawBackground = render.DrawBackground;
            oMapRender.Field = render.Field;
            oMapRender.SymbolType = (MapObjects2.SymbolTypeConstants)render.SymbolType;
            oMapRender.Tag = render.Tag;

            foreach (double dBreak in render.BreakList)
            {
                oMapRender.set_Break(iIndex, dBreak);

                iIndex++;
            }
            
            oMapRender.RampColors((uint)render.StartColor.ToArgb(), (uint)render.EndColor.ToArgb());

            return oMapRender;
        }

        private MapObjects2.LabelRenderer GetLabelRender(LabelRenderStruct render)
        {
            MapObjects2.LabelRenderer oMapRender = new MapObjects2.LabelRendererClass();

            oMapRender.AllowDuplicates = render.AllowDuplicates;
            oMapRender.DrawBackground = render.DrawBackground;
            oMapRender.Field = render.Field;
            oMapRender.FittedField = render.FittedField;
            oMapRender.Flip = render.Flip;
            oMapRender.HeightField = render.HeightField;
            oMapRender.LevelField = render.LevelField;
            oMapRender.MaxLevel = render.MaxLevel;
            oMapRender.MinLevel = render.MinLevel;
            oMapRender.RotationField = render.RotationField;
            oMapRender.SplinedText = render.SplinedText;
            oMapRender.SymbolCount = render.SymbolCount;
            oMapRender.SymbolField = render.SymbolField;
            oMapRender.Tag = render.Tag;
            oMapRender.XOffsetField = render.XOffsetField;
            oMapRender.YOffsetField = render.YOffsetField;

            short iIndex = 0;
            foreach (TextSymbolStruct oSymbol in render.SymbolList)
            {
                MapObjects2.TextSymbol otext = new MapObjects2.TextSymbol();
                this.ConvertTextSymbol(oSymbol, oMapRender.get_Symbol(iIndex));

                iIndex++;
            }

            return oMapRender;
        }

        private MapObjects2.GroupRenderer GetGroupRender(GroupRenderStruct render)
        {
            MapObjects2.GroupRenderer oMapRender = new MapObjects2.GroupRendererClass();

            foreach (IRenderStruct oRender in render.RenderList)
            {
                if (oRender.LayerRenderType == RenderType.ClassBreakRender)
                {
                    MapObjects2.ClassBreaksRenderer oClassBreakRender = this.GetClassBreakRender(oRender as ClassBreakRenderStruct);
                    oMapRender.Add(oClassBreakRender);
                }
                else if (oRender.LayerRenderType == RenderType.LabelRender)
                {
                    MapObjects2.LabelRenderer oLabelRender = this.GetLabelRender(oRender as LabelRenderStruct);
                    oMapRender.Add(oLabelRender);
                }
                else if (oRender.LayerRenderType == RenderType.ValueRender)
                {
                    MapObjects2.ValueMapRenderer oValueRender = this.GetValueRender(oRender as ValueRenderStruct);
                    oMapRender.Add(oValueRender);
                }
            }

            return oMapRender;

        }

        #endregion

        #region export layer render and symbol 

        private IRenderStruct ExportLayerRender(MapObjects2.MapLayer layer)
        {
            object oLayerRender = layer.Renderer;

            if (oLayerRender == null) return null;

            if (oLayerRender is MapObjects2.ValueMapRenderer) return this.ExportValueRender(layer.Renderer as MapObjects2.ValueMapRenderer);
            else if (oLayerRender is MapObjects2.ClassBreaksRenderer) return this.ExportClassBreakRender(layer.Renderer as MapObjects2.ClassBreaksRenderer);
            else if (oLayerRender is MapObjects2.LabelRenderer) return this.ExportLabelRender(layer.Renderer as MapObjects2.LabelRenderer);
            else if (oLayerRender is MapObjects2.GroupRenderer) return this.ExportGroupRender(layer.Renderer as MapObjects2.GroupRenderer);
            else return null;
        }

        private void DeconvertSymbol(MapObjects2.Symbol fromSymbol, SymbolStruct toSymbol)
        {
            toSymbol.CenterOnAscent = fromSymbol.CenterOnAscent;
            toSymbol.CharacterIndex = fromSymbol.CharacterIndex;
            toSymbol.FillColor = System.Drawing.ColorTranslator.FromWin32((int)fromSymbol.Color);
            toSymbol.CustomSymbol = fromSymbol.Custom;
            toSymbol.FontName = fromSymbol.Font.Name;
            toSymbol.OutLine = fromSymbol.Outline;
            toSymbol.OutLineColor = System.Drawing.ColorTranslator.FromWin32((int)fromSymbol.OutlineColor);
            toSymbol.Rotation = fromSymbol.Rotation;
            toSymbol.Size = fromSymbol.Size;
            toSymbol.Style = fromSymbol.Style;
            toSymbol.SymbolType = (short)fromSymbol.SymbolType;
        }

        private void DeconvertTextSymbol(MapObjects2.TextSymbol fromSymbol, TextSymbolStruct toSymbol)
        {
            toSymbol.TextColor = System.Drawing.ColorTranslator.FromWin32((int)fromSymbol.Color);
            toSymbol.Fitted = fromSymbol.Fitted;
            toSymbol.TextFont = fromSymbol.Font;
            toSymbol.Height = fromSymbol.Height;
            toSymbol.HorizontalAlignment = (short)fromSymbol.HorizontalAlignment;
            toSymbol.VerticalAlignment = (short)fromSymbol.VerticalAlignment;
            toSymbol.Rotation = fromSymbol.Rotation;
        }

        private ValueRenderStruct ExportValueRender(MapObjects2.ValueMapRenderer render)
        {
            ValueRenderStruct oValueRender = new ValueRenderStruct();

            this.DeconvertSymbol(render.DefaultSymbol, oValueRender.DefaultSymbol);

            oValueRender.Field = render.Field;
            oValueRender.RotationField = render.RotationField;
            oValueRender.ScaleField = render.ScalingField;
            oValueRender.SymbolType = (short)render.SymbolType;
            oValueRender.Tag = render.Tag;
            oValueRender.UseDefault = render.UseDefault;
            oValueRender.ValueCount = render.ValueCount;

            short iIndex = 0;
            MapObjects2.Symbol oMapSymbol = render.get_Symbol(iIndex);

            while (oMapSymbol != null)
            {
                SymbolStruct oSymbol = new SymbolStruct();
                this.DeconvertSymbol(oMapSymbol, oSymbol);
                oValueRender.SymbolList.Add(oSymbol);

                iIndex++;
                oMapSymbol = render.get_Symbol(iIndex);
            }

            return oValueRender;
        }

        private ClassBreakRenderStruct ExportClassBreakRender(MapObjects2.ClassBreaksRenderer render)
        {
            ClassBreakRenderStruct oClassBreakRender = new ClassBreakRenderStruct();
            short iIndex = 0;

            oClassBreakRender.BreakCount = render.BreakCount;
            oClassBreakRender.DrawBackground = render.DrawBackground;
            oClassBreakRender.Field = render.Field;
            oClassBreakRender.SymbolType = (short)render.SymbolType;
            oClassBreakRender.Tag = render.Tag;

            double dBreak = render.get_Break(iIndex);

            while (dBreak != double.NaN)
            {
                oClassBreakRender.BreakList.Add(dBreak);

                iIndex++;
                dBreak = render.get_Break(iIndex);
            }

            oClassBreakRender.StartColor = System.Drawing.ColorTranslator.FromWin32((int)render.get_Symbol((short)0).Color);
            oClassBreakRender.EndColor = System.Drawing.ColorTranslator.FromWin32((int)render.get_Symbol((short)(render.BreakCount - 1)).Color);

            return oClassBreakRender;
        }

        private LabelRenderStruct ExportLabelRender(MapObjects2.LabelRenderer render)
        {
            LabelRenderStruct oLabelRender = new LabelRenderStruct();

            oLabelRender.AllowDuplicates = render.AllowDuplicates;
            oLabelRender.DrawBackground = render.DrawBackground;
            oLabelRender.Field = render.Field;
            oLabelRender.FittedField = render.FittedField;
            oLabelRender.Flip = render.Flip;
            oLabelRender.HeightField = render.HeightField;
            oLabelRender.LevelField = render.LevelField;
            oLabelRender.MaxLevel = render.MaxLevel;
            oLabelRender.MinLevel = render.MinLevel;
            oLabelRender.RotationField = render.RotationField;
            oLabelRender.SplinedText = render.SplinedText;
            oLabelRender.SymbolCount = render.SymbolCount;
            oLabelRender.SymbolField = render.SymbolField;
            oLabelRender.Tag = render.Tag;
            oLabelRender.XOffsetField = render.XOffsetField;
            oLabelRender.YOffsetField = render.YOffsetField;

            short iIndex = 0;
            MapObjects2.TextSymbol oMapTextSymbol = render.get_Symbol(iIndex);

            while (oMapTextSymbol != null)
            {
                TextSymbolStruct oTextSymbol = new TextSymbolStruct();
                this.DeconvertTextSymbol(oMapTextSymbol, oTextSymbol);
                oLabelRender.SymbolList.Add(oTextSymbol);

                iIndex++;
                oMapTextSymbol = render.get_Symbol(iIndex);
            }          

            return oLabelRender;
        }

        private GroupRenderStruct ExportGroupRender(MapObjects2.GroupRenderer render)
        {
            GroupRenderStruct oGroupRender = new GroupRenderStruct();
            short iIndex = 0;

            oGroupRender.DrawBackground = render.DrawBackground;
            oGroupRender.Tag = render.Tag;
            
            object oMapSubRender = render.get_Renderer(iIndex);
            while (oMapSubRender != null)
            {
                if (oMapSubRender is MapObjects2.ValueMapRenderer)
                {
                    ValueRenderStruct oValueRender = this.ExportValueRender(oMapSubRender as MapObjects2.ValueMapRenderer);
                    oGroupRender.RenderList.Add(oValueRender);
                }
                else if (oMapSubRender is MapObjects2.ClassBreaksRenderer)
                {
                    ClassBreakRenderStruct oClassBreakRender = this.ExportClassBreakRender(oMapSubRender as MapObjects2.ClassBreaksRenderer);
                    oGroupRender.RenderList.Add(oClassBreakRender);
                }
                else if (oMapSubRender is MapObjects2.LabelRenderer)
                {
                    LabelRenderStruct oLabelRender = this.ExportLabelRender(oMapSubRender as MapObjects2.LabelRenderer);
                    oGroupRender.RenderList.Add(oLabelRender);
                }

                iIndex++;
                oMapSubRender = render.get_Renderer(iIndex);
            }


            return oGroupRender;
        }

        #endregion
        #endregion

    }
}

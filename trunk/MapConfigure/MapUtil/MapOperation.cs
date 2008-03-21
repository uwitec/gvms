using System;
using System.Collections.Generic;
using System.Text;
using MapObjects2;

namespace MapConfigure.MapUtil
{
    class MapOperation
    {
        #region public methods

        /// <summary>
        /// 加载图层集合
        /// </summary>
        /// <param name="layerPaths">图层路径集合</param>
        /// <param name="map">地图对象</param>
        public List<LayerInformations> LoadLayers(List<string> layerPaths, ref AxMapObjects2.AxMap mapControl)
        {
            BaseHandler.MapManager oMapManager = new BaseHandler.MapManager();
            List<LayerInformations> oLayerfosCollection = new List<LayerInformations>();

            foreach (string sLayerPath in layerPaths)
            {
                string sFileExtent = System.IO.Path.GetExtension(sLayerPath);
                LayerTypeConstants oLayerType = oMapManager.GetLayerTypeByFileExtent(sFileExtent);

                if (oLayerType == LayerTypeConstants.moMapLayer)
                {
                    MapLayer oMapLayer = oMapManager.GetSingleVectorLayer(sLayerPath);
                    mapControl.Layers.Add(oMapLayer);

                    oLayerfosCollection.Add(new LayerInformations(oMapLayer, oMapLayer.Name, oLayerType, oMapLayer.shapeType));
                }
                else if (oLayerType == LayerTypeConstants.moImageLayer)
                {
                    ImageLayer oImageLayer = oMapManager.GetSingleImageLayer(sLayerPath);
                    mapControl.Layers.Add(oImageLayer);

                    oLayerfosCollection.Add(new LayerInformations(oImageLayer, oImageLayer.Name, oLayerType, (ShapeTypeConstants)(-1)));
                }
            }

            return oLayerfosCollection;
        }
        
        public void LoadLayersToLegendControl(List<LayerInformations> layersInfoSet,System.Windows.Forms.ImageList imageList, ref System.Windows.Forms.TreeView legendControl)
        {
            if (legendControl.Nodes.Count == 0)
                legendControl.Nodes.Add("layergroup", "图层", imageList.Images.IndexOfKey("layergroup"));

            foreach (LayerInformations item in layersInfoSet)
            {
                legendControl.Nodes[0].Nodes.Add(item.MoShapeType.ToString(), item.LayerName, imageList.Images.IndexOfKey(item.MoShapeType.ToString()));
            }
        }

        public FeatureInformations GetIdentifyFeatureInfos(MapObjects2.Point mousePosition,AxMapObjects2.AxMap mapControl)
        {
            FeatureInformations oFeatureInfos = null;

            foreach (LayerInformations oLayerInfos in GlobeVariables.LayersInformationSet)
            {
                if (oLayerInfos.MoLayerType != LayerTypeConstants.moMapLayer)
                    continue;

                Recordset oSelectedRecords = (oLayerInfos.MoLayer as MapLayer).SearchByDistance(mousePosition, mapControl.ToMapDistance(4f), "");

                if (oSelectedRecords.EOF)
                    continue;

                oSelectedRecords.MoveFirst();

                oFeatureInfos = new FeatureInformations();
                oFeatureInfos.CurrentLayerInfos = oLayerInfos;
                oFeatureInfos.Geometry = oSelectedRecords.Fields.Item("shape").Value;

                TableDesc oTableDesc = oSelectedRecords.TableDesc;
                oFeatureInfos.FieldsAndValuesCollection = new Dictionary<string,string>();
                int iFieldsCount = oTableDesc.FieldCount;
                string sFieldName = "";
                string sValue = "";

                for (short i = 0; i < iFieldsCount; i++)
                {
                    sFieldName = oTableDesc.get_FieldName(i);
                    sValue = oSelectedRecords.Fields.Item(sFieldName).ValueAsString;
                    oFeatureInfos.FieldsAndValuesCollection.Add(sFieldName, sValue);
                }

                break;
            }

            return oFeatureInfos;
        }

        public void ZoomInMap(Rectangle mapExtent, ref AxMapObjects2.AxMap mapControl)
        {
            mapControl.Extent = mapExtent.Extent;
        }

        public void ZoomAndCenterMap(double scaleFactor, Point centerPoint, ref AxMapObjects2.AxMap mapControl)
        {
            Rectangle oExtent = new RectangleClass();
            oExtent.Left = mapControl.FullExtent.Left;
            oExtent.Right = mapControl.FullExtent.Right;
            oExtent.Top = mapControl.FullExtent.Top;
            oExtent.Bottom = mapControl.FullExtent.Bottom;

            oExtent.ScaleRectangle(scaleFactor);
            oExtent.Offset(centerPoint.X - oExtent.Center.X, centerPoint.Y - oExtent.Center.Y);

            mapControl.Extent = oExtent;
        }

        public void ZoomOutMap(Rectangle mapExtent, ref AxMapObjects2.AxMap mapControl)
        {
            Rectangle oRectangle = mapControl.Extent;
            oRectangle.ScaleRectangle(mapControl.Extent.Height / mapExtent.Extent.Height);
            mapControl.Extent = oRectangle;
        }

        public double ComputeDistance(Point location1, Point location2)
        {
            double dResult = 0;

            Line oLine = new LineClass();
            Points oPointsCol = new PointsClass();
            oPointsCol.Add(location1);
            oPointsCol.Add(location2);
            oLine.Parts.Add(oPointsCol);

            dResult = this.ComputeDistance(oLine);

            return dResult;
        }

        public double ComputeDistance(Line polyLine)
        {
            MapObjects2.Points pts = (MapObjects2.Points)polyLine.Parts.Item(0);

          if (pts.Count < 2)
                return 0.0;

            return ComputeDistance(pts);
        }
      
        public double ComputeArea(Polygon polygonRegion)
        {
            MapObjects2.Points pts = (MapObjects2.Points)polygonRegion.Parts.Item(0);
         
            if (pts.Count < 3)
                return 0.0;

            return ComputeArea(pts);
        }

        private double ComputeDistance(Points pointCollection)
        {
            int nSize = pointCollection.Count;
            double dLength = 0;
            double x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            int nCenterL = ((int)(pointCollection.Item(0).X) / 6 + 1) * 6 - 3;

            for (int i = 0; i < nSize - 1; i++)
            {
                BaseHandler.CoordinateConvert.ConvertLatLongCoordToGuss(pointCollection.Item(i).X, pointCollection.Item(i).Y, ref x1, ref y1, nCenterL);
                BaseHandler.CoordinateConvert.ConvertLatLongCoordToGuss(pointCollection.Item(i + 1).X, pointCollection.Item(i + 1).Y, ref x2, ref y2, nCenterL);
                dLength += Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            }

            return dLength;
        }

        private double ComputeArea(Points pointCollection)
        {
            int nSize = pointCollection.Count;
            double dArea = 0;
            double x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            int nCenterL = ((int)(pointCollection.Item(0).X) / 6 + 1) * 6 - 3;

            for (int i = 0; i < nSize-1; i++)
            {
                BaseHandler.CoordinateConvert.ConvertLatLongCoordToGuss(pointCollection.Item(i).X, pointCollection.Item(i).Y, ref x1, ref y1, nCenterL);
                BaseHandler.CoordinateConvert.ConvertLatLongCoordToGuss(pointCollection.Item(i + 1).X, pointCollection.Item(i + 1).Y, ref x2, ref y2, nCenterL);
                dArea += (x2 - x1) * (y1 + y2) / 2;
            }

            BaseHandler.CoordinateConvert.ConvertLatLongCoordToGuss(pointCollection.Item(nSize-1).X, pointCollection.Item(nSize-1).Y, ref x1, ref y1, nCenterL);
            BaseHandler.CoordinateConvert.ConvertLatLongCoordToGuss(pointCollection.Item(0).X, pointCollection.Item(01).Y, ref x2, ref y2, nCenterL);
            dArea += (x2 - x1) * (y1 + y2) / 2;

            if (dArea < 0)
                dArea = 0 - dArea;
            return dArea;
        }


        #endregion

        /// <summary>
        /// 计算地图的当前比例尺
        /// </summary>
        /// <param name="mapControl"></param>
        /// <returns></returns>
        public  double ComputeMapScale(AxMapObjects2.AxMap mapControl)
        {
            System.Drawing.Graphics g = System.Drawing.Graphics.FromHwnd((System.IntPtr)mapControl.hWnd);

            Point oPoint1 = new PointClass();
            oPoint1.X = mapControl.Extent.Left;
            oPoint1.Y = mapControl.Extent.Top;

            Point oPoint2 = new PointClass();
            oPoint2.X = mapControl.Extent.Right;
            oPoint2.Y =mapControl.Extent.Top;

            double dLen1 = this.ComputeDistance(oPoint1, oPoint2);
            double dLen2 = mapControl.Width / g.DpiX * 2.54 / 100;

            g.Dispose();

            return dLen1 / dLen2;
        }

        

        #region distroied code

        ///// <summary>
        ///// 加载图层集合
        ///// </summary>
        ///// <param name="layerPaths">图层路径集合</param>
        ///// <param name="map">地图对象</param>
        //public void LoadLayers(List<string> layerPaths, ref MapClass map)
        //{
        //    short iPointLayerMaxIndex = 0;
        //    short iPolylineLayerMaxIndex = 0;
        //    short iPolygonLayerMaxIndex = 0;
        //    short iImageLayerMaxIndex = 0;

        //    int iLayerCount = map.Layers.Count;

        //    for (short i = 0; i < iLayerCount; i++)
        //    {
        //        object oLayer = map.Layers.Item(i);

        //        if (oLayer is MapLayer)
        //        {
        //            MapLayer oMapLayer = oLayer as MapLayer;
        //            if (oMapLayer.shapeType == ShapeTypeConstants.moShapeTypePoint || oMapLayer.shapeType == ShapeTypeConstants.moShapeTypeMultipoint)
        //                iPointLayerMaxIndex = i;
        //            else if (oMapLayer.shapeType == ShapeTypeConstants.moShapeTypeLine || oMapLayer.shapeType == ShapeTypeConstants.moShapeTypeEllipse || oMapLayer.shapeType == ShapeTypeConstants.moShapeTypeRectangle)
        //                iPolylineLayerMaxIndex = i;
        //            else if (oMapLayer.shapeType == ShapeTypeConstants.moShapeTypePolygon)
        //                iPolygonLayerMaxIndex = i;
        //        }
        //        else if (oLayer is ImageLayer)
        //        {
        //            iImageLayerMaxIndex = i;
        //        }
        //    }

        //    foreach (string sLayerPath in layerPaths)
        //    {
        //        string sFileExtent = System.IO.Path.GetExtension(sLayerPath);
        //        string sFileName = System.IO.Path.GetFileNameWithoutExtension(sLayerPath);
        //        string sFileDirectory = System.IO.Path.GetDirectoryName(sLayerPath);
        //        MapUtil.LayerType oLayerType = this.GetLayerTypeByFileExtent(sFileExtent);

        //        if (oLayerType == GPSTrackingMonitor.MapUtil.LayerType.VectorLayer)
        //        {
        //            MapLayer oMapLayer = this.GetSingleVectorLayer(sLayerPath);
        //            map.Layers.Add(oMapLayer);

        //            short iMaxLayerIndex = map.Layers.Count - 1;
        //            if (oMapLayer.shapeType == ShapeTypeConstants.moShapeTypeMultipoint || oMapLayer.shapeType == ShapeTypeConstants.moShapeTypePoint)
        //            {
        //                map.Layers.MoveTo(map.Layers.Count, iPointLayerMaxIndex);
        //                iPointLayerMaxIndex++;
        //                iPolygonLayerMaxIndex++;
        //                iPolylineLayerMaxIndex++;
        //            }
        //            else if (oMapLayer.shapeType == ShapeTypeConstants.moShapeTypeEllipse || oMapLayer.shapeType == ShapeTypeConstants.moShapeTypeLine || oMapLayer.shapeType == ShapeTypeConstants.moShapeTypeRectangle)
        //            {
        //                map.Layers.MoveTo(map.Layers.Count - 1, iPolylineLayerMaxIndex);
        //                iPolygonLayerMaxIndex++;
        //                iPolylineLayerMaxIndex++;
        //            }
        //            else if (oMapLayer.shapeType == ShapeTypeConstants.moShapeTypePolygon)
        //            {
        //                map.Layers.MoveTo(map.Layers.Count - 1, iPolygonLayerMaxIndex);
        //                iPolygonLayerMaxIndex++;
        //            }
        //        }
        //        else if (oLayerType == GPSTrackingMonitor.MapUtil.LayerType.ImageLayer)
        //        {
        //            map.Layers.Add(this.GetSingleImageLayer(sLayerPath));
        //        }
        //    }
        //}
        #endregion
    }
}

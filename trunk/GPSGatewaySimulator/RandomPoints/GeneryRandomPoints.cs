using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MapObjects2;

namespace GPSGatewaySimulator.RandomPoints
{
   public class GeneryRandomPoints
   {
       #region public methods

       public DataTable GetPointsFromRoadLayer(int needPointsCount,int interVal, MapLayer vectorLayer)
        {
            if (vectorLayer.shapeType != ShapeTypeConstants.moShapeTypeLine)
                throw new Exception("请确定给定的图层是线类型。");

            DataTable dtResult = new HistoryTrakings.TrackingDataTableStruct();
           // List<Point> oResult = new List<Point>();
            Recordset oRecords = vectorLayer.Records;
            DateTime tCurTime = DateTime.Now;
            int iCounter = 1;
            int iGeoId = 0;

            oRecords.MoveFirst();          
            while (!oRecords.EOF)
            {
                Line oCurGeometry = oRecords.Fields.Item("shape").Value as Line;
                iGeoId++;

                if (oCurGeometry != null)
                {
                    short iPartsCount = oCurGeometry.Parts.Count;

                    for (int i = 0; i < iPartsCount; i++)
                    {
                        Points oPoints = oCurGeometry.Parts.Item(i) as Points;

                        for (int j = 0; j < oPoints.Count; j++)
                        {
                            if (iCounter <= needPointsCount)
                            {
                                DataRow dr = dtResult.NewRow();
                                tCurTime = tCurTime.AddSeconds(interVal);

                                dr["geoid"] = iGeoId.ToString();
                                dr["x"] = (oPoints.Item(j) as Point).X;
                                dr["y"] = (oPoints.Item(j) as Point).Y;
                                dr["currenttime"] = tCurTime;
                                dtResult.Rows.Add(dr);

                                iCounter++;
                            }
                            else
                            {
                                return dtResult;
                            }
                        }
                    }
                }

                oRecords.MoveNext();
            }

            return dtResult;
        }

       #endregion
    }
}

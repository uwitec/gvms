using System;
using System.Collections.Generic;
using System.Text;

namespace GPSTrackingMonitor.TrackingReplay
{
    public class ReplayOperation
    {
        private int _index = 0;
        private AxMapObjects2.AxMap _mapControl;
        private MapObjects2.TrackingLayer _trackingLayer;
        private int _trackingLineSymbolIndex;
        private int _trackingPointSymbolIndex;
        private MapObjects2.GeoEvent _trackingLineEvent;
        private MapObjects2.GeoEvent _trackingPointEvent;
        private MapObjects2.Line _trackingLine = new MapObjects2.LineClass();
        private MapUtil.MapOperation _mapOper = new GPSTrackingMonitor.MapUtil.MapOperation();
        private bool _isAddedSymbols = false;

        public ReplayOperation(AxMapObjects2.AxMap mapControl)
        {
            this._mapControl = mapControl;
            this._trackingLayer = mapControl.TrackingLayer; 
            this.AddEventSymbols();

            this._trackingPointSymbolIndex = this._trackingLayer.SymbolCount - 1;
            this._trackingLineSymbolIndex = this._trackingLayer.SymbolCount - 2;
        }

        public bool ReplayTrackings(TrackingReplay.TrackPoint curCarInfos,bool isMoveToMapView)
        {
            MapObjects2.Point oCarLocation = new MapObjects2.PointClass();
            bool bResult = true;

            try
            {
                oCarLocation.X = curCarInfos.X;
                oCarLocation.Y = curCarInfos.Y;

                if (this._index == 0)
                { 
                    this._trackingPointEvent = this._trackingLayer.AddEvent(oCarLocation, this._trackingPointSymbolIndex);

                    this._index++;
                    return bResult;
                }
                
                this._trackingPointEvent.MoveTo(oCarLocation.X, oCarLocation.Y);

                this._index++;
            }
            catch
            {
                bResult = false;
            }
            finally
            {
                oCarLocation = null;
            }

            return bResult;
        }

        public void AddTrackingPath(MapObjects2.Line trackingPath)
        {
            this._trackingLineEvent = this._trackingLayer.AddEvent(trackingPath, this._trackingLineSymbolIndex);
        }

        public void AddTrackingPath(TrackPoints pointsInTrackingPath)
        {
            MapObjects2.Line oTrackingPath = new MapObjects2.LineClass();

            MapObjects2.Points oPoints = new MapObjects2.PointsClass();

            foreach (TrackPoint item in pointsInTrackingPath)
            {
                MapObjects2.Point oPoint = new MapObjects2.PointClass();
                oPoint.X = item.X;
                oPoint.Y = item.Y;

                oPoints.Add(oPoint);
            }

            oTrackingPath.Parts.Add(oPoints);

            this.AddTrackingPath(oTrackingPath);
        }

        public void ClearTrackings(bool isRemoveSymbols)
        {
            this._index = 0;

            if (this._isAddedSymbols && isRemoveSymbols)
                this._trackingLayer.SymbolCount -= 2;

            if (this._trackingLineEvent != null && this._trackingLayer.get_Event(this._trackingLineEvent.index) != null)
                this._trackingLayer.RemoveEvent(this._trackingLineEvent.index);

            if (this._trackingPointEvent != null && this._trackingLayer.get_Event(this._trackingPointEvent.index) != null)
                this._trackingLayer.RemoveEvent(this._trackingPointEvent.index);

            this._trackingLineEvent = null;
            this._trackingPointEvent = null;
        }

        private void AddEventSymbols()
        {
            if (this._trackingLayer == null)
                return;

            this._trackingLayer.SymbolCount += 2;
            this._isAddedSymbols = true;

            int iSymbolCount = this._trackingLayer.SymbolCount;
         
            this._trackingLayer.get_Symbol(iSymbolCount - 2).SymbolType = MapObjects2.SymbolTypeConstants.moLineSymbol;
            this._trackingLayer.get_Symbol(iSymbolCount - 2).Style =(short)MapObjects2.LineStyleConstants.moDashLine;
            this._trackingLayer.get_Symbol(iSymbolCount - 2).Color = (uint)MapObjects2.ColorConstants.moRed;
            this._trackingLayer.get_Symbol(iSymbolCount - 2).Size = 2;
           
            this._trackingLayer.get_Symbol(iSymbolCount - 1).SymbolType = MapObjects2.SymbolTypeConstants.moPointSymbol;
            this._trackingLayer.get_Symbol(iSymbolCount - 1).Style =(short)MapObjects2.MarkerStyleConstants.moTrueTypeMarker;
            this._trackingLayer.get_Symbol(iSymbolCount - 1).Color = (uint)MapObjects2.ColorConstants.moYellow;
            this._trackingLayer.get_Symbol(iSymbolCount - 1).Font.Name = "ESRI Transportation & Civic";
            this._trackingLayer.get_Symbol(iSymbolCount - 1).Size = 25;
            this._trackingLayer.get_Symbol(iSymbolCount - 1).CharacterIndex = 106;
        }
        
    }
}

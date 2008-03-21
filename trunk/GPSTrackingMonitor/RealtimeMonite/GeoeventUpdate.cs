using System;
using System.Collections.Generic;
using System.Text;

namespace GPSTrackingMonitor.RealtimeMonite
{
    class GeoeventUpdate
    {
        #region fields

        private AxMapObjects2.AxMap _mapControl;
        private MapObjects2.TrackingLayer _trackingLayer;
        private int _carSymbolIndex = 0;

        #endregion

        #region properties

        public AxMapObjects2.AxMap MapControl
        {
            get { return this._mapControl; }
            set { this._mapControl = value; }
        }

        #endregion

        #region constructors

        public GeoeventUpdate(AxMapObjects2.AxMap mapControl)
        {
            this._mapControl = mapControl;
            this._trackingLayer = this._mapControl.TrackingLayer;
            this.InitCarSymbols();
        }

        #endregion

        #region public methods

        public void UpdateCarLocation(GPSTrackingMonitor.Communications.MessagePool trackingMessagePool)
        {
            MapObjects2.Point oCarLocation = new MapObjects2.PointClass();
            MapObjects2.GeoEvent oGeoevent = null;

            GPSTrackingMonitor.Communications.MessagePool.ValueCollection oTrackingMessages = trackingMessagePool.Values;

            foreach (CommnicationMessage.GPSTrackingMessage oTrackingMessage in oTrackingMessages)
            {
                oCarLocation.X = oTrackingMessage.X;
                oCarLocation.Y = oTrackingMessage.Y;

                oGeoevent = this._trackingLayer.FindEvent(oTrackingMessage.CarNumber);

                if (oGeoevent == null)
                {
                  //  this.AddCustomSymbol(oTrackingMessage.CarNumber);
                    oGeoevent = this._trackingLayer.AddEvent(oCarLocation, this._carSymbolIndex);
                    oGeoevent.Tag = oTrackingMessage.CarNumber;
                }
                else
                {
                    if (oGeoevent.X == oTrackingMessage.X && oGeoevent.Y == oTrackingMessage.Y)
                        continue;

                    oGeoevent.MoveTo(oTrackingMessage.X, oTrackingMessage.Y);
                }
            }

            this._trackingLayer.Refresh(true, this._mapControl.Extent);
        }

        public void UpdateLabelLocation(GPSTrackingMonitor.Communications.MessagePool trackingMessagePool)
        {
            if (trackingMessagePool == null || trackingMessagePool.Count == 0) return;

            MapObjects2.Point oCarLocation = new MapObjects2.PointClass();

            MapObjects2.TextSymbol oLabelSymbol = new MapObjects2.TextSymbolClass();
            oLabelSymbol.Font.Name = "Arial";
            oLabelSymbol.Font.Size = 8;
            oLabelSymbol.Color = (uint)MapObjects2.ColorConstants.moYellow;
            oLabelSymbol.HorizontalAlignment = MapObjects2.AlignmentConstants.moAlignCenter;
            oLabelSymbol.VerticalAlignment = MapObjects2.AlignmentConstants.moAlignCenter;

            int iGeoEventCount = this._trackingLayer.EventCount;
            MapObjects2.GeoEvent oGeoEvent = null;
            double dVerticalOffset = this._mapControl.ToMapDistance(10f);

            for (int i = 0; i < iGeoEventCount; i++)
            {
                oGeoEvent = this._trackingLayer.get_Event(i);

                oCarLocation.X = oGeoEvent.X;
                oCarLocation.Y = oGeoEvent.Y + dVerticalOffset;

                this._mapControl.DrawText(oGeoEvent.Tag, oCarLocation, oLabelSymbol);
            }
        }

        #endregion

        #region private methods

        private void InitCarSymbols()
        {
            this._trackingLayer.SymbolCount += 1;
            this._carSymbolIndex = this._trackingLayer.SymbolCount -1;
            
            this._trackingLayer.get_Symbol(this._carSymbolIndex).SymbolType = MapObjects2.SymbolTypeConstants.moPointSymbol;
            this._trackingLayer.get_Symbol(this._carSymbolIndex).Style = (short)MapObjects2.MarkerStyleConstants.moTrueTypeMarker;
            this._trackingLayer.get_Symbol(this._carSymbolIndex).Color = (uint)MapObjects2.ColorConstants.moRed;
            this._trackingLayer.get_Symbol(this._carSymbolIndex).Font.Name = "ESRI Transportation & Civic";
            this._trackingLayer.get_Symbol(this._carSymbolIndex).Size = 25;
            this._trackingLayer.get_Symbol(this._carSymbolIndex).CharacterIndex = 106;
        }

        private void AddCustomSymbol(string carNumber)
        {
            this._trackingLayer.SymbolCount += 1;
            this._carSymbolIndex = this._trackingLayer.SymbolCount - 1;

            this._trackingLayer.get_Symbol(this._carSymbolIndex).CenterOnAscent = true;
            RealtimeMonite.CustomSymbol oCustomSymbol =  new RealtimeMonite.CustomSymbol("ESRI Transportation & Civic","Arial", 35,9,106,carNumber);
            oCustomSymbol.SymbolColor = System.Drawing.Color.Red;

            this._trackingLayer.get_Symbol(this._carSymbolIndex).Custom = oCustomSymbol;
        }
        
        #endregion
    }
}

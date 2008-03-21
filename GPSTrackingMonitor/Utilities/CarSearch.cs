using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MapObjects2;

namespace GPSTrackingMonitor.Utilities
{
    public class CarSearch
    {
        private DataTable _realtimeCarInfos;

        public CarSearch(DataTable realtimeCarInfos)
        {
            this._realtimeCarInfos = realtimeCarInfos;
        }

        public DataTable SearchByCarNumber(string carNumber,bool isAllMatched)
        {
            if (this._realtimeCarInfos == null || this._realtimeCarInfos.Rows.Count == 0)
                return null;

            if (string.IsNullOrEmpty(carNumber))
                return this._realtimeCarInfos;

            string sFilter = "";

            if(isAllMatched) sFilter = string.Format("CarNumber='{0}'",carNumber);
            else sFilter = string.Format("CarNumber like '%{0}%'",carNumber);

            DataRow[] drResult = this._realtimeCarInfos.Select(sFilter, "carnumber desc");
            DataTable dtResult = new RealtimeMonite.TrackingDataTableStruct();

            if (drResult != null && drResult.Length != 0)
            {
                foreach (DataRow dr in drResult)
                {
                    dtResult.Rows.Add(dr.ItemArray);
                }
            }

            return dtResult;
        }

        public DataTable SearchByCarLocation(Point centerPoint, double searchRaduis)
        {
            DataTable dtResult = new RealtimeMonite.TrackingDataTableStruct();
            Point oCarLocation = new PointClass();
            MapUtil.MapOperation oMapOper = new GPSTrackingMonitor.MapUtil.MapOperation();

            foreach (DataRow dr in this._realtimeCarInfos.Rows)
            {
                oCarLocation.X = Convert.ToDouble(dr["x"]);
                oCarLocation.Y = Convert.ToDouble(dr["y"]);

                if (oMapOper.ComputeDistance(centerPoint, oCarLocation) <= searchRaduis)
                    dtResult.Rows.Add(dr.ItemArray);
            }
            
            return dtResult;
        }

        public DataTable SearchByCustomFilter(string queryFilter)
        {
            if (this._realtimeCarInfos == null || this._realtimeCarInfos.Rows.Count == 0)
                return null;

            if (string.IsNullOrEmpty(queryFilter))
                return this._realtimeCarInfos;

            DataTable dtResult = null;
            try
            {
                DataRow[] drResult = this._realtimeCarInfos.Select(queryFilter, "carnumber desc");
                dtResult = new RealtimeMonite.TrackingDataTableStruct();

                if (drResult != null && drResult.Length != 0)
                {
                    foreach (DataRow dr in drResult)
                    {
                        dtResult.Rows.Add(dr.ItemArray);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return dtResult;
        }
    }

    
}

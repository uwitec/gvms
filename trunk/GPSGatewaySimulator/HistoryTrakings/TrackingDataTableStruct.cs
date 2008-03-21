using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GPSGatewaySimulator.HistoryTrakings
{
    class TrackingDataTableStruct:DataTable
    {
        #region constructors

        public TrackingDataTableStruct()
        {
            DataColumn colGeoId = new DataColumn("GeoId", typeof(string));
            colGeoId.Caption = "GeoId";

            DataColumn colCarNumber = new DataColumn("CarNumber", typeof(string));
            colCarNumber.Caption = "车牌号";

            DataColumn colPhone = new DataColumn("Phone", typeof(string));
            colPhone.Caption = "联系电话";

            DataColumn colX = new DataColumn("X",typeof(double));
            colX.Caption = "X 坐标";

            DataColumn colY = new DataColumn("Y", typeof(double));
            colY.Caption = "Y 坐标";

            DataColumn colDirection = new DataColumn("Direction", typeof(double));
            colDirection.Caption = "行驶方向";

            DataColumn colCurrentTime = new DataColumn("CurrentTime", typeof(DateTime));
            colCurrentTime.Caption = "当前时间";

            DataColumn colOrderIndex = new DataColumn("OrderIndex", typeof(int));
            colOrderIndex.Caption = "消息编号";

            this.Columns.AddRange(new DataColumn[] { colGeoId,colCarNumber,colPhone,colX, colY,colDirection,colCurrentTime,colOrderIndex });
        }

        #endregion

    }
}

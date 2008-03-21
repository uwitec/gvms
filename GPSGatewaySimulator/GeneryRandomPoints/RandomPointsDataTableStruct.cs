using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GPSGatewaySimulator.RandomPoints
{   
    public class RandomPointsDataTableStruct:System.Data.DataTable
    {
        public RandomPointsDataTableStruct()
        {
            DataColumn colGeoId = new DataColumn("GeoId", typeof(string));
            colGeoId.Caption = "GeoId";

            DataColumn colX = new DataColumn("X",typeof(double));
            colX.Caption = "X зјБъ";

            DataColumn colY = new DataColumn("Y", typeof(double));
            colY.Caption = "Y зјБъ";


            this.Columns.AddRange(new DataColumn[] { colGeoId,colX, colY });
        }
    }
}

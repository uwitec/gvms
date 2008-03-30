using System;
using System.Collections.Generic;
using System.Text;

namespace MapConfigure
{
    class GlobeVariables
    {
       //public static List<MapUtil.LayerInformations> LayersInformationSet = new List<MapUtil.LayerInformations>();

        public static MapUtil.MapOperationType CurrentOperation = new MapConfigure.MapUtil.MapOperationType();

        public static AxMapObjects2.AxMap MapControl = null;

        public static ProjectUtil.MapStruct MapInfosCollection = new MapConfigure.ProjectUtil.MapStruct();

    }
}

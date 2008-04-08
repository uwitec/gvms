using System;
using System.Collections.Generic;
using System.Text;

namespace MapProject
{
    [Serializable]
    public enum RenderType
    {
        NoneRender = -1,
        GroupRender = 0,
        ValueRender = 1,
        ClassBreakRender = 2,
        SingleRender = 3,
        ChartRender = 4,
        LabelRender = 5,
    }
}

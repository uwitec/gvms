using System;
using System.Collections.Generic;
using System.Text;

namespace MapProject
{
    [Serializable]
    public class RenderStruct
    {
        private RenderType _layerRenderType = RenderType.NoneRender;
        private object _render = null;
    }
}

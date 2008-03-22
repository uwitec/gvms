using System;
using System.Collections.Generic;
using System.Text;
using MapObjects2;

namespace MapConfigure.MapUtil
{
    class LayerStyles
    {
        private ProjectUtil.RenderType _layerRenderType = MapConfigure.ProjectUtil.RenderType.NoneRender;
        private LayerInformations _layerInfos = new LayerInformations();
        private object _render = null;
        private Symbol _layerSymbol;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MapConfigure.ProjectUtil
{
    [Serializable]
    public class GroupRenderStruct : IRenderStruct
    {
        #region fields

        private int _count = 0;
        private bool _drawBackground = false;
        private string _tag = string.Empty;
        private List<IRenderStruct> _renderList = new List<IRenderStruct>();

        #endregion

        #region properties

        public List<IRenderStruct> RenderList
        {
            get { return this._renderList; }
            set { this._renderList = value; }
        }

        public int Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        public bool DrawBackground
        {
            get { return this._drawBackground; }
            set { this._drawBackground = value; }
        }

        public string Tag
        {
            get { return this._tag; }
            set { this._tag = value; }
        }

        #endregion

        #region IRenderStruct ≥…‘±

        public RenderType LayerRenderType
        {
            get
            {
                return RenderType.GroupRender;
            }
        }

        #endregion
    }
}

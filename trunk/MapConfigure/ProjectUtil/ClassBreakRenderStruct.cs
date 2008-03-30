using System;
using System.Collections.Generic;
using System.Text;

namespace MapConfigure.ProjectUtil
{
    [Serializable]
    public class ClassBreakRenderStruct :IRenderStruct
    {
        #region fields

        private short _breakCount = 0;
        private bool _drawBackground = false;
        private string _field = string.Empty;
        private short _symbolType = 0;
        private string _tag = string.Empty;
        private List<SymbolStruct> _symbolList = new List<SymbolStruct>();
        private List<double> _breakList = new List<double>();
        private System.Drawing.Color _startColor = System.Drawing.Color.Black;
        private System.Drawing.Color _endColor = System.Drawing.Color.Black;

        #endregion

        #region properties

        public short BreakCount
        {
            get { return this._breakCount; }
            set { this._breakCount = value; }
        }

        public bool DrawBackground
        {
            get { return this._drawBackground; }
            set { this._drawBackground = value; }
        }

        public string Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        public short SymbolType
        {
            get { return this._symbolType; }
            set { this._symbolType = value; }
        }

        public string Tag
        {
            get { return this._tag; }
            set { this._tag = value;}
        }

        public List<SymbolStruct> SymbolList
        {
            get { return this._symbolList; }
            set { this._symbolList = value; }
        }

        public List<double> BreakList
        {
            get { return this._breakList; }
            set { this._breakList = value; }
        }

        public System.Drawing.Color StartColor
        {
            get { return StartColor; }
            set { this._startColor = value; }
        }

        public System.Drawing.Color EndColor
        {
            get { return this._endColor; }
            set { this._endColor = value; }
        }

        #endregion

        #region IRenderStruct ≥…‘±

        public RenderType LayerRenderType
        {
            get { return RenderType.ClassBreakRender; }
        }

        #endregion
    }
}

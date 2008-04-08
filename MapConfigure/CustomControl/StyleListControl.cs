using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MapProject;

namespace MapConfigure.CustomControl
{
    public partial class StyleListControl : DataGridView
    {
        private MapLayerInfoStruct _layerStruct = null;
        private DataTable _dataSource = null;

        public StyleListControl()
        {
            InitializeComponent();
        }

        public StyleListControl(MapLayerInfoStruct layerInfos)
        {
            InitializeComponent();

            this._layerStruct = layerInfos;
            InitGridView();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            // TODO: 在此处添加自定义绘制代码

            // 调用基类 OnPaint
            base.OnPaint(pe);
        }

        public MapLayerInfoStruct LayerInfos
        {
            get { return this._layerStruct; }
            set { this._layerStruct = value; }
        }

        private void InitGridView()
        {
            if (this._layerStruct == null)
            {
                throw new Exception("Please set a value to Property 'LayerInfos',before use this control");
            }

            this._dataSource = new StyleListTableTemplate();
            this.DataSource = this._dataSource;
            foreach (DataColumn col in this._dataSource.Columns)
            {
                DataGridViewColumn oViewCol = this.Columns[col.ColumnName];
                oViewCol.HeaderText = col.Caption;

                if (oViewCol.Name == "SymbolColor")
                {
                    oViewCol.CellTemplate = new DataGridViewButtonCell();
                }
                else if (oViewCol.Name == "Value")
                {
                    oViewCol.CellTemplate = new DataGridViewTextBoxCell();
                }
            }

            List<SymbolStruct> oSymbolList = null;
            if (this._layerStruct.Render.LayerRenderType == RenderType.ClassBreakRender)
                oSymbolList = (this._layerStruct.Render as ClassBreakRenderStruct).SymbolList;
            else if (this._layerStruct.Render.LayerRenderType == RenderType.ValueRender)
                oSymbolList = (this._layerStruct.Render as ValueRenderStruct).SymbolList;

            
            foreach (SymbolStruct oSymbol in oSymbolList)
            {
                DataRow drNew = this._dataSource.NewRow();

                System.Windows.Forms.Button btnSymbolColor = new Button();
                btnSymbolColor.BackColor = oSymbol.FillColor;
                btnSymbolColor.FlatStyle = FlatStyle.Flat;

                drNew["SymbolColor"] = oSymbol.FillColor;
                drNew["Value"] = 0;
            }
        }
    }
}

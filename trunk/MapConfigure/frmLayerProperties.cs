using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MapProject;

namespace MapConfigure
{
    public partial class frmLayerProperties : Form
    {
        #region fields
        private AxMapObjects2.AxMap _mapControl = null;
        private MapObjects2.MapLayer _mapLayer = null;
        private MapObjects2.ImageLayer _imageLayer = null;
        private List<string> _numFieldsList = new List<string>();
        private List<string> _fieldsList = new List<string>();
        private ILayerStruct _layerStruct = null;
        private Font _selectedFont = new Font("Arial",12f);
        private int _selectedCharactorIndex = 0;

        #endregion

        #region events

        public frmLayerProperties(AxMapObjects2.AxMap mapControl, object layer)
        {
            InitializeComponent();

            this._mapControl = mapControl;

            if (layer == null)
                throw new Exception("layer is null,please set a valid layer.");

            if (layer is MapObjects2.ImageLayer)
                this._imageLayer = layer as MapObjects2.ImageLayer;
            else if (layer is MapObjects2.MapLayer)
                this._mapLayer = layer as MapObjects2.MapLayer;


            if (this._mapLayer != null)
            {
                int iColumnsCount = this._mapLayer.Records.TableDesc.FieldCount;
                string sFieldName = string.Empty;
                this._fieldsList.Clear();
                this._numFieldsList.Clear();

                for (short i = 0; i < iColumnsCount; i++)
                {
                    sFieldName = this._mapLayer.Records.TableDesc.get_FieldName(i);
                    MapObjects2.Field oField = this._mapLayer.Records.Fields.Item(sFieldName);
                    this._fieldsList.Add(oField.Name);

                    if (oField.Type == MapObjects2.FieldTypeConstants.moDouble || oField.Type == MapObjects2.FieldTypeConstants.moLong)
                        this._numFieldsList.Add(oField.Name);
                }
            }

        }

        private void frmLayerProperties_Load(object sender, EventArgs e)
        {   
            this.InitPars();
        }

        private void pnlSymbolColor_Click(object sender, EventArgs e)
        {
            this.pnlSymbolColor.BackColor = this.GetSelectedColor(this.pnlSymbolColor.BackColor);
        }

        private void pnlSymbolOutlineColor_Click(object sender, EventArgs e)
        {
            this.pnlSymbolOutlineColor.BackColor = this.GetSelectedColor(this.pnlSymbolOutlineColor.BackColor);
        }

        private void pnlStartColor_Click(object sender, EventArgs e)
        {
            this.pnlStartColor.BackColor = this.GetSelectedColor(this.pnlStartColor.BackColor);
        }

        private void pnlEndColor_Click(object sender, EventArgs e)
        {
            this.pnlEndColor.BackColor = this.GetSelectedColor(this.pnlEndColor.BackColor);
        }

        private void pnlLabelColor_Click(object sender, EventArgs e)
        {
            this.pnlLabelColor.BackColor = this.GetSelectedColor(this.pnlLabelColor.BackColor);
        }

        private void btnFontBrowser_Click(object sender, EventArgs e)
        {
            FontDialog oFontDialog = new FontDialog();

            oFontDialog.AllowSimulations = true;
            oFontDialog.AllowVectorFonts = true;
            oFontDialog.AllowVerticalFonts = true;
            oFontDialog.ShowApply = false;
            oFontDialog.ShowColor = false;
            oFontDialog.ShowEffects = false;

            if (oFontDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtFont.Text = oFontDialog.Font.Name;
            }
        }

        private void cbbSymbolStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSymbolStyle.SelectedItem.ToString() == MapObjects2.MarkerStyleConstants.moTrueTypeMarker.ToString())
            {
                frmTruetypeSymbolSelection frmSymbol = new frmTruetypeSymbolSelection();
                frmSymbol.Show();
            }
        }

        private void btnApplicateSets_Click(object sender, EventArgs e)
        {
            this._mapLayer.Tag = string.Format("{0}-{1}", this.numMinScale.Value, this.numMaxScale.Value);
            this._mapLayer.Name = this.txtLayerAliasName.Text;
            this.ApplicateSymbolSetToLayer();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.ApplicateSymbolSetToLayer();
            this.DialogResult = DialogResult.OK;
        }

        private void btnUniqueValueRender_Click(object sender, EventArgs e)
        {
            this.ApplicateUniqueValueRenderToLayer();
        }

        private void btnClassBreakRender_Click(object sender, EventArgs e)
        {
            this.ApplicationClassBreaksRenderToLayer();
        }

        private void btnLabelRender_Click(object sender, EventArgs e)
        {
            this.ApplicationLabelRenderToLayer();
        }

        private void btnGroupRender_Click(object sender, EventArgs e)
        {
            this.ApplicationGroupRenderToLayer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        #endregion

        #region methods

        private void InitPars()
        {
            this._layerStruct = GlobeVariables.MapInfosCollection.FindLayer(this._mapLayer.Name);

            if (this._layerStruct == null) throw new Exception("The layer '" + this._mapLayer.Name + "' didn't found.");

            this.InitLayerDescriptionTab();
            this.InitLayerSymbolTab();
            this.InitLayerRenderTab();
        }

        private void InitLayerDescriptionTab()
        {
            this.lblGeometryTypeValue.Text = this._mapLayer.shapeType.ToString();
            this.lblCoordinateSystemValue.Text = this._mapLayer.CoordinateSystem.ToString();
            this.lblFeaturesCountValue.Text = this._mapLayer.Records.Count.ToString();
            this.numMinScale.Value = decimal.Parse(this._mapLayer.Tag.Split('-')[0]);
            this.numMaxScale.Value = decimal.Parse(this._mapLayer.Tag.Split('-')[1]);
            this.txtLayerAliasName.Text = this._mapLayer.Name;

            LayerProperties.FieldsStructTableTemplate oDataSource = new MapConfigure.LayerProperties.FieldsStructTableTemplate();
            this.dgvFieldsStruct.DataSource = oDataSource;

            foreach (DataColumn col in oDataSource.Columns)
            {   
                DataGridViewColumn oViewCol = dgvFieldsStruct.Columns[col.ColumnName];
                oViewCol.HeaderText = col.Caption;
            }

            short iColumnsCount = this._mapLayer.Records.TableDesc.FieldCount;

            for (short i = 0; i < iColumnsCount; i++)
            {
                DataRow drNew = oDataSource.NewRow();

                drNew["FieldName"] = this._mapLayer.Records.TableDesc.get_FieldName(i);
                drNew["FieldLength"] = (int)this._mapLayer.Records.TableDesc.get_FieldLength(i);
                drNew["FieldType"] = this._mapLayer.Records.TableDesc.get_FieldType(i).ToString();

                oDataSource.Rows.Add(drNew);
            }
        }

        private void InitLayerSymbolTab()
        {
            if (this._mapLayer.LayerType == MapObjects2.LayerTypeConstants.moMapLayer)
            {
                //ProjectUtil.MapLayerInfoStruct oMapLayerStruct = this._layerStruct as ProjectUtil.MapLayerInfoStruct;
                this.cbbSymbolStyle.Items.Clear();
                this.ckbIsViewOutline.Visible = false;
                this.grpSymbolOutlineProperties.Visible = false;
                this.numSymbolSize.Value = this._mapLayer.Symbol.Size;
                this.pnlSymbolColor.BackColor = Utilities.Converter.ConvertIntegerToSystemColor((int)this._mapLayer.Symbol.Color);

                if (this._mapLayer.shapeType == MapObjects2.ShapeTypeConstants.moShapeTypePoint)
                {
                    this.cbbSymbolStyle.Items.Add(MapObjects2.MarkerStyleConstants.moCircleMarker.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.MarkerStyleConstants.moCrossMarker.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.MarkerStyleConstants.moSquareMarker.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.MarkerStyleConstants.moTriangleMarker.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.MarkerStyleConstants.moTrueTypeMarker.ToString());

                    this.cbbSymbolStyle.Text =  ((MapObjects2.MarkerStyleConstants)this._mapLayer.Symbol.Style).ToString();
                }
                else if (this._mapLayer.shapeType == MapObjects2.ShapeTypeConstants.moShapeTypeLine)
                {
                    this.cbbSymbolStyle.Items.Add(MapObjects2.LineStyleConstants.moDashDotDotLine.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.LineStyleConstants.moDashDotLine.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.LineStyleConstants.moDashLine.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.LineStyleConstants.moDotLine.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.LineStyleConstants.moSolidLine.ToString());

                    this.cbbSymbolStyle.Text = ((MapObjects2.LineStyleConstants)this._mapLayer.Symbol.Style).ToString();
                }
                else if (this._mapLayer.shapeType == MapObjects2.ShapeTypeConstants.moShapeTypePolygon)
                {
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moCrossFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moDarkGrayFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moDiagonalCrossFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moDownwardDiagonalFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moGrayFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moHorizontalFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moLightGrayFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moSolidFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moTransparentFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moUpwardDiagonalFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moVerticalFill.ToString());

                    this.ckbIsViewOutline.Visible = true;
                    this.numSymbolSize.Visible = false;
                    this.grpSymbolOutlineProperties.Visible = this.ckbIsViewOutline.Checked;
                    this.numSymbolOutlineSize.Value = (decimal)this._mapLayer.Symbol.Size;
                    this.pnlSymbolOutlineColor.BackColor = Utilities.Converter.ConvertIntegerToSystemColor((int)this._mapLayer.Symbol.OutlineColor);
                    this.cbbSymbolStyle.Text = ((MapObjects2.FillStyleConstants)this._mapLayer.Symbol.Style).ToString();
                }
            }
        }

        private void InitLayerRenderTab()
        {
            for (int i = 0; i < 20; i++) this.cbbNumber_ClassBreakRender.Items.Add(i);
            foreach (string sField in this._numFieldsList) this.cbbFields_ClassBreakRender.Items.Add(sField);
            foreach (string sField in this._fieldsList)
            {
                this.cbbLabelField.Items.Add(sField);
                this.cbbFields_UniqueValue.Items.Add(sField);
            }

            this.cbbLabelHorizonalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignBaseline);
           // this.cbbLabelHorizonalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignBottom);
          //  this.cbbLabelHorizonalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignCenter);
            this.cbbLabelHorizonalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignLeft);
            this.cbbLabelHorizonalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignRight);
           // this.cbbLabelHorizonalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignTop);

            this.cbbLabelVerticalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignBaseline);
            this.cbbLabelVerticalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignBottom);
            this.cbbLabelVerticalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignCenter);
          //  this.cbbLabelVerticalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignLeft);
           // this.cbbLabelVerticalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignRight);
            this.cbbLabelVerticalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignTop);

            if (this._mapLayer.Renderer == null) return;

            if (this._mapLayer.Renderer is MapObjects2.ValueMapRenderer)
            {
                this.InitUniqueValueRenderLab(this._mapLayer.Renderer as MapObjects2.ValueMapRenderer);
            }
            else if (this._mapLayer.Renderer is MapObjects2.ClassBreaksRenderer)
            {
                this.InitClassBreaksRenderLab(this._mapLayer.Renderer as MapObjects2.ClassBreaksRenderer);
            }
            else if (this._mapLayer.Renderer is MapObjects2.LabelRenderer)
            {
                this.InitLabelRenderLab(this._mapLayer.Renderer as MapObjects2.LabelRenderer);
            }
            else if (this._mapLayer.Renderer is MapObjects2.GroupRenderer)
            {
                this.InitGroupRenderLab(this._mapLayer.Renderer as MapObjects2.GroupRenderer);
            }
        }

        private void InitClassBreaksRenderLab(MapObjects2.ClassBreaksRenderer render)
        {
            this.cbbFields_ClassBreakRender.Text = render.Field;
            this.cbbNumber_ClassBreakRender.Text = render.BreakCount.ToString();
            this.pnlStartColor.BackColor = Utilities.Converter.ConvertIntegerToSystemColor((int)render.get_Symbol(0).Color);
            this.pnlEndColor.BackColor = Utilities.Converter.ConvertIntegerToSystemColor((int)render.get_Symbol((short)(render.BreakCount - 1)).Color);
        }

        private void InitUniqueValueRenderLab(MapObjects2.ValueMapRenderer render)
        {
            this.cbbFields_UniqueValue.Text = (render as MapObjects2.ValueMapRenderer).Field;
        }

        private void InitLabelRenderLab(MapObjects2.LabelRenderer render)
        {
            this.cbbLabelField.Text = render.Field;
            this.txtFont.Text = render.get_Symbol(0).Font.Name;
            this.pnlLabelColor.BackColor = Utilities.Converter.ConvertIntegerToSystemColor((int)render.get_Symbol(0).Color);
            this.cbbLabelHorizonalAligment.Text = (render.get_Symbol(0).HorizontalAlignment).ToString();
            this.cbbLabelVerticalAligment.Text = (render.get_Symbol(0).VerticalAlignment).ToString();
            this.numLabelSize.Value = render.get_Symbol(0).Font.Size;
            this.numLabelRotation.Value = (decimal)render.get_Symbol(0).Rotation;
            this.ckbAllowOverwrite.Checked = render.AllowDuplicates;
            this.ckbLabelScale.Checked = render.Flip;
        }

        private void InitGroupRenderLab(MapObjects2.GroupRenderer render)
        {
            if ((render).Count > 0)
            {
                object oClassBreaksRender = this.GetRenderFromGroup(render, RenderType.ClassBreakRender);
                if (oClassBreaksRender != null)
                {
                    this.ckbIsAddClassBreakRender.Checked = true;
                    InitClassBreaksRenderLab(oClassBreaksRender as MapObjects2.ClassBreaksRenderer);
                }

                object oLabelRender = this.GetRenderFromGroup(render, RenderType.LabelRender);
                if (oLabelRender != null)
                {
                    this.ckbIsAddLabelRender.Checked = true;
                    InitLabelRenderLab(oLabelRender as MapObjects2.LabelRenderer);
                }

                object oValueRender = this.GetRenderFromGroup(render, RenderType.ValueRender);
                if (oValueRender != null)
                {
                    this.ckbIsAddUniqueValueRender.Checked = true;
                    InitUniqueValueRenderLab(oValueRender as MapObjects2.ValueMapRenderer);
                }
            }
        }

        private void ApplicationDecriptionToLayer()
        {
            this._mapLayer.Name = this.txtLayerAliasName.Text;
        }

        private void ApplicateSymbolSetToLayer()
        {
            MapUtil.LayerStyles oLayerStyles = new MapConfigure.MapUtil.LayerStyles();

            this._mapLayer.Tag = this.numMinScale.Value.ToString() + "-" + this.numMaxScale.Value.ToString();

            this._mapLayer.Symbol.Color = (uint)Utilities.Converter.ConvertSystemtoIntegerColor(this.pnlSymbolColor.BackColor);
            this._mapLayer.Symbol.Size = (short)this.numSymbolSize.Value;
            this._mapLayer.Symbol.Style = oLayerStyles.GetSymbolStyleByName(this._mapLayer.shapeType, this.cbbSymbolStyle.SelectedItem.ToString());

            if (this._mapLayer.shapeType == MapObjects2.ShapeTypeConstants.moShapeTypePoint)
            {

                this._mapLayer.Symbol.CenterOnAscent = true;
                this._mapLayer.Symbol.CharacterIndex = (short)this._selectedCharactorIndex;
                this._mapLayer.Symbol.Font.Name = this._selectedFont.Name;
            }
            else if (this._mapLayer.shapeType == MapObjects2.ShapeTypeConstants.moShapeTypePolygon)
            {
                this._mapLayer.Symbol.Outline = this.ckbIsViewOutline.Checked;
                this._mapLayer.Symbol.OutlineColor = (uint)Utilities.Converter.ConvertSystemtoIntegerColor(this.pnlSymbolOutlineColor.BackColor);
            }
            this._mapControl.Refresh();
        }

        private void ApplicateUniqueValueRenderToLayer()
        {
            MapUtil.LayerStyles oLayerStyles = new MapConfigure.MapUtil.LayerStyles();

            this._mapLayer.Renderer = oLayerStyles.GetUniqueValueRender(this._mapLayer, this.cbbFields_UniqueValue.SelectedItem.ToString());

            this._mapControl.Refresh();
        }

        private void ApplicationClassBreaksRenderToLayer()
        {
            MapUtil.LayerStyles oLayerStyles = new MapConfigure.MapUtil.LayerStyles();

            this._mapLayer.Renderer = oLayerStyles.GetClassBreaksRender(this._mapLayer, this.cbbFields_ClassBreakRender.SelectedItem.ToString(),
                Int32.Parse(this.cbbNumber_ClassBreakRender.SelectedItem.ToString()), pnlStartColor.BackColor, pnlEndColor.BackColor);

            this._mapControl.Refresh();
        }

        private void ApplicationLabelRenderToLayer()
        {
            MapUtil.LayerStyles oLayerStyles = new MapConfigure.MapUtil.LayerStyles();

            this._mapLayer.Renderer = oLayerStyles.GetLabelRender
                (this.cbbLabelField.SelectedItem.ToString(), this.ckbAllowOverwrite.Checked,this.ckbLabelScale.Checked,
                0, 0, this.pnlLabelColor.BackColor, this.txtFont.Text,(double)this.numLabelSize.Value, (double)this.numLabelRotation.Value,
                oLayerStyles.GetLabelAlignmentByName(this.cbbLabelHorizonalAligment.SelectedItem.ToString()),
                oLayerStyles.GetLabelAlignmentByName(this.cbbLabelVerticalAligment.SelectedItem.ToString()));

            this._mapControl.Refresh();
        }

        private void ApplicationGroupRenderToLayer()
        {
            List<object> oRenders = new List<object>();
            MapUtil.LayerStyles oLayerStyles = new MapConfigure.MapUtil.LayerStyles();

            if (ckbIsAddUniqueValueRender.Checked)
            {
                object oUniqueRender = oLayerStyles.GetUniqueValueRender(this._mapLayer, this.cbbFields_UniqueValue.SelectedItem.ToString());

                oRenders.Add(oUniqueRender);
            }
            if (ckbIsAddClassBreakRender.Checked)
            {
                object oClassBreaksRender = oLayerStyles.GetClassBreaksRender(this._mapLayer, this.cbbFields_ClassBreakRender.SelectedItem.ToString(),
                   Int32.Parse(this.cbbNumber_ClassBreakRender.SelectedItem.ToString()), pnlStartColor.BackColor, pnlEndColor.BackColor);

                oRenders.Add(oClassBreaksRender);
            }
            if (ckbIsAddLabelRender.Checked)
            {
                object oLabelRender = oLayerStyles.GetLabelRender(this.cbbLabelField.SelectedItem.ToString(), this.ckbAllowOverwrite.Checked,
                   this.ckbLabelScale.Checked, 0, 0, this.pnlLabelColor.BackColor, this.txtFont.Text,(double)this.numLabelSize.Value, (double)this.numLabelRotation.Value,
                   oLayerStyles.GetLabelAlignmentByName(this.cbbLabelHorizonalAligment.SelectedItem.ToString()),
                   oLayerStyles.GetLabelAlignmentByName(this.cbbLabelVerticalAligment.SelectedItem.ToString()));

                oRenders.Add(oLabelRender);
            }

            if (oRenders.Count > 0)
            {
                this._mapLayer.Renderer = oLayerStyles.GetGroupRender(oRenders);
                this._mapControl.Refresh();
            }
            else
            {
                MessageBox.Show("请选择一个或多个渲染类型来进行组合.", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private object GetRenderFromGroup(MapObjects2.GroupRenderer groupRender, RenderType renderType)
        {
            short iRendererCount = groupRender.Count;

            for (short i = 0; i < iRendererCount; i++)
            {
                if ((groupRender.get_Renderer(i) is MapObjects2.ValueMapRenderer && renderType == RenderType.ValueRender)
                    || (groupRender.get_Renderer(i) is MapObjects2.ClassBreaksRenderer && renderType == RenderType.ClassBreakRender)
                    || (groupRender.get_Renderer(i) is MapObjects2.LabelRenderer && renderType == RenderType.LabelRender)
                    )
                    return groupRender.get_Renderer(i);
            }

            return null;
        }

        private Color GetSelectedColor(Color currentColor)
        {
            ColorDialog oColorDiaolog = new ColorDialog();
            oColorDiaolog.Color = currentColor;
            oColorDiaolog.AllowFullOpen = true;
            oColorDiaolog.AnyColor = true;
            oColorDiaolog.SolidColorOnly = false;

            if (oColorDiaolog.ShowDialog() == DialogResult.OK) return oColorDiaolog.Color;

            return currentColor;
        }

        #endregion

        private void ckbIsViewOutline_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbIsViewOutline.Checked == true)
            {
                this.grpSymbolOutlineProperties.Visible = true;
                this.numSymbolOutlineSize.Visible = true;
                this.pnlSymbolOutlineColor.Visible = true;
            }
            else if (this.ckbIsViewOutline.Checked == false)
            {
                this.grpSymbolOutlineProperties.Visible = false;
                this.numSymbolOutlineSize.Visible = false;
                this.pnlSymbolOutlineColor.Visible = false;
            }
        }

       
        #region old coder

        /*
        private void InitLayerDescriptionTab()
        {
            this.lblGeometryTypeValue.Text = this._mapLayer.shapeType.ToString();
            this.lblCoordinateSystemValue.Text = this._mapLayer.CoordinateSystem.ToString();
            this.lblFeaturesCountValue.Text = this._mapLayer.Records.Count.ToString();
            this.numMinScale.Value = (decimal)this._layerStruct.MinLevel;
            this.numMaxScale.Value = (decimal)this._layerStruct.MaxLevel;

            LayerProperties.FieldsStructTableTemplate oDataSource = new MapConfigure.LayerProperties.FieldsStructTableTemplate();
            this.dgvFieldsStruct.DataSource = oDataSource;

            foreach (DataColumn col in oDataSource.Columns)
            {
                DataGridViewColumn oViewCol = dgvFieldsStruct.Columns[col.ColumnName];
                oViewCol.HeaderText = col.Caption;
            }

            short iColumnsCount = this._mapLayer.Records.TableDesc.FieldCount;

            for (short i = 0; i < iColumnsCount; i++)
            {
                DataRow drNew = oDataSource.NewRow();

                drNew["FieldName"] = this._mapLayer.Records.TableDesc.get_FieldName(i);
                drNew["FieldLength"] = (int)this._mapLayer.Records.TableDesc.get_FieldLength(i);
                drNew["FieldType"] = this._mapLayer.Records.TableDesc.get_FieldType(i).ToString();

                oDataSource.Rows.Add(drNew);
            }
        }

        private void InitLayerSymbolTab()
        {
            if (this._layerStruct.LayerType == (short)MapObjects2.LayerTypeConstants.moMapLayer)
            {
                ProjectUtil.MapLayerInfoStruct oMapLayerStruct = this._layerStruct as ProjectUtil.MapLayerInfoStruct;

                this.cbbSymbolStyle.Items.Clear();
                this.ckbIsViewOutline.Visible = false;
                this.grpSymbolOutlineProperties.Visible = false;
                this.numSymbolSize.Value = oMapLayerStruct.Symbol.Size;
                this.pnlSymbolColor.BackColor = oMapLayerStruct.Symbol.FillColor;

                if (oMapLayerStruct.ShapeType == (short)MapObjects2.ShapeTypeConstants.moShapeTypePoint)
                {
                    this.cbbSymbolStyle.Items.Add(MapObjects2.MarkerStyleConstants.moCircleMarker.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.MarkerStyleConstants.moCrossMarker.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.MarkerStyleConstants.moSquareMarker.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.MarkerStyleConstants.moTriangleMarker.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.MarkerStyleConstants.moTrueTypeMarker.ToString());

                    this.cbbSymbolStyle.Text = ((MapObjects2.MarkerStyleConstants)(this._layerStruct as ProjectUtil.MapLayerInfoStruct).Symbol.Style).ToString();
                }
                else if (oMapLayerStruct.ShapeType == (short)MapObjects2.ShapeTypeConstants.moShapeTypeLine)
                {
                    this.cbbSymbolStyle.Items.Add(MapObjects2.LineStyleConstants.moDashDotDotLine.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.LineStyleConstants.moDashDotLine.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.LineStyleConstants.moDashLine.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.LineStyleConstants.moDotLine.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.LineStyleConstants.moSolidLine.ToString());

                    this.cbbSymbolStyle.Text = ((MapObjects2.LineStyleConstants)(this._layerStruct as ProjectUtil.MapLayerInfoStruct).Symbol.Style).ToString();
                }
                else if (oMapLayerStruct.ShapeType == (short)MapObjects2.ShapeTypeConstants.moShapeTypePolygon)
                {
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moCrossFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moDarkGrayFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moDiagonalCrossFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moDownwardDiagonalFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moGrayFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moHorizontalFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moLightGrayFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moSolidFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moTransparentFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moUpwardDiagonalFill.ToString());
                    this.cbbSymbolStyle.Items.Add(MapObjects2.FillStyleConstants.moVerticalFill.ToString());

                    this.ckbIsViewOutline.Visible = true;
                    this.numSymbolSize.Visible = false;
                    this.grpSymbolOutlineProperties.Visible = this.ckbIsViewOutline.Checked;
                    this.numSymbolOutlineSize.Value = oMapLayerStruct.Symbol.Size;
                    this.pnlSymbolOutlineColor.BackColor = oMapLayerStruct.Symbol.OutLineColor;
                    this.cbbSymbolStyle.Text = ((MapObjects2.FillStyleConstants)(this._layerStruct as ProjectUtil.MapLayerInfoStruct).Symbol.Style).ToString();
                }
            }
        }

        private void InitLayerRenderTab()
        {
            foreach (string sField in this._numFieldsList)
            {
                this.cbbFields_ClassBreakRender.Items.Add(sField);
                this.cbbFields_UniqueValue.Items.Add(sField);
            }

            for (int i = 0; i < 20; i++) this.cbbNumber_ClassBreakRender.Items.Add(i);
            foreach (string sField in this._fieldsList) this.cbbLabelField.Items.Add(sField);

            this.cbbLabelHorizonalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignBaseline);
            this.cbbLabelHorizonalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignBottom);
            this.cbbLabelHorizonalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignCenter);
            this.cbbLabelHorizonalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignLeft);
            this.cbbLabelHorizonalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignRight);
            this.cbbLabelHorizonalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignTop);

            this.cbbLabelVerticalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignBaseline);
            this.cbbLabelVerticalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignBottom);
            this.cbbLabelVerticalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignCenter);
            this.cbbLabelVerticalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignLeft);
            this.cbbLabelVerticalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignRight);
            this.cbbLabelVerticalAligment.Items.Add(MapObjects2.AlignmentConstants.moAlignTop);


            ProjectUtil.IRenderStruct oRenderStrcut = (this._layerStruct as ProjectUtil.MapLayerInfoStruct).Render;

            if (oRenderStrcut == null) return;

            if (oRenderStrcut.LayerRenderType == MapConfigure.ProjectUtil.RenderType.ValueRender)
            {
                this.cbbFields_UniqueValue.Text = (oRenderStrcut as ProjectUtil.ValueRenderStruct).Field.ToString();

            }
            else if (oRenderStrcut.LayerRenderType == MapConfigure.ProjectUtil.RenderType.ClassBreakRender)
            {
                this.cbbFields_ClassBreakRender.Text = (oRenderStrcut as ProjectUtil.ClassBreakRenderStruct).Field.ToString();
                this.cbbNumber_ClassBreakRender.Text = (oRenderStrcut as ProjectUtil.ClassBreakRenderStruct).BreakCount.ToString();
                this.pnlStartColor.BackColor = (oRenderStrcut as ProjectUtil.ClassBreakRenderStruct).StartColor;
                this.pnlEndColor.BackColor = (oRenderStrcut as ProjectUtil.ClassBreakRenderStruct).EndColor;
            }
            else if (oRenderStrcut.LayerRenderType == MapConfigure.ProjectUtil.RenderType.LabelRender)
            {
                this.cbbLabelField.Text = (oRenderStrcut as ProjectUtil.LabelRenderStruct).Field;
                this.txtFont.Text = (oRenderStrcut as ProjectUtil.LabelRenderStruct).SymbolList[0].TextFont.Name;
                this.pnlLabelColor.BackColor = (oRenderStrcut as ProjectUtil.LabelRenderStruct).SymbolList[0].TextColor;
                this.cbbLabelHorizonalAligment.Text = ((MapObjects2.AlignmentConstants)((oRenderStrcut as ProjectUtil.LabelRenderStruct).SymbolList[0].HorizontalAlignment)).ToString();
                this.cbbLabelVerticalAligment.Text = ((MapObjects2.AlignmentConstants)((oRenderStrcut as ProjectUtil.LabelRenderStruct).SymbolList[0].VerticalAlignment)).ToString();
                this.numLabelSize.Value = (oRenderStrcut as ProjectUtil.LabelRenderStruct).SymbolList[0].TextFont.Size;
                this.numLabelRotation.Value = (decimal)(oRenderStrcut as ProjectUtil.LabelRenderStruct).SymbolList[0].Rotation;
                this.ckbAllowOverwrite.Checked = (oRenderStrcut as ProjectUtil.LabelRenderStruct).AllowDuplicates;
                this.ckbLabelScale.Checked = (oRenderStrcut as ProjectUtil.LabelRenderStruct).Flip;
            }
            else if (oRenderStrcut.LayerRenderType == MapConfigure.ProjectUtil.RenderType.GroupRender)
            {
                if ((oRenderStrcut as ProjectUtil.GroupRenderStruct).RenderList.Count > 0)
                {
                    this.ckbIsAddClassBreakRender.Checked = this.JudgeRenderTypeInGroup(oRenderStrcut as ProjectUtil.GroupRenderStruct, MapConfigure.ProjectUtil.RenderType.ClassBreakRender);
                    this.ckbIsAddLabelRender.Checked = this.JudgeRenderTypeInGroup(oRenderStrcut as ProjectUtil.GroupRenderStruct, MapConfigure.ProjectUtil.RenderType.LabelRender);
                    this.ckbIsAddUniqueValueRender.Checked = this.JudgeRenderTypeInGroup(oRenderStrcut as ProjectUtil.GroupRenderStruct, MapConfigure.ProjectUtil.RenderType.ValueRender);
                }
            }
        }

        */
        #endregion
    }    
}
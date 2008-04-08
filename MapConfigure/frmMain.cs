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
    public partial class frmMain : Form
    {
        //private frmLegend _frmLegend;
        private frmMap _frmMap;
        private frmLegend _frmLegend;
        private frmNavigation _frmNavigation;
        // private frmCarData _frmCarData;
        // private frmTackingReplay _frmTrackingReplay;
        private bool _isSaved = false;
        private string _projectFileName = string.Empty;

        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            this._frmMap = frmMap.Instance;
            this._frmMap.Show(this.dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.Document);

            this._frmLegend = frmLegend.Instance;
            this._frmLegend.Show(this.dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);
            this._frmLegend.VisibleChanged += new EventHandler(_frmLegend_VisibleChanged);

            this._frmNavigation = frmNavigation.Instance;
            this._frmNavigation.Show(this._frmLegend.Pane, WeifenLuo.WinFormsUI.Docking.DockAlignment.Bottom, 0.3);
            this._frmNavigation.VisibleChanged += new EventHandler(_frmNavigation_VisibleChanged);

        }

        void _frmNavigation_VisibleChanged(object sender, EventArgs e)
        {
            if (this._frmNavigation.Visible)
                this.mnuIsViewMapNavigateWindow.Checked = true;
            else
                this.mnuIsViewMapNavigateWindow.Checked = false;
        }

        void _frmLegend_VisibleChanged(object sender, EventArgs e)
        {
            if (this._frmLegend.Visible)
                this.mnuIsViewLayerControlWindow.Checked = true;
            else
                this.mnuIsViewLayerControlWindow.Checked = false;
        }

        private void mnuOpenProject_Click(object sender, EventArgs e)
        {
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();

            oOpenFileDialog.Filter = "GVMS Project File(*.gvp) | *.gvp";
            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                ProjectSerialization oProjectSerilization = new ProjectSerialization();

                GlobeVariables.MapControl.Layers.Clear();
                GlobeVariables.MapInfosCollection = oProjectSerilization.LoadProjectByMapInfos(oOpenFileDialog.FileName, GlobeVariables.MapControl);

                GlobeVariables.MapControl.RefreshRect(GlobeVariables.MapControl.Extent);
                GlobeVariables.MapLegend.LoadLegend();
                this._projectFileName = oOpenFileDialog.FileName;
                this._isSaved = true;
                this.Text = "地图配置 " + this._projectFileName;
            }
        }

        private void mnuSaveProject_Click(object sender, EventArgs e)
        {
            ProjectSerialization oProjectSerialization = new ProjectSerialization();
            if (!this._isSaved)
            {
                SaveFileDialog oSaveFileDialog = new SaveFileDialog();
                oSaveFileDialog.Filter = "GVMS Project File(*.gvp) | *.gvp";
                if (oSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    oProjectSerialization.SaveMapInfosToProject(GlobeVariables.MapControl, oSaveFileDialog.FileName, GlobeVariables.MapInfosCollection);
                    this._projectFileName = oSaveFileDialog.FileName;
                    this._isSaved = true;
                    this.Text = "地图配置 " + this._projectFileName;
                }
            }
            else
            {
                oProjectSerialization.SaveMapInfosToProject(GlobeVariables.MapControl, this._projectFileName, GlobeVariables.MapInfosCollection);
                this.Text = "地图配置 " + this._projectFileName;
            }
        }

        private void mnuSaveAsProject_Click(object sender, EventArgs e)
        {
            SaveFileDialog oSaveFileDialog = new SaveFileDialog();
            oSaveFileDialog.Filter = "GVMS Project File(*.gvp) | *.gvp";
            if (oSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ProjectSerialization oProjectSerialization = new ProjectSerialization();
                oProjectSerialization.SaveMapInfosToProject(GlobeVariables.MapControl, oSaveFileDialog.FileName, GlobeVariables.MapInfosCollection);
                this._projectFileName = oSaveFileDialog.FileName;
                this._isSaved = true;
                this.Text = "地图配置 " + this._projectFileName;
            }
        }

        private void mnuAddLayers_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFileDialog = new OpenFileDialog();
            oFileDialog.Filter = "ESRI Shapefile(*.shp) | *.shp| All Support Format(*.*) | *.*";
            oFileDialog.Multiselect = true;

            if (oFileDialog.ShowDialog() == DialogResult.OK)
            {
                MapUtil.MapOperation oMapOper = new MapUtil.MapOperation();
                List<string> oLayerPaths = new List<string>(oFileDialog.FileNames);

                oMapOper.LoadLayers(oLayerPaths, GlobeVariables.MapInfosCollection, GlobeVariables.MapControl);
                frmLegend.Instance.LoadLayer();
                frmNavigation.Instance.LoadBackgroudLayer(GlobeVariables.MapInfosCollection.Layers);
            }
        }

        private void mnuIsViewLayerControlWindow_Click(object sender, EventArgs e)
        {
            mnuIsViewLayerControlWindow.Checked = !mnuIsViewLayerControlWindow.Checked;
            if (mnuIsViewLayerControlWindow.Checked)
                this._frmLegend.Show();
            else
                this._frmLegend.Hide();
        }

        private void mnuIsViewMapNavigateWindow_Click(object sender, EventArgs e)
        {
            mnuIsViewMapNavigateWindow.Checked = !mnuIsViewMapNavigateWindow.Checked;
            if (mnuIsViewMapNavigateWindow.Checked)
                this._frmNavigation.Show();
            else
                this._frmNavigation.Hide();
        }

        private void mnuSoftLicense_Click(object sender, EventArgs e)
        {
            frmLicense oFrmLicense = new frmLicense();
            oFrmLicense.ShowDialog();
        }

        private void mnuAboutUS_Click(object sender, EventArgs e)
        {
            frmAboutUS oFrmAboutUS = new frmAboutUS();
            oFrmAboutUS.ShowDialog();
        }

    }
}

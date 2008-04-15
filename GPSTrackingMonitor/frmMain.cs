using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MapProject;

namespace GPSTrackingMonitor
{
    public partial class frmMain : Form
    {
        #region fields

        private frmLegend _frmLegend;
        private frmMap _frmMap ;
        private frmNavigation _frmNavigation;
        private frmRealtimeCarInfos _frmRealtimeCarData;
        //private frmTackingReplay _frmTrackingReplay;

        #endregion

        #region constructor

        public frmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region events

        private void frmMain_Load(object sender, EventArgs e)
        { 
            this.InitWindowLayout();

            if (System.IO.File.Exists(GlobeVariables.ConfigureFileName))
                GlobeVariables.ConfigureInfos = Configures.ConfigureInfosStrcut.LoadConfigureInfos(GlobeVariables.ConfigureFileName);

            if (System.IO.File.Exists(GlobeVariables.ConfigureInfos.SystemConfigureInfos.ProjectFilePath))
                this.LoadMapProject(GlobeVariables.ConfigureInfos.SystemConfigureInfos.ProjectFilePath);

            this.StartReceiveCarMessages();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否确定需要关闭系统?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            System.Diagnostics.Process oThisProcess = System.Diagnostics.Process.GetCurrentProcess();
            oThisProcess.Kill();

                /*
              e.Cancel = false;

              GlobeVariables.CarInfosReceiver.Dispose();

              this._frmMap.Close();
              this._frmCarData.Close();
              this._frmLegend.Close();
              this._frmTrackingReplay.Close();
              this._frmNavigation.Close();


              this.dockPanel.Dispose();
              Application.ExitThread();
              Application.Exit();
                 * */
        }

        private void tlsSystemConfig_Click(object sender, EventArgs e)
        {
            frmConfigure oFormConfigure = new frmConfigure();
            oFormConfigure.ShowDialog();
        }

        private void mnuViewLegendForm_Click(object sender, EventArgs e)
        {
            this.mnuViewLegendForm.Checked = !this.mnuViewLegendForm.Checked;

            if (this.mnuViewLegendForm.Checked)
                this._frmLegend.Show();
            else
                this._frmLegend.Hide();
        }

        private void mnuViewNavigateForm_Click(object sender, EventArgs e)
        {
            this.mnuViewNavigateForm.Checked = !this.mnuViewNavigateForm.Checked;

            if (this.mnuViewNavigateForm.Checked)
                this._frmNavigation.Show();
            else
                this._frmNavigation.Hide();
        }

        private void mnuViewCarInfosForm_Click(object sender, EventArgs e)
        {
            this.mnuViewCarInfosForm.Checked = !this.mnuViewCarInfosForm.Checked;

            if (this.mnuViewCarInfosForm.Checked)
                this._frmRealtimeCarData.Show();
            else
                this._frmRealtimeCarData.Hide();

        }

        private void mnuExitSystem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        #endregion

        #region private methods

        private void InitWindowLayout()
        {
            this.IsMdiContainer = true;
            this.dockPanel.ShowDocumentIcon = true;

            this._frmMap = frmMap.Instance;
            this._frmMap.Show(this.dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.Document);

            this._frmRealtimeCarData = frmRealtimeCarInfos.Instance;
            this._frmRealtimeCarData.Show(this.dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockBottomAutoHide);

            //this._frmTrackingReplay = frmTackingReplay.Instance;
            //this._frmTrackingReplay.Show(this._frmRealtimeCarData.Pane, this._frmRealtimeCarData);

            this._frmLegend = frmLegend.Instance;
            this._frmLegend.Show(this.dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);

            this._frmNavigation = frmNavigation.Instance;
            this._frmNavigation.Show(this._frmLegend.Pane, WeifenLuo.WinFormsUI.Docking.DockAlignment.Bottom, 0.3);

            this._frmNavigation.Hide();
            this._frmLegend.Hide();
        }

        private void StartReceiveCarMessages()
        {
            GlobeVariables.CarInfosReceiver.ListenigPort = 8205;
            GlobeVariables.CarInfosReceiver.ServerIP = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName())[0].ToString();
            
            GlobeVariables.CarInfosReceiver.StartReceiveMessage();
        }

        #endregion

        private void mnuAbout_Click(object sender, EventArgs e)
        {
           
        }

        private void mnuOpenProject_Click(object sender, EventArgs e)
        {
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();

            oOpenFileDialog.Filter = "GVMS Project File(*.gvp) | *.gvp";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.LoadMapProject(oOpenFileDialog.FileName);
            }
        }

        private void LoadMapProject(string projectFileName)
        {
            ProjectSerialization oProjectSerilization = new ProjectSerialization();

            GlobeVariables.MainMapControl.Layers.Clear();
            GlobeVariables.MapInfosCollection = oProjectSerilization.LoadProjectByMapInfos(projectFileName, GlobeVariables.MainMapControl);

            GlobeVariables.MainMapControl.RefreshRect(GlobeVariables.MainMapControl.Extent);
            frmLegend.Instance.LoadLayersToLegend(GlobeVariables.MainMapControl);
            frmNavigation.Instance.LoadLayersToNavigation(GlobeVariables.MainMapControl);
        }

        private void mnuMapConfgiure_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(GlobeVariables.MapConfigureProgramPath)) System.Diagnostics.Process.Start(GlobeVariables.MapConfigureProgramPath);
            else MessageBox.Show("地图配置工具未找到，请确定配置信息是正确的。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
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

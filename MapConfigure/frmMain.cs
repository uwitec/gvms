using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MapConfigure
{
    public partial class frmMain : Form
    {
        private frmLegend _frmLegend;
        private frmMap _frmMap ;
        private frmNavigation _frmNavigation;
       // private frmCarData _frmCarData;
       // private frmTackingReplay _frmTrackingReplay;

        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            this._frmMap = frmMap.Instance;
            this._frmMap.Show(this.dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.Document);

            //this._frmCarData = new frmCarData();
            //this._frmCarData.Show(this._frmMap.Pane, WeifenLuo.WinFormsUI.Docking.DockAlignment.Bottom, 0.3);            

            //this._frmTrackingReplay = new frmTackingReplay();
            //this._frmTrackingReplay.Show(this._frmCarData.Pane, this._frmCarData); 

            this._frmLegend = frmLegend.Instance;
            this._frmLegend.Show(this.dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);

            this._frmNavigation = frmNavigation.Instance;
            this._frmNavigation.Show(this._frmLegend.Pane,WeifenLuo.WinFormsUI.Docking.DockAlignment.Bottom,0.3);
        }

    }
}

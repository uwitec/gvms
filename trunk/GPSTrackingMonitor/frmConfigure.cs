/***********************************************
* 
* 
* 
* 
* 
* 
* Use:
*      1、对当前系统中的可变参数进行配置
*      2、这些可变参数包括:信息
* 
* *********************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace GPSTrackingMonitor
{
    public partial class frmConfigure : Form
    {
        #region fields

        private Font _currentFont = null;
        private int _selectedSymbolIndex = 0;

        #endregion

        #region constructor

        public frmConfigure()
        {
            InitializeComponent();
        }

        #endregion

        #region event

        #region event - this form

        private void frmConfigure_Load(object sender, EventArgs e)
        {  
            this.InitSystemConfigureTab();
            this.InitCarConfigureTab();
            this.InitCommunicationConfigureTab();
            this.InitTrackingReplayConfigureTab();
        }

        #endregion

        #region event - 系统配置

        private void btnProjectFileBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();

            oOpenFileDialog.Filter = "工程文件 (*.gvp) | *.gvp";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtProjectFilePath.Text = oOpenFileDialog.FileName;
            }
        }

        #endregion

        #region event - 车辆符号设置

        protected void symbolSelector_SymboSelectedEvent(object sender, GPSTrackingMonitor.CustomControl.SymbolSelectedEventArgs e)
        {
            this._currentFont = e.CurrentFont;
            this._selectedSymbolIndex = e.SymbolIndex;

            txtSymbolIndex.Text = e.SymbolIndex.ToString();
            pnlSymbolColor.BackColor = Color.Red;
            numSymbolSize.Value = (decimal)e.CurrentFont.Size;
            numSymbolRotation.Value = 0;

            Utilities.GDIPlus.DrawSymbolOnControl(this.picPreviewSymbol, e.CurrentFont, e.SymbolIndex, e.CurrentFont.Size, 0, this.pnlSymbolColor.BackColor);
        }

        private void cbbFontNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFontNames.Items.Count > 0)
            {
                FontFamily oFontFamily = new FontFamily(cbbFontNames.Text);
                this._currentFont = new Font(oFontFamily, 40, FontStyle.Regular, GraphicsUnit.Pixel);
            }

           symSelector.ListCharactors(this._currentFont);
        }

        private void numSymbolSize_ValueChanged(object sender, EventArgs e)
        {
            Utilities.GDIPlus.DrawSymbolOnControl(this.picPreviewSymbol, this._currentFont,
                this._selectedSymbolIndex, (float)this.numSymbolSize.Value, (float)this.numSymbolRotation.Value, this.pnlSymbolColor.BackColor);
        }

        private void numSymbolRotation_ValueChanged(object sender, EventArgs e)
        {
            Utilities.GDIPlus.DrawSymbolOnControl(this.picPreviewSymbol, this._currentFont,
                this._selectedSymbolIndex, (float)this.numSymbolSize.Value, (float)this.numSymbolRotation.Value, this.pnlSymbolColor.BackColor);
        }

        private void pnlSymbolColor_Click(object sender, EventArgs e)
        {
            ColorDialog oColorDialog = new ColorDialog();

            oColorDialog.Color = this.pnlSymbolColor.BackColor;
            if (oColorDialog.ShowDialog() == DialogResult.OK)
            {
                this.pnlSymbolColor.BackColor = oColorDialog.Color;

                Utilities.GDIPlus.DrawSymbolOnControl(this.picPreviewSymbol, this._currentFont,
               this._selectedSymbolIndex, (float)this.numSymbolSize.Value, (float)this.numSymbolRotation.Value, this.pnlSymbolColor.BackColor);
            }
        }

        private void pnlCarLabelColor_Click(object sender, EventArgs e)
        {
            ColorDialog oColorDialog = new ColorDialog();

            oColorDialog.Color = this.pnlCarLabelColor.BackColor;

            if (oColorDialog.ShowDialog() == DialogResult.OK)
            {
                this.pnlCarLabelColor.BackColor = oColorDialog.Color;
                this.btnCarLabelFont.ForeColor = pnlCarLabelColor.BackColor;
            }
        }

        private void btnCarLabelFont_Click(object sender, EventArgs e)
        {
            FontDialog oFontDialog = new FontDialog();

            oFontDialog.Font = this.btnCarLabelFont.Font;
            oFontDialog.ShowEffects = true;
            if (oFontDialog.ShowDialog() == DialogResult.OK)
            {
                this.btnCarLabelFont.Font = oFontDialog.Font;
                this.btnCarLabelFont.ForeColor = pnlCarLabelColor.BackColor;
            }
        }
        #endregion

        #region event - 通信配置


        #endregion

        #endregion

        #region methods

        private void InitSystemConfigureTab()
        {
            this.numIntervalCarUpdate.Minimum = 1;
            this.numIntervalCarUpdate.Maximum = int.MaxValue;

            this.numMaxOfMessageCache.Minimum = 1;
            this.numMaxOfMessageCache.Maximum = int.MaxValue;

            this.txtProjectFilePath.Text = GlobeVariables.ConfigureInfos.SystemConfigureInfos.ProjectFilePath;
            this.numMaxOfMessageCache.Value = (decimal)GlobeVariables.ConfigureInfos.SystemConfigureInfos.MaxOfMessageCache;
            this.numIntervalCarUpdate.Value = (decimal)GlobeVariables.ConfigureInfos.SystemConfigureInfos.IntervalCarUpdate;
        }

        private void InitCarConfigureTab()
        {
            using (IEnumerator<string> oFontNames = symSelector.GetAllFontNames().GetEnumerator())
            {
                string sCurValue = string.Empty;
                while (oFontNames.MoveNext())
                {
                    sCurValue = oFontNames.Current;

                    if (!sCurValue.Contains("ESRI")) continue;

                    this.cbbFontNames.Items.Add(sCurValue);
                }
            }

            this.symSelector.SymboSelectedEvent += new GPSTrackingMonitor.CustomControl.SymbolSelector.SymbolSelectedEventHandler(symbolSelector_SymboSelectedEvent);

            this._currentFont = new Font(GlobeVariables.ConfigureInfos.CarSymbolConfigureInfos.CarSymbolFontName, 12, FontStyle.Regular);
            this._selectedSymbolIndex = GlobeVariables.ConfigureInfos.CarSymbolConfigureInfos.CarSymbolIndex;

            this.numSymbolSize.Minimum = 1;
            this.numSymbolSize.Maximum = 100;

            this.numSymbolRotation.Minimum = 0;
            this.numSymbolRotation.Maximum = 360;

            this.cbbFontNames.Text = GlobeVariables.ConfigureInfos.CarSymbolConfigureInfos.CarSymbolFontName;
            this.txtSymbolIndex.Text = GlobeVariables.ConfigureInfos.CarSymbolConfigureInfos.CarSymbolIndex.ToString();
            this.pnlSymbolColor.BackColor = GlobeVariables.ConfigureInfos.CarSymbolConfigureInfos.CarSymbolColor;
            this.numSymbolSize.Value = (decimal)GlobeVariables.ConfigureInfos.CarSymbolConfigureInfos.CarSymbolSize;
            this.numSymbolRotation.Value = (decimal)GlobeVariables.ConfigureInfos.CarSymbolConfigureInfos.CarSymbolRotation;

            this.btnCarLabelFont.Font = GlobeVariables.ConfigureInfos.CarSymbolConfigureInfos.CarLabelFont;
            this.btnCarLabelFont.ForeColor = GlobeVariables.ConfigureInfos.CarSymbolConfigureInfos.CarLabelColor;
            this.pnlCarLabelColor.BackColor = GlobeVariables.ConfigureInfos.CarSymbolConfigureInfos.CarLabelColor;          

            Utilities.GDIPlus.DrawSymbolOnControl(this.picPreviewSymbol, this._currentFont,
             this._selectedSymbolIndex, (float)this.numSymbolSize.Value, (float)this.numSymbolRotation.Value, this.pnlSymbolColor.BackColor);
        }

        private void InitCommunicationConfigureTab()
        {
            this.txtCommunicationServerIP.Text = GlobeVariables.ConfigureInfos.CommunicationConfigureInfos.MessageServerAddress;
            this.txtLocalLisentingPort.Text = GlobeVariables.ConfigureInfos.CommunicationConfigureInfos.LocalMessageLiseningPort.ToString();
        }

        private void InitTrackingReplayConfigureTab()
        {
            object[] oDatabaseTypes = new object[] { 
                Configures.DatabaseTypeEnum.Access,
                Configures.DatabaseTypeEnum.Oracle,
                Configures.DatabaseTypeEnum.PostgreSQL,
                Configures.DatabaseTypeEnum.SQLServer
            };

            this.cbbDatabaseTypes.DataSource = oDatabaseTypes;

            this.cbbDatabaseTypes.Text = GlobeVariables.ConfigureInfos.TrackingReplayConfigureInfos.DatabaseType.ToString();
            this.txtDatabaseUserName.Text = GlobeVariables.ConfigureInfos.TrackingReplayConfigureInfos.DatabaseUserName;
            this.txtDatabasePassword.Text = GlobeVariables.ConfigureInfos.TrackingReplayConfigureInfos.DatabasePassword;
            this.txtDatabaseServerAdress.Text = GlobeVariables.ConfigureInfos.TrackingReplayConfigureInfos.DatabaseServerAdress;
            this.txtDatabasePort.Text = GlobeVariables.ConfigureInfos.TrackingReplayConfigureInfos.DatabasePort.ToString();
            this.txtLocalDatabaseLocation.Text = GlobeVariables.ConfigureInfos.TrackingReplayConfigureInfos.LocalDatabaseLocation;
            this.cbbTrackingTableName.Text = GlobeVariables.ConfigureInfos.TrackingReplayConfigureInfos.TrackingTableName;
        }

        private void ApplicationSystemConfigure()
        {
            GlobeVariables.ConfigureInfos.SystemConfigureInfos.IntervalCarUpdate = (int)this.numIntervalCarUpdate.Value;
            GlobeVariables.ConfigureInfos.SystemConfigureInfos.MaxOfMessageCache = (int)this.numMaxOfMessageCache.Value;
            GlobeVariables.ConfigureInfos.SystemConfigureInfos.ProjectFilePath = this.txtProjectFilePath.Text;
        }

        private void ApplicationCarConfigure()
        {
            GlobeVariables.ConfigureInfos.CarSymbolConfigureInfos.CarSymbolFontName = this.cbbFontNames.SelectedItem.ToString();
            GlobeVariables.ConfigureInfos.CarSymbolConfigureInfos.CarSymbolIndex = int.Parse(this.txtSymbolIndex.Text);
            GlobeVariables.ConfigureInfos.CarSymbolConfigureInfos.CarSymbolColor = this.pnlSymbolColor.BackColor;
            GlobeVariables.ConfigureInfos.CarSymbolConfigureInfos.CarSymbolSize = (double)this.numSymbolSize.Value;
            GlobeVariables.ConfigureInfos.CarSymbolConfigureInfos.CarSymbolRotation = (double)this.numSymbolRotation.Value;

            GlobeVariables.ConfigureInfos.CarSymbolConfigureInfos.CarLabelFont = this.btnCarLabelFont.Font;
            GlobeVariables.ConfigureInfos.CarSymbolConfigureInfos.CarLabelColor = this.btnCarLabelFont.ForeColor;
            GlobeVariables.ConfigureInfos.CarSymbolConfigureInfos.CarLabelColor = this.pnlCarLabelColor.BackColor;
        }

        private void ApplicationCommunicationConfigure()
        {
            GlobeVariables.ConfigureInfos.CommunicationConfigureInfos.MessageServerAddress = this.txtCommunicationServerIP.Text;
            GlobeVariables.ConfigureInfos.CommunicationConfigureInfos.LocalMessageLiseningPort = int.Parse(this.txtLocalLisentingPort.Text);

        }

        private void ApplicationTrackingReplayConfigure()
        {
            GlobeVariables.ConfigureInfos.TrackingReplayConfigureInfos.DatabaseType = (Configures.DatabaseTypeEnum)this.cbbDatabaseTypes.SelectedItem;
            GlobeVariables.ConfigureInfos.TrackingReplayConfigureInfos.DatabaseUserName = this.txtDatabaseUserName.Text;
            GlobeVariables.ConfigureInfos.TrackingReplayConfigureInfos.DatabasePassword = this.txtDatabasePassword.Text;
            GlobeVariables.ConfigureInfos.TrackingReplayConfigureInfos.DatabaseServerAdress = this.txtDatabaseServerAdress.Text;
            GlobeVariables.ConfigureInfos.TrackingReplayConfigureInfos.DatabasePort = int.Parse(this.txtDatabasePort.Text);
            GlobeVariables.ConfigureInfos.TrackingReplayConfigureInfos.LocalDatabaseLocation = this.txtLocalDatabaseLocation.Text;
            GlobeVariables.ConfigureInfos.TrackingReplayConfigureInfos.TrackingTableName = this.cbbTrackingTableName.Text;
        }

        #endregion

        private void btnApplication_Click(object sender, EventArgs e)
        {
            this.ApplicationSystemConfigure();
            this.ApplicationCarConfigure();
            this.ApplicationCommunicationConfigure();
            this.ApplicationTrackingReplayConfigure();

            Configures.ConfigureInfosStrcut.SaveConfigureInfos(GlobeVariables.ConfigureInfos, GlobeVariables.ConfigureFileName);

        }

        private void btnBrowseLocalDatabase_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFileDialog = new OpenFileDialog();
            oFileDialog.Filter = "Access Database (*.mdb) | *.mdb";

            if (oFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtLocalDatabaseLocation.Text = oFileDialog.FileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.btnApplication_Click(sender, e);
            this.btnCancel_Click(sender, e);
        }

    }
}
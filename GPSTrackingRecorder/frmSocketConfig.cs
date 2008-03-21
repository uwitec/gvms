using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSTrackingRecorder
{
    public partial class frmSocketConfig : Form
    {
        #region fields

        private string _serverIP;
        private string _liseningPort;
        private string _queueMax;

        #endregion

        #region properties

        public string ServerIP
        {
            get { return this._serverIP; }
            set { this._serverIP = value; }
        }

        public string LiseningPort
        {
            get { return this._liseningPort; }
            set { this._liseningPort = value; }
        }

        public string QueueMax
        {
            get { return this._queueMax; }
            set { this._queueMax = value; }
        }

        #endregion

        #region constructors

        public frmSocketConfig()
        {
            InitializeComponent();
        }

        #endregion

        #region events

        private void btnOK_Click(object sender, EventArgs e)
        {
            this._liseningPort = this.txtLiseningPort.Text;
            this._serverIP = this.txtServerIP.Text;
            this._queueMax = this.txtQueueMax.Text;

            this.DialogResult = DialogResult.OK;
        }

        private void frmSocketConfig_Load(object sender, EventArgs e)
        {
            this.txtLiseningPort.Text = GlobeVariables.DefaultLiseningPort.ToString();
            this.txtServerIP.Text = GlobeVariables.DefaultServerIP;
            this.txtQueueMax.Text = GlobeVariables.DefaultQueueMax.ToString();
        }

        #endregion
    }
}
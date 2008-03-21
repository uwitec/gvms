using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSGatewaySimulator
{
    public partial class frmSendMessage : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        #region constructors

        public frmSendMessage()
        {
            InitializeComponent();
        }

        #endregion

        #region fields

        private string _port;
        private string _interval;

        #endregion

        #region properties

        public string Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        public string Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }

        #endregion

        #region events

        private void btnStartSend_Click(object sender, EventArgs e)
        {
            this._port = this.txtPort.Text;
            this._interval = this.txtInterval.Text;

            this.DialogResult = DialogResult = DialogResult.OK;


            //Communications.SocketServer oSocketServer = new GPSGatewaySimulator.Communications.SocketServer();
            //oSocketServer.StartSendMessage(Int32.Parse(this.txtLocalPort.Text));
        }

        private void frmSendMessage_Load(object sender, EventArgs e)
        {
            this.txtPort.Text = GlobeVariables.DefaultReceivePort.ToString();
            this.txtInterval.Text = GlobeVariables.DefaultSendInterval.ToString();
        }

        #endregion
    }
}
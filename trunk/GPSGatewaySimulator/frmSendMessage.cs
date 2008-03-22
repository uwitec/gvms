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

        private int _port;
        private int _interval;
        private int _simulatedCarNumber;

        #endregion

        #region properties

        public int Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        public int Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }

        public int SimulatedCarNumber
        {
            get { return this._simulatedCarNumber; }
            set { this._simulatedCarNumber = value; }
        }

        #endregion

        #region events

        private void btnStartSend_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(this.txtPort.Text, out this._port))
            {
                MessageBox.Show("请确定输入了正确的端口号.");
                return;
            }

            if (!Int32.TryParse(this.txtInterval.Text, out this._interval))
            {
                MessageBox.Show("请确定输入了正确的间隔时间.");
                return;
            }

            if (!Int32.TryParse(this.txtSimulatedCarNumber.Text,out this._simulatedCarNumber))
            {
                MessageBox.Show("请确定输入了正确的车辆数目.");
                return;
            }

            this.DialogResult = DialogResult = DialogResult.OK;
        }

        private void frmSendMessage_Load(object sender, EventArgs e)
        {
            this.txtPort.Text = GlobeVariables.DefaultReceivePort.ToString();
            this.txtInterval.Text = GlobeVariables.DefaultSendInterval.ToString();
            this.txtSimulatedCarNumber.Text = GlobeVariables.DefaultCarNumber.ToString();
        }

        #endregion
    }
}
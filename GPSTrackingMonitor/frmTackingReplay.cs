using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GPSTrackingMonitor.TrackingReplay;

namespace GPSTrackingMonitor
{
    public partial class frmTackingReplay : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public frmTackingReplay()
        {
            InitializeComponent();
        }

        private static frmTackingReplay _instance;
        public static frmTackingReplay Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmTackingReplay();

                return _instance;
            }
        }
        
        #region private properties

        private System.Timers.Timer _trackReplayTimer;
        private string _carNumber;
        private TrackPoints _inputData;
        private TrackPoints _outputData;
        private int _curIndex;
        private TrackingReplay.ReplayOperation _replayOperation;

        #endregion

        #region public methods

        public void SetCarNumber(string carNumber)
        {
            this._carNumber = carNumber;

            this.cbbCarNumber.Items.Insert(0, carNumber);
            this.cbbCarNumber.SelectedIndex = 0;
        }

        #endregion

        #region events

        private void frmTackingReplay_Load(object sender, EventArgs e)
        {
            this._trackReplayTimer = new System.Timers.Timer();
            this._trackReplayTimer.Elapsed += new System.Timers.ElapsedEventHandler(_trackReplay_Elapsed);

            trbSmoothScale.Minimum = 0;
            trbSmoothScale.Maximum = 100;
            trbSmoothScale.Value = 1;
            trbSmoothScale.LargeChange = trbSmoothScale.SmallChange = 1;

            trbReplaySpeed.Minimum = 1;
            trbReplaySpeed.Maximum = 100;
            trbReplaySpeed.Value = 10;
            trbReplaySpeed.LargeChange = trbReplaySpeed.SmallChange = 1;
            
            lblPercent.Text = "1";

            this._replayOperation = new ReplayOperation(GlobeVariables.MainMapControl);
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cbbCarNumber.Text))
            {
                MessageBox.Show("未指定车辆，无法进行轨迹回放！");
                return;
            }

            if (dtpEndTime.Value == dtpStartTime.Value)
            {
                MessageBox.Show("请设置正确的时间段。");
                return;
            }

            this._replayOperation.ClearTrackings(false);

            //计算插值
            TrackInterpolate oTrackInter = new TrackInterpolate();
            this._inputData = TrackingReplay.TrackingData.GetHistoryTrackingData(this.cbbCarNumber.Text,dtpStartTime.Value,dtpEndTime.Value);

            if (this._inputData == null || this._inputData.Count == 0)
            {
                MessageBox.Show("在指定的时间段内该车辆没有出行记录。");
                return;
            }

            this._outputData = oTrackInter.InterpolateProcess(this._inputData, this.trbSmoothScale.Value);

            if (this._outputData == null || this._outputData.Count == 0)
            {
               // MessageBox.Show("插值分析失败！");
                return;
            }

            //显示轨迹线
            this._replayOperation.AddTrackingPath(this._inputData);

            //开始回放
            this._curIndex = 0;
            this._trackReplayTimer.Interval = 1000 / this.trbReplaySpeed.Value;
            this._trackReplayTimer.Start();

            this.btnReplay.Enabled = false;
            this.btnStop.Enabled = true;
        } 

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                this._trackReplayTimer.Stop();
                this._replayOperation.ClearTrackings(false);

                this.btnReplay.Enabled = true;
                this.btnStop.Enabled = false;
            }
            catch
            { }
        }

        private void trbSmoothScale_ValueChanged(object sender, EventArgs e)
        {
            lblPercent.Text = trbSmoothScale.Value.ToString();
        }

        private void _trackReplay_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this._curIndex >= this._outputData.Count)
            {
                this._trackReplayTimer.Stop();

                Invoke((MethodInvoker)delegate
                {
                    this.btnReplay.Enabled = true;
                    this.btnStop.Enabled = false;
                });

                return;
            }

            this._replayOperation.ReplayTrackings(this._outputData[this._curIndex],true);
            //Invoke(TrackReplayEvent, this, this._outputData[this._curIndex]);
            this._curIndex++;
        }

        #endregion

        private void frmTackingReplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.TaskManagerClosing)
            {
                e.Cancel = true;

                this.btnStop_Click(this.btnStop, EventArgs.Empty);
                this.Visible = false;
            }
        }
    }
}
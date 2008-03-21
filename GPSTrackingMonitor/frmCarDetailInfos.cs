using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSTrackingMonitor
{
    public partial class frmCarDetailInfos : Form
    {
        public frmCarDetailInfos()
        {
            InitializeComponent();
        }

        public frmCarDetailInfos(string carNumber, string phone, string coordinateX, string coordinateY, string direction)
        {
            InitializeComponent();

            this.txtCarNumber.Text = carNumber;
            this.txtPhone.Text = phone;
            this.txtCoordinate.Text = coordinateX + "," + coordinateY;
            this.txtDirection.Text = direction;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
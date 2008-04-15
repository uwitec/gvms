using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSGatewaySimulator
{
    public partial class frmAboutUS : Form
    {
        public frmAboutUS()
        {
            InitializeComponent();
        }

        private void frmAboutUS_Load(object sender, EventArgs e)
        {
            this.txtIntroduction.Text += "  本程序为开源GPS车辆监控系统（GVMS）中的GPS车辆模拟网关子系统，由GISeeker团队合作开发，"
                                             + "并采用GPL 2.0协议发布该产品。\r\n\r\n"
                                             + " GISeeker团队由一群热衷于开源GIS开发的人组成，随着产品的完善，团队成员数量也在不断的扩充之中。目前团队中参与编码的人员只有两人，期望更多的技术高手加盟我们的队伍。\r\n\r\n"
                                             + "联系方式　：　281383656（qq） ; massifor@hotmail(MSN) \r\n";

            this.txtIntroduction.Select(0, 0);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this.lblURL.Text);
        }
    }
}
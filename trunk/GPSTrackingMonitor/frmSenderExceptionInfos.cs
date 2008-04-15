using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace GPSTrackingMonitor
{
    public partial class frmSenderExceptionInfos : Form
    {
        private Exception _exception = new Exception();

        public frmSenderExceptionInfos(Exception e)
        {
            InitializeComponent();

            this._exception = e;

            this.txtErrorInfos.Text += "【MESSAGE】\r\n\r\n" + this._exception.Message + "\r\n\r\n";
            this.txtErrorInfos.Text += "【STACKTRACE】\r\n\r\n" + this._exception.StackTrace + "\r\n\r\n";
            this.txtErrorInfos.Text += "【SOURCE】\r\n\r\n" + this._exception.Source + "\r\n\r\n";
            this.txtErrorInfos.Text += "【HELP】\r\n\r\n" + this._exception.HelpLink + "\r\n\r\n";
   }

        public void SendSMTPEMail(string strSmtpServer, string strFrom, string strFromPass, string strto, string strSubject, string strBody)
        {
            SmtpClient client = new SmtpClient(strSmtpServer);
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(strFrom, strFromPass);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            MailMessage message = new MailMessage(strFrom, strto, strSubject, strBody);
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            client.Send(message);
        }

        string GetPage(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                using (HttpWebResponse res = (HttpWebResponse)req.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(res.GetResponseStream()))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
            catch (System.Exception e)
            {
                return e.Message;
            }
            finally
            {
                req.Abort();
            }
        }

        //   通过外部网站得到本机的外部IP  
        string GetOuterIP()
        {
            //string patt = @"IP:   \[(?<IP>[0-9\.]*)\]";
            string url = "http://www.skyiv.com/info/";
            return GetPage(url);
        }

        private void btnSendBugs_Click(object sender, EventArgs e)
        { 
            string sInfos = string.Empty;

            sInfos += txtErrorInfos.Text.Replace("【","<font color='red' bold='true'>【").Replace("】","】</font><p><font color='blue'>").Replace("\r\n","<p>");
            sInfos += "<font color='red' bold='true'>【USERWORDS】</font><p><font color='blue'>" + this.txtUserLeavedWords.Text.Replace("\r\n", "<p>") + "</font><p>";
            sInfos += "<font color='red' bold='true'>【USERIP】</font><p><font color='blue'>" + this.GetOuterIP() + "</font><p>";

            try
            {
                SendSMTPEMail("smtp.126.com", "lionyue@126.com", "820527_wym4551", "massifor@hotmail.com", "GVMS-Bugs-Report", sInfos);
                MessageBox.Show("消息发送成功，谢谢您的合作。\r\n\r\n我们将尽快解决您提交的问题，请您随时关注我们的网站。", "发送成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("消息发送失败，可能与您的网络有关，请再尝试一次。", "发送失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }   

    }
}
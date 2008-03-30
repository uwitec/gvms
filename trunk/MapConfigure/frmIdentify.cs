using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MapConfigure
{
    public partial class frmIdentify : Form
    {
        public frmIdentify()
        {
            InitializeComponent();    
        }

        public void UpdateFeatureInfos(MapUtil.FeatureInformations featureInfos,Point mousePosition)
        {   
            this.lsvFeatureProperties.Items.Clear();

            if (featureInfos == null)
            {
                this.Hide();
            }
            else
            {   
                this.lsvFeatureProperties.Items.Clear();
                Dictionary<string,string>.KeyCollection oFieldsCollection = featureInfos.FieldsAndValuesCollection.Keys;
                string sValue;

                foreach (string sFieldName in oFieldsCollection)
                {
                    this.lsvFeatureProperties.Items.Add(sFieldName);
                    featureInfos.FieldsAndValuesCollection.TryGetValue(sFieldName, out sValue);
                    this.lsvFeatureProperties.Items[this.lsvFeatureProperties.Items.Count - 1].SubItems.Add(sValue);
                }

                this.labLayerInfos.Text = string.Format("Í¼²ã : {0}", featureInfos.CurrentLayerInfos.Name);

                if (!this.Visible)
                    this.Show();

                this.Location = mousePosition;
                this.Activate();
            }
        }

        private void frmIdentify_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.TaskManagerClosing || e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel  = true;
                this.Hide();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSTrackingMonitor
{
    public partial class frmAdvanceFilter : Form
    {
        private DataTable _dataSource;
        private string _filterString;

        public frmAdvanceFilter(DataTable dataSource)
        {
            InitializeComponent();
            this._dataSource = dataSource;
        }

        public string FilterString
        {
            get { return this._filterString; }
        }

        private void frmAdvanceFilter_Load(object sender, EventArgs e)
        {
            this.lstFields.Items.Clear();
            this.lstUniqueValues.Items.Clear();
            this.txtFilterString.Clear();

            if (this._dataSource == null)    return;

            foreach (DataColumn col in this._dataSource.Columns)
            {
                this.lstFields.Items.Add(col.ColumnName);
            }
        }

        private void btnListUniqueValues_Click(object sender, EventArgs e)
        {
            this.lstUniqueValues.Items.Clear();

            if (lstFields.SelectedItem == null) return;

            string sSelectedField = lstFields.SelectedItem.ToString();

            List<object> oResult = Utilities.DataFilter.GetDistinctRowsFromDataTable(this._dataSource, sSelectedField);

            Type oColumnType = this._dataSource.Columns[sSelectedField].DataType;
            string sValue = "";

            foreach (object item in oResult)
            {
                if (oColumnType == typeof(int) || oColumnType == typeof(double) || oColumnType == typeof(float)) sValue = item.ToString();
                else if (oColumnType == typeof(string)|| oColumnType == typeof(DateTime))sValue = string.Format("'{0}'",item.ToString());
                
                this.lstUniqueValues.Items.Add(sValue);
            }
        }

        private void lstFields_DoubleClick(object sender, EventArgs e)
        {
            if (lstFields.Items.Count == 0 || lstFields.SelectedItem == null) return;

            this.txtFilterString.SelectedText = lstFields.SelectedItem.ToString();
        }

        private void lstUniqueValues_DoubleClick(object sender, EventArgs e)
        {
            if (lstUniqueValues.Items.Count == 0 || lstUniqueValues.SelectedItem == null) return;

            this.txtFilterString.SelectedText = lstUniqueValues.SelectedItem.ToString();
        }

        private void btnOperationEquel_Click(object sender, EventArgs e)
        {
            this.txtFilterString.SelectedText = " " + btnOperationEquel.Text + " ";
        }

        private void btnOperationNotEquel_Click(object sender, EventArgs e)
        {
            this.txtFilterString.SelectedText += " " + btnOperationNotEquel.Text + " ";
        }

        private void btnOperationLike_Click(object sender, EventArgs e)
        {
            this.txtFilterString.SelectedText = " " + btnOperationLike.Text + " ";
        }
  

        private void btnOperationLarger_Click(object sender, EventArgs e)
        {
            this.txtFilterString.SelectedText = " " + btnOperationLarger.Text + " ";
        }

        private void btnOperationLargerEquel_Click(object sender, EventArgs e)
        {
            this.txtFilterString.SelectedText = " " + btnOperationLargerEquel.Text + " ";
        }

        private void btnOperationAnd_Click(object sender, EventArgs e)
        {
            this.txtFilterString.SelectedText = " " + btnOperationAnd.Text + " ";

        }

        private void btnOperationSmaller_Click(object sender, EventArgs e)
        {
            this.txtFilterString.SelectedText = " " + btnOperationSmaller.Text + " ";
        }

        private void btnOperationSmallerEquel_Click(object sender, EventArgs e)
        {
            this.txtFilterString.SelectedText = " " + btnOperationSmallerEquel.Text + " ";
        }

        private void btnOperationOr_Click(object sender, EventArgs e)
        {
            this.txtFilterString.SelectedText = " " + btnOperationOr.Text + " ";
        }

        private void btnOperationMatch_Click(object sender, EventArgs e)
        {
            this.txtFilterString.SelectedText = btnOperationMatch.Text;
        }

        private void btnOperationParenthesis_Click(object sender, EventArgs e)
        {
            this.txtFilterString.SelectedText = btnOperationParenthesis.Text;
        }

        private void btnOperationNot_Click(object sender, EventArgs e)
        {
            this.txtFilterString.SelectedText = " " + btnOperationNot.Text + " ";
        }

        private void btnClearFilterString_Click(object sender, EventArgs e)
        {
            this.txtFilterString.Clear();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.txtFilterString.Text.Trim()))
                    this._dataSource.Select(this.txtFilterString.Text.Trim());

                MessageBox.Show("您的过滤条件成立.", "验证成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("您的过滤条件错误.", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnLoadFilterExpression_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFileDialog = new OpenFileDialog();

            oFileDialog.Filter = "表达式文件(*.exp) | *.exp";

            if (oFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamReader oStreamReader = new System.IO.StreamReader(oFileDialog.FileName))
                {
                    txtFilterString.Text = oStreamReader.ReadToEnd();
                }
            }
        }

        private void btnSaveFilterExpression_Click(object sender, EventArgs e)
        {
            SaveFileDialog oFileDialog = new SaveFileDialog();

            oFileDialog.Filter = "表达式文件(*.exp) | *.exp";
            oFileDialog.AddExtension = true;

            if (oFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = oFileDialog.FileName;

                using (System.IO.FileStream oStream = new System.IO.FileStream(sFileName, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                {
                    System.IO.StreamWriter oStreamWriter = new System.IO.StreamWriter(oStream);
                    oStreamWriter.WriteLine(this.txtFilterString.Text);

                    oStreamWriter.Flush();
                    oStreamWriter.Close();
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this._filterString = this.txtFilterString.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this._filterString = "";
            this.DialogResult = DialogResult.Cancel;
        }       
    }
}
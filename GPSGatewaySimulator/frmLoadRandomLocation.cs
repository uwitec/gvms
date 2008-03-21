using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSGatewaySimulator
{
    public partial class frmLoadRandomLocation : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        #region constructors

        public frmLoadRandomLocation()
        {
            InitializeComponent();
        }

        #endregion

        #region private methods

        private void InitDataGridView()
        {
            this.dgvRandomPoints.Show();
            this.dgvRandomDatabase.Hide();

            DataTable dtTemp = new HistoryTrakings.TrackingDataTableStruct();
            this.dgvRandomPoints.DataSource = dtTemp;

            foreach (DataColumn col in dtTemp.Columns)
            {
                DataGridViewColumn colDgv = dgvRandomPoints.Columns[col.ColumnName];
                colDgv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                colDgv.HeaderText = col.Caption;
            }
        }

        private void LoadData()
        {
            if (this.dgvRandomPoints.RowCount == 0)
                return;

            System.Data.OleDb.OleDbConnection oConn = BaseHandler.DatabaseManager.GetOleDbConnection(GlobeVariables.RandomPointsDBPath);
            GPSGatewaySimulator.RandomPoints.LoadRandomPointToDB oLoadPoints = new GPSGatewaySimulator.RandomPoints.LoadRandomPointToDB();

            oLoadPoints.LoadPointsToDB(oConn, "carlocation", this.dgvRandomPoints.DataSource as DataTable);
        }

        private void DeleteData()
        {
            System.Data.OleDb.OleDbConnection oConn = BaseHandler.DatabaseManager.GetOleDbConnection(GlobeVariables.RandomPointsDBPath);
            GPSGatewaySimulator.RandomPoints.LoadRandomPointToDB oLoadPoints = new GPSGatewaySimulator.RandomPoints.LoadRandomPointToDB();

            oLoadPoints.DeleteAllPointsInDB(oConn, "carlocation");
        }

        #endregion

        #region events

        private void btnAddRandomPoints_Click(object sender, EventArgs e)
        {
            frmSetLoadParas oFrmSetLoadParas = new frmSetLoadParas();
            this.dgvRandomPoints.Show();
            this.dgvRandomDatabase.Hide();

            if (oFrmSetLoadParas.ShowDialog() == DialogResult.OK)
            {   
                DataTable dtPoints = oFrmSetLoadParas.RandomPointsTable;
                this.dgvRandomPoints.DataSource = dtPoints;
                
                foreach (DataColumn col in dtPoints.Columns)
                {
                    DataGridViewColumn colDgv = dgvRandomPoints.Columns[col.ColumnName];
                    colDgv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    colDgv.HeaderText = col.Caption;
                }
            }
        }

        private void btnLoadPointsIntoDatabase_Click(object sender, EventArgs e)
        {
            string sQuest = "请问是否需要清空数据表中的所有记录?\r\n删除所有记录请点击\"是\" 按钮，否则点击\"否\"按钮。";

            if (MessageBox.Show(sQuest, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DeleteData();
            }

            this.LoadData();

            MessageBox.Show("数据导入成功.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewRandomData_Click(object sender, EventArgs e)
        {
            this.dgvRandomDatabase.Bounds = this.dgvRandomPoints.Bounds;
            this.dgvRandomPoints.Hide();
            this.dgvRandomDatabase.Show();

            System.Data.OleDb.OleDbConnection oConn = BaseHandler.DatabaseManager.GetOleDbConnection(GlobeVariables.RandomPointsDBPath);
            string sSql = "select * from carlocation";
            DataTable dtTemp =  BaseHandler.DatabaseManager.GetData(oConn, sSql);
            dgvRandomDatabase.DataSource = dtTemp;
        }

        private void frmLoadRandomLocation_Load(object sender, EventArgs e)
        {
            this.InitDataGridView();
        }
    
        #endregion
    }
}
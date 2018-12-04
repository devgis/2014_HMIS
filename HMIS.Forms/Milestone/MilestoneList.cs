using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Milestone
{
    public partial class MilestoneList : Form
    {
        private readonly WaitForm _waitform = new WaitForm();
        private string SubProjectID;
        public MilestoneList(string SubProjectId)
        {
            InitializeComponent();
            this.SubProjectID = SubProjectId;
            try
            {
                DataTable dtTemp = WSAL.WSMilestone.GetList(SubProjectId);
                if (dtTemp == null || dtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("当前子项目无里程碑数据！");
                    this.Dispose();
                }
                dgvMileStone.DataSource = dtTemp;
            }
            catch
            {
                MessageBox.Show("加载数据出错，请稍候重试！");
                this.Dispose();
            }
            
        }

        private void dgvMileStone_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            else
            {
                _waitform.sValue = "查询中 请稍等.......";
                _waitform.Show();
                try
                {
                    string Milestoneid = dgvMileStone.Rows[e.RowIndex].Cells["milestoneid"].Value.ToString();
                    dgvMileStoneSub.DataSource = WSAL.WSMilestone.GetSubList(Milestoneid);
                }
                catch
                { }
                _waitform.Hide();
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Milestone
{
    public partial class MilestoneConfirm : Form
    {
        private string SubProjectID;
        public MilestoneConfirm(string ProjectName, string SubProjectName, string SubProjectId)
        {
            InitializeComponent();
            this.SubProjectID = SubProjectId;
            tbProject.Text = ProjectName;
            tbProject.ReadOnly = true;
            tbSubProject.Text = SubProjectName;
            tbSubProject.ReadOnly = true;
            try
            {
                UfidaPMS.Models.Milestone m = WSAL.WSMilestone.GetModel(SubProjectId);
                if (m == null)
                {
                    MessageBox.Show("获取数据错误，请稍候再试！");
                    return;
                }
                else
                {
                    dateTimePicker1.Value = m.createdate;
                    dateTimePicker1.Enabled = false;
                    tbVersion.Text = m.verion.ToString();
                    tbVersion.ReadOnly = true;
                    dgvMileStoneList.AutoGenerateColumns = false;
                    dgvMileStoneList.DataSource = m.DSMilestoneSub.Tables[0];
                }
            }
            catch
            {
                MessageBox.Show("获取数据错误，请稍候再试！");
                return;
            }
            //ConfirmOK.DisplayIndex = dgvMileStoneList.ColumnCount-1;
            foreach (DataGridViewRow dgvr in dgvMileStoneList.Rows)
            {
                if (dgvr.Cells["FinishDate"].Value != null && dgvr.Cells["FinishDate"].Value.ToString().Trim() != "")
                {
                    (dgvr.Cells["ConfirmOK"] as DataGridViewButtonCell).Value = "取消";
                }
                else
                {
                    (dgvr.Cells["ConfirmOK"] as DataGridViewButtonCell).Value = "确认";
                }
            }
            dgvMileStoneList.Refresh();
        }

        private void tsmiCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvMileStoneList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 9)
            {
                string Submilestoneid = dgvMileStoneList.Rows[e.RowIndex].Cells["submilestoneid"].Value.ToString();
                DataGridViewButtonCell b = dgvMileStoneList.Rows[e.RowIndex].Cells["ConfirmOK"] as DataGridViewButtonCell;
                if (b.Value.ToString() == "确认")
                {
                    for (int i = 0; i < e.RowIndex; i++)
                    {
                        DataGridViewButtonCell b2 = dgvMileStoneList.Rows[i].Cells["ConfirmOK"] as DataGridViewButtonCell;
                        if (b2.Value.ToString() == "确认")
                        {
                            MessageBox.Show("请先确认前边阶段的里成本！");
                            return;
                        }
                    }
                    ///确认
                    ///
                    try
                    {
                        SelectDate frmSelectDate = new SelectDate();
                        if (frmSelectDate.ShowDialog() == DialogResult.OK)
                        {
                            if (WSAL.WSMilestone.Confirm(Submilestoneid, SubProjectID, frmSelectDate.Value))
                            {
                                b.Value = "取消";
                                dgvMileStoneList.Rows[e.RowIndex].Cells["FinishDate"].Value = frmSelectDate.Value;
                                frmSelectDate.Dispose();
                                MessageBox.Show("确认成功！");
                                return;
                            }
                            else
                            {
                                frmSelectDate.Dispose();
                                MessageBox.Show("确认失败！");
                                return;
                            }
                        }
                        
                    }
                    catch
                    {
                        MessageBox.Show("确认失败！");
                        return;
                    }
                    
                }
                else
                {
                    for (int i = e.RowIndex + 1; i < dgvMileStoneList.Rows.Count; i++)
                    {
                        DataGridViewButtonCell b2 = dgvMileStoneList.Rows[i].Cells["ConfirmOK"] as DataGridViewButtonCell;
                        if (b2.Value.ToString() == "取消")
                        {
                            MessageBox.Show("请先取消后边阶段的里成本！");
                            return;
                        }
                    }
                    ///取消
                    try
                    {
                        SelectDate frmSelectDate = new SelectDate();
                        if (frmSelectDate.ShowDialog() == DialogResult.OK)
                        {
                            if (WSAL.WSMilestone.CancelConfirm(Submilestoneid, SubProjectID))
                            {
                                b.Value = "确认";
                                frmSelectDate.Dispose();
                                dgvMileStoneList.Rows[e.RowIndex].Cells["FinishDate"].Value = "";
                                MessageBox.Show("取消成功！");
                                return;
                            }
                            else
                            {
                                frmSelectDate.Dispose();
                                MessageBox.Show("取消失败！");
                                return;
                            }
                        }

                    }
                    catch
                    {
                        MessageBox.Show("取消失败！");
                        return;
                    }
                }
            }
        }
    }
}

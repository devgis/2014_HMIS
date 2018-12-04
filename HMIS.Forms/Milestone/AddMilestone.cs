using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Milestone
{
    public partial class AddMilestone : Form
    {
        bool bSave = false;
        public string SubProjectId
        {
            get;
            set;
        }
        public AddMilestone()
        {
            InitializeComponent();
        }
        public AddMilestone(string ProjectName, string SubProjectName, string SubProjectId,DataTable DTMilestone)
        {
            InitializeComponent();
            this.SubProjectId = SubProjectId;
            tbProject.Text = ProjectName;
            tbProject.ReadOnly = true;
            tbSubProject.Text = SubProjectName;
            tbSubProject.ReadOnly = true;
            dgvMileStoneList.DataSource = DTMilestone;
        }
        #region 通用方法
        /// <summary>
        /// 校验数据
        /// </summary>
        /// <returns></returns>
        private bool CheckData()
        {
            if (dateTimePicker1.Value == null)
            {
                MessageBox.Show("请选择创建时间!");
                return false;
            }
            for(int i=0;i< dgvMileStoneList.Rows.Count;i++)
            {
                DataGridViewRow dgvr = dgvMileStoneList.Rows[i];
                if (dgvr.Cells["Index"].Value == null || dgvr.Cells["Index"].Value.ToString() == "")
                {
                    MessageBox.Show("第" + i+"行 序号无效!");
                    return false;
                }
                if (dgvr.Cells["MilestoneName"].Value == null || dgvr.Cells["MilestoneName"].Value.ToString() == "")
                {
                    MessageBox.Show("第" + i + "行 里程碑阶段无效!");
                    return false;
                }
                if (dgvr.Cells["StartTime"].Value == null || dgvr.Cells["StartTime"].Value.ToString() == "")
                {
                    MessageBox.Show("第" + i + "行 启动时间无效!");
                    return false;
                }
                if (dgvr.Cells["PlanFinishDay"].Value == null || dgvr.Cells["PlanFinishDay"].Value.ToString() == "")
                {
                    MessageBox.Show("第" + i + "行 预计完成时间无效!");
                    return false;
                }
                try
                {
                    if ((Convert.ToDateTime(dgvr.Cells["PlanFinishDay"].Value).Date - Convert.ToDateTime(dgvr.Cells["StartTime"].Value).Date).TotalDays <= 0)
                    {
                        MessageBox.Show("第" + i + "行 预计完成日期>计划开始时间!");
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("第" + i + "行预计完成日期或者计划开始时间无效!");
                    return false;
                }
                if (dgvr.Cells["planpeopleday"].Value == null || dgvr.Cells["planpeopleday"].Value.ToString() == "")
                {
                    MessageBox.Show("第" + i + "行 未输入计划人天!");
                    return false;
                }
                else
                {
                    try
                    {
                        Convert.ToInt32(dgvr.Cells["planpeopleday"].Value);
                    }
                    catch
                    {
                        MessageBox.Show("第" + i + "行 计划人天不是有效的数字!");
                        return false;
                    }
                }
                try
                {
                    Convert.ToInt32(dgvr.Cells["Index"].Value);
                    Convert.ToInt32(dgvr.Cells["TotalPercent"].Value);
                }
                catch 
                {
                    MessageBox.Show("该里程碑后台数据有误，请联系管理员检查!");
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 获取对象模型
        /// </summary>
        /// <returns></returns>
        private UfidaPMS.Models.Milestone GetModel()
        {
            UfidaPMS.Models.Milestone model = new Models.Milestone();
            model.createdate = dateTimePicker1.Value.Date;
            model.milestoneid = "";
            model.subprojectid = this.SubProjectId;
            model.verion = 0;
            model.MilestoneSubList = new List<Models.MilestoneSub>();
            foreach (DataGridViewRow dgvr in dgvMileStoneList.Rows)
            {
                Models.MilestoneSub s = new Models.MilestoneSub();
                s.planfinishdate = Convert.ToDateTime(dgvr.Cells["PlanFinishDay"].Value);
                s.startdate = Convert.ToDateTime(dgvr.Cells["StartTime"].Value);
                s.orderid = Convert.ToInt32(dgvr.Cells["Index"].Value);
                s.milestoneid = "";
                s.milestonename = dgvr.Cells["MilestoneName"].Value.ToString();
                s.TotalPercent = Convert.ToInt32(dgvr.Cells["TotalPercent"].Value);
                s.planpeopleday = Convert.ToInt32(dgvr.Cells["planpeopleday"].Value);
                model.MilestoneSubList.Add(s);
            }
            return model;
        }
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <returns>成功则返回主表ID</returns>
        private string SaveDate()
        {
            string SResult = "";
            try
            {
                SResult = WSAL.WSMilestone.Add(GetModel());
            }
            catch
            { }
            return SResult;
        }
        #endregion


        private void dgvMileStoneList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            else
            {
                if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
                {
                    SelectDate frmSelectDate = new SelectDate();
                    if (frmSelectDate.ShowDialog() == DialogResult.OK)
                    {
                        if (e.ColumnIndex == 0)
                        {
                            dgvMileStoneList.Rows[e.RowIndex].Cells["StartTime"].Value = frmSelectDate.Value.ToShortDateString();
                        }
                        else if (e.ColumnIndex == 1)
                        {
                            dgvMileStoneList.Rows[e.RowIndex].Cells["PlanFinishDay"].Value = frmSelectDate.Value.ToShortDateString();
                        }
                    }
                    
                }
            }
        }

       

        private void tsmiCancel_Click(object sender, EventArgs e)
        {
            if (!bSave)
            {
                if (MessageBox.Show("确认退出，当前数据将不保存？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.Dispose();
                }
            }
            else
            {
                this.Dispose();
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMileStoneList.EndEdit();
            }
            catch
            { }
            if (CheckData())
            {
                try
                {
                    string SResult = SaveDate();
                    if (SResult == "")
                    {
                        MessageBox.Show("保存失败!");
                    }
                    else
                    {
                        MessageBox.Show("保存成功!");
                        bSave = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void AddMilestone_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtHistor = WSAL.WSMilestone.GetMilestoneNowList(SubProjectId);
                if (dtHistor != null && dtHistor.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtHistor.Rows)
                    {
                        for (int i = 0; i < dgvMileStoneList.Rows.Count; i++)
                        {
                            if (dgvMileStoneList.Rows[i].Cells["MilestoneName"].Value.ToString() == dr["milestonename"].ToString())
                            {
                                dgvMileStoneList.Rows[i].Cells["finishdate"].Value = dr["finishdate"];
                                try
                                {
                                    dgvMileStoneList.Rows[i].Cells["StartTime"].Value = Convert.ToDateTime(dr["startdate"]).ToShortDateString();
                                }
                                catch
                                { }
                                try
                                {
                                    dgvMileStoneList.Rows[i].Cells["PlanFinishDay"].Value = Convert.ToDateTime(dr["planfinishdate"]).ToShortDateString();
                                }
                                catch
                                { }
                                dgvMileStoneList.Rows[i].Cells["planpeopleday"].Value = dr["planpeopleday"];
                                break;
                            }
                        }
                    }
                }
            }
            catch
            { }
        }
    }
}

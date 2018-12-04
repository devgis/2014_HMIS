using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Project
{
    public partial class AddProjectStatue : Form
    {
        bool bSave = false;
        public string SubProjectId
        {
            get;
            set;
        }
        DataTable dtMilestone;
        public AddProjectStatue(string ProjectName, string SubProjectName, string SubProjectId)
        {
            InitializeComponent();
            this.SubProjectId = SubProjectId;
            tbProject.Text = ProjectName;
            tbProject2.Text = ProjectName;
            tbProject.ReadOnly = true;
            tbSubProject.Text = SubProjectName;
            tbSubProject2.Text = SubProjectName;
            tbSubProject.ReadOnly = true;
            try
            {
                dtMilestone = WSAL.WSMilestone.GetMilestoneNowList(SubProjectId);
                MileStone.DataSource = dtMilestone;
                MileStone.ValueMember = "milestonename";
                MileStone.DisplayMember = "milestonename";
                dtpCreateTime.Value = WSAL.WSCommon.GetServerTime().Date;
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载数据出错，请稍候重试！");
                this.Dispose();
            }

            try
            {
                UfidaPMS.Models.ProjectWeekStatus p = WSAL.WSProjectWeekStatus.GetLatestModelBySubProject(SubProjectId);
                if (p != null)
                {
                    nsYear.Value = (decimal)p.year;
                    nsMonth.Value = (decimal)p.moth;
                    nsWeek.Value = (decimal)p.week;
                    tbYear2.Text = p.year.ToString();
                    tbMonth2.Text = p.moth.ToString();
                    tbWeek2.Text = p.week.ToString();
                    tbCreatedate2.Text = p.createdate.ToShortDateString();
                    tbWaitImprove2.Text = p.problem;
                    tbImproveMethod2.Text = p.measure;
                    tbRemarks2.Text = p.remarks;
                    tbWeekstatus2.Text = p.state;
                    dgvList2.DataSource = p.DSSubProjectWeekStatus.Tables[0];
                    if (nsWeek.Value >= 5)
                    {
                        nuWeek.Value=nsWeek.Value+1;
                        if (nsMonth.Value >= 12)
                        {
                            nuMonth.Value = 1;
                            nuYear.Value = nsYear.Value+1;
                        }
                        else
                        {
                            nuMonth.Value = nsMonth.Value + 1;
                            nuYear.Value = nsYear.Value;
                        }

                    }
                    else
                    {
                        nuWeek.Value = nsWeek.Value + 1;
                        nuMonth.Value = nsMonth.Value;
                        nuYear.Value = nsYear.Value;
                    }
                }
                else
                {
                    MessageBox.Show("暂时无该项目数据！");
                }
            }
            catch
            {
                MessageBox.Show("暂时无该项目数据！");
            }
            
        }

        #region 通用方法
        /// <summary>
        /// 校验数据
        /// </summary>
        /// <returns></returns>
        private bool CheckData()
        {

            if (cbWeekStatue.Text.Trim() == "")
            {
                MessageBox.Show("请选择周状态!");
                return false;
            }
            if (tbWaitImprove.Text.Trim() == "")
            {
                MessageBox.Show("请项目状态/待解决/改进的问题!");
                return false;
            }

            if (tbImproveMethod.Text.Trim() == "")
            {
                MessageBox.Show("请输入改进措施/行动计划!");
                return false;
            }
            #region 检查子表数据
            //for (int i = 0; i < dgvList.Rows.Count; i++)
            //{
            //    DataGridViewRow dgvr = dgvList.Rows[i];
            //    if (dgvr.Cells["MileStone"].Value == null || dgvr.Cells["MileStone"].Value.ToString().Trim() == "")
            //    {
            //        MessageBox.Show("进度预测" + dgvr.Cells["PlanTime"].Value.ToString() + " 没有选择里程碑，请选择!");
            //        return false;
            //    }


            //    if (dgvr.Cells["Rate"].Value == null || dgvr.Cells["Rate"].Value.ToString().Trim() == "")
            //    {
            //        MessageBox.Show("进度预测" + dgvr.Cells["PlanTime"].Value.ToString() + " 没有输入比例,请输入!");
            //        return false;
            //    }
            //    else
            //    {
            //        try
            //        {
            //            int m = Convert.ToInt32(dgvr.Cells["Rate"].Value);
            //            if (m < 0 || m > 100)
            //            {
            //                MessageBox.Show("进度预测" + dgvr.Cells["PlanTime"].Value.ToString() + " 比例应该为1～100以内的整数!");
            //                return false;
            //            }
            //        }
            //        catch
            //        {
            //            MessageBox.Show("进度预测" + dgvr.Cells["PlanTime"].Value.ToString() + " 比例应该为1～100以内的整数!");
            //            return false;
            //        }
            //    }
            //}
            #endregion
            return true;
        }
        /// <summary>
        /// 获取对象模型
        /// </summary>
        /// <returns></returns>
        private UfidaPMS.Models.ProjectWeekStatus GetModel()
        {
            UfidaPMS.Models.ProjectWeekStatus model = new Models.ProjectWeekStatus();
            model.supprojectid = SubProjectId;
            model.measure = tbImproveMethod.Text;
            model.moth = (int)nuMonth.Value;
            model.problem= tbWaitImprove.Text;
            model.remarks = tbRemarks.Text;
            model.state = cbWeekStatue.Text;
            model.statusid = LoginForm.UserName;
            model.week = (int)nuWeek.Value;
            model.year = (int)nuYear.Value;
            model.createdate = dtpCreateTime.Value.Date;
            model.SubProjectWeekStatusList = new List<Models.SubProjectWeekStatus>();
            foreach (DataGridViewRow dgvr in dgvList.Rows)
            {
                UfidaPMS.Models.SubProjectWeekStatus s = new Models.SubProjectWeekStatus();
                try
                {
                    s.milestone = dgvr.Cells["MileStone"].Value.ToString();
                }
                catch
                {
                    s.milestone = "";
                }
                s.month = Convert.ToInt32(dgvr.Cells["month"].Value);
                try
                {
                    s.percentage = Convert.ToInt32(dgvr.Cells["Rate"].Value);
                }
                catch
                {
                    s.percentage = 0;
                }
                
                s.planid = "";
                s.statusid = "";
                s.week = Convert.ToInt32(dgvr.Cells["week"].Value);
                s.weektime = dgvr.Cells["PlanTime"].Value.ToString();
                model.SubProjectWeekStatusList.Add(s);
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
                SResult = WSAL.WSProjectWeekStatus.Add(GetModel());
            }
            catch
            { }
            return SResult;
        }
        #endregion

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

        private void nuYear_ValueChanged(object sender, EventArgs e)
        {
            //加载周
            dgvList.Rows.Clear();
            int iYear = (int)nuYear.Value;
            int iMonth = (int)nuMonth.Value;
            int iWeek = (int)nuWeek.Value;
            if (iWeek < 5)
            {
                for (int iWeekTempWeek = iWeek ; iWeekTempWeek <= 5; iWeekTempWeek++)
                {
                    int RowIndex = dgvList.Rows.Add();
                    dgvList.Rows[RowIndex].Cells["PlanTime"].Value = iYear + "年" + iMonth + "月份第" + iWeekTempWeek + "周";
                    dgvList.Rows[RowIndex].Cells["month"].Value = iMonth;
                    dgvList.Rows[RowIndex].Cells["week"].Value = iWeekTempWeek; 
                }
                for (int iMonthTemp = iMonth + 1; iMonthTemp <= 12; iMonthTemp++)
                {
                    int RowIndex = dgvList.Rows.Add();
                    dgvList.Rows[RowIndex].Cells["PlanTime"].Value = iYear + "年" + iMonthTemp + "月份";
                    dgvList.Rows[RowIndex].Cells["month"].Value = iMonthTemp;
                    dgvList.Rows[RowIndex].Cells["week"].Value = 0; 
                }
            }
            else
            {
                int RowIndex = dgvList.Rows.Add();
                dgvList.Rows[RowIndex].Cells["PlanTime"].Value = iYear + "年" + iMonth.ToString() + "月份第" + 5 + "周";
                dgvList.Rows[RowIndex].Cells["month"].Value = iMonth ;
                dgvList.Rows[RowIndex].Cells["week"].Value = 5;
                if (iMonth != 12)
                {
                    
                    for (int iWeekTempWeek = 1; iWeekTempWeek <= 5; iWeekTempWeek++)
                    {
                        RowIndex = dgvList.Rows.Add();
                        dgvList.Rows[RowIndex].Cells["PlanTime"].Value = iYear + "年" + (iMonth + 1).ToString() + "月份第" + iWeekTempWeek + "周";
                        dgvList.Rows[RowIndex].Cells["month"].Value = iMonth + 1;
                        dgvList.Rows[RowIndex].Cells["week"].Value = iWeekTempWeek;
                    }
                    for (int iMonthTemp = iMonth + 2; iMonthTemp <= 12; iMonthTemp++)
                    {
                        RowIndex = dgvList.Rows.Add();
                        dgvList.Rows[RowIndex].Cells["PlanTime"].Value = iYear + "年" + iMonthTemp + "月份";
                        dgvList.Rows[RowIndex].Cells["month"].Value = iMonthTemp;
                        dgvList.Rows[RowIndex].Cells["week"].Value = 0;
                    }
                }
                else
                {
                    //for (int iWeekTempWeek = 1; iWeekTempWeek <= 5; iWeekTempWeek++)
                    //{
                    //    RowIndex = dgvList.Rows.Add();
                    //    dgvList.Rows[RowIndex].Cells["PlanTime"].Value = (iYear+1).ToString() + "年1月份第" + iWeekTempWeek + "周";
                    //    dgvList.Rows[RowIndex].Cells["month"].Value = 1;
                    //    dgvList.Rows[RowIndex].Cells["week"].Value = iWeekTempWeek;
                    //}
                    for (int iMonthTemp = 1; iMonthTemp <= 12; iMonthTemp++)
                    {
                        RowIndex = dgvList.Rows.Add();
                        dgvList.Rows[RowIndex].Cells["PlanTime"].Value = (iYear+1).ToString() + "年" + iMonthTemp + "月份";
                        dgvList.Rows[RowIndex].Cells["month"].Value = iMonthTemp;
                        dgvList.Rows[RowIndex].Cells["week"].Value = 0;
                    }
                }
            }
        }

        private void dtpCreateTime_ValueChanged(object sender, EventArgs e)
        {
            nuYear.Value = dtpCreateTime.Value.Year;
            nuMonth.Value = dtpCreateTime.Value.Month;
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                dgvList.EndEdit();
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
                        bSave = true;
                        MessageBox.Show("保存成功!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void BttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                UfidaPMS.Models.ProjectWeekStatus p = WSAL.WSProjectWeekStatus.GetModelByWeek((int)nsYear.Value, (int)nsMonth.Value, (int)nsWeek.Value);
                if (p != null)
                {
                    nsYear.Value = (decimal)p.year;
                    nsMonth.Value = (decimal)p.moth;
                    nsWeek.Value = (decimal)p.week;
                    tbYear2.Text = p.year.ToString();
                    tbMonth2.Text = p.moth.ToString();
                    tbWeek2.Text = p.week.ToString();
                    tbCreatedate2.Text = p.createdate.ToShortDateString();
                    tbWaitImprove2.Text = p.problem;
                    tbImproveMethod2.Text = p.measure;
                    tbRemarks2.Text = p.remarks;
                    tbWeekstatus2.Text = p.state;
                    dgvList2.DataSource = p.DSSubProjectWeekStatus.Tables[0];
                }
                else
                {
                    MessageBox.Show("获取数据发生错误，请重试！");
                }
            }
            catch
            {
                MessageBox.Show("获取数据发生错误，请重试！");
            }
        }

        private void dgvList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                try
                {
                    string mislestoneName = dgvList.Rows[e.RowIndex].Cells["MileStone"].Value.ToString();
                    foreach (DataRow dr in dtMilestone.Rows)
                    {
                        if (dr["milestonename"].ToString() == mislestoneName)
                        {
                            dgvList.Rows[e.RowIndex].Cells["Rate"].Value = dr["totalpercent"];
                        }
                    }
                }
                catch
                { }
                
            }
        }

        private void tsmiProjectInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string ProjectId = WSAL.WSProjectWeekStatus.GetProjectId(SubProjectId);
                if (ProjectId.Trim() == "")
                {
                    MessageBox.Show("获取项目信息出错！");
                }
                ViewProject frmViewProject = new ViewProject(ProjectId);
                frmViewProject.MdiParent = this.MdiParent;
                frmViewProject.WindowState = FormWindowState.Maximized;
                frmViewProject.Show();
            }
            catch
            {
                MessageBox.Show("获取项目信息出错，请稍候再试！");
            }
        }

        private void tsmiContract_Click(object sender, EventArgs e)
        {
            try
            {
                string ContractId = WSAL.WSProjectWeekStatus.GetContractId(SubProjectId);
                if (ContractId.Trim() == "")
                {
                    MessageBox.Show("获取合同信息出错！");
                }
                UfidaPMS.Forms.Contract.ViewContract frmViewContract = new UfidaPMS.Forms.Contract.ViewContract(ContractId);
                frmViewContract.MdiParent = this.MdiParent;
                frmViewContract.WindowState = FormWindowState.Maximized;
                frmViewContract.Show();
            }
            catch
            {
                MessageBox.Show("获取项目合同出错，请稍候再试！");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Project
{
    public partial class AddSubProjectPeoPleDay : Form
    {
        bool bSave = false;
        private string SubProjectId;
        DataTable dtGuwen;
        public AddSubProjectPeoPleDay(string ProjectName,string SubProjectName,string SubProjectId)
        {
            InitializeComponent();
            this.SubProjectId=SubProjectId;
            tbProject.Text = ProjectName;
            tbSubProject.Text = SubProjectName;
            try {
                cbMilestone.DataSource = WSAL.WSMilestone.GetMilestoneNowList(SubProjectId);
                cbMilestone.DisplayMember = "milestonename";
                cbMilestone.ValueMember = "milestonename";

                
            }
            catch
            {
                MessageBox.Show("加载里程碑数据出错，请稍候再试！");
                this.Dispose();
            }

            try
            {
                dtGuwen = WSAL.WSDictonary.GetDictGuWen();
                GuWen.DataSource = dtGuwen;
                GuWen.DisplayMember = "developadviser";
                GuWen.ValueMember = "developadviser";
            }
            catch
            { }
            dtpReportDate.Value = DateTime.Now.Date;
            cbCreater.Text = LoginForm.UserName;
        }
        #region 通用方法
        /// <summary>
        /// 校验数据
        /// </summary>
        /// <returns></returns>
        private bool CheckData()
        {

            if (dtpReportDate.Value == null)
            {
                MessageBox.Show("请选择报告日期!");
                return false;
            }
            if (dtpStartTime.Value == null)
            {
                MessageBox.Show("请选择开始日期!");
                return false;
            }
            if (dtpEndTime == null)
            {
                MessageBox.Show("请选择结束日期!");
                return false;
            }
            if ((dtpEndTime.Value.Date - dtpStartTime.Value.Date).TotalDays < 0)
            {
                MessageBox.Show("结束日期必须大于开始日期!");
                return false;
            }
            if ((dtpReportDate.Value.Date-dtpEndTime.Value.Date).TotalDays < 0)
            {
                MessageBox.Show("报告日期必须大于等于结束日期!");
                return false;
            }
            if (cbMilestone.Text.Trim() == "")
            {
                MessageBox.Show("请选择里程碑!");
                return false;
            }
            //if (tbPeoPleDay.Text.Trim() == "")
            //{
            //    MessageBox.Show("请输入人天!");
            //    return false;
            //}
            //else
            //{
            //    try
            //    {
            //        Convert.ToInt32(tbPeoPleDay.Text);
            //    }
            //    catch
            //    {
            //         MessageBox.Show("人天必须为整数!");
            //        return false;
            //    }
            //}
            //if (cbCreater.Text.Trim() == "")
            //{
            //    MessageBox.Show("请输入制单人!");
            //    return false;
            //}
            
            #region 检查子表数据
            if (dgvGuWen.Rows.Count <= 0)
            {
                MessageBox.Show("请至少输入一行顾问!");
                return false;
            }
            for (int i = 0; i < dgvGuWen.Rows.Count; i++)
            {
                DataGridViewRow dgvr = dgvGuWen.Rows[i];
                if (dgvr.Cells["GuWen"].Value == null || dgvr.Cells["GuWen"].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("子项目第" + i + "行顾问姓名不能为空，请检查!");
                    return false;
                }
                if (dgvr.Cells["人天"].Value == null || dgvr.Cells["人天"].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("子项目第" + i + "行顾问人天不能为空，请检查!");
                    return false;
                }
                else
                {
                    try
                    {
                        if (Convert.ToInt32(dgvr.Cells["人天"].Value) <= 0)
                        {
                            MessageBox.Show("子项目第" + i + "行顾问人天必须为大于0的整数，请检查!");
                            return false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("子项目第" + i + "行顾问人天必须为大于0的整数，请检查!");
                        return false;
                    }
                }
            }
            #endregion
            return true;
        }
        /// <summary>
        /// 获取对象模型
        /// </summary>
        /// <returns></returns>
        private UfidaPMS.Models.Actualdays GetModel()
        {
            UfidaPMS.Models.Actualdays model = new Models.Actualdays();
           
            model.confirmdate = dtpReportDate.Value.Date;
            model.confirmuser = cbCreater.Text;
            model.enddate = dtpEndTime.Value.Date;
            model.milestonename = cbMilestone.Text;
            model.startdate = dtpStartTime.Value.Date;
            model.subprojectid = SubProjectId;
            model.guwen = dgvGuWen.Rows[0].Cells["GuWen"].Value.ToString();
            if (dgvGuWen.Rows.Count >1)
            {
                for (int i = 1; i < dgvGuWen.Rows.Count; i++)
                {
                    model.guwen += ","+dgvGuWen.Rows[i].Cells["GuWen"].Value.ToString();
                }
            }
            model.SubActualdaysList = new List<Models.SubActualdays>();
            int iPeopleDayAll = 0;
            foreach (DataGridViewRow dgvr in dgvGuWen.Rows)
            {
                Models.SubActualdays s = new Models.SubActualdays();
                s.gindex = Convert.ToInt32(dgvr.Cells["Index"].Value);
                s.guwen = dgvr.Cells["GuWen"].Value.ToString();
                s.peopleyday = Convert.ToInt32(dgvr.Cells["人天"].Value);
                iPeopleDayAll += s.peopleyday;
                model.SubActualdaysList.Add(s);
            }
            model.actualdays = iPeopleDayAll;
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
                SResult = WSAL.WSActualdays.Add(GetModel());
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

        private void dgvGuWen_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            GetIndex();
        }

        private void dgvGuWen_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            GetIndex();
        }

        private void dgvGuWen_Sorted(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 行编号
        /// </summary>
        private void GetIndex()
        {
            for (int i = 0; i < dgvGuWen.Rows.Count; i++)
            {
                dgvGuWen.Rows[i].Cells["Index"].Value = i;
            }
        }

        private void tsmiAddRow_Click(object sender, EventArgs e)
        {
            try
            {
                GuWen.DataSource = null;
                dgvGuWen.Rows.Add();
                GuWen.DataSource = dtGuwen;
                GuWen.DisplayMember = "developadviser";
                GuWen.ValueMember = "developadviser";
            }
            catch(Exception ex)
            { }
        }

        private void tsmiDeleteRow_Click(object sender, EventArgs e)
        {
            if (dgvGuWen.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择子至少一行进行删除！");
            }
            else
            {
                if (MessageBox.Show("确认删除当前选中行？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow dgvr in dgvGuWen.SelectedRows)
                    {
                        try
                        {
                            dgvGuWen.Rows.Remove(dgvr);
                        }
                        catch
                        { }
                    }
                }
            }
        }

        //private void tbPeoPleDay_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (tbPeoPleDay.Text.Trim() != "")
        //        {
        //            Convert.ToInt32(tbPeoPleDay.Text);
        //        }
        //    }
        //    catch
        //    {
        //        tbPeoPleDay.Text = "";
        //    }
        //}

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                dgvGuWen.EndEdit();
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

        private void dgvGuWen_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                (e.Control as ComboBox).DropDownStyle = ComboBoxStyle.DropDown;
            }
            catch
            { }
        }

        private void dgvGuWen_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //datagridviewcomboxcloumn列中出现异常不处理
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Project
{
    public partial class AddProject : Form
    {
        bool bSave = false;
        public string SubCoractID
        {
            set;
            get;
        }
        public int ContractAmount
        {
            set;
            get;
        }
        //public AddProject()
        //{
        //    InitializeComponent();
        //    SubCoractID = "";
        //}
        public AddProject(string ContractNo, string SubCoractNo, string SubCoractID,int ContractAmount)
        {
            InitializeComponent();
            this.SubCoractID = SubCoractID;
            tbContract.Text = ContractNo;
            tbSubContract.Text = SubCoractNo;
            this.ContractAmount = ContractAmount;

            ReLoadM:
            try
            {
                DataSet Ds = WSAL.WSDictonary.GetAllDict();

                cbPM.DataSource = Ds.Tables["projectmanager"];
                cbPM.DisplayMember = "projectmanager";
                cbPM.DisplayMember = "projectmanager";

                cbDepartment.DataSource = Ds.Tables["department"];
                cbDepartment.DisplayMember = "department";
                cbDepartment.ValueMember = "department";

                cbManager.DataSource = Ds.Tables["regulator"];
                cbManager.DisplayMember = "regulator";
                cbManager.ValueMember = "regulator";


                //ProjectMethod.DataSource = WSAL.WSCommon.GetProjectMethod();
                ProjectMethod.DataSource = Ds.Tables["projectmethod"];
                ProjectMethod.DisplayMember = "ProjectMethod";
                ProjectMethod.ValueMember = "ProjectMethod";
            }
            catch
            {
                if (MessageBox.Show("获取数据出错，请选择重新加载或者退出？", "系统提示", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                {
                    goto ReLoadM;
                }
                else
                {
                    this.Dispose();
                }
            }
            
        }

        #region 通用方法
        /// <summary>
        /// 校验数据
        /// </summary>
        /// <returns></returns>
        private bool CheckData()
        {
            
            if (tbContract.Text.Trim() == "")
            {
                MessageBox.Show("请选择主合同号!");
                return false;
            }
            if (tbSubContract.Text.Trim() == "")
            {
                MessageBox.Show("请选择子合同号!");
                return false;
            }
            if (SubCoractID == "")
            {
                MessageBox.Show("请选择子合同!");
                return false;
            }
            if (tbProjectName.Text.Trim() == "")
            {
                MessageBox.Show("请输入项目名称!");
                return false;
            }
            //if (tbPMPProjectNo.Text.Trim() == "")
            //{
            //    MessageBox.Show("请输入PMP项目编号!");
            //    return false;
            //}
            if (cbPM.Text.Trim() == "")
            {
                MessageBox.Show("请输入项目经理!");
                return false;
            }
            if (cbDepartment.Text.Trim() == "")
            {
                MessageBox.Show("请输入实施部门!");
                return false;
            }
            //if (cbManager.Text.Trim() == "")
            //{
            //    MessageBox.Show("请输入监管人员!");
            //    return false;
            //}
            //if (cbProjectLevel.Text.Trim() == "")
            //{
            //    MessageBox.Show("请输入项目级别!");
            //    return false;
            //}

            if (dgvSubProjectList.Rows.Count == 0)
            {
                MessageBox.Show("请至少包含一条子项目!");
                return false;
            }
            #region 检查子表数据
            for (int i = 0; i < dgvSubProjectList.Rows.Count; i++)
            {
                DataGridViewRow dgvr = dgvSubProjectList.Rows[i];
                if (dgvr.Cells["BianHao"].Value == null || dgvr.Cells["BianHao"].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("子项目第" + i + "行编号不能为空，请检查!");
                    return false;
                }
                if (dgvr.Cells["ProjectMethod"].Value == null || dgvr.Cells["ProjectMethod"].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("子项目第" + i + "交付方法不能为空，请检查!");
                    return false;
                }
                if (dgvr.Cells["SubProjectName"].Value == null || dgvr.Cells["SubProjectName"].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("子项目第" + i + "行项目名称不能为空，请检查!");
                    return false;
                }
                if (dgvr.Cells["SubProjectType"].Value == null || dgvr.Cells["SubProjectType"].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("子项目第" + i + "行项目类型不能为空，请检查!");
                    return false;
                }
                //if (dgvr.Cells["Model"].Value == null || dgvr.Cells["Model"].Value.ToString().Trim() == "")
                //{
                //    MessageBox.Show("子项目第" + i + "行模块不能为空，请检查!");
                //    return false;
                //}
                if (dgvr.Cells["SubProjectManager"].Value == null || dgvr.Cells["SubProjectManager"].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("子项目第" + i + "行子项目经理不能为空，请检查!");
                    return false;
                }
                //if (dgvr.Cells["GuWen"].Value == null || dgvr.Cells["GuWen"].Value.ToString().Trim() == "")
                //{
                //    MessageBox.Show("子项目第" + i + "行实施顾问不能为空，请检查!");
                //    return false;
                //}
                //if (dgvr.Cells["PlanPeopleDay"].Value == null || dgvr.Cells["PlanPeopleDay"].Value.ToString().Trim() == "")
                //{
                //    MessageBox.Show("子项目第" + i + "行计划人天不能为空，请检查!");
                //    return false;
                //}
                //else
                //{
                //    try
                //    {
                //        Convert.ToInt32(dgvr.Cells["PlanPeopleDay"].Value);
                //    }
                //    catch
                //    {
                //        MessageBox.Show("子项目第" + i + "行计划人天应该为整数，请检查!");
                //        return false;
                //    }
                //}
                if (dgvr.Cells["percentage"].Value == null || dgvr.Cells["percentage"].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("子项目第" + i + "行占总比例不能为空，请检查!");
                    return false;
                }
                else
                {
                    try
                    {
                        Convert.ToInt32(dgvr.Cells["percentage"].Value);
                    }
                    catch
                    {
                        MessageBox.Show("子项目第" + i + "行总比例应该为整数，请检查!");
                        return false;
                    }
                }
                if (dgvr.Cells["percentage"].Value == null || dgvr.Cells["percentage"].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("子项目第" + i + "行占总比例不能为空，请检查!");
                    return false;
                }
                //if (dgvr.Cells["StartTime"].Value == null || dgvr.Cells["StartTime"].Value.ToString().Trim() == "")
                //{
                //    MessageBox.Show("子项目第" + i + "行启动时间不能为空，请检查!");
                //    return false;
                //}
                //else
                //{
                //    try
                //    {
                //        Convert.ToDateTime(dgvr.Cells["StartTime"].Value);
                //    }
                //    catch
                //    {
                //        MessageBox.Show("子项目第" + i + "行未选择启动时间，请检查!");
                //        return false;
                //    }
                //}
                //if (dgvr.Cells["PlanFinishDay"].Value == null || dgvr.Cells["PlanFinishDay"].Value.ToString().Trim() == "")
                //{
                //    MessageBox.Show("子项目第" + i + "行预计完成时间不能为空，请检查!");
                //    return false;
                //}
                //else
                //{
                //    try
                //    {
                //        Convert.ToDateTime(dgvr.Cells["PlanFinishDay"].Value);
                //    }
                //    catch
                //    {
                //        MessageBox.Show("子项目第" + i + "行未选择预计完成时间，请检查!");
                //        return false;
                //    }
                //}
                if (dgvr.Cells["earlypercentage"].Value == null || dgvr.Cells["earlypercentage"].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("子项目第" + i + "行年初进度百分比不能为空，请检查!");
                    return false;
                }
                else
                {
                    try
                    {
                       int m= Convert.ToInt32(dgvr.Cells["earlypercentage"].Value);
                       if (m < 0 || m > 100)
                       {
                           MessageBox.Show("子项目第" + i + "行年初进度百分比应该为0～100间的整数，请检查!");
                           return false;
                       }
                    }
                    catch
                    {
                        MessageBox.Show("子项目第" + i + "行年初进度百分比整数，请检查!");
                        return false;
                    }
                }
            }
            #endregion
            //try
            //{
            //    //检查 tbPMPProjectNo PMP项目编号
            //    if (!WSAL.WSProject.CheckPMPNO(tbPMPProjectNo.Text))
            //    {
            //        MessageBox.Show("PMP项目编号已存在，请检查!");
            //        return false;
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("检查PMP项目编号出错，请稍候再试!");
            //    return false;
            //}
            return true;
        }
        /// <summary>
        /// 获取对象模型
        /// </summary>
        /// <returns></returns>
        private UfidaPMS.Models.Project GetModel()
        {
            UfidaPMS.Models.Project model = new Models.Project();
            model.implementdepartment = cbDepartment.Text;
            model.pmpprojectid = tbPMPProjectNo.Text;
            model.projectid = "";
            model.projectlevel = cbProjectLevel.Text;
            model.projectmanager = cbPM.Text;
            model.projectname = tbProjectName.Text;
            model.regulator = cbManager.Text;
            model.TotalAmount = ContractAmount;
            model.subcontractid = SubCoractID;
            model.SubProjectList = new List<Models.SubProject>();
            foreach (DataGridViewRow dgvr in dgvSubProjectList.Rows)
            {
                UfidaPMS.Models.SubProject s = new Models.SubProject();
                s.earlypercentage = Convert.ToInt32(dgvr.Cells["earlypercentage"].Value);
                s.projectmethod = dgvr.Cells["ProjectMethod"].Value.ToString();
                try
                {
                    s.implementadviser = dgvr.Cells["GuWen"].Value.ToString();
                }
                catch
                { }
                s.implementationamount=0;
                //try
                //{
                //    s.industry = dgvr.Cells["industry"].Value.ToString();
                //}
                //catch
                //{
                    s.industry = "";
                //}
                try
                {
                    s.modelname = dgvr.Cells["Model"].Value.ToString();
                }
                catch
                {
                    s.modelname = "";
                }
                s.percentage =Convert.ToInt32(dgvr.Cells["percentage"].Value);
                //s.planfinishtime=Convert.ToDateTime(dgvr.Cells["PlanFinishDay"].Value);
                s.remarks="";
                s.responsibilitymilestone="";
                try
                {
                    s.starttime = Convert.ToDateTime(dgvr.Cells["StartTime"].Value);
                }
                catch
                {
                    s.starttime =null;
                }
                
                s.subprojectcode=dgvr.Cells["BianHao"].Value.ToString();
                s.subprojectid="";
                s.subprojectmanager=dgvr.Cells["SubProjectManager"].Value.ToString();
                s.subprojectname=dgvr.Cells["SubProjectName"].Value.ToString();
                s.subprojecttype = dgvr.Cells["SubProjectType"].Value.ToString();
                s.totalschedule = 0;
                try
                {
                    s.Contacter = dgvr.Cells["Contacter"].Value.ToString();
                }
                catch
                {
                    s.Contacter = "";
                }
                try
                {
                    s.ContactPhone = dgvr.Cells["ContacterPhone"].Value.ToString();
                }
                catch
                {
                    s.ContactPhone = "";
                }
                try
                {
                    s.developadviser = dgvr.Cells["developadviser"].Value.ToString();
                }
                catch
                {
                    s.developadviser = "";
                }
                model.SubProjectList.Add(s);
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
                SResult = WSAL.WSProject.Add(GetModel());
            }
            catch
            { }
            return SResult;
        }
        #endregion

        private void tsmiAddRow_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSubProjectList.Rows.Add();
            }
            catch
            { }
        }

        private void tsmiDeleteRow_Click(object sender, EventArgs e)
        {
            if (dgvSubProjectList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择子至少一行子项目进行删除！");
            }
            else
            {
                if (MessageBox.Show("确认删除当前选中行？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow dgvr in dgvSubProjectList.SelectedRows)
                    {
                        try
                        {
                            dgvSubProjectList.Rows.Remove(dgvr);
                        }
                        catch
                        { }
                    }
                }
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSubProjectList.EndEdit();
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

        private void dgvSubProjectList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == 9)
            {
                SelectDate frmSelectDate = new SelectDate();
                if (frmSelectDate.ShowDialog() == DialogResult.OK)
                {
                    if (e.ColumnIndex == 9)
                    {
                        dgvSubProjectList.Rows[e.RowIndex].Cells["StartTime"].Value = frmSelectDate.Value.ToShortDateString();
                    }
                    //else if (e.ColumnIndex == 10)
                    //{
                    //    dgvSubProjectList.Rows[e.RowIndex].Cells["PlanFinishDay"].Value = frmSelectDate.Value.ToShortDateString();
                    //}
                }
                
            }

        }

        private void dgvSubProjectList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //earlypercentage
            dgvSubProjectList.Rows[e.RowIndex].Cells["earlypercentage"].Value = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Project
{
    public partial class EditProject : Form
    {
        bool bSave = false;
        private string ProjectID; 
        public EditProject(string ProjectID)
        {
            InitializeComponent();
            this.ProjectID = ProjectID;
            try
            {
                //ProjectMethod.DataSource = WSAL.WSCommon.GetProjectMethod();
                //ProjectMethod.DisplayMember = "ProjectMethod";
                //ProjectMethod.ValueMember = "ProjectMethod";
                UfidaPMS.Models.Project model = WSAL.WSProject.GetModel(ProjectID);
                if (model == null)
                {
                    MessageBox.Show("加载数据中发生错误，请稍候再试！");
                    this.Dispose();
                }
                else
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

                    cbContract.Text = model.ContractNo;
                    cbContract.Enabled = false;
                    cbDepartment.Text = model.implementdepartment;
                    cbManager.Text = model.regulator;
                    tbPMPProjectNo.Text = model.pmpprojectid;
                    cbProjectLevel.Text = model.projectlevel;
                    cbPM.Text = model.projectmanager;
                    tbProjectName.Text = model.projectname;
                    tbSubContract.Text = model.SubContractNo;
                    tbSubContract.Enabled = false;
                    dgvSubProjectList.DataSource = model.DSSubProject.Tables[0];
                    
                }
            }
            catch
            {
                MessageBox.Show("加载数据中发生错误，请稍候再试！");
                this.Dispose();
            }
        }

        #region 通用方法
        /// <summary>
        /// 校验数据
        /// </summary>
        /// <returns></returns>
        private bool CheckData()
        {

            if (cbContract.Text.Trim() == "")
            {
                MessageBox.Show("请选择主合同号!");
                return false;
            }
            if (tbSubContract.Text.Trim() == "")
            {
                MessageBox.Show("请选择子合同号!");
                return false;
            }
            //if (SubCoractID == "")
            //{
            //    if (cbSubContract.SelectedValue == null || cbSubContract.SelectedValue.ToString() == "")
            //    {
            //        MessageBox.Show("请选择子合同!");
            //        return false;
            //    }
            //}
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
                        int m = Convert.ToInt32(dgvr.Cells["earlypercentage"].Value);
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
            model.projectid = ProjectID;
            model.projectlevel = cbProjectLevel.Text;
            model.projectmanager = cbPM.Text;
            model.projectname = tbProjectName.Text;
            model.regulator = cbManager.Text;
            //if (SubCoractID == "")
            //{
            //    model.subcontractid = cbSubContract.SelectedValue.ToString();
            //}
            //else
            //{
            //    model.subcontractid = SubCoractID;
            //}
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
                {
                    s.implementadviser = "";
                }
                s.implementationamount = 0;
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
                s.percentage = Convert.ToInt32(dgvr.Cells["percentage"].Value);
                //s.planfinishtime = Convert.ToDateTime(dgvr.Cells["PlanFinishDay"].Value);
                s.remarks = "";
                s.responsibilitymilestone = "";
                try
                {
                    s.starttime = Convert.ToDateTime(dgvr.Cells["StartTime"].Value);
                }
                catch
                {
                    s.starttime = null;
                }
                s.subprojectcode = dgvr.Cells["BianHao"].Value.ToString();
                s.subprojectid = dgvr.Cells["subprojectid"].Value.ToString();
                s.subprojectmanager = dgvr.Cells["SubProjectManager"].Value.ToString();
                s.subprojectname = dgvr.Cells["SubProjectName"].Value.ToString();
                s.subprojecttype = dgvr.Cells["SubProjectType"].Value.ToString();
                s.totalschedule = 0;
                if (dgvr.Cells["IsAdd"].Value != null && dgvr.Cells["IsAdd"].Value.ToString().Trim() != "")
                {
                    if (dgvr.Cells["IsAdd"].Value.ToString().Trim() == "add")
                    {
                        s.IsNewAdd = true;
                    }
                }
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
                    s.ContactPhone = dgvr.Cells["Contactphone"].Value.ToString();
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
        private bool SaveDate()
        {
            bool bResult = false;
            try
            {
                bResult = WSAL.WSProject.Update(GetModel());
            }
            catch
            { }
            return bResult;
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
                    if (SaveDate())
                    {
                        bSave = true;
                        MessageBox.Show("保存成功!");
                    }
                    else
                    {
                        MessageBox.Show("保存失败!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void tsmiAddRow_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtTemp = dgvSubProjectList.DataSource as DataTable;
                dtTemp.Rows.Add(dtTemp.NewRow());
                dgvSubProjectList.DataSource = dtTemp;
            }
            catch
            { }
        }

        private void tsmiDeleteRow_Click(object sender, EventArgs e)
        {
            if (dgvSubProjectList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择子项目进行删除！");
            }
            else
            {
                if (MessageBox.Show("确认删除当前选中行？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        string subprojectid = dgvSubProjectList.SelectedRows[0].Cells["subprojectid"].Value.ToString();
                        int iResult = WSAL.WSProject.DeleteSub(subprojectid);
                        if (iResult > 0)
                        {
                            dgvSubProjectList.Rows.Remove(dgvSubProjectList.SelectedRows[0]);
                            MessageBox.Show("删除成功！");
                        }
                        else if (iResult == 0)
                        {
                            MessageBox.Show("删除失败！");
                        }
                        else if (iResult < 0)
                        {
                            MessageBox.Show("当前子项目不允许删除！");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("删除失败，错误信息：" + ex.Message);
                    }
                }
                
                
            }
        }

        private void dgvSubProjectList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                if (dgvSubProjectList.Rows[e.RowIndex].Cells["projectid2"].Value == null || dgvSubProjectList.Rows[e.RowIndex].Cells["projectid2"].Value.ToString().Trim()=="")
                {
                    dgvSubProjectList.Rows[e.RowIndex].Cells["IsAdd"].Value = "add";
                    dgvSubProjectList.Rows[e.RowIndex].Cells["earlypercentage"].Value = 0;
                }
            }
            catch
            { }
        }

        private void dgvSubProjectList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除当前项目？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    int iResult = WSAL.WSProject.Delete(ProjectID);
                    if (iResult == 0)
                    {
                        MessageBox.Show("删除失败！");
                    }
                    else if (iResult < 0)
                    {
                        MessageBox.Show("删除失败,可能当前项目子项目已经被引用！");
                    }
                    else if (iResult > 0)
                    {
                        MessageBox.Show("删除成功！");
                        this.Dispose();
                    }
                }
                catch
                {
                    MessageBox.Show("删除失败，请稍候再试！");
                }
                
            }
        }

        private void dgvSubProjectList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 12 )
            {
                SelectDate frmSelectDate = new SelectDate();
                if (frmSelectDate.ShowDialog() == DialogResult.OK)
                {
                    if (e.ColumnIndex == 12)
                    {
                        dgvSubProjectList.Rows[e.RowIndex].Cells["StartTime"].Value = frmSelectDate.Value.ToShortDateString();
                    }
                    //else if (e.ColumnIndex == 13)
                    //{
                    //    dgvSubProjectList.Rows[e.RowIndex].Cells["PlanFinishDay"].Value = frmSelectDate.Value.ToShortDateString();
                    //}
                }

            }
        }
    }
}

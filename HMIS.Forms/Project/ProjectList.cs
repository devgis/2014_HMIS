using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Project
{
    public partial class ProjectList : Form
    {
        private readonly WaitForm _waitform = new WaitForm();
        DataSet dsSource;
        public ProjectList()
        {
            InitializeComponent();
            try
            {
                dsSource = WSAL.WSDictonary.GetAllDict();
            }
            catch
            { }
        }

        private void tsmiState_Click(object sender, EventArgs e)
        {
            
            if (dgvSubProject.SelectedRows.Count <= 0)
            {
                MessageBox.Show("选择子项目进行立项！");
            }
            else
            {
                string ProjectName = dgvSubProject.SelectedRows[0].Cells["projectname"].Value.ToString();
                string SubProjectName = dgvSubProject.SelectedRows[0].Cells["子项目名称"].Value.ToString();
                string SubProjectId = dgvSubProject.SelectedRows[0].Cells["subprojectid"].Value.ToString();
                AddProjectStatue frmAddProjectStatue = new AddProjectStatue(ProjectName, SubProjectName, SubProjectId);
                frmAddProjectStatue.MdiParent = this.MdiParent;
                frmAddProjectStatue.WindowState = FormWindowState.Maximized;
                frmAddProjectStatue.Show();
            }
        }

        private void tsmiPeoPleDay_Click(object sender, EventArgs e)
        {
            if (dgvSubProject.SelectedRows.Count <= 0)
            {
                MessageBox.Show("选择子项目！");
            }
            else
            {
                try
                {
                    string ProjectName = dgvSubProject.SelectedRows[0].Cells["projectname"].Value.ToString();
                    string SubProjectName = dgvSubProject.SelectedRows[0].Cells["子项目名称"].Value.ToString();
                    string SubProjectId = dgvSubProject.SelectedRows[0].Cells["subprojectid"].Value.ToString();
                    AddSubProjectPeoPleDay frmAddSubProjectPeoPleDay = new AddSubProjectPeoPleDay(ProjectName, SubProjectName, SubProjectId);
                    frmAddSubProjectPeoPleDay.MdiParent = this.MdiParent;
                    frmAddSubProjectPeoPleDay.WindowState = FormWindowState.Maximized;
                    frmAddSubProjectPeoPleDay.Show();
                }
                catch
                { }
                
            }
            
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            SearchProject frmSearchProject = new SearchProject(dsSource);
            if (frmSearchProject.ShowDialog() == DialogResult.OK)
            {
                string Where = frmSearchProject.Where;
                frmSearchProject.Hide();
                this.Refresh();
                System.Threading.Thread.Sleep(50);
                _waitform.sValue = "查询中 请稍等.......";
                _waitform.Show();
                frmSearchProject.Dispose();
                DataTable dtProject = null;
                try
                {
                    dtProject = WSAL.WSProject.GetList(Where);
                    if (dtProject == null || dtProject.Rows.Count <= 0)
                    {
                        _waitform.Hide();
                        MessageBox.Show("没有符合条件的查询结果！");
                    }
                    else
                    {
                        dgvProject.DataSource = dtProject;
                        _waitform.Hide();
                    }
                }
                catch
                {
                    _waitform.Hide();
                    MessageBox.Show("查询出错，请稍候再试！");
                }
                
            }
        }

        private void dgvProject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                    string ProjectID = dgvProject.Rows[e.RowIndex].Cells["projectid"].Value.ToString();
                    dgvSubProject.DataSource = WSAL.WSProject.GetSubList(string.Format("projectid='{0}'", ProjectID));
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

        private void tsmiAddMileStone_Click(object sender, EventArgs e)
        {
            if (dgvSubProject.SelectedRows.Count <= 0)
            {
                MessageBox.Show("选择子项目进行操作！");
            }
            else
            {
                string ProjectName = "";
                try
                {
                    ProjectName = dgvSubProject.SelectedRows[0].Cells["projectname"].Value.ToString();
                }
                catch
                { }
                string SubProjectName = "";
                try
                {
                    SubProjectName = dgvSubProject.SelectedRows[0].Cells["子项目名称"].Value.ToString();
                }
                catch
                { }
                string SubProjectId = "";
                try
                {
                    SubProjectId = dgvSubProject.SelectedRows[0].Cells["subprojectid"].Value.ToString();
                }
                catch
                { }
                string projectmethod = "";
                try
                {
                    projectmethod = dgvSubProject.SelectedRows[0].Cells["projectmethod"].Value.ToString();
                }
                catch
                { }
                if (ProjectName == "")
                {
                    MessageBox.Show("项目无效，无法新建！");
                    return;
                }
                if (SubProjectName == "" || SubProjectId=="")
                {
                    MessageBox.Show("子项目无效，无法新建！");
                    return;
                }
                if (projectmethod == "")
                {
                    MessageBox.Show("子项目交付方法无效，无法新建！");
                    return;
                }
                DataTable dtMilestone = null;
                try
                {
                    dtMilestone = WSAL.WSCommon.GetMilseStoneByMethod(projectmethod);
                }
                catch
                { }
                if (dtMilestone == null || dtMilestone.Rows.Count == 0)
                {
                    MessageBox.Show("获取交付方法里程碑出错，无法新建！");
                    return;
                }
                Milestone.AddMilestone frmAddMilestone = new Milestone.AddMilestone(ProjectName, SubProjectName, SubProjectId,dtMilestone);
                frmAddMilestone.MdiParent = this.MdiParent;
                frmAddMilestone.WindowState = FormWindowState.Maximized;
                frmAddMilestone.Show();
            }
        }

        private void tsmiMileStoneConfirm_Click(object sender, EventArgs e)
        {
            if (dgvSubProject.SelectedRows.Count <= 0)
            {
                MessageBox.Show("选择子项目进行确认！");
            }
            else
            {
                string ProjectName = dgvSubProject.SelectedRows[0].Cells["projectname"].Value.ToString();
                string SubProjectName = dgvSubProject.SelectedRows[0].Cells["子项目名称"].Value.ToString();
                string SubProjectId = dgvSubProject.SelectedRows[0].Cells["subprojectid"].Value.ToString();
                Milestone.MilestoneConfirm frmMilestoneConfirm = new Milestone.MilestoneConfirm(ProjectName, SubProjectName, SubProjectId);
                frmMilestoneConfirm.MdiParent = this.MdiParent;
                frmMilestoneConfirm.WindowState = FormWindowState.Maximized;
                frmMilestoneConfirm.Show();
            }
            
        }

        private void tsmiMileStoneList_Click(object sender, EventArgs e)
        {
            if (dgvSubProject.SelectedRows.Count <= 0)
            {
                MessageBox.Show("选择子项目查看里程碑历史！");
            }
            else
            {
                try
                {
                    string SubProjectId = dgvSubProject.SelectedRows[0].Cells["subprojectid"].Value.ToString();
                    Milestone.MilestoneList frmMilestoneList = new Milestone.MilestoneList(SubProjectId);
                    frmMilestoneList.MdiParent = this.MdiParent;
                    frmMilestoneList.WindowState = FormWindowState.Maximized;
                    frmMilestoneList.Show();
                }
                catch
                { }
                
            }
            
        }

        private void tsmiView_Click(object sender, EventArgs e)
        {
            if (dgvProject.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择项目进行查看！");
                return;
            }
            else
            {
                try
                {
                    string ProjectId = dgvProject.SelectedRows[0].Cells["projectid"].Value.ToString();
                    ViewProject frmViewProject = new ViewProject(ProjectId);
                    frmViewProject.MdiParent = this.MdiParent;
                    frmViewProject.WindowState = FormWindowState.Maximized;
                    frmViewProject.Show();
                }
                catch
                { }

            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (dgvProject.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择项目进行查看！");
                return;
            }
            else
            {
                try
                {
                    string ProjectId = dgvProject.SelectedRows[0].Cells["projectid"].Value.ToString();
                    EditProject frmEditProject = new EditProject(ProjectId);
                    frmEditProject.MdiParent = this.MdiParent;
                    frmEditProject.WindowState = FormWindowState.Maximized;
                    frmEditProject.Show();
                }
                catch
                { }

            }
        }

        private void ProjectList_Load(object sender, EventArgs e)
        {
            switch (LoginForm.UserType)
            {
                case 0:
                    tsmiDocumentConfim.Visible = false;
                    break;
                case 1:
                    tsmiState.Visible = false;
                    break;
                case 2:
                    tsmiMileStone.Visible = false;
                    tsmiSave.Visible = false;
                    tsmiPeoPleDay.Visible = false;
                    tsmiDocumentConfim.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void tsmiDocumentConfim_Click(object sender, EventArgs e)
        {
            if (dgvSubProject.SelectedRows.Count <= 0)
            {
                MessageBox.Show("选择子项目！");
            }
            else
            {
                try
                {
                    string ProjectName = dgvSubProject.SelectedRows[0].Cells["projectname"].Value.ToString();
                    string SubProjectName = dgvSubProject.SelectedRows[0].Cells["子项目名称"].Value.ToString();
                    string ProjectMethod = "";
                    try
                    {
                        ProjectMethod = dgvSubProject.SelectedRows[0].Cells["projectmethod"].Value.ToString();
                    }
                    catch
                    { }
                    if (ProjectMethod.Trim() == "")
                    {
                        MessageBox.Show("当前子项目交付方法有问题，不能做文档交付！");
                        return;
                    }
                    string SubProjectId = dgvSubProject.SelectedRows[0].Cells["subprojectid"].Value.ToString();
                    UfidaPMS.Forms.SubProjectDocument.SubProjectDocumentCommit frmSubProjectDocumentCommit = new SubProjectDocument.SubProjectDocumentCommit(ProjectName, SubProjectName, ProjectMethod, SubProjectId,LoginForm.UserType);
                    frmSubProjectDocumentCommit.MdiParent = this.MdiParent;
                    frmSubProjectDocumentCommit.WindowState = FormWindowState.Maximized;
                    frmSubProjectDocumentCommit.Show();
                }
                catch
                {
                    MessageBox.Show("获取数据中发生错误，请稍候再试！");
                }

            }

            
        }
    }
}

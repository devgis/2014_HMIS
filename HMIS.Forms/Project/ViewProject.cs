using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Project
{
    public partial class ViewProject : Form
    {
        private string ProjectID; 
        public ViewProject(string ProjectID)
        {
            InitializeComponent();
            this.ProjectID = ProjectID;
            try
            {
                UfidaPMS.Models.Project model = WSAL.WSProject.GetModel(ProjectID);
                if (model == null)
                {
                    MessageBox.Show("加载数据中发生错误，请稍候再试！");
                    this.Dispose();
                }
                else
                {
                    tbContractName.Text = model.ContractNo;
                    tbDepartment.Text = model.implementdepartment;
                    tbManager.Text = model.regulator;
                    tbPMPProjectNo.Text = model.pmpprojectid;
                    tbProjectLevel.Text = model.projectlevel;
                    tbProjectManager.Text = model.projectmanager;
                    tbProjectName.Text = model.projectname;
                    tbSubContractName.Text = model.SubContractNo;
                    dgvSubProjectList.DataSource = model.DSSubProject.Tables[0];
                }
            }
            catch
            {
                MessageBox.Show("加载数据中发生错误，请稍候再试！");
                this.Dispose();
            }
        }

        private void tsmiCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            try
            {
                EditProject frmEditProject = new EditProject(ProjectID);
                frmEditProject.MdiParent = this.MdiParent;
                frmEditProject.WindowState = FormWindowState.Maximized;
                frmEditProject.Show();
            }
            catch
            {
                MessageBox.Show("加载数据出错，请稍候再试！");
            }
        }
    }
}

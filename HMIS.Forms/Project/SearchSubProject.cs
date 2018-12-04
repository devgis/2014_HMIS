using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Project
{
    public partial class SearchSubProject : Form
    {
        public string Where
        {
            get;
            set;
        }
        public SearchSubProject(DataSet dtDepartmentSource)
        {
            InitializeComponent();
            try
            {
                tbDeptName.DataSource = dtDepartmentSource.Tables["department"];
                tbDeptName.DisplayMember = "department";
                tbDeptName.ValueMember = "department";
                tbDeptName.Text = "";

                tbProjectManager.DataSource = dtDepartmentSource.Tables["custmanager"];
                tbProjectManager.DisplayMember = "custmanager";
                tbProjectManager.ValueMember = "custmanager";
                tbProjectManager.Text = "";
            }
            catch
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Where += " 1=1 ";
            if (tbPmpNo.Text.Trim() != "")
            {
                Where += string.Format("and pmpprojectid like '%{0}%'", tbPmpNo.Text);
            }
            if (tbProjectName.Text.Trim() != "")
            {
                Where += string.Format("and projectname like '%{0}%'", tbProjectName.Text);
            }
            if (tbDeptName.Text.Trim() != "")
            {
                Where += string.Format("and implementdepartment like '%{0}%'", tbDeptName.Text);
            }
            if (tbProjectManager.Text.Trim() != "")
            {
                Where += string.Format("and projectmanager like '%{0}%'", tbProjectManager.Text);
            }
            if (tbSubProjectName.Text.Trim() != "")
            {
                Where += string.Format("and subprojectname like '%{0}%'", tbSubProjectName.Text);
            }
            if (cbProjectState.Text.Trim() != "")
            {
                Where += string.Format("and state = '{0}'", cbProjectState.Text);
            }
            //关闭 验收
            if (!cbHaveYiGuanBi.Checked)
            {
                Where += "and state <> '关闭'";
            }
            if (!cbHaveYiYanShou.Checked)
            {
                Where += "and state <> '验收'";
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}

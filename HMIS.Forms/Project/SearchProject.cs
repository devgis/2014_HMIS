using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Project
{
    public partial class SearchProject : Form
    {
        public string Where
        {
            get;
            set;
        }
        public SearchProject(DataSet dtDepartmentSource)
        {
            InitializeComponent();
            try
            {
                tbDeptName.DataSource = dtDepartmentSource.Tables["department"];
                tbDeptName.DisplayMember = "department";
                tbDeptName.ValueMember = "department";
                tbDeptName.SelectedText = "";

                tbProjectManager.DataSource = dtDepartmentSource.Tables["projectmanager"];
                tbProjectManager.DisplayMember = "projectmanager";
                tbProjectManager.ValueMember = "projectmanager";
                tbProjectManager.SelectedText = "";
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
            if (tbZiHeTongHao.Text.Trim() != "")
            {
                Where += string.Format("and subcontractno like '%{0}%'", tbZiHeTongHao.Text);
            }
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
            this.DialogResult = DialogResult.OK;
        }
    }
}

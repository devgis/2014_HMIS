using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Project
{
    public partial class ProjectStatueList : Form
    {
        private readonly WaitForm _waitform = new WaitForm();
        public ProjectStatueList()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            //dgvStatueMain.DataSource = WSAL.WSProjectWeekStatus.GetList("");
            SearchProjectStatue frmSearchProjectStatue = new SearchProjectStatue();
            if (frmSearchProjectStatue.ShowDialog() == DialogResult.OK)
            {
                string Where = frmSearchProjectStatue.Where;
                frmSearchProjectStatue.Hide();
                this.Refresh();
                System.Threading.Thread.Sleep(50);
                _waitform.sValue = "查询中 请稍等.......";
                _waitform.Show();
                frmSearchProjectStatue.Dispose();
                DataTable dtProject = null;
                try
                {
                    dtProject = WSAL.WSProjectWeekStatus.GetList(Where);
                    if (dtProject == null || dtProject.Rows.Count <= 0)
                    {
                        _waitform.Hide();
                        MessageBox.Show("没有符合条件的查询结果！");
                    }
                    else
                    {
                        dgvStatueMain.DataSource = dtProject;
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

        private void dgvStatueMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                    string statusid = dgvStatueMain.Rows[e.RowIndex].Cells["statusid"].Value.ToString();
                    dgvStatueSub.DataSource = WSAL.WSProjectWeekStatus.GetSubList(statusid);
                }
                catch
                { }
                _waitform.Hide();
            }
        }

        private void tsiDelete_Click(object sender, EventArgs e)
        {
            if (dgvStatueMain.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择主表行进行删除！");
            }
            else
            {
                if (MessageBox.Show("确认删除当前选中行？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        string statusid = dgvStatueMain.SelectedRows[0].Cells["statusid"].Value.ToString();
                        if (WSAL.WSProjectWeekStatus.Delete(statusid))
                        {
                            dgvStatueMain.Rows.Remove(dgvStatueMain.SelectedRows[0]);
                            MessageBox.Show("删除成功！");
                        }
                        else
                        {
                            MessageBox.Show("删除失败！");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("删除失败，错误信息：" + ex.Message);
                    }
                }
            }
        }

        private void ProjectStatueList_Load(object sender, EventArgs e)
        {
            switch (LoginForm.UserType)
            {
                case 0:
                    break;
                case 1:
                    tsmiSave.Visible = false;
                    tsiDelete.Visible = false;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}

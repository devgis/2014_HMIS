using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Project
{
    public partial class SubProjectPeoPleDayList : Form
    {
        private readonly WaitForm _waitform = new WaitForm();
        public SubProjectPeoPleDayList()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            SearchPeopleDay frmSearchPeopleDay = new SearchPeopleDay();
            if (frmSearchPeopleDay.ShowDialog() == DialogResult.OK)
            {
                string Where = frmSearchPeopleDay.Where;
                frmSearchPeopleDay.Hide();
                this.Refresh();
                System.Threading.Thread.Sleep(50);
                _waitform.sValue = "查询中 请稍等.......";
                _waitform.Show();
                frmSearchPeopleDay.Dispose();
                DataTable dtActualdays = null;
                try
                {
                    dtActualdays = WSAL.WSActualdays.GetList(Where);
                    if (dtActualdays == null || dtActualdays.Rows.Count <= 0)
                    {
                        _waitform.Hide();
                        MessageBox.Show("没有符合条件的查询结果！");
                    }
                    else
                    {
                        dgvActualdays.DataSource = dtActualdays;
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

        private void dgvActualdays_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                    string ActualdaysID = dgvActualdays.Rows[e.RowIndex].Cells["actualdaysid"].Value.ToString();
                    dgvActualdaysSub.DataSource = WSAL.WSActualdays.GetSubList(ActualdaysID);
                    //dgvSubContract.DataSource = WSAL.WSContract.GetSubList(string.Format("contractid='{0}'", ContractID));
                }
                catch
                { }
                _waitform.Hide();
            }
        }
    }
}

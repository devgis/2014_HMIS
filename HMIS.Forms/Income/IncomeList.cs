using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Income
{
    public partial class IncomeList : Form
    {
        private string subcontractid;
        public IncomeList(string SubContractId)
        {
            InitializeComponent();
            try
            {
                this.subcontractid = SubContractId;
                dgvShouKuanList.DataSource = WSAL.WSIncome.GetListBySubContract(SubContractId);
            }
            catch
            {
                MessageBox.Show("获取收款历史出错，请稍候重试！");
                this.Dispose();
            }
            
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (dgvShouKuanList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择合同进行查看！");
                return;
            }
            else
            {
                try
                {
                    string IncomeId = dgvShouKuanList.SelectedRows[0].Cells["incomeid"].Value.ToString();
                    if (WSAL.WSIncome.Delete(IncomeId))
                    {
                        MessageBox.Show("删除成功！");
                        dgvShouKuanList.Rows.Remove(dgvShouKuanList.SelectedRows[0]);
                    }
                }
                catch
                {
                    MessageBox.Show("删除失败，请稍候再试！");
                }
            }
        }
    }
}

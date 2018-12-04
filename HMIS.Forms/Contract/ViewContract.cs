using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Contract
{
    public partial class ViewContract : Form
    {
        private string ContractID;
        public ViewContract(String ContractID)
        {
            InitializeComponent();
            this.ContractID = ContractID;
            try
            {
                UfidaPMS.Models.Contract model = WSAL.WSContract.GetModel(ContractID);
                if (model == null)
                {
                    MessageBox.Show("加载数据中发生错误，请稍候再试！");
                    this.Dispose();
                }
                else
                {
                    tbContractNo.Text = model.contractno;
                    tbCreateDate.Text = model.contractdate.Value.ToShortDateString();
                    tbCustManager.Text = model.custmanager;
                    tbCustName.Text = model.custname;
                    tbDepartmen.Text = model.department;
                    tbRemarks.Text = model.remarks;
                    tbTrade.Text = model.trade;
                    dgvSubContractList.DataSource = model.DSSubContract.Tables[0];
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
            if (MessageBox.Show("确认删除当前合同？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    int iResult = WSAL.WSContract.Delete(ContractID);
                    if (iResult == 0)
                    {
                        MessageBox.Show("删除失败！");
                    }
                    else if (iResult < 0)
                    {
                        MessageBox.Show("删除失败,可能当前合同子合同已经被引用！");
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
                EditContract frmEditContract = new EditContract(ContractID);
                frmEditContract.MdiParent = this.MdiParent;
                frmEditContract.WindowState = FormWindowState.Maximized;
                frmEditContract.Show();
            }
            catch
            {
                MessageBox.Show("加载数据出错，请稍候再试！");
            }
        }
    }
}

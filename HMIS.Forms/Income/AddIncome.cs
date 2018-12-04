using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Income
{
    public partial class AddIncome : Form
    {
        bool bSave = false;
        public string SubCoractID
        {
            set;
            get;
        }
        public AddIncome(string ContractNo, string SubCoractNo, string SubCoractID)
        {
            InitializeComponent();
            this.SubCoractID = SubCoractID;
            cbContract.Text = ContractNo;
            cbContract.ReadOnly = true;
            cbSubContract.Text = SubCoractNo;
            cbSubContract.ReadOnly = true;
            cbIncomer.Text = LoginForm.UserName;
            cbIncomer.ReadOnly = true;
        }

        #region 通用方法
        /// <summary>
        /// 校验数据
        /// </summary>
        /// <returns></returns>
        private bool CheckData()
        {
            if (tbAmount.Text.Trim() == "")
            {
                MessageBox.Show("请输入收款金额!");
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(tbAmount.Text);
                }
                catch
                {
                    MessageBox.Show("收款金额必须为整数!");
                    return false;
                }
            }
            if (dtpIncomeDate.Value == null)
            {
                MessageBox.Show("请选择收款日期!");
                return false;
            }
            if (cbIncomer.Text.Trim() == "")
            {
                MessageBox.Show("请输入收款人!");
                return false;
            }
            return true;
        }
        /// <summary>
        /// 获取对象模型
        /// </summary>
        /// <returns></returns>
        private UfidaPMS.Models.Income GetModel()
        {
            UfidaPMS.Models.Income model = new Models.Income();
            model.incomeamount = Convert.ToInt32(tbAmount.Text);
            model.incomedate = dtpIncomeDate.Value.Date;
            model.incomeid = "";
            model.incomeuserid = cbIncomer.Text;
            model.subcontractid = this.SubCoractID;
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
                SResult = WSAL.WSIncome.Add(GetModel());
            }
            catch
            { }
            return SResult;
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
                        MessageBox.Show("保存成功!");
                        tbAmount.Text = "";
                        bSave = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(tbAmount.Text);
            }
            catch
            {
                tbAmount.Text = "";
            }
        }
    }
}

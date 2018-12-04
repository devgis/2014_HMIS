using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UfidaPMS.Models;

namespace UfidaPMS.Forms.Contract
{
    public partial class AddContract : Form
    {
        bool bSave = false;
        public AddContract()
        {
            InitializeComponent();
            try
            {
                DataSet Ds = WSAL.WSDictonary.GetAllDict();
                cbCustName.DataSource = Ds.Tables["custname"];
                cbCustName.DisplayMember = "custname";
                cbCustName.ValueMember = "custname";

                cbDepartMent.DataSource = Ds.Tables["department"];
                cbDepartMent.DisplayMember = "department";
                cbDepartMent.ValueMember = "department";

                cbCustManager.DataSource = Ds.Tables["custmanager"];
                cbCustManager.DisplayMember = "custmanager";
                cbCustManager.ValueMember = "custmanager";

                cbTrade.DataSource = Ds.Tables["trade"];
                cbTrade.DisplayMember = "trade";
                cbTrade.ValueMember = "trade";
            }
            catch
            {
                MessageBox.Show("初始化数据发生错误，请稍候再试！");
                this.Dispose();
            }
            
        }
        #region 事件
        private void dgvSubContractList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvSubContractList.Rows[dgvSubContractList.Rows.Count - 1].Cells["Index"].Value = dgvSubContractList.Rows.Count - 1;
        }

        private void dgvSubContractList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i <= dgvSubContractList.Rows.Count - 1; i++)
            {
                dgvSubContractList.Rows[i].Cells["Index"].Value = i;
            }
        }
        private void dgvSubContractList_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i <= dgvSubContractList.Rows.Count - 1; i++)
            {
                dgvSubContractList.Rows[i].Cells["Index"].Value = i;
            }
        }

        private void tsmiAddRow_Click(object sender, EventArgs e)
        {
            dgvSubContractList.Rows.Add();
        }

        private void tsmiDeleteRow_Click(object sender, EventArgs e)
        {
            if(dgvSubContractList.SelectedRows.Count<=0)
            {
                MessageBox.Show("请选择行进行删除！");
                return;
            }
            if (MessageBox.Show("确认删除当前选中行？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                foreach (DataGridViewRow dgvr in dgvSubContractList.SelectedRows)
                {
                    try
                    {
                        dgvSubContractList.Rows.Remove(dgvr);
                    }
                    catch
                    { }
                }
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
               dgvSubContractList.EndEdit();
            }
            catch
            { }
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
                        bSave = true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error:"+ex.Message);
                }
            }
        }
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
        #endregion

        #region 通用方法
        /// <summary>
        /// 校验数据
        /// </summary>
        /// <returns></returns>
        private bool CheckData()
        {
            if (dtpCreateDate.Value == null)
            {
                MessageBox.Show("请选择创建时间!");
                return false;
            }
            if (tbContractNo.Text.Trim() == "")
            {
                MessageBox.Show("请输入主合同号!");
                return false;
            }
            if (cbCustName.Text.Trim() == "")
            {
                MessageBox.Show("请输入客户名称!");
                return false;
            }
            if (cbDepartMent.Text.Trim() == "")
            {
                MessageBox.Show("请输入部门!");
                return false;
            }
            if (cbCustManager.Text.Trim() == "")
            {
                MessageBox.Show("请输入客户经理!");
                return false;
            }
            if (dgvSubContractList.Rows.Count == 0)
            {
                MessageBox.Show("请至少包含一条子合同!");
                return false;
            }

            for (int i = 0; i < dgvSubContractList.Rows.Count; i++)
            {
                DataGridViewRow dgvr = dgvSubContractList.Rows[i];
                if (dgvr.Cells["SubContractNo"].Value == null || dgvr.Cells["SubContractNo"].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("子项目第" + i + "行子合同号不能为空，请检查!");
                    return false;
                }
                if (dgvr.Cells["ContractType"].Value == null || dgvr.Cells["ContractType"].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("子项目第" + i + "行子合同类型不能为空，请检查!");
                    return false;
                }
                if (dgvr.Cells["makecondition"].Value == null || dgvr.Cells["makecondition"].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("子项目第" + i + "行子合同收款条件不能为空，请检查!");
                    return false;
                }
                if (dgvr.Cells["contractamount"].Value == null || dgvr.Cells["contractamount"].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("子项目第" + i + "行子合同金额不能为空，请检查!");
                    return false;
                }
                else
                {
                    try
                    {
                        Convert.ToInt32(dgvr.Cells["contractamount"].Value);
                    }
                    catch
                    {
                        MessageBox.Show("子项目第" + i + "行子合同金额应该为整数，请检查!");
                        return false;
                    }
                }
            }
            try
            {
                if (!WSAL.WSContract.CheckContractNo(tbContractNo.Text))
                {
                    MessageBox.Show("主合同号已存在，请检查!");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("检查主合同号出错，请稍候再试!");
                return false;
            }
            return true;
        }
        /// <summary>
        /// 获取对象模型
        /// </summary>
        /// <returns></returns>
        private UfidaPMS.Models.Contract GetModel()
        {
            UfidaPMS.Models.Contract model = new Models.Contract();
            model.contractdate = dtpCreateDate.Value;
            model.contractno = tbContractNo.Text;
            model.custmanager = cbCustManager.Text;
            model.custname = cbCustName.Text;
            model.department = cbDepartMent.Text;
            model.remarks = tbRemarks.Text;
            model.trade = cbTrade.Text;
            model.SubContractList = new List<Models.SubContract>();
            foreach (DataGridViewRow dgvr in dgvSubContractList.Rows)
            {
                SubContract s = new SubContract();
                s.contractamount = Convert.ToInt32(dgvr.Cells["contractamount"].Value);
                s.contractid = "";
                s.makecondition = dgvr.Cells["makecondition"].Value.ToString();
                try
                {
                    s.productversion = dgvr.Cells["productversion"].Value.ToString();
                }
                catch
                {
                    s.productversion = "";
                }
                s.subcontractid = "";
                s.subcontractno = dgvr.Cells["SubContractNo"].Value.ToString();
                s.subcontracttype = dgvr.Cells["ContractType"].Value.ToString();
                model.SubContractList.Add(s);
            }
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
                SResult = WSAL.WSContract.Add(GetModel());
            }
            catch
            { }
            return SResult;
        }
        #endregion
    }
}

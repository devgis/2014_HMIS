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
    public partial class EditContract : Form
    {
        bool bSave = false;
        private string ContractId;
        public EditContract(string ContractId)
        {
            InitializeComponent();
            this.ContractId = ContractId;
            try
            {
                UfidaPMS.Models.Contract model = WSAL.WSContract.GetModel(ContractId);
                if (model == null)
                {
                    MessageBox.Show("加载数据中发生错误，请稍候再试！");
                    this.Dispose();
                }
                else
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

                    tbContractNo.Text = model.contractno;
                    dtpCreateDate.Value = model.contractdate.Value;
                    cbCustManager.Text = model.custmanager;
                    cbCustName.Text = model.custname;
                    cbDepartMent.Text = model.department;
                    tbRemarks.Text = model.remarks;
                    cbTrade.Text = model.trade;
                    dgvSubContractList.DataSource = model.DSSubContract.Tables[0];
                }
            }
            catch
            {
                MessageBox.Show("加载数据中发生错误，请稍候再试！");
                this.Dispose();
            }
        }

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
            return true;
        }
        /// <summary>
        /// 获取对象模型
        /// </summary>
        /// <returns></returns>
        private UfidaPMS.Models.Contract GetModel()
        {
            UfidaPMS.Models.Contract model = new Models.Contract();
            model.contractid = this.ContractId;
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
                s.contractid = ContractId;
                s.makecondition = dgvr.Cells["makecondition"].Value.ToString();
                try
                {
                    s.productversion = dgvr.Cells["productversion"].Value.ToString();
                }
                catch
                {
                    s.productversion = "";
                }
                s.subcontractid = dgvr.Cells["subcontractid"].Value.ToString();
                s.subcontractno = dgvr.Cells["SubContractNo"].Value.ToString();
                s.subcontracttype = dgvr.Cells["ContractType"].Value.ToString();
                if (dgvr.Cells["IsAdd"].Value != null && dgvr.Cells["IsAdd"].Value.ToString().Trim() != "")
                {
                    if (dgvr.Cells["IsAdd"].Value.ToString().Trim() == "add")
                    {
                        s.IsNewAdd = true;
                    }
                }
                model.SubContractList.Add(s);
            }
            return model;
        }
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <returns>成功则返回主表ID</returns>
        private bool SaveDate()
        {
            bool bResult = false;
            try
            {
                bResult = WSAL.WSContract.Update(GetModel());
            }
            catch
            { }
            return bResult;
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
                    if (SaveDate())
                    {
                        MessageBox.Show("保存成功!");
                        bSave = true;
                    }
                    else
                    {
                        MessageBox.Show("保存失败!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void tsmiDeleteRow_Click(object sender, EventArgs e)
        {
            if (dgvSubContractList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择子合同进行删除！");
            }
            else
            {
                if (MessageBox.Show("确认删除当前选中行？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        string SubContractID = dgvSubContractList.SelectedRows[0].Cells["subcontractid"].Value.ToString();
                        int iResult = WSAL.WSContract.DeleteSub(SubContractID);
                        if (iResult > 0)
                        {
                            dgvSubContractList.Rows.Remove(dgvSubContractList.SelectedRows[0]);
                            MessageBox.Show("删除成功！");
                        }
                        else if (iResult == 0)
                        {
                            MessageBox.Show("删除失败！");
                        }
                        else if (iResult < 0)
                        {
                            MessageBox.Show("当前子合同不允许删除！");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("删除失败，错误信息：" + ex.Message);
                    }
                }
                

            }
        }

        private void tsmiAddRow_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtTemp = dgvSubContractList.DataSource as DataTable;
                dtTemp.Rows.Add(dtTemp.NewRow());
                dgvSubContractList.DataSource = dtTemp;
            }
            catch
            { }
        }

        private void dgvSubContractList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                if (dgvSubContractList.Rows[e.RowIndex].Cells["subcontractid"].Value == null || dgvSubContractList.Rows[e.RowIndex].Cells["subcontractid"].Value.ToString().Trim()=="")
                {
                    dgvSubContractList.Rows[e.RowIndex].Cells["e.RowIndex IsAdd"].Value = "add";
                }
            }
            catch
            { }
        }

        private void dgvSubContractList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除当前合同？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    int iResult = WSAL.WSContract.Delete(ContractId);
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
    }
}

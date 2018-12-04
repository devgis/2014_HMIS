using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Contract
{
    public partial class ContractList : Form
    {
        private readonly WaitForm _waitform = new WaitForm();
        DataSet dsSource;
        public ContractList()
        {
            InitializeComponent();
            try
            {
                dsSource = WSAL.WSDictonary.GetAllDict();
            }
            catch
            { }
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            SearchContract frmSearchContract = new SearchContract(dsSource);
            if (frmSearchContract.ShowDialog() == DialogResult.OK)
            {
                string Where = frmSearchContract.Where;
                frmSearchContract.Hide();
                this.Refresh();
                System.Threading.Thread.Sleep(50);
                _waitform.sValue = "查询中 请稍等.......";
                _waitform.Show();
                frmSearchContract.Dispose();
                
                DataTable dt = null;
                try
                {
                    dt = WSAL.WSContract.GetList(Where);
                }
                catch
                { }
                if (dt == null)
                {
                    _waitform.Hide();
                    MessageBox.Show("查询数据发生错误!");
                    return;
                }
                else if (dt.Rows.Count <= 0)
                {
                    _waitform.Hide();
                    MessageBox.Show("没有符合条件的查询结果");
                    return;
                }
                dgvContract.DataSource = dt;
                _waitform.Hide();
            }
            
        }

        private void dgvContract_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                    string ContractID = dgvContract.Rows[e.RowIndex].Cells["contractid"].Value.ToString();
                    dgvSubContract.DataSource = WSAL.WSContract.GetSubList(string.Format("contractid='{0}'", ContractID));
                }
                catch
                {}
                _waitform.Hide();
            }
        }

        private void dgvSubContract_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i <= dgvSubContract.Rows.Count - 1; i++)
            {
                dgvSubContract.Rows[i].Cells["序号"].Value = i;
            }
        }

        private void dgvSubContract_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i <= dgvSubContract.Rows.Count - 1; i++)
            {
                dgvSubContract.Rows[i].Cells["序号"].Value = i;
            }
            
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tsmiCreateProject_Click(object sender, EventArgs e)
        {
            if (dgvSubContract.SelectedRows.Count <= 0)
            {
                MessageBox.Show("选择子合进行立项！");
            }
            else
            {
                string ContractType = dgvSubContract.SelectedRows[0].Cells["合同类型"].Value.ToString();
                if (ContractType == "软件合同" || ContractType == "服务合同" || ContractType == "培训合同")
                {
                    MessageBox.Show("软件合同,服务合同,培训合同不能立项！");
                    return;
                }

                string ContractNo=dgvSubContract.SelectedRows[0].Cells["contractno"].Value.ToString();
                string SubCoractNo=dgvSubContract.SelectedRows[0].Cells["子合同号"].Value.ToString();
                string SubCoractID=dgvSubContract.SelectedRows[0].Cells["subcontractid"].Value.ToString();

                try
                {
                    if (!WSAL.WSProject.CheckSubContractProject(SubCoractID))
                    {
                        MessageBox.Show("已立项，不能重复立项！");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("检查项目信息出错，请稍候再试！");
                    return;
                }
                int ContractAmount = Convert.ToInt32(dgvSubContract.SelectedRows[0].Cells["合同金额"].Value);
                try
                {
                    Project.AddProject frmAddProject = new Project.AddProject(ContractNo, SubCoractNo, SubCoractID, ContractAmount);
                    frmAddProject.MdiParent = this.MdiParent;
                    frmAddProject.WindowState = FormWindowState.Maximized;
                    frmAddProject.Show();
                }
                catch
                { }
                
            }
        }

        private void tsmiShouKuan_Click(object sender, EventArgs e)
        {
            if (dgvSubContract.SelectedRows.Count <= 0)
            {
                MessageBox.Show("选择子合同进行收款！");
            }
            else
            {
                //string ContractType = dgvSubContract.SelectedRows[0].Cells["合同类型"].Value.ToString();
                //if (ContractType == "软件合同" || ContractType == "服务合同" || ContractType == "培训合同")
                //{
                //    MessageBox.Show("软件合同,服务合同,培训合同不能收款！");
                //    return;
                //}
                string ContractNo = dgvSubContract.SelectedRows[0].Cells["contractno"].Value.ToString();
                string SubCoractNo = dgvSubContract.SelectedRows[0].Cells["子合同号"].Value.ToString();
                string SubCoractID = dgvSubContract.SelectedRows[0].Cells["subcontractid"].Value.ToString();
                try
                {
                    Income.AddIncome frmAddIncome = new Income.AddIncome(ContractNo, SubCoractNo, SubCoractID);
                    frmAddIncome.MdiParent = this.MdiParent;
                    frmAddIncome.WindowState = FormWindowState.Maximized;
                    frmAddIncome.Show();
                }
                catch
                { }

            }
        }

        private void tsmiView_Click(object sender, EventArgs e)
        {
            if (dgvContract.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择合同进行查看！");
                return;
            }
            else
            {
                try
                {
                    string ContractId=dgvContract.SelectedRows[0].Cells["contractid"].Value.ToString();
                    ViewContract frmViewContract=new ViewContract(ContractId);
                    frmViewContract.MdiParent=this.MdiParent;
                    frmViewContract.WindowState=FormWindowState.Maximized;
                    frmViewContract.Show();
                }
                catch
                {}
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (dgvContract.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择合同进行编辑！");
                return;
            }
            else
            {
                try
                {
                    string ContractId = dgvContract.SelectedRows[0].Cells["contractid"].Value.ToString();
                    EditContract frmEditContract = new EditContract(ContractId);
                    frmEditContract.MdiParent = this.MdiParent;
                    frmEditContract.WindowState = FormWindowState.Maximized;
                    frmEditContract.Show();
                }
                catch
                { }
            }
        }

        private void ContractList_Load(object sender, EventArgs e)
        {
            switch (LoginForm.UserType)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    tsmiSave.Visible = false;
                    tsmiShouKuan.Visible = false;
                    tsmiCreateProject.Visible = false;
                    tsmiShouKuanList.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void tsmiShouKuanList_Click(object sender, EventArgs e)
        {
            if (dgvSubContract.SelectedRows.Count <= 0)
            {
                MessageBox.Show("选择子合同查看！");
            }
            else
            {

                string SubCoractID = dgvSubContract.SelectedRows[0].Cells["subcontractid"].Value.ToString();
                try
                {
                    Income.IncomeList frmIncomeList = new Income.IncomeList(SubCoractID);
                    frmIncomeList.MdiParent = this.MdiParent;
                    frmIncomeList.WindowState = FormWindowState.Maximized;
                    frmIncomeList.Show();
                }
                catch
                { }

            }
        }

        
    }
}

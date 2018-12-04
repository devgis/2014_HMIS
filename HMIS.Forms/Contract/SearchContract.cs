using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Contract
{
    public partial class SearchContract : Form
    {
        public string Where
        {
            get;
            set;
        }
        //public SearchContract()
        //{
        //    InitializeComponent();
        //}
        public SearchContract(DataSet dtDepartmentSource)
        {
            InitializeComponent();
            try
            {
                tbDepartMent.DataSource = dtDepartmentSource.Tables["department"];
                tbDepartMent.DisplayMember = "department";
                tbDepartMent.ValueMember = "department";
                //tbDepartMent.Items.Add("");
                

                tbCustManager.DataSource = dtDepartmentSource.Tables["custmanager"];
                tbCustManager.DisplayMember = "custmanager";
                tbCustManager.ValueMember = "custmanager";
                
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
            if (cbEndleEnable.Checked && cbStartEnable.Checked)
            {
                if ((dtpEnd.Value.Date - dtpStart.Value.Date).TotalDays < 0)
                {
                    MessageBox.Show("最大日期必须大于或者等于最小日期！");
                }
            }
            Where += " 1=1 ";
            if (cbStartEnable.Checked)
            {
                Where += string.Format(" and contractdate>='{0}'", dtpStart.Value.ToShortDateString());
            }
            if (cbEndleEnable.Checked)
            {
                Where += string.Format("and contractdate<='{0}'", dtpEnd.Value.ToShortDateString());
            }
            if (tbContractNo.Text.Trim() != "")
            {
                Where += string.Format("and contractno like '%{0}%'",tbContractNo.Text);
            }
            if (tbCustName.Text.Trim() != "")
            {
                Where += string.Format("and custname like '%{0}%'",tbCustName.Text);
            }
            if (tbDepartMent.Text.Trim() != "")
            {
                Where += string.Format("and department like '%{0}%'",tbDepartMent.Text);
            }
            if (tbCustManager.Text.Trim() != "")
            {
                Where += string.Format("and custmanager like '%{0}%'",tbCustManager.Text);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FYSOFT.HMIS.Forms.UserManager
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void tsmiCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认退出？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void tsmiAddRow_Click(object sender, EventArgs e)
        {
            AddUser frmAddUser = new AddUser();
            frmAddUser.ShowDialog();
            LoadData();
        }

        private void tsmiRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvUserList.DataSource = new FYSOFT.HMIS.Bll.User().GetList("").Tables[0];
            }
            catch
            {
                MessageBox.Show("加载数据出错，请稍候再试！");
            }
        }

        private void tsmiDeleteRow_Click(object sender, EventArgs e)
        {
            if (dgvUserList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择用户进行删除！");
            }
            else
            {
                try
                {
                    string UserId = dgvUserList.SelectedRows[0].Cells["UserID"].Value.ToString();
                    if (new FYSOFT.HMIS.Bll.User().Delete(UserId))//WSAL.WSUser.Delete(UserId)
                    {
                        MessageBox.Show("删除成功！");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("出错:"+ex.Message);
                }
            }
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {

            if (dgvUserList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择用户进行删除！");
            }
            else
            {
                try
                {
                    string UserId = dgvUserList.SelectedRows[0].Cells["UserID"].Value.ToString();
                    EditUser frmEditUser = new EditUser(UserId);
                    frmEditUser.ShowDialog();
                    LoadData();
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("加载用户出错:"+ex.Message);
                }
            }
        }
    }
}

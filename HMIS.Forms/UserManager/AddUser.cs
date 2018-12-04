using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FYSOFT.HMIS.Forms.UserManager
{
    public partial class AddUser : Form
    {
        public AddUser()
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

        private void AddUser_Load(object sender, EventArgs e)
        {
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                try
                {
                    int iResult = SaveDate();
                    if (iResult<=0)
                    {
                        MessageBox.Show("保存失败!");
                    }
                    else
                    {
                        MessageBox.Show("保存成功!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }
        #region 通用方法
        /// <summary>
        /// 校验数据
        /// </summary>
        /// <returns></returns>
        private bool CheckData()
        {
            if (tbUserName.Text.Trim() =="" )
            {
                MessageBox.Show("请输入用户名!");
                return false;
            }
            if (tbUserPassword.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户密码!");
                return false;
            }
            try
            {
                if (!(new FYSOFT.HMIS.Bll.User().CheckUserName(tbUserName.Text))) //!WSAL.WSUser.CheckUserName(tbUserName.Text)
                {
                    MessageBox.Show("用户名已存在，请检查!");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("检查用户名失败，请稍候再试!");
                return false;
            }
            return true;
        }
        /// <summary>
        /// 获取对象模型
        /// </summary>
        /// <returns></returns>
        private FYSOFT.HMIS.Models.User GetModel()
        {
            FYSOFT.HMIS.Models.User model = new Models.User();
            model.UserName = tbUserName.Text;
            model.UserPassword = tbUserPassword.Text;
            return model;
        }
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <returns>成功则返回主表ID</returns>
        private int SaveDate()
        {
            int i = 0;
            try
            {
                i = new FYSOFT.HMIS.Bll.User().Add(GetModel());
            }
            catch
            { }
            return i;
        }
        #endregion

    }
}

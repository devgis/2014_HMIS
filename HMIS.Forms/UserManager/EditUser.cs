using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FYSOFT.HMIS.Forms.UserManager
{
    public partial class EditUser : Form
    {
        private String UserID
        {
            get;
            set;
        }
        public EditUser(string UserId)
        {
            InitializeComponent();
            try
            {
                FYSOFT.HMIS.Models.User u = new FYSOFT.HMIS.Bll.User().GetModel(UserId); 
                tbUserName.Text = u.UserName;
                tbUserName.ReadOnly = true;
                tbPassWord.Text = u.UserPassword;
                this.UserID = UserId;
            }
            catch
            {
                this.Dispose();
            }
        }

        private void tsmiCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认退出？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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
                    if (!SaveDate())
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
            if (tbUserName.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名!");
                return false;
            }
            if (tbPassWord.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户密码!");
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
            model.UserID = this.UserID;
            model.UserName = tbUserName.Text;
            model.UserPassword = tbPassWord.Text;
            return model;
        }
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <returns>成功则返回主表ID</returns>
        private bool SaveDate()
        {
            bool i =false;
            try
            {
                i = new FYSOFT.HMIS.Bll.User().Update(GetModel());
            }
            catch
            { }
            return i;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FYSOFT.HMIS.Forms
{
    public partial class LoginForm : Form
    {
        private readonly WaitForm _waitform = new WaitForm();
        public static string UserName="";
        public static int UserType = 2;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.Trim() == "" || tbUserName.Text.Trim() == "")
            {
                MessageBox.Show("用户名密码不能为空，请重输！");
            }
            else
            {
                _waitform.sValue = "登录中，请稍等......";
                this.Visible = false;
                _waitform.Show();
                try
                {
                    
                    int iResult =new FYSOFT.HMIS.Bll.User().CheckPassWord(tbUserName.Text, tbPassword.Text);
                    if (iResult == 1)
                    {
                        UserName = tbUserName.Text;
                        MainForm frmMain = new MainForm();
                        frmMain.Show();
                        _waitform.Hide();
                    }
                    else if (iResult == -1)
                    {
                        _waitform.Hide();
                        this.Visible = true;
                        MessageBox.Show("用户不存在，请重输！");
                        tbUserName.Clear();
                        tbPassword.Clear();
                        tbUserName.Focus();
                    }
                    else if (iResult == 0)
                    {
                        _waitform.Hide();
                        this.Visible = true;
                        MessageBox.Show("密码错误，请重输！");
                        tbPassword.Clear();
                        tbPassword.Focus();
                    }
                }
                catch
                {
                    _waitform.Hide();
                    this.Visible = true;
                    MessageBox.Show("发生未知错误！");
                }
                
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}

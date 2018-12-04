using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FYSOFT.HMIS.Forms.BasicForm;
using FYSOFT.HMIS.Common;

namespace FYSOFT.HMIS.Forms
{
    public partial class MainForm : Form
    {
        private readonly WaitForm _waitform = new WaitForm();
        public MainForm()
        {
            InitializeComponent();
            stlUserName.Text = "当前用户:" + LoginForm.UserName;
        }
        #region 系统管理
        private void mi_Exit_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MessageBox.Show("当前窗口包含未关闭窗口，您认要退出？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Application.ExitThread();
                }
            }
            else
            {
                Application.ExitThread();
            }
        }

        private void mi_Relogin_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MessageBox.Show("当前窗口包含未关闭窗口，您认要重新启动？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Application.ExitThread();
                }
            }
            else
            {
                Application.ExitThread();
            }
            Application.Restart();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MessageBox.Show("当前窗口包含子窗体，您确定要关闭当前窗口及其子窗体么？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Application.ExitThread();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                Application.ExitThread();
            }
        }

        private void mi_User_Click(object sender, EventArgs e)
        {
            FYSOFT.HMIS.Forms.UserManager.UserList frmUserList = new UserManager.UserList();
            this.ShowMdiForm(frmUserList);
        }
        private void mi_ChgUserPW_Click(object sender, EventArgs e)
        {
            FYSOFT.HMIS.Forms.UserManager.ChgPassWord frmChgPassWord = new UserManager.ChgPassWord(LoginForm.UserName);
            frmChgPassWord.ShowDialog();
        }
        #endregion

        #region 工具栏
        #region 子窗体平铺
        private void mi_ShuiPing_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mi_TuBiao_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);

        }

        private void mi_CengDie_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mi_ChuiZhi_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        #endregion
        private void tmi_CloseAll_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MessageBox.Show("您确定要关闭当前所有子窗体？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (Form f in this.MdiChildren)
                    {
                        try
                        {
                            f.Dispose();
                        }
                        catch
                        { }
                    }
                }
            }
        }
        #endregion

        #region 帮助关于
        private void miHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂无!");
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            HelpAbout.AboutBox frmAboutBox = new HelpAbout.AboutBox();
            frmAboutBox.ShowDialog();
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        #region 基础资料维护
        //银行卡管理
        private void MI_BankCard_Click(object sender, EventArgs e)
        {
            DictList frmDictList = new DictList("银行卡");
            this.ShowMdiForm(frmDictList);
        }
        //信用卡管理
        private void MI_XinYongKa(object sender, EventArgs e)
        {
            DictList frmDictList = new DictList("信用卡");
            this.ShowMdiForm(frmDictList);
        }
        //收入类型
        private void MI_ShouruType_Click(object sender, EventArgs e)
        {
            DictList frmDictList = new DictList("收入类型");
            this.ShowMdiForm(frmDictList);
        }
        //支出类型
        private void MI_ZhiChuType_Click(object sender, EventArgs e)
        {
            DictList frmDictList = new DictList("支出类型");
            this.ShowMdiForm(frmDictList);
        }
        #endregion

        #region 通用方法
        /// <summary>
        /// 在MDI子窗体中加载当前窗体
        /// </summary>
        /// <param name="FDialog"></param>
        public void ShowMdiForm(Form MdiChildForm)
        {
            CommonHelper.ShowMdiForm(MdiChildForm, this);
        }
        #endregion

        
    }
}

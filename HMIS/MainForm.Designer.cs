namespace FYSOFT.HMIS.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_system = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_PingPU = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ShuiPing = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_TuBiao = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_CengDie = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ChuiZhi = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Relogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_User = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ChgUserPW = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Basic = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_BankCard = new System.Windows.Forms.ToolStripMenuItem();
            this.信用卡管理XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MI_ShouruType = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_ZhiChuType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_hetong = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddContract = new System.Windows.Forms.ToolStripMenuItem();
            this.miContractList = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_project = new System.Windows.Forms.ToolStripMenuItem();
            this.miProjectList = new System.Windows.Forms.ToolStripMenuItem();
            this.miSubProjectList = new System.Windows.Forms.ToolStripMenuItem();
            this.miStatueList = new System.Windows.Forms.ToolStripMenuItem();
            this.miPeopleDayList = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_reports = new System.Windows.Forms.ToolStripMenuItem();
            this.miWeekStateReport = new System.Windows.Forms.ToolStripMenuItem();
            this.miMileStoneReport = new System.Windows.Forms.ToolStripMenuItem();
            this.miPeopleDayReport = new System.Windows.Forms.ToolStripMenuItem();
            this.miProjectWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_helpabout = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tmi_PingPU = new System.Windows.Forms.ToolStripDropDownButton();
            this.tmi_ShuiPing = new System.Windows.Forms.ToolStripMenuItem();
            this.tmi_TuBiao = new System.Windows.Forms.ToolStripMenuItem();
            this.tmi_CengDie = new System.Windows.Forms.ToolStripMenuItem();
            this.tmi_ChuiZhi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tmi_CloseAll = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stlUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_system,
            this.menu_Basic,
            this.menu_hetong,
            this.menu_project,
            this.menu_reports,
            this.menu_helpabout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_system
            // 
            this.menu_system.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_PingPU,
            this.mi_Relogin,
            this.mi_User,
            this.mi_ChgUserPW,
            this.mi_Exit});
            this.menu_system.Image = ((System.Drawing.Image)(resources.GetObject("menu_system.Image")));
            this.menu_system.Name = "menu_system";
            this.menu_system.Size = new System.Drawing.Size(100, 21);
            this.menu_system.Text = "系统维护(&X)";
            // 
            // mi_PingPU
            // 
            this.mi_PingPU.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_ShuiPing,
            this.mi_TuBiao,
            this.mi_CengDie,
            this.mi_ChuiZhi});
            this.mi_PingPU.Image = ((System.Drawing.Image)(resources.GetObject("mi_PingPU.Image")));
            this.mi_PingPU.Name = "mi_PingPU";
            this.mi_PingPU.Size = new System.Drawing.Size(141, 22);
            this.mi_PingPU.Text = "排列窗体(&P)";
            // 
            // mi_ShuiPing
            // 
            this.mi_ShuiPing.Image = ((System.Drawing.Image)(resources.GetObject("mi_ShuiPing.Image")));
            this.mi_ShuiPing.Name = "mi_ShuiPing";
            this.mi_ShuiPing.Size = new System.Drawing.Size(140, 22);
            this.mi_ShuiPing.Text = "水平平铺(&S)";
            this.mi_ShuiPing.Click += new System.EventHandler(this.mi_ShuiPing_Click);
            // 
            // mi_TuBiao
            // 
            this.mi_TuBiao.Image = ((System.Drawing.Image)(resources.GetObject("mi_TuBiao.Image")));
            this.mi_TuBiao.Name = "mi_TuBiao";
            this.mi_TuBiao.Size = new System.Drawing.Size(140, 22);
            this.mi_TuBiao.Text = "图标平铺(&T)";
            this.mi_TuBiao.Visible = false;
            this.mi_TuBiao.Click += new System.EventHandler(this.mi_TuBiao_Click);
            // 
            // mi_CengDie
            // 
            this.mi_CengDie.Image = ((System.Drawing.Image)(resources.GetObject("mi_CengDie.Image")));
            this.mi_CengDie.Name = "mi_CengDie";
            this.mi_CengDie.Size = new System.Drawing.Size(140, 22);
            this.mi_CengDie.Text = "层叠平铺(&C)";
            this.mi_CengDie.Click += new System.EventHandler(this.mi_CengDie_Click);
            // 
            // mi_ChuiZhi
            // 
            this.mi_ChuiZhi.Image = ((System.Drawing.Image)(resources.GetObject("mi_ChuiZhi.Image")));
            this.mi_ChuiZhi.Name = "mi_ChuiZhi";
            this.mi_ChuiZhi.Size = new System.Drawing.Size(140, 22);
            this.mi_ChuiZhi.Text = "垂直平铺(Z)";
            this.mi_ChuiZhi.Click += new System.EventHandler(this.mi_ChuiZhi_Click);
            // 
            // mi_Relogin
            // 
            this.mi_Relogin.Image = ((System.Drawing.Image)(resources.GetObject("mi_Relogin.Image")));
            this.mi_Relogin.Name = "mi_Relogin";
            this.mi_Relogin.Size = new System.Drawing.Size(141, 22);
            this.mi_Relogin.Text = "重新登录(&R)";
            this.mi_Relogin.Click += new System.EventHandler(this.mi_Relogin_Click);
            // 
            // mi_User
            // 
            this.mi_User.Name = "mi_User";
            this.mi_User.Size = new System.Drawing.Size(141, 22);
            this.mi_User.Text = "用户管理(&U)";
            this.mi_User.Click += new System.EventHandler(this.mi_User_Click);
            // 
            // mi_ChgUserPW
            // 
            this.mi_ChgUserPW.Name = "mi_ChgUserPW";
            this.mi_ChgUserPW.Size = new System.Drawing.Size(141, 22);
            this.mi_ChgUserPW.Text = "修改密码(&X)";
            this.mi_ChgUserPW.Click += new System.EventHandler(this.mi_ChgUserPW_Click);
            // 
            // mi_Exit
            // 
            this.mi_Exit.Image = ((System.Drawing.Image)(resources.GetObject("mi_Exit.Image")));
            this.mi_Exit.Name = "mi_Exit";
            this.mi_Exit.Size = new System.Drawing.Size(141, 22);
            this.mi_Exit.Text = "退出系统(&E)";
            this.mi_Exit.Click += new System.EventHandler(this.mi_Exit_Click);
            // 
            // menu_Basic
            // 
            this.menu_Basic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_BankCard,
            this.信用卡管理XToolStripMenuItem,
            this.toolStripSeparator1,
            this.MI_ShouruType,
            this.MI_ZhiChuType,
            this.toolStripSeparator2});
            this.menu_Basic.Name = "menu_Basic";
            this.menu_Basic.Size = new System.Drawing.Size(81, 21);
            this.menu_Basic.Text = "基础资料(&J)";
            // 
            // MI_BankCard
            // 
            this.MI_BankCard.Name = "MI_BankCard";
            this.MI_BankCard.Size = new System.Drawing.Size(152, 22);
            this.MI_BankCard.Text = "储蓄卡管理(&Y)";
            this.MI_BankCard.Click += new System.EventHandler(this.MI_BankCard_Click);
            // 
            // 信用卡管理XToolStripMenuItem
            // 
            this.信用卡管理XToolStripMenuItem.Name = "信用卡管理XToolStripMenuItem";
            this.信用卡管理XToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.信用卡管理XToolStripMenuItem.Text = "信用卡管理(&X)";
            this.信用卡管理XToolStripMenuItem.Click += new System.EventHandler(this.MI_XinYongKa);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // MI_ShouruType
            // 
            this.MI_ShouruType.Name = "MI_ShouruType";
            this.MI_ShouruType.Size = new System.Drawing.Size(152, 22);
            this.MI_ShouruType.Text = "收入类别(&C)";
            this.MI_ShouruType.Click += new System.EventHandler(this.MI_ShouruType_Click);
            // 
            // MI_ZhiChuType
            // 
            this.MI_ZhiChuType.Name = "MI_ZhiChuType";
            this.MI_ZhiChuType.Size = new System.Drawing.Size(152, 22);
            this.MI_ZhiChuType.Text = "支出类别(&Z)";
            this.MI_ZhiChuType.Click += new System.EventHandler(this.MI_ZhiChuType_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // menu_hetong
            // 
            this.menu_hetong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddContract,
            this.miContractList});
            this.menu_hetong.Image = ((System.Drawing.Image)(resources.GetObject("menu_hetong.Image")));
            this.menu_hetong.Name = "menu_hetong";
            this.menu_hetong.Size = new System.Drawing.Size(101, 21);
            this.menu_hetong.Text = "合同维护(&H)";
            // 
            // miAddContract
            // 
            this.miAddContract.Name = "miAddContract";
            this.miAddContract.Size = new System.Drawing.Size(140, 22);
            this.miAddContract.Text = "新建合同(&A)";
            // 
            // miContractList
            // 
            this.miContractList.Name = "miContractList";
            this.miContractList.Size = new System.Drawing.Size(140, 22);
            this.miContractList.Text = "合同列表(&L)";
            // 
            // menu_project
            // 
            this.menu_project.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miProjectList,
            this.miSubProjectList,
            this.miStatueList,
            this.miPeopleDayList});
            this.menu_project.Image = ((System.Drawing.Image)(resources.GetObject("menu_project.Image")));
            this.menu_project.Name = "menu_project";
            this.menu_project.Size = new System.Drawing.Size(100, 21);
            this.menu_project.Text = "项目维护(&X)";
            // 
            // miProjectList
            // 
            this.miProjectList.Name = "miProjectList";
            this.miProjectList.Size = new System.Drawing.Size(140, 22);
            this.miProjectList.Text = "项目主表(&L)";
            // 
            // miSubProjectList
            // 
            this.miSubProjectList.Name = "miSubProjectList";
            this.miSubProjectList.Size = new System.Drawing.Size(140, 22);
            this.miSubProjectList.Text = "项目列表(&Z)";
            // 
            // miStatueList
            // 
            this.miStatueList.Name = "miStatueList";
            this.miStatueList.Size = new System.Drawing.Size(140, 22);
            this.miStatueList.Text = "状态列表(&V)";
            // 
            // miPeopleDayList
            // 
            this.miPeopleDayList.Name = "miPeopleDayList";
            this.miPeopleDayList.Size = new System.Drawing.Size(140, 22);
            this.miPeopleDayList.Text = "人天列表(&B)";
            // 
            // menu_reports
            // 
            this.menu_reports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miWeekStateReport,
            this.miMileStoneReport,
            this.miPeopleDayReport,
            this.miProjectWeek});
            this.menu_reports.Image = ((System.Drawing.Image)(resources.GetObject("menu_reports.Image")));
            this.menu_reports.Name = "menu_reports";
            this.menu_reports.Size = new System.Drawing.Size(100, 21);
            this.menu_reports.Text = "报表管理(&B)";
            // 
            // miWeekStateReport
            // 
            this.miWeekStateReport.Name = "miWeekStateReport";
            this.miWeekStateReport.Size = new System.Drawing.Size(180, 22);
            this.miWeekStateReport.Text = "实施收入预测表(&Z)";
            // 
            // miMileStoneReport
            // 
            this.miMileStoneReport.Name = "miMileStoneReport";
            this.miMileStoneReport.Size = new System.Drawing.Size(180, 22);
            this.miMileStoneReport.Text = "里程碑报表(&L)";
            // 
            // miPeopleDayReport
            // 
            this.miPeopleDayReport.Name = "miPeopleDayReport";
            this.miPeopleDayReport.Size = new System.Drawing.Size(180, 22);
            this.miPeopleDayReport.Text = "人天报表(&R)";
            // 
            // miProjectWeek
            // 
            this.miProjectWeek.Name = "miProjectWeek";
            this.miProjectWeek.Size = new System.Drawing.Size(180, 22);
            this.miProjectWeek.Text = "项目周状态报表(&W)";
            // 
            // menu_helpabout
            // 
            this.menu_helpabout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHelp,
            this.miAbout});
            this.menu_helpabout.Image = ((System.Drawing.Image)(resources.GetObject("menu_helpabout.Image")));
            this.menu_helpabout.Name = "menu_helpabout";
            this.menu_helpabout.Size = new System.Drawing.Size(100, 21);
            this.menu_helpabout.Text = "帮助关于(&B)";
            // 
            // miHelp
            // 
            this.miHelp.Image = ((System.Drawing.Image)(resources.GetObject("miHelp.Image")));
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(117, 22);
            this.miHelp.Text = "帮助(&H)";
            this.miHelp.Click += new System.EventHandler(this.miHelp_Click);
            // 
            // miAbout
            // 
            this.miAbout.Image = ((System.Drawing.Image)(resources.GetObject("miAbout.Image")));
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(117, 22);
            this.miAbout.Text = "关于(&A)";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmi_PingPU,
            this.toolStripSeparator3,
            this.tmi_CloseAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(758, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tmi_PingPU
            // 
            this.tmi_PingPU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tmi_PingPU.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmi_ShuiPing,
            this.tmi_TuBiao,
            this.tmi_CengDie,
            this.tmi_ChuiZhi});
            this.tmi_PingPU.Image = ((System.Drawing.Image)(resources.GetObject("tmi_PingPU.Image")));
            this.tmi_PingPU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tmi_PingPU.Name = "tmi_PingPU";
            this.tmi_PingPU.Size = new System.Drawing.Size(29, 22);
            this.tmi_PingPU.Text = "子窗体(P)";
            // 
            // tmi_ShuiPing
            // 
            this.tmi_ShuiPing.Image = ((System.Drawing.Image)(resources.GetObject("tmi_ShuiPing.Image")));
            this.tmi_ShuiPing.Name = "tmi_ShuiPing";
            this.tmi_ShuiPing.Size = new System.Drawing.Size(140, 22);
            this.tmi_ShuiPing.Text = "水平平铺(&S)";
            this.tmi_ShuiPing.Click += new System.EventHandler(this.mi_ShuiPing_Click);
            // 
            // tmi_TuBiao
            // 
            this.tmi_TuBiao.Image = ((System.Drawing.Image)(resources.GetObject("tmi_TuBiao.Image")));
            this.tmi_TuBiao.Name = "tmi_TuBiao";
            this.tmi_TuBiao.Size = new System.Drawing.Size(140, 22);
            this.tmi_TuBiao.Text = "图标平铺(&T)";
            this.tmi_TuBiao.Visible = false;
            this.tmi_TuBiao.Click += new System.EventHandler(this.mi_TuBiao_Click);
            // 
            // tmi_CengDie
            // 
            this.tmi_CengDie.Image = ((System.Drawing.Image)(resources.GetObject("tmi_CengDie.Image")));
            this.tmi_CengDie.Name = "tmi_CengDie";
            this.tmi_CengDie.Size = new System.Drawing.Size(140, 22);
            this.tmi_CengDie.Text = "层叠平铺(&C)";
            this.tmi_CengDie.Click += new System.EventHandler(this.mi_CengDie_Click);
            // 
            // tmi_ChuiZhi
            // 
            this.tmi_ChuiZhi.Image = ((System.Drawing.Image)(resources.GetObject("tmi_ChuiZhi.Image")));
            this.tmi_ChuiZhi.Name = "tmi_ChuiZhi";
            this.tmi_ChuiZhi.Size = new System.Drawing.Size(140, 22);
            this.tmi_ChuiZhi.Text = "垂直平铺(Z)";
            this.tmi_ChuiZhi.Click += new System.EventHandler(this.mi_ChuiZhi_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tmi_CloseAll
            // 
            this.tmi_CloseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tmi_CloseAll.Image = global::FySoft.HMIS.Forms.Properties.Resources.menu_exit;
            this.tmi_CloseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tmi_CloseAll.Name = "tmi_CloseAll";
            this.tmi_CloseAll.Size = new System.Drawing.Size(23, 22);
            this.tmi_CloseAll.Text = "关闭所有窗体";
            this.tmi_CloseAll.ToolTipText = "关闭全部";
            this.tmi_CloseAll.Click += new System.EventHandler(this.tmi_CloseAll_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlUserName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(758, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stlUserName
            // 
            this.stlUserName.Name = "stlUserName";
            this.stlUserName.Size = new System.Drawing.Size(131, 17);
            this.stlUserName.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 474);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "家庭理财工具";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_system;
        private System.Windows.Forms.ToolStripMenuItem menu_hetong;
        private System.Windows.Forms.ToolStripMenuItem menu_project;
        private System.Windows.Forms.ToolStripMenuItem menu_reports;
        private System.Windows.Forms.ToolStripMenuItem menu_helpabout;
        private System.Windows.Forms.ToolStripMenuItem mi_Relogin;
        private System.Windows.Forms.ToolStripMenuItem mi_Exit;
        private System.Windows.Forms.ToolStripMenuItem miAddContract;
        private System.Windows.Forms.ToolStripMenuItem miContractList;
        private System.Windows.Forms.ToolStripMenuItem mi_PingPU;
        private System.Windows.Forms.ToolStripMenuItem mi_ShuiPing;
        private System.Windows.Forms.ToolStripMenuItem mi_TuBiao;
        private System.Windows.Forms.ToolStripMenuItem mi_CengDie;
        private System.Windows.Forms.ToolStripMenuItem mi_ChuiZhi;
        private System.Windows.Forms.ToolStripDropDownButton tmi_PingPU;
        private System.Windows.Forms.ToolStripMenuItem tmi_ShuiPing;
        private System.Windows.Forms.ToolStripMenuItem tmi_TuBiao;
        private System.Windows.Forms.ToolStripMenuItem tmi_CengDie;
        private System.Windows.Forms.ToolStripMenuItem tmi_ChuiZhi;
        //private System.Windows.Forms.ToolStripLabel tmiUserName;
        private System.Windows.Forms.ToolStripMenuItem miProjectList;
        private System.Windows.Forms.ToolStripMenuItem miStatueList;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripMenuItem miPeopleDayList;
        private System.Windows.Forms.ToolStripStatusLabel stlUserName;
        private System.Windows.Forms.ToolStripMenuItem miWeekStateReport;
        private System.Windows.Forms.ToolStripMenuItem miMileStoneReport;
        private System.Windows.Forms.ToolStripMenuItem miPeopleDayReport;
        private System.Windows.Forms.ToolStripMenuItem mi_User;
        private System.Windows.Forms.ToolStripMenuItem miSubProjectList;
        private System.Windows.Forms.ToolStripMenuItem mi_ChgUserPW;
        private System.Windows.Forms.ToolStripMenuItem menu_Basic;
        private System.Windows.Forms.ToolStripMenuItem miProjectWeek;
        private System.Windows.Forms.ToolStripButton tmi_CloseAll;
        private System.Windows.Forms.ToolStripMenuItem MI_BankCard;
        private System.Windows.Forms.ToolStripMenuItem MI_ShouruType;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MI_ZhiChuType;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 信用卡管理XToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}
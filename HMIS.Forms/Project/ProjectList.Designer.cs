namespace UfidaPMS.Forms.Project
{
    partial class ProjectList
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsmiSearch = new System.Windows.Forms.ToolStripButton();
            this.tsmiSave = new System.Windows.Forms.ToolStripButton();
            this.tsmiView = new System.Windows.Forms.ToolStripButton();
            this.tsmiMileStone = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiAddMileStone = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMileStoneConfirm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMileStoneList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiState = new System.Windows.Forms.ToolStripButton();
            this.tsmiPeoPleDay = new System.Windows.Forms.ToolStripButton();
            this.tsmiDocumentConfim = new System.Windows.Forms.ToolStripButton();
            this.tsmiExit = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.projectid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.子合同号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMP项目编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.项目名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.实施部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.项目经理 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.项目级别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.监管人员 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubProject = new System.Windows.Forms.DataGridView();
            this.projectid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subprojectid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.子项目名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.项目类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectmethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.模块 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.子项目经理 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.实施顾问 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.计划人天 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.占总比例 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.实施金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.启动时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.预计完成日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年初进度百分比 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.行业 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.developresources = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsibilitymilestone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalschedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contactphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.developadviser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubProject)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSearch,
            this.tsmiSave,
            this.tsmiView,
            this.tsmiMileStone,
            this.tsmiState,
            this.tsmiPeoPleDay,
            this.tsmiDocumentConfim,
            this.tsmiExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(857, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.Image = global::UfidaPMS.Forms.Properties.Resources.search;
            this.tsmiSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(67, 22);
            this.tsmiSearch.Text = "查找(&C)";
            this.tsmiSearch.Click += new System.EventHandler(this.tsmiSearch_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Image = global::UfidaPMS.Forms.Properties.Resources.menu_helpabout;
            this.tsmiSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(67, 22);
            this.tsmiSave.Text = "编辑(&S)";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.Image = global::UfidaPMS.Forms.Properties.Resources.menu_relogin;
            this.tsmiView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(67, 22);
            this.tsmiView.Text = "查看(&V)";
            this.tsmiView.Click += new System.EventHandler(this.tsmiView_Click);
            // 
            // tsmiMileStone
            // 
            this.tsmiMileStone.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddMileStone,
            this.tsmiMileStoneConfirm,
            this.tsmiMileStoneList});
            this.tsmiMileStone.Image = global::UfidaPMS.Forms.Properties.Resources.menu_system;
            this.tsmiMileStone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiMileStone.Name = "tsmiMileStone";
            this.tsmiMileStone.Size = new System.Drawing.Size(70, 22);
            this.tsmiMileStone.Text = "里程碑";
            // 
            // tsmiAddMileStone
            // 
            this.tsmiAddMileStone.Name = "tsmiAddMileStone";
            this.tsmiAddMileStone.Size = new System.Drawing.Size(148, 22);
            this.tsmiAddMileStone.Text = "新建里程碑(&A)";
            this.tsmiAddMileStone.Click += new System.EventHandler(this.tsmiAddMileStone_Click);
            // 
            // tsmiMileStoneConfirm
            // 
            this.tsmiMileStoneConfirm.Name = "tsmiMileStoneConfirm";
            this.tsmiMileStoneConfirm.Size = new System.Drawing.Size(148, 22);
            this.tsmiMileStoneConfirm.Text = "里程碑确认(&Q)";
            this.tsmiMileStoneConfirm.Click += new System.EventHandler(this.tsmiMileStoneConfirm_Click);
            // 
            // tsmiMileStoneList
            // 
            this.tsmiMileStoneList.Name = "tsmiMileStoneList";
            this.tsmiMileStoneList.Size = new System.Drawing.Size(148, 22);
            this.tsmiMileStoneList.Text = "里程碑历史(&L)";
            this.tsmiMileStoneList.Click += new System.EventHandler(this.tsmiMileStoneList_Click);
            // 
            // tsmiState
            // 
            this.tsmiState.Image = global::UfidaPMS.Forms.Properties.Resources.menu_baobiao;
            this.tsmiState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiState.Name = "tsmiState";
            this.tsmiState.Size = new System.Drawing.Size(91, 22);
            this.tsmiState.Text = "状态维护(&Z)";
            this.tsmiState.Click += new System.EventHandler(this.tsmiState_Click);
            // 
            // tsmiPeoPleDay
            // 
            this.tsmiPeoPleDay.Image = global::UfidaPMS.Forms.Properties.Resources.ico_logo;
            this.tsmiPeoPleDay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiPeoPleDay.Name = "tsmiPeoPleDay";
            this.tsmiPeoPleDay.Size = new System.Drawing.Size(91, 22);
            this.tsmiPeoPleDay.Text = "实际人天(&R)";
            this.tsmiPeoPleDay.Click += new System.EventHandler(this.tsmiPeoPleDay_Click);
            // 
            // tsmiDocumentConfim
            // 
            this.tsmiDocumentConfim.Image = global::UfidaPMS.Forms.Properties.Resources.edit;
            this.tsmiDocumentConfim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDocumentConfim.Name = "tsmiDocumentConfim";
            this.tsmiDocumentConfim.Size = new System.Drawing.Size(91, 22);
            this.tsmiDocumentConfim.Text = "文档交付(&D)";
            this.tsmiDocumentConfim.Click += new System.EventHandler(this.tsmiDocumentConfim_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = global::UfidaPMS.Forms.Properties.Resources.menu_exit;
            this.tsmiExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(67, 22);
            this.tsmiExit.Text = "关闭(&E)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvProject, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvSubProject, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(857, 455);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目主表：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "子项目列表：";
            // 
            // dgvProject
            // 
            this.dgvProject.AllowUserToAddRows = false;
            this.dgvProject.AllowUserToDeleteRows = false;
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectid,
            this.子合同号,
            this.PMP项目编号,
            this.项目名称,
            this.实施部门,
            this.项目经理,
            this.项目级别,
            this.监管人员});
            this.dgvProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProject.Location = new System.Drawing.Point(23, 53);
            this.dgvProject.MultiSelect = false;
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.ReadOnly = true;
            this.dgvProject.RowTemplate.Height = 23;
            this.dgvProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProject.Size = new System.Drawing.Size(811, 171);
            this.dgvProject.TabIndex = 2;
            this.dgvProject.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProject_CellDoubleClick);
            // 
            // projectid
            // 
            this.projectid.DataPropertyName = "projectid";
            this.projectid.HeaderText = "projectid";
            this.projectid.Name = "projectid";
            this.projectid.ReadOnly = true;
            this.projectid.Visible = false;
            // 
            // 子合同号
            // 
            this.子合同号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.子合同号.DataPropertyName = "subcontractno";
            this.子合同号.HeaderText = "子合同号";
            this.子合同号.Name = "子合同号";
            this.子合同号.ReadOnly = true;
            // 
            // PMP项目编号
            // 
            this.PMP项目编号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PMP项目编号.DataPropertyName = "pmpprojectid";
            this.PMP项目编号.HeaderText = "PMP项目编号";
            this.PMP项目编号.Name = "PMP项目编号";
            this.PMP项目编号.ReadOnly = true;
            // 
            // 项目名称
            // 
            this.项目名称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.项目名称.DataPropertyName = "projectname";
            this.项目名称.HeaderText = "项目名称";
            this.项目名称.Name = "项目名称";
            this.项目名称.ReadOnly = true;
            // 
            // 实施部门
            // 
            this.实施部门.DataPropertyName = "implementdepartment";
            this.实施部门.HeaderText = "实施部门";
            this.实施部门.Name = "实施部门";
            this.实施部门.ReadOnly = true;
            // 
            // 项目经理
            // 
            this.项目经理.DataPropertyName = "projectmanager";
            this.项目经理.HeaderText = "项目经理";
            this.项目经理.Name = "项目经理";
            this.项目经理.ReadOnly = true;
            // 
            // 项目级别
            // 
            this.项目级别.DataPropertyName = "projectlevel";
            this.项目级别.HeaderText = "项目级别";
            this.项目级别.Name = "项目级别";
            this.项目级别.ReadOnly = true;
            // 
            // 监管人员
            // 
            this.监管人员.DataPropertyName = "regulator";
            this.监管人员.HeaderText = "监管人员";
            this.监管人员.Name = "监管人员";
            this.监管人员.ReadOnly = true;
            // 
            // dgvSubProject
            // 
            this.dgvSubProject.AllowUserToAddRows = false;
            this.dgvSubProject.AllowUserToDeleteRows = false;
            this.dgvSubProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectid2,
            this.subprojectid,
            this.编号,
            this.子项目名称,
            this.项目类型,
            this.projectmethod,
            this.模块,
            this.子项目经理,
            this.实施顾问,
            this.计划人天,
            this.占总比例,
            this.实施金额,
            this.启动时间,
            this.预计完成日期,
            this.年初进度百分比,
            this.行业,
            this.developresources,
            this.responsibilitymilestone,
            this.totalschedule,
            this.remarks,
            this.projectname,
            this.progress,
            this.Contacter,
            this.Contactphone,
            this.developadviser});
            this.dgvSubProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubProject.Location = new System.Drawing.Point(23, 260);
            this.dgvSubProject.MultiSelect = false;
            this.dgvSubProject.Name = "dgvSubProject";
            this.dgvSubProject.ReadOnly = true;
            this.dgvSubProject.RowTemplate.Height = 23;
            this.dgvSubProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubProject.Size = new System.Drawing.Size(811, 171);
            this.dgvSubProject.TabIndex = 3;
            // 
            // projectid2
            // 
            this.projectid2.DataPropertyName = "projectid";
            this.projectid2.HeaderText = "projectid";
            this.projectid2.Name = "projectid2";
            this.projectid2.ReadOnly = true;
            this.projectid2.Visible = false;
            // 
            // subprojectid
            // 
            this.subprojectid.DataPropertyName = "subprojectid";
            this.subprojectid.HeaderText = "subprojectid";
            this.subprojectid.Name = "subprojectid";
            this.subprojectid.ReadOnly = true;
            this.subprojectid.Visible = false;
            // 
            // 编号
            // 
            this.编号.DataPropertyName = "subprojectcode";
            this.编号.HeaderText = "编号";
            this.编号.Name = "编号";
            this.编号.ReadOnly = true;
            // 
            // 子项目名称
            // 
            this.子项目名称.DataPropertyName = "subprojectname";
            this.子项目名称.HeaderText = "子项目名称";
            this.子项目名称.Name = "子项目名称";
            this.子项目名称.ReadOnly = true;
            this.子项目名称.Width = 150;
            // 
            // 项目类型
            // 
            this.项目类型.DataPropertyName = "subprojecttype";
            this.项目类型.HeaderText = "项目类型";
            this.项目类型.Name = "项目类型";
            this.项目类型.ReadOnly = true;
            // 
            // projectmethod
            // 
            this.projectmethod.DataPropertyName = "projectmethod";
            this.projectmethod.HeaderText = "交付方法";
            this.projectmethod.Name = "projectmethod";
            this.projectmethod.ReadOnly = true;
            // 
            // 模块
            // 
            this.模块.DataPropertyName = "modelname";
            this.模块.HeaderText = "模块";
            this.模块.Name = "模块";
            this.模块.ReadOnly = true;
            // 
            // 子项目经理
            // 
            this.子项目经理.DataPropertyName = "subprojectmanager";
            this.子项目经理.HeaderText = "子项目经理";
            this.子项目经理.Name = "子项目经理";
            this.子项目经理.ReadOnly = true;
            this.子项目经理.Width = 150;
            // 
            // 实施顾问
            // 
            this.实施顾问.DataPropertyName = "implementadviser";
            this.实施顾问.HeaderText = "实施顾问";
            this.实施顾问.Name = "实施顾问";
            this.实施顾问.ReadOnly = true;
            // 
            // 计划人天
            // 
            this.计划人天.DataPropertyName = "planpeopledays";
            this.计划人天.HeaderText = "计划人天";
            this.计划人天.Name = "计划人天";
            this.计划人天.ReadOnly = true;
            // 
            // 占总比例
            // 
            this.占总比例.DataPropertyName = "percentage";
            this.占总比例.HeaderText = "占总比例(%)";
            this.占总比例.Name = "占总比例";
            this.占总比例.ReadOnly = true;
            this.占总比例.Width = 120;
            // 
            // 实施金额
            // 
            this.实施金额.DataPropertyName = "implementationamount";
            this.实施金额.HeaderText = "实施金额";
            this.实施金额.Name = "实施金额";
            this.实施金额.ReadOnly = true;
            // 
            // 启动时间
            // 
            this.启动时间.DataPropertyName = "starttime";
            this.启动时间.HeaderText = "实际启动日期";
            this.启动时间.Name = "启动时间";
            this.启动时间.ReadOnly = true;
            this.启动时间.Width = 160;
            // 
            // 预计完成日期
            // 
            this.预计完成日期.DataPropertyName = "planfinishtime";
            this.预计完成日期.HeaderText = "预计完成日期";
            this.预计完成日期.Name = "预计完成日期";
            this.预计完成日期.ReadOnly = true;
            this.预计完成日期.Width = 160;
            // 
            // 年初进度百分比
            // 
            this.年初进度百分比.DataPropertyName = "earlypercentage";
            this.年初进度百分比.HeaderText = "年初进度百分比(%)";
            this.年初进度百分比.Name = "年初进度百分比";
            this.年初进度百分比.ReadOnly = true;
            this.年初进度百分比.Width = 160;
            // 
            // 行业
            // 
            this.行业.DataPropertyName = "industry";
            this.行业.HeaderText = "行业";
            this.行业.Name = "行业";
            this.行业.ReadOnly = true;
            this.行业.Visible = false;
            // 
            // developresources
            // 
            this.developresources.DataPropertyName = "developresources";
            this.developresources.HeaderText = "developresources";
            this.developresources.Name = "developresources";
            this.developresources.ReadOnly = true;
            this.developresources.Visible = false;
            // 
            // responsibilitymilestone
            // 
            this.responsibilitymilestone.DataPropertyName = "responsibilitymilestone";
            this.responsibilitymilestone.HeaderText = "responsibilitymilestone";
            this.responsibilitymilestone.Name = "responsibilitymilestone";
            this.responsibilitymilestone.ReadOnly = true;
            this.responsibilitymilestone.Visible = false;
            // 
            // totalschedule
            // 
            this.totalschedule.DataPropertyName = "totalschedule";
            this.totalschedule.HeaderText = "totalschedule";
            this.totalschedule.Name = "totalschedule";
            this.totalschedule.ReadOnly = true;
            this.totalschedule.Visible = false;
            // 
            // remarks
            // 
            this.remarks.DataPropertyName = "remarks";
            this.remarks.HeaderText = "remarks";
            this.remarks.Name = "remarks";
            this.remarks.ReadOnly = true;
            this.remarks.Visible = false;
            // 
            // projectname
            // 
            this.projectname.DataPropertyName = "projectname";
            this.projectname.HeaderText = "projectname";
            this.projectname.Name = "projectname";
            this.projectname.ReadOnly = true;
            this.projectname.Visible = false;
            // 
            // progress
            // 
            this.progress.DataPropertyName = "progress";
            this.progress.HeaderText = "项目进度";
            this.progress.Name = "progress";
            this.progress.ReadOnly = true;
            // 
            // Contacter
            // 
            this.Contacter.DataPropertyName = "contacter";
            this.Contacter.HeaderText = "联系人";
            this.Contacter.Name = "Contacter";
            this.Contacter.ReadOnly = true;
            // 
            // Contactphone
            // 
            this.Contactphone.DataPropertyName = "contactphone";
            this.Contactphone.HeaderText = "联系电话";
            this.Contactphone.Name = "Contactphone";
            this.Contactphone.ReadOnly = true;
            // 
            // developadviser
            // 
            this.developadviser.DataPropertyName = "developadviser";
            this.developadviser.HeaderText = "客开顾问";
            this.developadviser.Name = "developadviser";
            this.developadviser.ReadOnly = true;
            // 
            // ProjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 480);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ProjectList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "项目列表";
            this.Load += new System.EventHandler(this.ProjectList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsmiSearch;
        private System.Windows.Forms.ToolStripButton tsmiSave;
        private System.Windows.Forms.ToolStripButton tsmiView;
        private System.Windows.Forms.ToolStripButton tsmiExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProject;
        private System.Windows.Forms.DataGridView dgvSubProject;
        private System.Windows.Forms.ToolStripButton tsmiState;
        private System.Windows.Forms.ToolStripButton tsmiPeoPleDay;
        private System.Windows.Forms.ToolStripDropDownButton tsmiMileStone;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddMileStone;
        private System.Windows.Forms.ToolStripMenuItem tsmiMileStoneConfirm;
        private System.Windows.Forms.ToolStripMenuItem tsmiMileStoneList;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectid;
        private System.Windows.Forms.DataGridViewTextBoxColumn 子合同号;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMP项目编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 项目名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 实施部门;
        private System.Windows.Forms.DataGridViewTextBoxColumn 项目经理;
        private System.Windows.Forms.DataGridViewTextBoxColumn 项目级别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 监管人员;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn subprojectid;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 子项目名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 项目类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectmethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn 模块;
        private System.Windows.Forms.DataGridViewTextBoxColumn 子项目经理;
        private System.Windows.Forms.DataGridViewTextBoxColumn 实施顾问;
        private System.Windows.Forms.DataGridViewTextBoxColumn 计划人天;
        private System.Windows.Forms.DataGridViewTextBoxColumn 占总比例;
        private System.Windows.Forms.DataGridViewTextBoxColumn 实施金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 启动时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 预计完成日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年初进度百分比;
        private System.Windows.Forms.DataGridViewTextBoxColumn 行业;
        private System.Windows.Forms.DataGridViewTextBoxColumn developresources;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsibilitymilestone;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalschedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectname;
        private System.Windows.Forms.DataGridViewTextBoxColumn progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contactphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn developadviser;
        private System.Windows.Forms.ToolStripButton tsmiDocumentConfim;
    }
}
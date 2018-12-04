namespace UfidaPMS.Forms.Project
{
    partial class SubProjectList
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
            this.tsmiExit = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSubProject = new System.Windows.Forms.DataGridView();
            this.projectid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.子合同号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMP项目编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.项目名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.实施部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.项目经理 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.项目级别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.监管人员 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subprojectid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subprojectcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subprojectname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subprojecttype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectmethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subprojectmanager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.implementadviser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planpeopledays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.implementationamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planfinishtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.earlypercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subprojectState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contactphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcontractid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalschedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsmiDocumentConfim = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tsmiSave.Size = new System.Drawing.Size(91, 22);
            this.tsmiSave.Text = "编辑项目(&S)";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.Image = global::UfidaPMS.Forms.Properties.Resources.menu_relogin;
            this.tsmiView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(91, 22);
            this.tsmiView.Text = "查看项目(&V)";
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
            this.tableLayoutPanel1.Controls.Add(this.dgvSubProject, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(857, 455);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目列表";
            // 
            // dgvSubProject
            // 
            this.dgvSubProject.AllowUserToAddRows = false;
            this.dgvSubProject.AllowUserToDeleteRows = false;
            this.dgvSubProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectid,
            this.子合同号,
            this.PMP项目编号,
            this.项目名称,
            this.实施部门,
            this.项目经理,
            this.项目级别,
            this.监管人员,
            this.subprojectid,
            this.subprojectcode,
            this.subprojectname,
            this.subprojecttype,
            this.projectmethod,
            this.modelname,
            this.subprojectmanager,
            this.implementadviser,
            this.planpeopledays,
            this.percentage,
            this.implementationamount,
            this.starttime,
            this.planfinishtime,
            this.earlypercentage,
            this.progress,
            this.subprojectState,
            this.Contacter,
            this.Contactphone,
            this.subcontractid,
            this.totalschedule});
            this.dgvSubProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubProject.Location = new System.Drawing.Point(23, 53);
            this.dgvSubProject.MultiSelect = false;
            this.dgvSubProject.Name = "dgvSubProject";
            this.dgvSubProject.ReadOnly = true;
            this.dgvSubProject.RowTemplate.Height = 23;
            this.dgvSubProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubProject.Size = new System.Drawing.Size(811, 379);
            this.dgvSubProject.TabIndex = 2;
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
            this.子合同号.DataPropertyName = "subcontractno";
            this.子合同号.HeaderText = "子合同号";
            this.子合同号.Name = "子合同号";
            this.子合同号.ReadOnly = true;
            this.子合同号.Visible = false;
            this.子合同号.Width = 123;
            // 
            // PMP项目编号
            // 
            this.PMP项目编号.DataPropertyName = "pmpprojectid";
            this.PMP项目编号.HeaderText = "PMP项目编号";
            this.PMP项目编号.Name = "PMP项目编号";
            this.PMP项目编号.ReadOnly = true;
            this.PMP项目编号.Visible = false;
            this.PMP项目编号.Width = 122;
            // 
            // 项目名称
            // 
            this.项目名称.DataPropertyName = "projectname";
            this.项目名称.HeaderText = "项目名称";
            this.项目名称.Name = "项目名称";
            this.项目名称.ReadOnly = true;
            this.项目名称.Width = 168;
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
            // subprojectid
            // 
            this.subprojectid.DataPropertyName = "subprojectid";
            this.subprojectid.HeaderText = "subprojectid";
            this.subprojectid.Name = "subprojectid";
            this.subprojectid.ReadOnly = true;
            this.subprojectid.Visible = false;
            // 
            // subprojectcode
            // 
            this.subprojectcode.DataPropertyName = "subprojectcode";
            this.subprojectcode.HeaderText = "子项目编号";
            this.subprojectcode.Name = "subprojectcode";
            this.subprojectcode.ReadOnly = true;
            this.subprojectcode.Width = 160;
            // 
            // subprojectname
            // 
            this.subprojectname.DataPropertyName = "subprojectname";
            this.subprojectname.HeaderText = "子项目名称";
            this.subprojectname.Name = "subprojectname";
            this.subprojectname.ReadOnly = true;
            this.subprojectname.Width = 160;
            // 
            // subprojecttype
            // 
            this.subprojecttype.DataPropertyName = "subprojecttype";
            this.subprojecttype.HeaderText = "子项目类型";
            this.subprojecttype.Name = "subprojecttype";
            this.subprojecttype.ReadOnly = true;
            this.subprojecttype.Width = 160;
            // 
            // projectmethod
            // 
            this.projectmethod.DataPropertyName = "projectmethod";
            this.projectmethod.HeaderText = "交付方法";
            this.projectmethod.Name = "projectmethod";
            this.projectmethod.ReadOnly = true;
            // 
            // modelname
            // 
            this.modelname.DataPropertyName = "modelname";
            this.modelname.HeaderText = "模块";
            this.modelname.Name = "modelname";
            this.modelname.ReadOnly = true;
            // 
            // subprojectmanager
            // 
            this.subprojectmanager.DataPropertyName = "subprojectmanager";
            this.subprojectmanager.HeaderText = "子项目经理";
            this.subprojectmanager.Name = "subprojectmanager";
            this.subprojectmanager.ReadOnly = true;
            this.subprojectmanager.Width = 120;
            // 
            // implementadviser
            // 
            this.implementadviser.DataPropertyName = "implementadviser";
            this.implementadviser.HeaderText = "实施顾问";
            this.implementadviser.Name = "implementadviser";
            this.implementadviser.ReadOnly = true;
            // 
            // planpeopledays
            // 
            this.planpeopledays.DataPropertyName = "planpeopledays";
            this.planpeopledays.HeaderText = "预计人天";
            this.planpeopledays.Name = "planpeopledays";
            this.planpeopledays.ReadOnly = true;
            // 
            // percentage
            // 
            this.percentage.DataPropertyName = "percentage";
            this.percentage.HeaderText = "占总比例(%)";
            this.percentage.Name = "percentage";
            this.percentage.ReadOnly = true;
            this.percentage.Width = 120;
            // 
            // implementationamount
            // 
            this.implementationamount.DataPropertyName = "implementationamount";
            this.implementationamount.HeaderText = "实施金额";
            this.implementationamount.Name = "implementationamount";
            this.implementationamount.ReadOnly = true;
            // 
            // starttime
            // 
            this.starttime.DataPropertyName = "starttime";
            this.starttime.HeaderText = "实际启动日期";
            this.starttime.Name = "starttime";
            this.starttime.ReadOnly = true;
            this.starttime.Width = 160;
            // 
            // planfinishtime
            // 
            this.planfinishtime.DataPropertyName = "planfinishtime";
            this.planfinishtime.HeaderText = "预计完成日期";
            this.planfinishtime.Name = "planfinishtime";
            this.planfinishtime.ReadOnly = true;
            this.planfinishtime.Width = 160;
            // 
            // earlypercentage
            // 
            this.earlypercentage.DataPropertyName = "earlypercentage";
            this.earlypercentage.HeaderText = "年初进度百分比";
            this.earlypercentage.Name = "earlypercentage";
            this.earlypercentage.ReadOnly = true;
            this.earlypercentage.Width = 160;
            // 
            // progress
            // 
            this.progress.DataPropertyName = "progress";
            this.progress.HeaderText = "项目进度";
            this.progress.Name = "progress";
            this.progress.ReadOnly = true;
            // 
            // subprojectState
            // 
            this.subprojectState.DataPropertyName = "state";
            this.subprojectState.HeaderText = "项目状态";
            this.subprojectState.Name = "subprojectState";
            this.subprojectState.ReadOnly = true;
            // 
            // Contacter
            // 
            this.Contacter.DataPropertyName = "Contacter";
            this.Contacter.HeaderText = "联系人";
            this.Contacter.Name = "Contacter";
            this.Contacter.ReadOnly = true;
            // 
            // Contactphone
            // 
            this.Contactphone.DataPropertyName = "Contactphone";
            this.Contactphone.HeaderText = "联系电话";
            this.Contactphone.Name = "Contactphone";
            this.Contactphone.ReadOnly = true;
            // 
            // subcontractid
            // 
            this.subcontractid.DataPropertyName = "subcontractid";
            this.subcontractid.HeaderText = "subcontractid";
            this.subcontractid.Name = "subcontractid";
            this.subcontractid.ReadOnly = true;
            this.subcontractid.Visible = false;
            // 
            // totalschedule
            // 
            this.totalschedule.DataPropertyName = "totalschedule";
            this.totalschedule.HeaderText = "totalschedule";
            this.totalschedule.Name = "totalschedule";
            this.totalschedule.ReadOnly = true;
            this.totalschedule.Visible = false;
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
            // SubProjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 480);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SubProjectList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "子项目列表";
            this.Load += new System.EventHandler(this.ProjectList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn subprojectid;
        private System.Windows.Forms.DataGridViewTextBoxColumn subprojectcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn subprojectname;
        private System.Windows.Forms.DataGridViewTextBoxColumn subprojecttype;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectmethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelname;
        private System.Windows.Forms.DataGridViewTextBoxColumn subprojectmanager;
        private System.Windows.Forms.DataGridViewTextBoxColumn implementadviser;
        private System.Windows.Forms.DataGridViewTextBoxColumn planpeopledays;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn implementationamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn planfinishtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn earlypercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn subprojectState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contactphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcontractid;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalschedule;
        private System.Windows.Forms.ToolStripButton tsmiDocumentConfim;
    }
}
namespace UfidaPMS.Forms.Project
{
    partial class EditProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProject));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsmiAddRow = new System.Windows.Forms.ToolStripButton();
            this.tsmiDeleteRow = new System.Windows.Forms.ToolStripButton();
            this.tsmiSave = new System.Windows.Forms.ToolStripButton();
            this.tsmiDelete = new System.Windows.Forms.ToolStripButton();
            this.tsmiCancel = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSubProjectList = new System.Windows.Forms.DataGridView();
            this.BianHao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubProjectType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProjectMethod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubProjectManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuWen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanPeopleDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanFinishDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.earlypercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.industry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subprojectid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contactphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.developadviser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPMPProjectNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbPM = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.cbManager = new System.Windows.Forms.ComboBox();
            this.cbProjectLevel = new System.Windows.Forms.ComboBox();
            this.cbContract = new System.Windows.Forms.TextBox();
            this.tbSubContract = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubProjectList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddRow,
            this.tsmiDeleteRow,
            this.tsmiSave,
            this.tsmiDelete,
            this.tsmiCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(725, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsmiAddRow
            // 
            this.tsmiAddRow.Image = global::UfidaPMS.Forms.Properties.Resources.add;
            this.tsmiAddRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiAddRow.Name = "tsmiAddRow";
            this.tsmiAddRow.Size = new System.Drawing.Size(67, 22);
            this.tsmiAddRow.Text = "增行(&A)";
            this.tsmiAddRow.Click += new System.EventHandler(this.tsmiAddRow_Click);
            // 
            // tsmiDeleteRow
            // 
            this.tsmiDeleteRow.Image = global::UfidaPMS.Forms.Properties.Resources.SysReqNotMet;
            this.tsmiDeleteRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDeleteRow.Name = "tsmiDeleteRow";
            this.tsmiDeleteRow.Size = new System.Drawing.Size(67, 22);
            this.tsmiDeleteRow.Text = "删行(&D)";
            this.tsmiDeleteRow.Click += new System.EventHandler(this.tsmiDeleteRow_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Image = global::UfidaPMS.Forms.Properties.Resources.Save;
            this.tsmiSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(67, 22);
            this.tsmiSave.Text = "保存(&S)";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDelete.Image")));
            this.tsmiDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(67, 22);
            this.tsmiDelete.Text = "删除(&D)";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiCancel
            // 
            this.tsmiCancel.Image = global::UfidaPMS.Forms.Properties.Resources.menu_exit;
            this.tsmiCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiCancel.Name = "tsmiCancel";
            this.tsmiCancel.Size = new System.Drawing.Size(67, 22);
            this.tsmiCancel.Text = "关闭(&E)";
            this.tsmiCancel.Click += new System.EventHandler(this.tsmiCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Controls.Add(this.dgvSubProjectList, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.tbPMPProjectNo, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbProjectName, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.cbPM, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbDepartment, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbManager, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbProjectLevel, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbContract, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbSubContract, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(725, 444);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // dgvSubProjectList
            // 
            this.dgvSubProjectList.AllowUserToAddRows = false;
            this.dgvSubProjectList.AllowUserToDeleteRows = false;
            this.dgvSubProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubProjectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BianHao,
            this.SubProjectName,
            this.SubProjectType,
            this.ProjectMethod,
            this.Model,
            this.SubProjectManager,
            this.GuWen,
            this.PlanPeopleDay,
            this.percentage,
            this.StartTime,
            this.PlanFinishDay,
            this.earlypercentage,
            this.industry,
            this.projectid2,
            this.subprojectid,
            this.IsAdd,
            this.Contacter,
            this.Contactphone,
            this.progress,
            this.developadviser});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvSubProjectList, 4);
            this.dgvSubProjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubProjectList.Location = new System.Drawing.Point(23, 193);
            this.dgvSubProjectList.Name = "dgvSubProjectList";
            this.dgvSubProjectList.RowTemplate.Height = 23;
            this.dgvSubProjectList.Size = new System.Drawing.Size(660, 243);
            this.dgvSubProjectList.TabIndex = 27;
            this.dgvSubProjectList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubProjectList_CellClick);
            this.dgvSubProjectList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSubProjectList_DataError);
            this.dgvSubProjectList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSubProjectList_RowsAdded);
            // 
            // BianHao
            // 
            this.BianHao.DataPropertyName = "subprojectcode";
            this.BianHao.HeaderText = "编号";
            this.BianHao.Name = "BianHao";
            this.BianHao.Width = 150;
            // 
            // SubProjectName
            // 
            this.SubProjectName.DataPropertyName = "subprojectname";
            this.SubProjectName.HeaderText = "项目名称";
            this.SubProjectName.Name = "SubProjectName";
            this.SubProjectName.Width = 160;
            // 
            // SubProjectType
            // 
            this.SubProjectType.DataPropertyName = "subprojecttype";
            this.SubProjectType.HeaderText = "项目类型";
            this.SubProjectType.Items.AddRange(new object[] {
            "NC实施及客开",
            "UBS咨询",
            "NC应用集成",
            "HR实施及客开",
            "U9实施及客开",
            "U8实施及客开",
            "CRM实施及客开",
            "PLM实施及客开",
            "OA实施及客开",
            "BQ实施及客开",
            "其他软件实施"});
            this.SubProjectType.Name = "SubProjectType";
            this.SubProjectType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SubProjectType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ProjectMethod
            // 
            this.ProjectMethod.DataPropertyName = "projectmethod";
            this.ProjectMethod.HeaderText = "交付方法";
            this.ProjectMethod.Name = "ProjectMethod";
            this.ProjectMethod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectMethod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "modelname";
            this.Model.HeaderText = "模块";
            this.Model.Name = "Model";
            // 
            // SubProjectManager
            // 
            this.SubProjectManager.DataPropertyName = "subprojectmanager";
            this.SubProjectManager.HeaderText = "子项目经理";
            this.SubProjectManager.Name = "SubProjectManager";
            this.SubProjectManager.Width = 150;
            // 
            // GuWen
            // 
            this.GuWen.DataPropertyName = "implementadviser";
            this.GuWen.HeaderText = "实施顾问";
            this.GuWen.Name = "GuWen";
            // 
            // PlanPeopleDay
            // 
            this.PlanPeopleDay.DataPropertyName = "planpeopledays";
            this.PlanPeopleDay.HeaderText = "计划人天";
            this.PlanPeopleDay.Name = "PlanPeopleDay";
            this.PlanPeopleDay.Visible = false;
            // 
            // percentage
            // 
            this.percentage.DataPropertyName = "percentage";
            this.percentage.HeaderText = "占总比例(%)";
            this.percentage.Name = "percentage";
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "starttime";
            this.StartTime.HeaderText = "实际启动日期";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 160;
            // 
            // PlanFinishDay
            // 
            this.PlanFinishDay.DataPropertyName = "planfinishtime";
            this.PlanFinishDay.HeaderText = "预计完成日期";
            this.PlanFinishDay.Name = "PlanFinishDay";
            this.PlanFinishDay.ReadOnly = true;
            this.PlanFinishDay.Visible = false;
            this.PlanFinishDay.Width = 160;
            // 
            // earlypercentage
            // 
            this.earlypercentage.DataPropertyName = "earlypercentage";
            this.earlypercentage.HeaderText = "年初进度百分比(%)";
            this.earlypercentage.Name = "earlypercentage";
            this.earlypercentage.Width = 200;
            // 
            // industry
            // 
            this.industry.DataPropertyName = "industry";
            this.industry.HeaderText = "行业";
            this.industry.Name = "industry";
            this.industry.Visible = false;
            // 
            // projectid2
            // 
            this.projectid2.DataPropertyName = "projectid";
            this.projectid2.HeaderText = "projectid";
            this.projectid2.Name = "projectid2";
            this.projectid2.Visible = false;
            // 
            // subprojectid
            // 
            this.subprojectid.DataPropertyName = "subprojectid";
            this.subprojectid.HeaderText = "subprojectid";
            this.subprojectid.Name = "subprojectid";
            this.subprojectid.Visible = false;
            // 
            // IsAdd
            // 
            this.IsAdd.HeaderText = "IsAdd";
            this.IsAdd.Name = "IsAdd";
            this.IsAdd.Visible = false;
            // 
            // Contacter
            // 
            this.Contacter.DataPropertyName = "contacter";
            this.Contacter.HeaderText = "联系人";
            this.Contacter.Name = "Contacter";
            // 
            // Contactphone
            // 
            this.Contactphone.DataPropertyName = "contactphone";
            this.Contactphone.HeaderText = "联系电话";
            this.Contactphone.Name = "Contactphone";
            // 
            // progress
            // 
            this.progress.DataPropertyName = "progress";
            this.progress.HeaderText = "项目状态";
            this.progress.Name = "progress";
            this.progress.ReadOnly = true;
            this.progress.Visible = false;
            // 
            // developadviser
            // 
            this.developadviser.DataPropertyName = "developadviser";
            this.developadviser.HeaderText = "客开顾问";
            this.developadviser.Name = "developadviser";
            // 
            // tbPMPProjectNo
            // 
            this.tbPMPProjectNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPMPProjectNo.Location = new System.Drawing.Point(467, 58);
            this.tbPMPProjectNo.Name = "tbPMPProjectNo";
            this.tbPMPProjectNo.Size = new System.Drawing.Size(216, 26);
            this.tbPMPProjectNo.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(23, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "项目名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(356, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "实施部门：";
            // 
            // tbProjectName
            // 
            this.tbProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProjectName.Location = new System.Drawing.Point(134, 58);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(216, 26);
            this.tbProjectName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(356, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "PMP项目编号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(23, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "项目经理：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(356, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "项目级别：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(356, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "子合同：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(23, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "监管人员：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "合同：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "子合同列表：";
            // 
            // cbPM
            // 
            this.cbPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPM.FormattingEnabled = true;
            this.cbPM.Location = new System.Drawing.Point(134, 93);
            this.cbPM.Name = "cbPM";
            this.cbPM.Size = new System.Drawing.Size(216, 28);
            this.cbPM.TabIndex = 23;
            // 
            // cbDepartment
            // 
            this.cbDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(467, 93);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(216, 28);
            this.cbDepartment.TabIndex = 24;
            // 
            // cbManager
            // 
            this.cbManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbManager.FormattingEnabled = true;
            this.cbManager.Location = new System.Drawing.Point(134, 128);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(216, 28);
            this.cbManager.TabIndex = 25;
            // 
            // cbProjectLevel
            // 
            this.cbProjectLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProjectLevel.FormattingEnabled = true;
            this.cbProjectLevel.Items.AddRange(new object[] {
            "I级",
            "II级",
            "III级"});
            this.cbProjectLevel.Location = new System.Drawing.Point(467, 128);
            this.cbProjectLevel.Name = "cbProjectLevel";
            this.cbProjectLevel.Size = new System.Drawing.Size(216, 28);
            this.cbProjectLevel.TabIndex = 26;
            // 
            // cbContract
            // 
            this.cbContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbContract.Location = new System.Drawing.Point(134, 23);
            this.cbContract.Name = "cbContract";
            this.cbContract.ReadOnly = true;
            this.cbContract.Size = new System.Drawing.Size(216, 26);
            this.cbContract.TabIndex = 28;
            // 
            // tbSubContract
            // 
            this.tbSubContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSubContract.Location = new System.Drawing.Point(467, 23);
            this.tbSubContract.Name = "tbSubContract";
            this.tbSubContract.ReadOnly = true;
            this.tbSubContract.Size = new System.Drawing.Size(216, 26);
            this.tbSubContract.TabIndex = 29;
            // 
            // EditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 469);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EditProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑项目";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubProjectList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsmiSave;
        private System.Windows.Forms.ToolStripButton tsmiDelete;
        private System.Windows.Forms.ToolStripButton tsmiCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbPMPProjectNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbPM;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.ComboBox cbManager;
        private System.Windows.Forms.ComboBox cbProjectLevel;
        private System.Windows.Forms.DataGridView dgvSubProjectList;
        private System.Windows.Forms.ToolStripButton tsmiAddRow;
        private System.Windows.Forms.ToolStripButton tsmiDeleteRow;
        private System.Windows.Forms.TextBox cbContract;
        private System.Windows.Forms.TextBox tbSubContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn BianHao;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubProjectName;
        private System.Windows.Forms.DataGridViewComboBoxColumn SubProjectType;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProjectMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubProjectManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuWen;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanPeopleDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanFinishDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn earlypercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn industry;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn subprojectid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contactphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn developadviser;
    }
}
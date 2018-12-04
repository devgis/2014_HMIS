namespace UfidaPMS.Forms.Project
{
    partial class ViewProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProject));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsmiEdit = new System.Windows.Forms.ToolStripButton();
            this.tsmiDelete = new System.Windows.Forms.ToolStripButton();
            this.tsmiCancel = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbPMPProjectNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.dgvSubProjectList = new System.Windows.Forms.DataGridView();
            this.BianHao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubProjectType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.developadviser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbContractName = new System.Windows.Forms.TextBox();
            this.tbSubContractName = new System.Windows.Forms.TextBox();
            this.tbProjectManager = new System.Windows.Forms.TextBox();
            this.tbManager = new System.Windows.Forms.TextBox();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.tbProjectLevel = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubProjectList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiDelete,
            this.tsmiCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(830, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEdit.Image")));
            this.tsmiEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(67, 22);
            this.tsmiEdit.Text = "编辑(&E)";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbPMPProjectNo, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbProjectName, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvSubProjectList, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.tbContractName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbSubContractName, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbProjectManager, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbManager, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbDepartment, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbProjectLevel, 4, 7);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(830, 426);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tbPMPProjectNo
            // 
            this.tbPMPProjectNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPMPProjectNo.Location = new System.Drawing.Point(528, 58);
            this.tbPMPProjectNo.Name = "tbPMPProjectNo";
            this.tbPMPProjectNo.ReadOnly = true;
            this.tbPMPProjectNo.Size = new System.Drawing.Size(247, 26);
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
            this.label4.Location = new System.Drawing.Point(402, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "实施部门：";
            // 
            // tbProjectName
            // 
            this.tbProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProjectName.Location = new System.Drawing.Point(149, 58);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.ReadOnly = true;
            this.tbProjectName.Size = new System.Drawing.Size(247, 26);
            this.tbProjectName.TabIndex = 7;
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
            this.progress,
            this.Contacter,
            this.contactphone,
            this.developadviser});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvSubProjectList, 4);
            this.dgvSubProjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubProjectList.Location = new System.Drawing.Point(23, 193);
            this.dgvSubProjectList.Name = "dgvSubProjectList";
            this.dgvSubProjectList.ReadOnly = true;
            this.dgvSubProjectList.RowTemplate.Height = 23;
            this.dgvSubProjectList.Size = new System.Drawing.Size(752, 225);
            this.dgvSubProjectList.TabIndex = 12;
            // 
            // BianHao
            // 
            this.BianHao.DataPropertyName = "subprojectcode";
            this.BianHao.HeaderText = "编号";
            this.BianHao.Name = "BianHao";
            this.BianHao.ReadOnly = true;
            this.BianHao.Width = 150;
            // 
            // SubProjectName
            // 
            this.SubProjectName.DataPropertyName = "subprojectname";
            this.SubProjectName.HeaderText = "项目名称";
            this.SubProjectName.Name = "SubProjectName";
            this.SubProjectName.ReadOnly = true;
            this.SubProjectName.Width = 160;
            // 
            // SubProjectType
            // 
            this.SubProjectType.DataPropertyName = "subprojecttype";
            this.SubProjectType.HeaderText = "项目类型";
            this.SubProjectType.Name = "SubProjectType";
            this.SubProjectType.ReadOnly = true;
            // 
            // ProjectMethod
            // 
            this.ProjectMethod.DataPropertyName = "projectmethod";
            this.ProjectMethod.HeaderText = "交付方法";
            this.ProjectMethod.Name = "ProjectMethod";
            this.ProjectMethod.ReadOnly = true;
            this.ProjectMethod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "modelname";
            this.Model.HeaderText = "模块";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // SubProjectManager
            // 
            this.SubProjectManager.DataPropertyName = "subprojectmanager";
            this.SubProjectManager.HeaderText = "子项目经理";
            this.SubProjectManager.Name = "SubProjectManager";
            this.SubProjectManager.ReadOnly = true;
            this.SubProjectManager.Width = 150;
            // 
            // GuWen
            // 
            this.GuWen.DataPropertyName = "implementadviser";
            this.GuWen.HeaderText = "实施顾问";
            this.GuWen.Name = "GuWen";
            this.GuWen.ReadOnly = true;
            // 
            // PlanPeopleDay
            // 
            this.PlanPeopleDay.DataPropertyName = "planpeopledays";
            this.PlanPeopleDay.HeaderText = "计划人天";
            this.PlanPeopleDay.Name = "PlanPeopleDay";
            this.PlanPeopleDay.ReadOnly = true;
            // 
            // percentage
            // 
            this.percentage.DataPropertyName = "percentage";
            this.percentage.HeaderText = "占总比例(%)";
            this.percentage.Name = "percentage";
            this.percentage.ReadOnly = true;
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
            this.PlanFinishDay.Width = 160;
            // 
            // earlypercentage
            // 
            this.earlypercentage.DataPropertyName = "earlypercentage";
            this.earlypercentage.HeaderText = "年初进度百分比(%)";
            this.earlypercentage.Name = "earlypercentage";
            this.earlypercentage.ReadOnly = true;
            this.earlypercentage.Width = 200;
            // 
            // industry
            // 
            this.industry.DataPropertyName = "industry";
            this.industry.HeaderText = "行业";
            this.industry.Name = "industry";
            this.industry.ReadOnly = true;
            this.industry.Visible = false;
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
            // contactphone
            // 
            this.contactphone.DataPropertyName = "contactphone";
            this.contactphone.HeaderText = "联系电话";
            this.contactphone.Name = "contactphone";
            this.contactphone.ReadOnly = true;
            // 
            // developadviser
            // 
            this.developadviser.DataPropertyName = "developadviser";
            this.developadviser.HeaderText = "客开顾问";
            this.developadviser.Name = "developadviser";
            this.developadviser.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(402, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
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
            this.label2.Location = new System.Drawing.Point(402, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "项目级别：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(402, 20);
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
            // tbContractName
            // 
            this.tbContractName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContractName.Location = new System.Drawing.Point(149, 23);
            this.tbContractName.Name = "tbContractName";
            this.tbContractName.ReadOnly = true;
            this.tbContractName.Size = new System.Drawing.Size(247, 26);
            this.tbContractName.TabIndex = 27;
            // 
            // tbSubContractName
            // 
            this.tbSubContractName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSubContractName.Location = new System.Drawing.Point(528, 23);
            this.tbSubContractName.Name = "tbSubContractName";
            this.tbSubContractName.ReadOnly = true;
            this.tbSubContractName.Size = new System.Drawing.Size(247, 26);
            this.tbSubContractName.TabIndex = 28;
            // 
            // tbProjectManager
            // 
            this.tbProjectManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProjectManager.Location = new System.Drawing.Point(149, 93);
            this.tbProjectManager.Name = "tbProjectManager";
            this.tbProjectManager.ReadOnly = true;
            this.tbProjectManager.Size = new System.Drawing.Size(247, 26);
            this.tbProjectManager.TabIndex = 29;
            // 
            // tbManager
            // 
            this.tbManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbManager.Location = new System.Drawing.Point(149, 128);
            this.tbManager.Name = "tbManager";
            this.tbManager.ReadOnly = true;
            this.tbManager.Size = new System.Drawing.Size(247, 26);
            this.tbManager.TabIndex = 30;
            // 
            // tbDepartment
            // 
            this.tbDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDepartment.Location = new System.Drawing.Point(528, 93);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.ReadOnly = true;
            this.tbDepartment.Size = new System.Drawing.Size(247, 26);
            this.tbDepartment.TabIndex = 31;
            // 
            // tbProjectLevel
            // 
            this.tbProjectLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProjectLevel.Location = new System.Drawing.Point(528, 128);
            this.tbProjectLevel.Name = "tbProjectLevel";
            this.tbProjectLevel.ReadOnly = true;
            this.tbProjectLevel.Size = new System.Drawing.Size(247, 26);
            this.tbProjectLevel.TabIndex = 32;
            // 
            // ViewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 451);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ViewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "查看项目";
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
        private System.Windows.Forms.ToolStripButton tsmiEdit;
        private System.Windows.Forms.ToolStripButton tsmiDelete;
        private System.Windows.Forms.ToolStripButton tsmiCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbPMPProjectNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.DataGridView dgvSubProjectList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbContractName;
        private System.Windows.Forms.TextBox tbSubContractName;
        private System.Windows.Forms.TextBox tbProjectManager;
        private System.Windows.Forms.TextBox tbManager;
        private System.Windows.Forms.TextBox tbDepartment;
        private System.Windows.Forms.TextBox tbProjectLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BianHao;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubProjectType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectMethod;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacter;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn developadviser;
    }
}
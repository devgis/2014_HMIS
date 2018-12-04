namespace UfidaPMS.Forms.Milestone
{
    partial class EditMilestone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMilestone));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsmiSave = new System.Windows.Forms.ToolStripButton();
            this.tsmiDelete = new System.Windows.Forms.ToolStripButton();
            this.tsmiCancel = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbPMPProjectNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.dgvSubContractList = new System.Windows.Forms.DataGridView();
            this.cbSubContract = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbContract = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MilestoneName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectStarTime = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PlanFinishDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectPlanFinshTime = new System.Windows.Forms.DataGridViewButtonColumn();
            this.planpeopleday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubContractList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave,
            this.tsmiDelete,
            this.tsmiCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(730, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSave.Image")));
            this.tsmiSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(67, 22);
            this.tsmiSave.Text = "保存(&S)";
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDelete.Image")));
            this.tsmiDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(67, 22);
            this.tsmiDelete.Text = "删除(&D)";
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Controls.Add(this.tbPMPProjectNo, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbProjectName, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvSubContractList, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.cbSubContract, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbContract, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(859, 460);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tbPMPProjectNo
            // 
            this.tbPMPProjectNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPMPProjectNo.Location = new System.Drawing.Point(483, 43);
            this.tbPMPProjectNo.Name = "tbPMPProjectNo";
            this.tbPMPProjectNo.Size = new System.Drawing.Size(254, 26);
            this.tbPMPProjectNo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 5);
            this.label1.TabIndex = 14;
            this.label1.Text = "项目名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(23, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "创建日期：";
            // 
            // tbProjectName
            // 
            this.tbProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProjectName.Location = new System.Drawing.Point(123, 43);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(254, 26);
            this.tbProjectName.TabIndex = 7;
            // 
            // dgvSubContractList
            // 
            this.dgvSubContractList.AllowUserToAddRows = false;
            this.dgvSubContractList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubContractList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MilestoneName,
            this.StartTime,
            this.SelectStarTime,
            this.PlanFinishDay,
            this.SelectPlanFinshTime,
            this.planpeopleday});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvSubContractList, 4);
            this.dgvSubContractList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubContractList.Location = new System.Drawing.Point(23, 143);
            this.dgvSubContractList.Name = "dgvSubContractList";
            this.dgvSubContractList.RowTemplate.Height = 23;
            this.dgvSubContractList.Size = new System.Drawing.Size(714, 309);
            this.dgvSubContractList.TabIndex = 12;
            // 
            // cbSubContract
            // 
            this.cbSubContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSubContract.FormattingEnabled = true;
            this.cbSubContract.Location = new System.Drawing.Point(483, 8);
            this.cbSubContract.Name = "cbSubContract";
            this.cbSubContract.Size = new System.Drawing.Size(254, 28);
            this.cbSubContract.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(383, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "版本号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(383, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "子项目：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "项目：";
            // 
            // cbContract
            // 
            this.cbContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbContract.FormattingEnabled = true;
            this.cbContract.Location = new System.Drawing.Point(123, 8);
            this.cbContract.Name = "cbContract";
            this.cbContract.Size = new System.Drawing.Size(254, 28);
            this.cbContract.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(23, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "里程碑子表：";
            // 
            // MilestoneName
            // 
            this.MilestoneName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MilestoneName.HeaderText = "里程碑阶段";
            this.MilestoneName.Name = "MilestoneName";
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "启动日期";
            this.StartTime.Name = "StartTime";
            this.StartTime.Width = 160;
            // 
            // SelectStarTime
            // 
            this.SelectStarTime.HeaderText = "";
            this.SelectStarTime.Name = "SelectStarTime";
            this.SelectStarTime.Width = 30;
            // 
            // PlanFinishDay
            // 
            this.PlanFinishDay.HeaderText = "预计完成日期";
            this.PlanFinishDay.Name = "PlanFinishDay";
            this.PlanFinishDay.Width = 180;
            // 
            // SelectPlanFinshTime
            // 
            this.SelectPlanFinshTime.HeaderText = "";
            this.SelectPlanFinshTime.Name = "SelectPlanFinshTime";
            this.SelectPlanFinshTime.Width = 30;
            // 
            // planpeopleday
            // 
            this.planpeopleday.DataPropertyName = "planpeopleday";
            this.planpeopleday.HeaderText = "计划人天";
            this.planpeopleday.Name = "planpeopleday";
            // 
            // EditMilestone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 485);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EditMilestone";
            this.Text = "编辑里程碑";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubContractList)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.DataGridView dgvSubContractList;
        private System.Windows.Forms.ComboBox cbSubContract;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbContract;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MilestoneName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewButtonColumn SelectStarTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanFinishDay;
        private System.Windows.Forms.DataGridViewButtonColumn SelectPlanFinshTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn planpeopleday;
    }
}
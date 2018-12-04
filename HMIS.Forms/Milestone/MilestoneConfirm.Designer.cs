namespace UfidaPMS.Forms.Milestone
{
    partial class MilestoneConfirm
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
            this.tsmiCancel = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbVersion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMileStoneList = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milestoneid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submilestoneid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MilestoneName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planpeopleday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanFinishDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmOK = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbProject = new System.Windows.Forms.TextBox();
            this.tbSubProject = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMileStoneList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(842, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Controls.Add(this.tbVersion, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvMileStoneList, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbProject, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbSubProject, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(842, 469);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tbVersion
            // 
            this.tbVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbVersion.Location = new System.Drawing.Point(533, 58);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.Size = new System.Drawing.Size(274, 26);
            this.tbVersion.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(4, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "项目名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "创建日期：";
            // 
            // dgvMileStoneList
            // 
            this.dgvMileStoneList.AllowUserToAddRows = false;
            this.dgvMileStoneList.AllowUserToDeleteRows = false;
            this.dgvMileStoneList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMileStoneList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.milestoneid,
            this.submilestoneid,
            this.MilestoneName,
            this.planpeopleday,
            this.StartTime,
            this.PlanFinishDay,
            this.totalpercent,
            this.FinishDate,
            this.ConfirmOK});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvMileStoneList, 4);
            this.dgvMileStoneList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMileStoneList.Location = new System.Drawing.Point(13, 123);
            this.dgvMileStoneList.Name = "dgvMileStoneList";
            this.dgvMileStoneList.ReadOnly = true;
            this.dgvMileStoneList.RowTemplate.Height = 23;
            this.dgvMileStoneList.Size = new System.Drawing.Size(794, 323);
            this.dgvMileStoneList.TabIndex = 12;
            this.dgvMileStoneList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMileStoneList_CellClick);
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Index.DataPropertyName = "orderid";
            this.Index.FillWeight = 10000F;
            this.Index.HeaderText = "序号";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // milestoneid
            // 
            this.milestoneid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.milestoneid.DataPropertyName = "milestoneid";
            this.milestoneid.FillWeight = 1F;
            this.milestoneid.HeaderText = "milestoneid";
            this.milestoneid.Name = "milestoneid";
            this.milestoneid.ReadOnly = true;
            this.milestoneid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.milestoneid.Visible = false;
            // 
            // submilestoneid
            // 
            this.submilestoneid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.submilestoneid.DataPropertyName = "submilestoneid";
            this.submilestoneid.FillWeight = 1F;
            this.submilestoneid.HeaderText = "submilestoneid";
            this.submilestoneid.Name = "submilestoneid";
            this.submilestoneid.ReadOnly = true;
            this.submilestoneid.Visible = false;
            // 
            // MilestoneName
            // 
            this.MilestoneName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MilestoneName.DataPropertyName = "milestonename";
            this.MilestoneName.FillWeight = 10000F;
            this.MilestoneName.HeaderText = "里程碑阶段";
            this.MilestoneName.Name = "MilestoneName";
            this.MilestoneName.ReadOnly = true;
            this.MilestoneName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // planpeopleday
            // 
            this.planpeopleday.DataPropertyName = "planpeopleday";
            this.planpeopleday.HeaderText = "计划人天";
            this.planpeopleday.Name = "planpeopleday";
            this.planpeopleday.ReadOnly = true;
            // 
            // StartTime
            // 
            this.StartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StartTime.DataPropertyName = "startdate";
            this.StartTime.FillWeight = 10000F;
            this.StartTime.HeaderText = "启动日期";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PlanFinishDay
            // 
            this.PlanFinishDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlanFinishDay.DataPropertyName = "planfinishdate";
            this.PlanFinishDay.FillWeight = 10000F;
            this.PlanFinishDay.HeaderText = "预计完成日期";
            this.PlanFinishDay.Name = "PlanFinishDay";
            this.PlanFinishDay.ReadOnly = true;
            this.PlanFinishDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // totalpercent
            // 
            this.totalpercent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalpercent.DataPropertyName = "totalpercent";
            this.totalpercent.FillWeight = 10000F;
            this.totalpercent.HeaderText = "实际进度百分比";
            this.totalpercent.Name = "totalpercent";
            this.totalpercent.ReadOnly = true;
            this.totalpercent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FinishDate
            // 
            this.FinishDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FinishDate.DataPropertyName = "finishdate";
            this.FinishDate.FillWeight = 10000F;
            this.FinishDate.HeaderText = "实际完成时间";
            this.FinishDate.Name = "FinishDate";
            this.FinishDate.ReadOnly = true;
            this.FinishDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ConfirmOK
            // 
            this.ConfirmOK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ConfirmOK.DataPropertyName = "btntext";
            this.ConfirmOK.FillWeight = 3000F;
            this.ConfirmOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ConfirmOK.HeaderText = "";
            this.ConfirmOK.MinimumWidth = 30;
            this.ConfirmOK.Name = "ConfirmOK";
            this.ConfirmOK.ReadOnly = true;
            this.ConfirmOK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(413, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "版本号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(413, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "子项目：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "项目：";
            // 
            // tbProject
            // 
            this.tbProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProject.Location = new System.Drawing.Point(133, 23);
            this.tbProject.Name = "tbProject";
            this.tbProject.ReadOnly = true;
            this.tbProject.Size = new System.Drawing.Size(274, 26);
            this.tbProject.TabIndex = 21;
            // 
            // tbSubProject
            // 
            this.tbSubProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSubProject.Location = new System.Drawing.Point(533, 23);
            this.tbSubProject.Name = "tbSubProject";
            this.tbSubProject.ReadOnly = true;
            this.tbSubProject.Size = new System.Drawing.Size(274, 26);
            this.tbSubProject.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 26);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "里程碑列表";
            // 
            // MilestoneConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 494);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MilestoneConfirm";
            this.Text = "里程碑确认";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMileStoneList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsmiCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMileStoneList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbProject;
        private System.Windows.Forms.TextBox tbSubProject;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn milestoneid;
        private System.Windows.Forms.DataGridViewTextBoxColumn submilestoneid;
        private System.Windows.Forms.DataGridViewTextBoxColumn MilestoneName;
        private System.Windows.Forms.DataGridViewTextBoxColumn planpeopleday;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanFinishDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishDate;
        private System.Windows.Forms.DataGridViewButtonColumn ConfirmOK;
    }
}
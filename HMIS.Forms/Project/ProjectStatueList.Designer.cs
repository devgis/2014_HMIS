namespace UfidaPMS.Forms.Project
{
    partial class ProjectStatueList
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
            this.tsiDelete = new System.Windows.Forms.ToolStripButton();
            this.tsmiExit = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvStatueMain = new System.Windows.Forms.DataGridView();
            this.dgvStatueSub = new System.Windows.Forms.DataGridView();
            this.weektime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milestone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.week2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subprojectname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatueMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatueSub)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSearch,
            this.tsmiSave,
            this.tsiDelete,
            this.tsmiExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(928, 25);
            this.toolStrip1.TabIndex = 5;
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
            this.tsmiSave.Image = global::UfidaPMS.Forms.Properties.Resources.menu_relogin;
            this.tsmiSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(67, 22);
            this.tsmiSave.Text = "编辑(&S)";
            this.tsmiSave.Visible = false;
            // 
            // tsiDelete
            // 
            this.tsiDelete.Image = global::UfidaPMS.Forms.Properties.Resources.SysReqNotMet;
            this.tsiDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiDelete.Name = "tsiDelete";
            this.tsiDelete.Size = new System.Drawing.Size(67, 22);
            this.tsiDelete.Text = "删除(&D)";
            this.tsiDelete.Click += new System.EventHandler(this.tsiDelete_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.dgvStatueMain, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvStatueSub, 1, 4);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(928, 622);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "状态主表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "状态子表";
            // 
            // dgvStatueMain
            // 
            this.dgvStatueMain.AllowUserToAddRows = false;
            this.dgvStatueMain.AllowUserToDeleteRows = false;
            this.dgvStatueMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatueMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subprojectname,
            this.year,
            this.moth,
            this.week,
            this.state,
            this.problem,
            this.measure,
            this.remarks,
            this.createdate,
            this.statusid});
            this.dgvStatueMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatueMain.Location = new System.Drawing.Point(23, 53);
            this.dgvStatueMain.MultiSelect = false;
            this.dgvStatueMain.Name = "dgvStatueMain";
            this.dgvStatueMain.ReadOnly = true;
            this.dgvStatueMain.RowTemplate.Height = 23;
            this.dgvStatueMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatueMain.Size = new System.Drawing.Size(882, 255);
            this.dgvStatueMain.TabIndex = 2;
            this.dgvStatueMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStatueMain_CellDoubleClick);
            // 
            // dgvStatueSub
            // 
            this.dgvStatueSub.AllowUserToAddRows = false;
            this.dgvStatueSub.AllowUserToDeleteRows = false;
            this.dgvStatueSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatueSub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.weektime,
            this.milestone,
            this.percentage,
            this.statusid2,
            this.planid,
            this.month,
            this.week2});
            this.dgvStatueSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatueSub.Location = new System.Drawing.Point(23, 344);
            this.dgvStatueSub.MultiSelect = false;
            this.dgvStatueSub.Name = "dgvStatueSub";
            this.dgvStatueSub.ReadOnly = true;
            this.dgvStatueSub.RowTemplate.Height = 23;
            this.dgvStatueSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatueSub.Size = new System.Drawing.Size(882, 255);
            this.dgvStatueSub.TabIndex = 3;
            // 
            // weektime
            // 
            this.weektime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.weektime.DataPropertyName = "weektime";
            this.weektime.HeaderText = "预测日期";
            this.weektime.Name = "weektime";
            this.weektime.ReadOnly = true;
            // 
            // milestone
            // 
            this.milestone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.milestone.DataPropertyName = "milestone";
            this.milestone.HeaderText = "里程碑";
            this.milestone.Name = "milestone";
            this.milestone.ReadOnly = true;
            // 
            // percentage
            // 
            this.percentage.DataPropertyName = "percentage";
            this.percentage.HeaderText = "所占比例(%)";
            this.percentage.Name = "percentage";
            this.percentage.ReadOnly = true;
            this.percentage.Width = 150;
            // 
            // statusid2
            // 
            this.statusid2.DataPropertyName = "statusid";
            this.statusid2.HeaderText = "statusid";
            this.statusid2.Name = "statusid2";
            this.statusid2.ReadOnly = true;
            this.statusid2.Visible = false;
            // 
            // planid
            // 
            this.planid.DataPropertyName = "planid";
            this.planid.HeaderText = "planid";
            this.planid.Name = "planid";
            this.planid.ReadOnly = true;
            this.planid.Visible = false;
            // 
            // month
            // 
            this.month.DataPropertyName = "month";
            this.month.HeaderText = "month";
            this.month.Name = "month";
            this.month.ReadOnly = true;
            this.month.Visible = false;
            // 
            // week2
            // 
            this.week2.DataPropertyName = "week";
            this.week2.HeaderText = "week";
            this.week2.Name = "week2";
            this.week2.ReadOnly = true;
            this.week2.Visible = false;
            // 
            // subprojectname
            // 
            this.subprojectname.DataPropertyName = "subprojectname";
            this.subprojectname.HeaderText = "子项目";
            this.subprojectname.Name = "subprojectname";
            this.subprojectname.ReadOnly = true;
            // 
            // year
            // 
            this.year.DataPropertyName = "year";
            this.year.HeaderText = "年";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            this.year.Width = 60;
            // 
            // moth
            // 
            this.moth.DataPropertyName = "moth";
            this.moth.HeaderText = "月";
            this.moth.Name = "moth";
            this.moth.ReadOnly = true;
            this.moth.Width = 40;
            // 
            // week
            // 
            this.week.DataPropertyName = "week";
            this.week.HeaderText = "周";
            this.week.Name = "week";
            this.week.ReadOnly = true;
            this.week.Width = 40;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "项目状态";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // problem
            // 
            this.problem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.problem.DataPropertyName = "problem";
            this.problem.HeaderText = "待解决问题";
            this.problem.Name = "problem";
            this.problem.ReadOnly = true;
            // 
            // measure
            // 
            this.measure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.measure.DataPropertyName = "measure";
            this.measure.HeaderText = "本周关键任务";
            this.measure.Name = "measure";
            this.measure.ReadOnly = true;
            // 
            // remarks
            // 
            this.remarks.DataPropertyName = "remarks";
            this.remarks.HeaderText = "备注";
            this.remarks.Name = "remarks";
            this.remarks.ReadOnly = true;
            // 
            // createdate
            // 
            this.createdate.DataPropertyName = "createdate";
            this.createdate.HeaderText = "创建日期";
            this.createdate.Name = "createdate";
            this.createdate.ReadOnly = true;
            // 
            // statusid
            // 
            this.statusid.DataPropertyName = "statusid";
            this.statusid.HeaderText = "statusid";
            this.statusid.Name = "statusid";
            this.statusid.ReadOnly = true;
            this.statusid.Visible = false;
            // 
            // ProjectStatueList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 647);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ProjectStatueList";
            this.Text = "项目状态列表";
            this.Load += new System.EventHandler(this.ProjectStatueList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatueMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatueSub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsmiSearch;
        private System.Windows.Forms.ToolStripButton tsmiSave;
        private System.Windows.Forms.ToolStripButton tsmiExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvStatueMain;
        private System.Windows.Forms.DataGridView dgvStatueSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn weektime;
        private System.Windows.Forms.DataGridViewTextBoxColumn milestone;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn planid;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn week2;
        private System.Windows.Forms.ToolStripButton tsiDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn subprojectname;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn moth;
        private System.Windows.Forms.DataGridViewTextBoxColumn week;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn problem;
        private System.Windows.Forms.DataGridViewTextBoxColumn measure;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusid;
    }
}
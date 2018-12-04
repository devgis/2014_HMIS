namespace UfidaPMS.Forms.Project
{
    partial class SubProjectPeoPleDayList
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
            this.tsmiExit = new System.Windows.Forms.ToolStripButton();
            this.dgvActualdays = new System.Windows.Forms.DataGridView();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subprojectname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milestonename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualdays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guwen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualdaysid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subprojectid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvActualdaysSub = new System.Windows.Forms.DataGridView();
            this.gindex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guwen2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleyday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subactualdaysid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualdaysid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualdays)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualdaysSub)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSearch,
            this.tsmiExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(849, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.Image = global::UfidaPMS.Forms.Properties.Resources.viewMsg;
            this.tsmiSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(67, 22);
            this.tsmiSearch.Text = "查找(&C)";
            this.tsmiSearch.Click += new System.EventHandler(this.tsmiSearch_Click);
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
            // dgvActualdays
            // 
            this.dgvActualdays.AllowUserToAddRows = false;
            this.dgvActualdays.AllowUserToDeleteRows = false;
            this.dgvActualdays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualdays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectName,
            this.subprojectname,
            this.confirmdate,
            this.confirmuser,
            this.startdate,
            this.enddate,
            this.milestonename,
            this.actualdays,
            this.guwen,
            this.actualdaysid,
            this.projectid,
            this.subprojectid});
            this.dgvActualdays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActualdays.Location = new System.Drawing.Point(13, 13);
            this.dgvActualdays.Name = "dgvActualdays";
            this.dgvActualdays.ReadOnly = true;
            this.dgvActualdays.RowTemplate.Height = 23;
            this.dgvActualdays.Size = new System.Drawing.Size(823, 227);
            this.dgvActualdays.TabIndex = 5;
            this.dgvActualdays.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActualdays_CellDoubleClick);
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "projectname";
            this.ProjectName.HeaderText = "项目名称";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // subprojectname
            // 
            this.subprojectname.DataPropertyName = "subprojectname";
            this.subprojectname.HeaderText = "子项目名称";
            this.subprojectname.Name = "subprojectname";
            this.subprojectname.ReadOnly = true;
            this.subprojectname.Width = 113;
            // 
            // confirmdate
            // 
            this.confirmdate.DataPropertyName = "confirmdate";
            this.confirmdate.FillWeight = 80F;
            this.confirmdate.HeaderText = "报告日期";
            this.confirmdate.Name = "confirmdate";
            this.confirmdate.ReadOnly = true;
            this.confirmdate.Width = 90;
            // 
            // confirmuser
            // 
            this.confirmuser.DataPropertyName = "confirmuser";
            this.confirmuser.FillWeight = 70F;
            this.confirmuser.HeaderText = "制单人";
            this.confirmuser.Name = "confirmuser";
            this.confirmuser.ReadOnly = true;
            this.confirmuser.Width = 79;
            // 
            // startdate
            // 
            this.startdate.DataPropertyName = "startdate";
            this.startdate.FillWeight = 80F;
            this.startdate.HeaderText = "开始日期";
            this.startdate.Name = "startdate";
            this.startdate.ReadOnly = true;
            this.startdate.Width = 91;
            // 
            // enddate
            // 
            this.enddate.DataPropertyName = "enddate";
            this.enddate.FillWeight = 80F;
            this.enddate.HeaderText = "结束时间";
            this.enddate.Name = "enddate";
            this.enddate.ReadOnly = true;
            this.enddate.Width = 91;
            // 
            // milestonename
            // 
            this.milestonename.DataPropertyName = "milestonename";
            this.milestonename.FillWeight = 70F;
            this.milestonename.HeaderText = "里程碑";
            this.milestonename.Name = "milestonename";
            this.milestonename.ReadOnly = true;
            this.milestonename.Width = 80;
            // 
            // actualdays
            // 
            this.actualdays.DataPropertyName = "actualdays";
            this.actualdays.FillWeight = 60F;
            this.actualdays.HeaderText = "人天";
            this.actualdays.Name = "actualdays";
            this.actualdays.ReadOnly = true;
            this.actualdays.Width = 68;
            // 
            // guwen
            // 
            this.guwen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.guwen.DataPropertyName = "guwen";
            this.guwen.FillWeight = 60F;
            this.guwen.HeaderText = "顾问";
            this.guwen.Name = "guwen";
            this.guwen.ReadOnly = true;
            // 
            // actualdaysid
            // 
            this.actualdaysid.DataPropertyName = "actualdaysid";
            this.actualdaysid.HeaderText = "actualdaysid";
            this.actualdaysid.Name = "actualdaysid";
            this.actualdaysid.ReadOnly = true;
            this.actualdaysid.Visible = false;
            // 
            // projectid
            // 
            this.projectid.DataPropertyName = "projectid";
            this.projectid.HeaderText = "projectid";
            this.projectid.Name = "projectid";
            this.projectid.ReadOnly = true;
            this.projectid.Visible = false;
            // 
            // subprojectid
            // 
            this.subprojectid.DataPropertyName = "subprojectid";
            this.subprojectid.HeaderText = "subprojectid";
            this.subprojectid.Name = "subprojectid";
            this.subprojectid.ReadOnly = true;
            this.subprojectid.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.dgvActualdays, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvActualdaysSub, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 409);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // dgvActualdaysSub
            // 
            this.dgvActualdaysSub.AllowUserToAddRows = false;
            this.dgvActualdaysSub.AllowUserToDeleteRows = false;
            this.dgvActualdaysSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualdaysSub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gindex,
            this.guwen2,
            this.peopleyday,
            this.subactualdaysid,
            this.actualdaysid2});
            this.dgvActualdaysSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActualdaysSub.Location = new System.Drawing.Point(13, 246);
            this.dgvActualdaysSub.Name = "dgvActualdaysSub";
            this.dgvActualdaysSub.ReadOnly = true;
            this.dgvActualdaysSub.RowTemplate.Height = 23;
            this.dgvActualdaysSub.Size = new System.Drawing.Size(823, 149);
            this.dgvActualdaysSub.TabIndex = 6;
            // 
            // gindex
            // 
            this.gindex.DataPropertyName = "gindex";
            this.gindex.HeaderText = "序号";
            this.gindex.Name = "gindex";
            this.gindex.ReadOnly = true;
            // 
            // guwen2
            // 
            this.guwen2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.guwen2.DataPropertyName = "guwen";
            this.guwen2.HeaderText = "顾问";
            this.guwen2.Name = "guwen2";
            this.guwen2.ReadOnly = true;
            // 
            // peopleyday
            // 
            this.peopleyday.DataPropertyName = "peopleyday";
            this.peopleyday.HeaderText = "人天";
            this.peopleyday.Name = "peopleyday";
            this.peopleyday.ReadOnly = true;
            this.peopleyday.Width = 150;
            // 
            // subactualdaysid
            // 
            this.subactualdaysid.DataPropertyName = "subactualdaysid";
            this.subactualdaysid.HeaderText = "subactualdaysid";
            this.subactualdaysid.Name = "subactualdaysid";
            this.subactualdaysid.ReadOnly = true;
            this.subactualdaysid.Visible = false;
            // 
            // actualdaysid2
            // 
            this.actualdaysid2.DataPropertyName = "actualdaysid";
            this.actualdaysid2.HeaderText = "actualdaysid";
            this.actualdaysid2.Name = "actualdaysid2";
            this.actualdaysid2.ReadOnly = true;
            this.actualdaysid2.Visible = false;
            // 
            // SubProjectPeoPleDayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 434);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SubProjectPeoPleDayList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "项目人天列表";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualdays)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualdaysSub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsmiSearch;
        private System.Windows.Forms.ToolStripButton tsmiExit;
        private System.Windows.Forms.DataGridView dgvActualdays;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subprojectname;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn milestonename;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualdays;
        private System.Windows.Forms.DataGridViewTextBoxColumn guwen;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualdaysid;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectid;
        private System.Windows.Forms.DataGridViewTextBoxColumn subprojectid;
        private System.Windows.Forms.DataGridView dgvActualdaysSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn gindex;
        private System.Windows.Forms.DataGridViewTextBoxColumn guwen2;
        private System.Windows.Forms.DataGridViewTextBoxColumn peopleyday;
        private System.Windows.Forms.DataGridViewTextBoxColumn subactualdaysid;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualdaysid2;
    }
}
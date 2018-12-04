namespace UfidaPMS.Forms.Milestone
{
    partial class MilestoneList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MilestoneList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsmiSave = new System.Windows.Forms.ToolStripButton();
            this.tsmiExit = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMileStone = new System.Windows.Forms.DataGridView();
            this.milestoneid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subprojectid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMileStoneSub = new System.Windows.Forms.DataGridView();
            this.submilestoneid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milestoneid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milestonename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planpeopleday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planfinishdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMileStone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMileStoneSub)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave,
            this.tsmiExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(862, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSave.Image")));
            this.tsmiSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(67, 22);
            this.tsmiSave.Text = "复制(&C)";
            this.tsmiSave.Visible = false;
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
            this.tableLayoutPanel1.Controls.Add(this.dgvMileStone, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvMileStoneSub, 1, 4);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(862, 449);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "里程碑列表：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "里程碑子表";
            // 
            // dgvMileStone
            // 
            this.dgvMileStone.AllowUserToAddRows = false;
            this.dgvMileStone.AllowUserToDeleteRows = false;
            this.dgvMileStone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMileStone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.milestoneid,
            this.subprojectid,
            this.createdate,
            this.verion});
            this.dgvMileStone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMileStone.Location = new System.Drawing.Point(23, 53);
            this.dgvMileStone.MultiSelect = false;
            this.dgvMileStone.Name = "dgvMileStone";
            this.dgvMileStone.ReadOnly = true;
            this.dgvMileStone.RowTemplate.Height = 23;
            this.dgvMileStone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMileStone.Size = new System.Drawing.Size(816, 168);
            this.dgvMileStone.TabIndex = 2;
            this.dgvMileStone.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMileStone_CellDoubleClick);
            // 
            // milestoneid
            // 
            this.milestoneid.DataPropertyName = "milestoneid";
            this.milestoneid.HeaderText = "milestoneid";
            this.milestoneid.Name = "milestoneid";
            this.milestoneid.ReadOnly = true;
            this.milestoneid.Visible = false;
            // 
            // subprojectid
            // 
            this.subprojectid.DataPropertyName = "subprojectid";
            this.subprojectid.HeaderText = "subprojectid";
            this.subprojectid.Name = "subprojectid";
            this.subprojectid.ReadOnly = true;
            this.subprojectid.Visible = false;
            // 
            // createdate
            // 
            this.createdate.DataPropertyName = "createdate";
            this.createdate.HeaderText = "创建日期";
            this.createdate.Name = "createdate";
            this.createdate.ReadOnly = true;
            this.createdate.Width = 200;
            // 
            // verion
            // 
            this.verion.DataPropertyName = "verion";
            this.verion.HeaderText = "版本";
            this.verion.Name = "verion";
            this.verion.ReadOnly = true;
            this.verion.Width = 200;
            // 
            // dgvMileStoneSub
            // 
            this.dgvMileStoneSub.AllowUserToAddRows = false;
            this.dgvMileStoneSub.AllowUserToDeleteRows = false;
            this.dgvMileStoneSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMileStoneSub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.submilestoneid,
            this.milestoneid2,
            this.orderid,
            this.milestonename,
            this.planpeopleday,
            this.startdate,
            this.planfinishdate,
            this.finishdate,
            this.totalpercent});
            this.dgvMileStoneSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMileStoneSub.Location = new System.Drawing.Point(23, 257);
            this.dgvMileStoneSub.MultiSelect = false;
            this.dgvMileStoneSub.Name = "dgvMileStoneSub";
            this.dgvMileStoneSub.ReadOnly = true;
            this.dgvMileStoneSub.RowTemplate.Height = 23;
            this.dgvMileStoneSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMileStoneSub.Size = new System.Drawing.Size(816, 168);
            this.dgvMileStoneSub.TabIndex = 3;
            // 
            // submilestoneid
            // 
            this.submilestoneid.DataPropertyName = "submilestoneid";
            this.submilestoneid.HeaderText = "submilestoneid";
            this.submilestoneid.Name = "submilestoneid";
            this.submilestoneid.ReadOnly = true;
            this.submilestoneid.Visible = false;
            // 
            // milestoneid2
            // 
            this.milestoneid2.DataPropertyName = "milestoneid";
            this.milestoneid2.HeaderText = "milestoneid";
            this.milestoneid2.Name = "milestoneid2";
            this.milestoneid2.ReadOnly = true;
            this.milestoneid2.Visible = false;
            // 
            // orderid
            // 
            this.orderid.DataPropertyName = "orderid";
            this.orderid.HeaderText = "序号";
            this.orderid.Name = "orderid";
            this.orderid.ReadOnly = true;
            this.orderid.Width = 60;
            // 
            // milestonename
            // 
            this.milestonename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.milestonename.DataPropertyName = "milestonename";
            this.milestonename.HeaderText = "里程碑名称";
            this.milestonename.MinimumWidth = 160;
            this.milestonename.Name = "milestonename";
            this.milestonename.ReadOnly = true;
            // 
            // planpeopleday
            // 
            this.planpeopleday.DataPropertyName = "planpeopleday";
            this.planpeopleday.HeaderText = "计划人天";
            this.planpeopleday.Name = "planpeopleday";
            this.planpeopleday.ReadOnly = true;
            // 
            // startdate
            // 
            this.startdate.DataPropertyName = "startdate";
            this.startdate.HeaderText = "开始日期";
            this.startdate.Name = "startdate";
            this.startdate.ReadOnly = true;
            this.startdate.Width = 150;
            // 
            // planfinishdate
            // 
            this.planfinishdate.DataPropertyName = "planfinishdate";
            this.planfinishdate.HeaderText = "计划完成日期";
            this.planfinishdate.Name = "planfinishdate";
            this.planfinishdate.ReadOnly = true;
            this.planfinishdate.Width = 150;
            // 
            // finishdate
            // 
            this.finishdate.DataPropertyName = "finishdate";
            this.finishdate.HeaderText = "实际完成日期";
            this.finishdate.Name = "finishdate";
            this.finishdate.ReadOnly = true;
            this.finishdate.Width = 150;
            // 
            // totalpercent
            // 
            this.totalpercent.DataPropertyName = "totalpercent";
            this.totalpercent.HeaderText = "实际完成百分比";
            this.totalpercent.Name = "totalpercent";
            this.totalpercent.ReadOnly = true;
            this.totalpercent.Width = 200;
            // 
            // MilestoneList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 474);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MilestoneList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "历史里程碑列表";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMileStone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMileStoneSub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsmiSave;
        private System.Windows.Forms.ToolStripButton tsmiExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMileStone;
        private System.Windows.Forms.DataGridView dgvMileStoneSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn milestoneid;
        private System.Windows.Forms.DataGridViewTextBoxColumn subprojectid;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn verion;
        private System.Windows.Forms.DataGridViewTextBoxColumn submilestoneid;
        private System.Windows.Forms.DataGridViewTextBoxColumn milestoneid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderid;
        private System.Windows.Forms.DataGridViewTextBoxColumn milestonename;
        private System.Windows.Forms.DataGridViewTextBoxColumn planpeopleday;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn planfinishdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpercent;
    }
}
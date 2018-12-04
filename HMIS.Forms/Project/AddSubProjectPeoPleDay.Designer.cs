namespace UfidaPMS.Forms.Project
{
    partial class AddSubProjectPeoPleDay
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
            this.tsmiAddRow = new System.Windows.Forms.ToolStripButton();
            this.tsmiDeleteRow = new System.Windows.Forms.ToolStripButton();
            this.tsmiSave = new System.Windows.Forms.ToolStripButton();
            this.tsmiCancel = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpReportDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMilestone = new System.Windows.Forms.ComboBox();
            this.tbProject = new System.Windows.Forms.TextBox();
            this.tbSubProject = new System.Windows.Forms.TextBox();
            this.dgvGuWen = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuWen = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.人天 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCreater = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuWen)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddRow,
            this.tsmiDeleteRow,
            this.tsmiSave,
            this.tsmiCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(798, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsmiAddRow
            // 
            this.tsmiAddRow.Image = global::UfidaPMS.Forms.Properties.Resources.add;
            this.tsmiAddRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiAddRow.Name = "tsmiAddRow";
            this.tsmiAddRow.Size = new System.Drawing.Size(91, 22);
            this.tsmiAddRow.Text = "增加顾问(&A)";
            this.tsmiAddRow.Click += new System.EventHandler(this.tsmiAddRow_Click);
            // 
            // tsmiDeleteRow
            // 
            this.tsmiDeleteRow.Image = global::UfidaPMS.Forms.Properties.Resources.SysReqNotMet;
            this.tsmiDeleteRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDeleteRow.Name = "tsmiDeleteRow";
            this.tsmiDeleteRow.Size = new System.Drawing.Size(91, 22);
            this.tsmiDeleteRow.Text = "删除顾问(&D)";
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
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpStartTime, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.dtpReportDate, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtpEndTime, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.cbMilestone, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.tbProject, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbSubProject, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvGuWen, 2, 15);
            this.tableLayoutPanel1.Controls.Add(this.cbCreater, 2, 13);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 17;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(798, 557);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 5);
            this.label1.TabIndex = 14;
            this.label1.Text = "项目名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(23, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "报告日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(23, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "开始日期：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(23, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "子项目：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(23, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "结束日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(23, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "项目：";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpStartTime.Location = new System.Drawing.Point(173, 113);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(572, 26);
            this.dtpStartTime.TabIndex = 20;
            // 
            // dtpReportDate
            // 
            this.dtpReportDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpReportDate.Enabled = false;
            this.dtpReportDate.Location = new System.Drawing.Point(173, 78);
            this.dtpReportDate.Name = "dtpReportDate";
            this.dtpReportDate.Size = new System.Drawing.Size(572, 26);
            this.dtpReportDate.TabIndex = 22;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpEndTime.Location = new System.Drawing.Point(173, 148);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(572, 26);
            this.dtpEndTime.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(23, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "里程碑：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(23, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "制单人：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(23, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "人天：";
            // 
            // cbMilestone
            // 
            this.cbMilestone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMilestone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMilestone.FormattingEnabled = true;
            this.cbMilestone.Location = new System.Drawing.Point(173, 183);
            this.cbMilestone.Name = "cbMilestone";
            this.cbMilestone.Size = new System.Drawing.Size(572, 28);
            this.cbMilestone.TabIndex = 28;
            // 
            // tbProject
            // 
            this.tbProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProject.Location = new System.Drawing.Point(173, 8);
            this.tbProject.Name = "tbProject";
            this.tbProject.ReadOnly = true;
            this.tbProject.Size = new System.Drawing.Size(572, 26);
            this.tbProject.TabIndex = 32;
            // 
            // tbSubProject
            // 
            this.tbSubProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSubProject.Location = new System.Drawing.Point(173, 43);
            this.tbSubProject.Name = "tbSubProject";
            this.tbSubProject.ReadOnly = true;
            this.tbSubProject.Size = new System.Drawing.Size(572, 26);
            this.tbSubProject.TabIndex = 33;
            // 
            // dgvGuWen
            // 
            this.dgvGuWen.AllowUserToAddRows = false;
            this.dgvGuWen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuWen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.GuWen,
            this.人天});
            this.dgvGuWen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGuWen.Location = new System.Drawing.Point(173, 253);
            this.dgvGuWen.Name = "dgvGuWen";
            this.dgvGuWen.RowTemplate.Height = 23;
            this.dgvGuWen.Size = new System.Drawing.Size(572, 291);
            this.dgvGuWen.TabIndex = 34;
            this.dgvGuWen.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvGuWen_DataError);
            this.dgvGuWen.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvGuWen_EditingControlShowing);
            this.dgvGuWen.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvGuWen_RowsAdded);
            this.dgvGuWen.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvGuWen_RowsRemoved);
            this.dgvGuWen.Sorted += new System.EventHandler(this.dgvGuWen_Sorted);
            // 
            // Index
            // 
            this.Index.HeaderText = "序号";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Index.Width = 80;
            // 
            // GuWen
            // 
            this.GuWen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GuWen.HeaderText = "顾问姓名";
            this.GuWen.Name = "GuWen";
            this.GuWen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 人天
            // 
            this.人天.HeaderText = "顾问人天";
            this.人天.Name = "人天";
            this.人天.Width = 150;
            // 
            // cbCreater
            // 
            this.cbCreater.Location = new System.Drawing.Point(173, 218);
            this.cbCreater.Name = "cbCreater";
            this.cbCreater.ReadOnly = true;
            this.cbCreater.Size = new System.Drawing.Size(173, 26);
            this.cbCreater.TabIndex = 35;
            // 
            // AddSubProjectPeoPleDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 582);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AddSubProjectPeoPleDay";
            this.Text = "项目实际人天";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuWen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsmiSave;
        private System.Windows.Forms.ToolStripButton tsmiCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpReportDate;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMilestone;
        private System.Windows.Forms.TextBox tbProject;
        private System.Windows.Forms.TextBox tbSubProject;
        private System.Windows.Forms.DataGridView dgvGuWen;
        private System.Windows.Forms.ToolStripButton tsmiAddRow;
        private System.Windows.Forms.ToolStripButton tsmiDeleteRow;
        private System.Windows.Forms.TextBox cbCreater;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewComboBoxColumn GuWen;
        private System.Windows.Forms.DataGridViewTextBoxColumn 人天;
    }
}
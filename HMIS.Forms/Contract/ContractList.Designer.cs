namespace UfidaPMS.Forms.Contract
{
    partial class ContractList
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
            this.tsmiShouKuan = new System.Windows.Forms.ToolStripButton();
            this.tsmiShouKuanList = new System.Windows.Forms.ToolStripButton();
            this.tsmiCreateProject = new System.Windows.Forms.ToolStripButton();
            this.tsmiExit = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.contractid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.签定日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.主合同号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.客户名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.客户经理 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubContract = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcontractid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.子合同号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.合同类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.合同收款条件 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.合同金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.累计收款 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.应收金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubContract)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSearch,
            this.tsmiSave,
            this.tsmiView,
            this.tsmiShouKuan,
            this.tsmiShouKuanList,
            this.tsmiCreateProject,
            this.tsmiExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1034, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsmiSearch
            // 
            //this.tsmiSearch.Image = global::UfidaPMS.Forms.Properties.Resources.search;
            this.tsmiSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(67, 22);
            this.tsmiSearch.Text = "查找(&C)";
            this.tsmiSearch.Click += new System.EventHandler(this.tsmiSearch_Click);
            // 
            // tsmiSave
            // 
            //this.tsmiSave.Image = global::UfidaPMS.Forms.Properties.Resources.edit;
            this.tsmiSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(67, 22);
            this.tsmiSave.Text = "编辑(&S)";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiView
            // 
            //this.tsmiView.Image = global::UfidaPMS.Forms.Properties.Resources.viewMsg;
            this.tsmiView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(67, 22);
            this.tsmiView.Text = "查看(&V)";
            this.tsmiView.Click += new System.EventHandler(this.tsmiView_Click);
            // 
            // tsmiShouKuan
            // 
            this.tsmiShouKuan.Image = global::UfidaPMS.Forms.Properties.Resources.menu_helpabout;
            this.tsmiShouKuan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiShouKuan.Name = "tsmiShouKuan";
            this.tsmiShouKuan.Size = new System.Drawing.Size(67, 22);
            this.tsmiShouKuan.Text = "收款(&K)";
            this.tsmiShouKuan.Click += new System.EventHandler(this.tsmiShouKuan_Click);
            // 
            // tsmiShouKuanList
            // 
            this.tsmiShouKuanList.Image = global::UfidaPMS.Forms.Properties.Resources.menu_helpabout;
            this.tsmiShouKuanList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiShouKuanList.Name = "tsmiShouKuanList";
            this.tsmiShouKuanList.Size = new System.Drawing.Size(91, 22);
            this.tsmiShouKuanList.Text = "收款历史(&K)";
            this.tsmiShouKuanList.Click += new System.EventHandler(this.tsmiShouKuanList_Click);
            // 
            // tsmiCreateProject
            // 
            this.tsmiCreateProject.Image = global::UfidaPMS.Forms.Properties.Resources.menu_project;
            this.tsmiCreateProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiCreateProject.Name = "tsmiCreateProject";
            this.tsmiCreateProject.Size = new System.Drawing.Size(67, 22);
            this.tsmiCreateProject.Text = "立项(&V)";
            this.tsmiCreateProject.Click += new System.EventHandler(this.tsmiCreateProject_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.dgvContract, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvSubContract, 1, 4);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1034, 534);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "合同主表：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "子项目列表:";
            // 
            // dgvContract
            // 
            this.dgvContract.AllowUserToAddRows = false;
            this.dgvContract.AllowUserToDeleteRows = false;
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contractid,
            this.签定日期,
            this.主合同号,
            this.客户名称,
            this.部门,
            this.客户经理,
            this.Remarks,
            this.trade});
            this.dgvContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContract.Location = new System.Drawing.Point(23, 53);
            this.dgvContract.MultiSelect = false;
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.ReadOnly = true;
            this.dgvContract.RowTemplate.Height = 23;
            this.dgvContract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContract.Size = new System.Drawing.Size(988, 211);
            this.dgvContract.TabIndex = 2;
            this.dgvContract.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContract_CellDoubleClick);
            // 
            // contractid
            // 
            this.contractid.DataPropertyName = "contractid";
            this.contractid.HeaderText = "contractid";
            this.contractid.Name = "contractid";
            this.contractid.ReadOnly = true;
            this.contractid.Visible = false;
            // 
            // 签定日期
            // 
            this.签定日期.DataPropertyName = "contractdate";
            this.签定日期.HeaderText = "签定日期";
            this.签定日期.Name = "签定日期";
            this.签定日期.ReadOnly = true;
            // 
            // 主合同号
            // 
            this.主合同号.DataPropertyName = "contractno";
            this.主合同号.HeaderText = "主合同号";
            this.主合同号.Name = "主合同号";
            this.主合同号.ReadOnly = true;
            this.主合同号.Width = 150;
            // 
            // 客户名称
            // 
            this.客户名称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.客户名称.DataPropertyName = "custname";
            this.客户名称.HeaderText = "客户名称";
            this.客户名称.Name = "客户名称";
            this.客户名称.ReadOnly = true;
            // 
            // 部门
            // 
            this.部门.DataPropertyName = "department";
            this.部门.HeaderText = "部门";
            this.部门.Name = "部门";
            this.部门.ReadOnly = true;
            // 
            // 客户经理
            // 
            this.客户经理.DataPropertyName = "custmanager";
            this.客户经理.HeaderText = "客户经理";
            this.客户经理.Name = "客户经理";
            this.客户经理.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "备注";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // trade
            // 
            this.trade.DataPropertyName = "trade";
            this.trade.HeaderText = "行业";
            this.trade.Name = "trade";
            this.trade.ReadOnly = true;
            // 
            // dgvSubContract
            // 
            this.dgvSubContract.AllowUserToAddRows = false;
            this.dgvSubContract.AllowUserToDeleteRows = false;
            this.dgvSubContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.subcontractid,
            this.子合同号,
            this.合同类型,
            this.合同收款条件,
            this.合同金额,
            this.累计收款,
            this.应收金额,
            this.备注,
            this.contractno,
            this.contractid2});
            this.dgvSubContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubContract.Location = new System.Drawing.Point(23, 300);
            this.dgvSubContract.MultiSelect = false;
            this.dgvSubContract.Name = "dgvSubContract";
            this.dgvSubContract.ReadOnly = true;
            this.dgvSubContract.RowTemplate.Height = 23;
            this.dgvSubContract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubContract.Size = new System.Drawing.Size(988, 211);
            this.dgvSubContract.TabIndex = 3;
            this.dgvSubContract.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSubContract_RowsAdded);
            this.dgvSubContract.Sorted += new System.EventHandler(this.dgvSubContract_Sorted);
            // 
            // 序号
            // 
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.Width = 60;
            // 
            // subcontractid
            // 
            this.subcontractid.DataPropertyName = "subcontractid";
            this.subcontractid.HeaderText = "subcontractid";
            this.subcontractid.Name = "subcontractid";
            this.subcontractid.ReadOnly = true;
            this.subcontractid.Visible = false;
            // 
            // 子合同号
            // 
            this.子合同号.DataPropertyName = "subcontractno";
            this.子合同号.HeaderText = "子合同号";
            this.子合同号.Name = "子合同号";
            this.子合同号.ReadOnly = true;
            // 
            // 合同类型
            // 
            this.合同类型.DataPropertyName = "subcontracttype";
            this.合同类型.HeaderText = "合同类型";
            this.合同类型.Name = "合同类型";
            this.合同类型.ReadOnly = true;
            // 
            // 合同收款条件
            // 
            this.合同收款条件.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.合同收款条件.DataPropertyName = "makecondition";
            this.合同收款条件.FillWeight = 160F;
            this.合同收款条件.HeaderText = "合同收款条件";
            this.合同收款条件.Name = "合同收款条件";
            this.合同收款条件.ReadOnly = true;
            // 
            // 合同金额
            // 
            this.合同金额.DataPropertyName = "contractamount";
            this.合同金额.HeaderText = "合同金额";
            this.合同金额.Name = "合同金额";
            this.合同金额.ReadOnly = true;
            // 
            // 累计收款
            // 
            this.累计收款.DataPropertyName = "totoalreceive";
            this.累计收款.HeaderText = "累计收款";
            this.累计收款.Name = "累计收款";
            this.累计收款.ReadOnly = true;
            // 
            // 应收金额
            // 
            this.应收金额.DataPropertyName = "leftaccount";
            this.应收金额.HeaderText = "应收金额";
            this.应收金额.Name = "应收金额";
            this.应收金额.ReadOnly = true;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "productversion";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Width = 160;
            // 
            // contractno
            // 
            this.contractno.DataPropertyName = "contractno";
            this.contractno.HeaderText = "contractno";
            this.contractno.Name = "contractno";
            this.contractno.ReadOnly = true;
            this.contractno.Visible = false;
            // 
            // contractid2
            // 
            this.contractid2.DataPropertyName = "contractid";
            this.contractid2.HeaderText = "contractid";
            this.contractid2.Name = "contractid2";
            this.contractid2.ReadOnly = true;
            this.contractid2.Visible = false;
            // 
            // ContractList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 559);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ContractList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "合同列表";
            this.Load += new System.EventHandler(this.ContractList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubContract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsmiSave;
        private System.Windows.Forms.ToolStripButton tsmiExit;
        private System.Windows.Forms.ToolStripButton tsmiView;
        //private System.Windows.Forms.DataGridView dgvSubContractList;
        private System.Windows.Forms.ToolStripButton tsmiSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvContract;
        private System.Windows.Forms.DataGridView dgvSubContract;
        private System.Windows.Forms.ToolStripButton tsmiCreateProject;
        private System.Windows.Forms.ToolStripButton tsmiShouKuan;
        private System.Windows.Forms.ToolStripButton tsmiShouKuanList;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcontractid;
        private System.Windows.Forms.DataGridViewTextBoxColumn 子合同号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 合同类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 合同收款条件;
        private System.Windows.Forms.DataGridViewTextBoxColumn 合同金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 累计收款;
        private System.Windows.Forms.DataGridViewTextBoxColumn 应收金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractno;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractid;
        private System.Windows.Forms.DataGridViewTextBoxColumn 签定日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 主合同号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客户名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部门;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客户经理;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn trade;
    }
}
namespace UfidaPMS.Forms.Contract
{
    partial class EditContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditContract));
            this.tsmiCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsmiAddRow = new System.Windows.Forms.ToolStripButton();
            this.tsmiDeleteRow = new System.Windows.Forms.ToolStripButton();
            this.tsmiSave = new System.Windows.Forms.ToolStripButton();
            this.tsmiDelete = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSubContractList = new System.Windows.Forms.DataGridView();
            this.SubContractNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.makecondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcontractid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftaccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totoalreceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbContractNo = new System.Windows.Forms.TextBox();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.cbCustName = new System.Windows.Forms.ComboBox();
            this.cbDepartMent = new System.Windows.Forms.ComboBox();
            this.cbCustManager = new System.Windows.Forms.ComboBox();
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTrade = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubContractList)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(882, 25);
            this.toolStrip1.TabIndex = 2;
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
            this.tsmiSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSave.Image")));
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Controls.Add(this.dgvSubContractList, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.tbContractNo, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpCreateDate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbCustName, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbDepartMent, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbCustManager, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbRemarks, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbTrade, 4, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 464);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgvSubContractList
            // 
            this.dgvSubContractList.AllowUserToAddRows = false;
            this.dgvSubContractList.AllowUserToDeleteRows = false;
            this.dgvSubContractList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubContractList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubContractNo,
            this.ContractType,
            this.makecondition,
            this.contractamount,
            this.productversion,
            this.Index,
            this.contractno,
            this.subcontractid,
            this.contractid2,
            this.IsAdd,
            this.leftaccount,
            this.totoalreceive});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvSubContractList, 4);
            this.dgvSubContractList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubContractList.Location = new System.Drawing.Point(23, 198);
            this.dgvSubContractList.Name = "dgvSubContractList";
            this.dgvSubContractList.RowTemplate.Height = 23;
            this.dgvSubContractList.Size = new System.Drawing.Size(814, 258);
            this.dgvSubContractList.TabIndex = 16;
            this.dgvSubContractList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSubContractList_DataError);
            this.dgvSubContractList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSubContractList_RowsAdded);
            // 
            // SubContractNo
            // 
            this.SubContractNo.DataPropertyName = "subcontractno";
            this.SubContractNo.HeaderText = "子合同号";
            this.SubContractNo.Name = "SubContractNo";
            this.SubContractNo.Width = 160;
            // 
            // ContractType
            // 
            this.ContractType.DataPropertyName = "subcontracttype";
            this.ContractType.HeaderText = "合同类型";
            this.ContractType.Items.AddRange(new object[] {
            "软件合同",
            "实施合同",
            "服务合同",
            "开发合同",
            "培训合同",
            "咨询合同",
            "其他合同"});
            this.ContractType.Name = "ContractType";
            this.ContractType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ContractType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ContractType.Width = 120;
            // 
            // makecondition
            // 
            this.makecondition.DataPropertyName = "makecondition";
            this.makecondition.HeaderText = "合同收款条件";
            this.makecondition.Name = "makecondition";
            this.makecondition.Width = 196;
            // 
            // contractamount
            // 
            this.contractamount.DataPropertyName = "contractamount";
            this.contractamount.HeaderText = "合同金额";
            this.contractamount.Name = "contractamount";
            // 
            // productversion
            // 
            this.productversion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productversion.DataPropertyName = "productversion";
            this.productversion.HeaderText = "备注";
            this.productversion.Name = "productversion";
            // 
            // Index
            // 
            this.Index.HeaderText = "序号";
            this.Index.Name = "Index";
            this.Index.Visible = false;
            this.Index.Width = 60;
            // 
            // contractno
            // 
            this.contractno.DataPropertyName = "contractno";
            this.contractno.HeaderText = "contractno";
            this.contractno.Name = "contractno";
            this.contractno.Visible = false;
            // 
            // subcontractid
            // 
            this.subcontractid.DataPropertyName = "subcontractid";
            this.subcontractid.HeaderText = "subcontractid";
            this.subcontractid.Name = "subcontractid";
            this.subcontractid.Visible = false;
            // 
            // contractid2
            // 
            this.contractid2.DataPropertyName = "contractid";
            this.contractid2.HeaderText = "contractid";
            this.contractid2.Name = "contractid2";
            this.contractid2.Visible = false;
            // 
            // IsAdd
            // 
            this.IsAdd.HeaderText = "IsAdd";
            this.IsAdd.Name = "IsAdd";
            this.IsAdd.Visible = false;
            // 
            // leftaccount
            // 
            this.leftaccount.DataPropertyName = "leftaccount";
            this.leftaccount.HeaderText = "leftaccount";
            this.leftaccount.Name = "leftaccount";
            this.leftaccount.Visible = false;
            // 
            // totoalreceive
            // 
            this.totoalreceive.DataPropertyName = "totoalreceive";
            this.totoalreceive.HeaderText = "totoalreceive";
            this.totoalreceive.Name = "totoalreceive";
            this.totoalreceive.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(23, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "签订日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(433, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "主合同号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(23, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "客户名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(433, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "部门：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(23, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "客户经理：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(23, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "子项目列表：";
            // 
            // tbContractNo
            // 
            this.tbContractNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContractNo.Location = new System.Drawing.Point(556, 8);
            this.tbContractNo.Name = "tbContractNo";
            this.tbContractNo.Size = new System.Drawing.Size(281, 26);
            this.tbContractNo.TabIndex = 9;
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpCreateDate.Enabled = false;
            this.dtpCreateDate.Location = new System.Drawing.Point(146, 8);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(281, 26);
            this.dtpCreateDate.TabIndex = 11;
            // 
            // cbCustName
            // 
            this.cbCustName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCustName.FormattingEnabled = true;
            this.cbCustName.Location = new System.Drawing.Point(146, 43);
            this.cbCustName.Name = "cbCustName";
            this.cbCustName.Size = new System.Drawing.Size(281, 28);
            this.cbCustName.TabIndex = 13;
            // 
            // cbDepartMent
            // 
            this.cbDepartMent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDepartMent.FormattingEnabled = true;
            this.cbDepartMent.Location = new System.Drawing.Point(556, 43);
            this.cbDepartMent.Name = "cbDepartMent";
            this.cbDepartMent.Size = new System.Drawing.Size(281, 28);
            this.cbDepartMent.TabIndex = 14;
            // 
            // cbCustManager
            // 
            this.cbCustManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCustManager.FormattingEnabled = true;
            this.cbCustManager.Location = new System.Drawing.Point(146, 78);
            this.cbCustManager.Name = "cbCustManager";
            this.cbCustManager.Size = new System.Drawing.Size(281, 28);
            this.cbCustManager.TabIndex = 15;
            // 
            // tbRemarks
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbRemarks, 3);
            this.tbRemarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRemarks.Location = new System.Drawing.Point(146, 113);
            this.tbRemarks.MaxLength = 500;
            this.tbRemarks.Multiline = true;
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRemarks.Size = new System.Drawing.Size(691, 44);
            this.tbRemarks.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "备注：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "行业：";
            // 
            // cbTrade
            // 
            this.cbTrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTrade.FormattingEnabled = true;
            this.cbTrade.Location = new System.Drawing.Point(556, 78);
            this.cbTrade.Name = "cbTrade";
            this.cbTrade.Size = new System.Drawing.Size(281, 28);
            this.cbTrade.TabIndex = 20;
            // 
            // EditContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EditContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑合同";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubContractList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsmiCancel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsmiSave;
        private System.Windows.Forms.ToolStripButton tsmiDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbContractNo;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.ComboBox cbCustName;
        private System.Windows.Forms.ComboBox cbDepartMent;
        private System.Windows.Forms.ComboBox cbCustManager;
        private System.Windows.Forms.DataGridView dgvSubContractList;
        private System.Windows.Forms.ToolStripButton tsmiAddRow;
        private System.Windows.Forms.ToolStripButton tsmiDeleteRow;
        private System.Windows.Forms.TextBox tbRemarks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubContractNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn ContractType;
        private System.Windows.Forms.DataGridViewTextBoxColumn makecondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn productversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractno;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcontractid;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftaccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totoalreceive;
    }
}
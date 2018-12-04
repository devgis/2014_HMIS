namespace UfidaPMS.Forms.Income
{
    partial class IncomeList
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
            this.tsmiExit = new System.Windows.Forms.ToolStripButton();
            this.dgvShouKuanList = new System.Windows.Forms.DataGridView();
            this.incomedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeuserid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcontractid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tsmiDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShouKuanList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete,
            this.tsmiExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(743, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
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
            // dgvShouKuanList
            // 
            this.dgvShouKuanList.AllowUserToAddRows = false;
            this.dgvShouKuanList.AllowUserToDeleteRows = false;
            this.dgvShouKuanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShouKuanList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incomedate,
            this.incomeamount,
            this.incomeuserid,
            this.incomeid,
            this.subcontractid2});
            this.dgvShouKuanList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShouKuanList.Location = new System.Drawing.Point(23, 23);
            this.dgvShouKuanList.MultiSelect = false;
            this.dgvShouKuanList.Name = "dgvShouKuanList";
            this.dgvShouKuanList.ReadOnly = true;
            this.dgvShouKuanList.RowTemplate.Height = 23;
            this.dgvShouKuanList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShouKuanList.Size = new System.Drawing.Size(697, 391);
            this.dgvShouKuanList.TabIndex = 3;
            // 
            // incomedate
            // 
            this.incomedate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.incomedate.DataPropertyName = "incomedate";
            this.incomedate.HeaderText = "收款日期";
            this.incomedate.Name = "incomedate";
            this.incomedate.ReadOnly = true;
            // 
            // incomeamount
            // 
            this.incomeamount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.incomeamount.DataPropertyName = "incomeamount";
            this.incomeamount.HeaderText = "收款金额";
            this.incomeamount.Name = "incomeamount";
            this.incomeamount.ReadOnly = true;
            // 
            // incomeuserid
            // 
            this.incomeuserid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.incomeuserid.DataPropertyName = "incomeuserid";
            this.incomeuserid.HeaderText = "收款人";
            this.incomeuserid.Name = "incomeuserid";
            this.incomeuserid.ReadOnly = true;
            // 
            // incomeid
            // 
            this.incomeid.DataPropertyName = "incomeid";
            this.incomeid.HeaderText = "incomeid";
            this.incomeid.Name = "incomeid";
            this.incomeid.ReadOnly = true;
            this.incomeid.Visible = false;
            // 
            // subcontractid2
            // 
            this.subcontractid2.DataPropertyName = "subcontractid";
            this.subcontractid2.HeaderText = "subcontractid";
            this.subcontractid2.Name = "subcontractid2";
            this.subcontractid2.ReadOnly = true;
            this.subcontractid2.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgvShouKuanList, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(743, 437);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = global::UfidaPMS.Forms.Properties.Resources.SysReqNotMet;
            this.tsmiDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(67, 22);
            this.tsmiDelete.Text = "删除(&D)";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // IncomeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "IncomeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "收款列表";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShouKuanList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsmiExit;
        private System.Windows.Forms.DataGridView dgvShouKuanList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeuserid;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcontractid2;
        private System.Windows.Forms.ToolStripButton tsmiDelete;
    }
}
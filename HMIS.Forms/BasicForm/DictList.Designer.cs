namespace FYSOFT.HMIS.Forms.BasicForm
{
    partial class DictList
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
            this.tsmiEdit = new System.Windows.Forms.ToolStripButton();
            this.tsmiRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsmiCancel = new System.Windows.Forms.ToolStripButton();
            this.dgvDictList = new System.Windows.Forms.DataGridView();
            this.dictionaryid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dictionaryvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dictionaryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddRow,
            this.tsmiDeleteRow,
            this.tsmiEdit,
            this.tsmiRefresh,
            this.tsmiCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(751, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsmiAddRow
            // 
            this.tsmiAddRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiAddRow.Name = "tsmiAddRow";
            this.tsmiAddRow.Size = new System.Drawing.Size(52, 22);
            this.tsmiAddRow.Text = "新建(&A)";
            this.tsmiAddRow.Click += new System.EventHandler(this.tsmiAddRow_Click);
            // 
            // tsmiDeleteRow
            // 
            this.tsmiDeleteRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDeleteRow.Name = "tsmiDeleteRow";
            this.tsmiDeleteRow.Size = new System.Drawing.Size(53, 22);
            this.tsmiDeleteRow.Text = "删除(&D)";
            this.tsmiDeleteRow.Click += new System.EventHandler(this.tsmiDeleteRow_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(52, 22);
            this.tsmiEdit.Text = "编辑(&B)";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiRefresh
            // 
            this.tsmiRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiRefresh.Name = "tsmiRefresh";
            this.tsmiRefresh.Size = new System.Drawing.Size(52, 22);
            this.tsmiRefresh.Text = "刷新(&R)";
            this.tsmiRefresh.Click += new System.EventHandler(this.tsmiRefresh_Click);
            // 
            // tsmiCancel
            // 
            this.tsmiCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiCancel.Name = "tsmiCancel";
            this.tsmiCancel.Size = new System.Drawing.Size(51, 22);
            this.tsmiCancel.Text = "关闭(&E)";
            this.tsmiCancel.Click += new System.EventHandler(this.tsmiCancel_Click);
            // 
            // dgvDictList
            // 
            this.dgvDictList.AllowUserToAddRows = false;
            this.dgvDictList.AllowUserToDeleteRows = false;
            this.dgvDictList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDictList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dictionaryid,
            this.dictionaryvalue,
            this.dictionaryname});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvDictList, 4);
            this.dgvDictList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDictList.Location = new System.Drawing.Point(23, 8);
            this.dgvDictList.MultiSelect = false;
            this.dgvDictList.Name = "dgvDictList";
            this.dgvDictList.ReadOnly = true;
            this.dgvDictList.RowTemplate.Height = 23;
            this.dgvDictList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDictList.Size = new System.Drawing.Size(696, 425);
            this.dgvDictList.TabIndex = 12;
            // 
            // dictionaryid
            // 
            this.dictionaryid.DataPropertyName = "dictionaryid";
            this.dictionaryid.HeaderText = "ID";
            this.dictionaryid.Name = "dictionaryid";
            this.dictionaryid.ReadOnly = true;
            this.dictionaryid.Visible = false;
            // 
            // dictionaryvalue
            // 
            this.dictionaryvalue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dictionaryvalue.DataPropertyName = "dictionaryvalue";
            this.dictionaryvalue.HeaderText = "名称";
            this.dictionaryvalue.Name = "dictionaryvalue";
            this.dictionaryvalue.ReadOnly = true;
            // 
            // dictionaryname
            // 
            this.dictionaryname.DataPropertyName = "dictionaryname";
            this.dictionaryname.HeaderText = "字典类型";
            this.dictionaryname.Name = "dictionaryname";
            this.dictionaryname.ReadOnly = true;
            this.dictionaryname.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDictList, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(751, 441);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // DictList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DictList";
            this.Load += new System.EventHandler(this.UserList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsmiAddRow;
        private System.Windows.Forms.ToolStripButton tsmiDeleteRow;
        private System.Windows.Forms.ToolStripButton tsmiCancel;
        private System.Windows.Forms.DataGridView dgvDictList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripButton tsmiEdit;
        private System.Windows.Forms.ToolStripButton tsmiRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dictionaryid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dictionaryvalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dictionaryname;
    }
}
namespace UfidaPMS.Forms.Contract
{
    partial class SearchContract
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.tbContractNo = new System.Windows.Forms.TextBox();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.cbStartEnable = new System.Windows.Forms.CheckBox();
            this.cbEndleEnable = new System.Windows.Forms.CheckBox();
            this.tbDepartMent = new System.Windows.Forms.ComboBox();
            this.tbCustManager = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.dtpStart, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpEnd, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbContractNo, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbCustName, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbStartEnable, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbEndleEnable, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbDepartMent, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbCustManager, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(421, 206);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "最小日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "最大日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "主合同号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "客户名称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "部门：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "客户经理：";
            // 
            // dtpStart
            // 
            this.dtpStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpStart.Location = new System.Drawing.Point(163, 23);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(204, 26);
            this.dtpStart.TabIndex = 6;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpEnd.Location = new System.Drawing.Point(163, 53);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(204, 26);
            this.dtpEnd.TabIndex = 7;
            // 
            // tbContractNo
            // 
            this.tbContractNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContractNo.Location = new System.Drawing.Point(163, 83);
            this.tbContractNo.Name = "tbContractNo";
            this.tbContractNo.Size = new System.Drawing.Size(204, 26);
            this.tbContractNo.TabIndex = 8;
            // 
            // tbCustName
            // 
            this.tbCustName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCustName.Location = new System.Drawing.Point(163, 113);
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(204, 26);
            this.tbCustName.TabIndex = 9;
            // 
            // cbStartEnable
            // 
            this.cbStartEnable.AutoSize = true;
            this.cbStartEnable.Location = new System.Drawing.Point(373, 23);
            this.cbStartEnable.Name = "cbStartEnable";
            this.cbStartEnable.Size = new System.Drawing.Size(15, 14);
            this.cbStartEnable.TabIndex = 12;
            this.cbStartEnable.UseVisualStyleBackColor = true;
            // 
            // cbEndleEnable
            // 
            this.cbEndleEnable.AutoSize = true;
            this.cbEndleEnable.Location = new System.Drawing.Point(373, 53);
            this.cbEndleEnable.Name = "cbEndleEnable";
            this.cbEndleEnable.Size = new System.Drawing.Size(15, 14);
            this.cbEndleEnable.TabIndex = 13;
            this.cbEndleEnable.UseVisualStyleBackColor = true;
            // 
            // tbDepartMent
            // 
            this.tbDepartMent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDepartMent.FormattingEnabled = true;
            this.tbDepartMent.Location = new System.Drawing.Point(163, 143);
            this.tbDepartMent.Name = "tbDepartMent";
            this.tbDepartMent.Size = new System.Drawing.Size(204, 28);
            this.tbDepartMent.TabIndex = 14;
            // 
            // tbCustManager
            // 
            this.tbCustManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCustManager.FormattingEnabled = true;
            this.tbCustManager.Location = new System.Drawing.Point(163, 173);
            this.tbCustManager.Name = "tbCustManager";
            this.tbCustManager.Size = new System.Drawing.Size(204, 28);
            this.tbCustManager.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(112, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "查询(&S)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(218, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "取消(&C)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchContract
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 253);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchContract";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "合同查询";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.TextBox tbContractNo;
        private System.Windows.Forms.TextBox tbCustName;
        private System.Windows.Forms.CheckBox cbStartEnable;
        private System.Windows.Forms.CheckBox cbEndleEnable;
        private System.Windows.Forms.ComboBox tbDepartMent;
        private System.Windows.Forms.ComboBox tbCustManager;
    }
}
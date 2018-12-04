namespace UfidaPMS.Forms.Project
{
    partial class SearchProjectStatue
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
            this.lbYear = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.tbSubProject = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbMonth = new System.Windows.Forms.TextBox();
            this.tbWeek = new System.Windows.Forms.TextBox();
            this.cbStartEnable = new System.Windows.Forms.CheckBox();
            this.cbEndleEnable = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOtherWords = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.lbYear, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.dtpStart, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpEnd, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbSubProject, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbYear, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbMonth, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbWeek, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbStartEnable, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbEndleEnable, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbOtherWords, 2, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(421, 227);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "最小日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "最大日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "子项目：";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(23, 100);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(37, 20);
            this.lbYear.TabIndex = 3;
            this.lbYear.Text = "年：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "月：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "周：";
            // 
            // dtpStart
            // 
            this.dtpStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpStart.Location = new System.Drawing.Point(163, 13);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(204, 26);
            this.dtpStart.TabIndex = 6;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpEnd.Location = new System.Drawing.Point(163, 43);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(204, 26);
            this.dtpEnd.TabIndex = 7;
            // 
            // tbSubProject
            // 
            this.tbSubProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSubProject.Location = new System.Drawing.Point(163, 73);
            this.tbSubProject.Name = "tbSubProject";
            this.tbSubProject.Size = new System.Drawing.Size(204, 26);
            this.tbSubProject.TabIndex = 8;
            // 
            // tbYear
            // 
            this.tbYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbYear.Location = new System.Drawing.Point(163, 103);
            this.tbYear.MaxLength = 4;
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(204, 26);
            this.tbYear.TabIndex = 9;
            this.tbYear.TextChanged += new System.EventHandler(this.tbYear_TextChanged);
            // 
            // tbMonth
            // 
            this.tbMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMonth.Location = new System.Drawing.Point(163, 133);
            this.tbMonth.MaxLength = 2;
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(204, 26);
            this.tbMonth.TabIndex = 10;
            this.tbMonth.TextChanged += new System.EventHandler(this.tbMonth_TextChanged);
            // 
            // tbWeek
            // 
            this.tbWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWeek.Location = new System.Drawing.Point(163, 163);
            this.tbWeek.MaxLength = 1;
            this.tbWeek.Name = "tbWeek";
            this.tbWeek.Size = new System.Drawing.Size(204, 26);
            this.tbWeek.TabIndex = 11;
            this.tbWeek.TextChanged += new System.EventHandler(this.tbWeek_TextChanged);
            // 
            // cbStartEnable
            // 
            this.cbStartEnable.AutoSize = true;
            this.cbStartEnable.Location = new System.Drawing.Point(373, 13);
            this.cbStartEnable.Name = "cbStartEnable";
            this.cbStartEnable.Size = new System.Drawing.Size(15, 14);
            this.cbStartEnable.TabIndex = 12;
            this.cbStartEnable.UseVisualStyleBackColor = true;
            // 
            // cbEndleEnable
            // 
            this.cbEndleEnable.AutoSize = true;
            this.cbEndleEnable.Location = new System.Drawing.Point(373, 43);
            this.cbEndleEnable.Name = "cbEndleEnable";
            this.cbEndleEnable.Size = new System.Drawing.Size(15, 14);
            this.cbEndleEnable.TabIndex = 13;
            this.cbEndleEnable.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "其他关键词：";
            // 
            // tbOtherWords
            // 
            this.tbOtherWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOtherWords.Location = new System.Drawing.Point(163, 193);
            this.tbOtherWords.Name = "tbOtherWords";
            this.tbOtherWords.Size = new System.Drawing.Size(204, 26);
            this.tbOtherWords.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(120, 230);
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
            this.button2.Location = new System.Drawing.Point(220, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "取消(&C)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchProjectStatue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 267);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchProjectStatue";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "项目状态查询";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.TextBox tbSubProject;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbMonth;
        private System.Windows.Forms.TextBox tbWeek;
        private System.Windows.Forms.CheckBox cbStartEnable;
        private System.Windows.Forms.CheckBox cbEndleEnable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOtherWords;
    }
}
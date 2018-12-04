using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Project
{
    public partial class SearchProjectStatue : Form
    {
        public string Where
        {
            get;
            set;
        }
        public SearchProjectStatue()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbEndleEnable.Checked && cbStartEnable.Checked)
            {
                if ((dtpEnd.Value.Date - dtpStart.Value.Date).TotalDays < 0)
                {
                    MessageBox.Show("最大日期必须大于或者等于最小日期！");
                }
            }
            Where += " 1=1 ";
            if (cbStartEnable.Checked)
            {
                Where += string.Format(" and createdate>='{0}'", dtpStart.Value.ToShortDateString());
            }
            if (cbEndleEnable.Checked)
            {
                Where += string.Format(" and createdate<='{0}'", dtpEnd.Value.ToShortDateString());
            }
            if (tbSubProject.Text.Trim() != "")
            {
                Where += string.Format(" and subprojectname like '%{0}%'", tbSubProject.Text);
            }
            if (tbYear.Text.Trim() != "")
            {
                Where += string.Format(" and year = {0} ", tbYear.Text);
            }
            if (tbMonth.Text.Trim() != "")
            {
                Where += string.Format(" and moth = {0} ", tbMonth.Text);
            }
            if (tbWeek.Text.Trim() != "")
            {
                Where += string.Format(" and week = {0} ", tbWeek.Text);
            }
            if (tbOtherWords.Text.Trim() != "")
            {
                Where += string.Format(" and  (problem  like '%{0}%' or measure like '%{0}%' or p.remarks like '%{0}%')", tbOtherWords.Text);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void tbYear_TextChanged(object sender, EventArgs e)
        {
            if (tbYear.Text.Trim() != "")
            {
                try
                {
                    if (Convert.ToInt32(tbYear.Text) > 2010 || Convert.ToInt32(tbYear.Text) < 2100)
                    {
                        tbYear.Text = "";
                    }
                }
                catch
                {
                    tbYear.Text = "";
                }
            }
            
        }

        private void tbMonth_TextChanged(object sender, EventArgs e)
        {
            if (tbMonth.Text.Trim() != "")
            {
                try
                {
                    if (Convert.ToInt32(tbMonth.Text) > 12)
                    {
                        tbMonth.Text = "";
                    }
                }
                catch
                {
                    tbMonth.Text = "";
                }
            }
        }

        private void tbWeek_TextChanged(object sender, EventArgs e)
        {
            if (tbWeek.Text.Trim() != "")
            {
                try
                {
                    if (Convert.ToInt32(tbWeek.Text) > 5)
                    {
                        tbWeek.Text = "";
                    }
                }
                catch
                {
                    tbWeek.Text = "";
                }
            }
        }
    }
}

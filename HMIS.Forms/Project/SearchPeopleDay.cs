using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Project
{
    public partial class SearchPeopleDay : Form
    {
        public string Where
        {
            get;
            set;
        }
        public SearchPeopleDay()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Where = "1=1";
            if (tbProjectname.Text.Trim() != "")
            {
                Where += string.Format("and projectname like '%{0}%'", tbProjectname.Text);
            }
            if (tbSubProjectName.Text.Trim() != "")
            {
                Where += string.Format("and subProjectName like '%{0}%'", tbSubProjectName.Text);
            }
            if (tbMilestonename.Text.Trim() != "")
            {
                Where += string.Format("and milestonename like '%{0}%'", tbMilestonename.Text);
            }
            if (tbGuwen.Text.Trim() != "")
            {
                Where += string.Format("and guwen like '%{0}%'", tbGuwen.Text);
            }
            if (tbConfirmuser.Text.Trim() != "")
            {
                Where += string.Format("and confirmuser like '%{0}%'", tbConfirmuser.Text);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}

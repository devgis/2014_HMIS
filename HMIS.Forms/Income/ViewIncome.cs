using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Forms.Income
{
    public partial class ViewIncome : Form
    {
        public ViewIncome()
        {
            InitializeComponent();
        }

        private void tsmiCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

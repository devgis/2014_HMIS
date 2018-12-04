using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewGUID
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            StringBuilder sbString = new StringBuilder();
            for(int i=0;i<(int)nuCount.Value;i++)
            {
                sbString.Append(Guid.NewGuid().ToString()+"\r\n");
            }
            textBox1.Text = sbString.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace UfidaPMS.Controls
{
    public class ShowForms
    {
        public static void Show(string FormName, string ID,Form MdiParent)
        {
            switch (FormName)
            {
                case "ContractShow":
                    UfidaPMS.Forms.Contract.ViewContract frmVC = new Forms.Contract.ViewContract(ID);
                    frmVC.MdiParent = MdiParent;
                    frmVC.WindowState = FormWindowState.Maximized;
                    frmVC.Show();
                    break;
                default:
                    break;
            }
        }
    }
}

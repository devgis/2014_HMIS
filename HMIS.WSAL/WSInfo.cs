using System;
using System.Collections.Generic;
using System.Text;
using FYSOFT.HMIS.Common;

namespace FYSOFT.HMIS.WSAL
{
    public class WSInfo
    {
        public static string WsURL = "";
        public static string SPassword = "";
        static WSInfo()
        {
            WsURL = System.Configuration.ConfigurationManager.AppSettings["WSAddress"].ToString();
            SPassword = System.Configuration.ConfigurationManager.AppSettings["WSPassword"].ToString();
            SPassword = DesSecurity.Decrypt(SPassword);
        }
    }
}

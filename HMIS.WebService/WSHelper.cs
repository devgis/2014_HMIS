using System;
using System.Collections.Generic;
using System.Web;
using FYSOFT.HMIS.Common;

namespace FYSOFT.HMIS.WebService
{
    public class WSHelper
    {
        private static string SPassword = "";
        static WSHelper()
        {
            try
            {
                //获取WebService密码
                SPassword = System.Configuration.ConfigurationManager.AppSettings["WSPassword"].ToString();
                SPassword = DesSecurity.Decrypt(SPassword);
            }
            catch
            { }
        }
        public static bool CheckPassword(String PassWord)
        {
            if (PassWord == SPassword)
            {
                return true;
            }
            return false;
        }
    }
}
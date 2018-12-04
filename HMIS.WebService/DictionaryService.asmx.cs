using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Data;

namespace FYSOFT.HMIS.WebService
{
    /// <summary>
    /// DictionaryService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class DictionaryService : System.Web.Services.WebService
    {
        FYSOFT.HMIS.Bll.Dictionary bllDictionary;
        public DictionaryService()
        {
            bllDictionary = new Bll.Dictionary();
        }
        
        /// <summary>
        /// 获取客户名称
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDictCustName(string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllDictionary.GetDictCustName();
        }
        /// <summary>
        /// 获取客户经理
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDictCustManager(string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllDictionary.GetDictCustManager();
        }
        /// <summary>
        /// 获取项目经理
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDictProjectManager(string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllDictionary.GetDictProjectManager();
        }
        /// <summary>
        /// 获取部门
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDictDepartment(string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllDictionary.GetDictDepartment();
        }
        /// <summary>
        /// 获取监管人员
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDictregulator(string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllDictionary.GetDictregulator();
        }
        /// <summary>
        /// 获取行业
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDictTrade(string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllDictionary.GetDictTrade();
        }
        //--------------------------------项目
        /// <summary>
        /// 获取顾问
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDictGuWen(string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllDictionary.GetDictGuWen();
        }
        /// <summary>
        /// 获取所有字典
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAllDict(string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllDictionary.GetAllDict();
        }
        
    }
}

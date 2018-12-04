using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Data;

namespace FYSOFT.HMIS.WebService
{
    /// <summary>
    /// ReportService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class ReportService : System.Web.Services.WebService
    {

        FYSOFT.HMIS.Bll.Report bllReport;
        public ReportService()
        {
            bllReport = new Bll.Report();
        }
        /// <summary>
        /// 里程碑报表数据
        /// </summary>
        /// <param name="WSPassword"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetMileStoneReport(string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllReport.GetMileStoneReport();
        }
        /// <summary>
        /// 人天报表
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetPeopleDayReport(string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllReport.GetPeopleDayReport();
        }
        /// <summary>
        /// 周状态报表
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="week"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetWeekStatueReport(int year, int month, int week, string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllReport.GetWeekStatueReport(year, month, week);
        }
        /// <summary>
        /// 里程碑报表
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetMileStoneReport2(string Where, string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllReport.GetMileStoneReport(Where);
        }
        /// <summary>
        /// 人天报表
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetPeopleDayReport2(string Where, string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllReport.GetPeopleDayReport(Where);
        }
        /// <summary>
        /// 周状态报表
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="week"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetWeekStatueReport2(int year, int month, int week, string Where, string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllReport.GetWeekStatueReport(year, month, week, Where);
        }
        /// <summary>
        /// 周状态报表
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="week"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetStatueReport(int year, int month, int week, string Where, string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllReport.GetStatueReport(year, month, week, Where);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using FYSOFT.HMIS.Common;

namespace FYSOFT.HMIS.WSAL
{
    public class WSReport
    {
        /// <summary>
        /// 里程碑报表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetMileStoneReport()
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "ReportService.asmx";
                    object[] args = new object[1];
                    args[0] = WSInfo.SPassword;
                    object oResult = UfidaPMSService.InvokeWebService(WsFullURL, "GetMileStoneReport", args);
                    return (oResult as DataSet).Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 人天报表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetPeopleDayReport()
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "ReportService.asmx";
                    object[] args = new object[1];
                    args[0] = WSInfo.SPassword;
                    object oResult = UfidaPMSService.InvokeWebService(WsFullURL, "GetPeopleDayReport", args);
                    return (oResult as DataSet).Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 周状态报表
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="week"></param>
        /// <returns></returns>
        public static DataSet GetWeekStatueReport(int year, int month, int week)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "ReportService.asmx";
                    object[] args = new object[4];
                    args[0] = year;
                    args[1] = month;
                    args[2] = week;
                    args[3] = WSInfo.SPassword;
                    object oResult = UfidaPMSService.InvokeWebService(WsFullURL, "GetWeekStatueReport", args);
                    return oResult as DataSet;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 里程碑报表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetMileStoneReport(string Where)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "ReportService.asmx";
                    object[] args = new object[2];
                    args[0] = Where;
                    args[1] = WSInfo.SPassword;
                    object oResult = UfidaPMSService.InvokeWebService(WsFullURL, "GetMileStoneReport2", args);
                    return (oResult as DataSet).Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 人天报表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetPeopleDayReport(string Where)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "ReportService.asmx";
                    object[] args = new object[2];
                    args[0] = Where;
                    args[1] = WSInfo.SPassword;
                    object oResult = UfidaPMSService.InvokeWebService(WsFullURL, "GetPeopleDayReport2", args);
                    return (oResult as DataSet).Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 周状态报表
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="week"></param>
        /// <returns></returns>
        public static DataSet GetWeekStatueReport(int year, int month, int week, string Where)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "ReportService.asmx";
                    object[] args = new object[5];
                    args[0] = year;
                    args[1] = month;
                    args[2] = week;
                    args[3] = Where;
                    args[4] = WSInfo.SPassword;
                    object oResult = UfidaPMSService.InvokeWebService(WsFullURL, "GetWeekStatueReport2", args);
                    return oResult as DataSet;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 周状态报表
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="week"></param>
        /// <returns></returns>
        public static DataSet GetStatueReport(int year, int month, int week, string Where)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "ReportService.asmx";
                    object[] args = new object[5];
                    args[0] = year;
                    args[1] = month;
                    args[2] = week;
                    args[3] = Where;
                    args[4] = WSInfo.SPassword;
                    object oResult = UfidaPMSService.InvokeWebService(WsFullURL, "GetStatueReport", args);
                    return oResult as DataSet;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

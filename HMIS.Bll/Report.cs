using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FYSOFT.HMIS.Bll
{
    public class Report
    {
        FYSOFT.HMIS.DAL.Report dal;
        public Report()
        {
            dal = new DAL.Report();
        }
        /// <summary>
        /// 里程碑报表
        /// </summary>
        /// <returns></returns>
        public DataSet GetMileStoneReport()
        {
            return dal.GetMileStoneReport();
        }
        /// <summary>
        /// 人天报表
        /// </summary>
        /// <returns></returns>
        public DataSet GetPeopleDayReport()
        {
            return dal.GetPeopleDayReport();
        }
        /// <summary>
        /// 周状态报表
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="week"></param>
        /// <returns></returns>
        public DataSet GetWeekStatueReport(int year, int month, int week)
        {
            return dal.GetWeekStatueReport(year, month, week);
        }
        /// <summary>
        /// 里程碑报表
        /// </summary>
        /// <returns></returns>
        public DataSet GetMileStoneReport(string Where)
        {
            return dal.GetMileStoneReport(Where);
        }
        /// <summary>
        /// 人天报表
        /// </summary>
        /// <returns></returns>
        public DataSet GetPeopleDayReport(string Where)
        {
            return dal.GetPeopleDayReport(Where);
        }
        /// <summary>
        /// 周状态报表
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="week"></param>
        /// <returns></returns>
        public DataSet GetWeekStatueReport(int year, int month, int week, string Where)
        {
            return dal.GetWeekStatueReport(year, month, week, Where);
        }

        /// <summary>
        /// 周状态报表
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="week"></param>
        /// <returns></returns>
        public DataSet GetStatueReport(int year, int month, int week, string Where)
        {
            return dal.GetStatueReport(year, month, week, Where);
        }
    }
}

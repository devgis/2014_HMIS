using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using FYSOFT.HMIS.Common;

namespace FYSOFT.HMIS.DAL
{
    public class Report
    {
        /// <summary>
        /// 里程碑报表
        /// </summary>
        /// <returns></returns>
        public DataSet GetMileStoneReport()
        {
            string srrSQL = @"select c.contractno,sp.subprojectname,sp.subprojectmanager,sp.subprojecttype,sm.milestonename
,CONVERT(NVARCHAR,sm.startdate,23) as startdate, CONVERT(NVARCHAR,sm.planfinishdate,23) as planfinishdate,CONVERT(NVARCHAR,sm.finishdate,23) as finishdate from t_Contract c
left join t_SubContract sc on c.contractid=sc.contractid
left join t_Project p on p.subcontractid=sc.subcontractid
left join t_SubProject sp on sp.projectid=p.projectid
left join t_Milestone m on sp.subprojectid=m.subprojectid
left join t_MilestoneSub sm on sm.milestoneid=m.milestoneid
where sp.subprojectid is not null ";
            return DbHelperOLE.Query(srrSQL);
        }
        /// <summary>
        /// 人天报表
        /// </summary>
        /// <returns></returns>
        public DataSet GetPeopleDayReport()
        {
            string srrSQL = @"select c.contractno,sp.subprojectname,sp.subprojectmanager,sp.subprojecttype,sp.implementationamount,p.implementdepartment,sp.subprojectmanager,sp.planpeopledays,(SELECT SUM(actualdays) FROM t_Actualdays where subprojectid=sp.subprojectid) as actualday from t_Contract c
left join t_SubContract sc on c.contractid=sc.contractid
left join t_Project p on p.subcontractid=sc.subcontractid
left join t_SubProject sp on sp.projectid=p.projectid 
where sp.subprojectid is not null";
            return DbHelperOLE.Query(srrSQL);
        }
        /// <summary>
        /// 周状态报表
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="week"></param>
        /// <returns></returns>
        public DataSet GetWeekStatueReport(int year,int month,int week)
        {
            DataSet ds = new DataSet();
            //项目信息
            string strSql = string.Format(@"select c.contractno,c.custmanager,p.projectname,c.department,sp.subprojecttype,sp.implementationamount
,p.implementdepartment,p.projectmanager,sp.earlypercentage,progress,'' as jieduandate,sp.totalschedule
,(select sc.contractamount*(sp.totalschedule- sp.earlypercentage)/100 ) as totalreceive,sp.subprojectid
 from t_Contract c
left join t_SubContract sc on c.contractid=sc.contractid
left join t_Project p on p.subcontractid=sc.subcontractid
left join t_SubProject sp on sp.projectid=p.projectid
where p.projectid is not null or sp.subprojectid is not null", year);
            DataTable dt = DbHelperOLE.Query(strSql).Tables[0].Copy();
            dt.TableName="maintable";
            ds.Tables.Add(dt);

            //状态信息
            strSql = string.Format(@"select p.subprojectid,pp.month,pp.weektime,pp.week,pp.milestone,pp.percentage
,(SELECT ISNULL(percentage,0)*(select implementationamount from t_SubProject where subprojectid=(SELECT subprojectid FROM t_ProjectWeekStatus where statusid=pp.statusid))/100 ) as smoney 
from t_ProjectWeekStatus p 
left join t_ProjectPlan pp on p.statusid=pp.statusid
where p.year={0} and p.moth={1} and p.week={2}
order by pp.month,pp.week", year,month,week);
            DataTable dt2 = DbHelperOLE.Query(strSql).Tables[0].Copy();
            dt2.TableName = "subtable";
            ds.Tables.Add(dt2);
            return ds;
        }
        /// <summary>
        /// 里程碑报表
        /// </summary>
        /// <returns></returns>
        public DataSet GetMileStoneReport(string Where)
        {
            string srrSQL = @"select c.contractno,sc.subcontractno,sp.subprojectname,sp.subprojectmanager,sp.subprojecttype,sm.milestonename
,CONVERT(NVARCHAR,sm.startdate,23) as startdate, CONVERT(NVARCHAR,sm.planfinishdate,23) as planfinishdate,CONVERT(NVARCHAR,sm.finishdate,23) as finishdate from t_Contract c
left join t_SubContract sc on c.contractid=sc.contractid
left join t_Project p on p.subcontractid=sc.subcontractid
left join t_SubProject sp on sp.projectid=p.projectid
left join t_Milestone m on sp.subprojectid=m.subprojectid
left join t_MilestoneSub sm on sm.milestoneid=m.milestoneid
where sp.subprojectid is not null ";
            if (Where.Trim() != "" && Where.Trim() != "*")
            {
                srrSQL += " and " + Where;
            }
            return DbHelperOLE.Query(srrSQL);
        }
        /// <summary>
        /// 人天报表
        /// </summary>
        /// <returns></returns>
        public DataSet GetPeopleDayReport(string Where)
        {
            string srrSQL = @"select c.contractno,p.projectname,sc.subcontractno,sp.subprojectcode,sp.subprojectname,sp.subprojectmanager,sp.subprojecttype,sp.implementationamount,p.implementdepartment,sp.subprojectmanager,sp.planpeopledays,(SELECT SUM(actualdays) FROM t_Actualdays where subprojectid=sp.subprojectid) as actualday from t_Contract c
left join t_SubContract sc on c.contractid=sc.contractid
left join t_Project p on p.subcontractid=sc.subcontractid
left join t_SubProject sp on sp.projectid=p.projectid 
where sp.subprojectid is not null";
            if (Where.Trim() != "" && Where.Trim() != "*")
            {
                srrSQL += " and " + Where;
            }
            return DbHelperOLE.Query(srrSQL);
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
            DataSet ds = new DataSet();
            //项目信息
            string strSql = string.Format(@"select c.contractid,sc.subcontractno,sc.subcontractno,sp.subprojectcode,c.contractno,c.custmanager,sp.subprojectname,c.department,sp.subprojecttype,sp.implementationamount
,p.implementdepartment,p.projectmanager,sp.earlypercentage,progress,'' as jieduandate,sp.totalschedule
,(select sc.contractamount*(sp.totalschedule- sp.earlypercentage)/100 ) as totalreceive,sp.subprojectid
 from t_Contract c
left join t_SubContract sc on c.contractid=sc.contractid
left join t_Project p on p.subcontractid=sc.subcontractid
left join t_SubProject sp on sp.projectid=p.projectid
left join t_ProjectWeekStatus p2 on sp.subprojectid=p2.subprojectid
where (p.projectid is not null or sp.subprojectid is not null)", year);
            if (Where.Trim() != "" && Where.Trim() != "*")
            {
                strSql += " and " + Where;
            }
            DataTable dt = DbHelperOLE.Query(strSql).Tables[0].Copy();
            dt.TableName = "maintable";
            ds.Tables.Add(dt);

            //状态信息
            strSql = string.Format(@"select p.subprojectid,pp.month,pp.weektime,pp.week,pp.milestone,pp.percentage
,(SELECT ISNULL(percentage,0)*(select implementationamount from t_SubProject where subprojectid=(SELECT subprojectid FROM t_ProjectWeekStatus where statusid=pp.statusid))/100 ) as smoney 
from t_ProjectWeekStatus p 
left join t_ProjectPlan pp on p.statusid=pp.statusid
where p.year={0} and p.moth={1} and p.week={2}
order by pp.month,pp.week", year, month, week);
            DataTable dt2 = DbHelperOLE.Query(strSql).Tables[0].Copy();
            dt2.TableName = "subtable";
            ds.Tables.Add(dt2);
            return ds;
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
            DataSet ds = new DataSet();
            //项目信息
            string strSql = string.Format(@"select c.contractid,sc.subcontractno,sp.subprojectcode,c.custmanager,sp.subprojectname,c.department,sp.subprojecttype,sp.implementationamount
,p.implementdepartment,p.projectmanager,sp.earlypercentage,progress,'' as jieduandate,sp.totalschedule
,(select sc.contractamount*(sp.totalschedule- sp.earlypercentage)/100 ) as totalreceive,sp.subprojectid,p2.state,p2.problem,p2.measure
 from t_Contract c
left join t_SubContract sc on c.contractid=sc.contractid
left join t_Project p on p.subcontractid=sc.subcontractid
left join t_SubProject sp on sp.projectid=p.projectid
left join t_ProjectWeekStatus p2 on p2.subprojectid=sp.subprojectid and  p2.year={0} and p2.moth={1} and p2.week={2}
where (p.projectid is not null or sp.subprojectid is not null) ", year,month,week);
            if (Where.Trim() != "" && Where.Trim() != "*")
            {
                strSql += " and " + Where;
            }
            strSql += " order by sc.subcontractno,sp.subprojectcode";
            DataTable dt = DbHelperOLE.Query(strSql).Tables[0].Copy();
            dt.TableName = "maintable";
            ds.Tables.Add(dt);
            if (dt == null || dt.Rows.Count <= 0)
            {
                return null;
            }

            //状态信息
            strSql = string.Format(@"select p.subprojectid,pp.month,pp.weektime,pp.week,pp.milestone,p.state
,p.measure,p.problem,(SELECT ISNULL(percentage,0)*(select implementationamount from t_SubProject where subprojectid=(SELECT subprojectid FROM t_ProjectWeekStatus where statusid=pp.statusid))/100 ) as smoney 
from t_ProjectWeekStatus p 
left join t_ProjectPlan pp on p.statusid=pp.statusid
where p.year={0} and p.moth={1} and p.week={2}
order by pp.month,pp.week", year, month, week);
            DataTable dt2 = DbHelperOLE.Query(strSql).Tables[0].Copy();
            dt2.TableName = "subtable";
            ds.Tables.Add(dt2);
            return ds;
        }
        
    }
}

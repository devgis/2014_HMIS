using System;
using System.Collections.Generic;
using System.Text;

namespace FYSoft.HMIS.DICT
{
    public class UserSQLS
    {
        /// <summary>
        /// 根据实体生成插入语句
        /// </summary>
        /// <param name="UObject"></param>
        /// <returns></returns>
        public static String InsertString(FYSOFT.HMIS.Models.User UObject)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("INSERT INTO T_USER(");
            strSql.Append("USERID,USERNAME,USERPASSWORD)");
            strSql.Append(" VALUES (");
            strSql.AppendFormat("'{0}','{1}','{2}')",Guid.NewGuid().ToString(),UObject.UserName,UObject.UserPassword);
            return strSql.ToString();
        }

        /// <summary>
        /// 根据实体生成更新语句
        /// </summary>
        /// <param name="UObject"></param>
        /// <returns></returns>
        public static String UpdateString(FYSOFT.HMIS.Models.User UObject)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE T_USER SET ");
            strSql.AppendFormat("USERNAME='{0}',",UObject.UserName);
            strSql.AppendFormat("USERPASSWORD='{0}'", UObject.UserPassword);
            strSql.AppendFormat(" WHERE USERID='{0}'", UObject.UserID);
            return strSql.ToString();
        }

        /// <summary>
        /// 根据用户名密码更新
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserPasswword"></param>
        /// <returns></returns>
        public static String UpdateByUserNamePassWord(String UserName, String UserPasswword)
        {
            return string.Format("UPDATE T_USER SET USERPASSWORD='{1}' WHERE USERNAME='{0}'"
                , UserName, UserPasswword);
        }

        /// <summary>
        /// 根据用户ID删除
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public static String DeleteString(String UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM T_USER ");
            strSql.AppendFormat(" WHERE USERID='{0}'", UserID);
            return strSql.ToString();
        }

        /// <summary>
        /// 根据用户ID查询一条记录
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public static String Select1String(String UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TOP 1 USERID,USERNAME,USERPASSWORD FROM T_USER ");
            strSql.AppendFormat(" WHERE USERID='{0}'", UserID);
            return strSql.ToString();
        }

        /// <summary>
        /// 根据用户名查询用户数量
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public static String SelectCountByUserNameString(String UserName)
        {
            return string.Format("SELECT COUNT(*) FROM T_USER WHERE USERNAME='{0}'", UserName);
        }

        /// <summary>
        /// 根据条件查询多条
        /// </summary>
        /// <param name="Where"></param>
        /// <returns></returns>
        public static String SelectMuiltString(String Where)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT USERID,USERNAME,USERPASSWORD ");
            strSql.Append(" FROM T_USER ");
            if (Where.Trim() != "" && Where.Trim()!="*")
            {
                strSql.Append(" WHERE " + Where);
            }
            return strSql.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FYSoft.HMIS.DICT
{
    public class DictionarySQLS
    {
        /// <summary>
        /// 根据实体生成插入语句
        /// </summary>
        /// <param name="UObject"></param>
        /// <returns></returns>
        public static String InsertString(FYSOFT.HMIS.Models.Dictionary UObject)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("INSERT INTO T_DICTIONARY(");
            strSql.Append("DICTIONARYID,DICTIONARYVALUE,DICTIONARYNAME)");
            strSql.Append(" VALUES (");
            strSql.AppendFormat("'{0}','{1}','{2}')", Guid.NewGuid().ToString(), UObject.DictionaryValue, UObject.DictionaryName);
            return strSql.ToString();
        }

        /// <summary>
        /// 根据实体生成更新语句
        /// </summary>
        /// <param name="UObject"></param>
        /// <returns></returns>
        public static String UpdateString(FYSOFT.HMIS.Models.Dictionary UObject)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE T_DICTIONARY SET ");
            strSql.AppendFormat("DICTIONARYVALUE='{0}',", UObject.DictionaryValue);
            strSql.AppendFormat("DICTIONARYNAME='{0}'", UObject.DictionaryName);
            strSql.AppendFormat(" WHERE DICTIONARYID='{0}'", UObject.DictionaryID);
            return strSql.ToString();
        }

        /// <summary>
        /// 根据用户名密码更新
        /// </summary>
        /// <param name="DICTIONARYVALUE"></param>
        /// <param name="UserPasswword"></param>
        /// <returns></returns>
        public static String UpdateByDICTIONARYVALUEPassWord(String DICTIONARYVALUE, String UserPasswword)
        {
            return string.Format("UPDATE T_DICTIONARY SET DICTIONARYNAME='{1}' WHERE DICTIONARYVALUE='{0}'"
                , DICTIONARYVALUE, UserPasswword);
        }

        /// <summary>
        /// 根据用户ID删除
        /// </summary>
        /// <param name="DICTIONARYID"></param>
        /// <returns></returns>
        public static String DeleteString(String DICTIONARYID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM T_DICTIONARY ");
            strSql.AppendFormat(" WHERE DICTIONARYID='{0}'", DICTIONARYID);
            return strSql.ToString();
        }

        /// <summary>
        /// 根据用户ID查询一条记录
        /// </summary>
        /// <param name="DICTIONARYID"></param>
        /// <returns></returns>
        public static String Select1String(String DICTIONARYID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TOP 1 DICTIONARYID,DICTIONARYVALUE,DICTIONARYNAME FROM T_DICTIONARY ");
            strSql.AppendFormat(" WHERE DICTIONARYID='{0}'", DICTIONARYID);
            return strSql.ToString();
        }

        /// <summary>
        /// 根据用户名查询用户数量
        /// </summary>
        /// <param name="DICTIONARYVALUE"></param>
        /// <returns></returns>
        public static String SelectCountByDICTIONARYVALUEString(String DICTIONARYVALUE)
        {
            return string.Format("SELECT COUNT(*) FROM T_DICTIONARY WHERE DICTIONARYVALUE='{0}'", DICTIONARYVALUE);
        }

        /// <summary>
        /// 根据条件查询多条
        /// </summary>
        /// <param name="Where"></param>
        /// <returns></returns>
        public static String SelectMuiltString(String Where)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT DICTIONARYID,DICTIONARYVALUE,DICTIONARYNAME ");
            strSql.Append(" FROM T_DICTIONARY ");
            if (Where.Trim() != "" && Where.Trim() != "*")
            {
                strSql.Append(" WHERE " + Where);
            }
            return strSql.ToString();
        }

        //根据类型获取字典列表
        public static String GetDictTableByTypeName(String DictionaryName)
        {
            return string.Format("SELECT DICTIONARYID,DICTIONARYVALUE,DICTIONARYNAME FROM T_DICTIONARY WHERE DICTIONARYNAME='{0}'", DictionaryName);
        }
    }
}

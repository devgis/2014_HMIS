using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FYSOFT.HMIS.Common;
using FYSoft.HMIS.DICT;//Please add references
namespace FYSOFT.HMIS.DAL
{
	/// <summary>
	/// 数据访问类:Dictionary
	/// </summary>
	public partial class Dictionary
	{
		public Dictionary()
		{}
		#region  Method

        /// <summary>
        /// 根据类别获取字典列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetDictTableByTypeName(String DictionaryName)
        {
            return DbHelperOLE.Query(DictionarySQLS.GetDictTableByTypeName(DictionaryName));
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(FYSOFT.HMIS.Models.Dictionary model)
        {
            object obj = DbHelperOLE.ExecuteSql(DictionarySQLS.InsertString(model));
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
		#endregion  Method
	}
}


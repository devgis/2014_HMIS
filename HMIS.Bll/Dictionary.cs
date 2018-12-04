using System;
using System.Data;
using System.Collections.Generic;

using FYSOFT.HMIS.Models;
namespace FYSOFT.HMIS.Bll
{
	/// <summary>
	/// Dictionary
	/// </summary>
	public partial class Dictionary
	{
		private readonly FYSOFT.HMIS.DAL.Dictionary dal=new FYSOFT.HMIS.DAL.Dictionary();
		public Dictionary()
		{}
		#region  Method
        /// <summary>
        /// 根据类别获取字典列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetDictTableByTypeName(String DictionaryName)
        {
            return dal.GetDictTableByTypeName(DictionaryName);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(FYSOFT.HMIS.Models.Dictionary model)
        {
            return dal.Add(model);
        }
		#endregion  Method
	}
}


using System;
namespace FYSOFT.HMIS.Models
{
	/// <summary>
	/// Dictionary:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Dictionary
	{
		public Dictionary()
		{}
		#region Model
		/// <summary>
		/// 字典ID
		/// </summary>
        public String DictionaryID
        {
            set;
            get;
        }
		/// <summary>
		/// 字典值
		/// </summary>
		public string DictionaryValue
		{
            set;
            get;
		}
		/// <summary>
		/// 字典类型
		/// </summary>
        public string DictionaryName
		{
            set;
            get;
		}
		#endregion Model

	}
}


using System;
namespace FYSOFT.HMIS.Models
{
	/// <summary>
	/// User:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class User
	{
		public User()
		{}
		#region Model
		private String _userid;
        private String _username;
        private String _userpassword;
		/// <summary>
		/// 用户编码
		/// </summary>
        public String UserID
		{
            set { _userid = value; }
            get { return _userid; }
		}
		/// <summary>
		/// 用户名
		/// </summary>
        public String UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 用户密码
		/// </summary>
        public String UserPassword
		{
			set{ _userpassword=value;}
			get{return _userpassword;}
		}
		#endregion Model

	}
}


using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FYSOFT.HMIS.Common;
using FYSoft.HMIS.DICT;//Please add references
namespace FYSOFT.HMIS.DAL
{
	/// <summary>
	/// 数据访问类:User
	/// </summary>
	public partial class User
	{
		public User()
		{}
		#region  Method

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(FYSOFT.HMIS.Models.User model)
		{
            object obj = DbHelperOLE.ExecuteSql(UserSQLS.InsertString(model));
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(FYSOFT.HMIS.Models.User model)
		{
            int rows = DbHelperOLE.ExecuteSql(UserSQLS.UpdateString(model));
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string UserID)
		{
            int rows = DbHelperOLE.ExecuteSql(UserSQLS.DeleteString(UserID));
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public FYSOFT.HMIS.Models.User GetModel(String UserID)
		{
			FYSOFT.HMIS.Models.User model=new FYSOFT.HMIS.Models.User();
            DataSet ds = DbHelperOLE.Query(UserSQLS.Select1String(UserID));
			if(ds.Tables[0].Rows.Count>0)
			{
                if (ds.Tables[0].Rows[0]["userid"] != null && ds.Tables[0].Rows[0]["userid"].ToString() != "")
				{
                    model.UserID = ds.Tables[0].Rows[0]["userid"].ToString();
				}
				if(ds.Tables[0].Rows[0]["username"]!=null && ds.Tables[0].Rows[0]["username"].ToString()!="")
				{
					model.UserName=ds.Tables[0].Rows[0]["username"].ToString();
				}
				if(ds.Tables[0].Rows[0]["userpassword"]!=null && ds.Tables[0].Rows[0]["userpassword"].ToString()!="")
				{
					model.UserPassword=ds.Tables[0].Rows[0]["userpassword"].ToString();
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
            return DbHelperOLE.Query(UserSQLS.SelectMuiltString(strWhere));
		}

        /// <summary>
        /// 用户名
        /// </summary>
        public bool CheckUserName(string UserName)
        {
            try
            {
                int i = Convert.ToInt32(DbHelperOLE.Query(UserSQLS.SelectCountByUserNameString(UserName)).Tables[0].Rows[0][0]);
                if (i > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 修改用户密码
        /// </summary>
        public bool UpdateUserPassword(string UserName,string UserPasswword)
        {
            string Sql = string.Format(UserSQLS.UpdateByUserNamePassWord(UserName, UserPasswword));
            try
            {
                if (DbHelperOLE.ExecuteSql(Sql) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
		
		#endregion  Method
	}
}


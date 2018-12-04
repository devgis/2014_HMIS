using System;
using System.Data;
using System.Collections.Generic;
using FYSOFT.HMIS.Models;
namespace FYSOFT.HMIS.Bll
{
	/// <summary>
	/// User
	/// </summary>
	public partial class User
	{
		private readonly FYSOFT.HMIS.DAL.User dal=new FYSOFT.HMIS.DAL.User();
		public User()
		{}
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(FYSOFT.HMIS.Models.User model)
        {
            return dal.Add(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(FYSOFT.HMIS.Models.User model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(String UserID)
        {

            return dal.Delete(UserID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FYSOFT.HMIS.Models.User GetModel(String UserID)
        {
            return dal.GetModel(UserID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 检查用名是否存在
        /// </summary>
        public bool CheckUserName(string UserName)
        {
            return dal.CheckUserName(UserName);
        }
        /// <summary>
        /// 修改用户密码
        /// </summary>
        public bool UpdateUserPassword(string UserName, string UserPasswword)
        {
            return dal.UpdateUserPassword(UserName, UserPasswword);
        }

        /// <summary>
        /// 萧炎用户密码
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserPassword"></param>
        /// <param name="WSPassword"></param>
        /// <returns></returns>
        public int CheckPassWord(string UserName, string UserPassword)
        {
            //-1 用户不存在 1用户名密码正确 0 密码不正确
            DataSet ds = GetList(string.Format("USERNAME='{0}'", UserName));
            if (ds == null || ds.Tables.Count<= 0||ds.Tables[0].Rows.Count<=0)
            {
                return -1;
            }
            if (ds.Tables[0].Rows[0]["USERPASSWORD"].ToString() == UserPassword)
            {
                return 1;
            }
            else
            {
                return -0;
            }
        }
	}
}


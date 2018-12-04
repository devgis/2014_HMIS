using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Data;

namespace FYSOFT.HMIS.WebService
{
    /// <summary>
    /// UserService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class UserService : System.Web.Services.WebService
    {
        FYSOFT.HMIS.Bll.User bllUser;
        public UserService()
        {
            bllUser = new Bll.User();
        }
        #region  Method

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return bllUser.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int userid)
        {
            return bllUser.Exists(userid);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        [WebMethod]
        public int Add(string strModel, string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            FYSOFT.HMIS.Models.User model=Common.CommonHelper.DeSerialize(typeof(FYSOFT.HMIS.Models.User),strModel) as FYSOFT.HMIS.Models.User;
            return bllUser.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        [WebMethod]
        public bool Update(string strModel, string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            FYSOFT.HMIS.Models.User model = Common.CommonHelper.DeSerialize(typeof(FYSOFT.HMIS.Models.User), strModel) as FYSOFT.HMIS.Models.User;
            return bllUser.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        [WebMethod]
        public bool Delete(int userid, string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllUser.Delete(userid);
        }
        

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        [WebMethod]
        public string GetModel(int userid, string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return Common.CommonHelper.Serialize(bllUser.GetModel(userid));
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        [WebMethod]
        public DataSet GetList(string strWhere, string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllUser.GetList(strWhere);
        }
        
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FYSOFT.HMIS.Models.User> GetModelList(string strWhere)
        {
            DataSet ds = bllUser.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FYSOFT.HMIS.Models.User> DataTableToList(DataTable dt)
        {
            List<FYSOFT.HMIS.Models.User> modelList = new List<FYSOFT.HMIS.Models.User>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                FYSOFT.HMIS.Models.User model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new FYSOFT.HMIS.Models.User();
                    if (dt.Rows[n]["userid"] != null && dt.Rows[n]["userid"].ToString() != "")
                    {
                        model.userid = int.Parse(dt.Rows[n]["userid"].ToString());
                    }
                    if (dt.Rows[n]["username"] != null && dt.Rows[n]["username"].ToString() != "")
                    {
                        model.username = dt.Rows[n]["username"].ToString();
                    }
                    if (dt.Rows[n]["userpassword"] != null && dt.Rows[n]["userpassword"].ToString() != "")
                    {
                        model.userpassword = dt.Rows[n]["userpassword"].ToString();
                    }
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        //public DataSet GetAllList()
        //{
        //    return GetList("");
        //}

        /// <summary>
        /// 获取用户类型
        /// </summary>
        [WebMethod]
        public int GetUserType(string strWhere, string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllUser.GetUserType(strWhere);
        }
        ///// <summary>
        ///// 分页获取数据列表
        ///// </summary>
        //public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        //{
        //    return bllUser.GetListByPage(strWhere, orderby, startIndex, endIndex);
        //}
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}
        /// <summary>
        /// 校验用户密码
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <param name="UserPassword">密码</param>
        /// <returns>-1用户不存在 1 正确 0 用户密码错误</returns>
        [WebMethod]
        public int CheckPassWord(string UserName, string UserPassword, string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            // -1用户不存在 1 正确 0 用户密码错误
            List<FYSOFT.HMIS.Models.User> listUser = GetModelList(string.Format("username='{0}'", UserName));
            if (listUser.Count <= 0)
            {
                return -1;
            }
            if (listUser[0].userpassword == UserPassword)
            {
                return 1;
            }
            else
            {
                return -0;
            }
        }
        /// <summary>
        /// 检查用名是否存在
        /// </summary>
        [WebMethod]
        public bool CheckUserName(string UserName, string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllUser.CheckUserName(UserName);
        }
        /// <summary>
        /// 修改用户密码
        /// </summary>
        [WebMethod]
        public bool UpdateUserPassword(string UserName, string UserPasswword, string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllUser.UpdateUserPassword(UserName, UserPasswword);
        }
        #endregion  Method
    }
}

using EFEntity;
using IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
   public class RoleDAL:DaoBase<Role>,IRoleDAL
    {
        static MyDBContext db = CreateDbContext();
        private static MyDBContext CreateDbContext()
        {
            //从当前请求的线程取值
            db = CallContext.GetData("s") as MyDBContext;
            if (db == null)
            {
                db = new MyDBContext();
                //把上下文对象存入当前请求的线程中
                CallContext.SetData("s", db);
            }
            return db;
        }

        public int Add(RoleModel st)
        {
            //把DTO转为EO
            Role est = new Role()
            {
                RoleID = st.RoleID,
                RoleName = st.RoleName,
                RoleExplain = st.RoleExplain,
                IsOK = st.IsOK
            };
            return Add(est);
        }

        public List<usersModel> cxqb()
        {
            throw new NotImplementedException();
        }

        public int Del(RoleModel st)
        {
            Role est = new Role()
            {
                RoleID = st.RoleID
            };
            return Delete(est);
        }

        public List<RoleModel> fenye(int dqy)
        {
            int rows = 0;
            List<Role> list = FenYe<int>(e => e.RoleID, e => e.RoleID > 0, ref rows, dqy, 5);
            List<RoleModel> list2 = new List<RoleModel>();
            foreach (Role item in list)
            {
                RoleModel um = new RoleModel()
                {
                    RoleID = item.RoleID,
                    RoleName = item.RoleName,
                    RoleExplain = item.RoleExplain,
                    IsOK = item.IsOK
                };
                list2.Add(um);
            }
            return list2;
        }

        public List<RoleModel> RoleSelect()
        {
            var values = db.Database.SqlQuery<RoleModel>($"select * from Role").ToList();
            return values;
        }

        public int Row()
        {
            int rows = 0;
            List<Role> list = FenYe<int>(e => e.RoleID, e => e.RoleID > 0, ref rows, 1, 5);
            return rows;
        }
        public int pages()
        {
            int rows = 0;
            List<Role> list = FenYe<int>(e => e.RoleID, e => e.RoleID > 0, ref rows, 1, 5);
            double page = rows / 5.00;
            return (int)Math.Ceiling(page);
        } 

        public List<RoleModel> Select()
        {
            List<Role> list = SelectAll();
            List<RoleModel> list2 = new List<RoleModel>();
            foreach (Role item in list)
            {
                RoleModel sm = new RoleModel()
                {
                    RoleID = item.RoleID,
                    RoleName = item.RoleName,
                    RoleExplain = item.RoleExplain,
                    IsOK = item.IsOK
                };
                list2.Add(sm);
            }
            return list2;
        }

        public RoleModel SelectBy(int id)
        {
            Role r = SelectBy(e => e.RoleID.Equals(id)).FirstOrDefault();
           
                RoleModel rm = new RoleModel()
                {
                    RoleID = r.RoleID,
                    RoleName=r.RoleName,
                    RoleExplain=r.RoleExplain,
                    IsOK=r.IsOK
                };
            return rm;
        }

        public int Update(RoleModel st)
        {
            Role est = new Role()
            {
                RoleID = st.RoleID,
                RoleName = st.RoleName,
                RoleExplain = st.RoleExplain,
                IsOK = st.IsOK
            };
            return Update(est);
        }
        public DataTable selectJSQX(object rid,object id)
        {
            string sql = "";
            if (id == null)
            {
                //第一次过来,根数据
                sql = string.Format(@"select q.[id],[text],[state],qr.Pid,
case

    when qr.Pid is not null then 1
	else 0
end as checked
from [dbo].[Popedoms] q
left join(select Pid from [dbo].[PopedomRole] where uid = '{0}') qr on q.id = qr.Pid
where q.FID = 0", rid);
            }
            else
            {
                //第n次过来,子数据
                sql = string.Format(@"select q.[id],[text],[state],qr.Pid,
case

    when qr.Pid is not null then 1
	else 0
end as checked
from [dbo].[Popedoms] q
left join(select Pid from [dbo].[PopedomRole] where uid = '{0}') qr on q.id = qr.Pid
where q.FID = {1}", rid, id);
            }
            return DBHelper.SelectTable(sql);
        }
        /// <summary>
        ///  查询当前角色对应权限
        /// </summary>
        /// <param name="rid"></param>
        /// <param name="pid"></param>
        /// <returns></returns>
        public DataTable selectQX(string rid, string pid)
        {
            string sql = string.Format("select a.id, text, state,pe.id,case when pe.id is not null then 1 else 0 end as checked from [Popedoms] a left join(select * from PopedomRole where  uid='{0}') pe on a.id= pe.Pid where a.FID ='{1}'", rid, pid);
            return DBHelper.SelectTable(sql);

        }
        //根据角色id删除角色权限表
        public int DeletePer(string rid)
        {
            string sql = string.Format(@"Delete from [dbo].[PopedomRole] where uid ='{0}'", rid);
            return DBHelper.InsertDeleteUpdate(sql);

        }
        /// <summary>
        /// 新增角色权限表
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int AddPer(string sql)
        {
            return DBHelper.InsertDeleteUpdate(sql);

        }
    public List<RoleModel> selectupdate(int id)
        {
            List<Role> list = SelectBy(e => e.RoleID == id);


            List<RoleModel> li = new List<RoleModel>();
            foreach (Role item in list)
            {
                RoleModel ko = new RoleModel();
                ko.RoleID = item.RoleID;
                ko.RoleName = item.RoleName;
                ko.RoleExplain = item.RoleExplain;
                ko.IsOK = item.IsOK; li.Add(ko);
            }
            return li;

        }

    }
}

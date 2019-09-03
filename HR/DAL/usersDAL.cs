using EFEntity;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Data.Entity.Infrastructure;

namespace DAL
{
    public class usersDAL : DaoBase<users>, IusersDAL
    {
        static MyDBContext db = CreateDbContext();
        private Boolean RemoveHoldingEntityInContext(users entity)
        {
            var objContext = ((IObjectContextAdapter)db).ObjectContext;
            var objSet = objContext.CreateObjectSet<users>();
            var entityKey = objContext.CreateEntityKey(objSet.EntitySet.Name, entity);
            Object foundEntity;
            var exists = objContext.TryGetObjectByKey(entityKey, out foundEntity);

            if (exists)
            {
                objContext.Detach(foundEntity);
            }

            return (exists);

        }

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
        public List<usersModel> SelectBy(usersModel st)
        {
            List<users> list = SelectBy(e => e.Id.Equals(st.Id));
            List<usersModel> list2 = new List<usersModel>();
            foreach (var item in list)
            {
                usersModel sd = new usersModel()
                {
                    Id = item.Id,
                    u_name = item.u_name,
                    u_true_name = item.u_true_name,
                    u_password = item.u_password,
                    RoleID = item.RoleID
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(usersModel st)
        {
            //把DTO转为EO
            users est = new users()
            {
                Id = st.Id,
                u_name = st.u_name,
                u_true_name = st.u_true_name,
                u_password = st.u_password,
                RoleID = st.RoleID
            };
            return Add(est);
        }

        public int Del(Model.usersModel st)
        {
            users est = new users()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.usersModel> Select()
        {
            List<users> list = SelectAll();
            List<usersModel> list2 = new List<usersModel>();
            foreach (users item in list)
            {
                usersModel sm = new usersModel()
                {
                    Id = item.Id,
                    u_name = item.u_name,
                    u_true_name = item.u_true_name,
                    u_password = item.u_password
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(usersModel st)
        {
            users est = new users()
            {
                Id = st.Id,
                u_name = st.u_name,
                u_true_name = st.u_true_name,
                u_password = st.u_password,
                RoleID = st.RoleID
            };
            return Update(est);
        }
        public Dictionary<string, object> Fenye(int pageIndex)
        {
            List<usersModel> list = db.Database.SqlQuery<usersModel>($"select [Id],[u_name],[u_true_name],[u_password],(select [RoleName] from [dbo].[Role] where RoleID = u.RoleID)as RoleName  from [dbo].[users] u").ToList();
            List<usersModel> list2 = list.Skip((pageIndex - 1) * 3).Take(3).ToList();
            int rows = list.Count();
            double page = rows / 3.00;
            int pages = int.Parse(Math.Ceiling(page).ToString());
            Dictionary<string, object> di = new Dictionary<string, object>();
            di["dt"] = list2;
            di["rows"] = rows;
            di["pages"] = pages;
            return di;
        }
        public int Row()
        {
            int rows = 0;
            List<users> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, 1, 2);
            return rows;
        }
        public int login(usersModel us)
        {
            users u = new users();
            List<users> list = SelectBy(e => e.u_name.Equals(us.u_name) && e.u_password.Equals(us.u_password));
            foreach (users item in list)
            {
                if (item == null || item.Equals(""))
                {
                    return 0;
                }
                else
                {
                    return list[0].Id;
                }
            }
            return 0;
        }
        //根据Uid查询角色
        public DataTable SelectJS(int Uid)
        {
            string sql = string.Format(@"select [RoleID],u_true_name,(select  RoleName from Role r where (u.RoleID=r.[RoleID]))as RoleName from [dbo].[users] u  where id={0}", Uid);
            return DBHelper.SelectTable(sql);
        }
    }
}

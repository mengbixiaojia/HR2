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
            List<Role> list = FenYe<int>(e => e.RoleID, e => e.RoleID > 0, ref rows, dqy, 2);
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
            List<Role> list = FenYe<int>(e => e.RoleID, e => e.RoleID > 0, ref rows, 1, 2);
            return rows;
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

        public List<RoleModel> SelectBy(RoleModel st)
        {
            List<Role> list = SelectBy(e => e.RoleID.Equals(st.RoleID));
            List<RoleModel> list2 = new List<RoleModel>();
            foreach (var item in list)
            {
                RoleModel sd = new RoleModel()
                {
                    RoleID = item.RoleID,
                    RoleName=item.RoleName,
                    RoleExplain=item.RoleExplain,
                    IsOK=item.IsOK
                };
                list2.Add(sd);
            }
            return list2;
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
    }
}

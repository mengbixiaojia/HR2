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

namespace DAL
{
    public class usersDAL:DaoBase<users>,IusersDAL
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
        public List<usersModel> SelectBy(usersModel st)
        {
            List<users> list = SelectBy(e => e.Id.Equals(st.Id));
            List<usersModel> list2 = new List<usersModel>();
            foreach (var item in list)
            {
               usersModel sd = new usersModel()
                {
                    Id =item.Id,
                    u_name=item.u_name,
                   u_true_name=item.u_true_name,
                   u_password=item.u_password,
                   RoleID=item.RoleID
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

        object IusersDAL.login(usersModel u)
        {
            return login(u);
        }
        public List<usersModel> fenye(int dqy)
        {
            int rows = 0;
            List<users> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, dqy, 2);
            List<usersModel> list2 = new List<usersModel>();
            foreach (users item in list)
            {
                usersModel um = new usersModel()
                {
                    Id = item.Id,
                    u_name = item.u_name,
                    u_true_name = item.u_true_name,
                    u_password = item.u_password
                };
                list2.Add(um);
            }
            return list2;
        }
        public int Row()
        {
            int rows = 0;
            List<users> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, 1, 2);
            return rows;
        }
        public List<usersModel> cxqb()
        {
            var values=db.Database.SqlQuery<usersModel>($"select [Id],[u_name],[u_true_name],(select [RoleName] from [dbo].[Role] r where (r.[RoleID]=u.[RoleID]))as name,[u_password] from [dbo].[users] u").ToList();
            return values;
        }
    }
}

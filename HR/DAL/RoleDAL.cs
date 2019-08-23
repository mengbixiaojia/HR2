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

        public int Add(usersModel st)
        {
            throw new NotImplementedException();
        }

        public List<usersModel> cxqb()
        {
            throw new NotImplementedException();
        }

        public int Del(usersModel st)
        {
            throw new NotImplementedException();
        }

        public List<usersModel> fenye(int dqy)
        {
            throw new NotImplementedException();
        }

        public List<RoleModel> RoleSelect()
        {
            var values = db.Database.SqlQuery<RoleModel>($"select * from Role").ToList();
            return values;
        }

        public int Row()
        {
            throw new NotImplementedException();
        }

        public List<usersModel> Select()
        {
            throw new NotImplementedException();
        }

        public List<usersModel> SelectBy(usersModel st)
        {
            throw new NotImplementedException();
        }

        public int Update(usersModel st)
        {
            throw new NotImplementedException();
        }
    }
}

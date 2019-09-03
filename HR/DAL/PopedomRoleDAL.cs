using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using IDAL;
using Model;
using System.Runtime.Remoting.Messaging;

namespace DAL
{
    public class PopedomRoleDAL : DaoBase<PopedomRole>, IPopedomRoleDAL
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
        public int Add(PopedomRoleModel pm)
        {
            PopedomRole pr = new PopedomRole()
            {
                id = pm.id,
                uid = pm.uid,
                Pid = pm.Pid
            };
            return Add(pr);
        }

        public int Del(PopedomRoleModel pm)
        {
            PopedomRole pr = new PopedomRole()
            {
                id = pm.id
            };
            return Delete(pr);
        }

        public List<PopedomRoleModel> select()
        {
            List<PopedomRole> list = SelectAll();
            List<PopedomRoleModel> list2 = new List<PopedomRoleModel>();
            foreach (PopedomRole item in list)
            {
                PopedomRoleModel cm = new PopedomRoleModel()
                {
                    id = item.id,
                    uid = item.uid,
                    Pid = item.Pid
                };
                list2.Add(cm);
            }
            return list2;
        }

        public PopedomRoleModel SelectBy(int id)
        {
            PopedomRole c = SelectBy(e => e.id.Equals(id)).FirstOrDefault();
            PopedomRoleModel cm = new PopedomRoleModel()
            {
                id = c.id,
                uid = c.uid,
                Pid = c.Pid
            };
            return cm;
        }

        public DataTable selectRole(object uid, object id)
        {
            throw new NotImplementedException();
        }

        public DataTable selectRoleJ(object uid, object id)
        {
            string sql = "";
            if (id != null)
            {
                //查询子级
                sql = string.Format(@"select * from [dbo].[Popedoms] q inner join [dbo].[PopedomRole] qr on q.id=qr.Pid where qr.uid='{0}' and q.Fid='{1}'", uid, id);
            }
            else
            {
                //查询父级
                sql = string.Format(@"select * from [dbo].[Popedoms] q inner join [dbo].[PopedomRole] qr on q.id=qr.Pid where qr.uid='{0}' and q.Fid='0'", uid);
            }
            return DBHelper.SelectTable(sql);
        }

        public int Update(PopedomRoleModel pm)
        {
            PopedomRole est = new PopedomRole()
            {
                id = pm.id,
                uid = pm.uid,
                Pid = pm.Pid
            };
            return Update(est);
        }
    }
}

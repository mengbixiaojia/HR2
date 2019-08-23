using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using EFEntity;
using System.Data.Entity.Infrastructure;

namespace DAL
{
   public class DaoBase<T> where T : class
    {
        //static MyDbContext db = CreateDbContext();
        ////用于监测Context中的Entity是否存在，如果存在，将其Detach，防止出现问题。
        //private Boolean RemoveHoldingEntityInContext(T entity)
        //{
        //    var objContext = ((IObjectContextAdapter)db).ObjectContext;
        //    var objSet = objContext.CreateObjectSet<T>();
        //    var entityKey = objContext.CreateEntityKey(objSet.EntitySet.Name, entity);

        //    Object foundEntity;
        //    var exists = objContext.TryGetObjectByKey(entityKey, out foundEntity);

        //    if (exists)
        //    {
        //        objContext.Detach(foundEntity);
        //    }

        //    return (exists);
        //}

        //private static MyDbContext CreateDbContext()
        //{
        //    //从当前请求的线程取值
        //    db = CallContext.GetData("s") as MyDbContext;
        //    if (db == null)
        //    {
        //        db = new MyDbContext();
        //        //把上下文对象存入当前请求的线程中
        //        CallContext.SetData("s", db);
        //    }
        //    return db;
        //}
        //public int Add(T t)
        //{
        //    //db.Set<T>().Add(t);//Set<T>()相当于实体类
        //    db.Entry<T>(t).State = EntityState.Added;
        //    return db.SaveChanges();
        //}

        //public int Update(T t)
        //{
        //    db.Entry<T>(t).State = EntityState.Modified;
        //    return db.SaveChanges();
        //}

        //public int Delete(T t)
        //{
        //    db.Entry<T>(t).State = EntityState.Deleted;
        //    return db.SaveChanges();
        //}

        //public List<T> SelectAll()
        //{
        //    List<T> list = db.Set<T>().Select(e => e).ToList();
        //    return list;
        //}

        //public List<T> SelectBy(Expression<Func<T, bool>> where)
        //{
        //    List<T> list = db.Set<T>().Select(e => e).Where(where).ToList();
        //    return list;
        //}
        //public List<T> FenYe<K>(Expression<Func<T, K>> order, Expression<Func<T, bool>> where, ref int rows, int currentPage, int pageSize)
        //{
        //    var data = db.Set<T>().OrderBy(order).Where(where);
        //    rows = data.Count();//获取总行数
        //    List<T> list = data.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        //    return list;
        //}
        static MyDBContext db = CreateDbContext();

        //用于监测Context中的Entity是否存在，如果存在，将其Detach，防止出现问题。
        private Boolean RemoveHoldingEntityInContext(T entity)
        {
            var objContext = ((IObjectContextAdapter)db).ObjectContext;
            var objSet = objContext.CreateObjectSet<T>();
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

        public int Add(T t)
        {
            //Set<T>()等于Students
            db.Entry<T>(t).State = EntityState.Added;
            return db.SaveChanges();
        }
        public int Update(T t)
        {
            RemoveHoldingEntityInContext(t);
            db.Entry(t).State = EntityState.Modified;
            return db.SaveChanges();
        }
        public int Delete(T t)
        {

            RemoveHoldingEntityInContext(t);
            db.Entry(t).State = EntityState.Deleted;
            return db.SaveChanges();

        }

        /// <summary>
        /// 查询全部
        /// </summary>
        /// <returns></returns>
        public List<T> SelectAll()
        {
            List<T> list = db.Set<T>().Select(e => e).AsNoTracking().ToList();
            return list;
        }

        /// <summary>
        /// 按条件查询Expression<Func<T,bool>>是条件的类型,可以是表达式
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<T> SelectBy(Expression<Func<T, bool>> where)
        {
            List<T> list = db.Set<T>().Select(e => e)
                .Where(where)
                .ToList();
            return list;
        }


        /// <summary>
        /// 分页 K表示排序的属性的数据类型,比如id K就是int name k就是string
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <param name="order"></param>
        /// <param name="where"></param>
        /// <param name="rows"></param>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<T> FenYe<K>(Expression<Func<T, K>> order, Expression<Func<T, bool>> where, ref int rows, int currentPage, int pageSize)
        {
            var data = db.Set<T>().OrderBy(order).Where(where);
            rows = data.Count();//获取总行数
            List<T> list = data.Skip((currentPage - 1) * pageSize)//舍弃多少行
                .Take(pageSize)//每页显示数
                .ToList();
            return list;
        }
    }
}

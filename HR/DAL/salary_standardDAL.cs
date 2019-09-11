using EFEntity;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class salary_standardDAL:DaoBase<salary_standard>,Isalary_standardDAL
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
        public List<salary_standardModel> SelectBy(salary_standardModel st)
        {
            List<salary_standard> list = SelectBy(e => e.standard_id.Equals(st.standard_id));
            List<salary_standardModel> list2 = new List<salary_standardModel>();
            foreach (var item in list)
            {
               salary_standardModel sd = new salary_standardModel()
                {
                    Id =item.Id
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(salary_standardModel st)
        {
            //把DTO转为EO
            salary_standard est = new salary_standard()
            {
                Id = st.Id
            };
            return Add(est);
        }

        public int Del(Model.salary_standardModel st)
        {
            salary_standard est = new salary_standard()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.salary_standardModel> Select()
        {
            List<salary_standard> list = SelectAll();
            List<salary_standardModel> list2 = new List<salary_standardModel>();
            foreach (salary_standard item in list)
            {
                salary_standardModel sm = new salary_standardModel()
                {
                    Id = item.Id,
                    standard_id=item.standard_id,
                    standard_name=item.standard_name,
                    designer=item.designer,
                    register=item.register,
                    checker=item.checker,
                    changer=item.changer,
                    regist_time=item.regist_time,
                    check_time=item.check_time,
                    change_time=item.change_time,
                    salary_sum=item.salary_sum,
                    change_status=item.change_status,
                    check_status=item.check_status,
                    remark=item.remark
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(salary_standardModel st)
        {
            salary_standard est = new salary_standard()
            {
                Id = st.Id
            };
            return Update(est);
        }
        public List<salary_standardModel> SelectBy2(salary_standardModel st)
        {
            List<salary_standard> list = SelectBy(e => e.standard_id.Equals(st.standard_id));
            List<salary_standardModel> list2 = new List<salary_standardModel>();
            foreach (var item in list)
            {
                salary_standardModel sd = new salary_standardModel()
                {
                    Id = item.Id,
                    standard_id = item.standard_id,
                    standard_name = item.standard_name,
                    designer = item.designer,
                    register = item.register,
                    checker = item.checker,
                    changer = item.changer,
                    regist_time = item.regist_time,
                    check_time = item.check_time,
                    change_time = item.change_time,
                    salary_sum = item.salary_sum,
                    change_status = item.change_status,
                    check_status = item.check_status,
                    remark = item.remark
                };
                list2.Add(sd);
            }
            return list2;
        }
        public List<salary_standardModel> nineSelect()
        {
            var values = db.Database.SqlQuery<salary_standardModel>($"select [standard_id],[standard_name] from [dbo].[salary_standard]").ToList();
            return values;
        }
        public List<salary_standardModel> SelectByName(salary_standardModel st)
        {
            List<salary_standard> list = SelectBy(e => e.standard_id.Equals(st.standard_id) && e.standard_id.Equals(st.standard_id));
            List<salary_standardModel> list2 = new List<salary_standardModel>();
            foreach (var item in list)
            {
                salary_standardModel sd = new salary_standardModel()
                {
                    Id = item.Id,
                    standard_id = item.standard_id,
                    standard_name = item.standard_name,
                    designer = item.designer,
                    register = item.register,
                    checker = item.checker,
                    changer = item.changer,
                    regist_time = item.regist_time,
                    check_time = item.check_time,
                    change_time = item.change_time,
                    salary_sum = item.salary_sum,
                    change_status = item.change_status,
                    check_status = item.check_status,
                    remark = item.remark
                };
                list2.Add(sd);
            }
            return list2;
        }
    }
}

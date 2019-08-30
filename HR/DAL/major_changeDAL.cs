using EFEntity;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class major_changeDAL:DaoBase<major_change>,Imajor_changeDAL
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
        public List<major_changeModel> SelectBy(major_changeModel st)
        {
            List<major_change> list = SelectBy(e => e.Id.Equals(st.Id));
            List<major_changeModel> list2 = new List<major_changeModel>();
            foreach (var item in list)
            {
               major_changeModel sd = new major_changeModel()
                {
                    Id =item.Id,
                   first_kind_id = item.first_kind_id,
                   first_kind_name = item.first_kind_name,
                   second_kind_id = item.second_kind_id,
                   second_kind_name = item.second_kind_name,
                   third_kind_id = item.third_kind_id,
                   third_kind_name = item.third_kind_name,
                   major_kind_id = item.major_kind_id,
                   major_kind_name = item.major_kind_name,
                   major_id = item.major_id,
                   major_name = item.major_name,
                   new_first_kind_id = item.new_first_kind_id,
                   new_first_kind_name = item.new_first_kind_name,
                   new_second_kind_id = item.new_second_kind_id,
                   new_second_kind_name = item.new_second_kind_name,
                   new_third_kind_id = item.new_third_kind_id,
                   new_third_kind_name = item.new_third_kind_name,
                   new_major_kind_id = item.new_major_kind_id,
                   new_major_kind_name = item.new_major_kind_name,
                   new_major_id = item.new_major_id,
                   new_major_name = item.new_major_name,
                   human_id = item.human_id,
                   human_name = item.human_name,
                   salary_standard_id = item.salary_standard_id,
                   salary_standard_name = item.salary_standard_name,
                   salary_sum = item.salary_sum,
                   new_salary_standard_id = item.new_salary_standard_id,
                   new_salary_standard_name = item.new_salary_standard_name,
                   new_salary_sum = item.new_salary_sum,
                   change_reason = item.change_reason,
                   check_reason = item.check_reason,
                   check_status = item.check_status,
                   register = item.register,
                   checker = item.checker,
                   regist_time = item.regist_time,
                   check_time = item.check_time
               };
                list2.Add(sd);
            }
            return list2;
        }

        public List<major_changeModel> SelectBy2(major_changeModel st)
        {
            List<major_change> list = SelectBy(e => e.new_salary_standard_id.Equals(st.new_salary_standard_id));
            List<major_changeModel> list2 = new List<major_changeModel>();
            foreach (var item in list)
            {
                major_changeModel sd = new major_changeModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                    major_id = item.major_id,
                    major_name = item.major_name,
                    new_first_kind_id = item.new_first_kind_id,
                    new_first_kind_name = item.new_first_kind_name,
                    new_second_kind_id = item.new_second_kind_id,
                    new_second_kind_name = item.new_second_kind_name,
                    new_third_kind_id = item.new_third_kind_id,
                    new_third_kind_name = item.new_third_kind_name,
                    new_major_kind_id = item.new_major_kind_id,
                    new_major_kind_name = item.new_major_kind_name,
                    new_major_id = item.new_major_id,
                    new_major_name = item.new_major_name,
                    human_id = item.human_id,
                    human_name = item.human_name,
                    salary_standard_id = item.salary_standard_id,
                    salary_standard_name = item.salary_standard_name,
                    salary_sum = item.salary_sum,
                    new_salary_standard_id = item.new_salary_standard_id,
                    new_salary_standard_name = item.new_salary_standard_name,
                    new_salary_sum = item.new_salary_sum,
                    change_reason = item.change_reason,
                    check_reason = item.check_reason,
                    check_status = item.check_status,
                    register = item.register,
                    checker = item.checker,
                    regist_time = item.regist_time,
                    check_time = item.check_time
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(major_changeModel st)
        {
            //把DTO转为EO
            major_change est = new major_change()
            {
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id = st.third_kind_id,
                third_kind_name = st.third_kind_name,
                major_kind_id = st.major_kind_id,
                major_kind_name = st.major_kind_name,
                major_id = st.major_id,
                major_name = st.major_name,
                new_first_kind_id = st.new_first_kind_id,
                new_first_kind_name = st.new_first_kind_name,
                new_second_kind_id = st.new_second_kind_id,
                new_second_kind_name = st.new_second_kind_name,
                new_third_kind_id = st.new_third_kind_id,
                new_third_kind_name = st.new_third_kind_name,
                new_major_kind_id = st.new_major_kind_id,
                new_major_kind_name = st.new_major_kind_name,
                new_major_id = st.new_major_id,
                new_major_name = st.new_major_name,
                human_id = st.human_id,
                human_name = st.human_name,
                salary_standard_id = st.salary_standard_id,
                salary_standard_name = st.salary_standard_name,
                salary_sum = st.salary_sum,
                new_salary_standard_id = st.new_salary_standard_id,
                new_salary_standard_name = st.new_salary_standard_name,
                new_salary_sum = st.new_salary_sum,
                change_reason = st.change_reason,
                check_reason = st.check_reason,
                check_status = st.check_status,
                register = st.register,
                checker = st.checker,
                regist_time = st.regist_time,
                check_time = st.check_time
            };
            return Add(est);
        }

        public int Del(Model.major_changeModel st)
        {
            major_change est = new major_change()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.major_changeModel> Select()
        {
            List<major_change> list = SelectAll();
            List<major_changeModel> list2 = new List<major_changeModel>();
            foreach (major_change item in list)
            {
                major_changeModel sm = new major_changeModel()
                {
                    Id = item.Id,
                    first_kind_id=item.first_kind_id,
                    first_kind_name=item.first_kind_name,
                    second_kind_id=item.second_kind_id,
                    second_kind_name=item.second_kind_name,
                    third_kind_id=item.third_kind_id,
                    third_kind_name=item.third_kind_name,
                    major_kind_id=item.major_kind_id,
                    major_kind_name=item.major_kind_name,
                    major_id=item.major_id,
                    major_name=item.major_name,
                    new_first_kind_id=item.new_first_kind_id,
                    new_first_kind_name=item.new_first_kind_name,
                    new_second_kind_id=item.new_second_kind_id,
                    new_second_kind_name=item.new_second_kind_name,
                    new_third_kind_id=item.new_third_kind_id,
                    new_third_kind_name=item.new_third_kind_name,
                    new_major_kind_id=item.new_major_kind_id,
                    new_major_kind_name=item.new_major_kind_name,
                    new_major_id=item.new_major_id,
                    new_major_name=item.new_major_name,
                    human_id=item.human_id,
                    human_name=item.human_name,
                    salary_standard_id=item.salary_standard_id,
                    salary_standard_name=item.salary_standard_name,
                    salary_sum=item.salary_sum,
                    new_salary_standard_id=item.new_salary_standard_id,
                    new_salary_standard_name=item.new_salary_standard_name,
                    new_salary_sum=item.new_salary_sum,
                    change_reason=item.change_reason,
                    check_reason=item.check_reason,
                    check_status=item.check_status,
                    register=item.register,
                    checker=item.checker,
                    regist_time=item.regist_time,
                    check_time=item.check_time
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(major_changeModel st)
        {
            major_change est = new major_change()
            {
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id = st.third_kind_id,
                third_kind_name = st.third_kind_name,
                major_kind_id = st.major_kind_id,
                major_kind_name = st.major_kind_name,
                major_id = st.major_id,
                major_name = st.major_name,
                new_first_kind_id = st.new_first_kind_id,
                new_first_kind_name = st.new_first_kind_name,
                new_second_kind_id = st.new_second_kind_id,
                new_second_kind_name = st.new_second_kind_name,
                new_third_kind_id = st.new_third_kind_id,
                new_third_kind_name = st.new_third_kind_name,
                new_major_kind_id = st.new_major_kind_id,
                new_major_kind_name = st.new_major_kind_name,
                new_major_id = st.new_major_id,
                new_major_name = st.new_major_name,
                human_id = st.human_id,
                human_name = st.human_name,
                salary_standard_id = st.salary_standard_id,
                salary_standard_name = st.salary_standard_name,
                salary_sum = st.salary_sum,
                new_salary_standard_id = st.new_salary_standard_id,
                new_salary_standard_name = st.new_salary_standard_name,
                new_salary_sum = st.new_salary_sum,
                change_reason = st.change_reason,
                check_reason = st.check_reason,
                check_status = st.check_status,
                register = st.register,
                checker = st.checker,
                regist_time = DateTime.Now,
                check_time = DateTime.Now
            };
            return Update(est);
        }
        public List<major_changeModel> firstSelect()
        {
            var values = db.Database.SqlQuery<major_changeModel>($"select [first_kind_id],[first_kind_name] from [dbo].[major_change]").ToList();
            return values;
        }

        public List<major_changeModel> secondSelect()
        {
            var values = db.Database.SqlQuery<major_changeModel>($"select [second_kind_id],[second_kind_name] from [dbo].[major_change]").ToList();
            return values;
        }

        public List<major_changeModel> thirdSelect()
        {
            var values = db.Database.SqlQuery<major_changeModel>($"select [third_kind_id],[third_kind_name] from [dbo].[major_change]").ToList();
            return values;
        }
        public List<major_changeModel> fenye(int dqy)
        {
            int rows = 0;
            List<major_change> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, dqy, 2);
            List<major_changeModel> list2 = new List<major_changeModel>();
            foreach (major_change item in list)
            {
                major_changeModel mm = new major_changeModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                    major_id = item.major_id,
                    major_name = item.major_name,
                    new_first_kind_id = item.new_first_kind_id,
                    new_first_kind_name = item.new_first_kind_name,
                    new_second_kind_id = item.new_second_kind_id,
                    new_second_kind_name = item.new_second_kind_name,
                    new_third_kind_id = item.new_third_kind_id,
                    new_third_kind_name = item.new_third_kind_name,
                    new_major_kind_id = item.new_major_kind_id,
                    new_major_kind_name = item.new_major_kind_name,
                    new_major_id = item.new_major_id,
                    new_major_name = item.new_major_name,
                    human_id = item.human_id,
                    human_name = item.human_name,
                    salary_standard_id = item.salary_standard_id,
                    salary_standard_name = item.salary_standard_name,
                    salary_sum = item.salary_sum,
                    new_salary_standard_id = item.new_salary_standard_id,
                    new_salary_standard_name = item.new_salary_standard_name,
                    new_salary_sum = item.new_salary_sum,
                    change_reason = item.change_reason,
                    check_reason = item.check_reason,
                    check_status = item.check_status,
                    register = item.register,
                    checker = item.checker,
                    regist_time = item.regist_time,
                    check_time = item.check_time
                };
                list2.Add(mm);
            }
            return list2;
        }
        public List<major_changeModel> fenye1(int dqy,major_changeModel mm,DateTime sj)
        {
            int rows = 0;
            List<major_change> list = FenYe<int>(e => e.Id, e => e.first_kind_id.Equals(mm.first_kind_id)&&e.second_kind_id.Equals(mm.second_kind_id)&&e.third_kind_id.Equals(mm.third_kind_id)&&e.regist_time>=mm.regist_time&&e.regist_time<=sj, ref rows, dqy, 1);
            List<major_changeModel> list2 = new List<major_changeModel>();
            foreach (major_change item in list)
            {
                major_changeModel mcm = new major_changeModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                    major_id = item.major_id,
                    major_name = item.major_name,
                    new_first_kind_id = item.new_first_kind_id,
                    new_first_kind_name = item.new_first_kind_name,
                    new_second_kind_id = item.new_second_kind_id,
                    new_second_kind_name = item.new_second_kind_name,
                    new_third_kind_id = item.new_third_kind_id,
                    new_third_kind_name = item.new_third_kind_name,
                    new_major_kind_id = item.new_major_kind_id,
                    new_major_kind_name = item.new_major_kind_name,
                    new_major_id = item.new_major_id,
                    new_major_name = item.new_major_name,
                    human_id = item.human_id,
                    human_name = item.human_name,
                    salary_standard_id = item.salary_standard_id,
                    salary_standard_name = item.salary_standard_name,
                    salary_sum = item.salary_sum,
                    new_salary_standard_id = item.new_salary_standard_id,
                    new_salary_standard_name = item.new_salary_standard_name,
                    new_salary_sum = item.new_salary_sum,
                    change_reason = item.change_reason,
                    check_reason = item.check_reason,
                    check_status = item.check_status,
                    register = item.register,
                    checker = item.checker,
                    regist_time = item.regist_time,
                    check_time = item.check_time
                };
                list2.Add(mcm);
            }
            return list2;
        }
        public List<major_changeModel> fenye2(int dqy)
        {
            int rows = 0;
            List<major_change> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, dqy, 1);
            List<major_changeModel> list2 = new List<major_changeModel>();
            foreach (major_change item in list)
            {
                major_changeModel mm = new major_changeModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                    major_id = item.major_id,
                    major_name = item.major_name,
                    new_first_kind_id = item.new_first_kind_id,
                    new_first_kind_name = item.new_first_kind_name,
                    new_second_kind_id = item.new_second_kind_id,
                    new_second_kind_name = item.new_second_kind_name,
                    new_third_kind_id = item.new_third_kind_id,
                    new_third_kind_name = item.new_third_kind_name,
                    new_major_kind_id = item.new_major_kind_id,
                    new_major_kind_name = item.new_major_kind_name,
                    new_major_id = item.new_major_id,
                    new_major_name = item.new_major_name,
                    human_id = item.human_id,
                    human_name = item.human_name,
                    salary_standard_id = item.salary_standard_id,
                    salary_standard_name = item.salary_standard_name,
                    salary_sum = item.salary_sum,
                    new_salary_standard_id = item.new_salary_standard_id,
                    new_salary_standard_name = item.new_salary_standard_name,
                    new_salary_sum = item.new_salary_sum,
                    change_reason = item.change_reason,
                    check_reason = item.check_reason,
                    check_status = item.check_status,
                    register = item.register,
                    checker = item.checker,
                    regist_time = item.regist_time,
                    check_time = item.check_time
                };
                list2.Add(mm);
            }
            return list2;
        }
        public int Row()
        {
            int rows = 0;
            List<major_change> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, 1, 2);
            return rows;
        }
        public int pages()
        {
            int rows = 0;
            List<major_change> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, 1, 2);
            double page = rows / 2.00;
            return (int)Math.Ceiling(page);
        }

        public List<major_changeModel> fourSelect()
        {
            var values = db.Database.SqlQuery<major_changeModel>($"select [new_first_kind_id],[new_first_kind_name] from [dbo].[major_change]").ToList();
            return values;
        }

        public List<major_changeModel> fiveSelect()
        {
            var values = db.Database.SqlQuery<major_changeModel>($"select [new_second_kind_id],[new_second_kind_name] from [dbo].[major_change]").ToList();
            return values;
        }

        public List<major_changeModel> sixSelect()
        {
            var values = db.Database.SqlQuery<major_changeModel>($"select [new_third_kind_id],[new_third_kind_name] from [dbo].[major_change]").ToList();
            return values;
        }
        public List<major_changeModel> sevenSelect()
        {
            var values = db.Database.SqlQuery<major_changeModel>($"select [new_major_kind_id],[new_major_kind_name] from [dbo].[major_change]").ToList();
            return values;
        }
        public List<major_changeModel> eightSelect()
        {
            var values = db.Database.SqlQuery<major_changeModel>($"select [new_major_id],[new_major_name] from [dbo].[major_change]").ToList();
            return values;
        }
        public List<major_changeModel> nineSelect()
        {
            var values = db.Database.SqlQuery<major_changeModel>($"select [new_salary_standard_id],[new_salary_standard_name] from [dbo].[major_change]").ToList();
            return values;
        }
        
    }
}

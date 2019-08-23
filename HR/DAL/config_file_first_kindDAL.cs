using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using IDAL;
using Model;
using System.Runtime.Remoting.Messaging;

namespace DAL
{
    public class config_file_first_kindDAL : DaoBase<config_file_first_kind>, Iconfig_file_first_kindDAL
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
        public int FirstKindAdd(config_file_first_kindModel fk)
        {
            config_file_first_kind est = new config_file_first_kind()
            {
                Id = fk.Id,
                first_kind_id = fk.first_kind_id,
                first_kind_name = fk.first_kind_name,
                first_kind_salary_id = fk.first_kind_salary_id,
                first_kind_sale_id = fk.first_kind_sale_id
            };
            return Add(est);
        }

        public int FirstKindDel(config_file_first_kindModel fk)
        {
            //把DTO转为EO
            config_file_first_kind est = new config_file_first_kind()
            {
                Id = fk.Id
            };
            return Delete(est);
        }

        public List<config_file_first_kindModel> FirstKindSelect()
        {
            List<config_file_first_kind> list = SelectAll();
            List<config_file_first_kindModel> list2 = new List<config_file_first_kindModel>();
            foreach (config_file_first_kind item in list)
            {
                config_file_first_kindModel cm = new config_file_first_kindModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    first_kind_salary_id = item.first_kind_salary_id,
                    first_kind_sale_id = item.first_kind_sale_id
                };
                list2.Add(cm);
            }
            return list2;
        }

        public config_file_first_kindModel FirstKindSelectBy(int id)
        {
            config_file_first_kind c = SelectBy(e => e.Id.Equals(id)).FirstOrDefault();
            config_file_first_kindModel cm = new config_file_first_kindModel()
            {
                Id=c.Id,
                first_kind_id=c.first_kind_id,
                first_kind_name=c.first_kind_name,
                first_kind_salary_id=c.first_kind_salary_id,
                first_kind_sale_id=c.first_kind_sale_id
            };
            return cm;
        }

        public int FirstKindUpdate(config_file_first_kindModel fk)
        {
            config_file_first_kind est = new config_file_first_kind()
            {
                Id = fk.Id,
                first_kind_id = fk.first_kind_id,
                first_kind_sale_id = fk.first_kind_sale_id,
                first_kind_name = fk.first_kind_name,
                first_kind_salary_id = fk.first_kind_salary_id
            };
            return Update(est);
        }
        //查询最大编号
        public object Maxfirst_kind_id()
        {
            var result = Convert.ToInt32(db.
                first_kind.Select(e => e.first_kind_id).Max());
            return result + 1;
        }
    }
}
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
    public class config_file_first_kindDAL:DaoBase<config_file_first_kind>,Iconfig_file_first_kindDAL
    {
        public List<config_file_first_kindModel> SelectBy(config_file_first_kindModel st)
        {
            List<config_file_first_kind> list = SelectBy(e => e.Id.Equals(st.Id));
            List<config_file_first_kindModel> list2 = new List<config_file_first_kindModel>();
            foreach (var item in list)
            {
                config_file_first_kindModel sd = new config_file_first_kindModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    first_kind_salary_id = item.first_kind_salary_id,
                    first_kind_sale_id = item.first_kind_sale_id
                };
                list2.Add(sd);
            }
            return list2;
        }

        public List<config_file_first_kindModel> SelectByName(config_file_first_kindModel st)
        {
            List<config_file_first_kind> list = SelectBy(e => e.first_kind_id.Equals(st.first_kind_id));
            List<config_file_first_kindModel> list2 = new List<config_file_first_kindModel>();
            foreach (var item in list)
            {
                config_file_first_kindModel sd = new config_file_first_kindModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    first_kind_salary_id = item.first_kind_salary_id,
                    first_kind_sale_id = item.first_kind_sale_id
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(config_file_first_kindModel st)
        {
            //把DTO转为EO9
            config_file_first_kind est = new config_file_first_kind()
            {
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                first_kind_salary_id = st.first_kind_salary_id,
                first_kind_sale_id = st.first_kind_sale_id
            };
            return Add(est);
        }

        public int Del(Model.config_file_first_kindModel st)
        {
            config_file_first_kind est = new config_file_first_kind()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.config_file_first_kindModel> Select()
        {
            List<config_file_first_kind> list = SelectAll();
            List<config_file_first_kindModel> list2 = new List<config_file_first_kindModel>();
            foreach (config_file_first_kind item in list)
            {
                config_file_first_kindModel sm = new config_file_first_kindModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    first_kind_salary_id = item.first_kind_salary_id,
                    first_kind_sale_id = item.first_kind_sale_id
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(config_file_first_kindModel st)
        {
            config_file_first_kind est = new config_file_first_kind()
            {
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                first_kind_salary_id = st.first_kind_salary_id,
                first_kind_sale_id = st.first_kind_sale_id
            };
            return Update(est);
        }
    }
}

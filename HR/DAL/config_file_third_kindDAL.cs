using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using Model;
using IDAL;
using System.Runtime.Remoting.Messaging;

namespace DAL
{
    public class config_file_third_kindDAL:DaoBase<config_file_third_kind>, Iconfig_file_third_kindDAL
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
        public int Add(config_file_third_kindModel cm)
        {
            config_file_third_kind cfk = new config_file_third_kind
            {
                first_kind_id = cm.first_kind_id,
                second_kind_id = cm.second_kind_id,
                first_kind_name = cm.first_kind_name,
                second_kind_name = cm.second_kind_name,
                third_kind_id = cm.third_kind_id,
                third_kind_is_retail = cm.third_kind_is_retail,
                third_kind_name = cm.third_kind_name,
                third_kind_sale_id = cm.third_kind_sale_id
            };
            return Add(cfk);
        }
        public int del(config_file_third_kindModel cm)
        {
            config_file_third_kind cfk = new config_file_third_kind
            {
                Id = cm.Id
            };
            return Delete(cfk);
        }
        public int update(config_file_third_kindModel cm)
        {
            config_file_third_kind cfk = new config_file_third_kind
            {
                Id = cm.Id,
                first_kind_id = cm.first_kind_id,
                second_kind_id = cm.second_kind_id,
                first_kind_name = cm.first_kind_name,
                second_kind_name = cm.second_kind_name,
                third_kind_id = cm.third_kind_id,
                third_kind_is_retail = cm.third_kind_is_retail,
                third_kind_name = cm.third_kind_name,
                third_kind_sale_id = cm.third_kind_sale_id
            };
            return Update(cfk);
        }
        public List<config_file_third_kindModel> Select()
        {
            List<config_file_third_kind> list = SelectAll();
            List<config_file_third_kindModel> list2 = new List<config_file_third_kindModel>();
            foreach (config_file_third_kind item in list)
            {
                config_file_third_kindModel cfk = new config_file_third_kindModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    second_kind_id = item.second_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_is_retail = item.third_kind_is_retail,
                    third_kind_name = item.third_kind_name,
                    third_kind_sale_id = item.third_kind_sale_id
                };
                list2.Add(cfk);
            }
            return list2;
        }
        public object max()
        {
            var value = Convert.ToInt32(db.config_file_third_kind.Select(e=>e.third_kind_id).Max());
            return value + 1;
        }
        public List<config_file_third_kindModel> By(config_file_third_kindModel st)
        {
            List<config_file_third_kind> list = SelectBy(e => e.Id.Equals(st.Id));
            List<config_file_third_kindModel> list2 = new List<config_file_third_kindModel>();
            foreach (config_file_third_kind item in list)
            {
                config_file_third_kindModel sm = new config_file_third_kindModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    second_kind_id = item.second_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_is_retail = item.third_kind_is_retail,
                    third_kind_name = item.third_kind_name,
                    third_kind_sale_id = item.third_kind_sale_id
                };
                list2.Add(sm);
            }
            return list2;
        }
    }
}

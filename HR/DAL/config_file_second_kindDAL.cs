using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAL;
using EFEntity;
using System.Data;

namespace DAL
{
    public class config_file_second_kindDAL : DaoBase<config_file_second_kind>, Iconfig_file_second_kindDAL
    {
        public DataTable SelectType(string id )
        {
            string sql = $"select * from [dbo].[config_file_first_kind] where  first_kind_id ={id}";
            return DBHelper.SelectTable(sql);
        }
        public DataTable SelectXLK()
        {
            string sql = $"select * from [dbo].[config_file_first_kind]";
            return DBHelper.SelectTable(sql);
        }
          public List<config_file_second_kindModel> SelectBy(config_file_second_kindModel st)
        {
            List<config_file_second_kind> list = SelectBy(e => e.Id.Equals(st.Id));
            List<config_file_second_kindModel> list2 = new List<config_file_second_kindModel>();
            foreach (var item in list)
            {
                config_file_second_kindModel sd = new config_file_second_kindModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    first_kind_name = item.first_kind_name,
                    second_salary_id = item.second_salary_id,
                    second_sale_id = item.second_sale_id
                };
                list2.Add(sd);
            }
            return list2;
        }

        public List<config_file_second_kindModel> SelectByName(config_file_second_kindModel st)
        {
            List<config_file_second_kind> list = SelectBy(e => e.second_kind_id.Equals(st.second_kind_id));
            List<config_file_second_kindModel> list2 = new List<config_file_second_kindModel>();
            foreach (var item in list)
            {
                config_file_second_kindModel sd = new config_file_second_kindModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    first_kind_name = item.first_kind_name,
                    second_salary_id = item.second_salary_id,
                    second_sale_id = item.second_sale_id
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(config_file_second_kindModel st)
        {
            //把DTO转为EO9
            config_file_second_kind est = new config_file_second_kind()
            {
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                first_kind_name = st.first_kind_name,
                second_salary_id = st.second_salary_id,
                second_sale_id = st.second_sale_id
            };
            return Add(est);
        }

        public int Del(Model.config_file_second_kindModel st)
        {
            config_file_second_kind est = new config_file_second_kind()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.config_file_second_kindModel> Select()
        {
            List<config_file_second_kind> list = SelectAll();
            List<config_file_second_kindModel> list2 = new List<config_file_second_kindModel>();
            foreach (config_file_second_kind item in list)
            {
                config_file_second_kindModel sm = new config_file_second_kindModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    first_kind_name = item.first_kind_name,
                    second_salary_id = item.second_salary_id,
                    second_sale_id = item.second_sale_id
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(config_file_second_kindModel st)
        {
            config_file_second_kind est = new config_file_second_kind()
            {
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                first_kind_name = st.first_kind_name,
                second_salary_id = st.second_salary_id,
                second_sale_id = st.second_sale_id
            };
            return Update(est);
        }
    }
}

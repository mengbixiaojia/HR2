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
    public class config_file_second_kindDAL : DaoBase<config_file_second_kind>, config_file_second_kindIDAL
    {
        public int config_file_second_kindAdd(config_file_second_kindModel st)
        {
            //****
            //把你的add方法补齐了 电脑拿过去
            config_file_second_kind s = new config_file_second_kind()
            {
                first_kind_name =st.second_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                second_salary_id = st.second_salary_id,
                second_sale_id = st.second_sale_id,
                first_kind_id = st.first_kind_id

            };
            return Add(s);

        }

        public config_file_second_kindModel config_file_second_kindBYID(int id)
        {
            config_file_second_kind item = SelectBy(e => e.Id.Equals(id)).FirstOrDefault();
            config_file_second_kindModel sm = new config_file_second_kindModel()
            {
                Id = item.Id,
                first_kind_name = item.second_kind_name,
                second_kind_id = item.second_kind_id,
                second_kind_name = item.second_kind_name,
                second_salary_id = item.second_salary_id,
                second_sale_id = item.second_sale_id,
                first_kind_id = item.first_kind_id
            };
            return sm;
        }

        public int config_file_second_kindDele(config_file_second_kindModel st)
        {
            config_file_second_kind s = new config_file_second_kind() {
                Id = st.Id
        };
            return Delete(s);
        }

        public List<config_file_second_kindModel> config_file_second_kindsel()
        {
            List<config_file_second_kind> list = SelectAll();
            List<config_file_second_kindModel> list2 = new List<config_file_second_kindModel>();
            foreach (config_file_second_kind item in list)
            {
                config_file_second_kindModel sm = new config_file_second_kindModel()
                {
                    Id = item.Id,
                    first_kind_name = item.second_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    second_salary_id = item.second_salary_id,
                    second_sale_id = item.second_sale_id,
                    first_kind_id = item.first_kind_id
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int config_file_second_kindUP(config_file_second_kindModel st)
        {
            config_file_second_kind s = new config_file_second_kind()
            {
                Id = st.Id,
                first_kind_name = st.second_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                second_salary_id = st.second_salary_id,
                second_sale_id = st.second_sale_id,
                first_kind_id = st.first_kind_id
            };
            return Update(s);
        }

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

    }
}

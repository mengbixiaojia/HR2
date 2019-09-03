using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using IDAL;
using Model;
namespace DAL
{
    public class salary_standard_detailsDAL : DaoBase<salary_standard_details>, Isalary_standard_detailsDAL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="s"></param
        /// <returns></returns>
        public int salary_standard_detailsAdd(salary_standard_detailsModel s)
        {
            salary_standard_details ss = new salary_standard_details() {
                standard_id=s.standard_id,
                standard_name=s.standard_name,
                item_id=s.item_id,
                item_name=s.item_name,
                salary=s.salary
            };
            return Add(ss);
        }

        public int salaUP(salary_standard_detailsModel s)
        {
            salary_standard_details ss = new salary_standard_details()
            {
                Id=s.Id,
                standard_id = s.standard_id,
                standard_name = s.standard_name,
                item_id = s.item_id,
                item_name = s.item_name,
                salary = s.salary
            };
            return Update(ss);
        }

        public List<salary_standard_detailsModel> selectBYid(salary_standard_detailsModel id)
        {
           List <salary_standard_details> s1 = SelectBy(e => e.standard_id.Equals(id.standard_id));
            List<salary_standard_detailsModel> list = new List<salary_standard_detailsModel>();
            foreach (var s in s1)
            {
                salary_standard_detailsModel s2 = new salary_standard_detailsModel()
                {
                    Id = s.Id,
                    standard_id = s.standard_id,
                    standard_name = s.standard_name,
                    item_id = s.item_id,
                    item_name = s.item_name,
                    salary = s.salary
                };
                list.Add(s2);
            }
        
            return list;
        }

      
    }
}

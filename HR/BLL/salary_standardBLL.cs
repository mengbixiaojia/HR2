using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Model;
using IDAL;
using IOC;

namespace BLL
{
    public class salary_standardBLL:Isalary_standardBLL
    {
      Isalary_standardDAL ist = IocCreate.Createsalary_standardDAL();

        public List<salary_standardModel> SelectBy(salary_standardModel st)
        {
            return ist.SelectBy(st);
        }

        public int Add(salary_standardModel st)
        {
            return ist.Add(st);
        }

        public int Del(salary_standardModel st)
        {
            return ist.Del(st);
        }

        public List<salary_standardModel> Select()
        {
            return ist.Select();
        }

        public int Update(salary_standardModel st)
        {
            return ist.Update(st);
        }
        public List<salary_standardModel> SelectBy2(salary_standardModel st)
        {
            return ist.SelectBy2(st);
        }
        public List<salary_standardModel> nineSelect()
        {
            return ist.nineSelect();
        }
        public List<salary_standardModel> SelectByName(salary_standardModel st)
        {
            return ist.SelectByName(st);
        }
    }
}

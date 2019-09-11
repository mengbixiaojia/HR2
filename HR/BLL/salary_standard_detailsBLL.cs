using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IOC;
using IBLL;
using IDAL;
namespace BLL
{
    public class salary_standard_detailsBLL : Isalary_standard_detailsBLL
    {
        Isalary_standard_detailsDAL  st= IocCreate.Createsalary_standard_detailsDAL();
        public int salary_standard_detailsAdd(salary_standard_detailsModel s)
        {
            return st.salary_standard_detailsAdd(s);
        }

        public int salaUP(salary_standard_detailsModel s)
        {
            return st.salaUP(s);
        }

        public List<salary_standard_detailsModel> selectBYid(salary_standard_detailsModel id)
        {
            return st.selectBYid(id);
        }
        public List<salary_standard_detailsModel> Select()
        {
            return st.Select();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAL
{
   public interface Isalary_standard_detailsDAL
    {
        int salary_standard_detailsAdd(salary_standard_detailsModel s);
        List<salary_standard_detailsModel> selectBYid(salary_standard_detailsModel id);
        int salaUP(salary_standard_detailsModel s);
    }
}

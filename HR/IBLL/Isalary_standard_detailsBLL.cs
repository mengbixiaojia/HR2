using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
   public interface Isalary_standard_detailsBLL
    {
        int salary_standard_detailsAdd(salary_standard_detailsModel s);
        List<salary_standard_detailsModel> selectBYid(salary_standard_detailsModel id);
        int salaUP(salary_standard_detailsModel s);
    }
}

using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface Isalary_standardBLL
    {
        int Add(salary_standardModel st);
        int Del(salary_standardModel st);
        int Update(salary_standardModel st);
        List<salary_standardModel> Select();
        List<salary_standardModel> SelectBy(salary_standardModel st);
        List<salary_standardModel> SelectBy2(salary_standardModel st);
        List<salary_standardModel> nineSelect();
        List<salary_standardModel> SelectByName(salary_standardModel st);
    }
}


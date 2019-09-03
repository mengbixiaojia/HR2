using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
    public interface salary_standardIBLL
    {
        int salary_standardAdd(salary_standardModel s);
        int Row();
        List<salary_standardModel> fenye(int dqy);
        int Pages();
        salary_standardModel SelectBYID(int id);
        int UP(salary_standardModel s);
        List<salary_standardModel> Fenyecx(int dqy, string bh, string gjz, DateTime sjq, DateTime sjh);
        int rows(string bh, string gjz,string sjq,string sjh);
        int Pagescx();
    
    }
}

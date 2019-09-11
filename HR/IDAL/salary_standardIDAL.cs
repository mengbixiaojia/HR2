using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAL
{
  public  interface salary_standardIDAL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        int salary_standardAdd(salary_standardModel s);

        int Row();
        int rows(string bh,string gjz,string sjq,string sjh);
        List<salary_standardModel> fenye(int dqy);
        List<salary_standardModel> Fenyecx(int dqy, string bh, string gjz, DateTime sjq, DateTime sjh);
        int Pages();
        int Pagescx();
        salary_standardModel SelectBYID(int id);
        int UP(salary_standardModel s);
    }
}

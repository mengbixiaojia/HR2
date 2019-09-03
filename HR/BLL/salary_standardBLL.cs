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
    public class salary_standardBLL : salary_standardIBLL
    {
        salary_standardIDAL st = IOC.IocCreate.Createsalary_standardDAL();

        public List<salary_standardModel> fenye(int dqy)
        {
            return st.fenye(dqy);
        }

        public List<salary_standardModel> Fenyecx(int dqy, string bh, string gjz, DateTime sjq, DateTime sjh)
        {
            return st.Fenyecx(dqy, bh, gjz, sjq, sjh);
        }

        public int Pages()
        {
            return st.Pages();
        }

        public int Pagescx()
        {
            return st.Pagescx();
        }

        public int Row()
        {
            return st.Row();
        }

        public int rows(string bh, string gjz,string sjq,string sjh)
        {
            return st.rows(bh, gjz,sjq,sjh);
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int salary_standardAdd(salary_standardModel s)
        {
            return st.salary_standardAdd(s);
        }

        public salary_standardModel SelectBYID(int id)
        {
            return st.SelectBYID(id);
        }

        public int UP(salary_standardModel s)
        {
            return st.UP(s);
        }
    }
}

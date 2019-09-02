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
    public class engage_resumeBLL : Iengage_resumeBLL
    {
        Iengage_resumeDAL ist = IocCreate.Createengage_resumeDAL();

        public List<engage_resumeModel> SelectBy(engage_resumeModel st)
        {
            return ist.SelectBy(st);
        }

        public int Add(engage_resumeModel st)
        {
            return ist.Add(st);
        }

        public int Del(engage_resumeModel st)
        {
            return ist.Del(st);
        }

        public List<engage_resumeModel> Select()
        {
            return ist.Select();
        }

        public int Update(engage_resumeModel st)
        {
            return ist.Update(st);
        }
        public List<engage_resumeModel> FenYeByZT(int dqy)
        {
            return ist.FenYeByZT(dqy);
        }
        public int rows()
        {
            return ist.rows();
        }
        public int page()
        {
            return ist.page();
        }
    }
}

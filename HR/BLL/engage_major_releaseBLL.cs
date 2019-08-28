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
    public class engage_major_releaseBLL:Iengage_major_releaseBLL
    {
      Iengage_major_releaseDAL ist = IocCreate.Createengage_major_releaseDAL();

        public List<engage_major_releaseModel> SelectBy(engage_major_releaseModel st)
        {
            return ist.SelectBy(st);
        }

        public int Add(engage_major_releaseModel st)
        {
            return ist.Add(st);
        }

        public int Del(engage_major_releaseModel st)
        {
            return ist.Del(st);
        }

        public List<engage_major_releaseModel> Select()
        {
            return ist.Select();
        }

        public int Update(engage_major_releaseModel st)
        {
            return ist.Update(st);
        }
        public List<engage_major_releaseModel> fenye(int dqy)
        {
            return ist.fenye(dqy);
        }
        public int page()
        {
            return ist.page();
        }
        public int rows()
        {
            return ist.rows();
        }
    }
}

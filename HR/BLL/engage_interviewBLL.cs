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
    public class engage_interviewBLL:Iengage_interviewBLL
    {
      Iengage_interviewDAL ist = IocCreate.Createengage_interviewDAL();

        public List<engage_interviewModel> SelectBy(engage_interviewModel st)
        {
            return ist.SelectBy(st);
        }

        public int Add(engage_interviewModel st)
        {
            return ist.Add(st);
        }

        public int Del(engage_interviewModel st)
        {
            return ist.Del(st);
        }

        public List<engage_interviewModel> Select()
        {
            return ist.Select();
        }

        public int Update(engage_interviewModel st)
        {
            return ist.Update(st);
        }
    }
}

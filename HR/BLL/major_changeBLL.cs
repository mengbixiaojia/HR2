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
    public class major_changeBLL:Imajor_changeBLL
    {
      Imajor_changeDAL ist = IocCreate.Createmajor_changeDAL();

        public List<major_changeModel> SelectBy(major_changeModel st)
        {
            return ist.SelectBy(st);
        }

        public int Add(major_changeModel st)
        {
            return ist.Add(st);
        }

        public int Del(major_changeModel st)
        {
            return ist.Del(st);
        }

        public List<major_changeModel> Select()
        {
            return ist.Select();
        }

        public int Update(major_changeModel st)
        {
            return ist.Update(st);
        }
    }
}

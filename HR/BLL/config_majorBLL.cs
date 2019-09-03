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
    public class config_majorBLL:Iconfig_majorBLL
    {
      Iconfig_majorDAL ist = IocCreate.Createconfig_majorDAL();

     
        public int Add(config_majorModel st)
        {
            return ist.Add(st);
        }

        public int Del(config_majorModel st)
        {
            return ist.Del(st);
        }

        public List<config_majorModel> Select()
        {
            return ist.Select();
        }
    }
}

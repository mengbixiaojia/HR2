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
    public class config_file_first_kindBLL:Iconfig_file_first_kindBLL
    {
      Iconfig_file_first_kindDAL ist = IocCreate.Createconfig_file_first_kindDAL();

        public List<config_file_first_kindModel> SelectBy(config_file_first_kindModel st)
        {
            return ist.SelectBy(st);
        }
        public List<config_file_first_kindModel> SelectByName(config_file_first_kindModel st)
        {
            return ist.SelectByName(st);
        }

        public int Add(config_file_first_kindModel st)
        {
            return ist.Add(st);
        }

        public int Del(config_file_first_kindModel st)
        {
            return ist.Del(st);
        }

        public List<config_file_first_kindModel> Select()
        {
            return ist.Select();
        }

        public int Update(config_file_first_kindModel st)
        {
            return ist.Update(st);
        }
    }
}

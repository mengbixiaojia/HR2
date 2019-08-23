using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOC;
using Model;
using IBLL;
using IDAL;
using System.Data;

namespace BLL
{
  public  class config_file_second_kindBLL : config_file_second_kindIBLL
    {
        config_file_second_kindIDAL cis = IocCreate.Createconfig_file_second_kindDAL();

        public int config_file_second_kindAdd(config_file_second_kindModel st)
        {
            return cis.config_file_second_kindAdd(st);
        }

        public config_file_second_kindModel config_file_second_kindBYID(int id)
        {
            return cis.config_file_second_kindBYID(id);
        }

        public int config_file_second_kindDele(config_file_second_kindModel st)
        {
            return cis.config_file_second_kindDele(st);
        }

        public List<config_file_second_kindModel> config_file_second_kindsel()
        {
            return cis.config_file_second_kindsel();
        }

        public int config_file_second_kindUP(config_file_second_kindModel st)
        {
            return cis.config_file_second_kindUP(st);
        }
        public DataTable SelectId(string id) {
            return cis.SelectType(id);
        }

        public DataTable SelectXLK()
        {
            return cis.SelectXLK();
        }
    }
}

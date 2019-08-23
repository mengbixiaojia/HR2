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
    public class config_file_third_kindBLL : Iconfig_file_third_kindBLL
    {
        Iconfig_file_third_kindDAL id = IocCreate.CreateConfig_file_third_kindDAL();
        public int Add(config_file_third_kindModel cm)
        {
            return id.Add(cm);
        }

        public int del(config_file_third_kindModel cm)
        {
            return id.del(cm);
        }

        public List<config_file_third_kindModel> By(config_file_third_kindModel st)
        {
            return id.By(st);
        }

        public List<config_file_third_kindModel> Select()
        {
            return id.Select();
        }
        public object max()
        {
            return id.max();
        }

        public int update(config_file_third_kindModel cm)
        {
            return id.update(cm);
        }
    }
}

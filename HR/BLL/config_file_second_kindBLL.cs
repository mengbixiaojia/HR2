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
  public  class config_file_second_kindBLL : Iconfig_file_second_kindBLL
    {
        Iconfig_file_second_kindDAL cis = IocCreate.Createconfig_file_second_kindDAL();
        public DataTable SelectId(string id) {
            return cis.SelectType(id);
        }

        public DataTable SelectXLK()
        {
            return cis.SelectXLK();
        }
        Iconfig_file_second_kindDAL ist = IocCreate.Createconfig_file_second_kindDAL();

        public List<config_file_second_kindModel> SelectBy(config_file_second_kindModel st)
        {
            return ist.SelectBy(st);
        }
        public List<config_file_second_kindModel> SelectByName(config_file_second_kindModel st)
        {
            return ist.SelectByName(st);
        }

        public int Add(config_file_second_kindModel st)
        {
            return ist.Add(st);
        }

        public int Del(config_file_second_kindModel st)
        {
            return ist.Del(st);
        }

        public List<config_file_second_kindModel> Select()
        {
            return ist.Select();
        }

        public int Update(config_file_second_kindModel st)
        {
            return ist.Update(st);
        }
        public DataTable SelectType(string id)
        {
            return ist.SelectType(id);
        }
    }
}

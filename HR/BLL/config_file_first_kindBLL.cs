﻿using System;
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
        Iconfig_file_first_kindDAL icb = IocCreate.Createconfig_file_first_kindModelDAL();
        public int FirstKindAdd(config_file_first_kindModel fk)
        {
            return icb.FirstKindAdd(fk);
        }

        public int FirstKindDel(config_file_first_kindModel fk)
        {
            return icb.FirstKindDel(fk);
        }

        public int FirstKindUpdate(config_file_first_kindModel fk)
        {
            return icb.FirstKindUpdate(fk);
        }

        public config_file_first_kindModel FirstKindBy(int id)
        {
            return icb.FirstKindSelectBy(id);
        }

        public List<config_file_first_kindModel> FirstKindSelect()
        {
            return icb.FirstKindSelect();
        }
        public object Maxfirst_kind_id()
        {
            return icb.Maxfirst_kind_id();
        }
    }
}

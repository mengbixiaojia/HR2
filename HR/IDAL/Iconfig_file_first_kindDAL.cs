﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
   public interface Iconfig_file_first_kindDAL
    {
        int FirstKindAdd(config_file_first_kindModel fk);
        int FirstKindDel(config_file_first_kindModel fk);
        int FirstKindUpdate(config_file_first_kindModel fk);
        List<config_file_first_kindModel> FirstKindSelect();
        config_file_first_kindModel FirstKindSelectBy(int id);
        object Maxfirst_kind_id();
    }
}
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface Iconfig_file_first_kindDAL
    {
        int Add(config_file_first_kindModel st);
        int Del(config_file_first_kindModel st);
         int Update(config_file_first_kindModel st);
        List<config_file_first_kindModel> Select();
       List<config_file_first_kindModel> SelectBy(config_file_first_kindModel st);
        List<config_file_first_kindModel> SelectByName(config_file_first_kindModel st);
    }
}

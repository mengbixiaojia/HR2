using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface Iconfig_file_second_kindBLL
    {
        int Add(config_file_second_kindModel st);
        int Del(config_file_second_kindModel st);
        int Update(config_file_second_kindModel st);
        List<config_file_second_kindModel> Select();
        List<config_file_second_kindModel> SelectBy(config_file_second_kindModel st);
        List<config_file_second_kindModel> SelectByName(config_file_second_kindModel st);
    }
}


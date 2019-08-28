using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IBLL
{
    public interface Iconfig_file_third_kindBLL
    {
        int Add(config_file_third_kindModel cm);
        int del(config_file_third_kindModel cm);
        object max();
        int update(config_file_third_kindModel cm);
        List<config_file_third_kindModel> Select();
        List<config_file_third_kindModel> By(config_file_third_kindModel st);
        List<config_file_third_kindModel> SeBy(String Id);
        List<config_file_third_kindModel> SelectByName(config_file_third_kindModel st);
    }
}

using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface Iconfig_majorDAL
    {
        int Add(config_majorModel st);
        int Del(config_majorModel st);
        List<config_majorModel> Select();
    }
}

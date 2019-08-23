using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
   public interface Iconfig_major_kindDAL
    {
        int majorkindDel(config_major_kindModel ck);
        List<config_major_kindModel> majorKindSelect();
        int majorkindAdd(config_major_kindModel ck);
    }
}

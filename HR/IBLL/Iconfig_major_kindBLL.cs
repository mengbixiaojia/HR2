using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IBLL
{
   public interface Iconfig_major_kindBLL
    {
        int majorKindDel(config_major_kindModel fk);
        List<config_major_kindModel> majorKindSelect();
        int majorKindAdd(config_major_kindModel fk);
    }
}

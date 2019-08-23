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
    class config_major_kindBLL : Iconfig_major_kindBLL
    {
        Iconfig_major_kindDAL icd = IocCreate.Createconfig_major_kindDAL();

        public int majorKindAdd(config_major_kindModel fk)
        {
            return icd.majorkindAdd(fk);
    }

        public int majorKindDel(config_major_kindModel fk)
        {
            return icd.majorkindDel(fk);
        }

        public List<config_major_kindModel> majorKindSelect()
        {
            return icd.majorKindSelect();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;
using IOC;
using IBLL;

namespace BLL
{
    public class config_public_charBLL : Iconfig_public_charBLL
    {
        Iconfig_public_charDAL ib = IocCreate.CreateConfig_public_charDAL();
        public int Add(config_public_charModel st)
        {
            return ib.Add(st);
        }

        public int Del(config_public_charModel st)
        {
            return ib.Del(st);
        }

        public List<config_public_charModel> Select()
        {
            return ib.Select();
        }
    }
}

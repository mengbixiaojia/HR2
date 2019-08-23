using IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IOC;
using IDAL;
namespace BLL
{
    public class config_public_charBLL : config_public_charIBLL
    {
        config_public_charIDAL cis = IocCreate.Createconfig_public_charIDAL();
        public int config_public_charAdd(config_public_charModel s)
        {
            return cis.config_public_charAdd(s);
        }

        public int config_public_charDelect(config_public_charModel s)
        {
            return cis.config_public_charDelect(s);
        }

        public List<config_public_charModel> config_public_charSelect(config_public_charModel s)
        {
            return cis.config_public_charSelect(s);
        }
    }
}

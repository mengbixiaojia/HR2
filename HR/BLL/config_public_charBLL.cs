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
    public class config_public_charBLL:Iconfig_public_charBLL
    {
        Iconfig_public_charDAL ist = IocCreate.Createconfig_public_charDAL();

        public List<config_public_charModel> SelectBy(config_public_charModel st)
        {
            return ist.SelectBy(st);
        }

        public int Add(config_public_charModel st)
        {
            return ist.Add(st);
        }

        public int Del(config_public_charModel st)
        {
            return ist.Del(st);
        }

        public List<config_public_charModel> Select()
        {
            return ist.Select();
        }

        public int Update(config_public_charModel st)
        {
            return ist.Update(st);
        }
        Iconfig_public_charDAL cis = IocCreate.Createconfig_public_charDAL();
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

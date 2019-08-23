using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface Iconfig_public_charDAL
    {
        int Add(config_public_charModel st);
        int Del(config_public_charModel st);
         int Update(config_public_charModel st);
        List<config_public_charModel> Select();
       List<config_public_charModel> SelectBy(config_public_charModel st);
    }
}

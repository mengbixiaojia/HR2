using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
  public  interface config_public_charIDAL
    {
        int config_public_charAdd(config_public_charModel s);
        List<config_public_charModel> config_public_charSelect(config_public_charModel st);
        int config_public_charDelect(config_public_charModel s);
    }
}

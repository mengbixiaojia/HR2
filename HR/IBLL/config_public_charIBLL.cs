using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
  public  interface config_public_charIBLL
    {
        int config_public_charAdd(config_public_charModel s);
        List<config_public_charModel> config_public_charSelect(config_public_charModel s);
        int config_public_charDelect(config_public_charModel s);
    }
}

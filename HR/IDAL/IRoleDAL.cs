using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
   public interface IRoleDAL
    {
        List<RoleModel> RoleSelect();
        int Add(RoleModel st);
        int Del(RoleModel st);
        int Update(RoleModel st);
        List<RoleModel> Select();
        List<RoleModel> SelectBy(RoleModel st);
        int Row();
        List<RoleModel> fenye(int dqy);
    }
}

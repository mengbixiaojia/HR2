using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
   public interface IPopedomRoleDAL
    {
        DataTable selectRole(object uid, object id);
        int Add(PopedomRoleModel pm);
        int Update(PopedomRoleModel pm);
        int Del(PopedomRoleModel pm);
        List<PopedomRoleModel> select();
        PopedomRoleModel SelectBy(int id);
        DataTable selectRoleJ(object uid, object id);
    }
}

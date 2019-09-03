using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace IBLL
{
   public interface IPopedomRoleBLL
    {
        int Add(PopedomRoleModel pm);
        int Del(PopedomRoleModel pm);
        int Update(PopedomRoleModel pm);
        List<PopedomRoleModel> Select();
        PopedomRoleModel SelectBy(int id);
        DataTable selectRoleJ(object uid, object id);

    }
}

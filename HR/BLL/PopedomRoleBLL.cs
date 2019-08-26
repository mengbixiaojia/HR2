using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Model;
using IDAL;
using IOC;
using System.Data;

namespace BLL
{
    public class PopedomRoleBLL : IPopedomRoleBLL
    {
        IPopedomRoleDAL ipd = IocCreate.CreatePopedomRoleDAL();
        public int Add(PopedomRoleModel pm)
        {
            return ipd.Add(pm);
        }

        public int Del(PopedomRoleModel pm)
        {
            return ipd.Del(pm);
        }

        public List<PopedomRoleModel> Select()
        {
            return ipd.select();
        }

        public PopedomRoleModel SelectBy(int id)
        {
            return ipd.SelectBy(id);
        }

        public int Update(PopedomRoleModel pm)
        {
            return ipd.Update(pm);
        }
        public DataTable selectRoleJ(object uid, object id)
        {
            return ipd.selectRoleJ(uid, id);
        }
    }
}

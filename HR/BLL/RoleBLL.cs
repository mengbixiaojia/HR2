using IBLL;
using IDAL;
using IOC;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class RoleBLL:IRoleBLL
    {
        IRoleDAL irb = IocCreate.CreateRoleDAL();
        public List<RoleModel> RoleSelect()
        {
            return irb.RoleSelect();
        }
    }
}

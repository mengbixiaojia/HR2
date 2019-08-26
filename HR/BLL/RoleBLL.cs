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

        public int Add(RoleModel st)
        {
            return irb.Add(st);
        }

        public int Del(RoleModel st)
        {
            return irb.Del(st);
        }

        public List<RoleModel> fenye(int dqy)
        {
            return irb.fenye(dqy);
        }

        public List<RoleModel> RoleSelect()
        {
            return irb.RoleSelect();
        }

        public int Row()
        {
            return irb.Row();
        }

        public List<RoleModel> Select()
        {
            return irb.Select();
        }

        public List<RoleModel> SelectBy(RoleModel st)
        {
            return irb.SelectBy(st);
        }

        public int Update(RoleModel st)
        {
            return irb.Update(st);
        }
    }
}

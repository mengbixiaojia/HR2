using IBLL;
using IDAL;
using IOC;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
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
        public int pages()
        {
            return irb.pages();
        }

        public List<RoleModel> Select()
        {
            return irb.Select();
        }

        public RoleModel SelectBy(int id)
        {
            return irb.SelectBy(id);
        }

        public int Update(RoleModel st)
        {
            return irb.Update(st);
        }
        public DataTable selectJSQX(object rid, object id)
        {
            return irb.selectJSQX(rid, id);
        }

        public DataTable selectQX(string rid, string pid)
        {
            return irb.selectQX(rid, pid);
        }

        public int DeletePer(string rid)
        {
            return irb.DeletePer(rid);
        }

        public int AddPer(string sql)
        {
            return irb.AddPer(sql);
        }
        public List<RoleModel> selectupdate(int id)
        {
            return irb.selectupdate(id);
        }
    }
}

using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
   public interface IRoleBLL
    {
        List<RoleModel> RoleSelect();
        int Add(RoleModel st);
        int Del(RoleModel st);
        int Update(RoleModel st);
        List<RoleModel> Select();
        RoleModel SelectBy(int id);
        int Row();
        int pages();
        List<RoleModel> fenye(int dqy);
        DataTable selectJSQX(object rid, object id);
        DataTable selectQX(string rid, string pid);
        int DeletePer(string rid);
        int AddPer(string sql);
        List<RoleModel> selectupdate(int id);
    }
}

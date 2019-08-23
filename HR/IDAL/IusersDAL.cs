using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IusersDAL
    {
        int Add(usersModel st);
        int Del(usersModel st);
         int Update(usersModel st);
        List<usersModel> Select();
       List<usersModel> SelectBy(usersModel st);
        object login(usersModel u);
        List<usersModel> cxqb();
        int Row();
        List<usersModel> fenye(int dqy);
    }
}

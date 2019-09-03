using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IusersBLL
    {
        int Add(usersModel st);
        int Del(usersModel st);
        int Update(usersModel st);
        List<usersModel> Select();
       List<usersModel> SelectBy(usersModel st);
        int login(usersModel us);
        int Row();
        //List<usersModel> fenye(int dqy);
        DataTable SelectJS(int Uid);
        Dictionary<string, object> Fenye(int pageIndex);
    }
}


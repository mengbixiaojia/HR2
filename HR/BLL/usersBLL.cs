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
    public class usersBLL : IusersBLL
    {
        IusersDAL ist = IocCreate.CreateusersDAL();

        public List<usersModel> SelectBy(usersModel st)
        {
            return ist.SelectBy(st);
        }

        public int Add(usersModel st)
        {
            return ist.Add(st);
        }

        public int Del(usersModel st)
        {
            return ist.Del(st);
        }

        public List<usersModel> Select()
        {
            return ist.Select();
        }

        public int Update(usersModel st)
        {
            return ist.Update(st);
        }
        public int Row()
        {
            return ist.Row();
        }
        public Dictionary<string, object> Fenye(int pageIndex)
        {
            return ist.Fenye(pageIndex);
        }
        int IusersBLL.login(usersModel us)
        {
            return ist.login(us);
        }
        public DataTable SelectJS(int Uid)
        {
            return ist.SelectJS(Uid);
        }
    }
}

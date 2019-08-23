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
    public class usersBLL:IusersBLL
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

        public object login(usersModel u)
        {
            return ist.login(u);
        }
        public List<usersModel> cxqb()
        {
            return ist.cxqb();
        }
        public int Row()
        {
            return ist.Row();
        }
        public List<usersModel> fenye(int dqy)
        {
            return ist.fenye(dqy);
        }
    }
}

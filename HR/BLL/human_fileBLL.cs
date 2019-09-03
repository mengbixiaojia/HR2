using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Model;
using IDAL;
using IOC;

namespace BLL
{
    public class human_fileBLL:Ihuman_fileBLL
    {
      Ihuman_fileDAL ist = IocCreate.Createhuman_fileDAL();

        public List<human_fileModel> SelectBy(human_fileModel st)
        {
            return ist.SelectBy(st);
        }

        public int Add(human_fileModel st)
        {
            return ist.Add(st);
        }

        public int Del(human_fileModel st)
        {
            return ist.Del(st);
        }

        public List<human_fileModel> Select()
        {
            return ist.Select();
        }

        public int Update(human_fileModel st)
        {
            return ist.Update(st);
        }
    }
}

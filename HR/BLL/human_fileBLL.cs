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
        public Dictionary<string, object> Fenye(int dqy)
        {
            return ist.Fenye(dqy);
        }

        public List<human_fileModel> SelectById(human_fileModel st)
        {
            return ist.SelectById(st);
        }

        public Dictionary<string, object> Fenye(int dqy, string first, string second, string third, string major, string major_kind, string start, string end)
        {
            return ist.Fenye(dqy, first, second, third, major, major_kind, start, end);
        }

        public Dictionary<string, object> Fenye1(int dqy, string first, string second, string third, string major, string major_kind, string start, string end)
        {
            return ist.Fenye1(dqy, first, second, third, major, major_kind, start, end);
        }
    }
}

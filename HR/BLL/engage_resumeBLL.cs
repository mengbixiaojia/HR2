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
    public class engage_resumeBLL : Iengage_resumeBLL
    {
        Iengage_resumeDAL ist = IocCreate.Createengage_resumeDAL();

        public List<engage_resumeModel> SelectBy(engage_resumeModel st)
        {
            return ist.SelectBy(st);
        }
        public List<engage_resumeModel> ByID(int id)
        {
            return ist.ByID(id);
        }

        public int Add(engage_resumeModel st)
        {
            return ist.Add(st);
        }

        public int Del(engage_resumeModel st)
        {
            return ist.Del(st);
        }

        public List<engage_resumeModel> Select()
        {
            return ist.Select();
        }

        public int Update(engage_resumeModel st)
        {
            return ist.Update(st);
        }
        public List<engage_resumeModel> FenYeByZT(int dqy)
        {
            return ist.FenYeByZT(dqy);
        }
        public int rows()
        {
            return ist.rows();
        }
        public int page()
        {
            return ist.page();
        }

        public Dictionary<string, object> SeBy(int dqy, string Qid, string Pid, string Guan, string Start, string End, string Zt)
        {
            return ist.SeBy(dqy, Qid, Pid, Guan, Start, End, Zt);
        }

        public Dictionary<string, object> SeByy(int dqy, string Qid, string Pid, string Guan, string Start, string End, string Zt)
        {
            return ist.SeByy(dqy, Qid, Pid, Guan, Start, End, Zt);
        }

        public Dictionary<string, object> Fenye(int dqy)
        {
            return ist.Fenye(dqy);
        }
        public Dictionary<string, object> Fenye1(int dqy)
        {
            return ist.Fenye1(dqy);
        }

        public Dictionary<string, object> interviewDJ(int dqy)
        {
            return ist.interviewDJ(dqy);
        }
    }
}

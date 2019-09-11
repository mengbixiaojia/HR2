using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface Iengage_resumeDAL
    {
        int Add(engage_resumeModel st);
        int Del(engage_resumeModel st);
        int Update(engage_resumeModel st);
        List<engage_resumeModel> Select();
        List<engage_resumeModel> SelectBy(engage_resumeModel st);
        List<engage_resumeModel> ByID(int id);
        List<engage_resumeModel> FenYeByZT(int dqy);
        int rows();
        int page();
        Dictionary<string, object> SeBy(int dqy, String Qid, String Pid, String Guan, String Start, String End, String Zt);
        Dictionary<string, object> SeByy(int dqy, String Qid, String Pid, String Guan, String Start, String End, String Zt);

        Dictionary<string, object> Fenye(int dqy);
        Dictionary<string, object> Fenye1(int dqy);
        Dictionary<string, object> interviewDJ(int dqy);
    }
}

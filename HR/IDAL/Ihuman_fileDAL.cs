using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface Ihuman_fileDAL
    {
        int Add(human_fileModel st);
        int Del(human_fileModel st);
         int Update(human_fileModel st);
        List<human_fileModel> Select();
       List<human_fileModel> SelectBy(human_fileModel st);
        Dictionary<string, object> Fenye(int dqy);
        List<human_fileModel> SelectById(human_fileModel st);
        Dictionary<string, object> Fenye(int dqy, string first, string second, string third, string major, string major_kind, string start, string end);
        Dictionary<string, object> Fenye1(int dqy, string first, string second, string third, string major, string major_kind, string start, string end);
    }
}

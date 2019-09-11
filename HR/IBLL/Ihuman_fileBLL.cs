using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface Ihuman_fileBLL
    {
        int Add(human_fileModel st);
        int Del(human_fileModel st);
        int Update(human_fileModel st);
        List<human_fileModel> Select();
       List<human_fileModel> SelectBy(human_fileModel st);

       List<human_fileModel> fenye(int dqy);
        Dictionary<string, object> fenye1(int dqy, string yi, string er, string san, string time1, string time2);
    }
}


using Model;
using System;
using System.Collections.Generic;
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
        Dictionary<string, object> Fenye(int dqy);
        List<human_fileModel> SelectById(human_fileModel st);
    }
}


using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface Iengage_major_releaseBLL
    {
        int Add(engage_major_releaseModel st);
        int Del(engage_major_releaseModel st);
        int Update(engage_major_releaseModel st);
        List<engage_major_releaseModel> Select();
        List<engage_major_releaseModel> SelectBy(engage_major_releaseModel st);
        List<engage_major_releaseModel> fenye(int dqy);
        int page();
        int rows();
    }
}


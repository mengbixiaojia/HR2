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
    }
}

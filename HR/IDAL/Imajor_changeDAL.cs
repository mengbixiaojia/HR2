using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface Imajor_changeDAL
    {
        int Add(major_changeModel st);
        int Del(major_changeModel st);
         int Update(major_changeModel st);
        List<major_changeModel> Select();
       List<major_changeModel> SelectBy(major_changeModel st);
        List<major_changeModel> SelectBy2(major_changeModel st);
        List<major_changeModel> firstSelect();
        int Row();
        int pages();
        List<major_changeModel> fenye(int dqy);
        
        List<major_changeModel> fenye2(int dqy);
        List<major_changeModel> atjcx(string yi, string er, string san, string si, string wu, string time1, string time2);
        

    }
}

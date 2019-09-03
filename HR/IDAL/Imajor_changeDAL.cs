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
        List<major_changeModel> secondSelect();
        List<major_changeModel> thirdSelect();
        List<major_changeModel> fourSelect();
        List<major_changeModel> fiveSelect();
        List<major_changeModel> sixSelect();
        List<major_changeModel> sevenSelect();
        List<major_changeModel> eightSelect();
        List<major_changeModel> nineSelect();
        int Row();
        int pages();
        List<major_changeModel> fenye(int dqy);
        List<major_changeModel> fenye1(int dqy, major_changeModel mm, DateTime time1, DateTime time2);
        List<major_changeModel> fenye2(int dqy);

    }
}

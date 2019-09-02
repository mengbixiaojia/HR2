using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface Iengage_interviewBLL
    {
        int Add(engage_interviewModel st);
        int Del(engage_interviewModel st);
        int Update(engage_interviewModel st);
        List<engage_interviewModel> Select();
            List<engage_interviewModel> SelectBy(engage_interviewModel st);
    }
}

